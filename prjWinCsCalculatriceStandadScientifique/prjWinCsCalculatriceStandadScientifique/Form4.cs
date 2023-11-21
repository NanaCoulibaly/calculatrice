using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace prjWinCsCalculatriceStandadScientifique
{
    public partial class Form4 : Form
    {

        public struct Pays
        {
            public string Nom;
            public string Devise;
            public string Valeur;
        }
        List<Pays> tabPays = new List<Pays>();
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            StreamReader monfichier = new StreamReader("countries.txt");
            while (monfichier.EndOfStream == false)
            {
               Pays unpays;
                unpays.Nom = monfichier.ReadLine();
                unpays.Devise=monfichier.ReadLine();
                unpays.Valeur =  monfichier.ReadLine();
                tabPays.Add(unpays);
            }
            monfichier.Close();

            foreach(Pays unpays in tabPays)
            {
                cboPays.Items.Add(unpays.Nom);
            }
        }

        private void cboPays_SelectedIndexChanged(object sender, EventArgs e)
        {
            //    if(cboPays.SelectedIndex != -1)
            //    {
            //        int indiceSelect = cboPays.SelectedIndex;
            //        Pays unpays=tabPays[indiceSelect];
            //        //lblDollars.Text = unpays.Devise;
            //        //lblFranc.Text = unpays.Valeur;
            //        lblDollars.Text = " 1 US Dollars = 5.109862"
            //    }
            if(cboPays.SelectedIndex == 0)
            {
                lblDollars.Text = " 1 US Dollar = 5.109862 Franc(s) ";
                lblFranc.Text = " 1 Franc(s) = 0.1957 US Dollar";
                radDollars.Text = "De US Dollar a Franc";
                radFranc.Text = " De Franc a US Dollar ";

            }
            else if(cboPays.SelectedIndex == 1)
            {
                lblDollars.Text = " 1 US Dollar = 1.30 C.N Dollar  ";
                lblFranc.Text = " 1 C.N Dollar = 0.9957 US Dollar ";
                radDollars.Text = " De US Dollar a C.N Dollar";
                radFranc.Text = " C.N Dollar a US Dollar ";
            }
            else if (cboPays.SelectedIndex == 2)
            {
                lblDollars.Text = " 1 US Dollar = 0.85 Pound  ";
                lblFranc.Text = " 1 Pound = 1.9813 US Dollar ";
                radDollars.Text = " De US Dollar a Pound ";
                radFranc.Text = " De Pound a US Dollar ";
            }
            else
            {
                lblDollars.Text = " 1 US Dollar = 137.25 Yen ";
                lblFranc.Text = " 1 Yen = 1.1257 US Dollar ";
                radDollars.Text = " De US Dollar a Yen";
                radFranc.Text = " De Yen a US Dollar ";
            }


        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radDollars.Checked == true)
            {
                lblDevise.Text= "US Dollars";
            }
            //else
            //{
            //    lblDevise.Text="Francs";
            //}
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (cboPays.SelectedIndex == 0)
            {
                //lblDollars.Text = " 1 US Dollar = 5.109862 Franc(s) ";
                //lblFranc.Text = " 1 Franc(s) = 0.1957 US Dollar";
                lblDevise.Text = " Franc ";
                radDollars.Text = " De US Dollar a Franc";
                radFranc.Text = " De Franc a US Dollar ";
            }
            else if (cboPays.SelectedIndex == 1)
            {
               lblDevise.Text = " C.N Dollar ";
                radDollars.Text = " De US Dollar a C.N Dollar";
                radFranc.Text = " C.N Dollar a US Dollar ";
            }
            else if (cboPays.SelectedIndex == 2)
            {
                lblDevise.Text = " Pound ";
                radDollars.Text = " De US Dollar a Pound ";
                radFranc.Text = " De Pound a US Dollar ";
            
        }
            else
            {
                lblDevise.Text = " Yen ";
                radDollars.Text = " De US Dollar a Yen";
                radFranc.Text = " De Yen a US Dollar ";
            }
        }

        private void btnConversion_Click(object sender, EventArgs e)
        {
            if (cboPays.SelectedIndex != -1)
            {

                int indiceSelect = cboPays.SelectedIndex;
                Pays unpays = tabPays[indiceSelect];
                Single val = Convert.ToSingle(unpays.Devise);
                Single valeur = uint.Parse(txtMontant.Text);
                Single resultat;
                if (cboPays.SelectedIndex != -1)
                {
                    resultat = val * valeur;
                    lblAffichage.Text = valeur.ToString();
                }
            }
        }

        private void lblDevise_Click(object sender, EventArgs e)
        {

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            cboPays.Text=lblDevise.Text=lblAffichage.Text=lblDollars.Text
                =lblFranc.Text=txtMontant.Text= "";
            if (radDollars.Checked == true)
            {
                radDollars.Checked = false;
            }
            else if(radFranc.Checked == true)
            {
                radFranc.Checked = false;
            }
        }

        private void txtMontant_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
