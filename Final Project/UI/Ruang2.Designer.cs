namespace Final_Project.UI
{
    partial class frmRuang2
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
            this.txtNamaRuang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnRuang = new System.Windows.Forms.Button();
            this.btnPelapor = new System.Windows.Forms.Button();
            this.btnPenemu = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnTambahkan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNamaRuang
            // 
            this.txtNamaRuang.Location = new System.Drawing.Point(124, 20);
            this.txtNamaRuang.Margin = new System.Windows.Forms.Padding(2);
            this.txtNamaRuang.Name = "txtNamaRuang";
            this.txtNamaRuang.Size = new System.Drawing.Size(98, 20);
            this.txtNamaRuang.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nama Ruang";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(17)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnRuang);
            this.panel1.Controls.Add(this.btnPelapor);
            this.panel1.Controls.Add(this.btnPenemu);
            this.panel1.Controls.Add(this.btnHome);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 374);
            this.panel1.TabIndex = 42;
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
            this.btnRuang.Click += new System.EventHandler(this.BtnRuang_Click);
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
            // btnTambahkan
            // 
            this.btnTambahkan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(194)))));
            this.btnTambahkan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTambahkan.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTambahkan.Location = new System.Drawing.Point(476, 292);
            this.btnTambahkan.Margin = new System.Windows.Forms.Padding(2);
            this.btnTambahkan.Name = "btnTambahkan";
            this.btnTambahkan.Size = new System.Drawing.Size(87, 39);
            this.btnTambahkan.TabIndex = 52;
            this.btnTambahkan.Text = "TAMBAHKAN";
            this.btnTambahkan.UseVisualStyleBackColor = false;
            this.btnTambahkan.Click += new System.EventHandler(this.btnTambahkan_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.txtNamaRuang);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(175, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 192);
            this.panel2.TabIndex = 53;
            // 
            // frmRuang2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnTambahkan);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmRuang2";
            this.Text = "Ruang2";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtNamaRuang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRuang;
        private System.Windows.Forms.Button btnPelapor;
        private System.Windows.Forms.Button btnPenemu;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnTambahkan;
        protected internal System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel2;
    }
}