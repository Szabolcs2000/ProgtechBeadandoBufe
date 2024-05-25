using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BufeBeadandoProject
{
    public partial class FoodOrderWindow : Form, ICHBAndCBEvenetSubsricbe
    {
        private void SetDefaultFlavor()
        {
            CB_Monday.SelectedIndex = 0;
            CB_Tuesday.SelectedIndex = 0;
            CB_Wednesday.SelectedIndex = 0;
            CB_Thursday.SelectedIndex = 0;
            CB_Friday.SelectedIndex = 0;
        }

        public void CHBAndCBEvenetSubsricbe()
        {
            CHB_MondayMenu.CheckedChanged += ActualPrice;
            CHB_MondayDessert.CheckedChanged += ActualPrice;
            CHB_TuesdayMenu.CheckedChanged += ActualPrice;
            CHB_TuesdayDessert.CheckedChanged += ActualPrice;
            CHB_WednesdayMenu.CheckedChanged += ActualPrice;
            CHB_WednesdayDessert.CheckedChanged += ActualPrice;
            CHB_ThursdayMenu.CheckedChanged += ActualPrice;
            CHB_ThursdayDessert.CheckedChanged += ActualPrice;
            CHB_FridayMenu.CheckedChanged += ActualPrice;
            CHB_FridayDessert.CheckedChanged += ActualPrice;
            CB_Monday.SelectedIndexChanged += ActualPrice;
            CB_Tuesday.SelectedIndexChanged += ActualPrice;
            CB_Wednesday.SelectedIndexChanged += ActualPrice;
            CB_Thursday.SelectedIndexChanged += ActualPrice;
            CB_Friday.SelectedIndexChanged += ActualPrice;
        }

        #region
        private string[] flavorings = new string[4] { "Nem kérek", "Só (+50 Ft)", "Bors (+60 Ft)", "Mindkettő (+100 Ft)" };
        private int menuCounter = 0;
        private int dessertCounter = 0;
        private int noFlavorCounter = 0;
        private int onlySaltCounter = 0;
        private int onlyPepperCounter = 0;
        private int bothFlavorCounter = 0;
        #endregion

        private void EnableCBS()
        {       
                CB_Monday.Enabled = CHB_MondayMenu.Checked;
                CB_Tuesday.Enabled = CHB_TuesdayMenu.Checked;
                CB_Wednesday.Enabled = CHB_WednesdayMenu.Checked;
                CB_Thursday.Enabled = CHB_ThursdayMenu.Checked;
                CB_Friday.Enabled = CHB_FridayMenu.Checked;
        }

        private void CHBAndCBCounter(object sender, EventArgs e)
        {
            menuCounter = 0;
            dessertCounter = 0;
            noFlavorCounter = 0;
            onlySaltCounter = 0;
            onlyPepperCounter = 0;
            bothFlavorCounter = 0;

            menuCounter = Controls.OfType<CheckBox>()
                           .Where(cb => cb.Name.Contains("Menu"))
                           .Count(cb => cb.Checked);

            dessertCounter = Controls.OfType<CheckBox>()
                           .Where(cb => cb.Name.Contains("Dessert"))
                           .Count(cb => cb.Checked);

            foreach (ComboBox comboBox in Controls.OfType<ComboBox>())
            {
                if (comboBox.SelectedItem.ToString().Contains("Nem kérek"))
                    noFlavorCounter++;

                else if (comboBox.SelectedItem.ToString().Contains("Só (+50 Ft)"))
                    onlySaltCounter++;

                else if (comboBox.SelectedItem.ToString().Contains("Bors (+60 Ft)"))
                    onlyPepperCounter++;

                else
                    bothFlavorCounter++;
            }
        }

        public FoodOrderWindow()
        {
            InitializeComponent();
            for (int i = 0; i < flavorings.Length; i++)
            {
                CB_Monday.Items.Add(flavorings[i]);
                CB_Tuesday.Items.Add(flavorings[i]);
                CB_Wednesday.Items.Add(flavorings[i]);
                CB_Thursday.Items.Add(flavorings[i]);
                CB_Friday.Items.Add(flavorings[i]);
            }
            SetDefaultFlavor();
            CHBAndCBEvenetSubsricbe();
        }

        private static FoodOrderWindow instance;

        public static FoodOrderWindow Instance
        {
            get
            {
                if (instance == null)
                    instance = new FoodOrderWindow();
                return instance;
            }

        }

        private void ActualPrice(object sender, EventArgs e)
        {
            CHBAndCBCounter(sender, e);
            EnableCBS();
            int priceSummary = 0;

            if (menuCounter >= 1 || dessertCounter >= 1)
            {             
                IExtra menu = new SimpleMenu();
                IExtra desszert = new DessertDecorator(menu);
                IExtra salt = new SaltDecorator(menu);
                IExtra pepper = new PepperDecorator(menu);

                priceSummary = menu.Cost() * menuCounter + desszert.Cost() * dessertCounter +
                                   salt.Cost() * onlySaltCounter + pepper.Cost() * onlyPepperCounter +
                                   (salt.Cost() + pepper.Cost() - 10) * bothFlavorCounter;

                TB_ActualPrice.Text = priceSummary.ToString();
            }

            else
            {
                TB_ActualPrice.Text = "0";
            }

        }

        private void BTN_Payment_Click(object sender, EventArgs e)
        {
            AboutPaymentWindow aboutPaymentWindow = new AboutPaymentWindow();
            aboutPaymentWindow.FormClosed += (s, args) => this.Show();
            aboutPaymentWindow.Show();
            this.Hide();
        }

        private void BTN_FoodOrdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
