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
            this.dgvHome = new System.Windows.Forms.DataGridView();
            this.btnUbah = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnRuang = new System.Windows.Forms.Button();
            this.btnPelapor = new System.Windows.Forms.Button();
            this.btnPenemu = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHome)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHome
            // 
            this.dgvHome.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvHome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHome.Location = new System.Drawing.Point(8, 7);
            this.dgvHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHome.Name = "dgvHome";
            this.dgvHome.RowTemplate.Height = 24;
            this.dgvHome.Size = new System.Drawing.Size(398, 221);
            this.dgvHome.TabIndex = 1;
            // 
            // btnUbah
            // 
            this.btnUbah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(52)))), ((int)(((byte)(194)))));
            this.btnUbah.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUbah.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUbah.Location = new System.Drawing.Point(480, 300);
            this.btnUbah.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUbah.Name = "btnUbah";
            this.btnUbah.Size = new System.Drawing.Size(87, 39);
            this.btnUbah.TabIndex = 2;
            this.btnUbah.Text = "UBAH";
            this.btnUbah.UseVisualStyleBackColor = false;
            this.btnUbah.Click += new System.EventHandler(this.btnUbah_Click);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnRuang.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnPelapor.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.btnPenemu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPenemu.Name = "btnPenemu";
            this.btnPenemu.Size = new System.Drawing.Size(142, 38);
            this.btnPenemu.TabIndex = 1;
            this.btnPenemu.Text = "PENEMU";
            this.btnPenemu.UseVisualStyleBackColor = false;
            this.btnPenemu.Click += new System.EventHandler(this.btnPenemu_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHome.Location = new System.Drawing.Point(8, 26);
            this.btnHome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(142, 38);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "HOME";
            this.btnHome.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.dgvHome);
            this.panel2.Location = new System.Drawing.Point(176, 17);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(416, 242);
            this.panel2.TabIndex = 4;
            // 
            // frmKehilangan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUbah);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmKehilangan";
            this.Text = "Kehilangan";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHome)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHome;
        private System.Windows.Forms.Button btnUbah;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRuang;
        private System.Windows.Forms.Button btnPelapor;
        private System.Windows.Forms.Button btnPenemu;
        private System.Windows.Forms.Button btnHome;
        protected internal System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel panel2;
    }
}

