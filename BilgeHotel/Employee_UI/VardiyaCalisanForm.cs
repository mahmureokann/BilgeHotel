using BLL.Repo;
using DataAccses.Context;
using DataAccses.Entity;
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
    public partial class VardiyaCalisanForm : Form
    {
        public VardiyaCalisanForm()
        {
            InitializeComponent();
        }
        

        BaseRepository<Vardiya> vardiyaRepo = new BaseRepository<Vardiya>(); //BaseRepositorydeki Crud işlemlerine ulaşabilmek ve T tipini çalışana dönüştürebilmek için böyle bir işlem gerçekleştirildi.

        Employee employee = new Employee();
        private void VardiyaList()
        {
            listView1.Items.Clear();

            List<Vardiya> vardiyalar = vardiyaRepo.GetList();

            foreach (Vardiya vardiya in vardiyalar)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = vardiya.VardiyaId.ToString();
                lvi.SubItems.Add(vardiya.VardiyaBaslangic.ToString());
                lvi.SubItems.Add(vardiya.VardiyaBitis.ToString());
                lvi.SubItems.Add(vardiya.EmployeeId.ToString());


                listView1.Items.Add(lvi);

            }
        }
        private void VardiyaCalisanForm_Load(object sender, EventArgs e)
        {
            VardiyaList();
        }
    }
}
