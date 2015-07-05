using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using MSUtil;

namespace JamesRSkemp.LogParserPlus {
	public partial class MainForm : Form {
		public MainForm() {
			InitializeComponent();
		}

		//LogQueryClassClass LogParser;

		private void OnFormLoad(object sender, EventArgs e) {
			// Populates the file format combo box.
			GenerateFileFormats();

			//LogParser = new LogQueryClassClass();

		}

		private void OnLinkLabelCreatedByLinkClicked(object sender, LinkLabelLinkClickedEventArgs e) {
			//TODO: Automatically pull in version information.
			System.Diagnostics.Process.Start("http://jamesrskemp.com/apps/LogParserPlus/?0.3.1");
		}

		// Generate the listing of acceptable file formats.
		private void GenerateFileFormats() {
			FileFormatsComboBox.Items.Clear();
			FileFormatsComboBox.Items.Add("");
			FileFormatsComboBox.Items.Add("W3C Extended Log File Format");

		}

		private void SelectFileButton_Click(object sender, EventArgs e) {
			openFileDialog1.FileName = String.Empty;
			openFileDialog1.Multiselect = false;
			openFileDialog1.Title = "Select a file to parse";
			if (openFileDialog1.ShowDialog() == DialogResult.OK) {
				SelectedFileText.Text = openFileDialog1.FileName.ToString();
				if (FromFileRadio.Checked) {
					FromText.Text = "'" + openFileDialog1.FileName.ToString() + "'";
				} else if (FromDirExtRadio.Checked) {
					FromText.Text = "'" + Path.GetDirectoryName(openFileDialog1.FileName).ToString() + Path.DirectorySeparatorChar.ToString() + "*" + Path.GetExtension(openFileDialog1.FileName).ToString() + "'";
				} else if (FromDirRadio.Checked) {
					FromText.Text = "'" + Path.GetDirectoryName(openFileDialog1.FileName).ToString() + Path.DirectorySeparatorChar.ToString() + "*.*" + "'";
				}
				string filesName = openFileDialog1.FileName.ToString();
				filesName = filesName.Replace(Path.GetDirectoryName(filesName).ToString() + Path.DirectorySeparatorChar.ToString(), "");
				if (Path.GetExtension(filesName).ToString() == ".log" && (filesName.StartsWith("ex") || filesName.StartsWith("u_ex"))) {
					FileFormatsComboBox.SelectedItem = "W3C Extended Log File Format";
				}
			}
		}

		private void FromFileRadio_CheckedChanged(object sender, EventArgs e) {
			if (SelectedFileText.Text != String.Empty) {
				FromText.Text = "'" + SelectedFileText.Text + "'";
			}
		}

		private void FromDirRadio_CheckedChanged(object sender, EventArgs e) {
			if (SelectedFileText.Text != String.Empty) {
				FromText.Text = "'" + Path.GetDirectoryName(SelectedFileText.Text).ToString() + Path.DirectorySeparatorChar.ToString() + "*.*" + "'";
			}
		}

		private void FromDirExtRadio_CheckedChanged(object sender, EventArgs e) {
			if (SelectedFileText.Text != String.Empty) {
				FromText.Text = "'" + Path.GetDirectoryName(SelectedFileText.Text).ToString() + Path.DirectorySeparatorChar.ToString() + "*" + Path.GetExtension(SelectedFileText.Text).ToString() + "'";
			}
		}

		private void QueryButton_Click(object sender, EventArgs e) {
			// Validate we have at least a SELECT and a FROM.
			if (SelectText.Text.Trim() == String.Empty) {
				SelectText.Text = "*";
			}
			if (FromText.Text.Trim() == String.Empty) {
				SelectFileButton.PerformClick();
				if (FromText.Text.Trim() == String.Empty) {
					MessageBox.Show("You must have a FROM statement to continue." + Environment.NewLine + "Please select a file or enter the FROM manually.", "Query cancelled");
					return;
				}
			}
			PerformSQLQuery();

		}

		private void SelectStarButton_Click(object sender, EventArgs e) {
			// First select nothing ...
			SelectNoneButton.PerformClick();
			// then set the SELECT statement to '*'
			SelectText.Text = "*";
		}

		private void SelectAllButton_Click(object sender, EventArgs e) {
			// First select nothing ...
			SelectNoneButton.PerformClick();
			// then set the SELECT statement to everything in the list
			SelectText.Text = "";
			if (SelectListBox.Items.Count > 0) {
				for (int i = 0; i < SelectListBox.Items.Count; i++) {
					if (i != 0) {
						SelectText.Text += ", ";
					}
					SelectText.Text += SelectListBox.Items[i].ToString();
				}
			}
		}

