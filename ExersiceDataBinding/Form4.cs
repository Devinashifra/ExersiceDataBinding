﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExersiceDataBinding
{
    public partial class Form4 : Form
    {
        Form2 back;
        public void back_FormClosed(Object sender, FormClosedEventArgs e)
        {
            back = null;
        }
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (back == null)
            {
                back = new Form2();
                back.FormClosed += new FormClosedEventHandler(back_FormClosed);
                back.Show();
            }
            else
            {
                back.Activate();
            }
            this.Hide();
        }
    }
}
