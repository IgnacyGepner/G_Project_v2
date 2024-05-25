using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.Json;

namespace G_Project_v2
{
    public partial class UserControl1 : UserControl
    {
        //Deklaracje/////////////////////////////////////////////////////////////////
        private string save = "save.bin";
        string fileName = "entitySave.json";

        Entity entity;
        Dictionary<string, Entity> entiDict;
        Button eBtn;
        private List<Button> buttons;
        //początek programu///////////////////////////////////////////////////////
        public UserControl1()
        {
            InitializeComponent();

            addingEnti1.Hide();
            button1.Hide();
            entInfo1.Hide();

            entiDict = new Dictionary<string, Entity>();
            buttons = new List<Button>();

            LoadButtonsState();
        }

//Właściwości nowego przycisku i entity/////////////////////////////////////////////////////////
        public void AddingEntiBtn(string name, string genere, Image image, int wh, int eLong, DateTime born)
        {
            eBtn = new Button();
            flowLayoutPanel1.Controls.Add(eBtn);

            eBtn.Click += EBtn_Click;
            eBtn.Text = name;
            eBtn.Name = name;

            eBtn.BackgroundImage = image;
            eBtn.BackgroundImageLayout = ImageLayout.Stretch;
            eBtn.FlatStyle = FlatStyle.Flat; // Usuń standardowe obramowanie
            eBtn.FlatAppearance.BorderSize = 0; // Wyłącz obramowanie
            eBtn.Size = new Size(image.Width + 5, image.Height + 5);

            eBtn.Width = 150; eBtn.Height = 150;

            entity = new Entity(name, genere, image, wh, eLong, born);
            entiDict.Add(name, entity);
            buttons.Add(eBtn);
            SaveButtonsState();


        }
        
        //////////////metoda click nowego przycisku////////////////////////////

        private void EBtn_Click(object? sender, EventArgs e)
        {
            MessageBox.Show("Click");
            if (sender is Button clickedButton)
            {
                entInfo1.Show();
                string buttonName = clickedButton.Name;
                if (entiDict.TryGetValue(buttonName, out Entity entity))
                    EntInfoShow();

            }
        }
        /// //////////////////////////wywitlanie informacji o entiti
        private void EntInfoShow()
        {
            entInfo1.labName.Text = "imie: " + entity.GetName();
            entInfo1.labGen.Text = "Gatunek: " + entity.GetGen();
            entInfo1.labWh.Text = "Waga: " + entity.getWh();
            entInfo1.labElong.Text = "Rozmiar: " + entity.GetLong();
            entInfo1.labBorn.Text = "Data urodzenia: " + (entity.GetBorn()).ToString("dd.MM.yyyy");
        }

        ////////////////////Dodawanie wpisanych informacji o entiti

        private void button1_Click(object sender, EventArgs e)
        {
            AddingEntiBtn(addingEnti1.textBoxName.Text, addingEnti1.textBoxELong.Text, addingEnti1.pictureBox1.Image,int.Parse(addingEnti1.textBoxWh.Text), int.Parse(addingEnti1.textBoxELong.Text), addingEnti1.dateTimePicker1.Value); ;
            addingEnti1.Hide();
            button2.Show();
            button1.Hide();
            addingEnti1.textBoxELong.Text = "";
            addingEnti1.textBoxName.Text = "";

        }
       
        ///////////////wyświetlanie dodawania entiti

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Show();
            button2.Hide();
            addingEnti1.Show();
        }
        //serializacja przycisków/////////////////////
        private void SaveButtonsState()
        {

            var buttonsState = flowLayoutPanel1.Controls
                .OfType<Button>()
                .Select(button => new ButtonState
                {
                    Text = button.Text,
                    Width = button.Width,
                    Height = button.Height,
                    Name = button.Name,
                }).ToList();

            string json = JsonSerializer.Serialize(buttonsState);

            File.WriteAllText("buttonsState.json", json);
        }
        //deserializacja przycisków
    
        private void LoadButtonsState()
        {
            if (File.Exists("buttonsState.json"))
            {
                string json = File.ReadAllText("buttonsState.json");
                var buttonsState = JsonSerializer.Deserialize<List<ButtonState>>(json);

                foreach (var buttonState in buttonsState)
                {
                    Button newButton = new Button
                    {
                        Text = buttonState.Text,
                        Size = new Size(buttonState.Width, buttonState.Height),
                        Name = buttonState.Name,

                        // Ustaw inne właściwości zgodnie z zapisanym stanem
                    };
                    newButton.Click += EBtn_Click;
                    flowLayoutPanel1.Controls.Add(newButton);
                }

            }
        }
//właściości nowych przycisków po załadowaniu
        public class ButtonState
        {
            public string Text { get; set; }
            public int Width { get; set; }
            public int Height { get; set; }

            public string Name { get; set; }

            // Możesz dodać więcej właściwości, które chcesz zapisać
        }
    }
}
