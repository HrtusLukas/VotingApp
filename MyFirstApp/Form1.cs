using MyFirstApp.Functions;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

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
        //select candidate
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                string selectedItem = listBox1.SelectedItem.ToString();



            }
        }
        //vote button
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();


        }
        //Candidate info
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }
        //výsledky volieb
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
