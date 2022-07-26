using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_UI
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }



        void childForm(Form _childForm)
        {
            this.Width = _childForm.Width + 22;
            this.Height = _childForm.Height + 60;
            bool durum = false;

            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Text == _childForm.Text)
                {
                    durum = true;
                    frm.Activate();
                }
                else
                {
                    frm.Close();
                }

            }

            if (durum == false)
            {
                _childForm.MdiParent = this;
                _childForm.StartPosition = FormStartPosition.Manual;
                _childForm.WindowState = FormWindowState.Maximized;
                _childForm.FormBorderStyle = FormBorderStyle.None;
                _childForm.Show();

            }
          
        }

        private void calisanMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new EmployeeForm());
        }

        private void çalışanVardiyalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new VardiyaForm());
        }

        private void musteriMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new CustomerForm());
        }

        private void rezervasyonlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new RezervasyonForm());
        }

        private void odaTipleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new OdaTipiForm());
        }

        private void tatilPaketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childForm(new TatilPaketForm());
        }
    }
}



