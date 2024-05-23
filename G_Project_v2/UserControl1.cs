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
    public partial class UserControl1 : UserControl
    {
        
        Dictionary<string,Entity >entiDict ;
        Button eBtn;
        List<Button> list;

        public UserControl1()
        {
            InitializeComponent();
            list = new List<Button>();
            addingEnti1.Hide();
            button1.Hide();
            entiDict = new Dictionary<string,Entity>();
            entInfo1.Hide();

        }

        public void AddingEntiBtn(string name, string genere, Image image, int wh, int eLong, DateTime born)
        {
            eBtn = new CircleButton();
            list.Add(eBtn);
            flowLayoutPanel1.Controls.Add(eBtn);
            eBtn.Click += EBtn_Click;
            eBtn.Text = name;
            eBtn.Name = name;
            eBtn.BackgroundImage = image;
            eBtn.BackgroundImageLayout =ImageLayout.Stretch;
            eBtn.FlatStyle = FlatStyle.Flat; // Usuń standardowe obramowanie
            eBtn.FlatAppearance.BorderSize = 0; // Wyłącz obramowanie
            eBtn.Size = new Size(image.Width + 5, image.Height + 5);
            eBtn.Width = 150; eBtn.Height = 150;
            flowLayoutPanel1.Refresh();
            Entity entity = new Entity(name, genere, image, wh,eLong , born);
            entiDict.Add(name, entity);
        }

        private void EBtn_Click(object? sender, EventArgs e)
        {
            if (sender is CircleButton clickedButton)
            {
               entInfo1.Show();
                string buttonName = clickedButton.Name;
                if (entiDict.TryGetValue(buttonName, out Entity entity))
                    
                entInfo1.labName.Text = "imie: " + entity.GetName();
                entInfo1.labGen.Text = "Gatunek: " + entity.GetGen() ;
                entInfo1.labWh.Text = "Waga: " + entity.getWh();
                entInfo1.labElong.Text = "Rozmiar: " + entity.GetLong();
                entInfo1.labBorn.Text = "Data urodzenia: " + (entity.GetBorn()).ToString("dd.MM.yyyy"); ;
                    }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            DateTime born = addingEnti1.dateTimePicker1.Value;
            AddingEntiBtn(addingEnti1.textBoxName.Text, addingEnti1.textBoxELong.Text, addingEnti1.pictureBox1.Image,
             int.Parse(addingEnti1.textBoxWh.Text), int.Parse(addingEnti1.textBoxELong.Text), born); ;
            addingEnti1.Hide();
            button2.Show();
            button1.Hide();
            addingEnti1.textBoxELong.Text = "";
            addingEnti1.textBoxName.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Show();
            button2.Hide();
            addingEnti1.Show();
        }
    }
}
