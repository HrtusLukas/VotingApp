using MyFirstApp.Functions;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class Form1 : Form
    {

        string path = @"C:\Users\lukas\OneDrive\Po��ta�\UcimSaC#\MyFirstApp\MyFirstApp\Jsons\candidats.json";
        

        
        public Form1()
        {
            InitializeComponent();
            dataGridView1 = new DataGridView();
            LoadCandidates();
        }


        private void LoadCandidates()
        {
            // Na��tajte kandid�tov zo s�boru JSON
            var candidates = JsonLoader.LoadCandidatesFromJson(path);

            // Priradenie na��tan�ch d�t do DataGridView
            dataGridView1.DataSource = candidates;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var can = JsonLoader.LoadCandidatesFromJson(path);
        }

        
    }
}
