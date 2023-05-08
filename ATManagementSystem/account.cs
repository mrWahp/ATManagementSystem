using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ATManagementSystem
{
    public partial class account : Form
    {
        public account()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Decagon\Documents\ATMDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (AccNametb.Text == "" || AccNumbTb.Text == "" || FnameTb.Text == "" || PhoneTb.Text == "" || Addresstb.Text == "" || occupationtb.Text == "" || pintb.Text == "")
            {

            }else
            {
                try
                {

                }catch(Exception Ex) { 
                
                }
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void account_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }


    }
}
