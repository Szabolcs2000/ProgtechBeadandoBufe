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
    public partial class AboutPaymentWindow : Form
    {
        public AboutPaymentWindow()
        {
            InitializeComponent();
        }

        private static AboutPaymentWindow instance;

        public static AboutPaymentWindow Instance
        {
            get
            {
                if (Instance == null)
                    instance = new AboutPaymentWindow();
                return instance;
            }

        }

        private void BTN_AboutPaymentExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
