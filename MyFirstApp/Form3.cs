using MyFirstApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class Form3 : Form
    {


        private List<Candidats> candidats = new List<Candidats>();
        public Form3(List<Candidats> candidats)
        {
            InitializeComponent();
            this.candidats = candidats;

            ShowStats();
        }

        //private void Form3_Load(object sender, EventArgs e)
        //{
        //    ShowStats();
        //}

        private void ShowStats()
        {


            foreach (var candidate in candidats)
            {
                listBox1.Items.Add(candidate.Name + "-" + candidate.TotalVotes); ;
            }

        }

        


    }
}
