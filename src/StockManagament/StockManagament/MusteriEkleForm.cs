using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockManagament
{
    public partial class MusteriEkleForm : Form
    {
        public MusteriEkleForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBoxAdi.Text;
            string surname = textBoxSoyadi.Text;
            string telephone = textBoxTelefon1.Text;
            string telephone2 = textBoxTelefon2.Text;
            string address = textBoxAdres.Text;
            string explanation = textBoxAciklama.Text;

            DatabaseOperations db = new DatabaseOperations();
            db.AddCustomer(name, surname, address, telephone, telephone2, explanation);
        }
    }
}
