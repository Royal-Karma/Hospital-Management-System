namespace Hospital_Management_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (admin.Text == "" && password.Text == " ")
            {
                MessageBox.Show("Missing Information");
            }
            else if(admin.Text == "Admin" && password.Text == "Password")
            {
                Home obj = new Home();
                obj.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Please Enter The Correct Username And Password");
            }
        }


        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            admin.Text = " ";
            password.Text = " ";
        }

        private void CrossBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
