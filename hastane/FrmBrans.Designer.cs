namespace hastane
{
    partial class FrmBrans
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBrans));
            this.bransad = new System.Windows.Forms.TextBox();
            this.bransid = new System.Windows.Forms.TextBox();
            this.bransdatagrid = new System.Windows.Forms.DataGridView();
            this.bransgüncelle = new System.Windows.Forms.Button();
            this.branssil = new System.Windows.Forms.Button();
            this.bransekle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bransdatagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bransad
            // 
            this.bransad.Location = new System.Drawing.Point(174, 121);
            this.bransad.Name = "bransad";
            this.bransad.Size = new System.Drawing.Size(116, 20);
            this.bransad.TabIndex = 24;
            // 
            // bransid
            // 
            this.bransid.Location = new System.Drawing.Point(174, 81);
            this.bransid.Name = "bransid";
            this.bransid.Size = new System.Drawing.Size(116, 20);
            this.bransid.TabIndex = 23;
            // 
            // bransdatagrid
            // 
            this.bransdatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bransdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bransdatagrid.Location = new System.Drawing.Point(312, 44);
            this.bransdatagrid.Name = "bransdatagrid";
            this.bransdatagrid.Size = new System.Drawing.Size(456, 197);
            this.bransdatagrid.TabIndex = 22;
            this.bransdatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bransdatagrid_CellClick);
            // 
            // bransgüncelle
            // 
            this.bransgüncelle.Location = new System.Drawing.Point(92, 230);
            this.bransgüncelle.Name = "bransgüncelle";
            this.bransgüncelle.Size = new System.Drawing.Size(126, 41);
            this.bransgüncelle.TabIndex = 21;
            this.bransgüncelle.Text = "Güncelle";
            this.bransgüncelle.UseVisualStyleBackColor = true;
            this.bransgüncelle.Click += new System.EventHandler(this.bransgüncelle_Click);
            // 
            // branssil
            // 
            this.branssil.Location = new System.Drawing.Point(174, 179);
            this.branssil.Name = "branssil";
            this.branssil.Size = new System.Drawing.Size(106, 45);
            this.branssil.TabIndex = 20;
            this.branssil.Text = "Sil";
            this.branssil.UseVisualStyleBackColor = true;
            this.branssil.Click += new System.EventHandler(this.branssil_Click);
            // 
            // bransekle
            // 
            this.bransekle.Location = new System.Drawing.Point(48, 179);
            this.bransekle.Name = "bransekle";
            this.bransekle.Size = new System.Drawing.Size(92, 45);
            this.bransekle.TabIndex = 19;
            this.bransekle.Text = "Ekle";
            this.bransekle.UseVisualStyleBackColor = true;
            this.bransekle.Click += new System.EventHandler(this.bransekle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Brans Ad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 27);
            this.label1.TabIndex = 14;
            this.label1.Text = "Brans id";
            // 
            // FrmBrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.IndianRed;
            this.ClientSize = new System.Drawing.Size(800, 321);
            this.Controls.Add(this.bransad);
            this.Controls.Add(this.bransid);
            this.Controls.Add(this.bransdatagrid);
            this.Controls.Add(this.bransgüncelle);
            this.Controls.Add(this.branssil);
            this.Controls.Add(this.bransekle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBrans";
            this.Text = "FrmBrans";
            this.Load += new System.EventHandler(this.FrmBrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bransdatagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox bransad;
        private System.Windows.Forms.TextBox bransid;
        private System.Windows.Forms.DataGridView bransdatagrid;
        private System.Windows.Forms.Button bransgüncelle;
        private System.Windows.Forms.Button branssil;
        private System.Windows.Forms.Button bransekle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}