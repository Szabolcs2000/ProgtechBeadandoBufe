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
    public partial class FoodOrderWindow : Form
    {
        public FoodOrderWindow()
        {
            InitializeComponent();
        }

        private void BTN_FoodOrderExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
