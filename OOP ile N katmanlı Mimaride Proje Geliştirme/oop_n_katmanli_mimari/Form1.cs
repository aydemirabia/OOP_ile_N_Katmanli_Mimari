using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entity_Layer;
using DataAccessLayer;
using LogicLayer;

namespace oop_n_katmanli_mimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            EntityPersonel entE = new EntityPersonel();
            entE.Ad = txtAD.Text;
            entE.Soyad = txtSOYAD.Text;
            entE.Sehir = txtSEHIR.Text;
            entE.Gorev = txtGOREV.Text;
            entE.Maas = short.Parse(txtMAAS.Text);
            LogicPersonel.LLPersonel(entE);
            MessageBox.Show("Personel Eklendi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(txtID.Text);
            LogicPersonel.LLPersonelSil(ent.Id);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Id = Convert.ToInt32(txtID.Text);
            ent.Ad = txtAD.Text;
            ent.Soyad = txtSOYAD.Text;
            ent.Sehir = txtSEHIR.Text;
            ent.Gorev = txtGOREV.Text;
            ent.Maas = short.Parse(txtMAAS.Text);
            LogicPersonel.LLPersonelGuncelle(ent);
        }
    }
}
