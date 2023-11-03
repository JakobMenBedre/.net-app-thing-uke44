using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addisjon_Click(object sender, EventArgs e) //når man trykker på knappen som heter addisjon skjer det under
            
        {
            
            try { //try-catch mer eller mindre gjør slik at errors ikke bare ødelegger hele programmet, men at den bare stopper det den holder på med hvis det er noe som ikke funker (try)og så lar deg kjøre en kode som skjer da (catch).
                int combobox = Convert.ToInt32(comboBox1.Text); //lager integer som heter combobox som er verdien til comboBox1.Text men som en integer.
                if (combobox <= -1)
                {
                    MessageBox.Show("broder du kan ikke ha negative antall desimaltall. ødalagt as."); //sjekker om at combobox sin verdi er mindre enn 0. hvis den er så kjefter programmet på deg og kaller deg for ødelagt.
                }

                double verdi1 = Convert.ToDouble(input1.Text); //lager en double som heter verdi1 og verdien dens er input1.Text men gjort om til en double med Convert.ToDouble 
                double verdi2 = Convert.ToDouble(input2.Text); //samme som over men med verdi2 og input2.Text

                double res = Math.Round(verdi1 + verdi2, combobox); //lager en til double variabel som heter res. denne har verdien verdi1 + verdi2, men at den rundes opp til to desimaler med Math.Round([verdi], [antall desimaltall])
                resultat.Text = res.ToString(); //gjør gir resultat.Text verdien res are at den er en string.
                
            }
            catch (FormatException ex){
                resultat.Text = "Her har du skrevet noe galt:" + ex.Message;//her fanger program opp ting som har gått galt, sier at det har gått noe galt, og hva det er som er feil (på engelsk da) også så er ex error-messagen
            }
            catch (Exception ex)
            {
                resultat.Text = "Her har noe gått galt:" + ex.Message; //samme som over
            }
        }

        private void subtraksjon_Click(object sender, EventArgs e) 
        {

            try
            {

                int combobox = Convert.ToInt32(comboBox1.Text);
                if (combobox <= -1)
                {
                    MessageBox.Show("broder du kan ikke ha negative antall desimaltall. ødalagt as.");//alt det over men med subtraksjon
                }

                double verdi1 = Convert.ToDouble(input1.Text);
                double verdi2 = Convert.ToDouble(input2.Text);

                double res = Math.Round(verdi1 - verdi2, combobox);
                resultat.Text = res.ToString();
            }
            catch (FormatException ex)
            {
                resultat.Text = "Her har du skrevet noe galt:" + ex.Message;
            }
            catch (Exception ex)
            {
                resultat.Text = "Her har noe gått galt:" + ex.Message;
            }
        }

        private void multiplikasjon_Click(object sender, EventArgs e)
        {

            try
            {
                
                int combobox = Convert.ToInt32(comboBox1.Text);
                if (combobox <= -1)
                {
                    MessageBox.Show("broder du kan ikke ha negative antall desimaltall. ødalagt as.");//alt det over men med multiplikasjon
                }

                double verdi1 = Convert.ToDouble(input1.Text); 
                double verdi2 = Convert.ToDouble(input2.Text); 

                double res = Math.Round(verdi1 * verdi2, combobox); 
                resultat.Text = res.ToString(); 
            }
            catch (FormatException ex)
            {
                resultat.Text = "Her har du skrevet noe galt:" + ex.Message; 
            }
            catch (Exception ex)
            {
                resultat.Text = "Her har noe gått galt:" + ex.Message; 
            }
        }

        private void divisjon_Click(object sender, EventArgs e)
        {

            try
            {
                
                int combobox = Convert.ToInt32(comboBox1.Text);
                if (combobox <= -1)
                {
                    MessageBox.Show("broder du kan ikke ha negative antall desimaltall. ødalagt as."); // alt det over bare med divisjon og en til ting
                }

                double verdi1 = Convert.ToDouble(input1.Text); 
                double verdi2 = Convert.ToDouble(input2.Text);

                double res = Math.Round(verdi1 / verdi2, combobox); 
                resultat.Text = res.ToString(); 
                if (verdi2 == 0)
                {
                    MessageBox.Show("BRODER HVEM TROR DU AT DU ER MED AT DU PRØVER Å DELE PÅ 0!?!"); //om du prøver å dele på 0 kjefter programmet på deg med en popup.
                } 
            }
            catch (FormatException ex)
            {
                resultat.Text = "Her har du skrevet noe galt:" + ex.Message; 
            }
            catch (Exception ex)
            {
                resultat.Text = "Her har noe gått galt:" + ex.Message; 
            }
        }
    }
}
