using MyFirstApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class Form1 : Form
    {
        private string path = @"C:\Users\lukas\Source\Repos\VotingApp2\MyFirstApp\Jsons\candidats.json";
        private List<Candidats> candidatesList = new List<Candidats>();

        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SerializeAndDeserializeCandidates();
            AddCandidatesToListBox();
        }

        private void SerializeAndDeserializeCandidates()
        {
            try
            {
                string jsonString = File.ReadAllText(path);
                var jsonDocument = JsonDocument.Parse(jsonString);

                // Access the "kandidati" array
                var kandidatiArray = jsonDocument.RootElement.GetProperty("kandidati");

                // Deserialize each candidate object
                foreach (var kandidatJson in kandidatiArray.EnumerateArray())
                {
                    var kandidat = new Candidats
                    {
                        Name = kandidatJson.GetProperty("meno").GetString(),
                        PoliticalParty = kandidatJson.GetProperty("strana").GetString()
                    };
                    candidatesList.Add(kandidat);
                }
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("S˙bor sa nenaöiel");
            }
            catch (JsonException)
            {
                MessageBox.Show("ProblÈm bude s Jsonom");
            }
        }

        private void AddCandidatesToListBox()
        {
            listBox1.Items.Clear();
            // Add each candidate from the list to the listBox1
            foreach (var candidate in candidatesList)
            {
                listBox1.Items.Add(candidate.Name + "-" + candidate.PoliticalParty);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Handle selection change event
        }

        private void Form2_YesButtonClicked(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;
            candidatesList[selectedIndex].TotalVotes++;
            Console.WriteLine(candidatesList[selectedIndex].TotalVotes);
        }

        private void Form2_NoButtonClicked(object sender, EventArgs e)
        {
            // Do nothing or add any other action you want to perform when "No" is clicked
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                
                Form2 form2 = new Form2();
                form2.YesButtonClicked += Form2_YesButtonClicked;
                form2.NoButtonClicked += Form2_NoButtonClicked;
                form2.ShowDialog();
            }
            else
            {
                MessageBox.Show("MusÌö zvoliù kandid·ta!");
            }
        }

        
    }
}
