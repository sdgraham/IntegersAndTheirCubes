namespace IntegersAndTheirCubes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";

            for (int i = 1; i <= 10; i++)
            {
                string strToJoin = "The cube of " + i + " is " + (i * i) + "\n";

                lblOutput.Text = lblOutput.Text + strToJoin;
            }
        }
    }
}