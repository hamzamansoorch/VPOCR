namespace VPproject
{
    partial class Form1
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
            this.welcome_panel = new System.Windows.Forms.Panel();
            this.main_pane = new System.Windows.Forms.Panel();
            this.capture_btn = new System.Windows.Forms.Button();
            this.streamOnOff = new System.Windows.Forms.Button();
            this.picStream = new System.Windows.Forms.PictureBox();
            this.perform_button = new System.Windows.Forms.Button();
            this.main_pb = new System.Windows.Forms.PictureBox();
            this.browse_tb = new System.Windows.Forms.TextBox();
            this.browse_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.welcome_panel.SuspendLayout();
            this.main_pane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStream)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome_panel
            // 
            this.welcome_panel.BackgroundImage = global::VPproject.Properties.Resources.bg2;
            this.welcome_panel.Controls.Add(this.main_pane);
            this.welcome_panel.Controls.Add(this.button1);
            this.welcome_panel.Controls.Add(this.label1);
            this.welcome_panel.Location = new System.Drawing.Point(3, 12);
            this.welcome_panel.Name = "welcome_panel";
            this.welcome_panel.Size = new System.Drawing.Size(785, 426);
            this.welcome_panel.TabIndex = 0;
            // 
            // main_pane
            // 
            this.main_pane.BackColor = System.Drawing.Color.DarkRed;
            this.main_pane.BackgroundImage = global::VPproject.Properties.Resources.bg2;
            this.main_pane.Controls.Add(this.textBox4);
            this.main_pane.Controls.Add(this.textBox5);
            this.main_pane.Controls.Add(this.textBox6);
            this.main_pane.Controls.Add(this.textBox3);
            this.main_pane.Controls.Add(this.textBox2);
            this.main_pane.Controls.Add(this.textBox1);
            this.main_pane.Controls.Add(this.back_button);
            this.main_pane.Controls.Add(this.capture_btn);
            this.main_pane.Controls.Add(this.streamOnOff);
            this.main_pane.Controls.Add(this.picStream);
            this.main_pane.Controls.Add(this.perform_button);
            this.main_pane.Controls.Add(this.main_pb);
            this.main_pane.Controls.Add(this.browse_tb);
            this.main_pane.Controls.Add(this.browse_btn);
            this.main_pane.Location = new System.Drawing.Point(1, 0);
            this.main_pane.Name = "main_pane";
            this.main_pane.Size = new System.Drawing.Size(784, 432);
            this.main_pane.TabIndex = 1;
            this.main_pane.Visible = false;
            this.main_pane.Paint += new System.Windows.Forms.PaintEventHandler(this.main_pane_Paint);
            // 
            // capture_btn
            // 
            this.capture_btn.Location = new System.Drawing.Point(237, 243);
            this.capture_btn.Name = "capture_btn";
            this.capture_btn.Size = new System.Drawing.Size(99, 23);
            this.capture_btn.TabIndex = 6;
            this.capture_btn.Text = "Capture";
            this.capture_btn.UseVisualStyleBackColor = true;
            this.capture_btn.Click += new System.EventHandler(this.capture_btn_Click);
            // 
            // streamOnOff
            // 
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
            this.picStream.Location = new System.Drawing.Point(12, 8);
            this.picStream.Name = "picStream";
            this.picStream.Size = new System.Drawing.Size(372, 229);
            this.picStream.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picStream.TabIndex = 4;
            this.picStream.TabStop = false;
            // 
            // perform_button
            // 
            this.perform_button.Location = new System.Drawing.Point(390, 387);
            this.perform_button.Name = "perform_button";
            this.perform_button.Size = new System.Drawing.Size(373, 23);
            this.perform_button.TabIndex = 3;
            this.perform_button.Text = "Perform Action";
            this.perform_button.UseVisualStyleBackColor = true;
            this.perform_button.Click += new System.EventHandler(this.perform_button_Click);
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
            this.browse_btn.Location = new System.Drawing.Point(390, 349);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(107, 32);
            this.browse_btn.TabIndex = 0;
            this.browse_btn.Text = "Browse";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(306, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "Enter";
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
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(8, 387);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(40, 23);
            this.back_button.TabIndex = 7;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 297);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 323);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(79, 349);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(284, 349);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(284, 323);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(284, 297);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VPproject.Properties.Resources.bg2;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.welcome_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.welcome_panel.ResumeLayout(false);
            this.welcome_panel.PerformLayout();
            this.main_pane.ResumeLayout(false);
            this.main_pane.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStream)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_pb)).EndInit();
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
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

