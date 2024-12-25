using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cinema_Tickets_System
{
    public partial class mainForm : Form
    {
        public static mainForm f1; //Main form instance 
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
           f1 = this; 
        }

        private async void startBtn_Click(object sender, EventArgs e)
        {
            this.Hide();                                                 //if u can use the timer i think U can replace this code //StackOverFlow 
            waitingForm loadingForm = new waitingForm();
            loadingForm.Show();
            await Task.Run(() => System.Threading.Thread.Sleep(1000));
            loadingForm.Close();
            moviesLib movielibrary = new moviesLib();
            movielibrary.Show();
        }
    }
}
