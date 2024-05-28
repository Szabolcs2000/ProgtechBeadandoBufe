namespace BufeBeadandoProject
{
    partial class UserLoginWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLoginWindow));
            this.LB_Cim = new System.Windows.Forms.Label();
            this.TB_UserName = new System.Windows.Forms.TextBox();
            this.TB_UserPW = new System.Windows.Forms.TextBox();
            this.BTN_UserLogin = new System.Windows.Forms.Button();
            this.LB_UserName = new System.Windows.Forms.Label();
            this.LB_UserPW = new System.Windows.Forms.Label();
            this.LB_Reg = new System.Windows.Forms.Label();
            this.BTN_Reg = new System.Windows.Forms.Button();
            this.LB_Admin = new System.Windows.Forms.Label();
            this.BTN_Admin = new System.Windows.Forms.Button();
            this.BTN_UserExit = new System.Windows.Forms.Button();
            this.LB_UserErrorMessage = new System.Windows.Forms.Label();
            this.BTN_UserShowAndHidePW = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LB_Cim
            // 
            this.LB_Cim.AutoSize = true;
            this.LB_Cim.BackColor = System.Drawing.Color.White;
            this.LB_Cim.Location = new System.Drawing.Point(161, 28);
            this.LB_Cim.Name = "LB_Cim";
            this.LB_Cim.Size = new System.Drawing.Size(63, 13);
            this.LB_Cim.TabIndex = 0;
            this.LB_Cim.Text = "Pocak Büfé";
            // 
            // TB_UserName
            // 
            this.TB_UserName.Location = new System.Drawing.Point(352, 147);
            this.TB_UserName.Name = "TB_UserName";
            this.TB_UserName.Size = new System.Drawing.Size(100, 20);
            this.TB_UserName.TabIndex = 1;
            // 
            // TB_UserPW
            // 
            this.TB_UserPW.Location = new System.Drawing.Point(352, 184);
            this.TB_UserPW.Name = "TB_UserPW";
            this.TB_UserPW.Size = new System.Drawing.Size(100, 20);
            this.TB_UserPW.TabIndex = 2;
            // 
            // BTN_UserLogin
            // 
            this.BTN_UserLogin.BackColor = System.Drawing.Color.White;
            this.BTN_UserLogin.Location = new System.Drawing.Point(352, 223);
            this.BTN_UserLogin.Name = "BTN_UserLogin";
            this.BTN_UserLogin.Size = new System.Drawing.Size(75, 23);
            this.BTN_UserLogin.TabIndex = 3;
            this.BTN_UserLogin.Text = "Belépés";
            this.BTN_UserLogin.UseVisualStyleBackColor = false;
            this.BTN_UserLogin.Click += new System.EventHandler(this.BTN_UserLogin_Click);
            // 
            // LB_UserName
            // 
            this.LB_UserName.AutoSize = true;
            this.LB_UserName.BackColor = System.Drawing.Color.White;
            this.LB_UserName.Location = new System.Drawing.Point(253, 153);
            this.LB_UserName.Name = "LB_UserName";
            this.LB_UserName.Size = new System.Drawing.Size(84, 13);
            this.LB_UserName.TabIndex = 4;
            this.LB_UserName.Text = "Felhasználónév:";
            // 
            // LB_UserPW
            // 
            this.LB_UserPW.AutoSize = true;
            this.LB_UserPW.BackColor = System.Drawing.Color.White;
            this.LB_UserPW.Location = new System.Drawing.Point(298, 191);
            this.LB_UserPW.Name = "LB_UserPW";
            this.LB_UserPW.Size = new System.Drawing.Size(39, 13);
            this.LB_UserPW.TabIndex = 5;
            this.LB_UserPW.Text = "Jelszó:";
            // 
            // LB_Reg
            // 
            this.LB_Reg.AutoSize = true;
            this.LB_Reg.BackColor = System.Drawing.Color.White;
            this.LB_Reg.Location = new System.Drawing.Point(170, 316);
            this.LB_Reg.Name = "LB_Reg";
            this.LB_Reg.Size = new System.Drawing.Size(206, 13);
            this.LB_Reg.TabIndex = 6;
            this.LB_Reg.Text = "Ha nincs még fiókja, akkor itt regisztrálhat:";
            // 
            // BTN_Reg
            // 
            this.BTN_Reg.BackColor = System.Drawing.Color.White;
            this.BTN_Reg.Location = new System.Drawing.Point(301, 343);
            this.BTN_Reg.Name = "BTN_Reg";
            this.BTN_Reg.Size = new System.Drawing.Size(75, 23);
            this.BTN_Reg.TabIndex = 7;
            this.BTN_Reg.Text = "Regisztráció";
            this.BTN_Reg.UseVisualStyleBackColor = false;
            this.BTN_Reg.Click += new System.EventHandler(this.BTN_Reg_Click);
            // 
            // LB_Admin
            // 
            this.LB_Admin.AutoSize = true;
            this.LB_Admin.BackColor = System.Drawing.Color.White;
            this.LB_Admin.Location = new System.Drawing.Point(464, 316);
            this.LB_Admin.Name = "LB_Admin";
            this.LB_Admin.Size = new System.Drawing.Size(156, 13);
            this.LB_Admin.TabIndex = 8;
            this.LB_Admin.Text = "Ha adminként szeretne belépni:";
            // 
            // BTN_Admin
            // 
            this.BTN_Admin.BackColor = System.Drawing.Color.White;
            this.BTN_Admin.Location = new System.Drawing.Point(467, 343);
            this.BTN_Admin.Name = "BTN_Admin";
            this.BTN_Admin.Size = new System.Drawing.Size(138, 23);
            this.BTN_Admin.TabIndex = 9;
            this.BTN_Admin.Text = "Adminként belépés";
            this.BTN_Admin.UseVisualStyleBackColor = false;
            this.BTN_Admin.Click += new System.EventHandler(this.BTN_Admin_Click);
            // 
            // BTN_UserExit
            // 
            this.BTN_UserExit.BackColor = System.Drawing.Color.White;
            this.BTN_UserExit.Location = new System.Drawing.Point(684, 18);
            this.BTN_UserExit.Name = "BTN_UserExit";
            this.BTN_UserExit.Size = new System.Drawing.Size(104, 33);
            this.BTN_UserExit.TabIndex = 10;
            this.BTN_UserExit.Text = "Kilépés";
            this.BTN_UserExit.UseVisualStyleBackColor = false;
            this.BTN_UserExit.Click += new System.EventHandler(this.BTN_UserExit_Click);
            // 
            // LB_UserErrorMessage
            // 
            this.LB_UserErrorMessage.AutoSize = true;
            this.LB_UserErrorMessage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LB_UserErrorMessage.Location = new System.Drawing.Point(321, 270);
            this.LB_UserErrorMessage.Name = "LB_UserErrorMessage";
            this.LB_UserErrorMessage.Size = new System.Drawing.Size(0, 13);
            this.LB_UserErrorMessage.TabIndex = 11;
            // 
            // BTN_UserShowAndHidePW
            // 
            this.BTN_UserShowAndHidePW.BackColor = System.Drawing.Color.White;
            this.BTN_UserShowAndHidePW.Location = new System.Drawing.Point(467, 174);
            this.BTN_UserShowAndHidePW.Name = "BTN_UserShowAndHidePW";
            this.BTN_UserShowAndHidePW.Size = new System.Drawing.Size(85, 39);
            this.BTN_UserShowAndHidePW.TabIndex = 31;
            this.BTN_UserShowAndHidePW.Text = "Megjelenítés / elrejtés";
            this.BTN_UserShowAndHidePW.UseVisualStyleBackColor = false;
            this.BTN_UserShowAndHidePW.Click += new System.EventHandler(this.BTN_UserShowAndHidePW_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(654, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UserLoginWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BTN_UserShowAndHidePW);
            this.Controls.Add(this.LB_UserErrorMessage);
            this.Controls.Add(this.BTN_UserExit);
            this.Controls.Add(this.BTN_Admin);
            this.Controls.Add(this.LB_Admin);
            this.Controls.Add(this.BTN_Reg);
            this.Controls.Add(this.LB_Reg);
            this.Controls.Add(this.LB_UserPW);
            this.Controls.Add(this.LB_UserName);
            this.Controls.Add(this.BTN_UserLogin);
            this.Controls.Add(this.TB_UserPW);
            this.Controls.Add(this.TB_UserName);
            this.Controls.Add(this.LB_Cim);
            this.Name = "UserLoginWindow";
            this.Text = "Bejelentkezés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LB_Cim;
        private System.Windows.Forms.TextBox TB_UserName;
        private System.Windows.Forms.TextBox TB_UserPW;
        private System.Windows.Forms.Button BTN_UserLogin;
        private System.Windows.Forms.Label LB_UserName;
        private System.Windows.Forms.Label LB_UserPW;
        private System.Windows.Forms.Label LB_Reg;
        private System.Windows.Forms.Button BTN_Reg;
        private System.Windows.Forms.Label LB_Admin;
        private System.Windows.Forms.Button BTN_Admin;
        private System.Windows.Forms.Button BTN_UserExit;
        private System.Windows.Forms.Label LB_UserErrorMessage;
        private System.Windows.Forms.Button BTN_UserShowAndHidePW;
        private System.Windows.Forms.Button button1;
    }
}

