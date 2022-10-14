namespace Pasta_Pısırme_Projesı
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.progressBar2 = new System.Windows.Forms.ProgressBar();
			this.progressBar3 = new System.Windows.Forms.ProgressBar();
			this.progressBar4 = new System.Windows.Forms.ProgressBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.timer2 = new System.Windows.Forms.Timer(this.components);
			this.timer3 = new System.Windows.Forms.Timer(this.components);
			this.timer4 = new System.Windows.Forms.Timer(this.components);
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 171);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(429, 37);
			this.label1.TabIndex = 0;
			this.label1.Text = "Un ve Yumurta Karıştırılıyor...";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(12, 293);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(364, 37);
			this.label2.TabIndex = 1;
			this.label2.Text = "Çırpma İşlemi Yapılıyor...";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 419);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(559, 37);
			this.label3.TabIndex = 2;
			this.label3.Text = "Malzemeler Ekleniyor ve Karıştırılıyor...";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(12, 543);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(254, 37);
			this.label4.TabIndex = 3;
			this.label4.Text = "Pasta Pişiriliyor...";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(19, 211);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(1355, 62);
			this.progressBar1.TabIndex = 4;
			// 
			// progressBar2
			// 
			this.progressBar2.Location = new System.Drawing.Point(19, 333);
			this.progressBar2.Name = "progressBar2";
			this.progressBar2.Size = new System.Drawing.Size(1355, 62);
			this.progressBar2.TabIndex = 5;
			// 
			// progressBar3
			// 
			this.progressBar3.Location = new System.Drawing.Point(19, 459);
			this.progressBar3.Name = "progressBar3";
			this.progressBar3.Size = new System.Drawing.Size(1355, 63);
			this.progressBar3.TabIndex = 6;
			// 
			// progressBar4
			// 
			this.progressBar4.Location = new System.Drawing.Point(19, 592);
			this.progressBar4.Name = "progressBar4";
			this.progressBar4.Size = new System.Drawing.Size(1355, 63);
			this.progressBar4.TabIndex = 7;
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// timer2
			// 
			this.timer2.Interval = 1000;
			this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
			// 
			// timer3
			// 
			this.timer3.Interval = 1000;
			this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
			// 
			// timer4
			// 
			this.timer4.Interval = 1000;
			this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("MV Boli", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(326, 19);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(758, 105);
			this.label5.TabIndex = 8;
			this.label5.Text = "TEKINOGLU FIRIN";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 36F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.ClientSize = new System.Drawing.Size(1385, 666);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.progressBar4);
			this.Controls.Add(this.progressBar3);
			this.Controls.Add(this.progressBar2);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.ProgressBar progressBar2;
		private System.Windows.Forms.ProgressBar progressBar3;
		private System.Windows.Forms.ProgressBar progressBar4;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Timer timer2;
		private System.Windows.Forms.Timer timer3;
		private System.Windows.Forms.Timer timer4;
		private System.Windows.Forms.Label label5;
	}
}

