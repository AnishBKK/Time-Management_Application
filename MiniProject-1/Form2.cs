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
using System.Windows.Forms.VisualStyles;
using System.Text.RegularExpressions;
using System.Globalization;

namespace MiniProject_1
{
    public partial class Form2 : Form
    {
        string startTime, endTime, timeTaken;
        public Form2(string startingTime, string stopTime)
        {
            InitializeComponent();
            textBox1.Text = startingTime;
            textBox2.Text = stopTime;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string h, m, s;
            startTime = textBox1.Text;
            endTime = textBox2.Text;
            string Activity = textBox3.Text;

            string format = "dd/MM/yy HH:mm:ss";
            DateTime dateTime;

            if (DateTime.TryParseExact(startTime, format, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out dateTime) && DateTime.TryParseExact(endTime, format, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out dateTime))
            {
                if (Activity != "")
                {
                    string[] startTime2 = startTime.Split('/', ':', ' ');
                    string[] stopTime2 = endTime.Split('/', ':', ' ');

                    if (Convert.ToInt32(startTime2[3]) > Convert.ToInt32(stopTime2[3]))
                    {
                        h = (24 - Convert.ToInt32(startTime2[3]) + Convert.ToInt32(stopTime2[3])).ToString();
                    }
                    else
                    {
                        h = (Convert.ToInt32(stopTime2[3]) - Convert.ToInt32(startTime2[3])).ToString();
                    }

                    if (Convert.ToInt32(startTime2[4]) > Convert.ToInt32(stopTime2[4]) && Convert.ToInt32(startTime2[3]) < Convert.ToInt32(stopTime2[3]))
                    {
                        m = (60 - Convert.ToInt32(startTime2[4]) + Convert.ToInt32(stopTime2[4])).ToString();
                    }
                    else
                    {
                        m = (Convert.ToInt32(stopTime2[4]) - Convert.ToInt32(startTime2[4])).ToString();
                    }

                    if (Convert.ToInt32(startTime2[5]) > Convert.ToInt32(stopTime2[5]) && Convert.ToInt32(startTime2[4]) < Convert.ToInt32(stopTime2[4]))
                    {
                        s = (60 - Convert.ToInt32(startTime2[5]) + Convert.ToInt32(stopTime2[5])).ToString();
                    }
                    else
                    {
                        s = (Convert.ToInt32(stopTime2[5]) - Convert.ToInt32(startTime2[5])).ToString();
                    }

                    timeTaken = (h + ":" + m + ":" + s);

                    string conn = "Data Source=ANI-L5P11\\SQLEXPRESS;Initial Catalog=TimeManagement;Integrated Security=True";
                    SqlConnection con = new SqlConnection(conn);

                    SqlCommand sqlCommand = new SqlCommand(@"INSERT INTO [dbo].[TimeManager2]
           ([startTime]
           ,[endTime]
           ,[timeTaken]
           ,[Activity])
     VALUES
           ('" + startTime + "','" + endTime + "','" + timeTaken + "','" + Activity + "') ", con);
                    con.Open();
                    sqlCommand.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Data Entered Successfully");

                    this.Close();
                }

                else
                {
                    MessageBox.Show("Enter Activity Name");
                }
                
            }
            else
            {
                MessageBox.Show("Date and Time values entered are of incorrect order. Please follow 'dd/mm/yy hh:mm:ss' order");
                textBox1.Text = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");
                textBox2.Text = DateTime.Now.ToString("dd/MM/yy HH:mm:ss");
            }  
        }
    }
}
