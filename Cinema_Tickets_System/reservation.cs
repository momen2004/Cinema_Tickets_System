﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Tickets_System
{
    public partial class reservation : Form
    {
        public reservation(Image img, string name)
        {
            InitializeComponent();
            pictureBox1.Image = img;
            movieTitle.Text = name;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void reservation_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();  
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you confirm the booking of " + movieTitle.Text, "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("oK");
            }
            else if (result == DialogResult.No)
            {
                return;
            }
        
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void reservation_Load(object sender, EventArgs e)
        {
            
        }
    }
}
