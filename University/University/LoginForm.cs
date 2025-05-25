using Services;

namespace University
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _authService;
        public LoginForm()
        {
            InitializeComponent();
            _authService = new AuthService();
        }

        private async void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                var username = usernameTextBox.Text;
                var password = passwordTextBox.Text;
                var token = await _authService.Login(username, password);
                MessageBox.Show("Вы авторизованы");
                UsersForm usersForm = new UsersForm(token);
                usersForm.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
