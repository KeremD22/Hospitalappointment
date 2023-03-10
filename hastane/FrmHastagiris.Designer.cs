namespace hastane
{
    partial class FrmHastagiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastagiris));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.hstgrstxt = new System.Windows.Forms.TextBox();
            this.hstgrssfretxt = new System.Windows.Forms.TextBox();
            this.Hastagrsbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(138, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "HASTA GIRIS PANELI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "TC KIMLIK NO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(122, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "SIFRE:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.linkLabel1.Location = new System.Drawing.Point(443, 290);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(87, 25);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Kayıt Ol";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // hstgrstxt
            // 
            this.hstgrstxt.Location = new System.Drawing.Point(206, 164);
            this.hstgrstxt.Name = "hstgrstxt";
            this.hstgrstxt.Size = new System.Drawing.Size(151, 20);
            this.hstgrstxt.TabIndex = 4;
            // 
            // hstgrssfretxt
            // 
            this.hstgrssfretxt.Location = new System.Drawing.Point(206, 224);
            this.hstgrssfretxt.Name = "hstgrssfretxt";
            this.hstgrssfretxt.Size = new System.Drawing.Size(151, 20);
            this.hstgrssfretxt.TabIndex = 5;
            // 
            // Hastagrsbtn
            // 
            this.Hastagrsbtn.Location = new System.Drawing.Point(244, 275);
            this.Hastagrsbtn.Name = "Hastagrsbtn";
            this.Hastagrsbtn.Size = new System.Drawing.Size(113, 31);
            this.Hastagrsbtn.TabIndex = 6;
            this.Hastagrsbtn.Text = "Giris Yap";
            this.Hastagrsbtn.UseVisualStyleBackColor = true;
            this.Hastagrsbtn.Click += new System.EventHandler(this.Hastagrsbtn_Click);
            // 
            // FrmHastagiris
            // 
            this.AcceptButton = this.Hastagrsbtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(589, 365);
            this.Controls.Add(this.Hastagrsbtn);
            this.Controls.Add(this.hstgrssfretxt);
            this.Controls.Add(this.hstgrstxt);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmHastagiris";
            this.Text = "Hasta Giris";
            this.Load += new System.EventHandler(this.FrmHastagiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.TextBox hstgrstxt;
        private System.Windows.Forms.TextBox hstgrssfretxt;
        private System.Windows.Forms.Button Hastagrsbtn;
    }
}