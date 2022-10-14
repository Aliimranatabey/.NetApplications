namespace Context_MenuStript
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
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.arkaplanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mAVİToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.pEMBEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.sARIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hakkımızdaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.kolayErişimToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.hesapMakinesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.paintToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.contextMenuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arkaplanToolStripMenuItem,
            this.ayarlarToolStripMenuItem,
            this.kolayErişimToolStripMenuItem});
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(211, 104);
			// 
			// arkaplanToolStripMenuItem
			// 
			this.arkaplanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mAVİToolStripMenuItem,
            this.pEMBEToolStripMenuItem,
            this.sARIToolStripMenuItem});
			this.arkaplanToolStripMenuItem.Name = "arkaplanToolStripMenuItem";
			this.arkaplanToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
			this.arkaplanToolStripMenuItem.Text = "Arkaplan";
			// 
			// mAVİToolStripMenuItem
			// 
			this.mAVİToolStripMenuItem.Name = "mAVİToolStripMenuItem";
			this.mAVİToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.mAVİToolStripMenuItem.Text = "Mavi";
			this.mAVİToolStripMenuItem.Click += new System.EventHandler(this.mAVİToolStripMenuItem_Click);
			// 
			// pEMBEToolStripMenuItem
			// 
			this.pEMBEToolStripMenuItem.Name = "pEMBEToolStripMenuItem";
			this.pEMBEToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.pEMBEToolStripMenuItem.Text = "Pembe";
			this.pEMBEToolStripMenuItem.Click += new System.EventHandler(this.pEMBEToolStripMenuItem_Click);
			// 
			// sARIToolStripMenuItem
			// 
			this.sARIToolStripMenuItem.Name = "sARIToolStripMenuItem";
			this.sARIToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.sARIToolStripMenuItem.Text = "Sarı";
			this.sARIToolStripMenuItem.Click += new System.EventHandler(this.sARIToolStripMenuItem_Click);
			// 
			// ayarlarToolStripMenuItem
			// 
			this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hakkımızdaToolStripMenuItem,
            this.çıkışToolStripMenuItem});
			this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
			this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
			this.ayarlarToolStripMenuItem.Text = "Ayarlar";
			// 
			// hakkımızdaToolStripMenuItem
			// 
			this.hakkımızdaToolStripMenuItem.Name = "hakkımızdaToolStripMenuItem";
			this.hakkımızdaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.hakkımızdaToolStripMenuItem.Text = "Hakkımızda";
			this.hakkımızdaToolStripMenuItem.Click += new System.EventHandler(this.hakkımızdaToolStripMenuItem_Click);
			// 
			// çıkışToolStripMenuItem
			// 
			this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
			this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.çıkışToolStripMenuItem.Text = "Çıkış";
			this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
			// 
			// kolayErişimToolStripMenuItem
			// 
			this.kolayErişimToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hesapMakinesiToolStripMenuItem,
            this.paintToolStripMenuItem});
			this.kolayErişimToolStripMenuItem.Name = "kolayErişimToolStripMenuItem";
			this.kolayErişimToolStripMenuItem.Size = new System.Drawing.Size(210, 24);
			this.kolayErişimToolStripMenuItem.Text = "Kolay Erişim";
			// 
			// hesapMakinesiToolStripMenuItem
			// 
			this.hesapMakinesiToolStripMenuItem.Name = "hesapMakinesiToolStripMenuItem";
			this.hesapMakinesiToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.hesapMakinesiToolStripMenuItem.Text = "Hesap Makinesi";
			this.hesapMakinesiToolStripMenuItem.Click += new System.EventHandler(this.hesapMakinesiToolStripMenuItem_Click);
			// 
			// paintToolStripMenuItem
			// 
			this.paintToolStripMenuItem.Name = "paintToolStripMenuItem";
			this.paintToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
			this.paintToolStripMenuItem.Text = "Paint";
			this.paintToolStripMenuItem.Click += new System.EventHandler(this.paintToolStripMenuItem_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(759, 431);
			this.ContextMenuStrip = this.contextMenuStrip1;
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
			this.Name = "Form1";
			this.Text = "Form1";
			this.contextMenuStrip1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.ToolStripMenuItem arkaplanToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mAVİToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem pEMBEToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem sARIToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hakkımızdaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem kolayErişimToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem hesapMakinesiToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem paintToolStripMenuItem;
	}
}

