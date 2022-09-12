
namespace MaasHesap
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
            this.rdb_yonetim = new System.Windows.Forms.RadioButton();
            this.rdb_ogretmen = new System.Windows.Forms.RadioButton();
            this.rdb_personel = new System.Windows.Forms.RadioButton();
            this.grp_departman = new System.Windows.Forms.GroupBox();
            this.nud_tucrubeYili = new System.Windows.Forms.NumericUpDown();
            this.grp_tecrubeYili = new System.Windows.Forms.GroupBox();
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.grp_tarihSecimi = new System.Windows.Forms.GroupBox();
            this.dtp_tarihSecimi = new System.Windows.Forms.DateTimePicker();
            this.txt_hesaplananMaas = new System.Windows.Forms.TextBox();
            this.lbl_MaasBilgisi = new System.Windows.Forms.Label();
            this.nud_maasKatsayisi = new System.Windows.Forms.NumericUpDown();
            this.grp_maasKatsayi = new System.Windows.Forms.GroupBox();
            this.grp_departman.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tucrubeYili)).BeginInit();
            this.grp_tecrubeYili.SuspendLayout();
            this.grp_tarihSecimi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_maasKatsayisi)).BeginInit();
            this.grp_maasKatsayi.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdb_yonetim
            // 
            this.rdb_yonetim.AutoSize = true;
            this.rdb_yonetim.Location = new System.Drawing.Point(6, 19);
            this.rdb_yonetim.Name = "rdb_yonetim";
            this.rdb_yonetim.Size = new System.Drawing.Size(63, 17);
            this.rdb_yonetim.TabIndex = 0;
            this.rdb_yonetim.TabStop = true;
            this.rdb_yonetim.Text = "Yönetim";
            this.rdb_yonetim.UseVisualStyleBackColor = true;
            // 
            // rdb_ogretmen
            // 
            this.rdb_ogretmen.AutoSize = true;
            this.rdb_ogretmen.Location = new System.Drawing.Point(75, 19);
            this.rdb_ogretmen.Name = "rdb_ogretmen";
            this.rdb_ogretmen.Size = new System.Drawing.Size(71, 17);
            this.rdb_ogretmen.TabIndex = 1;
            this.rdb_ogretmen.TabStop = true;
            this.rdb_ogretmen.Text = "Öğretmen";
            this.rdb_ogretmen.UseVisualStyleBackColor = true;
            // 
            // rdb_personel
            // 
            this.rdb_personel.AutoSize = true;
            this.rdb_personel.Location = new System.Drawing.Point(152, 19);
            this.rdb_personel.Name = "rdb_personel";
            this.rdb_personel.Size = new System.Drawing.Size(66, 17);
            this.rdb_personel.TabIndex = 2;
            this.rdb_personel.TabStop = true;
            this.rdb_personel.Text = "Personel";
            this.rdb_personel.UseVisualStyleBackColor = true;
            // 
            // grp_departman
            // 
            this.grp_departman.Controls.Add(this.rdb_yonetim);
            this.grp_departman.Controls.Add(this.rdb_personel);
            this.grp_departman.Controls.Add(this.rdb_ogretmen);
            this.grp_departman.Location = new System.Drawing.Point(12, 17);
            this.grp_departman.Name = "grp_departman";
            this.grp_departman.Size = new System.Drawing.Size(234, 50);
            this.grp_departman.TabIndex = 3;
            this.grp_departman.TabStop = false;
            this.grp_departman.Text = "Departman Seçimi";
            // 
            // nud_tucrubeYili
            // 
            this.nud_tucrubeYili.Location = new System.Drawing.Point(7, 19);
            this.nud_tucrubeYili.Name = "nud_tucrubeYili";
            this.nud_tucrubeYili.Size = new System.Drawing.Size(215, 20);
            this.nud_tucrubeYili.TabIndex = 4;
            // 
            // grp_tecrubeYili
            // 
            this.grp_tecrubeYili.Controls.Add(this.nud_tucrubeYili);
            this.grp_tecrubeYili.Location = new System.Drawing.Point(12, 189);
            this.grp_tecrubeYili.Name = "grp_tecrubeYili";
            this.grp_tecrubeYili.Size = new System.Drawing.Size(234, 50);
            this.grp_tecrubeYili.TabIndex = 4;
            this.grp_tecrubeYili.TabStop = false;
            this.grp_tecrubeYili.Text = "Tecrübe Yılı Seçimi";
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(12, 245);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(234, 23);
            this.btn_hesapla.TabIndex = 5;
            this.btn_hesapla.Text = "Maaş Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // grp_tarihSecimi
            // 
            this.grp_tarihSecimi.Controls.Add(this.dtp_tarihSecimi);
            this.grp_tarihSecimi.Location = new System.Drawing.Point(12, 73);
            this.grp_tarihSecimi.Name = "grp_tarihSecimi";
            this.grp_tarihSecimi.Size = new System.Drawing.Size(234, 51);
            this.grp_tarihSecimi.TabIndex = 5;
            this.grp_tarihSecimi.TabStop = false;
            this.grp_tarihSecimi.Text = "Tarih Seçimi";
            // 
            // dtp_tarihSecimi
            // 
            this.dtp_tarihSecimi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_tarihSecimi.Location = new System.Drawing.Point(7, 19);
            this.dtp_tarihSecimi.Name = "dtp_tarihSecimi";
            this.dtp_tarihSecimi.Size = new System.Drawing.Size(215, 20);
            this.dtp_tarihSecimi.TabIndex = 8;
            this.dtp_tarihSecimi.ValueChanged += new System.EventHandler(this.dtp_tarihSecimi_ValueChanged);
            // 
            // txt_hesaplananMaas
            // 
            this.txt_hesaplananMaas.Location = new System.Drawing.Point(12, 296);
            this.txt_hesaplananMaas.Name = "txt_hesaplananMaas";
            this.txt_hesaplananMaas.ReadOnly = true;
            this.txt_hesaplananMaas.Size = new System.Drawing.Size(234, 20);
            this.txt_hesaplananMaas.TabIndex = 6;
            // 
            // lbl_MaasBilgisi
            // 
            this.lbl_MaasBilgisi.AutoSize = true;
            this.lbl_MaasBilgisi.Location = new System.Drawing.Point(12, 280);
            this.lbl_MaasBilgisi.Name = "lbl_MaasBilgisi";
            this.lbl_MaasBilgisi.Size = new System.Drawing.Size(51, 13);
            this.lbl_MaasBilgisi.TabIndex = 7;
            this.lbl_MaasBilgisi.Text = "Maaşınız:";
            // 
            // nud_maasKatsayisi
            // 
            this.nud_maasKatsayisi.DecimalPlaces = 2;
            this.nud_maasKatsayisi.Location = new System.Drawing.Point(6, 19);
            this.nud_maasKatsayisi.Name = "nud_maasKatsayisi";
            this.nud_maasKatsayisi.Size = new System.Drawing.Size(216, 20);
            this.nud_maasKatsayisi.TabIndex = 8;
            // 
            // grp_maasKatsayi
            // 
            this.grp_maasKatsayi.Controls.Add(this.nud_maasKatsayisi);
            this.grp_maasKatsayi.Location = new System.Drawing.Point(12, 133);
            this.grp_maasKatsayi.Name = "grp_maasKatsayi";
            this.grp_maasKatsayi.Size = new System.Drawing.Size(234, 50);
            this.grp_maasKatsayi.TabIndex = 9;
            this.grp_maasKatsayi.TabStop = false;
            this.grp_maasKatsayi.Text = "Maaş Katsayısı Seçimi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 348);
            this.Controls.Add(this.grp_maasKatsayi);
            this.Controls.Add(this.lbl_MaasBilgisi);
            this.Controls.Add(this.txt_hesaplananMaas);
            this.Controls.Add(this.grp_tarihSecimi);
            this.Controls.Add(this.btn_hesapla);
            this.Controls.Add(this.grp_tecrubeYili);
            this.Controls.Add(this.grp_departman);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grp_departman.ResumeLayout(false);
            this.grp_departman.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_tucrubeYili)).EndInit();
            this.grp_tecrubeYili.ResumeLayout(false);
            this.grp_tarihSecimi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_maasKatsayisi)).EndInit();
            this.grp_maasKatsayi.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdb_yonetim;
        private System.Windows.Forms.RadioButton rdb_ogretmen;
        private System.Windows.Forms.RadioButton rdb_personel;
        private System.Windows.Forms.GroupBox grp_departman;
        private System.Windows.Forms.NumericUpDown nud_tucrubeYili;
        private System.Windows.Forms.GroupBox grp_tecrubeYili;
        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.GroupBox grp_tarihSecimi;
        private System.Windows.Forms.TextBox txt_hesaplananMaas;
        private System.Windows.Forms.Label lbl_MaasBilgisi;
        public System.Windows.Forms.DateTimePicker dtp_tarihSecimi;
        public System.Windows.Forms.NumericUpDown nud_maasKatsayisi;
        private System.Windows.Forms.GroupBox grp_maasKatsayi;
    }
}

