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
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }
        BaseRepository<Customer> customerRepo = new BaseRepository<Customer>();
        private void CustomerList()
        {
            listView1.Items.Clear();

            List<Customer> customers = customerRepo.GetList();

            foreach (Customer customer in customers)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = customer.CustomerId.ToString();
                lvi.SubItems.Add(customer.Firstname.ToString());
                lvi.SubItems.Add(customer.Lastname.ToString());
                lvi.SubItems.Add(customer.Tckn.ToString());
                lvi.SubItems.Add(customer.PhoneNumber.ToString());
                lvi.SubItems.Add(customer.Email.ToString());


                listView1.Items.Add(lvi);

            }
        }
        private void MusteriForm_Load(object sender, EventArgs e)
        {
            CustomerList();
        }
    }
}
