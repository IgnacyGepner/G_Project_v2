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
            textBox1 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label6 = new Label();
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
            textBoxName.Location = new Point(120, 17);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(125, 27);
            textBoxName.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(151, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
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
            // AddingEnti
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label6);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(textBox1);
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
        public TextBox textBox1;
        private OpenFileDialog openFileDialog1;
        private Button button1;
        public PictureBox pictureBox1;
        private Label label6;
    }
}
