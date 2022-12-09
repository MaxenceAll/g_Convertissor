using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace g_Convertissor
{
    public partial class Monnaies : Form
    {
        //Déclaration globale pour facilter les choses ...
        Dictionary<string, double> conversionMap = new Dictionary<string, double>();
        //List pour la sauvegarde des précédentes opérations.
        List<string> sauvegardes = new List<string>();
        List<string> sauvegardesWithNow = new List<string>();

        public Monnaies()
        {
            InitializeComponent();            
            //Ajout de la table de conversion dans la hashmap :
            conversionMap.Add("Dollar", 1);
            conversionMap.Add("Euro", 0.94659594);
            conversionMap.Add("Pounds", 0.81416675);
            conversionMap.Add("Yen", 135.76175);
            //Avoir dans le combobox les keys (monnaies) dispos dans conversionMap (hashmap):
            comboBoxSource.DataSource= conversionMap.Keys.ToList();
            comboBoxResultat.DataSource= conversionMap.Keys.ToList();
            //remplir la gridview avec le contenu de la hashmap conversionMap (hashmap = 2 list, donc il faut convertir 1list key ET 1list Value) :
            dataGridView1.DataSource  = (from map in conversionMap select new { map.Key, map.Value } ).ToList();
            //changer la topleft cell :
            //dataGridView1.TopLeftHeaderCell.Value = "Table de conversion!";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            calculerConversion();
            string result = "-- " + (textBoxSource.Text) + ((Convert.ToString(comboBoxSource.SelectedItem)).ToLower()) + " = " + (textBoxResultat.Text) + ((Convert.ToString(comboBoxResultat.SelectedItem)).ToLower()) + ".";
            sauvegardes.Add(result);
            sauvegardesWithNow.Add(now + result);
            comboBoxSauvegarde.DataSource = sauvegardes.ToArray();
        }
        private void textBoxSource_TextChanged(object sender, EventArgs e)
        {
            calculerConversion();
        }
        private void textBoxResultat_TextChanged(object sender, EventArgs e)
        {
            calculerConversion();
        }
        private void comboBoxSource_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculerConversion();
        }
        private void comboBoxResultat_SelectedIndexChanged(object sender, EventArgs e)
        {
            calculerConversion();
        }
        private void calculerConversion()
        {
            double source = 0;
            double taux = 0;
            double resultat = 0;
            if (textBoxSource.Text != "")
            {
                if (double.TryParse(textBoxSource.Text, out source))
                {
                    source = Convert.ToDouble(textBoxSource.Text);
                    taux = (conversionMap.GetValueOrDefault(Convert.ToString(comboBoxResultat.SelectedItem))) / (conversionMap.GetValueOrDefault(Convert.ToString(comboBoxSource.SelectedItem)));
                    resultat = Math.Round(source * taux, 2);
                    textBoxResultat.Text = Convert.ToString(resultat);
                    labelResultat.BackColor = Color.Teal;
                    labelResultat.Text = "--   Vous voulez convertir des '" + (Convert.ToString(comboBoxSource.SelectedItem)).ToUpper() + "' en '" + (Convert.ToString(comboBoxResultat.SelectedItem)).ToUpper() + "'.";
                    labelResultat.Text += "\n--   Le taux pour cette conversion est " + taux + ".";
                    labelResultat.Text += "\n--   " + (textBoxSource.Text) + ((Convert.ToString(comboBoxSource.SelectedItem)).ToLower()) + " = " + (textBoxResultat.Text) + ((Convert.ToString(comboBoxResultat.SelectedItem)).ToLower()) + ".";
                }
                else // si tryparse KO
                {
                    //button1.Font.Strikeout = true;
                    labelResultat.BackColor = Color.Red;
                    labelResultat.Text = "Merci de vérifier la saisie ☺ !";
                }

            }
            else // si text vvide
            {
                labelResultat.BackColor = Color.Teal;
                labelResultat.Text = "Merci de faire votre saisie !";
            }
        }
        private async void button2_Click(object sender, EventArgs e)
        {
            string result = "--   " + (textBoxSource.Text) + ((Convert.ToString(comboBoxSource.SelectedItem)).ToLower()) + " = " + (textBoxResultat.Text) + ((Convert.ToString(comboBoxResultat.SelectedItem)).ToLower()) + ".";
            Clipboard.SetText(result);
            labelClipBoard.Visible = true;
            await Task.Delay(1000);
            labelClipBoard.Visible = false;
        }

        private async void buttonExport_Click(object sender, EventArgs e)
        {

            string[] toSave = sauvegardesWithNow.ToArray();
            File.AppendAllLines(@"C:\temp\test.txt", toSave);
            labelExport.Visible = true;
            await Task.Delay(1000);
            labelExport.Visible = false;
        }

        private async void buttonImport_Click(object sender, EventArgs e)
        {
            // split pour supprimer le now afin d'importer sans le now();
            string[] toLoad = (File.ReadAllLines(@"C:\temp\test.txt"));
            sauvegardes.AddRange(toLoad);
            comboBoxSauvegarde.DataSource = sauvegardes.ToArray();
            labelImport.Visible = true;
            await Task.Delay(1000);
            labelImport.Visible = false;
        }
    }
}
