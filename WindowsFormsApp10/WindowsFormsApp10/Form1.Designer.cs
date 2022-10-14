namespace WindowsFormsApp10
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
			this.listView1 = new System.Windows.Forms.ListView();
			this.lblTotal = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.btnTaskEnd = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(3, 29);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(894, 308);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// lblTotal
			// 
			this.lblTotal.AutoSize = true;
			this.lblTotal.Location = new System.Drawing.Point(186, 371);
			this.lblTotal.Name = "lblTotal";
			this.lblTotal.Size = new System.Drawing.Size(30, 17);
			this.lblTotal.TabIndex = 1;
			this.lblTotal.Text = "null";
			this.lblTotal.Click += new System.EventHandler(this.lblTotal_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Lime;
			this.button1.Location = new System.Drawing.Point(12, 435);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "Yenile";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click_1);
			// 
			// btnTaskEnd
			// 
			this.btnTaskEnd.BackColor = System.Drawing.Color.Red;
			this.btnTaskEnd.Location = new System.Drawing.Point(753, 356);
			this.btnTaskEnd.Name = "btnTaskEnd";
			this.btnTaskEnd.Size = new System.Drawing.Size(111, 46);
			this.btnTaskEnd.TabIndex = 3;
			this.btnTaskEnd.Text = "GÖREVİ SONLANDIR";
			this.btnTaskEnd.UseVisualStyleBackColor = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(0, 372);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(180, 17);
			this.label1.TabIndex = 4;
			this.label1.Text = "Toplam Çalışan Uygulama :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(103, 19);
			this.label2.TabIndex = 5;
			this.label2.Text = "Programın Adı ";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label3.Location = new System.Drawing.Point(300, 7);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 19);
			this.label3.TabIndex = 6;
			this.label3.Text = "PID";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label4.Location = new System.Drawing.Point(504, 9);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 19);
			this.label4.TabIndex = 7;
			this.label4.Text = "CPU";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.label5.Location = new System.Drawing.Point(805, 9);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(59, 19);
			this.label5.TabIndex = 8;
			this.label5.Text = "Çalışma";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(933, 559);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnTaskEnd);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.lblTotal);
			this.Controls.Add(this.listView1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Label lblTotal;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button btnTaskEnd;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
	}
}

