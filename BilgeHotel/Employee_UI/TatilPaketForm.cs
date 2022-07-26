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
    public partial class TatilPaketForm : Form
    {
        public TatilPaketForm()
        {
            InitializeComponent();
        }

        ProjectContext db = new ProjectContext();
        BaseRepository<HolidayPackage> holidayRepo = new BaseRepository<HolidayPackage>(); //BaseRepositorydeki Crud işlemlerine ulaşabilmek ve T tipini çalışana dönüştürebilmek için böyle bir işlem gerçekleştirildi.

        private void HolidayList()


        {
            listView1.Items.Clear();

            List<HolidayPackage> holidayPackages = holidayRepo.GetList();

            foreach (HolidayPackage holiday in holidayPackages)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = holiday.HolidayPackageId.ToString();
                lvi.SubItems.Add(holiday.PaketAdi);
                lvi.SubItems.Add(holiday.Fiyat.ToString());
               

                listView1.Items.Add(lvi);

            }
        }
        private void TatilPaketForm_Load(object sender, EventArgs e)
        {
            HolidayList();
        }
        HolidayPackage holiday1 = new HolidayPackage();
        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (txtPaketAd.Text != "")
            {
               holiday1.PaketAdi = txtPaketAd.Text;



            }
            if (txtFiyat.Text != "")
            {
                holiday1.Fiyat =Convert.ToInt32(txtFiyat.Text);


            }
            
            else
            {
                MessageBox.Show("Tüm alanlar doldurulmalıdır!");
            }


            string result = holidayRepo.Create(holiday1);
            MessageBox.Show(result);
            HolidayList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int yakalananId;

            yakalananId = Convert.ToInt32(txtPaketId.Text);

            HolidayPackage guncelle = holidayRepo.FindById(yakalananId);


            if (txtPaketAd.Text != "")
            {
                guncelle.PaketAdi = txtPaketAd.Text;



            }
            if (txtFiyat.Text != "")
            {
                guncelle.Fiyat = Convert.ToInt32(txtFiyat.Text);


            }



            HolidayList(); 
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int yakalananId = Convert.ToInt32(txtPaketId.Text);
                yakalananId = Convert.ToInt32(txtPaketId.Text);
                string result = holidayRepo.Delete(yakalananId);
                MessageBox.Show("Veri silindi!");

                db.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen bir ID giriniz!");
            }

            HolidayList();
        }
    }
}
