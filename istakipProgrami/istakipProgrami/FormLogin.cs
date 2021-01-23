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

namespace istakipProgrami
{
    public partial class formLogin : MetroFramework.Forms.MetroForm
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            if (GirisKontrolu(txtKullaniciAdi.Text, txtSifre.Text))
            {
                formAnaIslemYeri fm = new formAnaIslemYeri();
                this.Hide();
                fm.ShowDialog();
            }
            else
            {
                MessageBox.Show("kullanıcı adı veya parola hatalı!", "Giriş Başarız", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        public bool GirisKontrolu(string kullaniciAdi, string parola)
        {
            bool onay = false;
            VTBaglan vt = new VTBaglan();
            if (kullaniciAdi == "" || parola == "")
            {

            }
            else
            {
            Sifreleme sifrele = new Sifreleme();
            SqlCommand c = new SqlCommand("select * from tb_kullanicilar where kullaniciAdi=@p1 and parola=@p2", vt.bagla());
            c.Parameters.AddWithValue("@p1", kullaniciAdi);
            c.Parameters.AddWithValue("@p2", sifrele.RijndaelSifrele(parola));
            SqlDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                onay = true;
                GirisBilgileri(Convert.ToInt16(dr["ID"]), dr["adi"].ToString(), dr["soyadi"].ToString(), dr["kullaniciAdi"].ToString());
            }
            vt.bagla().Close();
            }
            return onay;
        }



        private void GirisBilgileri(int _id, string _adi, string _soyadi, string _kullanici)
        {
            if (Kullanici._login == null)
                Kullanici._login = new Kullanici();

            Kullanici._login.Id = _id;
            Kullanici._login.Adi = _adi;
            Kullanici._login.Soyadi = _soyadi;
            Kullanici._login.KullaniciAdi = _kullanici;
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            formKayit fk = new formKayit();
            fk.ShowDialog();
        }
    }
}
