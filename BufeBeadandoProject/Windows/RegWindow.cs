using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BufeBeadandoProject
{
    public partial class RegWindow : Form
    {
        public RegWindow()
        {
            InitializeComponent();
            TB_RegPW.UseSystemPasswordChar = true;
            TB_RegPW2.UseSystemPasswordChar = true;
        }

        private List<User> UserDatas = new List<User>();
        private void Reader(string filename)
        {
            StreamReader sr = new StreamReader(filename);
            while (!sr.EndOfStream)
            {
                User newUser = new User();
                string line = sr.ReadLine();
                string[] lines = line.Split(';');
                newUser.Username = lines[0];
                newUser.Password = lines[1];
                UserDatas.Add(newUser);
            }
            sr.Close();
        }

        private static RegWindow instance;

        public static RegWindow Instance
        {
            get
            {
                if (instance == null)
                    instance = new RegWindow();
                return instance;
            }

        }

        private void BTN_RegUser_Click(object sender, EventArgs e)
        {
            UserLoginWindow userLoginWindow = new UserLoginWindow();
            userLoginWindow.FormClosed += (s, args) => this.Show();
            userLoginWindow.Show();
            this.Hide();
        }

        private void BTN_RegExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_RegShowAndHidePW_Click(object sender, EventArgs e)
        {
            if (TB_RegPW.UseSystemPasswordChar)
                TB_RegPW.UseSystemPasswordChar = false;

            else
                TB_RegPW.UseSystemPasswordChar = true;
        }

        private void BTN_RegShowAndHidePW2_Click(object sender, EventArgs e)
        {
            if (TB_RegPW2.UseSystemPasswordChar)
                TB_RegPW2.UseSystemPasswordChar = false;

            else
                TB_RegPW2.UseSystemPasswordChar = true;
        }

        private void BTN_RegCreate_Click(object sender, EventArgs e)
        {
            LB_ErrorMessage.Text = "";
            string UserName = TB_RegName.Text;
            string Password1 = TB_RegPW.Text;
            string Password2 = TB_RegPW2.Text;
            string Email = TB_RegEmail.Text;

            ValidateUsername(UserName);

            if (ValidateUsername(UserName) && ValidatePassword(Password1, Password2) && ValidateEmail(Email))
            {
                string csvLine = $"{UserName};{Password2}\n";
                string filePath = "./Users.csv";

                try
                {
                    File.AppendAllText(filePath, csvLine);
                    LB_ErrorMessage.Text = "Adatok sikeresen elmentve.";
                    LB_ErrorMessage.ForeColor = System.Drawing.Color.Green;

                    LogForReg logForReg = new LogForReg();
                    logForReg.Log("Információ", TB_RegName.Text);
                }
                catch (Exception ex)
                {
                    LB_ErrorMessage.Text = $"Sikertelen mentés: {ex.Message}";
                    LB_ErrorMessage.ForeColor = System.Drawing.Color.Red;
                }
            }
        }

        private bool ValidateUsername(string UserName)
        {
            Reader("./Users.csv");
            foreach (User user in UserDatas)
            {
                if (user.Username == UserName)
                {
                    LB_ErrorMessage.Text = "Már ilyen felhasználónévvel van regisztrálva felhasználó!";
                    LB_ErrorMessage.ForeColor = System.Drawing.Color.Red;
                    return false;
                }
            }

            if (UserName.Length < 5)
            {
                LB_ErrorMessage.Text = "Nem megfelelő hosszúságú felhasználónév!";
                LB_ErrorMessage.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            return true;
        }

        private bool ValidatePassword(string Password1, string Password2)
        {
            if (Password1.Length < 5 || Password2.Length < 5)
            {
                LB_ErrorMessage.Text = "Nem megfelelő hosszúságú jelszó!";
                LB_ErrorMessage.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            if (Password1 != Password2)
            {
                LB_ErrorMessage.Text = "Nem egyező jelszó!";
                LB_ErrorMessage.ForeColor = System.Drawing.Color.Red;
                return false;
            }
            return true;
        }

        private bool ValidateEmail(string Email)
        {
            if (Email.Length < 5)
            {
                LB_ErrorMessage.Text = "Nem megfelelő hosszúságú email cím!";
                LB_ErrorMessage.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            if (!(Email.Contains('@') && Email.Contains('.')))
            {
                LB_ErrorMessage.Text = "Nem megfelelő email!";
                LB_ErrorMessage.ForeColor = System.Drawing.Color.Red;
                return false;
            }

            return true;
        }

    }
    
}
