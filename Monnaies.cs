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
            conversionMap.Add("dollar", 1);
            conversionMap.Add("euro", 0.94659594);
            conversionMap.Add("pounds", 0.81416675);
            conversionMap.Add("yen", 135.76175);
            majDataGridView();
        }
        private void majDataGridView()
        {
            //remplir la gridview avec le contenu de la hashmap conversionMap (hashmap = 2 list, donc il faut convertir 1list key ET 1list Value) :
            dataGridView1.DataSource = (from map in conversionMap select new { map.Key, map.Value }).ToList();
            //Avoir dans le combobox les keys (monnaies) dispos dans conversionMap (hashmap): 
            comboBoxSource.DataSource = conversionMap.Keys.ToList();
            comboBoxResultat.DataSource = conversionMap.Keys.ToList();
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
                    labelResultat.Text = "--   Vous voulez convertir des \n'" + (Convert.ToString(comboBoxSource.SelectedItem)).ToUpper() + "' en '" + (Convert.ToString(comboBoxResultat.SelectedItem)).ToUpper() + "'.";
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
            string folderPath = "";            
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = Path.GetDirectoryName(saveFileDialog1.FileName);
            }            
            File.AppendAllLines(saveFileDialog1.FileName, toSave);
            labelExport.Visible = true;
            await Task.Delay(3000);
            labelExport.Visible = false;
        }
        private async void buttonImport_Click(object sender, EventArgs e)
        {
            // A FAIRE : split pour supprimer le now afin d'importer sans le now();            
            string folderPath = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                folderPath = Path.GetFullPath(openFileDialog1.FileName);
            }
            //MessageBox.Show(Convert.ToString (folderPath));
            string[] toLoad = (File.ReadAllLines(folderPath));
            for (int i = 0 ; i < toLoad.Length ; i++)
            {
                toLoad[i] = toLoad[i].Remove(0, 19);
            }
            sauvegardes.AddRange(toLoad);
            comboBoxSauvegarde.DataSource = sauvegardes.ToArray();
            labelImport.Visible = true;
            await Task.Delay(3000);
            labelImport.Visible = false;
        }
        private void buttonAddCurrency_Click(object sender, EventArgs e)
        {
            string newName = Microsoft.VisualBasic.Interaction.InputBox("Merci de saisir le nom de la monnaie à ajouter.", "Ajout d'une monnaie - nom");
            double newTaux = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Merci de saisir le taux de la monnaie à ajouter.", "Ajout d'une monnaie - taux"));
            conversionMap.Add(newName, newTaux);
            majDataGridView();
        }
        private void buttonModifyCurrency_Click(object sender, EventArgs e)
        {
            string currencyToModifyName = Microsoft.VisualBasic.Interaction.InputBox("Merci de saisir le nom de la monnaie à modifier.", "Modification d'une monnaie - nom");
            conversionMap.Remove(currencyToModifyName);
            string newName = Microsoft.VisualBasic.Interaction.InputBox("Merci de saisir le nouveau de la monnaie.", "Ajout d'une monnaie - nom");
            double newTaux = Convert.ToDouble(Microsoft.VisualBasic.Interaction.InputBox("Merci de saisir le nouveau taux.", "Ajout d'une monnaie - taux"));
            conversionMap.Add(newName, newTaux);
            majDataGridView();
        }
        private void buttonRemoveCurrency_Click(object sender, EventArgs e)
        {
            string currencyToRemoveName = Microsoft.VisualBasic.Interaction.InputBox("Merci de saisir le nom de la monnaie à supprimer.", "Retrait d'une monnaie - nom");
            conversionMap.Remove(currencyToRemoveName);
            majDataGridView();
        }
        private void buttonMajCurrency_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not yet implemented !! ☺☺☺");
        }
    }
}
