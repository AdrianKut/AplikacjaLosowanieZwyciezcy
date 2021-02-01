using System;
using System.IO;
using System.Media;
using System.Threading;
using System.Windows.Forms;

namespace LosowanieZwyciezcy
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        SoundPlayer snd = new SoundPlayer(Properties.Resources.winning);
        private void changerLabelNumberOfPerson()
        {
            labelNumberOfPerson.Text = "👥Liczba osób: " + listBoxMain.Items.Count;
            if (listBoxMain.Items.Count == 0)
            {
                buttonDraw.Enabled = false;
            }
            else
            {
                buttonDraw.Enabled = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
            changerLabelNumberOfPerson();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < random.Next(10, 40); i++)
            {
                listBoxMain.SetSelected(random.Next(listBoxMain.Items.Count), true);
                Thread.Sleep(250);
            }
            snd.Play();
            labelWinnner.Text = "" + listBoxMain.SelectedItem.ToString();
            Thread.Sleep(500);
            DialogResult dialogResult = MessageBox.Show("\nZwyięzcą został: " + listBoxMain.SelectedItem.ToString() + "\n" +
                "\nCzy chcesz go usunąć z listy?", "BRAWO!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    listBoxMain.Items.Remove(listBoxMain.SelectedItem);
                    changerLabelNumberOfPerson();
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.FileName = "";
            openFileDialog1.Title = "Wybierz osoby";
            openFileDialog1.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                {
                    while (!sr.EndOfStream)
                    {
                        listBoxMain.Items.Add(sr.ReadLine());
                    }
                }
            }
            changerLabelNumberOfPerson();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listBoxMain.Items.Clear();
            changerLabelNumberOfPerson();
            buttonDraw.Enabled = false;
        }

        private void buttonAddNewPerson_Click(object sender, EventArgs e)
        {
            if (textBoxPerson.Text != "")
            {
                listBoxMain.Items.Add(textBoxPerson.Text);
                buttonDraw.Enabled = true;
                textBoxPerson.Text = "";
                labelNumberOfPerson.Text = "Liczba osób: " + listBoxMain.Items.Count;
                changerLabelNumberOfPerson();
            }
            else
            {
                MessageBox.Show("Wprowadź dane!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                changerLabelNumberOfPerson();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBoxMain.Items.Remove(listBoxMain.SelectedItem);
            changerLabelNumberOfPerson();

        }

        private void listBoxMain_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                listBoxMain.Items.Remove(listBoxMain.SelectedItem);
                changerLabelNumberOfPerson();
            }

        }
    }

}
