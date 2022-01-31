using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace MillionaireGame
{
    public partial class SelectAudience : Form
    {
        int selection = 0;
        List<int> numberList = new List<int>();
        public SelectAudience()
        {
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null, panel4, new object[] { true });
            typeof(Panel).InvokeMember("DoubleBuffered", System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic, null, panel1, new object[] { true });

            audienceGallery();

        }


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {

            string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB;Password=2001";

            OracleConnection conn = new OracleConnection(oradb);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "update players set aud_1 = '" + numberList[0] + "', aud_2 = '" + numberList[1] + "', aud_3 = '" +numberList[2]+ "' where player_id = '" + MainMenu.id + "'";
            int rowsUpdated = cmd.ExecuteNonQuery();

            GameMenu myForm = new GameMenu();
            myForm.TopLevel = false;
            myForm.AutoScroll = true;
            panel1.Controls.Clear();
            panel1.Controls.Add(myForm);
            myForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void audienceGallery()
        {
            try
            {
                string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB;Password=2001";
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from audience where serial_no = 1"; 
                OracleDataReader reader = cmd.ExecuteReader();
                reader.Read();
                label1.Text = reader.GetString(1) + ", " + reader.GetValue(3).ToString();
                label3.Text = reader.GetString(2);
                label4.Text = "IQ: "+ reader.GetValue(4).ToString();

                // Fetch the blob
                OracleBlob imgBlob = reader.GetOracleBlob(5);
                // Create byte array to read the blob into
                byte[] imgBytes = new byte[imgBlob.Length];
                // Read the blob into the byte array
                imgBlob.Read(imgBytes, 0, (int)imgBlob.Length);
                bunifuPictureBox1.Image = new Bitmap(imgBlob);

                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            try
            {
                string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB;Password=2001";
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from audience where serial_no = 2";
                OracleDataReader reader = cmd.ExecuteReader();
                reader.Read();
                label8.Text = reader.GetString(1) + ", " + reader.GetValue(3).ToString();
                label7.Text = reader.GetString(2);
                label6.Text = "IQ: " + reader.GetValue(4).ToString();

                // Fetch the blob
                OracleBlob imgBlob = reader.GetOracleBlob(5);
                // Create byte array to read the blob into
                byte[] imgBytes = new byte[imgBlob.Length];
                // Read the blob into the byte array
                imgBlob.Read(imgBytes, 0, (int)imgBlob.Length);
                bunifuPictureBox2.Image = new Bitmap(imgBlob);

                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            try
            {
                string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB;Password=2001";
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from audience where serial_no = 3";
                OracleDataReader reader = cmd.ExecuteReader();
                reader.Read();
                label12.Text = reader.GetString(1) + ", " + reader.GetValue(3).ToString();
                label11.Text = reader.GetString(2);
                label10.Text = "IQ: " + reader.GetValue(4).ToString();

                // Fetch the blob
                OracleBlob imgBlob = reader.GetOracleBlob(5);
                // Create byte array to read the blob into
                byte[] imgBytes = new byte[imgBlob.Length];
                // Read the blob into the byte array
                imgBlob.Read(imgBytes, 0, (int)imgBlob.Length);
                bunifuPictureBox3.Image = new Bitmap(imgBlob);

                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            try
            {
                string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB;Password=2001";
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from audience where serial_no = 4";
                OracleDataReader reader = cmd.ExecuteReader();
                reader.Read();
                label16.Text = reader.GetString(1) + ", " + reader.GetValue(3).ToString();
                label15.Text = reader.GetString(2);
                label14.Text = "IQ: " + reader.GetValue(4).ToString();

                // Fetch the blob
                OracleBlob imgBlob = reader.GetOracleBlob(5);
                // Create byte array to read the blob into
                byte[] imgBytes = new byte[imgBlob.Length];
                // Read the blob into the byte array
                imgBlob.Read(imgBytes, 0, (int)imgBlob.Length);
                bunifuPictureBox4.Image = new Bitmap(imgBlob);

                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            try
            {
                string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB;Password=2001";
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from audience where serial_no = 5";
                OracleDataReader reader = cmd.ExecuteReader();
                reader.Read();
                label20.Text = reader.GetString(1) + ", " + reader.GetValue(3).ToString();
                label19.Text = reader.GetString(2);
                label18.Text = "IQ: " + reader.GetValue(4).ToString();

                // Fetch the blob
                OracleBlob imgBlob = reader.GetOracleBlob(5);
                // Create byte array to read the blob into
                byte[] imgBytes = new byte[imgBlob.Length];
                // Read the blob into the byte array
                imgBlob.Read(imgBytes, 0, (int)imgBlob.Length);
                bunifuPictureBox5.Image = new Bitmap(imgBlob);

                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



            try
            {
                string oradb = "Data Source=(DESCRIPTION =" + "(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))" + "(CONNECT_DATA =" + "(SERVER = DEDICATED)" + "(SERVICE_NAME = XE)));" + "User Id= WWTBM_DB;Password=2001";
                OracleConnection conn = new OracleConnection(oradb);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select * from audience where serial_no = 6";
                OracleDataReader reader = cmd.ExecuteReader();
                reader.Read();
                label24.Text = reader.GetString(1) + ", " + reader.GetValue(3).ToString();
                label23.Text = reader.GetString(2);
                label22.Text = "IQ: " + reader.GetValue(4).ToString();

                // Fetch the blob
                OracleBlob imgBlob = reader.GetOracleBlob(5);
                // Create byte array to read the blob into
                byte[] imgBytes = new byte[imgBlob.Length];
                // Read the blob into the byte array
                imgBlob.Read(imgBytes, 0, (int)imgBlob.Length);
                bunifuPictureBox6.Image = new Bitmap(imgBlob);

                cmd.Dispose();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {
            if(selection < 3)
            {
                numberList.Add(1);
                selection += 1;
                bunifuTileButton1.BackgroundImage = Properties.Resources.correct__1_;
                bunifuTileButton1.Enabled = false;

            }
        }

        private void bunifuTileButton2_Click(object sender, EventArgs e)
        {
            if (selection < 3)
            {
                numberList.Add(2);
                selection += 1;
                bunifuTileButton2.BackgroundImage = Properties.Resources.correct__1_;
                bunifuTileButton2.Enabled = false;
            }
        }

        private void bunifuTileButton3_Click(object sender, EventArgs e)
        {
            if (selection < 3)
            {
                numberList.Add(3);
                selection += 1;
                bunifuTileButton3.BackgroundImage = Properties.Resources.correct__1_;
                bunifuTileButton3.Enabled = false;
            }
        }

        private void bunifuTileButton4_Click(object sender, EventArgs e)
        {
            if (selection < 3)
            {
                numberList.Add(4);
                selection += 1;
                bunifuTileButton4.BackgroundImage = Properties.Resources.correct__1_;
                bunifuTileButton4.Enabled = false;
            }
        }

        private void bunifuTileButton5_Click(object sender, EventArgs e)
        {
            if (selection < 3)
            {
                numberList.Add(5);
                selection += 1;
                bunifuTileButton5.BackgroundImage = Properties.Resources.correct__1_;
                bunifuTileButton5.Enabled = false;
            }
        }

        private void bunifuTileButton6_Click(object sender, EventArgs e)
        {
            if (selection < 3)
            {
                numberList.Add(6);
                selection += 1;
                bunifuTileButton6.BackgroundImage = Properties.Resources.correct__1_;
                bunifuTileButton6.Enabled = false;
            }
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
