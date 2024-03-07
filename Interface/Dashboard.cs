using SIREMA.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIREMA.Interface
{
    public partial class Dashboard : Form
    {
        public Dashboard(string nama)
        {
            InitializeComponent();
            namaTxt.Text = "Welcome, " + nama;
        }

        //private int geser = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            //geser += 1;
            //if (geser > 350)
            //{
            //    geser = 0;
            //}
            //walkTxt.Left = geser;
            walkTxt.Text = DateTime.Now.ToLongDateString() + "  " + DateTime.Now.ToLongTimeString();
        }

        private void contentPnl_Paint(object sender, PaintEventArgs e)
        {
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
        }

        private void namaTxt_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProdiFrm prodi = new ProdiFrm();
            Form1 jurusan = new Form1();

            jurusan.TopLevel = false;
            contentPnl.Controls.Clear();
            contentPnl.Controls.Add(jurusan);
            prodi.Close();
            jurusan.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProdiFrm prodi = new ProdiFrm();
            Form1 jurusan = new Form1();

            prodi.TopLevel = false;
            contentPnl.Controls.Clear();
            contentPnl.Controls.Add(prodi);
            jurusan.Close();
            prodi.Show();
        }
    }
}