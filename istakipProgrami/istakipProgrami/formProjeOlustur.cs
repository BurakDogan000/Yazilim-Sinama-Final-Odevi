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
    public partial class formProjeOlustur : MetroFramework.Forms.MetroForm
    {
        public formProjeOlustur()
        {
            InitializeComponent();
        }


        public formProjeOlustur(Proje projeGetir)
        {
            _proje = projeGetir;
            InitializeComponent();
        }

        private Proje _proje;

        VTBaglan vt = new VTBaglan();

        private void projeYatar()
        {
            SqlCommand c = new SqlCommand("insert into tb_projeler (projeismi, musteri, bilgi) values (@p1, @p2, @p3)", vt.bagla());
            c.Parameters.AddWithValue("@p1", _proje.Projeİsmi);
            c.Parameters.AddWithValue("@p2", _proje.Musteri);
            c.Parameters.AddWithValue("@p3", _proje.Bilgi);
            c.ExecuteNonQuery();
            vt.bagla().Close();
                        
            c = new SqlCommand("select IDENT_CURRENT('tb_projeler')", vt.bagla());
            SqlDataReader dr = c.ExecuteReader();
            if (dr.Read())
                _proje.Id = Convert.ToInt32(dr[0]);
            vt.bagla().Close();
                        
            c = new SqlCommand("insert into tb_projeSorumlu (projeId, kullaniciId) values (@p1, @p2)", vt.bagla());
            c.Parameters.AddWithValue("@p1", _proje.Id);
            c.Parameters.AddWithValue("@p2", Kullanici._login.Id);
            c.ExecuteNonQuery();
            vt.bagla().Close();
        }


        public void projeGuncelle()
        {
            SqlCommand c = new SqlCommand("update tb_projeler set projeismi=@p1, musteri=@p2, bilgi=@p3 where ID=@p4", vt.bagla());
            c.Parameters.AddWithValue("@p1", _proje.Projeİsmi);
            c.Parameters.AddWithValue("@p2", _proje.Musteri);
            c.Parameters.AddWithValue("@p3", _proje.Bilgi);
            c.Parameters.AddWithValue("@p4", _proje.Id);
            c.ExecuteNonQuery();
            vt.bagla().Close();
        }
        private void btnOlustur_Click(object sender, EventArgs e)
        {
            bool kontrol = true;
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = (TextBox)item;
                    if (String.IsNullOrEmpty(txt.Text))
                    {
                        kontrol = false;
                        break;
                    }
                }
            }


            if (kontrol == true)
            {
                _proje = new Proje();
                _proje.Projeİsmi = txtProje.Text.Trim();
                _proje.Musteri = txtMusteri.Text.Trim();
                _proje.Bilgi = txtNot.Text.Trim();
                if (_proje.Id <= 0)
                {
                    projeYatar();
                    MessageBox.Show("Yeni proje yaratıldı");
                }
                else
                {
                    projeGuncelle();
                    MessageBox.Show("Proje güncellendi");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen boşlukları doldurunuz");
            }
        }

        private void formProjeOlustur_Load(object sender, EventArgs e)
        {
            if (_proje != null)
            {
                txtProje.Text = _proje.Projeİsmi;
                txtMusteri.Text = _proje.Musteri;
                txtNot.Text = _proje.Bilgi;
            }
        }
    }
}
