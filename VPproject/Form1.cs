using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VPproject
{
    public partial class Form1 : Form
    {
        string path = "";
        public Form1()
        {
            InitializeComponent();
            welcome_panel.Visible = true;
            main_pane.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            welcome_panel.Visible = false;
            main_pane.Visible = true;
        }

        private void browse_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                main_pb.Image = new Bitmap(open.FileName);
                browse_tb.Text = open.FileName;
                path = open.FileName;
                main_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}
