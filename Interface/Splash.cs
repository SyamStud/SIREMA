﻿using System;
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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
        }

        private void bunifuLabel2_Click(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private int count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;
            if (count > 5)
            {
                timer1.Enabled = false;
                Login login = new Login();

                login.Show();
                this.Hide();
            }
        }
    }
}