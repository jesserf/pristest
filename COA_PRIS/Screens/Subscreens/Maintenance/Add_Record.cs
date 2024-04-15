﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using COA_PRIS.UserControlUtil;
using COA_PRIS.Utilities;
using COA_PRIS.Screens;
using COA_PRIS.UserControlUtil.PRIS_UserControl;

namespace COA_PRIS.Screens.Subscreens.Maintenance
{
    public partial class Add_Record : Form
    {
        private readonly Database_Manager database_Manager = new Database_Manager();
        private readonly Validator validator = new Validator();
        private readonly Util util = new Util();

        private string Insert_Query { get; }
        private string Table { get; }

        private bool is_ClosingProgrammatically = false;

        public event Action callback;

        public Add_Record(UserControl[] controls, string insertQuery, string table)
        {
            InitializeComponent();
            InitializeControls(controls);

            Insert_Query = insertQuery;
            Table = table;
        }

        private void Add_Agency_Load(object sender, EventArgs e)
        {
            code_Title.Text = util.generate_ID(Table);
        }

        private void InitializeControls(UserControl[] controls)
        {
            control_Panel.SuspendLayout();
            foreach (var control in controls)
            {
                control_Panel.Controls.Add(control);
                control.Size = new Size(control_Panel.Width, control.Height);
            }
            control_Panel.ResumeLayout(false);
            control_Panel.PerformLayout();
        }

        private void save_Btn_Click(object sender, EventArgs e)
        {
            int ret = 0;
            if (validator.Required_TextBox(control_Panel, error_provider, error_Message))
            {

                // Adds the required values inside of a list.
                var values = new List<string> { code_Title.Text };

                // Loops through the controls and add its value to the  list.
                foreach (UserControl control in control_Panel.Controls) 
                {
                    if (control is IPRIS_UserControl)
                    {
                        var user_control = (IPRIS_UserControl)control;
                        values.Add(user_control.Value?.Trim() ?? "");
                    }
                }

                // Adds the active account
                values.Add("james");

                
                var entries = new List<List<string>> { values };

                using (database_Manager) 
                    ret = database_Manager.ExecuteNonQuery(util.generate_Query(entries, Insert_Query));
            }

            if (ret == 1) 
            {
                if (MessageBox.Show($"{code_Title.Text} is successfully added.", "New Record Added", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                {
                    is_ClosingProgrammatically = true; 
                    Close();
                    callback?.Invoke();
                }
            }
            
        }

        private void Add_Record_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!is_ClosingProgrammatically)
            {
                if (e.CloseReason == CloseReason.UserClosing)
                    e.Cancel = MessageBox.Show("Are you sure you want to cancel?", "Cancel Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) == DialogResult.No;

                else if (e.CloseReason == CloseReason.WindowsShutDown)
                    Close();
            }
        }

        private void cancel_Btn_Click(object sender, EventArgs e)
        {
            is_ClosingProgrammatically = false;
            Close();
        }

    }
}