		private void SelectSelectedButton_Click(object sender, EventArgs e) {
			// First select nothing ...
			SelectNoneButton.PerformClick();
			// then set the SELECT statement to everything in the list
			SelectText.Text = "";
			if (SelectListBox.SelectedItems.Count > 0) {
				for (int i = 0; i < SelectListBox.SelectedItems.Count; i++) {
					if (i != 0) {
						SelectText.Text += ", ";
					}
					SelectText.Text += SelectListBox.SelectedItems[i].ToString();
				}
			}
		}

		private void SelectNoneButton_Click(object sender, EventArgs e) {
			// Set the SELECT statement to nothing
			SelectText.Text = "TOP 0 ''";
			// Select nothing in the list.
			// Actually, keep what they've selected the same.
			//SelectListBox.SelectedItem = -1;
		}

		private void PopulateSelectListButton_Click(object sender, EventArgs e) {
			if (SelectedFileText.Text.Trim() == String.Empty) {
				SelectFileButton.PerformClick();
				if (FromText.Text.Trim() == String.Empty) {
					MessageBox.Show("You must have a FROM statement to continue." + Environment.NewLine + "Please select a file or enter the FROM manually.", "Query cancelled");
					return;
				}
			}

			// Use Log Parser to get a list of valid fields. Grab the top 5, as 1 might do strange things.
			ILogRecordset rs;
			if (FileFormatsComboBox.SelectedItem.ToString() == "W3C Extended Log File Format") {
				rs = GetRecordSet("SELECT TOP 5 * FROM " + FromText.Text, new COMIISW3CInputContextClassClass());
			} else {
				rs = GetRecordSet("SELECT TOP 5 * FROM " + FromText.Text, null);
			}

			//MessageBox.Show(rs.getColumnCount().ToString());

			SelectListBox.Items.Clear();
			for (int i = 0; i < rs.getColumnCount(); i++) {
				SelectListBox.Items.Add(rs.getColumnName(i));
			}

			if (FileFormatsComboBox.SelectedItem.ToString() == "W3C Extended Log File Format") {
				SelectListBox.Items.Add("TO_LOCALTIME(TO_TIMESTAMP(date, time)) AS LocalTime");
			}

		}

		private string BuildSqlQuery() {
			StringBuilder sqlQuery = new StringBuilder();

			if (SelectText.Text.Length > 0) {
				sqlQuery.Append("SELECT " + SelectText.Text.Trim());
			}
			if (UsingText.Text.Length > 0) {
				sqlQuery.Append(" USING " + UsingText.Text.Trim());
			}
			if (IntoText.Text.Length > 0) {
				sqlQuery.Append(" INTO " + IntoText.Text.Trim());
			}
			if (FromText.Text.Length > 0) {
				sqlQuery.Append(" FROM " + FromText.Text.Trim());
			}
			if (WhereText.Text.Length > 0) {
				sqlQuery.Append(" WHERE " + WhereText.Text.Trim());
			}
			if (GroupByText.Text.Length > 0) {
				sqlQuery.Append(" GROUP BY " + GroupByText.Text.Trim());
			}
			if (HavingText.Text.Length > 0) {
				sqlQuery.Append(" HAVING " + HavingText.Text.Trim());
			}
			if (OrderByText.Text.Length > 0) {
				sqlQuery.Append(" ORDER BY " + OrderByText.Text.Trim());
			}

			return sqlQuery.ToString();
		}

