namespace Lmaowtf
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.siticonePictureBox1 = new Siticone.UI.WinForms.SiticonePictureBox();
            this.siticonePanel1 = new Siticone.UI.WinForms.SiticonePanel();
            this.siticonePanel2 = new Siticone.UI.WinForms.SiticonePanel();
            this.siticonePanel3 = new Siticone.UI.WinForms.SiticonePanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).BeginInit();
            this.siticonePanel1.SuspendLayout();
            this.siticonePanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticonePictureBox1
            // 
            this.siticonePictureBox1.Image = global::Lmaowtf.Properties.Resources._4FACFCC_converted;
            this.siticonePictureBox1.Location = new System.Drawing.Point(262, 132);
            this.siticonePictureBox1.Name = "siticonePictureBox1";
            this.siticonePictureBox1.ShadowDecoration.Parent = this.siticonePictureBox1;
            this.siticonePictureBox1.Size = new System.Drawing.Size(141, 48);
            this.siticonePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.siticonePictureBox1.TabIndex = 0;
            this.siticonePictureBox1.TabStop = false;
            // 
            // siticonePanel1
            // 
            this.siticonePanel1.Controls.Add(this.siticonePanel2);
            this.siticonePanel1.Location = new System.Drawing.Point(160, 186);
            this.siticonePanel1.Name = "siticonePanel1";
            this.siticonePanel1.ShadowDecoration.Parent = this.siticonePanel1;
            this.siticonePanel1.Size = new System.Drawing.Size(333, 100);
            this.siticonePanel1.TabIndex = 1;
            // 
            // siticonePanel2
            // 
            this.siticonePanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(14)))));
            this.siticonePanel2.Controls.Add(this.siticonePanel3);
            this.siticonePanel2.Location = new System.Drawing.Point(20, 46);
            this.siticonePanel2.Name = "siticonePanel2";
            this.siticonePanel2.ShadowDecoration.Parent = this.siticonePanel2;
            this.siticonePanel2.Size = new System.Drawing.Size(295, 6);
            this.siticonePanel2.TabIndex = 2;
            // 
            // siticonePanel3
            // 
            this.siticonePanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(152)))), ((int)(((byte)(120)))));
            this.siticonePanel3.Location = new System.Drawing.Point(0, 0);
            this.siticonePanel3.Name = "siticonePanel3";
            this.siticonePanel3.ShadowDecoration.Parent = this.siticonePanel3;
            this.siticonePanel3.Size = new System.Drawing.Size(1, 6);
            this.siticonePanel3.TabIndex = 3;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 120;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(269, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "No Minecraft Found";
            this.label1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(659, 389);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.siticonePanel1);
            this.Controls.Add(this.siticonePictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "vape";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.siticonePictureBox1)).EndInit();
            this.siticonePanel1.ResumeLayout(false);
            this.siticonePanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Siticone.UI.WinForms.SiticonePictureBox siticonePictureBox1;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel1;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel2;
        private Siticone.UI.WinForms.SiticonePanel siticonePanel3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label label1;
    }
}

