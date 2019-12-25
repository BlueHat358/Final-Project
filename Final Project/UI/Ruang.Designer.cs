namespace Final_Project.UI
{
    partial class frmRuang
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
            this.btnHapus = new System.Windows.Forms.Button();
            this.dgvRuang = new System.Windows.Forms.DataGridView();
            this.id_ruang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_ruang_ruang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_barang_ruang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_barang_ruang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnRuang = new System.Windows.Forms.Button();
            this.btnPelapor = new System.Windows.Forms.Button();
            this.btnPenemu = new System.Windows.Forms.Button();
            this.btnBarang = new System.Windows.Forms.Button();
            this.btnTambahkan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuang)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHapus
            // 
            this.btnHapus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(80)))), ((int)(((byte)(74)))));
            this.btnHapus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHapus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHapus.Location = new System.Drawing.Point(481, 301);
            this.btnHapus.Margin = new System.Windows.Forms.Padding(2);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(87, 39);
            this.btnHapus.TabIndex = 15;
            this.btnHapus.Text = "HAPUS";
            this.btnHapus.UseVisualStyleBackColor = false;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // dgvRuang
            // 
            this.dgvRuang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvRuang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRuang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_ruang,
            this.nama_ruang_ruang,
            this.id_barang_ruang,
            this.nama_barang_ruang,
            this.status});
            this.dgvRuang.Location = new System.Drawing.Point(7, 7);
            this.dgvRuang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRuang.Name = "dgvRuang";
            this.dgvRuang.RowTemplate.Height = 24;
            this.dgvRuang.Size = new System.Drawing.Size(398, 247);
            this.dgvRuang.TabIndex = 13;
            // 
            // id_ruang
            // 
            this.id_ruang.HeaderText = "ID Ruang";
            this.id_ruang.Name = "id_ruang";
            // 
            // nama_ruang_ruang
            // 
            this.nama_ruang_ruang.HeaderText = "Nama Ruang";
            this.nama_ruang_ruang.Name = "nama_ruang_ruang";
            // 
            // id_barang_ruang
            // 
            this.id_barang_ruang.HeaderText = "ID Barang";
            this.id_barang_ruang.Name = "id_barang_ruang";
            // 
            // nama_barang_ruang
            // 
            this.nama_barang_ruang.HeaderText = "Nama Barang";
            this.nama_barang_ruang.Name = "nama_barang_ruang";
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(17)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnRuang);
            this.panel1.Controls.Add(this.btnPelapor);
            this.panel1.Controls.Add(this.btnPenemu);
            this.panel1.Controls.Add(this.btnBarang);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 374);
            this.panel1.TabIndex = 12;
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
            this.btnLogOut.TabIndex = 9;
            this.btnLogOut.Text = "LOG OUT";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnRuang
            // 
            this.btnRuang.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnRuang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRuang.Location = new System.Drawing.Point(8, 154);
            this.btnRuang.Margin = new System.Windows.Forms.Padding(2);
            this.btnRuang.Name = "btnRuang";
            this.btnRuang.Size = new System.Drawing.Size(142, 38);
            this.btnRuang.TabIndex = 4;
            this.btnRuang.Text = "RUANG";
            this.btnRuang.UseVisualStyleBackColor = false;
            // 
            // btnPelapor
            // 
            this.btnPelapor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(194)))));
            this.btnPelapor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPelapor.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPelapor.Location = new System.Drawing.Point(8, 112);
            this.btnPelapor.Margin = new System.Windows.Forms.Padding(2);
            this.btnPelapor.Name = "btnPelapor";
            this.btnPelapor.Size = new System.Drawing.Size(142, 38);
            this.btnPelapor.TabIndex = 2;
            this.btnPelapor.Text = "PELAPOR";
            this.btnPelapor.UseVisualStyleBackColor = false;
            this.btnPelapor.Click += new System.EventHandler(this.btnPelapor_Click);
            // 
            // btnPenemu
            // 
            this.btnPenemu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(194)))));
            this.btnPenemu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPenemu.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPenemu.Location = new System.Drawing.Point(8, 69);
            this.btnPenemu.Margin = new System.Windows.Forms.Padding(2);
            this.btnPenemu.Name = "btnPenemu";
            this.btnPenemu.Size = new System.Drawing.Size(142, 38);
            this.btnPenemu.TabIndex = 1;
            this.btnPenemu.Text = "PENEMU";
            this.btnPenemu.UseVisualStyleBackColor = false;
            this.btnPenemu.Click += new System.EventHandler(this.btnPenemu_Click);
            // 
            // btnBarang
            // 
            this.btnBarang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(194)))));
            this.btnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBarang.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBarang.Location = new System.Drawing.Point(8, 26);
            this.btnBarang.Margin = new System.Windows.Forms.Padding(2);
            this.btnBarang.Name = "btnBarang";
            this.btnBarang.Size = new System.Drawing.Size(142, 38);
            this.btnBarang.TabIndex = 0;
            this.btnBarang.Text = "BARANG";
            this.btnBarang.UseVisualStyleBackColor = false;
            this.btnBarang.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnTambahkan
            // 
            this.btnTambahkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(194)))));
            this.btnTambahkan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTambahkan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTambahkan.Location = new System.Drawing.Point(191, 301);
            this.btnTambahkan.Margin = new System.Windows.Forms.Padding(2);
            this.btnTambahkan.Name = "btnTambahkan";
            this.btnTambahkan.Size = new System.Drawing.Size(87, 39);
            this.btnTambahkan.TabIndex = 16;
            this.btnTambahkan.Text = "TAMBAHKAN";
            this.btnTambahkan.UseVisualStyleBackColor = false;
            this.btnTambahkan.Click += new System.EventHandler(this.btnTambahkan_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.dgvRuang);
            this.panel2.Location = new System.Drawing.Point(174, 18);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 266);
            this.panel2.TabIndex = 17;
            // 
            // frmRuang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnTambahkan);
            this.Controls.Add(this.btnHapus);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRuang";
            this.Text = "Ruang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRuang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.DataGridView dgvRuang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRuang;
        private System.Windows.Forms.Button btnPelapor;
        private System.Windows.Forms.Button btnPenemu;
        private System.Windows.Forms.Button btnBarang;
        private System.Windows.Forms.Button btnTambahkan;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ruang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_ruang_ruang;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barang_ruang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_barang_ruang;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        protected internal System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel2;
    }
}