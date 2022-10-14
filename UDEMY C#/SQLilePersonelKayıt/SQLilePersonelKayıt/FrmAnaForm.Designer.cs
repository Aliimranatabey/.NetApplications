namespace SQLilePersonelKayıt
{
	partial class FrmAnaForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAnaForm));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label7 = new System.Windows.Forms.Label();
			this.mskmaas = new System.Windows.Forms.MaskedTextBox();
			this.txtmeslek = new System.Windows.Forms.TextBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.cmbsehir = new System.Windows.Forms.ComboBox();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.txtpersonelsoyad = new System.Windows.Forms.TextBox();
			this.txtpersonelad = new System.Windows.Forms.TextBox();
			this.txtpersonelıd = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.btngrafikler = new System.Windows.Forms.Button();
			this.btnistatistik = new System.Windows.Forms.Button();
			this.btntemizle = new System.Windows.Forms.Button();
			this.btngüncelle = new System.Windows.Forms.Button();
			this.btnsil = new System.Windows.Forms.Button();
			this.btnkaydet = new System.Windows.Forms.Button();
			this.btnlistele = new System.Windows.Forms.Button();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.perIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perAdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perSoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perSehirDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perMaaşDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.perDurumDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
			this.perMeslekDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.tblPersonelBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.personelVeriTabaniDataSet = new SQLilePersonelKayıt.PersonelVeriTabaniDataSet();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.tbl_PersonelTableAdapter = new SQLilePersonelKayıt.PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter();
			this.label8 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.mskmaas);
			this.groupBox1.Controls.Add(this.txtmeslek);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.cmbsehir);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Controls.Add(this.txtpersonelsoyad);
			this.groupBox1.Controls.Add(this.txtpersonelad);
			this.groupBox1.Controls.Add(this.txtpersonelıd);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(2, 12);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(392, 344);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(21, 295);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(171, 29);
			this.label7.TabIndex = 9;
			this.label7.Text = "Personel Maaş :";
			// 
			// mskmaas
			// 
			this.mskmaas.Location = new System.Drawing.Point(198, 297);
			this.mskmaas.Mask = "00000";
			this.mskmaas.Name = "mskmaas";
			this.mskmaas.Size = new System.Drawing.Size(162, 36);
			this.mskmaas.TabIndex = 7;
			this.mskmaas.ValidatingType = typeof(int);
			// 
			// txtmeslek
			// 
			this.txtmeslek.Location = new System.Drawing.Point(198, 253);
			this.txtmeslek.Name = "txtmeslek";
			this.txtmeslek.Size = new System.Drawing.Size(162, 36);
			this.txtmeslek.TabIndex = 8;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(267, 211);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(93, 33);
			this.radioButton2.TabIndex = 1;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Bekar";
			this.radioButton2.UseVisualStyleBackColor = true;
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// cmbsehir
			// 
			this.cmbsehir.FormattingEnabled = true;
			this.cmbsehir.Location = new System.Drawing.Point(198, 169);
			this.cmbsehir.Name = "cmbsehir";
			this.cmbsehir.Size = new System.Drawing.Size(162, 36);
			this.cmbsehir.TabIndex = 0;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(198, 211);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(72, 33);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Evli";
			this.radioButton1.UseVisualStyleBackColor = true;
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// txtpersonelsoyad
			// 
			this.txtpersonelsoyad.Location = new System.Drawing.Point(198, 125);
			this.txtpersonelsoyad.Name = "txtpersonelsoyad";
			this.txtpersonelsoyad.Size = new System.Drawing.Size(162, 36);
			this.txtpersonelsoyad.TabIndex = 7;
			// 
			// txtpersonelad
			// 
			this.txtpersonelad.Location = new System.Drawing.Point(198, 79);
			this.txtpersonelad.Name = "txtpersonelad";
			this.txtpersonelad.Size = new System.Drawing.Size(162, 36);
			this.txtpersonelad.TabIndex = 6;
			// 
			// txtpersonelıd
			// 
			this.txtpersonelıd.Location = new System.Drawing.Point(198, 35);
			this.txtpersonelıd.Name = "txtpersonelıd";
			this.txtpersonelıd.Size = new System.Drawing.Size(162, 36);
			this.txtpersonelıd.TabIndex = 0;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(3, 253);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(189, 29);
			this.label6.TabIndex = 5;
			this.label6.Text = "Personel Meslek :";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(40, 211);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(152, 29);
			this.label5.TabIndex = 4;
			this.label5.Text = "Medeni Hali : ";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(23, 169);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(169, 29);
			this.label4.TabIndex = 3;
			this.label4.Text = "Personel Şehir :";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(12, 127);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(180, 29);
			this.label3.TabIndex = 2;
			this.label3.Text = "Personel Soyad :";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(47, 85);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Personel Ad :";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(51, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(141, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Personel ID :";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btngrafikler);
			this.groupBox2.Controls.Add(this.btnistatistik);
			this.groupBox2.Controls.Add(this.btntemizle);
			this.groupBox2.Controls.Add(this.btngüncelle);
			this.groupBox2.Controls.Add(this.btnsil);
			this.groupBox2.Controls.Add(this.btnkaydet);
			this.groupBox2.Controls.Add(this.btnlistele);
			this.groupBox2.Location = new System.Drawing.Point(400, 12);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(392, 344);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// btngrafikler
			// 
			this.btngrafikler.Location = new System.Drawing.Point(132, 286);
			this.btngrafikler.Name = "btngrafikler";
			this.btngrafikler.Size = new System.Drawing.Size(165, 42);
			this.btngrafikler.TabIndex = 6;
			this.btngrafikler.Text = "Grafikler";
			this.btngrafikler.UseVisualStyleBackColor = true;
			this.btngrafikler.Click += new System.EventHandler(this.btngrafikler_Click);
			// 
			// btnistatistik
			// 
			this.btnistatistik.Location = new System.Drawing.Point(132, 241);
			this.btnistatistik.Name = "btnistatistik";
			this.btnistatistik.Size = new System.Drawing.Size(165, 42);
			this.btnistatistik.TabIndex = 5;
			this.btnistatistik.Text = "İstatistik";
			this.btnistatistik.UseVisualStyleBackColor = true;
			this.btnistatistik.Click += new System.EventHandler(this.btnistatistik_Click);
			// 
			// btntemizle
			// 
			this.btntemizle.Location = new System.Drawing.Point(132, 196);
			this.btntemizle.Name = "btntemizle";
			this.btntemizle.Size = new System.Drawing.Size(165, 42);
			this.btntemizle.TabIndex = 4;
			this.btntemizle.Text = "Temizle";
			this.btntemizle.UseVisualStyleBackColor = true;
			this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
			// 
			// btngüncelle
			// 
			this.btngüncelle.Location = new System.Drawing.Point(132, 151);
			this.btngüncelle.Name = "btngüncelle";
			this.btngüncelle.Size = new System.Drawing.Size(165, 42);
			this.btngüncelle.TabIndex = 3;
			this.btngüncelle.Text = "Güncelle";
			this.btngüncelle.UseVisualStyleBackColor = true;
			this.btngüncelle.Click += new System.EventHandler(this.btngüncelle_Click);
			// 
			// btnsil
			// 
			this.btnsil.Location = new System.Drawing.Point(132, 106);
			this.btnsil.Name = "btnsil";
			this.btnsil.Size = new System.Drawing.Size(165, 42);
			this.btnsil.TabIndex = 2;
			this.btnsil.Text = "Sil";
			this.btnsil.UseVisualStyleBackColor = true;
			this.btnsil.Click += new System.EventHandler(this.btnsil_Click);
			// 
			// btnkaydet
			// 
			this.btnkaydet.Location = new System.Drawing.Point(132, 61);
			this.btnkaydet.Name = "btnkaydet";
			this.btnkaydet.Size = new System.Drawing.Size(165, 42);
			this.btnkaydet.TabIndex = 1;
			this.btnkaydet.Text = "Kaydet";
			this.btnkaydet.UseVisualStyleBackColor = true;
			this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
			// 
			// btnlistele
			// 
			this.btnlistele.Location = new System.Drawing.Point(132, 16);
			this.btnlistele.Name = "btnlistele";
			this.btnlistele.Size = new System.Drawing.Size(165, 42);
			this.btnlistele.TabIndex = 0;
			this.btnlistele.Text = "Listele";
			this.btnlistele.UseVisualStyleBackColor = true;
			this.btnlistele.Click += new System.EventHandler(this.btnlistele_Click);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.dataGridView1);
			this.groupBox3.Location = new System.Drawing.Point(2, 387);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(1047, 166);
			this.groupBox3.TabIndex = 2;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "groupBox3";
			this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.perIDDataGridViewTextBoxColumn,
            this.perAdDataGridViewTextBoxColumn,
            this.perSoyadDataGridViewTextBoxColumn,
            this.perSehirDataGridViewTextBoxColumn,
            this.perMaaşDataGridViewTextBoxColumn,
            this.perDurumDataGridViewCheckBoxColumn,
            this.perMeslekDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.tblPersonelBindingSource;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(3, 32);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(1041, 131);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
			// 
			// perIDDataGridViewTextBoxColumn
			// 
			this.perIDDataGridViewTextBoxColumn.DataPropertyName = "PerID";
			this.perIDDataGridViewTextBoxColumn.HeaderText = "PerID";
			this.perIDDataGridViewTextBoxColumn.Name = "perIDDataGridViewTextBoxColumn";
			this.perIDDataGridViewTextBoxColumn.ReadOnly = true;
			// 
			// perAdDataGridViewTextBoxColumn
			// 
			this.perAdDataGridViewTextBoxColumn.DataPropertyName = "PerAd";
			this.perAdDataGridViewTextBoxColumn.HeaderText = "PerAd";
			this.perAdDataGridViewTextBoxColumn.Name = "perAdDataGridViewTextBoxColumn";
			// 
			// perSoyadDataGridViewTextBoxColumn
			// 
			this.perSoyadDataGridViewTextBoxColumn.DataPropertyName = "PerSoyad";
			this.perSoyadDataGridViewTextBoxColumn.HeaderText = "PerSoyad";
			this.perSoyadDataGridViewTextBoxColumn.Name = "perSoyadDataGridViewTextBoxColumn";
			// 
			// perSehirDataGridViewTextBoxColumn
			// 
			this.perSehirDataGridViewTextBoxColumn.DataPropertyName = "PerSehir";
			this.perSehirDataGridViewTextBoxColumn.HeaderText = "PerSehir";
			this.perSehirDataGridViewTextBoxColumn.Name = "perSehirDataGridViewTextBoxColumn";
			// 
			// perMaaşDataGridViewTextBoxColumn
			// 
			this.perMaaşDataGridViewTextBoxColumn.DataPropertyName = "PerMaaş";
			this.perMaaşDataGridViewTextBoxColumn.HeaderText = "PerMaaş";
			this.perMaaşDataGridViewTextBoxColumn.Name = "perMaaşDataGridViewTextBoxColumn";
			// 
			// perDurumDataGridViewCheckBoxColumn
			// 
			this.perDurumDataGridViewCheckBoxColumn.DataPropertyName = "PerDurum";
			this.perDurumDataGridViewCheckBoxColumn.HeaderText = "PerDurum";
			this.perDurumDataGridViewCheckBoxColumn.Name = "perDurumDataGridViewCheckBoxColumn";
			// 
			// perMeslekDataGridViewTextBoxColumn
			// 
			this.perMeslekDataGridViewTextBoxColumn.DataPropertyName = "PerMeslek";
			this.perMeslekDataGridViewTextBoxColumn.HeaderText = "PerMeslek";
			this.perMeslekDataGridViewTextBoxColumn.Name = "perMeslekDataGridViewTextBoxColumn";
			// 
			// tblPersonelBindingSource
			// 
			this.tblPersonelBindingSource.DataMember = "Tbl_Personel";
			this.tblPersonelBindingSource.DataSource = this.personelVeriTabaniDataSet;
			// 
			// personelVeriTabaniDataSet
			// 
			this.personelVeriTabaniDataSet.DataSetName = "PersonelVeriTabaniDataSet";
			this.personelVeriTabaniDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(812, 28);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(234, 185);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// tbl_PersonelTableAdapter
			// 
			this.tbl_PersonelTableAdapter.ClearBeforeFill = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Enabled = false;
			this.label8.Location = new System.Drawing.Point(869, 242);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(75, 29);
			this.label8.TabIndex = 4;
			this.label8.Text = "label8";
			this.label8.TextChanged += new System.EventHandler(this.label8_TextChanged);
			// 
			// FrmAnaForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Teal;
			this.ClientSize = new System.Drawing.Size(1061, 553);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.Margin = new System.Windows.Forms.Padding(5);
			this.Name = "FrmAnaForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.tblPersonelBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.personelVeriTabaniDataSet)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MaskedTextBox mskmaas;
		private System.Windows.Forms.TextBox txtmeslek;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.ComboBox cmbsehir;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.TextBox txtpersonelsoyad;
		private System.Windows.Forms.TextBox txtpersonelad;
		private System.Windows.Forms.TextBox txtpersonelıd;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button btngrafikler;
		private System.Windows.Forms.Button btnistatistik;
		private System.Windows.Forms.Button btntemizle;
		private System.Windows.Forms.Button btngüncelle;
		private System.Windows.Forms.Button btnsil;
		private System.Windows.Forms.Button btnkaydet;
		private System.Windows.Forms.Button btnlistele;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private PersonelVeriTabaniDataSet personelVeriTabaniDataSet;
		private System.Windows.Forms.BindingSource tblPersonelBindingSource;
		private PersonelVeriTabaniDataSetTableAdapters.Tbl_PersonelTableAdapter tbl_PersonelTableAdapter;
		private System.Windows.Forms.DataGridViewTextBoxColumn perIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn perAdDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn perSoyadDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn perSehirDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn perMaaşDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewCheckBoxColumn perDurumDataGridViewCheckBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn perMeslekDataGridViewTextBoxColumn;
		private System.Windows.Forms.Label label8;
	}
}

