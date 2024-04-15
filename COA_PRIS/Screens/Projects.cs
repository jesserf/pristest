﻿using COA_PRIS.Screens.Subscreens.Employees;
using COA_PRIS.Screens.Subscreens.Projects;
using COA_PRIS.Utilities;
using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COA_PRIS.Screens
{
    public partial class Projects : Form
    {
        private Form current_Form = null;
        private Tab_Manager tab_Manager;
        //private readonly Inactive_Submodule inactive_Submodule = new Inactive_Submodule();

        //private readonly ProjectLists Lists_Submodule = new ProjectLists();
        //private readonly ProjectCreate Create_Submodule = new ProjectCreate();
        //private readonly ProjectArchive Archive_Submodule = new ProjectArchive();
        private readonly Create_Project create_Project = new Create_Project();
        public Projects()
        {
            InitializeComponent();
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            tab_Manager = new Tab_Manager();
            foreach (Control control in nav_panel.Controls)
                if (control is GunaButton)
                    tab_Manager.Nav_buttons.Add(control);
            tab_Manager.set_Colors("#1B303B", "#C7C8CC");
            tab_Manager.active_Button(record_Btn, false);
            record_Btn.PerformClick();
        }
        private void button_Clicked(object sender, EventArgs e)
        {
            var button = (GunaButton)sender;
            switch (button.Name)
            {
                case "record_Btn":
                    current_Form = tab_Manager.switch_Form(create_Project, current_Form, container_Panel);
                    break;

            }
            tab_Manager.active_Button(button, false);
        }
    }
}
