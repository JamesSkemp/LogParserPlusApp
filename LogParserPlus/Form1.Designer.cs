namespace JamesRSkemp.LogParserPlus {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.SelectLabel = new System.Windows.Forms.Label();
			this.UsingLabel = new System.Windows.Forms.Label();
			this.IntoLabel = new System.Windows.Forms.Label();
			this.FromLabel = new System.Windows.Forms.Label();
			this.WhereLabel = new System.Windows.Forms.Label();
			this.GroupByLabel = new System.Windows.Forms.Label();
			this.HavingLabel = new System.Windows.Forms.Label();
			this.OrderByLabel = new System.Windows.Forms.Label();
			this.SelectText = new System.Windows.Forms.TextBox();
			this.UsingText = new System.Windows.Forms.TextBox();
			this.IntoText = new System.Windows.Forms.TextBox();
			this.FromText = new System.Windows.Forms.TextBox();
			this.WhereText = new System.Windows.Forms.TextBox();
			this.GroupByText = new System.Windows.Forms.TextBox();
			this.HavingText = new System.Windows.Forms.TextBox();
			this.OrderByText = new System.Windows.Forms.TextBox();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.SelectFileButton = new System.Windows.Forms.Button();
			this.SelectedFileText = new System.Windows.Forms.TextBox();
			this.FromFileRadio = new System.Windows.Forms.RadioButton();
			this.FromDirExtRadio = new System.Windows.Forms.RadioButton();
			this.FromDirRadio = new System.Windows.Forms.RadioButton();
			this.FromOptionGroup = new System.Windows.Forms.GroupBox();
			this.QueryButton = new System.Windows.Forms.Button();
			this.SelectListBox = new System.Windows.Forms.ListBox();
			this.SelectStarButton = new System.Windows.Forms.Button();
			this.SelectAllButton = new System.Windows.Forms.Button();
			this.SelectNoneButton = new System.Windows.Forms.Button();
			this.PopulateSelectListButton = new System.Windows.Forms.Button();
			this.FormatLabel = new System.Windows.Forms.Label();
			this.FileFormatsComboBox = new System.Windows.Forms.ComboBox();
			this.textScratchPad = new System.Windows.Forms.TextBox();
			this.dataGridViewResults = new System.Windows.Forms.DataGridView();
			this.SelectSelectedButton = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelTimeTaken = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelDataInfo = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
			this.PerformRecordCount = new System.Windows.Forms.Button();
			this.linkLabelCreatedBy = new System.Windows.Forms.LinkLabel();
			this.textFinalQuery = new System.Windows.Forms.TextBox();
			this.labelFinalQuery = new System.Windows.Forms.Label();
			this.FromOptionGroup.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// SelectLabel
			// 
			this.SelectLabel.AutoSize = true;
			this.SelectLabel.Location = new System.Drawing.Point(52, 70);
			this.SelectLabel.Name = "SelectLabel";
			this.SelectLabel.Size = new System.Drawing.Size(48, 13);
			this.SelectLabel.TabIndex = 0;
			this.SelectLabel.Text = "SELECT";
			// 
			// UsingLabel
			// 
			this.UsingLabel.AutoSize = true;
			this.UsingLabel.Location = new System.Drawing.Point(59, 116);
			this.UsingLabel.Name = "UsingLabel";
			this.UsingLabel.Size = new System.Drawing.Size(41, 13);
			this.UsingLabel.TabIndex = 1;
			this.UsingLabel.Text = "USING";
			// 
			// IntoLabel
			// 
			this.IntoLabel.AutoSize = true;
			this.IntoLabel.Location = new System.Drawing.Point(67, 162);
			this.IntoLabel.Name = "IntoLabel";
			this.IntoLabel.Size = new System.Drawing.Size(33, 13);
			this.IntoLabel.TabIndex = 2;
			this.IntoLabel.Text = "INTO";
			// 
			// FromLabel
			// 
			this.FromLabel.AutoSize = true;
			this.FromLabel.Location = new System.Drawing.Point(62, 208);
			this.FromLabel.Name = "FromLabel";
			this.FromLabel.Size = new System.Drawing.Size(38, 13);
			this.FromLabel.TabIndex = 3;
			this.FromLabel.Text = "FROM";
			// 
			// WhereLabel
			// 
			this.WhereLabel.AutoSize = true;
			this.WhereLabel.Location = new System.Drawing.Point(52, 254);
			this.WhereLabel.Name = "WhereLabel";
			this.WhereLabel.Size = new System.Drawing.Size(48, 13);
			this.WhereLabel.TabIndex = 4;
			this.WhereLabel.Text = "WHERE";
			// 
			// GroupByLabel
			// 
			this.GroupByLabel.AutoSize = true;
			this.GroupByLabel.Location = new System.Drawing.Point(37, 300);
			this.GroupByLabel.Name = "GroupByLabel";
			this.GroupByLabel.Size = new System.Drawing.Size(63, 13);
			this.GroupByLabel.TabIndex = 5;
			this.GroupByLabel.Text = "GROUP BY";
			// 
			// HavingLabel
			// 
			this.HavingLabel.AutoSize = true;
			this.HavingLabel.Location = new System.Drawing.Point(52, 346);
			this.HavingLabel.Name = "HavingLabel";
			this.HavingLabel.Size = new System.Drawing.Size(48, 13);
			this.HavingLabel.TabIndex = 6;
			this.HavingLabel.Text = "HAVING";
			// 
			// OrderByLabel
			// 
			this.OrderByLabel.AutoSize = true;
			this.OrderByLabel.Location = new System.Drawing.Point(37, 392);
			this.OrderByLabel.Name = "OrderByLabel";
			this.OrderByLabel.Size = new System.Drawing.Size(63, 13);
			this.OrderByLabel.TabIndex = 7;
			this.OrderByLabel.Text = "ORDER BY";
			// 
			// SelectText
			// 
			this.SelectText.Location = new System.Drawing.Point(106, 67);
			this.SelectText.Multiline = true;
			this.SelectText.Name = "SelectText";
			this.SelectText.Size = new System.Drawing.Size(300, 40);
			this.SelectText.TabIndex = 8;
			// 
			// UsingText
			// 
			this.UsingText.Location = new System.Drawing.Point(106, 113);
			this.UsingText.Multiline = true;
			this.UsingText.Name = "UsingText";
			this.UsingText.Size = new System.Drawing.Size(300, 40);
			this.UsingText.TabIndex = 9;
			// 
			// IntoText
			// 
			this.IntoText.Location = new System.Drawing.Point(106, 159);
			this.IntoText.Multiline = true;
			this.IntoText.Name = "IntoText";
			this.IntoText.Size = new System.Drawing.Size(300, 40);
			this.IntoText.TabIndex = 10;
			// 
			// FromText
			// 
			this.FromText.Location = new System.Drawing.Point(106, 205);
			this.FromText.Multiline = true;
			this.FromText.Name = "FromText";
			this.FromText.Size = new System.Drawing.Size(300, 40);
			this.FromText.TabIndex = 11;
			// 
			// WhereText
			// 
			this.WhereText.Location = new System.Drawing.Point(106, 251);
			this.WhereText.Multiline = true;
			this.WhereText.Name = "WhereText";
			this.WhereText.Size = new System.Drawing.Size(300, 40);
			this.WhereText.TabIndex = 12;
			// 
			// GroupByText
			// 
			this.GroupByText.Location = new System.Drawing.Point(106, 297);
			this.GroupByText.Multiline = true;
			this.GroupByText.Name = "GroupByText";
			this.GroupByText.Size = new System.Drawing.Size(300, 40);
			this.GroupByText.TabIndex = 13;
			// 
			// HavingText
			// 
			this.HavingText.Location = new System.Drawing.Point(106, 343);
			this.HavingText.Multiline = true;
			this.HavingText.Name = "HavingText";
			this.HavingText.Size = new System.Drawing.Size(300, 40);
			this.HavingText.TabIndex = 14;
			// 
			// OrderByText
			// 
			this.OrderByText.Location = new System.Drawing.Point(106, 389);
			this.OrderByText.Multiline = true;
			this.OrderByText.Name = "OrderByText";
			this.OrderByText.Size = new System.Drawing.Size(300, 40);
			this.OrderByText.TabIndex = 15;
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// SelectFileButton
			// 
			this.SelectFileButton.Location = new System.Drawing.Point(25, 5);
			this.SelectFileButton.Name = "SelectFileButton";
			this.SelectFileButton.Size = new System.Drawing.Size(75, 23);
			this.SelectFileButton.TabIndex = 16;
			this.SelectFileButton.Text = "Select a file";
			this.SelectFileButton.UseVisualStyleBackColor = true;
			this.SelectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
			// 
			// SelectedFileText
			// 
			this.SelectedFileText.Enabled = false;
			this.SelectedFileText.Location = new System.Drawing.Point(106, 8);
			this.SelectedFileText.Name = "SelectedFileText";
			this.SelectedFileText.Size = new System.Drawing.Size(300, 20);
			this.SelectedFileText.TabIndex = 17;
			// 
			// FromFileRadio
			// 
			this.FromFileRadio.AutoSize = true;
			this.FromFileRadio.Checked = true;
			this.FromFileRadio.Location = new System.Drawing.Point(6, 19);
			this.FromFileRadio.Name = "FromFileRadio";
			this.FromFileRadio.Size = new System.Drawing.Size(57, 17);
			this.FromFileRadio.TabIndex = 18;
			this.FromFileRadio.TabStop = true;
			this.FromFileRadio.Text = "this file";
			this.FromFileRadio.UseVisualStyleBackColor = true;
			this.FromFileRadio.CheckedChanged += new System.EventHandler(this.FromFileRadio_CheckedChanged);
			// 
			// FromDirExtRadio
			// 
			this.FromDirExtRadio.AutoSize = true;
			this.FromDirExtRadio.Location = new System.Drawing.Point(6, 42);
			this.FromDirExtRadio.Name = "FromDirExtRadio";
			this.FromDirExtRadio.Size = new System.Drawing.Size(172, 17);
			this.FromDirExtRadio.TabIndex = 19;
			this.FromDirExtRadio.Text = "this directory and this extension";
			this.FromDirExtRadio.UseVisualStyleBackColor = true;
			this.FromDirExtRadio.CheckedChanged += new System.EventHandler(this.FromDirExtRadio_CheckedChanged);
			// 
			// FromDirRadio
			// 
			this.FromDirRadio.AutoSize = true;
			this.FromDirRadio.Location = new System.Drawing.Point(97, 19);
			this.FromDirRadio.Name = "FromDirRadio";
			this.FromDirRadio.Size = new System.Drawing.Size(84, 17);
			this.FromDirRadio.TabIndex = 20;
			this.FromDirRadio.Text = "this directory";
			this.FromDirRadio.UseVisualStyleBackColor = true;
			this.FromDirRadio.CheckedChanged += new System.EventHandler(this.FromDirRadio_CheckedChanged);
			// 
			// FromOptionGroup
			// 
			this.FromOptionGroup.Controls.Add(this.FromFileRadio);
			this.FromOptionGroup.Controls.Add(this.FromDirRadio);
			this.FromOptionGroup.Controls.Add(this.FromDirExtRadio);
			this.FromOptionGroup.Location = new System.Drawing.Point(412, 190);
			this.FromOptionGroup.Name = "FromOptionGroup";
			this.FromOptionGroup.Size = new System.Drawing.Size(200, 71);
			this.FromOptionGroup.TabIndex = 21;
			this.FromOptionGroup.TabStop = false;
			this.FromOptionGroup.Text = "FROM options";
			// 
			// QueryButton
			// 
			this.QueryButton.Location = new System.Drawing.Point(316, 461);
			this.QueryButton.Name = "QueryButton";
			this.QueryButton.Size = new System.Drawing.Size(90, 23);
			this.QueryButton.TabIndex = 22;
			this.QueryButton.Text = "Perform query";
			this.QueryButton.UseVisualStyleBackColor = true;
			this.QueryButton.Click += new System.EventHandler(this.QueryButton_Click);
			// 
			// SelectListBox
			// 
			this.SelectListBox.FormattingEnabled = true;
			this.SelectListBox.Location = new System.Drawing.Point(412, 32);
			this.SelectListBox.Name = "SelectListBox";
			this.SelectListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.SelectListBox.Size = new System.Drawing.Size(132, 134);
			this.SelectListBox.TabIndex = 23;
			// 
			// SelectStarButton
			// 
			this.SelectStarButton.Location = new System.Drawing.Point(550, 32);
			this.SelectStarButton.Name = "SelectStarButton";
			this.SelectStarButton.Size = new System.Drawing.Size(100, 23);
			this.SelectStarButton.TabIndex = 24;
			this.SelectStarButton.Text = "set to *";
			this.SelectStarButton.UseVisualStyleBackColor = true;
			this.SelectStarButton.Click += new System.EventHandler(this.SelectStarButton_Click);
			// 
			// SelectAllButton
			// 
			this.SelectAllButton.Location = new System.Drawing.Point(550, 61);
			this.SelectAllButton.Name = "SelectAllButton";
			this.SelectAllButton.Size = new System.Drawing.Size(100, 23);
			this.SelectAllButton.TabIndex = 25;
			this.SelectAllButton.Text = "set to all";
			this.SelectAllButton.UseVisualStyleBackColor = true;
			this.SelectAllButton.Click += new System.EventHandler(this.SelectAllButton_Click);
			// 
			// SelectNoneButton
			// 
			this.SelectNoneButton.Location = new System.Drawing.Point(550, 119);
			this.SelectNoneButton.Name = "SelectNoneButton";
			this.SelectNoneButton.Size = new System.Drawing.Size(100, 23);
			this.SelectNoneButton.TabIndex = 26;
			this.SelectNoneButton.Text = "set to none";
			this.SelectNoneButton.UseVisualStyleBackColor = true;
			this.SelectNoneButton.Click += new System.EventHandler(this.SelectNoneButton_Click);
			// 
			// PopulateSelectListButton
			// 
			this.PopulateSelectListButton.Location = new System.Drawing.Point(412, 6);
			this.PopulateSelectListButton.Name = "PopulateSelectListButton";
			this.PopulateSelectListButton.Size = new System.Drawing.Size(150, 23);
			this.PopulateSelectListButton.TabIndex = 27;
			this.PopulateSelectListButton.Text = "Populate/refresh field listing";
			this.PopulateSelectListButton.UseVisualStyleBackColor = true;
			this.PopulateSelectListButton.Click += new System.EventHandler(this.PopulateSelectListButton_Click);
			// 
			// FormatLabel
			// 
			this.FormatLabel.AutoSize = true;
			this.FormatLabel.Location = new System.Drawing.Point(21, 43);
			this.FormatLabel.Name = "FormatLabel";
			this.FormatLabel.Size = new System.Drawing.Size(79, 13);
			this.FormatLabel.TabIndex = 28;
			this.FormatLabel.Text = "Input file format";
			// 
			// FileFormatsComboBox
			// 
			this.FileFormatsComboBox.FormattingEnabled = true;
			this.FileFormatsComboBox.Location = new System.Drawing.Point(106, 40);
			this.FileFormatsComboBox.Name = "FileFormatsComboBox";
			this.FileFormatsComboBox.Size = new System.Drawing.Size(300, 21);
			this.FileFormatsComboBox.TabIndex = 29;
			// 
			// textScratchPad
			// 
			this.textScratchPad.Location = new System.Drawing.Point(412, 267);
			this.textScratchPad.Multiline = true;
			this.textScratchPad.Name = "textScratchPad";
			this.textScratchPad.Size = new System.Drawing.Size(238, 162);
			this.textScratchPad.TabIndex = 30;
			// 
			// dataGridViewResults
			// 
			this.dataGridViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
						| System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewResults.Location = new System.Drawing.Point(12, 490);
			this.dataGridViewResults.Name = "dataGridViewResults";
			this.dataGridViewResults.Size = new System.Drawing.Size(638, 181);
			this.dataGridViewResults.TabIndex = 31;
			// 
			// SelectSelectedButton
			// 
			this.SelectSelectedButton.Location = new System.Drawing.Point(550, 90);
			this.SelectSelectedButton.Name = "SelectSelectedButton";
			this.SelectSelectedButton.Size = new System.Drawing.Size(100, 23);
			this.SelectSelectedButton.TabIndex = 32;
			this.SelectSelectedButton.Text = "set to selected";
			this.SelectSelectedButton.UseVisualStyleBackColor = true;
			this.SelectSelectedButton.Click += new System.EventHandler(this.SelectSelectedButton_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelTimeTaken,
            this.toolStripStatusLabelDataInfo,
            this.toolStripProgressBar});
			this.statusStrip1.Location = new System.Drawing.Point(0, 674);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(662, 22);
			this.statusStrip1.TabIndex = 33;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabelTimeTaken
			// 
			this.toolStripStatusLabelTimeTaken.Name = "toolStripStatusLabelTimeTaken";
			this.toolStripStatusLabelTimeTaken.Size = new System.Drawing.Size(0, 17);
			// 
			// toolStripStatusLabelDataInfo
			// 
			this.toolStripStatusLabelDataInfo.Name = "toolStripStatusLabelDataInfo";
			this.toolStripStatusLabelDataInfo.Size = new System.Drawing.Size(545, 17);
			this.toolStripStatusLabelDataInfo.Spring = true;
			this.toolStripStatusLabelDataInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// toolStripProgressBar
			// 
			this.toolStripProgressBar.Name = "toolStripProgressBar";
			this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
			// 
			// PerformRecordCount
			// 
			this.PerformRecordCount.Location = new System.Drawing.Point(412, 461);
			this.PerformRecordCount.Name = "PerformRecordCount";
			this.PerformRecordCount.Size = new System.Drawing.Size(98, 23);
			this.PerformRecordCount.TabIndex = 34;
			this.PerformRecordCount.Text = "Get quick count";
			this.PerformRecordCount.UseVisualStyleBackColor = true;
			this.PerformRecordCount.Click += new System.EventHandler(this.PerformRecordCount_Click);
			// 
			// linkLabelCreatedBy
			// 
			this.linkLabelCreatedBy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.linkLabelCreatedBy.AutoSize = true;
			this.linkLabelCreatedBy.Location = new System.Drawing.Point(523, 466);
			this.linkLabelCreatedBy.Name = "linkLabelCreatedBy";
			this.linkLabelCreatedBy.Size = new System.Drawing.Size(127, 13);
			this.linkLabelCreatedBy.TabIndex = 35;
			this.linkLabelCreatedBy.TabStop = true;
			this.linkLabelCreatedBy.Text = "Created by James Skemp";
			this.linkLabelCreatedBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.linkLabelCreatedBy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnLinkLabelCreatedByLinkClicked);
			// 
			// textFinalQuery
			// 
			this.textFinalQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
						| System.Windows.Forms.AnchorStyles.Right)));
			this.textFinalQuery.Location = new System.Drawing.Point(106, 435);
			this.textFinalQuery.Name = "textFinalQuery";
			this.textFinalQuery.Size = new System.Drawing.Size(544, 20);
			this.textFinalQuery.TabIndex = 36;
			// 
			// labelFinalQuery
			// 
			this.labelFinalQuery.AutoSize = true;
			this.labelFinalQuery.Location = new System.Drawing.Point(42, 438);
			this.labelFinalQuery.Name = "labelFinalQuery";
			this.labelFinalQuery.Size = new System.Drawing.Size(58, 13);
			this.labelFinalQuery.TabIndex = 37;
			this.labelFinalQuery.Text = "Final query";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(662, 696);
			this.Controls.Add(this.labelFinalQuery);
			this.Controls.Add(this.textFinalQuery);
			this.Controls.Add(this.linkLabelCreatedBy);
			this.Controls.Add(this.PerformRecordCount);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.SelectSelectedButton);
			this.Controls.Add(this.dataGridViewResults);
			this.Controls.Add(this.textScratchPad);
			this.Controls.Add(this.FileFormatsComboBox);
			this.Controls.Add(this.FormatLabel);
			this.Controls.Add(this.PopulateSelectListButton);
			this.Controls.Add(this.SelectNoneButton);
			this.Controls.Add(this.SelectAllButton);
			this.Controls.Add(this.SelectStarButton);
			this.Controls.Add(this.SelectListBox);
			this.Controls.Add(this.QueryButton);
			this.Controls.Add(this.FromOptionGroup);
			this.Controls.Add(this.SelectedFileText);
			this.Controls.Add(this.SelectFileButton);
			this.Controls.Add(this.OrderByText);
			this.Controls.Add(this.HavingText);
			this.Controls.Add(this.GroupByText);
			this.Controls.Add(this.WhereText);
			this.Controls.Add(this.FromText);
			this.Controls.Add(this.IntoText);
			this.Controls.Add(this.UsingText);
			this.Controls.Add(this.SelectText);
			this.Controls.Add(this.OrderByLabel);
			this.Controls.Add(this.HavingLabel);
			this.Controls.Add(this.GroupByLabel);
			this.Controls.Add(this.WhereLabel);
			this.Controls.Add(this.FromLabel);
			this.Controls.Add(this.IntoLabel);
			this.Controls.Add(this.UsingLabel);
			this.Controls.Add(this.SelectLabel);
			this.Name = "MainForm";
			this.Text = "Log Parser Plus 0.3.1 BETA";
			this.Load += new System.EventHandler(this.OnFormLoad);
			this.FromOptionGroup.ResumeLayout(false);
			this.FromOptionGroup.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResults)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label SelectLabel;
		private System.Windows.Forms.Label UsingLabel;
		private System.Windows.Forms.Label IntoLabel;
		private System.Windows.Forms.Label FromLabel;
		private System.Windows.Forms.Label WhereLabel;
		private System.Windows.Forms.Label GroupByLabel;
		private System.Windows.Forms.Label HavingLabel;
		private System.Windows.Forms.Label OrderByLabel;
		private System.Windows.Forms.TextBox SelectText;
		private System.Windows.Forms.TextBox UsingText;
		private System.Windows.Forms.TextBox IntoText;
		private System.Windows.Forms.TextBox FromText;
		private System.Windows.Forms.TextBox WhereText;
		private System.Windows.Forms.TextBox GroupByText;
		private System.Windows.Forms.TextBox HavingText;
		private System.Windows.Forms.TextBox OrderByText;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button SelectFileButton;
		private System.Windows.Forms.TextBox SelectedFileText;
		private System.Windows.Forms.RadioButton FromFileRadio;
		private System.Windows.Forms.RadioButton FromDirExtRadio;
		private System.Windows.Forms.RadioButton FromDirRadio;
		private System.Windows.Forms.GroupBox FromOptionGroup;
		private System.Windows.Forms.Button QueryButton;
		private System.Windows.Forms.ListBox SelectListBox;
		private System.Windows.Forms.Button SelectStarButton;
		private System.Windows.Forms.Button SelectAllButton;
		private System.Windows.Forms.Button SelectNoneButton;
		private System.Windows.Forms.Button PopulateSelectListButton;
		private System.Windows.Forms.Label FormatLabel;
		private System.Windows.Forms.ComboBox FileFormatsComboBox;
		private System.Windows.Forms.TextBox textScratchPad;
		private System.Windows.Forms.DataGridView dataGridViewResults;
		private System.Windows.Forms.Button SelectSelectedButton;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelTimeTaken;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelDataInfo;
		private System.Windows.Forms.Button PerformRecordCount;
		private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
		private System.Windows.Forms.LinkLabel linkLabelCreatedBy;
		private System.Windows.Forms.TextBox textFinalQuery;
		private System.Windows.Forms.Label labelFinalQuery;
	}
}

