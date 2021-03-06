﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace VPproject
{
    public partial class SearchAndSort : Form
    {
        string con1 = "datasource=127.0.0.1;port=3306;username=root;password=1234";
        public SearchAndSort()
        {
            InitializeComponent();
            MySqlConnection srchDB = new MySqlConnection(con1);
            grid_panel.Visible = false;

            
        }

        private void srchClick_btn_Click(object sender, EventArgs e)
        {

            int count = 0;
            string imgPath;
            string check = "SELECT student_name,student_id,student_dept,student_semester,student_batch,student_registration,student_image FROM testdb1.student_data where student_id = '" + en_tb.Text +"';";
            MySqlConnection srchDB = new MySqlConnection(con1);
            MySqlCommand cmdDB = new MySqlCommand(check, srchDB);
            MySqlDataReader myReader;

            srchDB.Open();
            myReader = cmdDB.ExecuteReader();

            while (myReader.Read())
            {
                name_box.Text = myReader.GetString("student_name");
                enroll_box.Text = myReader.GetString("student_id");
                dept_box.Text = myReader.GetString("student_dept");
                batch_box.Text = myReader.GetString("student_batch");
                semester_box.Text = myReader.GetString("student_semester");
                reg_box.Text = myReader.GetString("student_registration");
                imgPath = myReader.GetString("student_image");
                Bitmap d = new Bitmap(imgPath);
                pic_db.Image = d;
                pic_db.SizeMode = PictureBoxSizeMode.StretchImage;

                count++;
            }
            srchDB.Close();
            if(count ==0)
            {
                MessageBox.Show("Student Record does not exists");
            }
        }

        private void grid_btn_Click(object sender, EventArgs e)
        {
            
            MySqlConnection gdb = new MySqlConnection(con1);
            
               
            string q = "SELECT * FROM testdb1.student_data ORDER BY student_info_time DESC";

            gdb.Open();
            //MySqlCommand cmd = new MySqlCommand(q,gdb);
            MySqlDataAdapter adap = new MySqlDataAdapter(q, gdb);
            
            DataSet s = new DataSet();
            adap.Fill(s);
            student_grid.DataSource = s.Tables[0];
            gdb.Close();
             

        }

        private void displayall_btn_Click(object sender, EventArgs e)
        {
            grid_panel.Visible = true;
        }
    }
}
