using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G_Project_v2
{
    
    public partial class AddingEnti : UserControl
    {
        string[]genereList; 
        public AddingEnti()
        {
            InitializeComponent();
            genereList = new string[2];
            genereList[0] = "lampart";
            genereList[1] = "nie lampart";
            AddGenList();
            for (int i = 0; i < genereList.Length; i++)
            {
                genereCombo.Items.Add(genereList[i]);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Wczytaj obraz z wybranego pliku
                Image image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = image;
            }
        }

        private void genereCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void AddGenList()
        {


        }

    }
}
