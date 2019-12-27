namespace VPproject
{
    partial class card_proj
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
            this.components = new System.ComponentModel.Container();
            this.welcome_panel = new System.Windows.Forms.Panel();
            this.main_pane = new System.Windows.Forms.Panel();
            this.search_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.browseCheck = new System.Windows.Forms.RadioButton();
            this.liveCheck = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reg_box = new System.Windows.Forms.TextBox();
            this.batch_box = new System.Windows.Forms.TextBox();
            this.semester_box = new System.Windows.Forms.TextBox();
            this.dept_box = new System.Windows.Forms.TextBox();
            this.enroll_box = new System.Windows.Forms.TextBox();
            this.name_box = new System.Windows.Forms.TextBox();
            this.back_button = new System.Windows.Forms.Button();
            this.capture_btn = new System.Windows.Forms.Button();
            this.streamOnOff = new System.Windows.Forms.Button();
            this.picStream = new System.Windows.Forms.PictureBox();
            this.perform_button = new System.Windows.Forms.Button();
            this.main_pb = new System.Windows.Forms.PictureBox();
            this.browse_tb = new System.Windows.Forms.TextBox();
            this.browse_btn = new System.Windows.Forms.Button();
            this.log_pan = new System.Windows.Forms.Panel();
            this.log_btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.tb_un = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.welcome_panel.SuspendLayout();
            this.main_pane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_pb)).BeginInit();
            this.log_pan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome_panel
            // 
            this.welcome_panel.BackgroundImage = global::VPproject.Properties.Resources.bg2;
            this.welcome_panel.Controls.Add(this.main_pane);
            this.welcome_panel.Controls.Add(this.log_pan);
            this.welcome_panel.Controls.Add(this.button1);
            this.welcome_panel.Controls.Add(this.label1);
            this.welcome_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcome_panel.Location = new System.Drawing.Point(0, 0);
            this.welcome_panel.Name = "welcome_panel";
            this.welcome_panel.Size = new System.Drawing.Size(800, 450);
            this.welcome_panel.TabIndex = 0;
            // 
            // main_pane
            // 
            this.main_pane.BackColor = System.Drawing.Color.Transparent;
            this.main_pane.BackgroundImage = global::VPproject.Properties.Resources.bg2;
            this.main_pane.Controls.Add(this.search_btn);
            this.main_pane.Controls.Add(this.add_btn);
            this.main_pane.Controls.Add(this.browseCheck);
            this.main_pane.Controls.Add(this.liveCheck);
            this.main_pane.Controls.Add(this.label7);
            this.main_pane.Controls.Add(this.label6);
            this.main_pane.Controls.Add(this.label5);
            this.main_pane.Controls.Add(this.label4);
            this.main_pane.Controls.Add(this.label3);
            this.main_pane.Controls.Add(this.label2);
            this.main_pane.Controls.Add(this.reg_box);
            this.main_pane.Controls.Add(this.batch_box);
            this.main_pane.Controls.Add(this.semester_box);
            this.main_pane.Controls.Add(this.dept_box);
            this.main_pane.Controls.Add(this.enroll_box);
            this.main_pane.Controls.Add(this.name_box);
            this.main_pane.Controls.Add(this.back_button);
            this.main_pane.Controls.Add(this.capture_btn);
            this.main_pane.Controls.Add(this.streamOnOff);
            this.main_pane.Controls.Add(this.picStream);
            this.main_pane.Controls.Add(this.perform_button);
            this.main_pane.Controls.Add(this.main_pb);
            this.main_pane.Controls.Add(this.browse_tb);
            this.main_pane.Controls.Add(this.browse_btn);
            this.main_pane.Location = new System.Drawing.Point(7, 10);
            this.main_pane.Name = "main_pane";
            this.main_pane.Size = new System.Drawing.Size(781, 429);
            this.main_pane.TabIndex = 1;
            this.main_pane.Visible = false;
            this.main_pane.Paint += new System.Windows.Forms.PaintEventHandler(this.main_pane_Paint);
            // 
            // search_btn
            // 
            this.search_btn.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.Location = new System.Drawing.Point(66, 387);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(56, 24);
            this.search_btn.TabIndex = 23;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.Location = new System.Drawing.Point(161, 371);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(75, 23);
            this.add_btn.TabIndex = 22;
            this.add_btn.Text = "Add";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Visible = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // browseCheck
            // 
            this.browseCheck.AutoSize = true;
            this.browseCheck.Location = new System.Drawing.Point(320, 390);
            this.browseCheck.Name = "browseCheck";
            this.browseCheck.Size = new System.Drawing.Size(60, 17);
            this.browseCheck.TabIndex = 21;
            this.browseCheck.TabStop = true;
            this.browseCheck.Text = "Browse";
            this.browseCheck.UseVisualStyleBackColor = true;
            // 
            // liveCheck
            // 
            this.liveCheck.AutoSize = true;
            this.liveCheck.Location = new System.Drawing.Point(269, 390);
            this.liveCheck.Name = "liveCheck";
            this.liveCheck.Size = new System.Drawing.Size(45, 17);
            this.liveCheck.TabIndex = 20;
            this.liveCheck.TabStop = true;
            this.liveCheck.Text = "Live";
            this.liveCheck.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Registration";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(243, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Batch";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(227, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Semester";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 352);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Dept.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(17, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Enrollment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(38, 300);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Name";
            // 
            // reg_box
            // 
            this.reg_box.Location = new System.Drawing.Point(284, 349);
            this.reg_box.Name = "reg_box";
            this.reg_box.Size = new System.Drawing.Size(100, 20);
            this.reg_box.TabIndex = 13;
            // 
            // batch_box
            // 
            this.batch_box.Location = new System.Drawing.Point(284, 323);
            this.batch_box.Name = "batch_box";
            this.batch_box.Size = new System.Drawing.Size(100, 20);
            this.batch_box.TabIndex = 12;
            // 
            // semester_box
            // 
            this.semester_box.Location = new System.Drawing.Point(284, 297);
            this.semester_box.Name = "semester_box";
            this.semester_box.Size = new System.Drawing.Size(100, 20);
            this.semester_box.TabIndex = 11;
            // 
            // dept_box
            // 
            this.dept_box.Location = new System.Drawing.Point(79, 349);
            this.dept_box.Name = "dept_box";
            this.dept_box.Size = new System.Drawing.Size(100, 20);
            this.dept_box.TabIndex = 10;
            // 
            // enroll_box
            // 
            this.enroll_box.Location = new System.Drawing.Point(79, 323);
            this.enroll_box.Name = "enroll_box";
            this.enroll_box.Size = new System.Drawing.Size(100, 20);
            this.enroll_box.TabIndex = 9;
            // 
            // name_box
            // 
            this.name_box.Location = new System.Drawing.Point(79, 297);
            this.name_box.Name = "name_box";
            this.name_box.Size = new System.Drawing.Size(100, 20);
            this.name_box.TabIndex = 8;
            // 
            // back_button
            // 
            this.back_button.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_button.Location = new System.Drawing.Point(8, 387);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(52, 23);
            this.back_button.TabIndex = 7;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // capture_btn
            // 
            this.capture_btn.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.capture_btn.Location = new System.Drawing.Point(237, 243);
            this.capture_btn.Name = "capture_btn";
            this.capture_btn.Size = new System.Drawing.Size(99, 23);
            this.capture_btn.TabIndex = 6;
            this.capture_btn.Text = "Capture";
            this.capture_btn.UseVisualStyleBackColor = true;
            this.capture_btn.Click += new System.EventHandler(this.capture_btn_Click);
            this.capture_btn.MouseHover += new System.EventHandler(this.capture_btn_MouseHover);
            // 
            // streamOnOff
            // 
            this.streamOnOff.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.streamOnOff.Location = new System.Drawing.Point(65, 243);
            this.streamOnOff.Name = "streamOnOff";
            this.streamOnOff.Size = new System.Drawing.Size(100, 23);
            this.streamOnOff.TabIndex = 5;
            this.streamOnOff.Text = "Start Live Stream";
            this.streamOnOff.UseVisualStyleBackColor = true;
            this.streamOnOff.Click += new System.EventHandler(this.streamOnOff_Click);
            this.streamOnOff.MouseHover += new System.EventHandler(this.streamOnOff_MouseHover);
            // 
            // picStream
            // 
            this.picStream.BackColor = System.Drawing.Color.LightGray;
            this.picStream.Location = new System.Drawing.Point(12, 8);
            this.picStream.Name = "picStream";
            this.picStream.Size = new System.Drawing.Size(372, 229);
            this.picStream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStream.TabIndex = 4;
            this.picStream.TabStop = false;
            // 
            // perform_button
            // 
            this.perform_button.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perform_button.Location = new System.Drawing.Point(390, 387);
            this.perform_button.Name = "perform_button";
            this.perform_button.Size = new System.Drawing.Size(373, 23);
            this.perform_button.TabIndex = 3;
            this.perform_button.Text = "Perform Action";
            this.perform_button.UseVisualStyleBackColor = true;
            this.perform_button.Click += new System.EventHandler(this.perform_button_Click);
            this.perform_button.MouseHover += new System.EventHandler(this.perform_button_MouseHover);
            // 
            // main_pb
            // 
            this.main_pb.BackColor = System.Drawing.SystemColors.ControlDark;
            this.main_pb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.main_pb.Location = new System.Drawing.Point(390, 8);
            this.main_pb.Name = "main_pb";
            this.main_pb.Size = new System.Drawing.Size(373, 335);
            this.main_pb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.main_pb.TabIndex = 2;
            this.main_pb.TabStop = false;
            // 
            // browse_tb
            // 
            this.browse_tb.Location = new System.Drawing.Point(503, 349);
            this.browse_tb.Name = "browse_tb";
            this.browse_tb.Size = new System.Drawing.Size(260, 20);
            this.browse_tb.TabIndex = 1;
            // 
            // browse_btn
            // 
            this.browse_btn.Font = new System.Drawing.Font("Corbel", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browse_btn.Location = new System.Drawing.Point(390, 349);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(107, 32);
            this.browse_btn.TabIndex = 0;
            this.browse_btn.Text = "Browse";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            this.browse_btn.MouseHover += new System.EventHandler(this.browse_btn_MouseHover);
            // 
            // log_pan
            // 
            this.log_pan.BackColor = System.Drawing.Color.BurlyWood;
            this.log_pan.Controls.Add(this.log_btn);
            this.log_pan.Controls.Add(this.label10);
            this.log_pan.Controls.Add(this.label9);
            this.log_pan.Controls.Add(this.tb_pw);
            this.log_pan.Controls.Add(this.tb_un);
            this.log_pan.Controls.Add(this.label8);
            this.log_pan.Location = new System.Drawing.Point(110, 98);
            this.log_pan.Name = "log_pan";
            this.log_pan.Size = new System.Drawing.Size(569, 291);
            this.log_pan.TabIndex = 2;
            // 
            // log_btn
            // 
            this.log_btn.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.log_btn.Location = new System.Drawing.Point(234, 253);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(93, 30);
            this.log_btn.TabIndex = 5;
            this.log_btn.Text = "Enter";
            this.log_btn.UseVisualStyleBackColor = true;
            this.log_btn.Click += new System.EventHandler(this.log_btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(114, 199);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 26);
            this.label10.TabIndex = 4;
            this.label10.Text = "Password";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(114, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 26);
            this.label9.TabIndex = 3;
            this.label9.Text = "Username";
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(227, 199);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.PasswordChar = '*';
            this.tb_pw.Size = new System.Drawing.Size(100, 20);
            this.tb_pw.TabIndex = 2;
            // 
            // tb_un
            // 
            this.tb_un.Location = new System.Drawing.Point(227, 140);
            this.tb_un.Name = "tb_un";
            this.tb_un.Size = new System.Drawing.Size(100, 20);
            this.tb_un.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Corbel", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(248, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 26);
            this.label8.TabIndex = 0;
            this.label8.Text = "Login";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "Login";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // card_proj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VPproject.Properties.Resources.bg2;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcome_panel);
            this.Name = "card_proj";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Card Reader";
            this.Load += new System.EventHandler(this.card_proj_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.card_proj_Paint);
            this.welcome_panel.ResumeLayout(false);
            this.welcome_panel.PerformLayout();
            this.main_pane.ResumeLayout(false);
            this.main_pane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_pb)).EndInit();
            this.log_pan.ResumeLayout(false);
            this.log_pan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel welcome_panel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel main_pane;
        private System.Windows.Forms.PictureBox main_pb;
        private System.Windows.Forms.TextBox browse_tb;
        private System.Windows.Forms.Button browse_btn;
        private System.Windows.Forms.Button perform_button;
        private System.Windows.Forms.Button streamOnOff;
        private System.Windows.Forms.PictureBox picStream;
        private System.Windows.Forms.Button capture_btn;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox reg_box;
        private System.Windows.Forms.TextBox batch_box;
        private System.Windows.Forms.TextBox semester_box;
        private System.Windows.Forms.TextBox dept_box;
        private System.Windows.Forms.TextBox enroll_box;
        private System.Windows.Forms.TextBox name_box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel log_pan;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.TextBox tb_un;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button log_btn;
        private System.Windows.Forms.RadioButton browseCheck;
        private System.Windows.Forms.RadioButton liveCheck;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button search_btn;
    }
}

