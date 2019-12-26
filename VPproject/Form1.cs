using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using IronOcr;
using MySql.Data.MySqlClient;



namespace VPproject
{
    public partial class card_proj : Form
    {
        string con = "datasource=127.0.0.1;port=3306;username=root;password=1234";
        string query = "Insert into testdb1.student_data(student_id,student_name,student_program,student_age) Values ('01-241162-028','Usama Mansoor','BSE','18')";
    

        ProcessStartInfo startInfo;
        Capture cap;
        bool streaming;
        Stopwatch s = new Stopwatch();
        string path = "";
        private readonly string _tesseractExePath;
        private readonly string _language;
        Bitmap c;

        public card_proj()
        {
            InitializeComponent();
            MySqlConnection conDB = new MySqlConnection(con);
            MySqlCommand cmdDB = new MySqlCommand(query, conDB);
            MySqlDataReader myReader;

            conDB.Open();
           
            conDB.Close();

            startInfo = new ProcessStartInfo();
            startInfo.FileName = @"C:\Users\Hamza_PC\Downloads\VPProjectTest\ocrScript.py";


            welcome_panel.Visible = true;
            main_pane.Visible = false;
            log_pan.Visible = false;
            Font f = new Font("Corbel", 11, FontStyle.Bold);
            browse_btn.Font = f;
            button1.Font = f;
            perform_button.Font = f;
            capture_btn.Font = f;
            streamOnOff.Font = f;
            back_button.Font = f;
        }

        public card_proj(string tesseractDir, string language = "en", string dataDir = null)
        {

            
            // Tesseract checking
            _tesseractExePath = Path.Combine(tesseractDir, "tesseract.exe");
            _language = language;

            if (String.IsNullOrEmpty(dataDir))
                dataDir = Path.Combine(tesseractDir, "tessdata");

            Environment.SetEnvironmentVariable("TESSDATA_PREFIX", dataDir);
        }


    

        private void streamOnOff_Click(object sender, EventArgs e)
        {
            if (!streaming)
            {
                Application.Idle += streamProcess;

            }
            else
            {
                Application.Idle -= streamProcess;

            }

            streaming = !streaming;

        }

        private void streamProcess(object sender, System.EventArgs e)
        {
            var img = cap.QueryFrame().ToImage<Bgr, byte>();
            var bmp = img.ToBitmap();
            picStream.Image = bmp;
        }

        private void capture_btn_Click(object sender, EventArgs e)
        {
            var img = cap.QueryFrame().ToImage<Bgr, byte>();
            var bmp = img.ToBitmap();
            
            Bitmap c = new Bitmap(bmp);


            int width = c.Width;
            int height = c.Height;

            int i = 0;
            Color p;
            File.Delete(@"C:\Users\Hamza_PC\Downloads\VPProjectTest\abc.bmp");
            c.Save(@"C:\Users\Hamza_PC\Downloads\VPProjectTest\abc.bmp");
            startInfo.Arguments = @"C:\Users\Hamza_PC\Downloads\VPProjectTest\abc.bmp";
          
            int x, y;
            main_pb.Image = c;

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            log_pan.Visible = true;
        }



        private void browse_btn_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files (*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                startInfo.Arguments = open.FileName;
                Bitmap c = new Bitmap(open.FileName);
            

                int x, y;

                
                main_pb.Image = c;
                browse_tb.Text = open.FileName;
                path = open.FileName;
                main_pb.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }



