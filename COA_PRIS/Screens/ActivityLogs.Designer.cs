﻿namespace COA_PRIS.Screens
{
    partial class ActivityLogs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActivityLogs));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pageCountTextbox = new Guna.UI.WinForms.GunaTextBox();
            this.gunaPanel4 = new Guna.UI.WinForms.GunaPanel();
            this.nextLogsBtn = new Guna.UI.WinForms.GunaButton();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.sortComboBox = new Guna.UI.WinForms.GunaComboBox();
            this.reportsButton = new Guna.UI.WinForms.GunaButton();
            this.searchBar1 = new COA_PRIS.UserControlUtil.SearchBar();
            this.dateFilter1 = new COA_PRIS.UserControlUtil.DateFilter();
            this.LogsTable = new Guna.UI.WinForms.GunaDataGridView();
            this.gunaPanel4.SuspendLayout();
            this.gunaPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogsTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pageCountTextbox
            // 
            this.pageCountTextbox.BackColor = System.Drawing.Color.White;
            this.pageCountTextbox.BaseColor = System.Drawing.Color.White;
            this.pageCountTextbox.BorderColor = System.Drawing.Color.White;
            this.pageCountTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.pageCountTextbox.FocusedBaseColor = System.Drawing.Color.White;
            this.pageCountTextbox.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.pageCountTextbox.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.pageCountTextbox.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pageCountTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.pageCountTextbox.Location = new System.Drawing.Point(809, 21);
            this.pageCountTextbox.Name = "pageCountTextbox";
            this.pageCountTextbox.PasswordChar = '\0';
            this.pageCountTextbox.SelectedText = "";
            this.pageCountTextbox.Size = new System.Drawing.Size(90, 30);
            this.pageCountTextbox.TabIndex = 2;
            this.pageCountTextbox.Text = "1";
            this.pageCountTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pageCountTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pageCountTextbox_KeyDown);
            // 
            // gunaPanel4
            // 
            this.gunaPanel4.BackColor = System.Drawing.Color.White;
            this.gunaPanel4.Controls.Add(this.pageCountTextbox);
            this.gunaPanel4.Controls.Add(this.nextLogsBtn);
            this.gunaPanel4.Controls.Add(this.gunaButton1);
            this.gunaPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gunaPanel4.Location = new System.Drawing.Point(0, 846);
            this.gunaPanel4.Name = "gunaPanel4";
            this.gunaPanel4.Size = new System.Drawing.Size(1603, 68);
            this.gunaPanel4.TabIndex = 6;
            // 
            // nextLogsBtn
            // 
            this.nextLogsBtn.AnimationHoverSpeed = 0.07F;
            this.nextLogsBtn.AnimationSpeed = 0.03F;
            this.nextLogsBtn.BackColor = System.Drawing.Color.Transparent;
            this.nextLogsBtn.BaseColor = System.Drawing.Color.White;
            this.nextLogsBtn.BorderColor = System.Drawing.Color.Black;
            this.nextLogsBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nextLogsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.nextLogsBtn.FocusedColor = System.Drawing.Color.Empty;
            this.nextLogsBtn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextLogsBtn.ForeColor = System.Drawing.Color.White;
            this.nextLogsBtn.Image = ((System.Drawing.Image)(resources.GetObject("nextLogsBtn.Image")));
            this.nextLogsBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.nextLogsBtn.Location = new System.Drawing.Point(892, 14);
            this.nextLogsBtn.Name = "nextLogsBtn";
            this.nextLogsBtn.OnHoverBaseColor = System.Drawing.Color.White;
            this.nextLogsBtn.OnHoverBorderColor = System.Drawing.Color.White;
            this.nextLogsBtn.OnHoverForeColor = System.Drawing.Color.White;
            this.nextLogsBtn.OnHoverImage = null;
            this.nextLogsBtn.OnPressedColor = System.Drawing.Color.White;
            this.nextLogsBtn.Size = new System.Drawing.Size(46, 42);
            this.nextLogsBtn.TabIndex = 1;
            this.nextLogsBtn.Text = ">";
            this.nextLogsBtn.Click += new System.EventHandler(this.gunaButton2_Click);
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BackColor = System.Drawing.Color.White;
            this.gunaButton1.BaseColor = System.Drawing.Color.White;
            this.gunaButton1.BorderColor = System.Drawing.Color.White;
            this.gunaButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.White;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = ((System.Drawing.Image)(resources.GetObject("gunaButton1.Image")));
            this.gunaButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.gunaButton1.Location = new System.Drawing.Point(760, 14);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.White;
            this.gunaButton1.Size = new System.Drawing.Size(46, 42);
            this.gunaButton1.TabIndex = 0;
            this.gunaButton1.Text = "<";
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPanel1.Controls.Add(this.tableLayoutPanel1);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(1603, 112);
            this.gunaPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.92614F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.07386F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 222F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.searchBar1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dateFilter1, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1603, 112);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.sortComboBox, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.reportsButton, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(1384, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel2.TabIndex = 7;
            // 
            // sortComboBox
            // 
            this.sortComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sortComboBox.BackColor = System.Drawing.Color.Transparent;
            this.sortComboBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.sortComboBox.BorderColor = System.Drawing.Color.Transparent;
            this.sortComboBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.FocusedColor = System.Drawing.Color.Empty;
            this.sortComboBox.Font = new System.Drawing.Font("Bahnschrift", 16.25F);
            this.sortComboBox.ForeColor = System.Drawing.Color.White;
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "User Name",
            "Activity"});
            this.sortComboBox.Location = new System.Drawing.Point(3, 53);
            this.sortComboBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 20);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.sortComboBox.OnHoverItemForeColor = System.Drawing.Color.White;
            this.sortComboBox.Radius = 12;
            this.sortComboBox.Size = new System.Drawing.Size(191, 35);
            this.sortComboBox.TabIndex = 2;
            this.sortComboBox.SelectedValueChanged += new System.EventHandler(this.sortComboBox_SelectedValueChanged);
            // 
            // reportsButton
            // 
            this.reportsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.reportsButton.AnimationHoverSpeed = 0.07F;
            this.reportsButton.AnimationSpeed = 0.03F;
            this.reportsButton.BackColor = System.Drawing.Color.Transparent;
            this.reportsButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(48)))), ((int)(((byte)(59)))));
            this.reportsButton.BorderColor = System.Drawing.Color.Black;
            this.reportsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportsButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.reportsButton.FocusedColor = System.Drawing.Color.Empty;
            this.reportsButton.Font = new System.Drawing.Font("Bahnschrift", 16.25F);
            this.reportsButton.ForeColor = System.Drawing.Color.White;
            this.reportsButton.Image = null;
            this.reportsButton.ImageSize = new System.Drawing.Size(20, 20);
            this.reportsButton.Location = new System.Drawing.Point(3, 12);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.reportsButton.OnHoverBorderColor = System.Drawing.Color.Black;
            this.reportsButton.OnHoverForeColor = System.Drawing.Color.White;
            this.reportsButton.OnHoverImage = null;
            this.reportsButton.OnPressedColor = System.Drawing.Color.Black;
            this.reportsButton.Radius = 12;
            this.reportsButton.Size = new System.Drawing.Size(188, 35);
            this.reportsButton.TabIndex = 4;
            this.reportsButton.Text = "Generate Report";
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // searchBar1
            // 
            this.searchBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.searchBar1.Location = new System.Drawing.Point(3, 66);
            this.searchBar1.Name = "searchBar1";
            this.searchBar1.Size = new System.Drawing.Size(554, 43);
            this.searchBar1.TabIndex = 3;
            this.searchBar1.TextChanged += new System.EventHandler(this.logsSearchBox_TextChanged);
            // 
            // dateFilter1
            // 
            this.dateFilter1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dateFilter1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.dateFilter1.BackColor = System.Drawing.Color.Transparent;
            this.dateFilter1.fromValue = new System.DateTime(2024, 4, 8, 10, 35, 15, 477);
            this.dateFilter1.Location = new System.Drawing.Point(582, 66);
            this.dateFilter1.Name = "dateFilter1";
            this.dateFilter1.Size = new System.Drawing.Size(656, 43);
            this.dateFilter1.TabIndex = 5;
            this.dateFilter1.toValue = new System.DateTime(2024, 4, 8, 10, 35, 15, 477);
            // 
            // LogsTable
            // 
            this.LogsTable.AllowUserToDeleteRows = false;
            this.LogsTable.AllowUserToResizeColumns = false;
            this.LogsTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.LogsTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LogsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LogsTable.BackgroundColor = System.Drawing.Color.White;
            this.LogsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogsTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LogsTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LogsTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.LogsTable.ColumnHeadersHeight = 20;
            this.LogsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LogsTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.LogsTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogsTable.EnableHeadersVisualStyles = false;
            this.LogsTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LogsTable.Location = new System.Drawing.Point(0, 112);
            this.LogsTable.Margin = new System.Windows.Forms.Padding(15);
            this.LogsTable.Name = "LogsTable";
            this.LogsTable.ReadOnly = true;
            this.LogsTable.RowHeadersVisible = false;
            this.LogsTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogsTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LogsTable.Size = new System.Drawing.Size(1603, 734);
            this.LogsTable.TabIndex = 1;
            this.LogsTable.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.LogsTable.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.LogsTable.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.LogsTable.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.LogsTable.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.LogsTable.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.LogsTable.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.LogsTable.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LogsTable.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.LogsTable.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.LogsTable.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.LogsTable.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.LogsTable.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LogsTable.ThemeStyle.HeaderStyle.Height = 20;
            this.LogsTable.ThemeStyle.ReadOnly = true;
            this.LogsTable.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.LogsTable.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.LogsTable.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.LogsTable.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.LogsTable.ThemeStyle.RowsStyle.Height = 22;
            this.LogsTable.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.LogsTable.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // ActivityLogs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1603, 914);
            this.Controls.Add(this.LogsTable);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaPanel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActivityLogs";
            this.Text = "LogsTab";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gunaPanel4.ResumeLayout(false);
            this.gunaPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogsTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private Guna.UI.WinForms.GunaButton nextLogsBtn;
        private Guna.UI.WinForms.GunaTextBox pageCountTextbox;
        private Guna.UI.WinForms.GunaPanel gunaPanel4;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaComboBox sortComboBox;
        private Guna.UI.WinForms.GunaDataGridView LogsTable;
        private UserControlUtil.SearchBar searchBar1;
        private Guna.UI.WinForms.GunaButton reportsButton;
        private UserControlUtil.DateFilter dateFilter1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}