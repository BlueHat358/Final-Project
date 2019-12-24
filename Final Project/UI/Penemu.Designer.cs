namespace Final_Project.UI
{
    partial class frmPenemu
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
            this.btnPELAPOR = new System.Windows.Forms.Button();
            this.btnPenemu = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnLanjut = new System.Windows.Forms.Button();
            this.btnTampilkan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbRuang = new System.Windows.Forms.ComboBox();
            this.cmbJenisBarang = new System.Windows.Forms.ComboBox();
            this.txtNamaBarang = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNamaPenemu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(17)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnRuang);
            this.panel1.Controls.Add(this.btnPELAPOR);
            this.panel1.Controls.Add(this.btnPenemu);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 374);
            this.panel1.TabIndex = 1;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(74)))));
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogOut.Location = new System.Drawing.Point(8, 314);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(142, 38);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnRuang
            // 
            this.btnRuang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(194)))));
            this.btnRuang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRuang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRuang.Location = new System.Drawing.Point(8, 155);
            this.btnRuang.Margin = new System.Windows.Forms.Padding(2);
            this.btnRuang.Name = "btnRuang";
            this.btnRuang.Size = new System.Drawing.Size(142, 38);
            this.btnRuang.TabIndex = 4;
            this.btnRuang.Text = "RUANG";
            this.btnRuang.UseVisualStyleBackColor = false;
            this.btnRuang.Click += new System.EventHandler(this.btnRuang_Click);
            // 
            // btnPELAPOR
            // 
            this.btnPELAPOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(194)))));
            this.btnPELAPOR.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPELAPOR.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPELAPOR.Location = new System.Drawing.Point(8, 112);
            this.btnPELAPOR.Margin = new System.Windows.Forms.Padding(2);
            this.btnPELAPOR.Name = "btnPELAPOR";
            this.btnPELAPOR.Size = new System.Drawing.Size(142, 38);
            this.btnPELAPOR.TabIndex = 2;
            this.btnPELAPOR.Text = "PELAPOR";
            this.btnPELAPOR.UseVisualStyleBackColor = false;
            this.btnPELAPOR.Click += new System.EventHandler(this.btnPelapor_Click);
            // 
            // btnPenemu
            // 
            this.btnPenemu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnPenemu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPenemu.Location = new System.Drawing.Point(8, 69);
            this.btnPenemu.Margin = new System.Windows.Forms.Padding(2);
            this.btnPenemu.Name = "btnPenemu";
            this.btnPenemu.Size = new System.Drawing.Size(142, 38);
            this.btnPenemu.TabIndex = 1;
            this.btnPenemu.Text = "PENEMU";
            this.btnPenemu.UseVisualStyleBackColor = false;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(194)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHome.Location = new System.Drawing.Point(8, 26);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(142, 38);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLanjut
            // 
            this.btnLanjut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(194)))));
            this.btnLanjut.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLanjut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLanjut.Location = new System.Drawing.Point(190, 300);
            this.btnLanjut.Margin = new System.Windows.Forms.Padding(2);
            this.btnLanjut.Name = "btnLanjut";
            this.btnLanjut.Size = new System.Drawing.Size(87, 39);
            this.btnLanjut.TabIndex = 12;
            this.btnLanjut.Text = "LANJUT";
            this.btnLanjut.UseVisualStyleBackColor = false;
            this.btnLanjut.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnTampilkan
            // 
            this.btnTampilkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(194)))));
            this.btnTampilkan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTampilkan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTampilkan.Location = new System.Drawing.Point(480, 300);
            this.btnTampilkan.Margin = new System.Windows.Forms.Padding(2);
            this.btnTampilkan.Name = "btnTampilkan";
            this.btnTampilkan.Size = new System.Drawing.Size(87, 39);
            this.btnTampilkan.TabIndex = 13;
            this.btnTampilkan.Text = "TAMPILKAN";
            this.btnTampilkan.UseVisualStyleBackColor = false;
            this.btnTampilkan.Click += new System.EventHandler(this.btnTampilkan_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.cmbRuang);
            this.panel2.Controls.Add(this.cmbJenisBarang);
            this.panel2.Controls.Add(this.txtNamaBarang);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtNamaPenemu);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(175, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 204);
            this.panel2.TabIndex = 14;
            // 
            // cmbRuang
            // 
            this.cmbRuang.FormattingEnabled = true;
            this.cmbRuang.Location = new System.Drawing.Point(136, 150);
            this.cmbRuang.Margin = new System.Windows.Forms.Padding(2);
            this.cmbRuang.Name = "cmbRuang";
            this.cmbRuang.Size = new System.Drawing.Size(66, 21);
            this.cmbRuang.TabIndex = 21;
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
            "kunci"});
            this.cmbJenisBarang.Location = new System.Drawing.Point(136, 64);
            this.cmbJenisBarang.Margin = new System.Windows.Forms.Padding(2);
            this.cmbJenisBarang.Name = "cmbJenisBarang";
            this.cmbJenisBarang.Size = new System.Drawing.Size(122, 21);
            this.cmbJenisBarang.TabIndex = 20;
            // 
            // txtNamaBarang
            // 
            this.txtNamaBarang.Location = new System.Drawing.Point(136, 107);
            this.txtNamaBarang.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamaBarang.Name = "txtNamaBarang";
            this.txtNamaBarang.Size = new System.Drawing.Size(122, 20);
            this.txtNamaBarang.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 152);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Ruang";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 109);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nama Barang";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 66);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Jenis Barang";
            // 
            // txtNamaPenemu
            // 
            this.txtNamaPenemu.Location = new System.Drawing.Point(136, 20);
            this.txtNamaPenemu.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamaPenemu.Name = "txtNamaPenemu";
            this.txtNamaPenemu.Size = new System.Drawing.Size(122, 20);
            this.txtNamaPenemu.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nama Penemu";
            // 
            // frmPenemu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnTampilkan);
            this.Controls.Add(this.btnLanjut);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPenemu";
            this.Text = "Penemu";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRuang;
        private System.Windows.Forms.Button btnPELAPOR;
        private System.Windows.Forms.Button btnPenemu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnLanjut;
        private System.Windows.Forms.Button btnTampilkan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbRuang;
        private System.Windows.Forms.ComboBox cmbJenisBarang;
        private System.Windows.Forms.TextBox txtNamaBarang;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNamaPenemu;
        private System.Windows.Forms.Label label1;
        protected internal System.Windows.Forms.Button btnLogOut;
    }
}