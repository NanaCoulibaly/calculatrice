using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsCalculatriceStandadScientifique
{
    public partial class Form2 : Form
    {
        
        int j=0;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnEgalite_Click(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {

        }


        private void operateur_click(object sender, EventArgs e)
        {
          
        }

        private void btnNeuf_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                txtResultat.Text = "9";
                j = 1;
            }
            else
            {
                txtResultat.Text += "9";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                txtResultat.Text = "6";
                j = 1;
            }
            else
            {
                txtResultat.Text += "6";
            }
        }

        private void btnTrois_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                txtResultat.Text = "3";
                   
               j = 1;
            }
            else
            {
                txtResultat.Text += "3";
                   
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                txtResultat.Text = ".";
                j = 1;
            }
            else if(!txtResultat.Text.Contains(".") )
            {
                txtResultat.Text += ".";
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                txtResultat.Text = "0";
                j= 1;
            }
            else
            {
                txtResultat.Text += "0";
            }
        }

        private void btnDeux_Click(object sender, EventArgs e)
        {
            if (j== 0)
            {
                txtResultat.Text = "2";
                j = 1;
            }
            else
            {
                txtResultat.Text += "2";
            }
        }

        private void btnCinq_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                txtResultat.Text = "5";
               j = 1;
            }
            else
            {
                txtResultat.Text += "5";
            }
        }

        private void btnHuit_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                txtResultat.Text = "8";
                j = 1;
            }
            else
            {
                txtResultat.Text += "8";
            }
        }

        private void btnPlusparMoins_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUn_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                txtResultat.Text = "1";
                j = 1;
            }
            else
            {
                txtResultat.Text += "1";
            }
        }

        private void btnQuatre_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                txtResultat.Text = "4";
                j = 1;
            }
            else
            {
                txtResultat.Text += "4";
            }
        }

        private void btnSept_Click(object sender, EventArgs e)
        {
            if (j == 0)
            {
                txtResultat.Text = "7";
               j = 1;
            }
            else
            {
                txtResultat.Text += "7";
            }
        }
        double valeur = 0, nombre = 0;
        string operateur = "";


        private void btnAddition_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResultat.Text)&&txtResultat.Text!=".")
                {
                valeur = Convert.ToDouble(txtResultat.Text);
                operateur = "+";
                j = 0;
            }
        }
        //double resultat = 0;

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResultat.Text))
            {
                valeur = Convert.ToDouble(txtResultat.Text);
                operateur = "x";
                j = 0;
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResultat.Text))
            {
                valeur = Convert.ToDouble(txtResultat.Text);
                operateur = "÷";
                j = 0;
            }
        }

        private void btnSoustraction_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResultat.Text))
            {
                valeur = Convert.ToDouble(txtResultat.Text);
                operateur = "-";
                j = 0;
            }
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResultat.Text))
            {
                txtResultat.Text = txtResultat.Text.Remove(txtResultat.Text.Length - 1);

            }
        }
        double resultat = 0;

        private void btnPourcentage_Click(object sender, EventArgs e)
        {
            double pourc=Convert.ToDouble(txtResultat.Text);
            txtResultat.Text = Convert.ToString(pourc / 100);
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultat.Text = null;
            valeur = 0;
            nombre = 0;
            j = 0;
        }

        private void btnCE_Click(object sender, EventArgs e)
        {

        }

        private void btnUnsurX_Click(object sender, EventArgs e)
        {
            double div = Convert.ToDouble(txtResultat.Text);
            txtResultat.Text = Convert.ToString(1/div);
        }

        private void btnDeuxRacineX_Click(object sender, EventArgs e)
        {
            Single val = Convert.ToSingle(txtResultat.Text);
            double nbr=Convert.ToDouble(txtResultat.Text);
            txtResultat.Text=Convert.ToString(val*nbr);

        }

        private void button22_Click(object sender, EventArgs e)
        {
            
        }

        private void btnEgalite_Click_1(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResultat.Text) && operateur!="" && txtResultat.Text != ".")
            {
                nombre = Convert.ToDouble(txtResultat.Text);
                if ( operateur == "+") 
                {
                    resultat = valeur + nombre;
                }
               else if( operateur == "-")
                    {
                    resultat = valeur - nombre;
                }
                else if (operateur == "x")
                {
                    resultat = valeur * nombre;
                }
                else if (operateur == "÷")
                {
                    resultat = valeur /nombre;
                }
               txtResultat.Text = resultat.ToString();

            }
        }
    }
}
