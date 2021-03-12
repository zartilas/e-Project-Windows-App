using e_Projects.Classes;
using System;
using System.Windows.Forms;

namespace e_Projects.Forms.Admin
{
    public partial class Form_Admin_Show_Team_Students_Info : Form
    {
        private String student_ids;

        public Form_Admin_Show_Team_Students_Info(String student_ids)
        {
            InitializeComponent();
            this.student_ids = student_ids;

            ControlsDesigner controlsDesigner = new ControlsDesigner();
            controlsDesigner.Create_Students_Info_Controls(this, panel_Container, student_ids);
        }

        private void Form_Admin_Show_Team_Students_Info_Load(object sender, EventArgs e)
        {
        }
    }
}