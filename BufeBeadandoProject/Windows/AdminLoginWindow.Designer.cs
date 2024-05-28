namespace BufeBeadandoProject
{
    partial class AdminLoginWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLoginWindow));
            this.LB_AdminWindowTitle = new System.Windows.Forms.Label();
            this.BTN_User = new System.Windows.Forms.Button();
            this.LB_User = new System.Windows.Forms.Label();
            this.LB_AdminPW = new System.Windows.Forms.Label();
            this.LB_AdminName = new System.Windows.Forms.Label();
            this.BTN_AdminLogin = new System.Windows.Forms.Button();
            this.TB_AdminPW = new System.Windows.Forms.TextBox();
            this.TB_AdminName = new System.Windows.Forms.TextBox();
            this.BTN_AdminExit = new System.Windows.Forms.Button();
            this.LB_ErrorMessage = new System.Windows.Forms.Label();
            this.BTN_AdminShowAndHidePW = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_AdminWindowTitle
            // 
            this.LB_AdminWindowTitle.AutoSize = true;
            this.LB_AdminWindowTitle.BackColor = System.Drawing.Color.White;
            this.LB_AdminWindowTitle.Location = new System.Drawing.Point(25, 34);
            this.LB_AdminWindowTitle.Name = "LB_AdminWindowTitle";
            this.LB_AdminWindowTitle.Size = new System.Drawing.Size(76, 13);
            this.LB_AdminWindowTitle.TabIndex = 0;
            this.LB_AdminWindowTitle.Text = "Admin belépés";
            // 
            // BTN_User
            // 
            this.BTN_User.BackColor = System.Drawing.Color.White;
            this.BTN_User.Location = new System.Drawing.Point(602, 399);
            this.BTN_User.Name = "BTN_User";
            this.BTN_User.Size = new System.Drawing.Size(138, 25);
            this.BTN_User.TabIndex = 16;
            this.BTN_User.Text = "Felhasználóként belépés";
            this.BTN_User.UseVisualStyleBackColor = false;
            this.BTN_User.Click += new System.EventHandler(this.BTN_User_Click);
            // 
            // LB_User
            // 
            this.LB_User.AutoSize = true;
            this.LB_User.BackColor = System.Drawing.Color.White;
            this.LB_User.Location = new System.Drawing.Point(599, 372);
            this.LB_User.Name = "LB_User";
            this.LB_User.Size = new System.Drawing.Size(181, 13);
            this.LB_User.TabIndex = 15;
            this.LB_User.Text = "Ha felhasználóként szeretne belépni:";
            // 
            // LB_AdminPW
            // 
            this.LB_AdminPW.AutoSize = true;
            this.LB_AdminPW.BackColor = System.Drawing.Color.White;
            this.LB_AdminPW.Location = new System.Drawing.Point(224, 202);
            this.LB_AdminPW.Name = "LB_AdminPW";
            this.LB_AdminPW.Size = new System.Drawing.Size(39, 13);
            this.LB_AdminPW.TabIndex = 14;
            this.LB_AdminPW.Text = "Jelszó:";
            // 
            // LB_AdminName
            // 
            this.LB_AdminName.AutoSize = true;
            this.LB_AdminName.BackColor = System.Drawing.Color.White;
            this.LB_AdminName.Location = new System.Drawing.Point(211, 170);
            this.LB_AdminName.Name = "LB_AdminName";
            this.LB_AdminName.Size = new System.Drawing.Size(84, 13);
            this.LB_AdminName.TabIndex = 13;
            this.LB_AdminName.Text = "Felhasználónév:";
            // 
            // BTN_AdminLogin
            // 
            this.BTN_AdminLogin.BackColor = System.Drawing.Color.White;
            this.BTN_AdminLogin.Location = new System.Drawing.Point(326, 245);
            this.BTN_AdminLogin.Name = "BTN_AdminLogin";
            this.BTN_AdminLogin.Size = new System.Drawing.Size(81, 32);
            this.BTN_AdminLogin.TabIndex = 12;
            this.BTN_AdminLogin.Text = "Belépés";
            this.BTN_AdminLogin.UseVisualStyleBackColor = false;
            this.BTN_AdminLogin.Click += new System.EventHandler(this.BTN_AdminLogin_Click);
            // 
            // TB_AdminPW
            // 
            this.TB_AdminPW.Location = new System.Drawing.Point(326, 199);
            this.TB_AdminPW.Name = "TB_AdminPW";
            this.TB_AdminPW.Size = new System.Drawing.Size(100, 20);
            this.TB_AdminPW.TabIndex = 11;
            // 
            // TB_AdminName
            // 
            this.TB_AdminName.Location = new System.Drawing.Point(326, 163);
            this.TB_AdminName.Name = "TB_AdminName";
            this.TB_AdminName.Size = new System.Drawing.Size(100, 20);
            this.TB_AdminName.TabIndex = 10;
            // 
            // BTN_AdminExit
            // 
            this.BTN_AdminExit.BackColor = System.Drawing.Color.White;
            this.BTN_AdminExit.Location = new System.Drawing.Point(676, 34);
            this.BTN_AdminExit.Name = "BTN_AdminExit";
            this.BTN_AdminExit.Size = new System.Drawing.Size(104, 33);
            this.BTN_AdminExit.TabIndex = 17;
            this.BTN_AdminExit.Text = "Kilépés";
            this.BTN_AdminExit.UseVisualStyleBackColor = false;
            this.BTN_AdminExit.Click += new System.EventHandler(this.BTN_AdminExit_Click);
            // 
            // LB_ErrorMessage
            // 
            this.LB_ErrorMessage.AutoSize = true;
            this.LB_ErrorMessage.Location = new System.Drawing.Point(323, 264);
            this.LB_ErrorMessage.Name = "LB_ErrorMessage";
            this.LB_ErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.LB_ErrorMessage.TabIndex = 18;
            // 
            // BTN_AdminShowAndHidePW
            // 
            this.BTN_AdminShowAndHidePW.BackColor = System.Drawing.Color.White;
            this.BTN_AdminShowAndHidePW.Location = new System.Drawing.Point(432, 191);
            this.BTN_AdminShowAndHidePW.Name = "BTN_AdminShowAndHidePW";
            this.BTN_AdminShowAndHidePW.Size = new System.Drawing.Size(86, 35);
            this.BTN_AdminShowAndHidePW.TabIndex = 31;
            this.BTN_AdminShowAndHidePW.Text = "Megjelenítés / elrejtés";
            this.BTN_AdminShowAndHidePW.UseVisualStyleBackColor = false;
            this.BTN_AdminShowAndHidePW.Click += new System.EventHandler(this.BTN_AdminShowAndHidePW_Click);
            // 
            // AdminLoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_AdminShowAndHidePW);
            this.Controls.Add(this.LB_ErrorMessage);
            this.Controls.Add(this.BTN_AdminExit);
            this.Controls.Add(this.BTN_User);
            this.Controls.Add(this.LB_User);
            this.Controls.Add(this.LB_AdminPW);
            this.Controls.Add(this.LB_AdminName);
            this.Controls.Add(this.BTN_AdminLogin);
            this.Controls.Add(this.TB_AdminPW);
            this.Controls.Add(this.TB_AdminName);
            this.Controls.Add(this.LB_AdminWindowTitle);
            this.Name = "AdminLoginWindow";
            this.Text = "Admin bejelentkezés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_AdminWindowTitle;
        private System.Windows.Forms.Button BTN_User;
        private System.Windows.Forms.Label LB_User;
        private System.Windows.Forms.Label LB_AdminPW;
        private System.Windows.Forms.Label LB_AdminName;
        private System.Windows.Forms.Button BTN_AdminLogin;
        private System.Windows.Forms.TextBox TB_AdminPW;
        private System.Windows.Forms.TextBox TB_AdminName;
        private System.Windows.Forms.Button BTN_AdminExit;
        private System.Windows.Forms.Label LB_ErrorMessage;
        private System.Windows.Forms.Button BTN_AdminShowAndHidePW;
    }
}