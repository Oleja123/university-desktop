using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace University
{
    public partial class SessionsForm : Form
    {
        private UserService _userService { get; set; }
        private string _token { get; set; }
        private string _currentUser { get; set; }
        private int _userId { get; set; }
        public SessionsForm(UserService userService, int userId, string token, string currentUser)
        {
            InitializeComponent();
            _userService = userService;
            _token = token;
            _currentUser = currentUser;
            _userId = userId;
            usernameTextBox.Text = _currentUser;
        }

        private async Task LoadData()
        {
            try
            {
                var list = await _userService.GetUserSessions(_userId);
                if (list != null)
                {
                    DataTable table = new DataTable();
                    table.Columns.Add("Id сессии", typeof(string));

                    foreach (var str in list)
                    {
                        table.Rows.Add(str);
                    }
                    dataGridView.DataSource = table;
                    dataGridView.AllowUserToAddRows = false;
                    dataGridView.Columns["Id сессии"].AutoSizeMode =
               DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private async void SessionsForm_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void refreshButton_Click(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void closeSessionsButton_Click(object sender, EventArgs e)
        {
            try
            {
                await _userService.CloseSessions(_userId);
                await LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private async void closeSessionButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                try
                {
                    var selectedRow = dataGridView.SelectedRows[0];
                    var value = selectedRow.Cells["Id сессии"].Value!.ToString();
                    await _userService.CloseSession(_userId, value!);
                    await LoadData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Неизвестая ошибка");
                }
            }
        }
    }
}
