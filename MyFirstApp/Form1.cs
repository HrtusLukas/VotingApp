using MyFirstApp.Functions;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class Form1 : Form
    {

        string path = @"C:\Users\lukas\OneDrive\Poèítaè\UcimSaC#\MyFirstApp\MyFirstApp\Jsons\candidats.json";



        public Form1()
        {
            InitializeComponent();

            // Add dummy data
            listBox1.Items.Add("Dummy Data 1");
            listBox1.Items.Add("Dummy Data 2");
            listBox1.Items.Add("Dummy Data 3");
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            { 
                string selectedItem = listBox1.SelectedItem.ToString();

                MessageBox.Show("Selected Item: " + selectedItem);
            }
        }
    }
}
