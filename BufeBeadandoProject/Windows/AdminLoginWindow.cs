using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BufeBeadandoProject
{
    public partial class AdminLoginWindow : Form
    {
       
        public AdminLoginWindow(){
            InitializeComponent();
            LB_ErrorMessage.Text = "";
            TB_AdminPW.UseSystemPasswordChar = true;
        }

        private static AdminLoginWindow instance;

        public static AdminLoginWindow Instance
        {
            get
            {
                if (instance == null)
                    instance = new AdminLoginWindow();
                return instance;
            }

        }

        private void BTN_User_Click(object sender, EventArgs e)
        {
            UserLoginWindow userLoginWindow = new UserLoginWindow();
            userLoginWindow.FormClosed += (s, args) => this.Show();
            userLoginWindow.Show();
            this.Hide();
        }

        private void BTN_AdminExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTN_AdminLogin_Click(object sender, EventArgs e)
        {
            if (TB_AdminName.Text == "Admin" && TB_AdminPW.Text == "1234")
            {
                AdminFoodEditWindow adminFoodEditWindow = new AdminFoodEditWindow();
                adminFoodEditWindow.FormClosed += (s, args) => this.Show();
                adminFoodEditWindow.Show();
                this.Hide();
                LogForAdminLogin logForAdminLogin = new LogForAdminLogin();
                logForAdminLogin.Log("Információ", TB_AdminName.Text);
            }
                
            else
            {
                LB_ErrorMessage.Text = "Hibás felhaszálónév vagy jelszó!";
            }
        }

        private void BTN_AdminShowAndHidePW_Click(object sender, EventArgs e)
        {
            if (TB_AdminPW.UseSystemPasswordChar)
                TB_AdminPW.UseSystemPasswordChar = false;

            else
                TB_AdminPW.UseSystemPasswordChar = true;
        }
    }
}
