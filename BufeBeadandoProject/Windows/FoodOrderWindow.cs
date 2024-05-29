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
    public partial class FoodOrderWindow : Form, ICHBAndCBEvenetSubsricbe
    {
        private void ShowSoupsForUser()
        {
            int soupIndex = 0;           

            do
            {
                randomNumberForSoup = rnd.Next(0, newMenu.GetSoups().Count);       

                if (!indexesForSoups.Contains(randomNumberForSoup))
                {
                    indexesForSoups[soupIndex] = randomNumberForSoup;
                    soupIndex++;
                }
            } while (soupIndex < 5);                  

            TB_MondaySoup.Text = newMenu.GetSoups()[indexesForSoups[0]].ToString();
            TB_TuesdaySoup.Text = newMenu.GetSoups()[indexesForSoups[1]].ToString();
            TB_WednesdaySoup.Text = newMenu.GetSoups()[indexesForSoups[2]].ToString();
            TB_ThursdaySoup.Text = newMenu.GetSoups()[indexesForSoups[3]].ToString();         
            TB_FridaySoup.Text = newMenu.GetSoups()[indexesForSoups[4]].ToString();            
        }

        private void ShowEntreesForUser()
        {
            int entreeIndex = 0;

            do
            {
                randomNumberForEntree = rnd.Next(0, newMenu.GetEntrees().Count);        

                if (!indexesForEntrees.Contains(randomNumberForEntree))
                {
                    indexesForEntrees[entreeIndex] = randomNumberForEntree;
                    entreeIndex++;
                }               
            } while (entreeIndex < 5);

            TB_MondayMeal.Text = newMenu.GetEntrees()[indexesForEntrees[0]].ToString();
            TB_TuesdayMeal.Text = newMenu.GetEntrees()[indexesForEntrees[1]].ToString();
            TB_WednesdayMeal.Text = newMenu.GetEntrees()[indexesForEntrees[2]].ToString();
            TB_ThursdayMeal.Text = newMenu.GetEntrees()[indexesForEntrees[3]].ToString();
            TB_FridayMeal.Text = newMenu.GetEntrees()[indexesForEntrees[4]].ToString();           
        }

        private void ShowDessertsForUser()
        {
            int dessertIndex = 0;

            do
            {
                randomNumberForDessert = rnd.Next(0, newMenu.GetDesserts().Count);

                if (!indexesForDesserts.Contains(randomNumberForDessert))
                {
                    indexesForDesserts[dessertIndex] = randomNumberForDessert;
                    dessertIndex++;
                }
            } while (dessertIndex < 5);

            TB_MondayDessert.Text = newMenu.GetDesserts()[indexesForDesserts[0]].ToString();
            TB_TuesdayDessert.Text = newMenu.GetDesserts()[indexesForDesserts[1]].ToString();
            TB_WednesdayDessert.Text = newMenu.GetDesserts()[indexesForDesserts[2]].ToString();
            TB_ThursdayDessert.Text = newMenu.GetDesserts()[indexesForDesserts[3]].ToString();
            TB_FridayDessert.Text = newMenu.GetDesserts()[indexesForDesserts[4]].ToString();
        }

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
        private MenuWindow newMenu;
        private Random rnd;
        private int[] indexesForSoups = new int[5];
        private int[] indexesForEntrees = new int[5];
        private int[] indexesForDesserts = new int[5];
        private string[] flavorings = new string[4] { "Nem kérek", "Só (+50 Ft)", "Bors (+60 Ft)", "Mindkettő (+100 Ft)" };
        public int menuCounter;
        public int dessertCounter;
        public int onlySaltCounter;
        public int onlyPepperCounter;
        public int bothFlavorCounter;
        public int priceSummary;
        private int randomNumberForSoup;
        private int randomNumberForEntree;
        private int randomNumberForDessert;
        #endregion

        private void EnableCBS()
        {
            CB_Monday.Enabled = CHB_MondayMenu.Checked;
            CB_Tuesday.Enabled = CHB_TuesdayMenu.Checked;
            CB_Wednesday.Enabled = CHB_WednesdayMenu.Checked;
            CB_Thursday.Enabled = CHB_ThursdayMenu.Checked;
            CB_Friday.Enabled = CHB_FridayMenu.Checked;
        }

        public void CHBAndCBCounter()
        {
            menuCounter = 0;
            dessertCounter = 0;
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

                if (comboBox.SelectedItem.ToString().Contains("Só (+50 Ft)"))
                    onlySaltCounter++;

                else if (comboBox.SelectedItem.ToString().Contains("Bors (+60 Ft)"))
                    onlyPepperCounter++;

                else if (comboBox.SelectedItem.ToString().Contains("Mindkettő (+100 Ft)"))
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

            newMenu = new MenuWindow();
            rnd = new Random();

            ShowSoupsForUser();
            ShowEntreesForUser();
            ShowDessertsForUser();
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

        public void ActualPrice(object sender, EventArgs e)
        {
            CHBAndCBCounter();
            EnableCBS();
            priceSummary = 0;

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

        public void ActualPriceForUnitTest(int menuNum, int dessertNum, int saltNum, int pepperNum, int bothNum)
        {

            priceSummary = 0;

            this.menuCounter = menuNum;
            this.dessertCounter = dessertNum;
            this.onlySaltCounter = saltNum;
            this.onlyPepperCounter = pepperNum;
            this.bothFlavorCounter = bothNum;


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
            LogForPayment logForPayment = new LogForPayment();
            logForPayment.Log("Információ", "");
        }

        private void BTN_FoodOrdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
