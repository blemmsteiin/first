namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        bool[,] mayin = new bool[10, 10];

        public Form1()
        {
            InitializeComponent();
        }
        int say = 0;
        void mayinla()
        {
            Random rnd = new Random();
            int mayinsayisi = 0;
            while (mayinsayisi < 10)
            {
                int satir = rnd.Next(10);
                int sutun = rnd.Next(10);
                if (mayin[satir, sutun] == false)
                {
                    mayin[satir, sutun] = true;
                    mayinsayisi++;
                }
            }
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button tiklananbutton = (Button)sender;

            Point konum = (Point)tiklananbutton.Tag;
            int satir = konum.X;
            int sutun = konum.Y;

            if (mayin[satir, sutun] == true)
            {
                tiklananbutton.BackColor = Color.Red;
                MessageBox.Show("mayına bastın!");
            }
            else
            {
                tiklananbutton.BackColor = Color.Gray;
                tiklananbutton.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            {
                listBox1.Items.Add("Tesla");
            }

            {
                System.Timers.Timer ts = new System.Timers.Timer();
                ts.Enabled = true;
                ts.Interval = 1000;
                ts.Start();
            }

            mayinla();

            int y = 100;

            for (int k = 0; k < 10; k++)
            {
                int x = 100;
                for (int i = 0; i < 10; i++)
                {
                    Button btn = new Button();

                    btn.Name = "btn_" + k + "_" + i;
                    btn.Text = "";
                    btn.Location = new Point(x, y);
                    btn.Size = new Size(40, 40);
                    btn.Tag = new Point(k, i);
                    this.Controls.Add(btn);
                    btn.Click += btn_Click;
                    x += 40;
                }
                y += 40;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = say.ToString();
            say++;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
            listBox2.Items.Remove(listBox2.SelectedItem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
            listBox2.Items.Add(textBox2.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2.Items.Clear();

            if (listBox1.SelectedItem != null)
            {
                string secilenMarka = listBox1.SelectedItem.ToString();

                if (secilenMarka == "Tesla")
                {
                    listBox2.Items.Add("Model S");
                    listBox2.Items.Add("Model 3");
                    listBox2.Items.Add("Model X");
                    listBox2.Items.Add("Model Y");
                }
                else if (secilenMarka == "BMW")
                {
                    listBox2.Items.Add("3 Serisi");
                    listBox2.Items.Add("5 Serisi");
                    listBox2.Items.Add("X Serisi");
                }
                else if (secilenMarka == "Mercedes")
                {
                    listBox2.Items.Add("C Serisi");
                    listBox2.Items.Add("E Serisi");
                    listBox2.Items.Add("S Serisi");
                }
                else if (secilenMarka == "Fiat")
                {
                    listBox2.Items.Add("Punto");
                    listBox2.Items.Add("Linea");
                    listBox2.Items.Add("Egea");
                }
                else if (secilenMarka == "Ford")
                {
                    listBox2.Items.Add("Focus");
                    listBox2.Items.Add("Fiesta");
                    listBox2.Items.Add("Kuga");
                }
                else if (secilenMarka == "Hyundai")
                {
                    listBox2.Items.Add("Accent");
                    listBox2.Items.Add("ix35");
                    listBox2.Items.Add("Bayon");
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.AddRange(listBox1.Items);
            listBox1.Items.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Items.AddRange(listBox2.Items); 
            listBox2.Items.Clear();
        }
    }
}