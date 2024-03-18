namespace LoadScreen
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            if(i != 100)
            {
                i++;
            }else
            {
                Form2 form2 = new Form2();

                //Show form2
                form2.Show();

                //CLose Loadscreen
                this.Hide();

                //Timer stop
                timer1.Stop();
            }
        }
    }
}
