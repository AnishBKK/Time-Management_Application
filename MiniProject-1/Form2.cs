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
            string Activity = textBox3.Text;
            startTime = textBox1.Text;
            endTime = textBox2.Text;
            string[] startTime2 = startTime.Split('/', ':', ' ');
            string[] stopTime2 = endTime.Split('/', ':', ' ');
            if (startTime2[6] == stopTime2[6])
            {
                h = (Convert.ToInt32(stopTime2[3]) - Convert.ToInt32(startTime2[3])).ToString();
                m = (Convert.ToInt32(stopTime2[4]) - Convert.ToInt32(startTime2[4])).ToString();
                s = (Convert.ToInt32(stopTime2[5]) - Convert.ToInt32(startTime2[5])).ToString();
            }

            else
            {
                h = (12 - Convert.ToInt32(stopTime2[3]) + 12 - Convert.ToInt32(startTime2[3])).ToString();
                m = (Convert.ToInt32(stopTime2[4]) - Convert.ToInt32(startTime2[4])).ToString();
                s = (Convert.ToInt32(stopTime2[5]) - Convert.ToInt32(startTime2[5])).ToString();
            }


            if (Convert.ToInt32(stopTime2[3]) < Convert.ToInt32(startTime2[3]) && Convert.ToInt32(stopTime2[0]) > Convert.ToInt32(startTime2[0]))
            {
                if (Convert.ToInt32(stopTime2[4]) < Convert.ToInt32(startTime2[4]) && (Convert.ToInt32(startTime[3]) > (Convert.ToInt32(stopTime2[3]))))
                {
                    if (Convert.ToInt32(stopTime2[5]) < Convert.ToInt32(startTime2[5]) && (Convert.ToInt32(startTime[4]) > (Convert.ToInt32(stopTime2[4]))))
                    {
                        s = (60 - (Convert.ToInt32(stopTime2[5]) + Convert.ToInt32(startTime2[5]))).ToString();
                        m = ((Convert.ToInt32(stopTime2[4]) - Convert.ToInt32(startTime2[4])) - 1).ToString();
                    }
                    m = (60 - (Convert.ToInt32(stopTime2[4]) + Convert.ToInt32(startTime2[4]))).ToString();
                    h = ((Convert.ToInt32(stopTime2[3]) - Convert.ToInt32(startTime2[3])) - 1).ToString();

                }
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

    }
}