		private void PerformSQLQuery() {
			DateTime startTime = DateTime.Now;

			dataGridViewResults.DataSource = null;
			toolStripStatusLabelDataInfo.Text = "";

			QueryButton.Enabled = false;
			toolStripStatusLabelTimeTaken.Text = "Performing query.";

			string sqlQuery = BuildSqlQuery();

			textFinalQuery.Text = sqlQuery;

			// Perform the query requested
			ICOMIISW3CInputContext iisW3c = new COMIISW3CInputContextClassClass();

			int recordsCount = GetRecordCount(FromText.Text.Trim(), iisW3c);

			if (recordsCount > 0) {
				toolStripProgressBar.Maximum = recordsCount;
				toolStripProgressBar.Value = 0;

				ILogRecordset rs = GetRecordSet(sqlQuery.ToString(), iisW3c);

				ILogRecord rcd;

				DataTable table = new DataTable();

				if (!rs.atEnd()) {
					for (int i = 0; i < rs.getColumnCount(); i++) {
						table.Columns.Add(rs.getColumnName(i), Type.GetType("System.String"));
					}
				}

				DataRow row;

				//textScratchPad.Text = "";

				int currentRecord = 0;

				while (!rs.atEnd()) {
					currentRecord++;
					rcd = rs.getRecord();
					row = table.NewRow();
					for (int i = 0; i < rs.getColumnCount(); i++) {
						row[i] = rcd.getValue(i).ToString();
					}
					table.Rows.Add(row);
					//textBox1.Text += rcd.getValue("cs-uri-stem").ToString() + System.Environment.NewLine;
					rs.moveNext();
					if (currentRecord <= toolStripProgressBar.Maximum) {
						toolStripProgressBar.Value = currentRecord;
					} else {
						toolStripProgressBar.Value = toolStripProgressBar.Maximum;
					}
				}

				rs.close();

				dataGridViewResults.DataSource = table;

				toolStripStatusLabelDataInfo.Text = "Records returned: " + table.Rows.Count.ToString();
				toolStripProgressBar.Value = 0;

			} else {
				MessageBox.Show("No records would be returned by your query.");
			}

			DateTime endTime = DateTime.Now;

			toolStripStatusLabelTimeTaken.Text = "";
			toolStripStatusLabelTimeTaken.Text += "Time taken: " + endTime.Subtract(startTime).ToString();
			/*
			ICOMDataGridOutputContext dataGrid = new COMDataGridOutputContextClassClass();

			LogParser.ExecuteBatch("SELECT TOP 10 * FROM " + FromText.Text + "", iisW3c, dataGrid);
			*/
			/*
			ICOMW3COutputContext w3cOutput = new COMW3COutputContextClassClass();

			LogParser.ExecuteBatch("SELECT TOP 10 * FROM '" + FromText.Text + "'", iisW3c, w3cOutput);
			*/
			QueryButton.Enabled = true;
		}

		private void PerformRecordCount_Click(object sender, EventArgs e) {
			toolStripStatusLabelDataInfo.Text = "";
			if (FromText.Text.Trim() == String.Empty) {
				SelectFileButton.PerformClick();
				if (FromText.Text.Trim() == String.Empty) {
					MessageBox.Show("You must have a FROM statement to continue." + Environment.NewLine + "Please select a file or enter the FROM manually.", "Query cancelled");
					return;
				}
			}

			PerformRecordCount.Enabled = false;

			ICOMIISW3CInputContext input = new COMIISW3CInputContextClassClass();

			toolStripStatusLabelDataInfo.Text = "There are " + GetRecordCount(FromText.Text, input).ToString() + " records to parse.";

			PerformRecordCount.Enabled = true;
		}

		private int GetRecordCount(string from, Object input) {
			string countQuery = "SELECT COUNT(*) FROM " + from;

			ILogRecordset returnedCount = GetRecordSet(countQuery, input);

			string returnedValue = "0";

			if (!returnedCount.atEnd()) {
				returnedValue = returnedCount.getRecord().getValue(0).ToString();
			}
			returnedCount.close();

			int recordsCount;
			int.TryParse(returnedValue, out recordsCount);

			return recordsCount;
		}

		/// <summary>
		/// Returns a set of records from a Log Parser query.
		/// </summary>
		/// <param name="query">The full query to perform.</param>
		/// <param name="input">Input file format.</param>
		/// <returns>Record set from Log Parser.</returns>
		private ILogRecordset GetRecordSet(string query, Object input) {
			LogQueryClassClass logParser = new LogQueryClassClass();

			ILogRecordset rs;
			try {
				rs = logParser.Execute(query, input);
			} catch (FileNotFoundException) {
				MessageBox.Show("The FROM field is invalid. Please verify that the file(s) you wish to parse is entered correctly.");
				rs = logParser.Execute("SELECT TOP 0 '' FROM *.*", input);
			} catch (Exception ex) {
				MessageBox.Show(ex.Message);
				MessageBox.Show(ex.GetType().ToString());
				rs = logParser.Execute("SELECT TOP 0 '' FROM *.*", input);
			}

			if (logParser != null) {
				System.Runtime.InteropServices.Marshal.ReleaseComObject(logParser);
				logParser = null;
			}

			return rs;
		}

	}
}
