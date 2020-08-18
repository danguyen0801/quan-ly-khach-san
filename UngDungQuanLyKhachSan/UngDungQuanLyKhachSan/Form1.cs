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
        public Form_Main(string fullName)
        {
            InitializeComponent();
            this.Text = "Xin chào " + fullName;
            Rectangle screen = Screen.PrimaryScreen.WorkingArea;
            int w = Width >= screen.Width ? screen.Width : (screen.Width + Width) / 2;
            int h = Height >= screen.Height ? screen.Height : (screen.Height + Height) / 2;
            this.Location = new Point((screen.Width - w) / 2, (screen.Height - h) / 2);
            this.Size = new Size(w, h);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);
            this.rOOMTableAdapter.Fill(this.dataSet1.ROOM);
        }

        DataSet GetInfoPhong()
        {
            DataSet data = new DataSet();

            string truyVan = "select * from ROOM where ROOM_ID = '" + comboBox_soPhong.Text + "'";
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string truyVan = "select Distinct RENT_BILL.CUSTOMER_NAME, RENT_BILL.START_DATE, ROOM.*"
                + "FROM  RENT_BILL , ROOM "
                + "WHERE ROOM.ROOM_ID = '" + comboBox_soPhong.Text + "' AND ROOM.STATUS = N'Có Khách' and ROOM.ROOM_ID = RENT_BILL.ROOM_ID";
            try
            {
                DataSet data = new DataSet();
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(truyVan, connection);
                    adapter.Fill(data);
                    if (data.Tables[0].Rows.Count != 0)
                    {
                        dataGridView1.DataSource = data.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Phòng chưa có khách thuê");
                    }
                    connection.Close();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối! " + ex.Message);
            }

        }


        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void groupbox_Timkiem_Enter(object sender, EventArgs e)
        {

        }

        private void label_Khachhang_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {
            string truyVan = "select Distinct RENT_BILL.CUSTOMER_NAME, RENT_BILL.START_DATE, ROOM.*"
                + "FROM  RENT_BILL , ROOM "
                + "WHERE RENT_BILL.CUSTOMER_NAME = N'" + txt_tenKhachhang.Text + "' and  ROOM.ROOM_ID = RENT_BILL.ROOM_ID";
            try
            {
                DataSet data = new DataSet();
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(truyVan, connection);
                    adapter.Fill(data);
                    if (data.Tables[0].Rows.Count != 0)
                    {
                        dataGridView1.DataSource = data.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Không có khách hàng tương ứng");
                    }
                    connection.Close();

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối! " + ex.Message);
            }
        }
    }
}
