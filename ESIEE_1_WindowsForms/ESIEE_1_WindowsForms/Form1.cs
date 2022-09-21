namespace ESIEE_1_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void buttonVider_Click(object sender, EventArgs e)
        {
            this.textBoxNom.Clear();
            this.textBoxPrenom.Clear();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            string client = this.textBoxNom.Text + " " + this.textBoxPrenom.Text;
            this.listView1.Items.Add(client);
        }
    }
}