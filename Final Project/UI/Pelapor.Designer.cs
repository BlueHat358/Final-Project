namespace Final_Project.UI
{
    partial class frmPelapor
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnRuang = new System.Windows.Forms.Button();
            this.btnPelapor = new System.Windows.Forms.Button();
            this.btnPenemu = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.cmbJenisBarang = new System.Windows.Forms.ComboBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamaPelapor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbIdPelapor = new System.Windows.Forms.Label();
            this.txtIdPelapor = new System.Windows.Forms.TextBox();
            this.rbPelaporan = new System.Windows.Forms.RadioButton();
            this.rbDiambil = new System.Windows.Forms.RadioButton();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbIdBarang = new System.Windows.Forms.Label();
            this.txtIdBarang = new System.Windows.Forms.TextBox();
            this.txtNoTelp = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(17)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnRuang);
            this.panel1.Controls.Add(this.btnPelapor);
            this.panel1.Controls.Add(this.btnPenemu);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 374);
            this.panel1.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(74)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOut.Location = new System.Drawing.Point(8, 313);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(142, 38);
            this.btnLogOut.TabIndex = 7;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnRuang
            // 
            this.btnRuang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(194)))));
            this.btnRuang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRuang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRuang.Location = new System.Drawing.Point(8, 154);
            this.btnRuang.Margin = new System.Windows.Forms.Padding(2);
            this.btnRuang.Name = "btnRuang";
            this.btnRuang.Size = new System.Drawing.Size(142, 38);
            this.btnRuang.TabIndex = 4;
            this.btnRuang.Text = "RUANG";
            this.btnRuang.UseVisualStyleBackColor = false;
            this.btnRuang.Click += new System.EventHandler(this.btnRuang_Click);
            // 
            // btnPelapor
            // 
            this.btnPelapor.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPelapor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPelapor.Location = new System.Drawing.Point(8, 111);
            this.btnPelapor.Margin = new System.Windows.Forms.Padding(2);
            this.btnPelapor.Name = "btnPelapor";
            this.btnPelapor.Size = new System.Drawing.Size(142, 38);
            this.btnPelapor.TabIndex = 2;
            this.btnPelapor.Text = "PELAPOR";
            this.btnPelapor.UseVisualStyleBackColor = false;
            // 
            // btnPenemu
            // 
            this.btnPenemu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(194)))));
            this.btnPenemu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPenemu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPenemu.Location = new System.Drawing.Point(8, 68);
            this.btnPenemu.Margin = new System.Windows.Forms.Padding(2);
            this.btnPenemu.Name = "btnPenemu";
            this.btnPenemu.Size = new System.Drawing.Size(142, 38);
            this.btnPenemu.TabIndex = 1;
            this.btnPenemu.Text = "PENEMU";
            this.btnPenemu.UseVisualStyleBackColor = false;
            this.btnPenemu.Click += new System.EventHandler(this.btnPenemu_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(194)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.Location = new System.Drawing.Point(8, 25);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(142, 38);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(194)))));
            this.btnTampilkan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTampilkan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTampilkan.Location = new System.Drawing.Point(480, 299);
            this.btnTampilkan.Margin = new System.Windows.Forms.Padding(2);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(87, 39);
            this.btnTampilkan.TabIndex = 25;
            this.btnTampilkan.Text = "TAMPILKAN";
            this.btnTampilkan.UseVisualStyleBackColor = false;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(194)))));
            this.btnSimpan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSimpan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSimpan.Location = new System.Drawing.Point(190, 299);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(2);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(87, 39);
            this.btnSimpan.TabIndex = 24;
            this.btnSimpan.Text = "LANJUT";
            this.btnSimpan.UseVisualStyleBackColor = false;
            this.btnSimpan.Click += new System.EventHandler(this.btnLanjut_Click);
            // 
            // cmbJenisBarang
            // 
            this.cmbJenisBarang.FormattingEnabled = true;
            this.cmbJenisBarang.Items.AddRange(new object[] {
            "Identitas",
            "Dompet / Tas",
            "Surat",
            "Gadget",
            "Perhiasan",
            "Kunci"});
            this.cmbJenisBarang.Location = new System.Drawing.Point(136, 62);
            this.cmbJenisBarang.Margin = new System.Windows.Forms.Padding(2);
            this.cmbJenisBarang.Name = "cmbJenisBarang";
            this.cmbJenisBarang.Size = new System.Drawing.Size(122, 21);
            this.cmbJenisBarang.TabIndex = 22;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(136, 105);
            this.txtNamaBarang.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(170, 20);
            this.txtNamaBarang.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 64);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Jenis Barang";
            // 
            // txtNamaPelapor
            // 
            this.txtNamaPelapor.Location = new System.Drawing.Point(136, 19);
            this.txtNamaPelapor.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamaPelapor.Name = "txtNamaPelapor";
            this.txtNamaPelapor.Size = new System.Drawing.Size(170, 20);
            this.txtNamaPelapor.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nama Pelapor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 150);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "No. Telp";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.txtNoTelp);
            this.panel2.Controls.Add(this.lbIdPelapor);
            this.panel2.Controls.Add(this.txtIdPelapor);
            this.panel2.Controls.Add(this.rbPelaporan);
            this.panel2.Controls.Add(this.rbDiambil);
            this.panel2.Controls.Add(this.lbStatus);
            this.panel2.Controls.Add(this.lbIdBarang);
            this.panel2.Controls.Add(this.txtIdBarang);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtNamaPelapor);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.cmbJenisBarang);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtNamaBarang);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(175, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 264);
            this.panel2.TabIndex = 27;
            // 
            // lbIdPelapor
            // 
            this.lbIdPelapor.AutoSize = true;
            this.lbIdPelapor.Location = new System.Drawing.Point(17, 189);
            this.lbIdPelapor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIdPelapor.Name = "lbIdPelapor";
            this.lbIdPelapor.Size = new System.Drawing.Size(57, 13);
            this.lbIdPelapor.TabIndex = 32;
            this.lbIdPelapor.Text = "ID Pelapor";
            // 
            // txtIdPelapor
            // 
            this.txtIdPelapor.Location = new System.Drawing.Point(137, 186);
            this.txtIdPelapor.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdPelapor.Name = "txtIdPelapor";
            this.txtIdPelapor.Size = new System.Drawing.Size(80, 20);
            this.txtIdPelapor.TabIndex = 33;
            // 
            // rbPelaporan
            // 
            this.rbPelaporan.AutoSize = true;
            this.rbPelaporan.Location = new System.Drawing.Point(254, 226);
            this.rbPelaporan.Name = "rbPelaporan";
            this.rbPelaporan.Size = new System.Drawing.Size(73, 17);
            this.rbPelaporan.TabIndex = 31;
            this.rbPelaporan.Text = "Pelaporan";
            this.rbPelaporan.UseVisualStyleBackColor = true;
            // 
            // rbDiambil
            // 
            this.rbDiambil.AutoSize = true;
            this.rbDiambil.Checked = true;
            this.rbDiambil.Location = new System.Drawing.Point(136, 226);
            this.rbDiambil.Name = "rbDiambil";
            this.rbDiambil.Size = new System.Drawing.Size(59, 17);
            this.rbDiambil.TabIndex = 30;
            this.rbDiambil.TabStop = true;
            this.rbDiambil.Text = "Diambil";
            this.rbDiambil.UseVisualStyleBackColor = true;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(17, 226);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(37, 13);
            this.lbStatus.TabIndex = 29;
            this.lbStatus.Text = "Status";
            // 
            // lbIdBarang
            // 
            this.lbIdBarang.AutoSize = true;
            this.lbIdBarang.Location = new System.Drawing.Point(239, 189);
            this.lbIdBarang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbIdBarang.Name = "lbIdBarang";
            this.lbIdBarang.Size = new System.Drawing.Size(55, 13);
            this.lbIdBarang.TabIndex = 27;
            this.lbIdBarang.Text = "ID Barang";
            // 
            // txtIdBarang
            // 
            this.txtIdBarang.Location = new System.Drawing.Point(312, 186);
            this.txtIdBarang.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdBarang.Name = "txtIdBarang";
            this.txtIdBarang.Size = new System.Drawing.Size(80, 20);
            this.txtIdBarang.TabIndex = 28;
            // 
            // txtNoTelp
            // 
            this.txtNoTelp.Location = new System.Drawing.Point(137, 147);
            this.txtNoTelp.Name = "txtNoTelp";
            this.txtNoTelp.Size = new System.Drawing.Size(100, 20);
            this.txtNoTelp.TabIndex = 34;
            // 
            // frmPelapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPelapor";
            this.Text = "Pelapor";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRuang;
        private System.Windows.Forms.Button btnPelapor;
        private System.Windows.Forms.Button btnPenemu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.ComboBox cmbJenisBarang;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamaPelapor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        protected internal System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Label lbIdBarang;
        private System.Windows.Forms.TextBox txtIdBarang;
        private System.Windows.Forms.RadioButton rbPelaporan;
        private System.Windows.Forms.RadioButton rbDiambil;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbIdPelapor;
        private System.Windows.Forms.TextBox txtIdPelapor;
        private System.Windows.Forms.TextBox txtNoTelp;
    }
}