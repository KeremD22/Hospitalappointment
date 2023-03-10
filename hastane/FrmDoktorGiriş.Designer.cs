namespace hastane
{
    partial class FrmDoktorGiriş
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGiriş));
            this.doktorgrssfretxt = new System.Windows.Forms.TextBox();
            this.doktorgrstxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.doktorgrsbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doktorgrssfretxt
            // 
            this.doktorgrssfretxt.Location = new System.Drawing.Point(355, 240);
            this.doktorgrssfretxt.Name = "doktorgrssfretxt";
            this.doktorgrssfretxt.Size = new System.Drawing.Size(151, 20);
            this.doktorgrssfretxt.TabIndex = 11;
            this.doktorgrssfretxt.UseSystemPasswordChar = true;
            // 
            // doktorgrstxt
            // 
            this.doktorgrstxt.Location = new System.Drawing.Point(355, 180);
            this.doktorgrstxt.Name = "doktorgrstxt";
            this.doktorgrstxt.Size = new System.Drawing.Size(151, 20);
            this.doktorgrstxt.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(271, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "SIFRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(217, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "TC KIMLIK NO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(214, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "DOKTOR GIRIS PANELI";
            // 
            // doktorgrsbutton
            // 
            this.doktorgrsbutton.Location = new System.Drawing.Point(355, 289);
            this.doktorgrsbutton.Name = "doktorgrsbutton";
            this.doktorgrsbutton.Size = new System.Drawing.Size(151, 44);
            this.doktorgrsbutton.TabIndex = 12;
            this.doktorgrsbutton.Text = "Giriş Yap";
            this.doktorgrsbutton.UseVisualStyleBackColor = true;
            this.doktorgrsbutton.Click += new System.EventHandler(this.doktorgrsbutton_Click);
            // 
            // FrmDoktorGiriş
            // 
            this.AcceptButton = this.doktorgrsbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.doktorgrsbutton);
            this.Controls.Add(this.doktorgrssfretxt);
            this.Controls.Add(this.doktorgrstxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmDoktorGiriş";
            this.Text = "Doktor Giriş";
            this.Load += new System.EventHandler(this.FrmDoktorGiriş_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox doktorgrssfretxt;
        private System.Windows.Forms.TextBox doktorgrstxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button doktorgrsbutton;
    }
}