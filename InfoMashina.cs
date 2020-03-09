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
    public partial class InfoMashina : Form
    {
        public InfoMashina()
        {
            InitializeComponent();
        }

        private void InfoMashina_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автоподборDataSet1.TipDvigatela". При необходимости она может быть перемещена или удалена.
            this.tipDvigatelaTableAdapter.Fill(this.автоподборDataSet1.TipDvigatela);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автоподборDataSet1.TipAvto". При необходимости она может быть перемещена или удалена.
            this.tipAvtoTableAdapter.Fill(this.автоподборDataSet1.TipAvto);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автоподборDataSet1.Privod". При необходимости она может быть перемещена или удалена.
            this.privodTableAdapter.Fill(this.автоподборDataSet1.Privod);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автоподборDataSet1.Korobka". При необходимости она может быть перемещена или удалена.
            this.korobkaTableAdapter.Fill(this.автоподборDataSet1.Korobka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "автоподборDataSet1.Avto". При необходимости она может быть перемещена или удалена.
            this.avtoTableAdapter.Fill(this.автоподборDataSet1.Avto);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AvtoPodbor spr = new AvtoPodbor();
            spr.Show();
            this.Hide();
        }
    }
}
