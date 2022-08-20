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

namespace WindowsFormsApp1.DAO
{
    internal class dataProvider
    {
        private string dataSrc = "Data Source=.\\sqlexpress; Initial Catalog = QuanLiQuanCafe; Integrated Security = True";

        private static dataProvider instance;
        public static dataProvider Instance
        {
            get { if (instance == null) instance = new dataProvider(); return dataProvider.instance; }
            private set { dataProvider.instance = value; }
        }

        private dataProvider() { }


        public DataTable excuteQuerry(string querry, object[] Parameter = null)
        {
            DataTable data = new DataTable();
            using(SqlConnection connection = new SqlConnection(dataSrc)) { 
                SqlCommand command = new SqlCommand(querry, connection);

                if(Parameter != null)
                {
                    string[] Para = querry.Split(' ');
                    int i = 0;
                    foreach (string s in Para)
                    {
                        if (s.Contains("@"))
                        {
                            //MessageBox.Show(Para[i]);
                            command.Parameters.AddWithValue(s, Parameter[i++]);
                        }
                    }
                }
               // command.Parameters.AddWithValue("@userDisplayName", "admin");

                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);

                connection.Close();
            }
            return data;
            
        }

        public int excuteExist(string querry, object[] Parameter = null)
        {
            DataTable pdata =  dataProvider.instance.excuteQuerry(querry);
            return pdata.Rows.Count;
        }

        public object excuteFirstElement(string querry, string element, object[] Parameter = null)
        {
            DataTable pdata = dataProvider.instance.excuteQuerry(querry);
            foreach(DataRow dataRow in pdata.Rows)
            {
                return dataRow[element];
            }
            return 0;
        }

        public int excuteNonQuerry(string querry, object[] Parameter = null)
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(dataSrc))
            {
                SqlCommand command = new SqlCommand(querry, connection);

                if (Parameter != null)
                {
                    string[] Para = querry.Split(' ');
                    int i = 0;
                    foreach (string s in Para)
                    {
                        if (s.Contains("@"))
                        {
                            //MessageBox.Show(Para[i]);
                            command.Parameters.AddWithValue(s, Parameter[i++]);
                        }
                    }
                }
                    data = command.ExecuteNonQuery();

                connection.Close();
            }
            return data;
        }

        public object excuteScalar(string querry, object[] Parameter = null)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(dataSrc))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(querry, connection);

                if (Parameter != null)
                {
                    string[] Para = querry.Split(' ');
                    int i = 0;
                    foreach (string s in Para)
                    {
                        if (s.Contains("@"))
                        {
                            //MessageBox.Show(Para[i]);
                            command.Parameters.AddWithValue(s, Parameter[i++]);
                        }
                    }
                }

                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;

        } 

    }
}
