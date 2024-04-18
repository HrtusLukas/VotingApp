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
            dataGridView1.Columns.Add("name", "name"); //add column
            dataGridView1.Rows.Add("hello"); //add rows with data
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }



        
    }
}
