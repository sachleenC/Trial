using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Mapping
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Search_button_Click(object sender, EventArgs e)
        {
            string Street = textBox_street.Text;
            string City = textBox_city.Text;
            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://maps.google.com/maps?q=");

                if(Street != string.Empty)
                {
                    queryaddress.Append(Street + "," + "+");
                }
                if (City != string.Empty)
                {
                    queryaddress.Append(City + "," + "+");
                }

                webBrowser1.Navigate(queryaddress.ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");
            }
        }
            
        
    }
}
