namespace G_Project_v2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            MenuBtn = new GroupBox();
            MojeZwierzeta = new UserControl1();
            katalog1 = new Katalog();
            about1 = new About();
            MenuBtn.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 26);
            button1.Name = "button1";
            button1.Size = new Size(232, 29);
            button1.TabIndex = 1;
            button1.Text = "Moje Zwierzęta";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 126);
            button2.Name = "button2";
            button2.Size = new Size(232, 29);
            button2.TabIndex = 2;
            button2.Text = "Katalog Zwierząt";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 226);
            button3.Name = "button3";
            button3.Size = new Size(232, 29);
            button3.TabIndex = 3;
            button3.Text = "O Aplikacji";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 960);
            button4.Name = "button4";
            button4.Size = new Size(232, 29);
            button4.TabIndex = 4;
            button4.Text = "Wyjście";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // MenuBtn
            // 
            MenuBtn.Controls.Add(button4);
            MenuBtn.Controls.Add(button3);
            MenuBtn.Controls.Add(button2);
            MenuBtn.Controls.Add(button1);
            MenuBtn.Dock = DockStyle.Left;
            MenuBtn.Location = new Point(0, 0);
            MenuBtn.Name = "MenuBtn";
            MenuBtn.Size = new Size(256, 1033);
            MenuBtn.TabIndex = 0;
            MenuBtn.TabStop = false;
            MenuBtn.Text = "groupBox1";
            // 
            // MojeZwierzeta
            // 
            MojeZwierzeta.BackColor = Color.FromArgb(128, 255, 128);
            MojeZwierzeta.Location = new Point(302, 26);
            MojeZwierzeta.Name = "MojeZwierzeta";
            MojeZwierzeta.Size = new Size(1542, 933);
            MojeZwierzeta.TabIndex = 1;
            // 
            // katalog1
            // 
            katalog1.Location = new Point(302, 26);
            katalog1.Name = "katalog1";
            katalog1.Size = new Size(1542, 933);
            katalog1.TabIndex = 2;
            // 
            // about1
            // 
            about1.Location = new Point(302, 26);
            about1.Name = "about1";
            about1.Size = new Size(1542, 933);
            about1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1902, 1033);
            Controls.Add(about1);
            Controls.Add(katalog1);
            Controls.Add(MojeZwierzeta);
            Controls.Add(MenuBtn);
            Name = "Form1";
            Text = "Form1";
            MenuBtn.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox MenuBtn;
        private UserControl1 MojeZwierzeta;
        private Katalog katalog1;
        private About about1;
    }
}
