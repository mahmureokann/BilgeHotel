using BLL.Repo;
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
    public partial class RezervasyonForm : Form
    {
        public RezervasyonForm()
        {
            InitializeComponent();
        }
        BaseRepository<ReservationInfo> rezRepo = new BaseRepository<ReservationInfo>();
        private void RezervasyonList()
        {
            listView1.Items.Clear();

            List<ReservationInfo> rez = rezRepo.GetList();

            foreach (ReservationInfo reservation in rez)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = reservation.ReservationInfoId.ToString();
                lvi.SubItems.Add(reservation.RezBaslangic.ToString());
                lvi.SubItems.Add(reservation.RezBitis.ToString());
                
                lvi.SubItems.Add(reservation.RezervasyonTarihi.ToString());
                lvi.SubItems.Add(reservation.CustomerId.ToString());
                lvi.SubItems.Add(reservation.ToplamFiyat.ToString());
                lvi.SubItems.Add(reservation.HolidayPackageId.ToString());
                lvi.SubItems.Add(reservation.RoomTypeId.ToString());


                listView1.Items.Add(lvi);

            }
        }
        private void RezervasyonForm_Load(object sender, EventArgs e)
        {
            RezervasyonList();
        }
    }
}
