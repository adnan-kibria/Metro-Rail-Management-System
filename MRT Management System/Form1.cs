﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MRT_Management_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblbangladesh .BackColor = Color.FromArgb(50, 0, 0, 0);
            lblwelcometometro.BackColor = Color.FromArgb(50, 0, 0, 0);
        }
    }
}
