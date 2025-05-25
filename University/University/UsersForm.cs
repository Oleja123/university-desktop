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
    public partial class UsersForm : Form
    {
        private readonly string _token;
        public UsersForm(string token)
        {
            InitializeComponent();
            _token = token;
        }
    }
}
