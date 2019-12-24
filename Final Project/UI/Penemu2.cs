using Final_Project.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForm;

namespace Final_Project.UI
{
    public partial class frmPenemu2 : Form
    {
        public frmPenemu2()
        {
            InitializeComponent();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {

        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (this.dgvPenemu.SelectedRows.Count > 0)
            {
                dgvPenemu.Rows.RemoveAt(this.dgvPenemu.SelectedRows[0].Index);
            };
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmKehilangan frm = new frmKehilangan();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnPelapor_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmPelapor frm = new frmPelapor();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnPengambil_Click(object sender, EventArgs e)
        {
            this.Hide();
            
            this.Dispose();
        }

        private void btnRuang_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRuang frm = new frmRuang();
            frm.ShowDialog();
            this.Dispose();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ImpSignOut signOut = new ImpSignOut();
            signOut.SignOut();

            Login login = new Login();
            this.Hide();
            login.ShowDialog();
            this.Dispose();
        }
    }
}
