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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.main_pane = new System.Windows.Forms.Panel();
            this.browse_btn = new System.Windows.Forms.Button();
            this.browse_tb = new System.Windows.Forms.TextBox();
            this.main_pb = new System.Windows.Forms.PictureBox();
            this.welcome_panel.SuspendLayout();
            this.main_pane.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_pb)).BeginInit();
            this.SuspendLayout();
            // 
            // welcome_panel
            // 
            this.welcome_panel.Controls.Add(this.button1);
            this.welcome_panel.Controls.Add(this.label1);
            this.welcome_panel.Location = new System.Drawing.Point(13, 3);
            this.welcome_panel.Name = "welcome_panel";
            this.welcome_panel.Size = new System.Drawing.Size(775, 435);
            this.welcome_panel.TabIndex = 0;
            this.welcome_panel.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
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
            // main_pane
            // 
            this.main_pane.Controls.Add(this.main_pb);
            this.main_pane.Controls.Add(this.browse_tb);
            this.main_pane.Controls.Add(this.browse_btn);
            this.main_pane.Location = new System.Drawing.Point(14, 7);
            this.main_pane.Name = "main_pane";
            this.main_pane.Size = new System.Drawing.Size(774, 431);
            this.main_pane.TabIndex = 1;
            // 
            // browse_btn
            // 
            this.browse_btn.Location = new System.Drawing.Point(163, 344);
            this.browse_btn.Name = "browse_btn";
            this.browse_btn.Size = new System.Drawing.Size(107, 20);
            this.browse_btn.TabIndex = 0;
            this.browse_btn.Text = "Browse";
            this.browse_btn.UseVisualStyleBackColor = true;
            this.browse_btn.Click += new System.EventHandler(this.browse_btn_Click);
            // 
            // browse_tb
            // 
            this.browse_tb.Location = new System.Drawing.Point(276, 344);
            this.browse_tb.Name = "browse_tb";
            this.browse_tb.Size = new System.Drawing.Size(260, 20);
            this.browse_tb.TabIndex = 1;
            // 
            // main_pb
            // 
            this.main_pb.Location = new System.Drawing.Point(163, 3);
            this.main_pb.Name = "main_pb";
            this.main_pb.Size = new System.Drawing.Size(373, 335);
            this.main_pb.TabIndex = 2;
            this.main_pb.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.main_pane);
            this.Controls.Add(this.welcome_panel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.welcome_panel.ResumeLayout(false);
            this.welcome_panel.PerformLayout();
            this.main_pane.ResumeLayout(false);
            this.main_pane.PerformLayout();
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
    }
}

