using Services;

namespace University
{
    public partial class LoginForm : Form
    {
        private readonly AuthService _authService;
        public string Token { get; private set; }
        public string Username { get; private set; }
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
                Token = token;
                Username = username;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
