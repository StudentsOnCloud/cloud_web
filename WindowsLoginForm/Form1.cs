using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace WindowsLoginForm
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void girisButon_Click(object sender, EventArgs e)
        {
            string kullanici_Adi = girisKullaniciAdi.Text;
            string sifre = girisSifre.Text;
            con = new SqlConnection("Data Source=DESKTOP-00A7JNL;Initial Catalog=StudentsOnCloud;Integrated Security=True");
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText="Select*from Kullanici_Bilgisi where kullanici_adi='"+girisKullaniciAdi.Text+"'and sifre='" + girisSifre.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show(" Tebrikler Giriş Başarılı");
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı ve ya Şifre");
            }
            con.Close();
        }
    }
}
