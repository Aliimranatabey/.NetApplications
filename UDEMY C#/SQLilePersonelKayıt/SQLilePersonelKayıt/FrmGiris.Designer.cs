namespace SQLilePersonelKayıt
{
	partial class FrmGiris
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtkullaniciadi = new System.Windows.Forms.TextBox();
			this.txtsifre = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(53, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(152, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Kullanıcı Adı :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(132, 116);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Şifre :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Harlow Solid Italic", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(405, 30);
			this.label3.TabIndex = 2;
			this.label3.Text = "Personel Takip Sistemi Giriş Paneli";
			// 
			// txtkullaniciadi
			// 
			this.txtkullaniciadi.Location = new System.Drawing.Point(211, 63);
			this.txtkullaniciadi.Name = "txtkullaniciadi";
			this.txtkullaniciadi.Size = new System.Drawing.Size(149, 36);
			this.txtkullaniciadi.TabIndex = 3;
			// 
			// txtsifre
			// 
			this.txtsifre.Location = new System.Drawing.Point(211, 113);
			this.txtsifre.Name = "txtsifre";
			this.txtsifre.Size = new System.Drawing.Size(149, 36);
			this.txtsifre.TabIndex = 4;
			this.txtsifre.UseSystemPasswordChar = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(211, 170);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(149, 36);
			this.button1.TabIndex = 5;
			this.button1.Text = "Giriş Yap";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FrmGiris
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Green;
			this.ClientSize = new System.Drawing.Size(437, 247);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.txtsifre);
			this.Controls.Add(this.txtkullaniciadi);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.Name = "FrmGiris";
			this.Text = "FrmGiris";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtkullaniciadi;
		private System.Windows.Forms.TextBox txtsifre;
		private System.Windows.Forms.Button button1;
	}
}