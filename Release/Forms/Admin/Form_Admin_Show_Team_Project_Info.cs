using e_Projects.Classes;
using System.Windows.Forms;

namespace e_Projects.Forms.Admin
{
    public partial class Form_Admin_Show_Team_Project_Info : Form
    {
        private int project_id;

        public Form_Admin_Show_Team_Project_Info(int project_id)
        {
            InitializeComponent();
            this.project_id = project_id;

            ControlsDesigner controlsDesigner = new ControlsDesigner();
            controlsDesigner.Create_Project_Info_Controls(this, panel_Container, imageList_Buttons, project_id);
        }

        private void Form_Admin_Show_Team_Project_Info_Load(object sender, System.EventArgs e)
        {
        }
    }
}