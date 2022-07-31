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
    public partial class CalisanForm : Form
    {
        public CalisanForm()
        {
            InitializeComponent();
        }
        ProjectContext db = new ProjectContext();

        BaseRepository<Employee> employeeRepo = new BaseRepository<Employee>(); //BaseRepositorydeki Crud işlemlerine ulaşabilmek ve T tipini çalışana dönüştürebilmek için böyle bir işlem gerçekleştirildi.

        private void CalisanList()


        {
            listView1.Items.Clear();

            List<Employee> employees = employeeRepo.GetList();

            foreach (Employee employee in employees)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = employee.EmployeeId.ToString();
                lvi.SubItems.Add(employee.Firstname);
                lvi.SubItems.Add(employee.Lastname);
                lvi.SubItems.Add(employee.Email.ToString());
                lvi.SubItems.Add(employee.Password.ToString());
                lvi.SubItems.Add(employee.Maas.ToString());
                lvi.SubItems.Add(employee.Title.ToString());

                lvi.SubItems.Add(employee.SaatlikUcret.ToString());
                lvi.SubItems.Add(employee.VardiyaSuresi.ToString());
                lvi.SubItems.Add(employee.Pozisyon.ToString());
                lvi.SubItems.Add(employee.KullaniciAdi.ToString());

                listView1.Items.Add(lvi);

            }
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            CalisanList();
        }
        Employee employee = new Employee();
        private void btnEkle_Click(object sender, EventArgs e)
        {

            if (txtİsim.Text != "")
            {
                employee.Firstname = txtİsim.Text;



            }
            if (txtSoyad.Text != "")
            {
                employee.Lastname = txtSoyad.Text;


            }
            if (txtMail.Text != "")
            {
                employee.Email = txtMail.Text;


            }
            if (txtSifre.Text != "")
            {
                employee.Password = txtSifre.Text;


            }
            if (txtMaas.Text != "")
            {
                employee.Maas = Convert.ToInt32(txtMaas.Text);


            }
            if (txtPoz.Text != "")
            {
                employee.Title = 0;
                employee.Pozisyon = txtPoz.Text;


            }
            if (numericUpDown1.Value > 1)
            {
                employee.SaatlikUcret = Convert.ToInt32(numericUpDown1.Value);


            }
            if (txtVardiya.Text != "")
            {
                employee.VardiyaSuresi = Convert.ToInt32(txtVardiya.Text);


            }
            if (txtKullaniciAd.Text == "calisan" || txtKullaniciAd.Text == "yonetici")
            {
                employee.KullaniciAdi = txtKullaniciAd.Text;
            }
            else
            {
                MessageBox.Show("Tüm alanlar doldurulmalıdır!");
            }


            string result = employeeRepo.Create(employee);
            MessageBox.Show(result);
            CalisanList();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int yakalananId;

            yakalananId = Convert.ToInt32(txtId.Text);

            Employee guncelle = employeeRepo.FindById(yakalananId);


            if (txtİsim.Text != "")
            {
                guncelle.Firstname = txtİsim.Text;



            }
            if (txtSoyad.Text != "")
            {
                guncelle.Lastname = txtSoyad.Text;


            }
            if (txtMail.Text != "")
            {
                guncelle.Email = txtMail.Text;


            }
            if (txtSifre.Text != "")
            {
                guncelle.Password = txtSifre.Text;


            }
            if (txtMaas.Text != "")
            {
                guncelle.Maas = Convert.ToInt32(txtMaas.Text);


            }
            if (txtPoz.Text != "")
            {
                guncelle.Title = 0;
                guncelle.Pozisyon = txtPoz.Text;


            }
            if (numericUpDown1.Value > 1)
            {
                guncelle.SaatlikUcret = Convert.ToInt32(numericUpDown1.Value);


            }
            if (txtVardiya.Text != "")
            {
                guncelle.VardiyaSuresi = Convert.ToInt32(txtVardiya.Text);


            }


            CalisanList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                int yakalananId = Convert.ToInt32(txtId.Text);
                yakalananId = Convert.ToInt32(txtId.Text);
                string result = employeeRepo.Delete(yakalananId);
                MessageBox.Show("Veri silindi!");

                db.SaveChanges();
            }
            catch (Exception)
            {

                MessageBox.Show("Lütfen bir ID giriniz!");
            }

            CalisanList();
        }
    }
}
