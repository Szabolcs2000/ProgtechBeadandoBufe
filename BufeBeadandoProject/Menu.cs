using BufeBeadandoProject.Factorys.Soups;
using BufeBeadandoProject.Interfaces;
using BufeBeadandoProject.Soups;
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
    public partial class Menu : Form
    {
        private ISoupFactory soupFactory;
        private List<ISoup> soups;

        public Menu()
        {
            InitializeComponent();
            soups = new List<ISoup>();
            InitializeSoups();
        }

        private void InitializeSoups()
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

        private void btn_soups_Click(object sender, EventArgs e)
        {
            UpdateSoupList();
            btn_soups.Enabled = false;
        }

        private void UpdateSoupList()
        {
            listBox_result.Items.Clear();
            foreach (ISoup soup in soups)
            {
                listBox_result.Items.Add(soup.ToString());
            }
        }

        private void listBox_result_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_result.SelectedItem != null)
            {
                lbl_inf_result.Text = "Neve: " + listBox_result.SelectedItem.ToString() + "\n";
                lbl_inf_result.Text += "Ára: 1500 Ft";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
