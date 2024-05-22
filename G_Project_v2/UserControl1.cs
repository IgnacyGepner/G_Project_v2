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

        }

        public void AddingEntiBtn(string name, string genere, Image image)
        {
            eBtn = new Button();
            list.Add(eBtn);
            flowLayoutPanel1.Controls.Add(eBtn);
            eBtn.Click += EBtn_Click;
            eBtn.Text = name;
            eBtn.Name = name;
            eBtn.Image = image;

            eBtn.Width = 150; eBtn.Height = 150;
            flowLayoutPanel1.Refresh();
            Entity entity = new Entity(name, genere, image);
            entiDict.Add(name, entity);
        }

        private void EBtn_Click(object? sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                string buttonName = clickedButton.Name;
                if (entiDict.TryGetValue(buttonName, out Entity entity))
                    MessageBox.Show(entity.GetGen());
            }
        }

            private void button1_Click(object sender, EventArgs e)
        {
            AddingEntiBtn(addingEnti1.textBoxName.Text, addingEnti1.textBox1.Text,addingEnti1.pictureBox1.Image);
            addingEnti1.Hide();
            button2.Show();
            button1.Hide();
            addingEnti1.textBox1.Text = "";
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
