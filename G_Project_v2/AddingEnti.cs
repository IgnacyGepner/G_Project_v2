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
        public AddingEnti()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFileDialog1.Filter = "Pliki obrazów|*.jpg;*.jpeg;*.png;*.bmp|Wszystkie pliki|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // Wczytaj obraz z wybranego pliku
                Image image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = image;
            }
        }
    }
}
