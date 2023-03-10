namespace hastane
{
    partial class FrmSekreterGrs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterGrs));
            this.sekretergrsbutton = new System.Windows.Forms.Button();
            this.sekretergrssfretxt = new System.Windows.Forms.TextBox();
            this.sekretergrstxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // sekretergrsbutton
            // 
            this.sekretergrsbutton.Location = new System.Drawing.Point(271, 270);
            this.sekretergrsbutton.Name = "sekretergrsbutton";
            this.sekretergrsbutton.Size = new System.Drawing.Size(151, 44);
            this.sekretergrsbutton.TabIndex = 18;
            this.sekretergrsbutton.Text = "Giriş Yap";
            this.sekretergrsbutton.UseVisualStyleBackColor = true;
            this.sekretergrsbutton.Click += new System.EventHandler(this.sekretergrsbutton_Click);
            // 
            // sekretergrssfretxt
            // 
            this.sekretergrssfretxt.Location = new System.Drawing.Point(271, 221);
            this.sekretergrssfretxt.Name = "sekretergrssfretxt";
            this.sekretergrssfretxt.Size = new System.Drawing.Size(151, 20);
            this.sekretergrssfretxt.TabIndex = 17;
            this.sekretergrssfretxt.UseSystemPasswordChar = true;
            // 
            // sekretergrstxt
            // 
            this.sekretergrstxt.Location = new System.Drawing.Point(271, 161);
            this.sekretergrstxt.Name = "sekretergrstxt";
            this.sekretergrstxt.Size = new System.Drawing.Size(151, 20);
            this.sekretergrstxt.TabIndex = 16;
            this.sekretergrstxt.TextChanged += new System.EventHandler(this.sekretergrstxt_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(187, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 24);
            this.label3.TabIndex = 15;
            this.label3.Text = "SIFRE:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(133, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "TC KIMLIK NO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(113, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 38);
            this.label1.TabIndex = 13;
            this.label1.Text = "SEKRETER GIRIS PANELI";
            // 
            // FrmSekreterGrs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(610, 390);
            this.Controls.Add(this.sekretergrsbutton);
            this.Controls.Add(this.sekretergrssfretxt);
            this.Controls.Add(this.sekretergrstxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmSekreterGrs";
            this.Text = "FrmSekreterGrs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sekretergrsbutton;
        private System.Windows.Forms.TextBox sekretergrssfretxt;
        private System.Windows.Forms.TextBox sekretergrstxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}