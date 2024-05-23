namespace G_Project_v2
{
    partial class UserControl1
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
            button1 = new Button();
            addingEnti1 = new AddingEnti();
            button2 = new Button();
            entInfo1 = new EntInfo();
            flowLayoutPanel1 = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 40F);
            label1.Location = new Point(36, 0);
            label1.Name = "label1";
            label1.Size = new Size(480, 89);
            label1.TabIndex = 0;
            label1.Text = "Moje zwierzęta";
            // 
            // button1
            // 
            button1.Location = new Point(1445, 850);
            button1.Name = "button1";
            button1.Size = new Size(94, 80);
            button1.TabIndex = 2;
            button1.Text = "Dodaj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // addingEnti1
            // 
            addingEnti1.Location = new Point(45, 92);
            addingEnti1.Name = "addingEnti1";
            addingEnti1.Size = new Size(1539, 752);
            addingEnti1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(1445, 850);
            button2.Name = "button2";
            button2.Size = new Size(94, 80);
            button2.TabIndex = 4;
            button2.Text = "Utwórz";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // entInfo1
            // 
            entInfo1.Location = new Point(45, 92);
            entInfo1.Name = "entInfo1";
            entInfo1.Size = new Size(1928, 1166);
            entInfo1.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(356, 92);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1163, 738);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 128);
            Controls.Add(entInfo1);
            Controls.Add(addingEnti1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(label1);
            Name = "UserControl1";
            Size = new Size(1542, 933);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private AddingEnti addingEnti1;
        private Button button2;
        private EntInfo entInfo1;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
