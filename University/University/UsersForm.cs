using Microsoft.VisualBasic;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace University
{
    public partial class UsersForm : Form
    {
        private UserService _userService { get; set; }
        private string? _token { get; set; }
        private string? _currentUser { get; set; }
        private int _page { get; set; }
        private int _nextPage { get; set; }
        private int _prevPage { get; set; }
        public UsersForm()
        {
            InitializeComponent();
            _userService = new UserService();
        }

        private async Task OpenLogin()
        {
            using (var dialogForm = new LoginForm())
            {
                Enabled = false;
                if (dialogForm.ShowDialog() == DialogResult.OK)
                {
                    _token = dialogForm.Token;
                    _currentUser = dialogForm.Username;
                    _userService.Token = _token;
                    await LoadData();
                }
                Console.WriteLine(_token);
                Enabled = true;
            }
        }

        private async void войтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            await OpenLogin();
        }

        private void информацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Текущий пользователь: {_currentUser}\n" +
                            $"Текущий токен: {_token}");
        }

        private async Task LoadData()
        {
            try
            {
                dataGridView.Columns["Id"].AutoSizeMode =
               DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns["Username"].AutoSizeMode =
               DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns["FullName"].AutoSizeMode =
               DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns["Role"].AutoSizeMode =
               DataGridViewAutoSizeColumnMode.Fill;
                dataGridView.Columns["TokenAvailable"].AutoSizeMode =
               DataGridViewAutoSizeColumnMode.Fill;
                var list = await _userService.GetUsers(_page);
                if (list != null)
                {
                    if (list.Users!.Count == 0)
                    {
                        _page = 1;
                        list = await _userService.GetUsers(_page);
                    }
                    dataGridView.DataSource = list.Users;
                    _page = list.Page!.Value!;
                    _nextPage = list.NextPage!.Value;
                    _prevPage = list.PrevPage!.Value!;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK);
            }
        }

        private async void refreshButton_Click(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void UsersForm_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void prevButton_Click(object sender, EventArgs e)
        {
            _page = _prevPage;
            await LoadData();
        }

        private async void nextButton_Click(object sender, EventArgs e)
        {
            _page = _nextPage;
            await LoadData();
        }

        private async void revokeButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count != 0)
            {
                var selectedRow = dataGridView.SelectedRows[0];
                var value = selectedRow.Cells["Id"].Value!.ToString();
                await _userService.RevokeToken(int.Parse(value!));
                await LoadData();
            }
        }
    }
}
