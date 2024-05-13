using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniProject_1
{
    public partial class Alter : Form
    {

        string startTime, endTime, timeTaken, Activity, alterID;
        public Alter(string altID, string startingTime, string stoppingTime, string Act)
        {
            InitializeComponent();
            alterID = altID;

            startTime = startingTime;
            endTime = stoppingTime;
            Activity = Act;

            textBox1.Text = startTime;
            textBox2.Text = endTime;
            textBox3.Text = Activity;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string h, m, s;
            startTime = textBox1.Text;
            endTime = textBox2.Text;
            Activity = textBox3.Text;

            string format = "dd/MM/yy HH:mm:ss";
            DateTime dateTime;

            if (DateTime.TryParseExact(startTime, format, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out dateTime) && DateTime.TryParseExact(endTime, format, CultureInfo.InvariantCulture,
                DateTimeStyles.None, out dateTime))
            {
                string[] startTime2 = startTime.Split('/', ':', ' ');
                string[] stopTime2 = endTime.Split('/', ':', ' ');

                if (Convert.ToInt32(startTime2[3]) > Convert.ToInt32(stopTime2[3]) && Convert.ToInt32(startTime2[0]) < Convert.ToInt32(stopTime2[0]))
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
                SqlCommand sqlCommand = new SqlCommand("UPDATE [dbo].[TimeManager2]" +
                    "SET [startTime] = '" + startTime + "'," +
                    "[endTime] = '" + endTime + "'," +
                    "[timeTaken] = '" + timeTaken + "'," +
                    "[Activity] = '" + Activity + "' " +
                    "WHERE ID = '" + alterID + "'", con);
                con.Open();
                sqlCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Data Altered Successfully");
                this.Close();
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
