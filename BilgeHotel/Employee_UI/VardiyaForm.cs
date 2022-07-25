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
    public partial class VardiyaForm : Form
    {
        public VardiyaForm()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();

        BaseRepository<Vardiya> vardiyaRepo = new BaseRepository<Vardiya>(); //BaseRepositorydeki Crud işlemlerine ulaşabilmek ve T tipini çalışana dönüştürebilmek için böyle bir işlem gerçekleştirildi.
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


                listView1.Items.Add(lvi);

            }
        }




        private void VardiyaForm_Load(object sender, EventArgs e)
        {
            VardiyaList();
        }
        Vardiya vardiya1 = new Vardiya();
        private void btnEkle_Click(object sender, EventArgs e)
        {
          
            if (dtBaslangic.Value>DateTime.Now && dtBitis.Value > DateTime.Now)
            {
                vardiya1.VardiyaBaslangic = dtBaslangic.Value;
                vardiya1.VardiyaBitis = dtBitis.Value;

                string result = vardiyaRepo.Create(vardiya1);
                MessageBox.Show(result);
                VardiyaList();

            }
            else
            {
                MessageBox.Show("Geçerli bir tarih giriniz!");
            }

            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            int yakalananId;

            yakalananId = Convert.ToInt32(txtVardiyaId.Text);

            Vardiya guncelle = vardiyaRepo.FindById(yakalananId);


            if (dtBaslangic.Value>DateTime.Now && dtBitis.Value > DateTime.Now)

            {
                guncelle.VardiyaBaslangic = dtBaslangic.Value;
                guncelle.VardiyaBitis = dtBitis.Value;

               


                VardiyaList();


            }
            else
            {
                MessageBox.Show("Güncelleme yapılamadı! Farklı bir tarih seçiniz");
            }
            


          
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int yakalananId = Convert.ToInt32(txtVardiyaId.Text);
                yakalananId = Convert.ToInt32(txtVardiyaId.Text);
                string result = vardiyaRepo.Delete(yakalananId);
                MessageBox.Show("Veri silindi!");

                db.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen bir ID giriniz!");
            }

            VardiyaList();
        }
    }
}
