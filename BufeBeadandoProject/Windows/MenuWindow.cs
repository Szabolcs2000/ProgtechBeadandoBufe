using BufeBeadandoProject.Factorys.Dessert_factorys;
using BufeBeadandoProject.Factorys.Entree_factorys;
using BufeBeadandoProject.Factorys.Soups;
using BufeBeadandoProject.Interfaces;
using BufeBeadandoProject.Interfaces.Desserts;
using BufeBeadandoProject.Interfaces.Entrees;
using BufeBeadandoProject.Soups;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BufeBeadandoProject
{
    public partial class MenuWindow : Form
    {
        private ISoupFactory soupFactory;
        private IEntreeFactory entreeFactory;
        private IDessertFactory dessertFactory;
        private List<ISoup> soups;
        private List<IEntree> entrees;
        private List<IDessert> desserts;

        public List<ISoup> GetSoups() { return soups; }
        public List<IEntree> GetEntrees() { return entrees; }
        public List<IDessert> GetDesserts() { return desserts; }

        public MenuWindow()
        {
            InitializeComponent();
            soups = new List<ISoup>();
            entrees = new List<IEntree>();
            desserts = new List<IDessert>();
            InitializeSoups();
            InitializeEntrees();
            InitializeDesserts();           
        }

        private static MenuWindow instance;

        public static MenuWindow Instance
        {
            get
            {
                if (instance == null)
                    instance = new MenuWindow();
                return instance;
            }

        }

        public void InitializeSoups()
        {
            soupFactory = new BeanSoupFactory();
            soups.Add(soupFactory.CreateSoup());

            soupFactory = new CabbageSoupFactory();
            soups.Add(soupFactory.CreateSoup());

            soupFactory = new CarrotCreamSoupFactory();
            soups.Add(soupFactory.CreateSoup());

            soupFactory = new CreamSoupFactory();
            soups.Add(soupFactory.CreateSoup());

            soupFactory = new GoulashSoupFactory();
            soups.Add(soupFactory.CreateSoup());

            soupFactory = new LentilSoupFactory();
            soups.Add(soupFactory.CreateSoup());

            soupFactory = new PeaSoupFactory();
            soups.Add(soupFactory.CreateSoup());

            soupFactory = new SpinachSoupFactory();
            soups.Add(soupFactory.CreateSoup());

            soupFactory = new TomatoSoupFactory();
            soups.Add(soupFactory.CreateSoup());

            soupFactory = new ZucchiniSoupFactory();
            soups.Add(soupFactory.CreateSoup());

        }

        public void InitializeEntrees()
        {
            entreeFactory = new BeefStewFactory();
            entrees.Add(entreeFactory.CreateEntree());

            entreeFactory = new BreadedChickenFactory();
            entrees.Add(entreeFactory.CreateEntree());

            entreeFactory = new ChickenPaprikashFactory();
            entrees.Add(entreeFactory.CreateEntree());

            entreeFactory = new HungarianRatatouilleFactory();
            entrees.Add(entreeFactory.CreateEntree());

            entreeFactory = new LayeredPotatoesFactory();
            entrees.Add(entreeFactory.CreateEntree());

            entreeFactory = new PorkAndSauerkrautStewFactory();
            entrees.Add(entreeFactory.CreateEntree());

            entreeFactory = new PorkStewFactory();
            entrees.Add(entreeFactory.CreateEntree());

            entreeFactory = new RoastedChickenFactory();
            entrees.Add(entreeFactory.CreateEntree());

            entreeFactory = new StuffedCabbageFactory();
            entrees.Add(entreeFactory.CreateEntree());

            entreeFactory = new StuffedPeppersFactory();
            entrees.Add(entreeFactory.CreateEntree());
        }

        public void InitializeDesserts()
        {
            dessertFactory = new AppleStrudelFactory();
            desserts.Add(dessertFactory.CreateDessert());

            dessertFactory = new DobosTorteFactory();
            desserts.Add(dessertFactory.CreateDessert());

            dessertFactory = new GerbeaudSliceFactory();
            desserts.Add(dessertFactory.CreateDessert());

            dessertFactory = new GoldenDumplingsFactory();
            desserts.Add(dessertFactory.CreateDessert());

            dessertFactory = new HoneyCakeFactory();
            desserts.Add(dessertFactory.CreateDessert());
        }

        private void btn_soups_Click(object sender, EventArgs e)
        {
            UpdateSoupListSoup();
            btn_soups.Enabled = false;
            btn_Entrees.Enabled = true;
            btn_desserts.Enabled = true;
        }

        private void btn_Entrees_Click(object sender, EventArgs e)
        {
            UpdateSoupListEntree();
            btn_Entrees.Enabled = false;
            btn_soups.Enabled = true;
            btn_desserts.Enabled = true;
        }

        private void btn_desserts_Click(object sender, EventArgs e)
        {
            UpdateSoupListDessert();
            btn_Entrees.Enabled = true;
            btn_soups.Enabled = true;
            btn_desserts.Enabled = false;
        }

        private void UpdateSoupListSoup()
        {
            listBox_result.Items.Clear();
            foreach (ISoup soup in soups)
            {
                listBox_result.Items.Add(soup.ToString());
            }
        }

        private void UpdateSoupListEntree()
        {
            listBox_result.Items.Clear();
            foreach (IEntree entree in entrees)
            {
                listBox_result.Items.Add(entree.ToString());
            }
        }

        private void UpdateSoupListDessert()
        {
            listBox_result.Items.Clear();
            foreach (IDessert dessert in desserts)
            {
                listBox_result.Items.Add(dessert.ToString());
            }
        }

        private void listBox_result_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_result.SelectedItem != null && !btn_soups.Enabled)
            {
                lbl_inf_result.Text = "Neve: " + listBox_result.SelectedItem.ToString() + "\n";
                lbl_inf_result.Text += "Ára: 1500 Ft";
            }
            
            else if (listBox_result.SelectedItem != null && !btn_Entrees.Enabled)
            {
                lbl_inf_result.Text = "Neve: " + listBox_result.SelectedItem.ToString() + "\n";
                lbl_inf_result.Text += "Ára: 1800 Ft";
            }
            
            else if (listBox_result.SelectedItem != null && !btn_desserts.Enabled)
            {
                lbl_inf_result.Text = "Neve: " + listBox_result.SelectedItem.ToString() + "\n";
                lbl_inf_result.Text += "Ára: 800 Ft";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
