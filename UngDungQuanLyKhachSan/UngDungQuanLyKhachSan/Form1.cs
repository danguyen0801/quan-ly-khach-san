using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungQuanLyKhachSan
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTileButton1_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CUSTOMER' table. You can move, or remove it, as needed.
            this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);
            // TODO: This line of code loads data into the 'dataSet1.ROOM' table. You can move, or remove it, as needed.
            this.rOOMTableAdapter.Fill(this.dataSet1.ROOM);
            //dataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            //dataGridView1.DataSource = GetAllInfo().Tables[0];
            textBox1.Text = "vothientin";
        }
        DataSet GetAllInfo()
        {
            DataSet data = new DataSet();

            string truyVan = "select * from ROOM";
            using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
            {
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(truyVan, connection);
                adapter.Fill(data);
                    
                connection.Close();

            }

            return data;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridView1.AutoSizeColumnsMode = (DataGridViewAutoSizeColumnsMode)DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.DataSource = GetAllInfo().Tables[0];
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
