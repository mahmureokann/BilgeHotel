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
    public partial class TatilPaketiCalisanForm : Form
    {
        public TatilPaketiCalisanForm()
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
        private void TatilPaketiCalisanForm_Load(object sender, EventArgs e)
        {
            HolidayList();
        }
    }
}