        private void perform_button_Click(object sender, EventArgs e)
        {
            WaitForm please = new WaitForm();
            please.Visible = true;
            int count = 0;
            try
            {
                using (Process exeProcess = Process.Start(startInfo))
                {
                    exeProcess.WaitForExit();
                }
            }
            catch (Exception x)
            {

                MessageBox.Show(x.Message);
            }

            string text = File.ReadAllText(@"C:\Users\Hamza_PC\Downloads\VPProjectTest\test.txt", Encoding.UTF8);

            string search = "01-";
            string enrollment = "";
            int pos = text.IndexOf(search);
            if (pos > 0)
            {
                for (int a = pos; a < (pos + 13); a++)
                {
                    enrollment = enrollment + text[a];
                }
                enroll_box.Text = enrollment;
                name_box.Text = "";
                dept_box.Text = "";
                batch_box.Text = "";
                semester_box.Text = "";
                reg_box.Text = "";


                string query = "SELECT student_name,student_dept,student_semester,student_batch,student_registration FROM testdb1.student_data where student_id = '" + enrollment + "';";
                MySqlConnection conDB = new MySqlConnection(con);
                MySqlCommand cmdDB = new MySqlCommand(query, conDB);
                MySqlDataReader myReader;

                conDB.Open();
                myReader = cmdDB.ExecuteReader();

                while (myReader.Read())
                {
                    name_box.Text = myReader.GetString("student_name");
                    dept_box.Text = myReader.GetString("student_dept");
                    batch_box.Text = myReader.GetString("student_batch");
                    semester_box.Text = myReader.GetString("student_semester");
                    reg_box.Text = myReader.GetString("student_registration");

                    count++;
                }
                conDB.Close();

                if (count == 0)
                {
                    MessageBox.Show("User not found. Add by filling in details");
                    add_btn.Visible = true;

                }
            }
            else if (pos == -1)
            {
                MessageBox.Show("Error reading the imgage. Try again.");
            }
            please.Visible = false;
            if (browseCheck.Checked == true)
            {
               
                please.Visible = true;



                please.Visible = false;

            }
            else if (liveCheck.Checked == true)
            {
               // WaitForm please = new WaitForm();
                please.Visible = true;

                please.Visible = false;
            }
        }

        private void main_pane_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            tb_un.Text = "";
            tb_pw.Text = "";
            main_pane.Visible = false;
            welcome_panel.Visible = true;
        }

        private void streamOnOff_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(streamOnOff, "Starts live picture");
        }

        private void capture_btn_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(capture_btn, "Captures image and displays iin box on right");

        }

        private void browse_btn_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(browse_btn, "Browse image from the system");
        }

        private void perform_button_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(perform_button, "Displays the text of image");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void log_btn_Click(object sender, EventArgs e)
        {
            welcome_panel.Visible = true;
            log_pan.Visible = false;
            main_pane.Visible = true;

            //if (tb_un.Text == "hamzamansoorch" && tb_pw.Text == "1234")
            //{
            //    welcome_panel.Visible = true;
            //    log_pan.Visible = false;
            //    main_pane.Visible = true;
            //}
            //else
            //{
            //    MessageBox.Show("Invalid Entries");
            //}
        }



        private void add_btn_Click(object sender, EventArgs e)
        {
            string query = "INSERT into testdb1.student_data (student_id,student_name,student_dept,student_semester,student_batch,student_registration,student_info_time) VALUES('" + enroll_box.Text + "','" + name_box.Text + "','" + dept_box.Text + "','" + semester_box.Text + "','" + batch_box.Text + "','" + reg_box.Text + "','" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "');";
            MySqlConnection conDB = new MySqlConnection(con);
            MySqlCommand cmdDB = new MySqlCommand(query, conDB);
            MySqlDataReader myReader;

            conDB.Open();
            cmdDB.ExecuteReader();
            conDB.Close();
            enroll_box.Text = "";
            name_box.Text = "";
            dept_box.Text = "";
            batch_box.Text = "";
            semester_box.Text = "";
            reg_box.Text = "";
            MessageBox.Show("Added successfully");
            add_btn.Visible = false;

        }

        private void card_proj_Load(object sender, EventArgs e)
        {
            streaming = false;

            cap = new Capture();

        }

        private void card_proj_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (c != null)
            {
                g.DrawImage(c, 140, 10, c.Width, c.Height);
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            SearchAndSort s = new SearchAndSort();
            s.Show();
        }
    }
}
