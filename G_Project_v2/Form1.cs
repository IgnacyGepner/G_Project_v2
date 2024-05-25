namespace G_Project_v2
{
    public partial class Form1 : Form
    {
        UserControl1 userControl1 = new();
        int ControlChose = 1;
            public Form1()
        {
            InitializeComponent();
            ChangeControls();
            ShowControl();
            WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
        }

        void ChangeControls()
        {
            foreach (Button b in MenuBtn.Controls)
            {
                b.BackColor = Color.FromArgb(100, 200, 100);
                b.Width = 350;
                b.Height = 100;
                b.FlatStyle = FlatStyle.Flat;
                b.FlatAppearance.BorderSize = 0;
                b.Font = new Font(b.Font.FontFamily, 20);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ControlChose = 1;
            ShowControl();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ControlChose = 2;
            ShowControl();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            ControlChose = 3;
            ShowControl();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ShowControl()
        {
            MojeZwierzeta.Hide();
            katalog1.Hide();
            about1.Hide();

            switch (ControlChose)
            {

                case 1:
                    MojeZwierzeta.Show();
                    break;
                case 2:
                    katalog1.Show(); break;
                case 3:
                    about1.Show(); break;

            }

        }

    }
}
