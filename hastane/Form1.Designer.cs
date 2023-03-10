namespace hastane
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BtnSekreterGrs = new System.Windows.Forms.Button();
            this.BtnHastaGrs = new System.Windows.Forms.Button();
            this.BtnDktGrs = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(103, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "DOKTOR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(333, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "HASTA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(590, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "SEKRETER";
            // 
            // BtnSekreterGrs
            // 
            this.BtnSekreterGrs.BackgroundImage = global::hastane.Properties.Resources._6342669;
            this.BtnSekreterGrs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnSekreterGrs.Location = new System.Drawing.Point(532, 58);
            this.BtnSekreterGrs.Name = "BtnSekreterGrs";
            this.BtnSekreterGrs.Size = new System.Drawing.Size(215, 173);
            this.BtnSekreterGrs.TabIndex = 2;
            this.BtnSekreterGrs.UseVisualStyleBackColor = true;
            this.BtnSekreterGrs.Click += new System.EventHandler(this.BtnSekreterGrs_Click);
            // 
            // BtnHastaGrs
            // 
            this.BtnHastaGrs.BackgroundImage = global::hastane.Properties.Resources._22780_200;
            this.BtnHastaGrs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnHastaGrs.Location = new System.Drawing.Point(289, 58);
            this.BtnHastaGrs.Name = "BtnHastaGrs";
            this.BtnHastaGrs.Size = new System.Drawing.Size(211, 173);
            this.BtnHastaGrs.TabIndex = 1;
            this.BtnHastaGrs.UseVisualStyleBackColor = true;
            this.BtnHastaGrs.Click += new System.EventHandler(this.BtnHastaGrs_Click);
            // 
            // BtnDktGrs
            // 
            this.BtnDktGrs.BackgroundImage = global::hastane.Properties.Resources._194915;
            this.BtnDktGrs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnDktGrs.Location = new System.Drawing.Point(51, 58);
            this.BtnDktGrs.Name = "BtnDktGrs";
            this.BtnDktGrs.Size = new System.Drawing.Size(209, 173);
            this.BtnDktGrs.TabIndex = 0;
            this.BtnDktGrs.UseVisualStyleBackColor = true;
            this.BtnDktGrs.Click += new System.EventHandler(this.BtnDktGrs_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(163, 187);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(8, 8);
            this.dataGridView1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnSekreterGrs);
            this.Controls.Add(this.BtnHastaGrs);
            this.Controls.Add(this.BtnDktGrs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Daglar Hospital";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnDktGrs;
        private System.Windows.Forms.Button BtnHastaGrs;
        private System.Windows.Forms.Button BtnSekreterGrs;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

