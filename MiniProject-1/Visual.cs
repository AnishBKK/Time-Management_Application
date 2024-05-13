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
using System.Windows.Forms.DataVisualization.Charting;

namespace MiniProject_1
{
    public partial class Visual : Form
    {
        public Visual(string date)
        {
            InitializeComponent();

            List<string> timeTakenList = new List<string>();
            List<string> ActivityList = new List<string>();
            List<string> DateStartList = new List<string>();
            List<string> DateEndList = new List<string>();

            string conn = "Data Source=ANI-L5P11\\SQLEXPRESS;Initial Catalog=TimeManagement;Integrated Security=True";
            SqlConnection con = new SqlConnection(conn);
            con.Open();
            string query = "select * from TimeManager2";
            SqlCommand cmd = new SqlCommand(query, con);
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                timeTakenList.Add(dr["timeTaken"].ToString());
                ActivityList.Add(dr["Activity"].ToString());
                DateStartList.Add(dr["startTime"].ToString());
                DateEndList.Add(dr["endTime"].ToString());
            }

            string reqDate = date.Substring(0, 2);

            string[] timeTaken = timeTakenList.ToArray();
            string[] Activity = ActivityList.ToArray();
            string[] startTime = DateStartList.ToArray();
            string[] endTime = DateEndList.ToArray();

            int[] totalseconds = new int[timeTaken.Length];
            int[] startedTime = new int[startTime.Length];
            int[] stoppedTime = new int[endTime.Length];
            string[] selectedActivity = new string[Activity.Length];

            for (int i = 0; i < startTime.Length; i++)
            {
                startedTime[i] = Convert.ToInt32(startTime[i].Substring(0, 2));
                stoppedTime[i] = Convert.ToInt32(endTime[i].Substring(0, 2));
            }

            for (int i = 0; i < timeTaken.Length; i++)
            {
                if (startedTime[i] == Convert.ToInt32(reqDate) && stoppedTime[i] == Convert.ToInt32(reqDate))
                {
                    string a = timeTaken[i];
                    string[] l = new string[a.Length];
                    l = a.Split(':');
                    totalseconds[i] = ((Convert.ToInt32(l[0]) * 3600) + (Convert.ToInt32(l[1]) * 60) + (Convert.ToInt32(l[2])));
                    selectedActivity[i] = Activity[i];
                }
            }

            selectedActivity = selectedActivity.Where(a => a != null).ToArray();
            totalseconds = totalseconds.Where(a => a != 0).ToArray();

            chart1.Series["Day"].Points.DataBindXY(selectedActivity, totalseconds);
            chart1.Titles.Add(date);
        }
    }
}
