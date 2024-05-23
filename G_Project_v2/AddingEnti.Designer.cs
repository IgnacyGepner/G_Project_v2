namespace G_Project_v2
{
    partial class AddingEnti
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBoxName = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            genereCombo = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBoxELong = new TextBox();
            textBoxWh = new TextBox();
            label7 = new Label();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(84, 46);
            label1.TabIndex = 0;
            label1.Text = "Imie";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.Location = new Point(0, 46);
            label2.Name = "label2";
            label2.Size = new Size(145, 46);
            label2.TabIndex = 1;
            label2.Text = "Gatunek";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F);
            label3.Location = new Point(3, 92);
            label3.Name = "label3";
            label3.Size = new Size(251, 46);
            label3.TabIndex = 2;
            label3.Text = "Data Urodzenia";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F);
            label4.Location = new Point(0, 138);
            label4.Name = "label4";
            label4.Size = new Size(105, 46);
            label4.TabIndex = 3;
            label4.Text = "Waga";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F);
            label5.Location = new Point(3, 184);
            label5.Name = "label5";
            label5.Size = new Size(133, 46);
            label5.TabIndex = 4;
            label5.Text = "rozmiar";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(260, 17);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 5;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.Location = new Point(1448, 17);
            button1.Name = "button1";
            button1.Size = new Size(94, 64);
            button1.TabIndex = 7;
            button1.Text = "Dodaj zdjęcie";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(1116, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 300);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1116, 320);
            label6.Name = "label6";
            label6.Size = new Size(183, 20);
            label6.TabIndex = 9;
            label6.Text = "zdjęcie musi być 300x300*";
            // 
            // genereCombo
            // 
            genereCombo.FormattingEnabled = true;
            genereCombo.Location = new Point(260, 63);
            genereCombo.Name = "genereCombo";
            genereCombo.Size = new Size(151, 28);
            genereCombo.TabIndex = 10;
            genereCombo.SelectedIndexChanged += genereCombo_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(260, 107);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 11;
            // 
            // textBoxELong
            // 
            textBoxELong.Location = new Point(260, 203);
            textBoxELong.Name = "textBoxELong";
            textBoxELong.Size = new Size(125, 27);
            textBoxELong.TabIndex = 12;
            // 
            // textBoxWh
            // 
            textBoxWh.Location = new Point(260, 155);
            textBoxWh.Name = "textBoxWh";
            textBoxWh.Size = new Size(125, 27);
            textBoxWh.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F);
            label7.Location = new Point(417, 201);
            label7.Name = "label7";
            label7.Size = new Size(72, 46);
            label7.TabIndex = 14;
            label7.Text = "cm.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20F);
            label8.Location = new Point(417, 155);
            label8.Name = "label8";
            label8.Size = new Size(47, 46);
            label8.TabIndex = 15;
            label8.Text = "g.";
            // 
            // AddingEnti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBoxWh);
            Controls.Add(textBoxELong);
            Controls.Add(dateTimePicker1);
            Controls.Add(genereCombo);
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBoxName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddingEnti";
            Size = new Size(1542, 933);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        public TextBox textBoxName;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        public PictureBox pictureBox1;
        private Label label6;
        public TextBox textBoxELong;
        public TextBox textBoxWh;
        private Label label7;
        private Label label8;
        public ComboBox genereCombo;
        public DateTimePicker dateTimePicker1;
    }
}
