﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabIIVS
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void playGame_Click(object sender, EventArgs e)
        {

            Form1 form1 = new Form1();
            form1.gameOver = false;
            form1.ShowDialog();

        }
    }
}
