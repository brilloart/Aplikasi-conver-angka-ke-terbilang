using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerbilangLibrary;


namespace TerbilangApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nominal = int.Parse(nominal1.Text);

            

            Terbilang terbilang = new Terbilang();
            listView1.Items.Clear();
            listView1.Items.Add(string.Format(terbilang.TerbilangIndonesia(nominal)));

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
