using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BufeBeadandoProject
{
    public partial class UserLoginWindow : Form
    {
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


        public UserLoginWindow()
        {            
            InitializeComponent();
            TB_UserPW.UseSystemPasswordChar = true;
        }

        private static UserLoginWindow instance;

        public static UserLoginWindow Instance
        {
            get
            {
                if (instance == null)
                    instance = new UserLoginWindow();
                return instance;
            }

        }

        private void BTN_Reg_Click(object sender, EventArgs e)
        {
            RegWindow regWindow = new RegWindow();
            regWindow.FormClosed += (s, args) => this.Show();
            regWindow.Show();
            this.Hide();
        }

        private void BTN_Admin_Click(object sender, EventArgs e)
        {
            AdminLoginWindow adminLoginWindow = new AdminLoginWindow();
            adminLoginWindow.FormClosed += (s, args) => this.Show();
            adminLoginWindow.Show();
            this.Hide();
        }        

        private void BTN_UserExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_UserLogin_Click(object sender, EventArgs e)
        {
            Reader("./Users.csv");
            foreach (User user in UserDatas)
            {
                if (TB_UserName.Text == user.Username && TB_UserPW.Text == user.Password)
                {
                    FoodOrderWindow foodOrderWindow = new FoodOrderWindow();
                    foodOrderWindow.FormClosed += (s, args) => this.Show();
                    foodOrderWindow.Show();
                    this.Hide();
                    break;
                }

                else
                {
                    LB_UserErrorMessage.Text = "Hibás felhasználónév vagy jelszó!";
                }                    
            }
        }

        private void BTN_UserShowAndHidePW_Click(object sender, EventArgs e)
        {
            if (TB_UserPW.UseSystemPasswordChar)
                TB_UserPW.UseSystemPasswordChar = false;

            else
                TB_UserPW.UseSystemPasswordChar = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Menu menu = new Menu();
            menu.FormClosed += (s, args) => this.Show();
            menu.Show();
            this.Hide();
        }
    }
}
