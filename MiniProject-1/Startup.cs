﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject_1
{
    public partial class Startup : Form
    {
        public Startup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string startTime = DateTime.Now.ToString("dd/MM/yy HH:mm:ss"), endTime = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");
            Form2 f2 = new Form2(startTime, endTime);
            f2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Display display = new Display();
            display.Show();
        }
    }
}
