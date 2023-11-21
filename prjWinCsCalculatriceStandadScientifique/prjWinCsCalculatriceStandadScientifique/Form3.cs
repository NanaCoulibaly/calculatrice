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
    public partial class Form3 : Form
    {
        int i = 0;
        public Form3()
        {
            InitializeComponent();
        }

        private void btnHuit_Click(object sender, EventArgs e)
        {
            
        }

        private void btnNeuf_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                txtResultat.Text = "9";
                i = 1;
            }
            else
            {
                txtResultat.Text += "9";
            }
        }

        private void btnSept_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                txtResultat.Text = "7";
                i = 1;
            }
            else
            {
                txtResultat.Text += "7";
            }
        }

        private void btnQuatre_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                txtResultat.Text = "4";
                i = 1;
            }
            else
            {
                txtResultat.Text += "4";
            }
        }

        private void btnUn_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                txtResultat.Text = "1";
                i = 1;
            }
            else
            {
                txtResultat.Text += "1";
            }
        }

        private void btnCinq_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                txtResultat.Text = "5";
                i = 1;
            }
            else
            {
                txtResultat.Text += "5";
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                txtResultat.Text = "6" 
                    ;
                i = 1;
            }
            else
            {
                txtResultat.Text += "6";
            }
        }

        private void btnTrois_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                txtResultat.Text = "3";
                i = 1;
            }
            else
            {
                txtResultat.Text += "3";
            }
        }

        private void btnDeux_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                txtResultat.Text = "2";
                i = 1;
            }
            else
            {
                txtResultat.Text += "2";
            }
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                txtResultat.Text = "0";
                i = 1;
            }
            else
            {
                txtResultat.Text += "0";
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                txtResultat.Text = ".";
                i = 1;
            }
            else if(!txtResultat.Text.Contains("."))
            {
                txtResultat.Text += ".";
            }
        }

        private void btnLn_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                txtResultat.Text = "ln";
                i = 1;
            }
            else
            {
                txtResultat.Text += "ln";
            }
        }

        private void btnParOuvert_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                txtResultat.Text = "(";
                i = 1;
            }
            else
            {
                txtResultat.Text += "(";
            }
        }

        private void btnParFerme_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                txtResultat.Text = ")";
                i = 1;
            }
            else
            {
                txtResultat.Text += ")";
            }
        }
        double resultat = 0;
        double valeur = 0, nombre = 0;
        string operateur = "";

        private void btnEgalite_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResultat.Text) && operateur != "" && txtResultat.Text != ".")
            {
                nombre = Convert.ToDouble(txtResultat.Text);
                if (operateur == "+")
                {
                    resultat = valeur + nombre;
                }
                else if (operateur == "-")
                {
                    resultat = valeur - nombre;
                }
                else if (operateur == "x")
                {
                    resultat = valeur * nombre;
                }
                else if (operateur == "÷")
                {
                    resultat = valeur / nombre;
                }
                else if (operateur == "ln")
                {
                   resultat= nombre* valeur;
                }
                txtResultat.Text = resultat.ToString();
            }
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtResultat.Text) && txtResultat.Text != ".")
                {
                valeur = Convert.ToDouble(txtResultat.Text);
                operateur = "+";
                i = 0;
            }
        }

        private void btnSoustraction_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResultat.Text))
            {
                valeur = Convert.ToDouble(txtResultat.Text);
                operateur = "-";
                i = 0;
            }
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResultat.Text))
            {
                valeur = Convert.ToDouble(txtResultat.Text);
                operateur = "x";
                i = 0;
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResultat.Text))
            {
                valeur = Convert.ToDouble(txtResultat.Text);
                operateur = "÷";
                i = 0;
            }
        }

        private void btnHuit_Click_1(object sender, EventArgs e)
        {
            if (i == 0)
            {
                txtResultat.Text = "8";
                i = 1;
            }
            else
            {
                txtResultat.Text += "8";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtResultat.Text = null;
            valeur = 0;
            nombre = 0;
            i = 0;
        }

        private void btnXCarre_Click(object sender, EventArgs e)
        {
            Single val = Convert.ToSingle(txtResultat.Text);
            double nbr = Convert.ToDouble(txtResultat.Text);
            txtResultat.Text = Convert.ToString(val * nbr);

        }

        private void btnUnsurX_Click(object sender, EventArgs e)
        {
            double div = Convert.ToDouble(txtResultat.Text);
            txtResultat.Text = Convert.ToString(1 / div);
        }

        private void btnRcDeuxX_Click(object sender, EventArgs e)
        {

        }

        private void btnN_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                txtResultat.Text = "1";
                i = 1;
            }
            else
            {
                txtResultat.Text += "1";
            }
        }

        private void btnPi_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                txtResultat.Text = "3,141592653589793";
                i = 1;
            }
            else
            {
                txtResultat.Text = "3,141592653589793";
               
            }
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                txtResultat.Text = "2,7118281828459045";
                i = 1;
            }
            else
            {
                txtResultat.Text = "2,7118281828459045";

            }
        }

        private void btnXpuissY_Click(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {

        }

        private void btnValAbsoX_Click(object sender, EventArgs e)
        {

        }

        private void btnDixpuissX_Click(object sender, EventArgs e)
        {
            Single val;
            double puis;
            if (i == 0)
            {
                txtResultat.Text = "1";
            }
           
        }

        private void btnSecond_Click(object sender, EventArgs e)
        {

        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtResultat.Text))
            {
                txtResultat.Text=txtResultat.Text.Remove(txtResultat.Text.Length - 1);

            }
            
        }
    }
}
