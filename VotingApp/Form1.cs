using System.ComponentModel;
using System;
using System.Windows.Forms;
using MyFirstApp.Models;

namespace VotingApp
{
    public partial class Form1 : Form
    {
        string path = @"C:\Users\lukas\OneDrive\Poèítaè\UcimSaC#\MyFirstApp\MyFirstApp\Jsons\candidats.json";
        public BindingList<Candidats> candidats { get; set; }
        public Form1()
        {
            InitializeComponent();

           
            LoadData();
           

        }

        private void LoadData()
        {
            candidats = new BindingList<Candidats>()
            {
            new Candidats("Peter Pellegrini", "Hlas-SD"),
            new Candidats("Ivan Korèok", ""),
            new Candidats("Štefan Harabin", ""),
            };



            dataGridView1.DataSource = candidats;



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