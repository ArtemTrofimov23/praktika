using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace avtoPodbor
{
    public partial class Zanesenie : Form
    {
        public Zanesenie()
        {
            InitializeComponent();
            foreach (Avto avto in Program.db.Avto)
            {
                comboBox1.Items.Add(avto.id_avto);
            }
        }

        private void Zanesenie_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pokypatel p = new Pokypatel();
            p.Surname = textBox1.Text;
            p.NamePokyp = textBox2.Text;
            p.Patronomyc = textBox3.Text;
            p.Number = textBox4.Text;
            p.id_avto = Convert.ToInt32(comboBox1.SelectedItem);
            Program.db.Pokypatel.Add(p);
            Program.db.SaveChanges();
            soxr spr = new soxr();
            spr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AvtoPodbor spr = new AvtoPodbor();
            spr.Show();
            this.Hide();
        }
    }
}
