﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SodiumV1
{
    public partial class aboutSection : Form
    {
        public aboutSection()
        {
            this.Hide();
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opacity == 1)
            {
                timer1.Stop();
            }
            Opacity += .1;
        }
        private void aboutSection_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.Hide();
        }

        private void siticoneButton2_Click(object sender, EventArgs e)
        {
            timer2.Start();
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (Opacity <= 0)
            {
                this.Hide();
            }
            Opacity -= .025;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
