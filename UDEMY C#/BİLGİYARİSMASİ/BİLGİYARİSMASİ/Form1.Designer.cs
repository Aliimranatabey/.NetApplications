namespace BİLGİYARİSMASİ
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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblsoruno = new System.Windows.Forms.Label();
			this.lbldogru = new System.Windows.Forms.Label();
			this.lblyanlis = new System.Windows.Forms.Label();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.btnA = new System.Windows.Forms.Button();
			this.btnB = new System.Windows.Forms.Button();
			this.btnC = new System.Windows.Forms.Button();
			this.btnD = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(794, 53);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(145, 31);
			this.label1.TabIndex = 0;
			this.label1.Text = "SORU NO :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(834, 106);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(105, 31);
			this.label2.TabIndex = 1;
			this.label2.Text = "Doğru :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(840, 163);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(99, 31);
			this.label3.TabIndex = 2;
			this.label3.Text = "Yanlış :";
			// 
			// lblsoruno
			// 
			this.lblsoruno.AutoSize = true;
			this.lblsoruno.Location = new System.Drawing.Point(945, 53);
			this.lblsoruno.Name = "lblsoruno";
			this.lblsoruno.Size = new System.Drawing.Size(29, 31);
			this.lblsoruno.TabIndex = 3;
			this.lblsoruno.Text = "0";
			// 
			// lbldogru
			// 
			this.lbldogru.AutoSize = true;
			this.lbldogru.Location = new System.Drawing.Point(945, 106);
			this.lbldogru.Name = "lbldogru";
			this.lbldogru.Size = new System.Drawing.Size(29, 31);
			this.lbldogru.TabIndex = 4;
			this.lbldogru.Text = "0";
			// 
			// lblyanlis
			// 
			this.lblyanlis.AutoSize = true;
			this.lblyanlis.Location = new System.Drawing.Point(945, 163);
			this.lblyanlis.Name = "lblyanlis";
			this.lblyanlis.Size = new System.Drawing.Size(29, 31);
			this.lblyanlis.TabIndex = 5;
			this.lblyanlis.Text = "0";
			// 
			// richTextBox1
			// 
			this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
			this.richTextBox1.Location = new System.Drawing.Point(-2, 1);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(750, 251);
			this.richTextBox1.TabIndex = 6;
			this.richTextBox1.Text = "";
			// 
			// btnA
			// 
			this.btnA.Location = new System.Drawing.Point(-2, 258);
			this.btnA.Name = "btnA";
			this.btnA.Size = new System.Drawing.Size(372, 60);
			this.btnA.TabIndex = 7;
			this.btnA.Text = "A";
			this.btnA.UseVisualStyleBackColor = true;
			this.btnA.Click += new System.EventHandler(this.btnA_Click);
			// 
			// btnB
			// 
			this.btnB.Location = new System.Drawing.Point(376, 258);
			this.btnB.Name = "btnB";
			this.btnB.Size = new System.Drawing.Size(372, 60);
			this.btnB.TabIndex = 8;
			this.btnB.Text = "B";
			this.btnB.UseVisualStyleBackColor = true;
			this.btnB.Click += new System.EventHandler(this.btnB_Click);
			// 
			// btnC
			// 
			this.btnC.Location = new System.Drawing.Point(-2, 324);
			this.btnC.Name = "btnC";
			this.btnC.Size = new System.Drawing.Size(372, 60);
			this.btnC.TabIndex = 9;
			this.btnC.Text = "C";
			this.btnC.UseVisualStyleBackColor = true;
			this.btnC.Click += new System.EventHandler(this.btnC_Click);
			// 
			// btnD
			// 
			this.btnD.Location = new System.Drawing.Point(376, 324);
			this.btnD.Name = "btnD";
			this.btnD.Size = new System.Drawing.Size(372, 60);
			this.btnD.TabIndex = 10;
			this.btnD.Text = "D";
			this.btnD.UseVisualStyleBackColor = true;
			this.btnD.Click += new System.EventHandler(this.btnD_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(471, 438);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(87, 31);
			this.label4.TabIndex = 11;
			this.label4.Text = "label4";
			this.label4.Visible = false;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(471, 481);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(87, 31);
			this.label5.TabIndex = 12;
			this.label5.Text = "label5";
			this.label5.Visible = false;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(800, 208);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(190, 69);
			this.button1.TabIndex = 13;
			this.button1.Text = "SONRAKİ ";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(758, 298);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(121, 95);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(885, 298);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(121, 95);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 15;
			this.pictureBox2.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 31F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Yellow;
			this.ClientSize = new System.Drawing.Size(1015, 399);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.btnD);
			this.Controls.Add(this.btnC);
			this.Controls.Add(this.btnB);
			this.Controls.Add(this.btnA);
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.lblyanlis);
			this.Controls.Add(this.lbldogru);
			this.Controls.Add(this.lblsoruno);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Microsoft YaHei", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.Name = "Form1";
			this.Text = "BİLGİ YARIŞMASI";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblsoruno;
		private System.Windows.Forms.Label lbldogru;
		private System.Windows.Forms.Label lblyanlis;
		private System.Windows.Forms.RichTextBox richTextBox1;
		private System.Windows.Forms.Button btnA;
		private System.Windows.Forms.Button btnB;
		private System.Windows.Forms.Button btnC;
		private System.Windows.Forms.Button btnD;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
	}
}

