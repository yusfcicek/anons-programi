
namespace Anons_Programı
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.saat_lbl = new System.Windows.Forms.Label();
            this.sesDosyasi_lbl = new System.Windows.Forms.Label();
            this.sesDosyasi_txt = new System.Windows.Forms.TextBox();
            this.saat_txt = new System.Windows.Forms.TextBox();
            this.ekle_btn = new System.Windows.Forms.Button();
            this.guncelle_btn = new System.Windows.Forms.Button();
            this.dosyaSec_btn = new System.Windows.Forms.Button();
            this.sil_btn = new System.Windows.Forms.Button();
            this.durdur_btn = new System.Windows.Forms.Button();
            this.otoBaslat_checkBox = new System.Windows.Forms.CheckBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Saat_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sesDosyasi_Column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // saat_lbl
            // 
            this.saat_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saat_lbl.Location = new System.Drawing.Point(8, 9);
            this.saat_lbl.Name = "saat_lbl";
            this.saat_lbl.Size = new System.Drawing.Size(235, 23);
            this.saat_lbl.TabIndex = 0;
            this.saat_lbl.Text = "Hangi Saatte Anons Yapılacak : ";
            // 
            // sesDosyasi_lbl
            // 
            this.sesDosyasi_lbl.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F);
            this.sesDosyasi_lbl.Location = new System.Drawing.Point(8, 48);
            this.sesDosyasi_lbl.Name = "sesDosyasi_lbl";
            this.sesDosyasi_lbl.Size = new System.Drawing.Size(271, 23);
            this.sesDosyasi_lbl.TabIndex = 1;
            this.sesDosyasi_lbl.Text = "Hangi Ses Dosyası Anons Yapılacak :";
            // 
            // sesDosyasi_txt
            // 
            this.sesDosyasi_txt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F);
            this.sesDosyasi_txt.Location = new System.Drawing.Point(280, 46);
            this.sesDosyasi_txt.Name = "sesDosyasi_txt";
            this.sesDosyasi_txt.ReadOnly = true;
            this.sesDosyasi_txt.Size = new System.Drawing.Size(394, 25);
            this.sesDosyasi_txt.TabIndex = 2;
            // 
            // saat_txt
            // 
            this.saat_txt.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saat_txt.Location = new System.Drawing.Point(242, 7);
            this.saat_txt.Name = "saat_txt";
            this.saat_txt.Size = new System.Drawing.Size(174, 25);
            this.saat_txt.TabIndex = 3;
            // 
            // ekle_btn
            // 
            this.ekle_btn.Location = new System.Drawing.Point(455, 4);
            this.ekle_btn.Name = "ekle_btn";
            this.ekle_btn.Size = new System.Drawing.Size(102, 32);
            this.ekle_btn.TabIndex = 4;
            this.ekle_btn.Text = "Ekle";
            this.ekle_btn.UseVisualStyleBackColor = true;
            this.ekle_btn.Click += new System.EventHandler(this.ekle_btn_Click);
            // 
            // guncelle_btn
            // 
            this.guncelle_btn.Location = new System.Drawing.Point(572, 4);
            this.guncelle_btn.Name = "guncelle_btn";
            this.guncelle_btn.Size = new System.Drawing.Size(102, 32);
            this.guncelle_btn.TabIndex = 5;
            this.guncelle_btn.Text = "Güncelle";
            this.guncelle_btn.UseVisualStyleBackColor = true;
            this.guncelle_btn.Click += new System.EventHandler(this.guncelle_btn_Click);
            // 
            // dosyaSec_btn
            // 
            this.dosyaSec_btn.Location = new System.Drawing.Point(686, 43);
            this.dosyaSec_btn.Name = "dosyaSec_btn";
            this.dosyaSec_btn.Size = new System.Drawing.Size(102, 32);
            this.dosyaSec_btn.TabIndex = 6;
            this.dosyaSec_btn.Text = "Dosya Seç";
            this.dosyaSec_btn.UseVisualStyleBackColor = true;
            this.dosyaSec_btn.Click += new System.EventHandler(this.dosyaSec_btn_Click);
            // 
            // sil_btn
            // 
            this.sil_btn.Location = new System.Drawing.Point(686, 4);
            this.sil_btn.Name = "sil_btn";
            this.sil_btn.Size = new System.Drawing.Size(102, 32);
            this.sil_btn.TabIndex = 7;
            this.sil_btn.Text = "Sil";
            this.sil_btn.UseVisualStyleBackColor = true;
            this.sil_btn.Click += new System.EventHandler(this.sil_btn_Click);
            // 
            // durdur_btn
            // 
            this.durdur_btn.Location = new System.Drawing.Point(651, 95);
            this.durdur_btn.Name = "durdur_btn";
            this.durdur_btn.Size = new System.Drawing.Size(137, 32);
            this.durdur_btn.TabIndex = 8;
            this.durdur_btn.Text = "Uygulamadan Çıkış";
            this.durdur_btn.UseVisualStyleBackColor = true;
            this.durdur_btn.Click += new System.EventHandler(this.durdur_btn_Click);
            // 
            // otoBaslat_checkBox
            // 
            this.otoBaslat_checkBox.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.otoBaslat_checkBox.Location = new System.Drawing.Point(12, 103);
            this.otoBaslat_checkBox.Name = "otoBaslat_checkBox";
            this.otoBaslat_checkBox.Size = new System.Drawing.Size(303, 24);
            this.otoBaslat_checkBox.TabIndex = 9;
            this.otoBaslat_checkBox.Text = "Bilgisayar Başlatıldığında Otomatik Başlatılsın";
            this.otoBaslat_checkBox.UseVisualStyleBackColor = true;
            this.otoBaslat_checkBox.CheckedChanged += new System.EventHandler(this.otoBaslat_checkBox_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeight = 32;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Column,
            this.Saat_Column,
            this.sesDosyasi_Column});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 144);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 32;
            this.dataGridView1.Size = new System.Drawing.Size(776, 272);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // ID_Column
            // 
            this.ID_Column.HeaderText = "ID";
            this.ID_Column.Name = "ID_Column";
            this.ID_Column.Width = 75;
            // 
            // Saat_Column
            // 
            this.Saat_Column.HeaderText = "Saat";
            this.Saat_Column.Name = "Saat_Column";
            this.Saat_Column.Width = 150;
            // 
            // sesDosyasi_Column
            // 
            this.sesDosyasi_Column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sesDosyasi_Column.HeaderText = "Ses Dosyası";
            this.sesDosyasi_Column.Name = "sesDosyasi_Column";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 428);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.otoBaslat_checkBox);
            this.Controls.Add(this.durdur_btn);
            this.Controls.Add(this.sil_btn);
            this.Controls.Add(this.dosyaSec_btn);
            this.Controls.Add(this.guncelle_btn);
            this.Controls.Add(this.ekle_btn);
            this.Controls.Add(this.saat_txt);
            this.Controls.Add(this.sesDosyasi_txt);
            this.Controls.Add(this.sesDosyasi_lbl);
            this.Controls.Add(this.saat_lbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Anons Programı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saat_lbl;
        private System.Windows.Forms.Label sesDosyasi_lbl;
        private System.Windows.Forms.TextBox sesDosyasi_txt;
        private System.Windows.Forms.TextBox saat_txt;
        private System.Windows.Forms.Button ekle_btn;
        private System.Windows.Forms.Button guncelle_btn;
        private System.Windows.Forms.Button dosyaSec_btn;
        private System.Windows.Forms.Button sil_btn;
        private System.Windows.Forms.Button durdur_btn;
        private System.Windows.Forms.CheckBox otoBaslat_checkBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn Saat_Column;
        private System.Windows.Forms.DataGridViewTextBoxColumn sesDosyasi_Column;
    }
}

