using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
             this.chart1.Series["Procent"].Points.AddXY("j2006", "locatie");

            string constring = "datasource=localhost;port=3306;username=root;=2048";
            MySqlConnection conDataBase=new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(" Select * from database.veiligheidsindex ;", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();

                while (myReader.Read())
                {
                    this.chart1.Series["Procent"].Points.AddXY(myReader.GetString("locatie"), myReader.GetInt32("j2006"));
                }
            }
            finally
            {

            }
            }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
    }