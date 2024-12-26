using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

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

        DialogResult res = DialogResult.None;

        int Ticket_price = 8; //s3r el ticket

        int ln;


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public bool isValidEmail (string email)
        {
            Regex emailRegex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", RegexOptions.IgnoreCase); //Gotten from https://youtu.be/2ujFcfybwhw?feature=shared :)
            return emailRegex.IsMatch(email);
        }
        public bool isValidPhone(string number)
        {
            if (number.Length < 10)
            {
                return true;
            }
            else return false;
        }
        public void saveInfo()
        {
            string movie=movieTitle.Text;
            string Fname=FnameBox.Text;
            string Lname=LnameBox.Text;
            string email=emailBox.Text;
            string address=addressBox.Text;
            string city=cityBox.Text;
            string phone= phoneBox.Text;
            string price= priceLabel.Text;

            string Info = "Name: "+Fname+" "+Lname+"\nEmail: "+email+"\nAdress: "+address+" ,"+city+"\nPhone: "+phone+"\nMovie: "+movie+"\nTotal price: "+price;
            SaveFileDialog save = new SaveFileDialog();
            save.FileName = "Ticket"; //Set the name 
            save.DefaultExt = "txt"; 
            save.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";                          //
            MessageBox.Show(Info);
            if (save.ShowDialog() == DialogResult.OK) { 
            try
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                writer.WriteLine(Info);
                MessageBox.Show("Ticket is saved to "+ save.FileName);
                writer.Close();
                }
                catch (Exception ex)
            {
                MessageBox.Show("Error saving information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }

        private void reservation_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void SaveBtn_Click(object sender, EventArgs e) //this is the save file button somehow cannot change its name!!!
        {
            if (res == DialogResult.OK)
             { 
            DialogResult result = MessageBox.Show("Do you confirm the booking of " + movieTitle.Text+"?", "Comfirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question); 
            if (result == DialogResult.Yes)
            {
                    MessageBox.Show("Booking Confirmed", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    saveInfo();
                }
                else if (result == DialogResult.No)
            {
                    MessageBox.Show("Booking Cancelled", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
            }
            }
            else MessageBox.Show("Please check the info first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void emailBox_TextChanged(object sender, EventArgs e)
        {
            if (!isValidEmail(emailBox.Text))
            {
                checkEmailLabel.Text = "Email is incorrect";
                checkEmailLabel.ForeColor = Color.Red;
            }
            else
            {
                checkEmailLabel.Text = "Email is correct";
                checkEmailLabel.ForeColor = Color.Lime;
            }
        }
        private void phoneBox_TextChanged(object sender, EventArgs e)
        {
            if (isValidPhone(phoneBox.Text))
            {
                checkPhoneLabel.Text = "Phone number is incorrect";
                checkPhoneLabel.ForeColor = Color.Red;
            }
            else
            {
                checkPhoneLabel.Text = "Phone number is correct";
                checkPhoneLabel.ForeColor= Color.Lime;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void reservation_Load(object sender, EventArgs e)
        {
            priceLabel.Text = Ticket_price.ToString() + " JOD";
          
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if(numericUpDown1.Value >= 1 && numericUpDown1.Value <=5)
            {
                Ticket_price = Convert.ToInt32( numericUpDown1.Value) * 8;
                priceLabel.Text = Ticket_price.ToString() + " JOD";
            }
        }

        private void priceLabel_Click(object sender, EventArgs e)
        {
          
        }

        private void LnameBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FnameBox_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void phoneBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void saveBtn_Click_1(object sender, EventArgs e)
        {
            if(FnameBox.Text== "" || LnameBox.Text=="" ||  phoneBox.Text== "" || emailBox.Text=="" || addressBox.Text =="" || cityBox.Text == "")
            {
                 MessageBox.Show("Please fill all the information", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (isValidPhone(phoneBox.Text))
            {
                MessageBox.Show("Phone number is not valid");
            }
            else if (!isValidEmail(emailBox.Text))
            {
                MessageBox.Show("Email is not valid");
            }
            else
            {
                res = MessageBox.Show("Approved", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void addressBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addressBox_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }


    }
}
