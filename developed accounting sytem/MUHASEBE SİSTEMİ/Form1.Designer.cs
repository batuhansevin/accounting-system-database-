﻿namespace Muhasebe
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.eklefirmaadi = new System.Windows.Forms.TextBox();
            this.firmakaydet = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.eklefirmatelefon = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.eklefirmaadres = new System.Windows.Forms.TextBox();
            this.firmasil = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.toplambakiye = new System.Windows.Forms.Label();
            this.buaykibakiye = new System.Windows.Forms.Label();
            this.buayyazdir = new System.Windows.Forms.Button();
            this.butunaylariyazdir = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.listelefirmaadi = new System.Windows.Forms.ComboBox();
            this.firmalarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new Muhasebe.databaseDataSet();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nerdenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alinanmalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunadetDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birimfiyatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvharictutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvdahiltutarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.durumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nerdenDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nedenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvharictutarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kdvdahiltutarDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelirBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.aciklama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firmaadi = new System.Windows.Forms.ComboBox();
            this.adetfiyat = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gidergir = new System.Windows.Forms.Button();
            this.gelirgir = new System.Windows.Forms.Button();
            this.kdvdahil = new System.Windows.Forms.RadioButton();
            this.kdvharic = new System.Windows.Forms.RadioButton();
            this.miktar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.toplamtutar = new System.Windows.Forms.Label();
            this.kdvtutari = new System.Windows.Forms.Label();
            this.kdvorani = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.giderTableAdapter = new Muhasebe.databaseDataSetTableAdapters.giderTableAdapter();
            this.gelirTableAdapter = new Muhasebe.databaseDataSetTableAdapters.gelirTableAdapter();
            this.firmalarTableAdapter = new Muhasebe.databaseDataSetTableAdapters.firmalarTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmalarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelirBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.eklefirmaadi);
            this.groupBox2.Controls.Add(this.firmakaydet);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.eklefirmatelefon);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.eklefirmaadres);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(787, 53);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(399, 261);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Firma Ekle - Düzenle";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(31, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 29);
            this.label7.TabIndex = 14;
            this.label7.Text = "Adı :";
            // 
            // eklefirmaadi
            // 
            this.eklefirmaadi.Location = new System.Drawing.Point(160, 50);
            this.eklefirmaadi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eklefirmaadi.Name = "eklefirmaadi";
            this.eklefirmaadi.Size = new System.Drawing.Size(200, 34);
            this.eklefirmaadi.TabIndex = 13;
            // 
            // firmakaydet
            // 
            this.firmakaydet.BackColor = System.Drawing.Color.Purple;
            this.firmakaydet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.firmakaydet.Location = new System.Drawing.Point(36, 190);
            this.firmakaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firmakaydet.Name = "firmakaydet";
            this.firmakaydet.Size = new System.Drawing.Size(325, 47);
            this.firmakaydet.TabIndex = 12;
            this.firmakaydet.Text = "Kaydet";
            this.firmakaydet.UseVisualStyleBackColor = false;
            this.firmakaydet.Click += new System.EventHandler(this.firmakaydet_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(31, 140);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "Telefon : ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 194);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 29);
            this.label9.TabIndex = 7;
            // 
            // eklefirmatelefon
            // 
            this.eklefirmatelefon.Location = new System.Drawing.Point(160, 137);
            this.eklefirmatelefon.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eklefirmatelefon.Name = "eklefirmatelefon";
            this.eklefirmatelefon.Size = new System.Drawing.Size(200, 34);
            this.eklefirmatelefon.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(31, 97);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 29);
            this.label10.TabIndex = 5;
            this.label10.Text = "Adres : ";
            // 
            // eklefirmaadres
            // 
            this.eklefirmaadres.Location = new System.Drawing.Point(160, 94);
            this.eklefirmaadres.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eklefirmaadres.Name = "eklefirmaadres";
            this.eklefirmaadres.Size = new System.Drawing.Size(200, 34);
            this.eklefirmaadres.TabIndex = 4;
            // 
            // firmasil
            // 
            this.firmasil.BackColor = System.Drawing.Color.Purple;
            this.firmasil.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.firmasil.Location = new System.Drawing.Point(279, 100);
            this.firmasil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firmasil.Name = "firmasil";
            this.firmasil.Size = new System.Drawing.Size(228, 47);
            this.firmasil.TabIndex = 22;
            this.firmasil.Text = "Sil";
            this.firmasil.UseVisualStyleBackColor = false;
            this.firmasil.Click += new System.EventHandler(this.firmasil_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.toplambakiye);
            this.groupBox3.Controls.Add(this.buaykibakiye);
            this.groupBox3.Controls.Add(this.firmasil);
            this.groupBox3.Controls.Add(this.buayyazdir);
            this.groupBox3.Controls.Add(this.butunaylariyazdir);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.listelefirmaadi);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(1193, 53);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(543, 368);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Firma Bakiyeleri";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Purple;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(39, 100);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(228, 47);
            this.button2.TabIndex = 28;
            this.button2.Text = "Temizle";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // toplambakiye
            // 
            this.toplambakiye.AutoSize = true;
            this.toplambakiye.Location = new System.Drawing.Point(233, 229);
            this.toplambakiye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toplambakiye.Name = "toplambakiye";
            this.toplambakiye.Size = new System.Drawing.Size(0, 29);
            this.toplambakiye.TabIndex = 27;
            // 
            // buaykibakiye
            // 
            this.buaykibakiye.AutoSize = true;
            this.buaykibakiye.Location = new System.Drawing.Point(233, 182);
            this.buaykibakiye.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.buaykibakiye.Name = "buaykibakiye";
            this.buaykibakiye.Size = new System.Drawing.Size(0, 29);
            this.buaykibakiye.TabIndex = 26;
            // 
            // buayyazdir
            // 
            this.buayyazdir.BackColor = System.Drawing.Color.Purple;
            this.buayyazdir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buayyazdir.Location = new System.Drawing.Point(39, 288);
            this.buayyazdir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buayyazdir.Name = "buayyazdir";
            this.buayyazdir.Size = new System.Drawing.Size(192, 47);
            this.buayyazdir.TabIndex = 25;
            this.buayyazdir.Text = "Bu Ayı Yazdır";
            this.buayyazdir.UseVisualStyleBackColor = false;
            // 
            // butunaylariyazdir
            // 
            this.butunaylariyazdir.BackColor = System.Drawing.Color.Purple;
            this.butunaylariyazdir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.butunaylariyazdir.Location = new System.Drawing.Point(239, 288);
            this.butunaylariyazdir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butunaylariyazdir.Name = "butunaylariyazdir";
            this.butunaylariyazdir.Size = new System.Drawing.Size(269, 47);
            this.butunaylariyazdir.TabIndex = 24;
            this.butunaylariyazdir.Text = "Tüm Kayıtları Yazdır";
            this.butunaylariyazdir.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(32, 182);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(188, 29);
            this.label14.TabIndex = 23;
            this.label14.Text = "Bu Ayki Bakiye : ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(33, 229);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 29);
            this.label13.TabIndex = 22;
            this.label13.Text = "Toplam Hesap : ";
            // 
            // listelefirmaadi
            // 
            this.listelefirmaadi.DataSource = this.firmalarBindingSource;
            this.listelefirmaadi.DisplayMember = "adi";
            this.listelefirmaadi.FormattingEnabled = true;
            this.listelefirmaadi.Location = new System.Drawing.Point(161, 48);
            this.listelefirmaadi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listelefirmaadi.Name = "listelefirmaadi";
            this.listelefirmaadi.Size = new System.Drawing.Size(344, 37);
            this.listelefirmaadi.TabIndex = 20;
            this.listelefirmaadi.ValueMember = "id";
            this.listelefirmaadi.SelectedIndexChanged += new System.EventHandler(this.listelefirmaadi_SelectedIndexChanged);
            // 
            // firmalarBindingSource
            // 
            this.firmalarBindingSource.DataMember = "firmalar";
            this.firmalarBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "databaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 53);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(122, 29);
            this.label12.TabIndex = 19;
            this.label12.Text = "Firma Adı:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(32, 194);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 29);
            this.label15.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Purple;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(11, 463);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(166, 29);
            this.label17.TabIndex = 6;
            this.label17.Text = "Gider Listesi : ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Purple;
            this.label18.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(877, 463);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(158, 29);
            this.label18.TabIndex = 7;
            this.label18.Text = "Gelir Listesi : ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(835, 386);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(291, 31);
            this.label11.TabIndex = 9;
            this.label11.Text = "TÜM HAKLARI SAKLIDIR.";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Purple;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nerdenDataGridViewTextBoxColumn,
            this.tarihDataGridViewTextBoxColumn,
            this.alinanmalDataGridViewTextBoxColumn,
            this.urunadetDataGridViewTextBoxColumn,
            this.birimfiyatDataGridViewTextBoxColumn,
            this.kdvDataGridViewTextBoxColumn,
            this.kdvharictutarDataGridViewTextBoxColumn,
            this.kdvdahiltutarDataGridViewTextBoxColumn,
            this.durumDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.giderBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(16, 512);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(840, 409);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // nerdenDataGridViewTextBoxColumn
            // 
            this.nerdenDataGridViewTextBoxColumn.DataPropertyName = "nerden";
            this.nerdenDataGridViewTextBoxColumn.HeaderText = "İsim";
            this.nerdenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nerdenDataGridViewTextBoxColumn.Name = "nerdenDataGridViewTextBoxColumn";
            this.nerdenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn
            // 
            this.tarihDataGridViewTextBoxColumn.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn.Name = "tarihDataGridViewTextBoxColumn";
            this.tarihDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alinanmalDataGridViewTextBoxColumn
            // 
            this.alinanmalDataGridViewTextBoxColumn.DataPropertyName = "alinanmal";
            this.alinanmalDataGridViewTextBoxColumn.HeaderText = "Mal";
            this.alinanmalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.alinanmalDataGridViewTextBoxColumn.Name = "alinanmalDataGridViewTextBoxColumn";
            this.alinanmalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // urunadetDataGridViewTextBoxColumn
            // 
            this.urunadetDataGridViewTextBoxColumn.DataPropertyName = "urunadet";
            this.urunadetDataGridViewTextBoxColumn.HeaderText = "Adet";
            this.urunadetDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.urunadetDataGridViewTextBoxColumn.Name = "urunadetDataGridViewTextBoxColumn";
            this.urunadetDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // birimfiyatDataGridViewTextBoxColumn
            // 
            this.birimfiyatDataGridViewTextBoxColumn.DataPropertyName = "birimfiyat";
            this.birimfiyatDataGridViewTextBoxColumn.HeaderText = "B. Fiyat";
            this.birimfiyatDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.birimfiyatDataGridViewTextBoxColumn.Name = "birimfiyatDataGridViewTextBoxColumn";
            this.birimfiyatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kdvDataGridViewTextBoxColumn
            // 
            this.kdvDataGridViewTextBoxColumn.DataPropertyName = "kdv";
            this.kdvDataGridViewTextBoxColumn.HeaderText = "KDV";
            this.kdvDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kdvDataGridViewTextBoxColumn.Name = "kdvDataGridViewTextBoxColumn";
            this.kdvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kdvharictutarDataGridViewTextBoxColumn
            // 
            this.kdvharictutarDataGridViewTextBoxColumn.DataPropertyName = "kdvharictutar";
            this.kdvharictutarDataGridViewTextBoxColumn.HeaderText = "KDV Haric";
            this.kdvharictutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kdvharictutarDataGridViewTextBoxColumn.Name = "kdvharictutarDataGridViewTextBoxColumn";
            this.kdvharictutarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kdvdahiltutarDataGridViewTextBoxColumn
            // 
            this.kdvdahiltutarDataGridViewTextBoxColumn.DataPropertyName = "kdvdahiltutar";
            this.kdvdahiltutarDataGridViewTextBoxColumn.HeaderText = "KDV Dahil";
            this.kdvdahiltutarDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kdvdahiltutarDataGridViewTextBoxColumn.Name = "kdvdahiltutarDataGridViewTextBoxColumn";
            this.kdvdahiltutarDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // durumDataGridViewTextBoxColumn
            // 
            this.durumDataGridViewTextBoxColumn.DataPropertyName = "durum";
            this.durumDataGridViewTextBoxColumn.HeaderText = "Durum";
            this.durumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.durumDataGridViewTextBoxColumn.Name = "durumDataGridViewTextBoxColumn";
            this.durumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // giderBindingSource
            // 
            this.giderBindingSource.DataMember = "gider";
            this.giderBindingSource.DataSource = this.databaseDataSet;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.Purple;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.nerdenDataGridViewTextBoxColumn1,
            this.tarihDataGridViewTextBoxColumn1,
            this.nedenDataGridViewTextBoxColumn,
            this.kdvDataGridViewTextBoxColumn1,
            this.kdvharictutarDataGridViewTextBoxColumn1,
            this.kdvdahiltutarDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.gelirBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(883, 512);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(853, 409);
            this.dataGridView2.TabIndex = 11;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Visible = false;
            // 
            // nerdenDataGridViewTextBoxColumn1
            // 
            this.nerdenDataGridViewTextBoxColumn1.DataPropertyName = "nerden";
            this.nerdenDataGridViewTextBoxColumn1.HeaderText = "Nerden";
            this.nerdenDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.nerdenDataGridViewTextBoxColumn1.Name = "nerdenDataGridViewTextBoxColumn1";
            this.nerdenDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // tarihDataGridViewTextBoxColumn1
            // 
            this.tarihDataGridViewTextBoxColumn1.DataPropertyName = "tarih";
            this.tarihDataGridViewTextBoxColumn1.HeaderText = "Tarih";
            this.tarihDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.tarihDataGridViewTextBoxColumn1.Name = "tarihDataGridViewTextBoxColumn1";
            this.tarihDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nedenDataGridViewTextBoxColumn
            // 
            this.nedenDataGridViewTextBoxColumn.DataPropertyName = "neden";
            this.nedenDataGridViewTextBoxColumn.HeaderText = "Açıklama";
            this.nedenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nedenDataGridViewTextBoxColumn.Name = "nedenDataGridViewTextBoxColumn";
            this.nedenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // kdvDataGridViewTextBoxColumn1
            // 
            this.kdvDataGridViewTextBoxColumn1.DataPropertyName = "kdv";
            this.kdvDataGridViewTextBoxColumn1.HeaderText = "KDV";
            this.kdvDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kdvDataGridViewTextBoxColumn1.Name = "kdvDataGridViewTextBoxColumn1";
            this.kdvDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kdvharictutarDataGridViewTextBoxColumn1
            // 
            this.kdvharictutarDataGridViewTextBoxColumn1.DataPropertyName = "kdvharictutar";
            this.kdvharictutarDataGridViewTextBoxColumn1.HeaderText = "KDV Haric";
            this.kdvharictutarDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kdvharictutarDataGridViewTextBoxColumn1.Name = "kdvharictutarDataGridViewTextBoxColumn1";
            this.kdvharictutarDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // kdvdahiltutarDataGridViewTextBoxColumn1
            // 
            this.kdvdahiltutarDataGridViewTextBoxColumn1.DataPropertyName = "kdvdahiltutar";
            this.kdvdahiltutarDataGridViewTextBoxColumn1.HeaderText = "KDV Dahil";
            this.kdvdahiltutarDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.kdvdahiltutarDataGridViewTextBoxColumn1.Name = "kdvdahiltutarDataGridViewTextBoxColumn1";
            this.kdvdahiltutarDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // gelirBindingSource
            // 
            this.gelirBindingSource.DataMember = "gelir";
            this.gelirBindingSource.DataSource = this.databaseDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Firma Adı:";
            // 
            // tarih
            // 
            this.tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarih.Location = new System.Drawing.Point(155, 52);
            this.tarih.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tarih.Name = "tarih";
            this.tarih.Size = new System.Drawing.Size(233, 34);
            this.tarih.TabIndex = 2;
            this.tarih.ValueChanged += new System.EventHandler(this.tarih_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tarih : ";
            // 
            // aciklama
            // 
            this.aciklama.Location = new System.Drawing.Point(155, 139);
            this.aciklama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aciklama.Name = "aciklama";
            this.aciklama.Size = new System.Drawing.Size(233, 34);
            this.aciklama.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ürün Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 29);
            this.label4.TabIndex = 7;
            // 
            // firmaadi
            // 
            this.firmaadi.DataSource = this.firmalarBindingSource;
            this.firmaadi.DisplayMember = "adi";
            this.firmaadi.FormattingEnabled = true;
            this.firmaadi.Location = new System.Drawing.Point(155, 95);
            this.firmaadi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firmaadi.Name = "firmaadi";
            this.firmaadi.Size = new System.Drawing.Size(233, 37);
            this.firmaadi.TabIndex = 8;
            this.firmaadi.ValueMember = "id";
            // 
            // adetfiyat
            // 
            this.adetfiyat.Location = new System.Drawing.Point(581, 96);
            this.adetfiyat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.adetfiyat.Name = "adetfiyat";
            this.adetfiyat.Size = new System.Drawing.Size(155, 34);
            this.adetfiyat.TabIndex = 10;
            this.adetfiyat.TextChanged += new System.EventHandler(this.birimfiyat_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(431, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 29);
            this.label6.TabIndex = 11;
            this.label6.Text = "KDV Oranı :";
            // 
            // gidergir
            // 
            this.gidergir.BackColor = System.Drawing.Color.Purple;
            this.gidergir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gidergir.Location = new System.Drawing.Point(31, 306);
            this.gidergir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gidergir.Name = "gidergir";
            this.gidergir.Size = new System.Drawing.Size(331, 47);
            this.gidergir.TabIndex = 12;
            this.gidergir.Text = "Gider Gir";
            this.gidergir.UseVisualStyleBackColor = false;
            this.gidergir.Click += new System.EventHandler(this.gidergir_Click);
            // 
            // gelirgir
            // 
            this.gelirgir.BackColor = System.Drawing.Color.Purple;
            this.gelirgir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gelirgir.Location = new System.Drawing.Point(393, 306);
            this.gelirgir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gelirgir.Name = "gelirgir";
            this.gelirgir.Size = new System.Drawing.Size(344, 47);
            this.gelirgir.TabIndex = 13;
            this.gelirgir.Text = "Gelir Gir";
            this.gelirgir.UseVisualStyleBackColor = false;
            this.gelirgir.Click += new System.EventHandler(this.gelirgir_Click);
            // 
            // kdvdahil
            // 
            this.kdvdahil.AutoSize = true;
            this.kdvdahil.Checked = true;
            this.kdvdahil.Location = new System.Drawing.Point(31, 203);
            this.kdvdahil.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kdvdahil.Name = "kdvdahil";
            this.kdvdahil.Size = new System.Drawing.Size(143, 33);
            this.kdvdahil.TabIndex = 14;
            this.kdvdahil.TabStop = true;
            this.kdvdahil.Text = "KDV Dahil";
            this.kdvdahil.UseVisualStyleBackColor = true;
            this.kdvdahil.CheckedChanged += new System.EventHandler(this.kdvdahil_CheckedChanged);
            // 
            // kdvharic
            // 
            this.kdvharic.AutoSize = true;
            this.kdvharic.Location = new System.Drawing.Point(31, 245);
            this.kdvharic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kdvharic.Name = "kdvharic";
            this.kdvharic.Size = new System.Drawing.Size(144, 33);
            this.kdvharic.TabIndex = 15;
            this.kdvharic.Text = "KDV Hariç";
            this.kdvharic.UseVisualStyleBackColor = true;
            this.kdvharic.CheckedChanged += new System.EventHandler(this.kdvharic_CheckedChanged);
            // 
            // miktar
            // 
            this.miktar.Location = new System.Drawing.Point(581, 53);
            this.miktar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.miktar.Name = "miktar";
            this.miktar.Size = new System.Drawing.Size(155, 34);
            this.miktar.TabIndex = 16;
            this.miktar.TextChanged += new System.EventHandler(this.miktar_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(431, 55);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ürün Adet :";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(431, 100);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(144, 29);
            this.label19.TabIndex = 18;
            this.label19.Text = "Birim Fiyatı :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.toplamtutar);
            this.groupBox1.Controls.Add(this.kdvtutari);
            this.groupBox1.Controls.Add(this.kdvorani);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.miktar);
            this.groupBox1.Controls.Add(this.kdvharic);
            this.groupBox1.Controls.Add(this.kdvdahil);
            this.groupBox1.Controls.Add(this.gelirgir);
            this.groupBox1.Controls.Add(this.gidergir);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.adetfiyat);
            this.groupBox1.Controls.Add(this.firmaadi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.aciklama);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tarih);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(16, 53);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(763, 368);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gelir - Gider";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // toplamtutar
            // 
            this.toplamtutar.BackColor = System.Drawing.Color.Transparent;
            this.toplamtutar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toplamtutar.Location = new System.Drawing.Point(393, 247);
            this.toplamtutar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.toplamtutar.Name = "toplamtutar";
            this.toplamtutar.Size = new System.Drawing.Size(343, 32);
            this.toplamtutar.TabIndex = 21;
            this.toplamtutar.Text = "Toplam Tutar : ";
            // 
            // kdvtutari
            // 
            this.kdvtutari.BackColor = System.Drawing.Color.Transparent;
            this.kdvtutari.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kdvtutari.Location = new System.Drawing.Point(393, 206);
            this.kdvtutari.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kdvtutari.Name = "kdvtutari";
            this.kdvtutari.Size = new System.Drawing.Size(343, 29);
            this.kdvtutari.TabIndex = 20;
            this.kdvtutari.Text = "KDV Tutarı :";
            // 
            // kdvorani
            // 
            this.kdvorani.FormattingEnabled = true;
            this.kdvorani.Items.AddRange(new object[] {
            "%1",
            "%8",
            "%18"});
            this.kdvorani.Location = new System.Drawing.Point(581, 138);
            this.kdvorani.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kdvorani.Name = "kdvorani";
            this.kdvorani.Size = new System.Drawing.Size(155, 37);
            this.kdvorani.TabIndex = 19;
            this.kdvorani.Text = "%8";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Purple;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(671, 460);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(185, 41);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // giderTableAdapter
            // 
            this.giderTableAdapter.ClearBeforeFill = true;
            // 
            // gelirTableAdapter
            // 
            this.gelirTableAdapter.ClearBeforeFill = true;
            // 
            // firmalarTableAdapter
            // 
            this.firmalarTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Purple;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(477, 460);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(185, 41);
            this.button3.TabIndex = 14;
            this.button3.Text = "Ödendi";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toolStrip1.BackgroundImage")));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1753, 27);
            this.toolStrip1.TabIndex = 16;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(60, 24);
            this.toolStripButton3.Text = "Ayarlar";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(64, 24);
            this.toolStripButton2.Text = "Yedekle";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(122, 24);
            this.toolStripButton1.Text = "Yedek Geri Yükle";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1753, 939);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Gelir - Gider";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.firmalarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.giderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gelirBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button firmasil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox eklefirmaadi;
        private System.Windows.Forms.Button firmakaydet;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox eklefirmatelefon;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox eklefirmaadres;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buayyazdir;
        private System.Windows.Forms.Button butunaylariyazdir;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox listelefirmaadi;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label toplambakiye;
        private System.Windows.Forms.Label buaykibakiye;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker tarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox aciklama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox firmaadi;
        private System.Windows.Forms.TextBox adetfiyat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button gidergir;
        private System.Windows.Forms.Button gelirgir;
        private System.Windows.Forms.RadioButton kdvdahil;
        private System.Windows.Forms.RadioButton kdvharic;
        private System.Windows.Forms.TextBox miktar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.Label toplamtutar;
        private System.Windows.Forms.Label kdvtutari;
        private System.Windows.Forms.ComboBox kdvorani;
        private System.Windows.Forms.Button button1;
        private databaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource giderBindingSource;
        private databaseDataSetTableAdapters.giderTableAdapter giderTableAdapter;
        private System.Windows.Forms.BindingSource gelirBindingSource;
        private databaseDataSetTableAdapters.gelirTableAdapter gelirTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nerdenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alinanmalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunadetDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birimfiyatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvharictutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvdahiltutarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn durumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nerdenDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nedenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvharictutarDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn kdvdahiltutarDataGridViewTextBoxColumn1;
        private System.Windows.Forms.BindingSource firmalarBindingSource;
        private databaseDataSetTableAdapters.firmalarTableAdapter firmalarTableAdapter;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStrip toolStrip1;
        protected System.Windows.Forms.ToolStripButton toolStripButton3;
        protected System.Windows.Forms.ToolStripButton toolStripButton2;
        protected System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

