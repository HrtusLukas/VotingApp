using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstApp
{
    public partial class Form2 : Form
    {

        public event EventHandler YesButtonClicked;
        public event EventHandler NoButtonClicked;
        public Form2()
        {
            InitializeComponent();
            this.Enabled = true;
        }
        //Yes button
        private void button1_Click(object sender, EventArgs e)
        {
            YesButtonClicked?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
        //No button
        private void button2_Click(object sender, EventArgs e)
        {
            NoButtonClicked?.Invoke(this, EventArgs.Empty);
            this.Close();
        }
    }
}
