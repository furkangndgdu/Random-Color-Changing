﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form_random2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color[] renkler=new Color[5] {Color.Red,Color.Green,Color.Blue,Color.Orange,Color.Pink};
            Random x=new Random();
            int rastgelerenk=x.Next(0,5);
            this.BackColor = renkler[rastgelerenk]; 
        }
    }
}
