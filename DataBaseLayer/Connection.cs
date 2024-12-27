using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using HopitalSystem.BussinessLayer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Net;
using System.Xml.Linq;
using System.Security.Cryptography;

namespace HopitalSystem.DataBaseLayer
{
    public  class Connection
    {
        public static SqlConnection GetConnection()
        {
            string connection = "Data Source=DESKTOP-037AGVV;Initial Catalog=Hospital;Integrated Security=True";
            SqlConnection n = new SqlConnection(connection);
            n.Open();
            return n;
        }
        public static void InsertPatientData(Patient p) 
        {
            
                SqlConnection n = GetConnection();
                string Query = "Insert into Patient (Name,P_Adress,Contact,Age,Gender,Blood_Group,Disease) Values ('" + p.Name + "','" + p.P_Adress + "'," + p.Contact + "," + p.Age + ",'" + p.Gender + "','" + p.Blood_Group + "','" + p.Disease + "')";
                SqlCommand cmd = new SqlCommand(Query, n);
                cmd.ExecuteNonQuery();
               
                n.Close();
            
        }
        public static void InsertDiagnose(Patient p)
        {
            SqlConnection n = GetConnection();
            string Query = "Insert into Diagnose ([PID],[Symptoms],[Medicines],[Ward],[Ward_Type]) Values (" + p.PIDD + ",'" + p.Symptoms + "','" + p.Medicines + "','" + p.Ward + "','" + p.Ward_Type + "')";
            SqlCommand cmd = new SqlCommand(Query, n);
            cmd.ExecuteNonQuery();
            n.Close();
        }

        public static SqlDataReader GetPIDs()
        {

            SqlConnection myConnect = GetConnection();


            string query = "select PID from Patient";
            SqlCommand cmd = new SqlCommand(query, myConnect);

            SqlDataReader myReader = cmd.ExecuteReader();

            return myReader;
        }
        public static DataTable GetPatientHistoryAdapterData()
        {

            SqlConnection myConnect = GetConnection();


            string Query = "SELECT * FROM Patient full outer JOIN Diagnose ON Patient.[PID] = Diagnose.[PID]";

            SqlCommand cmd = new SqlCommand(Query, myConnect);
            SqlDataAdapter myAdapter = new SqlDataAdapter();
            myAdapter.SelectCommand = cmd;

            DataTable myTable = new DataTable();
            myAdapter.Fill(myTable);

            return myTable;
        }
        public static DataTable GetStaffAdapterData()
        {

            SqlConnection myConnect = GetConnection();

            string Query = "Select * From Staff ";

            SqlCommand cmd = new SqlCommand(Query, myConnect);
            SqlDataAdapter myAdapter = new SqlDataAdapter();
            myAdapter.SelectCommand = cmd;

            DataTable myTable = new DataTable();
            myAdapter.Fill(myTable);

            return myTable;
        }
        public static DataTable GetPatientAdapterData()
        {

            SqlConnection myConnect = GetConnection();

            string Query = "Select * From Patient ";

            SqlCommand cmd = new SqlCommand(Query, myConnect);
            SqlDataAdapter myAdapter = new SqlDataAdapter();
            myAdapter.SelectCommand = cmd;

            DataTable myTable = new DataTable();
            myAdapter.Fill(myTable);

            return myTable;
        }

    }
}
