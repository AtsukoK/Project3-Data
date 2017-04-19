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

            string constring = "datasource=localhost;port=3306;username=root;password=2048";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT j2006,locatie FROM veiligheidsindex.statistieken INNER JOIN veiligheidsindex.locaties ON statistieken.locatie_name = locaties.locatie where regio = 'Noord' and datasoort = 'Fietsdiefstal'", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                this.chart1.Series["Procent"].Points.Clear();
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

        private void button2_Click(object sender, EventArgs e)

        {
            this.chart3.Series["Procent"].Points.AddY("locatie");

            string constring = "datasource=localhost;port=3306;username=root;password=2048";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT j2006,locatie FROM veiligheidsindex.statistieken INNER JOIN veiligheidsindex.locaties ON statistieken.locatie_name = locaties.locatie where regio = 'Feyenoord' and datasoort = 'Fietsdiefstal'", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                this.chart3.Series["Procent"].Points.Clear();

                while (myReader.Read())
                {
                    this.chart3.Series["Procent"].Points.AddXY(myReader.GetString("locatie"), myReader.GetInt32("j2006"));
                }
            }

            finally
            {



            }










            {

            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string street = txt_street.Text;
            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("http://maps.google.com/maps?q=");

                if (street != string.Empty)
                {
                    queryaddress.Append(street + "," + "+");
                }

                webBrowser1.Navigate(queryaddress.ToString());
                        

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error");

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.chart2.Series["Procent"].Points.AddY("locatie");

            string constring = "datasource=localhost;port=3306;username=root;password=2048";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand(" SELECT j2011,locatie FROM veiligheidsindex.statistieken INNER JOIN veiligheidsindex.locaties ON statistieken.locatie_name = locaties.locatie where datasoort = 'vandalisme' ;", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                this.chart2.Series["Procent"].Points.Clear();

                while (myReader.Read())
                {
                    this.chart2.Series["Procent"].Points.AddXY(myReader.GetString("locatie"), myReader.GetInt32("j2011"));
                }
            
            }
            finally
            {

            }
        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.chart1.Series["Procent"].Points.AddY("locatie");

            string constring = "datasource=localhost;port=3306;username=root;password=2048";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT j2006,locatie FROM veiligheidsindex.statistieken INNER JOIN veiligheidsindex.locaties ON statistieken.locatie_name = locaties.locatie where regio = 'Noord' and datasoort = 'Autodiefstal' ;", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                this.chart1.Series["Procent"].Points.Clear();

                while (myReader.Read())
                {
                    this.chart1.Series["Procent"].Points.AddXY(myReader.GetString("locatie"), myReader.GetInt32("j2006"));
                }

            }
            finally
            {

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.chart3.Series["Procent"].Points.AddY("locatie");

            string constring = "datasource=localhost;port=3306;username=root;password=2048";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT j2006,locatie FROM veiligheidsindex.statistieken INNER JOIN veiligheidsindex.locaties ON statistieken.locatie_name = locaties.locatie where regio = 'Feyenoord' and datasoort = 'Autodiefstal' ;", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                this.chart3.Series["Procent"].Points.Clear();

                while (myReader.Read())
                {
                    this.chart3.Series["Procent"].Points.AddXY(myReader.GetString("locatie"), myReader.GetInt32("j2006"));
                }

            }
            finally
            {

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.chart2.Series["Procent"].Points.AddY("locatie");

            string constring = "datasource=localhost;port=3306;username=root;password=2048";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDatabase = new MySqlCommand("SELECT j2011,locatie FROM veiligheidsindex.statistieken INNER JOIN veiligheidsindex.locaties ON statistieken.locatie_name = locaties.locatie where datasoort = 'drugsoverlast' ;", conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDatabase.ExecuteReader();
                this.chart2.Series["Procent"].Points.Clear();

                while (myReader.Read())
                {
                    this.chart2.Series["Procent"].Points.AddXY(myReader.GetString("locatie"), myReader.GetInt32("j2011"));
                }

            }
            finally
            {

            }
        }

    }
    
    
    
}
