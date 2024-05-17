using MyFirstApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Windows.Forms;
using static MyFirstApp.Models.Candidats;

namespace MyFirstApp
{
    public partial class Form1 : Form
    {
        private string path = @"C:\Users\hrtusl21\Source\Repos\VotingAppjihi\MyFirstApp\Jsons\candidats.json";
        public List<Candidats> candidatesList = new List<Candidats>();
        public List<Detail> details = new List<Detail>();
        private int lastIdx { get; set; }

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


                var kandidatiArray = jsonDocument.RootElement.GetProperty("kandidati");


                foreach (var kandidatJson in kandidatiArray.EnumerateArray())
                {
                    var kandidat = new Candidats
                    {
                        Name = kandidatJson.GetProperty("name").GetString(),
                        PoliticalParty = kandidatJson.GetProperty("strana").GetString(),
                        TotalVotes = kandidatJson.GetProperty("pocetHlavsov").GetInt32(),

                    };


                    var detailKandidata = kandidatJson.GetProperty("detail");

                    var detail = new Detail
                    {
                        BirthDate = detailKandidata.GetProperty("narodenie").GetString(),
                        Info = detailKandidata.GetProperty("info").GetString(),
                        ImagePath = detailKandidata.GetProperty("imagePath").GetString()
                    };

                    kandidat.KandiatDetail = detail;
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

            foreach (var candidate in candidatesList)
            {
                if (candidate.PoliticalParty == string.Empty)
                {
                    listBox1.Items.Add(candidate.Name);
                }
                else
                {
                    listBox1.Items.Add(candidate.Name + "-" + candidate.PoliticalParty);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lastIdx = listBox1.SelectedIndex;
        }

        private void Form2_YesButtonClicked(object sender, EventArgs e)
        {

            int selectedIndex = listBox1.SelectedIndex;
            candidatesList[selectedIndex].TotalVotes++;


        }

        private void Form2_NoButtonClicked(object sender, EventArgs e)
        {

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

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this.candidatesList);

            form3.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(path, JsonSerializer.Serialize(new { kandidati = this.candidatesList }));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {

                Form4 form4 = new Form4(this.candidatesList);
                form4.ShowCandidateDetail(listBox1.SelectedIndex);
                form4.ShowDialog();
            }
            else
            {
                MessageBox.Show("MusÌö zvoliù kandid·ta!");
            }
        }
    }
}
