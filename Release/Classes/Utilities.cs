using System;
using System.Drawing;
using System.Windows.Forms;

namespace e_Projects.Classes
{
    internal class Utilities
    {
        // Control Designers
        public Label add_Numbering_Label(int num, int posX, int posY)
        {
            Label label = new Label();

            label.Name = "label_" + num;
            label.Text = num + ".";
            label.Location = new Point(posX, posY);
            label.AutoSize = true;

            return label;
        }

        public Label add_Label(string name, string text, int posX, int posY)
        {
            Label label = new Label();

            label.Name = name;
            label.Text = text;
            label.Location = new Point(posX, posY);
            label.AutoSize = true;

            return label;
        }

        public Label add_Label(string name, string text, int width, int height, int posX, int posY, string textAlign, bool auto_Size)
        {
            Label label = new Label();

            label.Name = name;
            label.Text = text;
            label.Location = new Point(posX, posY);
            label.AutoSize = auto_Size;
            label.Size = new Size(width, height);
            label.FlatStyle = FlatStyle.Flat;
            label.TextAlign = (ContentAlignment)Enum.Parse(typeof(ContentAlignment), textAlign);

            return label;
        }

        public Button add_Button(string name, int posX, int posY)
        {
            Button button = new Button();
            button.Name = name;
            button.Text = "";
            button.AutoSize = false;
            button.BackColor = Color.Transparent;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button.Size = new Size(27, 22);
            button.Cursor = Cursors.Hand;
            button.Location = new Point(posX, posY);

            return button;
        }

        public Button add_Button(string name, int posX, int posY, string hover_msg)
        {
            Button button = new Button();
            button.Name = name;
            button.Text = "";
            button.AutoSize = false;
            button.BackColor = Color.Transparent;
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button.FlatAppearance.MouseOverBackColor = Color.Transparent;
            ToolTip tooltip_button = new ToolTip();
            add_Tooltip(button, hover_msg);
            button.Size = new Size(27, 22);
            button.Cursor = Cursors.Hand;
            button.Location = new Point(posX, posY);

            return button;
        }

        public Panel add_Actions_Panel(string name, int width, int posX, int posY)
        {
            Panel mini_panel = new Panel();

            mini_panel.Name = name;
            mini_panel.Location = new Point(posX, posY);
            mini_panel.AutoSize = false;
            mini_panel.Name = name;
            mini_panel.Text = "";
            mini_panel.BackColor = Color.FromArgb(31, 64, 104);
            mini_panel.Size = new Size(width, 24);
            mini_panel.Location = new Point(posX, posY);

            return mini_panel;
        }

        public Panel add_Panel(string name, int width, int height, int posX, int posY)
        {
            Panel panel = new Panel();

            panel.Name = name;
            panel.AutoSize = false;
            panel.Name = name;
            panel.Text = "";
            panel.BackColor = Color.FromArgb(31, 64, 104);
            panel.Size = new Size(width, height);
            panel.Location = new Point(posX, posY);

            return panel;
        }

        public ToolTip add_Tooltip(Control control, string tooltip_msg)
        {
            ToolTip tooltip = new ToolTip();
            tooltip.SetToolTip(control, tooltip_msg);

            tooltip.ToolTipIcon = ToolTipIcon.Info;

            return tooltip;
        }

        public PictureBox add_PictureBox(string name, int width, int height, int posX, int posY)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = Properties.Resources.required;
            pictureBox.Name = name;
            pictureBox.Size = new Size(width, height);
            pictureBox.Location = new Point(posX, posY);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.BackColor = Color.Transparent;

            return pictureBox;
        }

        public TextBox add_TextBox(string name, int posX, int posY, int max_Length, bool shortcuts)
        {
            TextBox textBox = new TextBox();
            textBox.ForeColor = Color.White;
            textBox.BackColor = Color.FromArgb(15, 76, 117);
            textBox.Size = new Size(540, 30);
            textBox.Name = name;
            textBox.MaxLength = max_Length;
            textBox.Location = new Point(posX, posY);
            textBox.ScrollBars = ScrollBars.Horizontal;
            textBox.ShortcutsEnabled = shortcuts;

            return textBox;
        }

        public OpenFileDialog Open_ZIP_File_Dialog()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "ZIP Files (*.zip)|*.zip";
            openFileDialog.Title = "Επιλέξτε το αρχείο ZIP της εργασίας";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.DefaultExt = "zip";
            openFileDialog.CheckFileExists = true;
            openFileDialog.CheckPathExists = true;

            return openFileDialog;
        }

        public SaveFileDialog Save_ZIP_File_Dialog()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "ZIP File (*.zip)|*.zip";
            saveFileDialog.Title = "Αποθηκεύστε το αρχείο ZIP της ομάδας";
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.DefaultExt = "zip";
            saveFileDialog.CheckPathExists = true;

            return saveFileDialog;
        }

        public Control Find_Control(Control.ControlCollection controlCollection, string name)
        {
            foreach (Control control in controlCollection)
            {
                if (string.Equals(control.Name, name, StringComparison.OrdinalIgnoreCase))
                {
                    return control;
                }

                if (control.Controls.Count > 0)
                {
                    Control result = Find_Control(control.Controls, name);
                    if (result != null)
                    {
                        return result;
                    }
                }
            }

            return null;
        }
    }
}