using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_envoyer_Click(object sender, EventArgs e)
        {
            string nom = txt_nom.Text;

            string profession = txt_profession.Text;


            int salaire = int.Parse(txt_salaire.Text);
            string genre = txt_genre.Text;
            string hoobies = txt_hobbies.Text;


            if(rbt_female.Checked)

            {
                genre = "feminin";
            }
            
             else if (rbt_male.Checked)

            {
                genre = "masculin";

            }

            if(CKB_CINEMA.Checked)
            {
                hoobies = "Cinema";
            }
            else if(CKB_tv.Checked)
            {
                hoobies = "tv";
            }




            string message;
            message = ("M/Mme " + nom + " vous etes un genre " + genre + " qui pratique le metier de " + profession + "votre hoobie c'est regarder " + hoobies + "et votre salaire est de " + salaire);
            
            rtbox_afficher.Text = "M/Mme " + nom + " vous etes un genre ," + genre + " qui pratique le metier de, " + profession + " votre hoobie c'est regarder la  " + hoobies + "  et votre salaire est de :" + salaire +" FCFA";
           



        }

        private void rtbox_afficher_TextChanged(object sender, EventArgs e)
        {

        }

        private void LBL_save_Click(object sender, EventArgs e)
        {

        }

        private void btn_annuler_Click(object sender, EventArgs e)
        {

        }
    }
}
