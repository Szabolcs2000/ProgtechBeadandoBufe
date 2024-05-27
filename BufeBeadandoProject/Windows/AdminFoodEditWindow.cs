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
    public partial class AdminFoodEditWindow : Form
    {
        public AdminFoodEditWindow()
        {
            InitializeComponent();
        }

        private static AdminFoodEditWindow instance;

        public static AdminFoodEditWindow Instance
        {
            get
            {
                if (Instance == null)
                    instance = new AdminFoodEditWindow();
                return instance;
            }

        }

        private void BTN_FoodEditExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
