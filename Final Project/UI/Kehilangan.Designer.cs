namespace Final_Project
{
    partial class frmKehilangan
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
            this.dgvBarang = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnRuang = new System.Windows.Forms.Button();
            this.btnPelapor = new System.Windows.Forms.Button();
            this.btnPenemu = new System.Windows.Forms.Button();
            this.btnBarang = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.id_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_ruang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jenis_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nama_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status_barang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBarang
            // 
            this.dgvBarang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBarang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_barang,
            this.id_ruang,
            this.jenis_barang,
            this.nama_barang,
            this.status_barang});
            this.dgvBarang.Location = new System.Drawing.Point(0, 2);
            this.dgvBarang.Margin = new System.Windows.Forms.Padding(2);
            this.dgvBarang.Name = "dgvBarang";
            this.dgvBarang.RowTemplate.Height = 24;
            this.dgvBarang.Size = new System.Drawing.Size(416, 305);
            this.dgvBarang.TabIndex = 1;
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
            this.panel1.TabIndex = 3;
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
            this.btnLogOut.TabIndex = 6;
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
            this.btnBarang.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnBarang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBarang.Location = new System.Drawing.Point(8, 26);
            this.btnBarang.Margin = new System.Windows.Forms.Padding(2);
            this.btnBarang.Name = "btnBarang";
            this.btnBarang.Size = new System.Drawing.Size(142, 38);
            this.btnBarang.TabIndex = 0;
            this.btnBarang.Text = "BARANG";
            this.btnBarang.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.dgvBarang);
            this.panel2.Location = new System.Drawing.Point(176, 44);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 309);
            this.panel2.TabIndex = 4;
            // 
            // id_barang
            // 
            this.id_barang.HeaderText = "ID Barang";
            this.id_barang.Name = "id_barang";
            // 
            // id_ruang
            // 
            this.id_ruang.HeaderText = "ID Ruang";
            this.id_ruang.Name = "id_ruang";
            // 
            // jenis_barang
            // 
            this.jenis_barang.HeaderText = "Jenis Barang";
            this.jenis_barang.Name = "jenis_barang";
            // 
            // nama_barang
            // 
            this.nama_barang.HeaderText = "Nama Barang";
            this.nama_barang.Name = "nama_barang";
            // 
            // status_barang
            // 
            this.status_barang.HeaderText = "Status";
            this.status_barang.Name = "status_barang";
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCari.ForeColor = System.Drawing.Color.White;
            this.btnCari.Location = new System.Drawing.Point(517, 10);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 23);
            this.btnCari.TabIndex = 14;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = false;
            this.btnCari.Click += new System.EventHandler(this.BtnCari_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(411, 12);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(100, 20);
            this.txtCari.TabIndex = 13;
            this.txtCari.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmKehilangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmKehilangan";
            this.Text = "Barang";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBarang)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvBarang;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRuang;
        private System.Windows.Forms.Button btnPelapor;
        private System.Windows.Forms.Button btnPenemu;
        private System.Windows.Forms.Button btnBarang;
        protected internal System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_ruang;
        private System.Windows.Forms.DataGridViewTextBoxColumn jenis_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn nama_barang;
        private System.Windows.Forms.DataGridViewTextBoxColumn status_barang;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtCari;
    }
}

