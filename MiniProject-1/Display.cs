using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace MiniProject_1
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
            LoadRecord();
        }

        void LoadRecord()
        {
            SqlConnection con = new SqlConnection(@"Data Source=ANI-L5P11\SQLEXPRESS;Initial Catalog=TimeManagement;Integrated Security=True");
            SqlCommand comm = new SqlCommand("select * from TimeManager2 ORDER by ID", con);
            SqlDataAdapter d = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            d.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            string startTime = DateTime.Now.ToString("dd/MM/yy HH:mm:ss tt"), endTime = DateTime.Now.ToString("dd/MM/yy HH:mm:ss tt");
            Form2 f2 = new Form2(startTime, endTime);
            f2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string deleteID = Interaction.InputBox("Enter Which ID should be deleted", "Delete Value");

            string conn = "Data Source=ANI-L5P11\\SQLEXPRESS;Initial Catalog=TimeManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);

            SqlCommand sqlCommand = new SqlCommand(@"DELETE FROM [dbo].[TimeManager2] WHERE ID = '" + deleteID + "'" +
                " CREATE TABLE [dbo].[TempManager]([startTime] [varchar](50),[endTime] [varchar](50),[timeTaken] [varchar](50),[Activity] [varchar](50))" +
                " INSERT INTO [dbo].[TempManager] SELECT startTime, endTime, timeTaken, Activity FROM TimeManager2" +
                " TRUNCATE TABLE [dbo].[TimeManager2]" +
                " DBCC CHECKIDENT (TimeManager2, RESEED, 1)" +
                " INSERT INTO [dbo].[TimeManager2] (startTime, endTime, timeTaken, Activity) SELECT startTime, endTime, timeTaken, Activity FROM TempManager order by startTime" +
                " DROP TABLE TempManager", con);

            con.Open();
            sqlCommand.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Record Deleted Successfully");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string alterID = Interaction.InputBox("Enter Which ID should be Altered", "Alter Value");
            string startTime = "";
            string stopTime = "";
            string Activity = "";

            string conn = "Data Source=ANI-L5P11\\SQLEXPRESS;Initial Catalog=TimeManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string query = "select * from TimeManager2 where ID = '" + alterID + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                startTime = dr["startTime"].ToString();
                stopTime = dr["endTime"].ToString();
                Activity = dr["Activity"].ToString();
            }



            Alter a = new Alter(alterID, startTime, stopTime, Activity);
            a.Show();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            LoadRecord();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string date = Interaction.InputBox("Enter Which ID should be Visualised", "Visualisation",DateTime.Now.ToString("dd/MM/yy"));

            Visual visual = new Visual(date);
            visual.Show();
        }
    }
}
