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
    public partial class formGorev : MetroFramework.Forms.MetroForm
    {
        private Proje _proje;
        private Gorev _gorev;
        VTBaglan vt = new VTBaglan();

        public formGorev(Proje proje)
        {
            _proje = proje;
            InitializeComponent();
        }

        public formGorev(Gorev gorev, Proje proje)
        {
            _proje = proje;
            _gorev = gorev;
            InitializeComponent();
        }
        private void formGorev_Load(object sender, EventArgs e)
        {
            gorevliler();

            if (_gorev != null)
            {
                txtBaslik.Text = _gorev.Baslik;
                txtAciklama.Text = _gorev.Aciklama;

                int i = 0;
                foreach (Kullanici item in _proje.Sorumlu)
                {
                    if (item.Id == _gorev.Gorevli)
                    {
                        cmbGorevliler.SelectedIndex = i;
                        break;
                    }
                    i++;
                }
                if (_gorev.Durum == 3)
                {
                    txtBaslik.Enabled = false;
                    txtAciklama.Enabled = false;
                    cmbGorevliler.Enabled = false;
                    btnKaydet.Enabled = false;
                }
            }
        }
        private void gorevliler()
        {
            foreach (Kullanici item in _proje.Sorumlu)
            {
                cmbGorevliler.Items.Add(item.KullaniciAdi);
            }
        }
        private void gorevEkle(Gorev gorevEkle, int projeId)
        {
            if (tekrarKayit(projeId, gorevEkle.Baslik))
            {
                SqlCommand c = new SqlCommand("insert into tb_gorevler (projeId, baslik, gorevliId, aciklama) values (@p1, @p2, @p3, @p4)", vt.bagla());
                c.Parameters.AddWithValue("@p1", projeId);
                c.Parameters.AddWithValue("@p2", gorevEkle.Baslik);
                c.Parameters.AddWithValue("@p3", gorevEkle.Gorevli);
                c.Parameters.AddWithValue("@p4", gorevEkle.Aciklama);
                c.ExecuteNonQuery();
                vt.bagla().Close();

                int gorevID = 0;
                c = new SqlCommand("select IDENT_CURRENT('tb_gorevler')", vt.bagla());
                SqlDataReader dr = c.ExecuteReader();
                if (dr.Read())
                {
                    gorevID = Convert.ToInt32(dr[0]);
                }
                vt.bagla().Close();
                                
                c = new SqlCommand("insert into tb_gorevHareket (gorevId, durumId, kullaniciId, tarih) values (@p1, @p2, @p3, @p4)", vt.bagla());
                c.Parameters.AddWithValue("@p1", gorevID);
                c.Parameters.AddWithValue("@p2", 1);
                c.Parameters.AddWithValue("@p3", Kullanici._login.Id);
                c.Parameters.AddWithValue("@p4", DateTime.Now);
                c.ExecuteNonQuery();
                vt.bagla().Close(); 
            }
        }
        private bool tekrarKayit(int projeId, string baslik, bool yeni = true, int gorevId = 0)
        {
            bool onay = true;
            string sorgu = "";
            if (yeni)
                sorgu = "select * from tb_gorevler where projeId = @p1 and baslik = @p2";
            else
                sorgu = "select * from tb_gorevler where projeId = @p1 and baslik = @p2 and ID <> @p3";
            SqlCommand c = new SqlCommand(sorgu, vt.bagla());            
            c.Parameters.AddWithValue("@p1", projeId);
            c.Parameters.AddWithValue("@p2", baslik);
            c.Parameters.AddWithValue("@p3", gorevId);
            SqlDataReader dr = c.ExecuteReader();
            if (dr.Read())
            {
                onay = false;
            }
            vt.bagla().Close();
            return onay;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtBaslik.Text) && cmbGorevliler.SelectedIndex >= 0)
            {
                if (_gorev == null)
                {
                    Gorev gr = new Gorev();
                    gr.Baslik = txtBaslik.Text;
                    gr.Aciklama = txtAciklama.Text;
                    gr.Durum = 1;
                    gr.Gorevli = _proje.Sorumlu[cmbGorevliler.SelectedIndex].Id;
                    gorevEkle(gr, _proje.Id);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Lütfen boş alanları doldurunuz");
            }
        }
    }
}
