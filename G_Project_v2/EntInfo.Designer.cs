namespace G_Project_v2
{
    partial class EntInfo
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
            components = new System.ComponentModel.Container();
            labName = new Label();
            labGen = new Label();
            labBorn = new Label();
            labWh = new Label();
            labElong = new Label();
            button1 = new Button();
            entityBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)entityBindingSource).BeginInit();
            SuspendLayout();
            // 
            // labName
            // 
            labName.AutoSize = true;
            labName.Font = new Font("Segoe UI", 30F);
            labName.Location = new Point(0, 0);
            labName.Name = "labName";
            labName.Size = new Size(133, 67);
            labName.TabIndex = 0;
            labName.Text = "imie:";
            // 
            // labGen
            // 
            labGen.AutoSize = true;
            labGen.Font = new Font("Segoe UI", 30F);
            labGen.Location = new Point(0, 91);
            labGen.Name = "labGen";
            labGen.Size = new Size(212, 67);
            labGen.TabIndex = 1;
            labGen.Text = "Gatunek";
            // 
            // labBorn
            // 
            labBorn.AutoSize = true;
            labBorn.Font = new Font("Segoe UI", 30F);
            labBorn.Location = new Point(0, 188);
            labBorn.Name = "labBorn";
            labBorn.Size = new Size(160, 67);
            labBorn.TabIndex = 2;
            labBorn.Text = "label3";
            // 
            // labWh
            // 
            labWh.AutoSize = true;
            labWh.Font = new Font("Segoe UI", 30F);
            labWh.Location = new Point(0, 291);
            labWh.Name = "labWh";
            labWh.Size = new Size(160, 67);
            labWh.TabIndex = 3;
            labWh.Text = "label4";
            // 
            // labElong
            // 
            labElong.AutoSize = true;
            labElong.Font = new Font("Segoe UI", 30F);
            labElong.Location = new Point(0, 407);
            labElong.Name = "labElong";
            labElong.Size = new Size(160, 67);
            labElong.TabIndex = 4;
            labElong.Text = "label5";
            // 
            // button1
            // 
            button1.Location = new Point(952, 636);
            button1.Name = "button1";
            button1.Size = new Size(146, 46);
            button1.TabIndex = 5;
            button1.Text = "Powrót";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // entityBindingSource
            // 
            entityBindingSource.DataSource = typeof(Entity);
            // 
            // EntInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(labElong);
            Controls.Add(labWh);
            Controls.Add(labBorn);
            Controls.Add(labGen);
            Controls.Add(labName);
            Name = "EntInfo";
            Size = new Size(1542, 933);
            ((System.ComponentModel.ISupportInitialize)entityBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label4;
        private Label label5;
        public Label labName;
        public Label labGen;
        public Label labBorn;
        public Label labWh;
        public Label labElong;
        private Button button1;
        private BindingSource entityBindingSource;
    }
}
