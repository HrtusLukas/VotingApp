using MyFirstApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MyFirstApp.Models.Candidats;

namespace MyFirstApp
{
    public partial class Form4 : Form
    {

        private List<Candidats> candidats = new List<Candidats>();
        private List<Detail> details = new List<Detail>();
        public Form4(List<Candidats> candidats)
        {
            InitializeComponent();
            this.candidats = candidats;

        }

        public void ShowCandidateDetail(int selectedIndex)
        {
            Candidats selectedCandidate = candidats[selectedIndex];
            label1.Text = selectedCandidate.Name;
            label2.Text = selectedCandidate.KandiatDetail.BirthDate;
            label3.Text = selectedCandidate.KandiatDetail.Info;
            pictureBox1.Image = Image.FromFile(selectedCandidate.KandiatDetail.ImagePath);


        }


    }
}
