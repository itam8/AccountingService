using AccountingService.config;
using AccountingService.context;
using AccountingService.helper;
using AccountingService.model;
using AccountingService.repository;
using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace AccountingService
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            var login = loginTextBox.Text;
            var password = passwordTextBox.Text;

            if (login == "" || password == "")
                return;

            var passwordHash = PasswordHelper.GenerateHash(password);
            var user = UserRepository.FindByLogin(login);

            if (user != null && user.Password == passwordHash)
            {
                ControllerContext.User = user;

                if (user.Role == Role.ACCOUNTANT)
                    OpenForm(new AccountantForm());
                else
                    OpenForm(new EmployeeForm());
            }
            else
                MessageDisplayHelper.ShowMessage(errorLabel, "Неверный логин или пароль");
        }

        private void OpenForm(Form form)
        {
            Hide();
            form.ShowDialog(this);
            Close();
        }
    }
}
