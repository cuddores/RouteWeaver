using Guna.UI2.WinForms;
using RouteWeaver.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RouteWeaver.AppForms
{
    public partial class RegistrationForm : Form
    {
        private bool IsSign = true;

        public RegistrationForm()
        {
            InitializeComponent();
           
        }

        private void SignUp_Btn_Click(object sender, EventArgs e)
        {
            IsSign = true;
            Enter_Btn.Text = "Войти";
            SignUp_Btn.FillColor = Color.FromArgb(147, 166, 255);
            SignUp_Btn.ForeColor = Color.FromArgb(255, 255, 255);
            Registration_Btn.FillColor = Color.FromArgb(215, 223, 252);
            Registration_Btn.ForeColor = Color.FromArgb(87, 115, 232);
            FIO_Label.Visible = false;
            FIO_TextBox.Visible = false;
            Email_Label.Visible = false;
            Email_TextBox.Visible = false;
            ClearFields();
        }

        private void Registration_Btn_Click(object sender, EventArgs e)
        {
            IsSign = false;
            Enter_Btn.Text = "Зарегистрироваться";
            Registration_Btn.FillColor = Color.FromArgb(147, 166, 255);
            Registration_Btn.ForeColor = Color.FromArgb(255, 255, 255);
            SignUp_Btn.FillColor = Color.FromArgb(215, 223, 252);
            SignUp_Btn.ForeColor = Color.FromArgb(87, 115, 232);
            FIO_Label.Visible = true;
            FIO_TextBox.Visible = true;
            Email_Label.Visible = true;
            Email_TextBox.Visible = true;
            ClearFields();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            SignUp_Btn.FillColor = Color.FromArgb(147, 166, 255);
            SignUp_Btn.ForeColor = Color.FromArgb(255, 255, 255);
            Registration_Btn.FillColor = Color.FromArgb(215, 223, 252);
            Registration_Btn.ForeColor = Color.FromArgb(87, 115, 232);
            FIO_Label.Visible = false;
            FIO_TextBox.Visible = false;
            ClearFields();

            // Подписываемся на нажатие Enter в текстовых полях
            Login_TextBox.KeyDown += TextBox_KeyDown;
            Password_TextBox.KeyDown += TextBox_KeyDown;
            FIO_TextBox.KeyDown += TextBox_KeyDown;

            Password_TextBox.UseSystemPasswordChar = true;
        }

        /// <summary>
        /// Очищает все поля ввода
        /// </summary>
        private void ClearFields()
        {
            Login_TextBox.Clear();
            Password_TextBox.Clear();
            FIO_TextBox.Clear();
            Email_TextBox.Clear();
        }

        private void Enter_Btn_Click(object sender, EventArgs e)
        {
            string logintext = Login_TextBox.Text.Trim();
            string passwordtext = Password_TextBox.Text;
            string fio = FIO_TextBox.Text.Trim();
            string email = Email_TextBox.Text.Trim();

            if (Validation())
            {
                try
                {
                    if (IsSign)
                    {
                        //Логика входа
                        var user = Program.context.Users.FirstOrDefault(u => u.login == logintext && u.password == passwordtext);

                        if (user != null)
                        {
                            OpenMainForm(user);
                        }
                        else
                        {
                            MessageBox.Show("Неверный логин или пароль", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {

                        // Проверка: существует ли пользователь с таким логином
                        bool userExists = Program.context.Users.Any(u => u.login == logintext);

                        if (userExists)
                        {
                            MessageBox.Show("Пользователь с таким логином уже существет", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Login_TextBox.Focus();
                            return;
                        }

                        // Создаём нового пользователя
                        var newUser = new Users();
                        newUser.login = logintext;
                        newUser.password = passwordtext;
                        newUser.user_name = fio;
                        newUser.created_date = DateTime.Now;
                        newUser.email = email;
                        newUser.user_role_id = 1;

                        Program.context.Users.Add(newUser);
                        Program.context.SaveChanges();

                        MessageBox.Show("Регистрация успешна!", "Успех",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        OpenMainForm(newUser);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        /// <summary>
        /// Обработка нажатия Enter в полях ввода
        /// </summary>
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Enter_Btn.PerformClick();
            }
        }

        /// <summary>
        /// Открывает MainForm и закрывает текущую форму
        /// </summary>
        private void OpenMainForm(Users user)
        {
            MainForm mainform = this.Owner as MainForm;
            mainform.SetCurrentUser(user); 

            ClearFields();
            this.Close();
            mainform.Show();
        }

        private bool Validation()
        {
            string logintext = Login_TextBox.Text.Trim();
            string passwordtext = Password_TextBox.Text;
            string fio = FIO_TextBox.Text.Trim();

            //Валидация
            if (Login_TextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите логин", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Login_TextBox.Focus();
                return false;
            }

            if (Password_TextBox.Text.Trim().Length < 8)
            {
                MessageBox.Show("Введите пароль (более 8 символов)", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Password_TextBox.Focus();
                return false;
            }

            if (!IsSign && FIO_TextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Введите имя и фамилию", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                FIO_TextBox.Focus();
                return false;
            }

            if (Login_TextBox.Text.Trim().Length == 0 && Password_TextBox.Text.Trim().Length == 0 &&  FIO_TextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Необходимо заполнить все поля", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainForm mainForm = this.Owner as MainForm;
            mainForm.Show();
        }
    }
}
