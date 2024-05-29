using BufeBeadandoProject.Log.Login_and_other;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BufeBeadandoProject
{
    public partial class AdminWindow : Form
    {
        private static AdminWindow instance = null;
        private static readonly object padlock = new object();
        private string filePath = "./Users.csv";

        private AdminWindow()
        {
            InitializeComponent();
            LoadUsers();
        }

        public static AdminWindow Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new AdminWindow();
                    }
                    return instance;
                }
            }
        }

        private void LoadUsers()
        {
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                listBoxUsers.Items.Clear();
                foreach (var line in lines)
                {
                    var parts = line.Split(';');
                    if (parts.Length == 2)
                    {
                        listBoxUsers.Items.Add(parts[0]);
                    }
                }
            }
            else
            {
                MessageBox.Show("A fájl nem található.");
            }
        }

        private void BTN_FoodEditExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonDelete_Click_1(object sender, EventArgs e)
        {
            var selectedUser = listBoxUsers.SelectedItem;
            if (selectedUser != null)
            {
                var lines = File.ReadAllLines(filePath).ToList();
                var newLines = lines.Where(line => !line.StartsWith(selectedUser.ToString() + ";")).ToList();

                File.WriteAllLines(filePath, newLines);
                LoadUsers();
                lbl_Message.Text = $"{selectedUser} törölve.";
                LogForAdminDeleteUser logForAdminDeleteUser = new LogForAdminDeleteUser();
                logForAdminDeleteUser.Log("Információ", selectedUser.ToString());
            }
            else
            {
                lbl_Message.Text = "Kérjük, válasszon ki egy felhasználót a törléshez.";
            }
        }
    }
}
