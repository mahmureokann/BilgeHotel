using BLL.Repo;
using DataAccses.Context;
using DataAccses.Entity;
using DataAccses.Enums;
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
    public partial class OdaCalisanForm : Form
    {
        public OdaCalisanForm()
        {
            InitializeComponent();
        }
        BaseRepository<RoomType> roomRepo = new BaseRepository<RoomType>(); //BaseRepositorydeki Crud işlemlerine ulaşabilmek ve T tipini çalışana dönüştürebilmek için böyle bir işlem gerçekleştirildi.


        private void OdaList()


        {
            listView1.Items.Clear();
            cmbDurum.Items.Clear();
            cmbOdaTipi.Items.Clear();
            cmbOdaTuru.Items.Clear();

            List<RoomType> roomTypes = roomRepo.GetList();

            List<OdaDurumu> OdaDurumları = Enum.GetValues(typeof(OdaDurumu)).Cast<OdaDurumu>().ToList();
            foreach (RoomType room in roomTypes)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = room.RoomTypeId.ToString();
                lvi.SubItems.Add(room.OdaTipi.ToString());
                lvi.SubItems.Add(room.OdaTuru.ToString());
                lvi.SubItems.Add(room.OdaDurumu.ToString());
                lvi.SubItems.Add(room.Fiyat.ToString());
                listView1.Items.Add(lvi);
            }


            foreach (OdaDurumu room in OdaDurumları) //enum cmbye eklensin diye.
            {
                cmbDurum.Items.Add(room.ToString());
                cmbDurum.Tag = room;

            }

            //OdaTipi
            cmbOdaTipi.Items.Add("Her şey dahil");
            cmbOdaTipi.Items.Add("Tam pansiyon");

            //OdaTürü
            cmbOdaTuru.Items.Add("Üç kişilik");
            cmbOdaTuru.Items.Add("Tek kişilik");
            cmbOdaTuru.Items.Add("Dört kişilik");
            cmbOdaTuru.Items.Add("Kral dairesi");

        }

        private void OdaCalisanForm_Load(object sender, EventArgs e)
        {
            OdaList();
        }

        private void OdaCalisanForm_Load_1(object sender, EventArgs e)
        {
            OdaList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            RoomType room = new RoomType();

            room.OdaTipi = cmbOdaTipi.Text;
            room.OdaTuru = cmbOdaTuru.Text;
            room.OdaDurumu = (OdaDurumu)cmbDurum.SelectedIndex;
            room.Fiyat = Convert.ToInt32(txtFiyat.Text);


            string result = roomRepo.Create(room);
            MessageBox.Show(result);

            OdaList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int yakalananId;

            yakalananId = Convert.ToInt32(txtId.Text);

            RoomType guncelle = roomRepo.FindById(yakalananId);


            if (cmbOdaTipi.SelectedIndex != null)
            {
                guncelle.OdaTipi = cmbOdaTipi.Text;



            }
            if (cmbOdaTuru.SelectedIndex != null)
            {
                guncelle.OdaTuru = cmbOdaTuru.Text;


            }
            if (cmbDurum.SelectedIndex != null)
            {
                guncelle.OdaDurumu = (OdaDurumu)cmbDurum.SelectedIndex;


            }
            if (txtFiyat.Text != "")
            {
                guncelle.Fiyat = Convert.ToInt32(txtFiyat.Text);


            }


            OdaList();
        }

        ProjectContext db = new ProjectContext();
        private void btnSil_Click(object sender, EventArgs e)
        {

            try
            {
                int yakalananId = Convert.ToInt32(txtId.Text);
                yakalananId = Convert.ToInt32(txtId.Text);
                string result = roomRepo.Delete(yakalananId);
                MessageBox.Show("Veri silindi!");

                db.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen bir ID giriniz!");
            }

            OdaList();

        }
    }
}