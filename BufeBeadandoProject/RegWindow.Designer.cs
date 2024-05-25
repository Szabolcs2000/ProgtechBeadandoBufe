namespace BufeBeadandoProject
{
    partial class RegWindow
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
            this.BTN_RegUser = new System.Windows.Forms.Button();
            this.LB_RegUser = new System.Windows.Forms.Label();
            this.LB_RegPW = new System.Windows.Forms.Label();
            this.LB_RegName = new System.Windows.Forms.Label();
            this.BTN_RegCreate = new System.Windows.Forms.Button();
            this.TB_RegPW = new System.Windows.Forms.TextBox();
            this.TB_RegName = new System.Windows.Forms.TextBox();
            this.LB_RegWindowTitle = new System.Windows.Forms.Label();
            this.LB_RegEmail = new System.Windows.Forms.Label();
            this.TB_RegEmail = new System.Windows.Forms.TextBox();
            this.BTN_RegExit = new System.Windows.Forms.Button();
            this.LB_RegPW2 = new System.Windows.Forms.Label();
            this.TB_RegPW2 = new System.Windows.Forms.TextBox();
            this.BTN_RegShowAndHidePW = new System.Windows.Forms.Button();
            this.BTN_RegShowAndHidePW2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_RegUser
            // 
            this.BTN_RegUser.Location = new System.Drawing.Point(578, 367);
            this.BTN_RegUser.Name = "BTN_RegUser";
            this.BTN_RegUser.Size = new System.Drawing.Size(138, 23);
            this.BTN_RegUser.TabIndex = 24;
            this.BTN_RegUser.Text = "Felhasználóként belépés";
            this.BTN_RegUser.UseVisualStyleBackColor = true;
            this.BTN_RegUser.Click += new System.EventHandler(this.BTN_RegUser_Click);
            // 
            // LB_RegUser
            // 
            this.LB_RegUser.AutoSize = true;
            this.LB_RegUser.Location = new System.Drawing.Point(584, 334);
            this.LB_RegUser.Name = "LB_RegUser";
            this.LB_RegUser.Size = new System.Drawing.Size(181, 13);
            this.LB_RegUser.TabIndex = 23;
            this.LB_RegUser.Text = "Ha felhasználóként szeretne belépni:";
            // 
            // LB_RegPW
            // 
            this.LB_RegPW.AutoSize = true;
            this.LB_RegPW.Location = new System.Drawing.Point(192, 197);
            this.LB_RegPW.Name = "LB_RegPW";
            this.LB_RegPW.Size = new System.Drawing.Size(39, 13);
            this.LB_RegPW.TabIndex = 22;
            this.LB_RegPW.Text = "Jelszó:";
            // 
            // LB_RegName
            // 
            this.LB_RegName.AutoSize = true;
            this.LB_RegName.Location = new System.Drawing.Point(192, 153);
            this.LB_RegName.Name = "LB_RegName";
            this.LB_RegName.Size = new System.Drawing.Size(84, 13);
            this.LB_RegName.TabIndex = 21;
            this.LB_RegName.Text = "Felhasználónév:";
            // 
            // BTN_RegCreate
            // 
            this.BTN_RegCreate.Location = new System.Drawing.Point(311, 324);
            this.BTN_RegCreate.Name = "BTN_RegCreate";
            this.BTN_RegCreate.Size = new System.Drawing.Size(75, 23);
            this.BTN_RegCreate.TabIndex = 20;
            this.BTN_RegCreate.Text = "Regisztráció";
            this.BTN_RegCreate.UseVisualStyleBackColor = true;
            // 
            // TB_RegPW
            // 
            this.TB_RegPW.Location = new System.Drawing.Point(311, 190);
            this.TB_RegPW.Name = "TB_RegPW";
            this.TB_RegPW.Size = new System.Drawing.Size(134, 20);
            this.TB_RegPW.TabIndex = 19;
            // 
            // TB_RegName
            // 
            this.TB_RegName.Location = new System.Drawing.Point(311, 153);
            this.TB_RegName.Name = "TB_RegName";
            this.TB_RegName.Size = new System.Drawing.Size(134, 20);
            this.TB_RegName.TabIndex = 18;
            // 
            // LB_RegWindowTitle
            // 
            this.LB_RegWindowTitle.AutoSize = true;
            this.LB_RegWindowTitle.Location = new System.Drawing.Point(36, 60);
            this.LB_RegWindowTitle.Name = "LB_RegWindowTitle";
            this.LB_RegWindowTitle.Size = new System.Drawing.Size(65, 13);
            this.LB_RegWindowTitle.TabIndex = 17;
            this.LB_RegWindowTitle.Text = "Regisztráció";
            // 
            // LB_RegEmail
            // 
            this.LB_RegEmail.AutoSize = true;
            this.LB_RegEmail.Location = new System.Drawing.Point(192, 279);
            this.LB_RegEmail.Name = "LB_RegEmail";
            this.LB_RegEmail.Size = new System.Drawing.Size(35, 13);
            this.LB_RegEmail.TabIndex = 25;
            this.LB_RegEmail.Text = "Email:";
            // 
            // TB_RegEmail
            // 
            this.TB_RegEmail.Location = new System.Drawing.Point(311, 279);
            this.TB_RegEmail.Name = "TB_RegEmail";
            this.TB_RegEmail.Size = new System.Drawing.Size(134, 20);
            this.TB_RegEmail.TabIndex = 26;
            // 
            // BTN_RegExit
            // 
            this.BTN_RegExit.Location = new System.Drawing.Point(645, 40);
            this.BTN_RegExit.Name = "BTN_RegExit";
            this.BTN_RegExit.Size = new System.Drawing.Size(104, 33);
            this.BTN_RegExit.TabIndex = 27;
            this.BTN_RegExit.Text = "Kilépés";
            this.BTN_RegExit.UseVisualStyleBackColor = true;
            this.BTN_RegExit.Click += new System.EventHandler(this.BTN_RegExit_Click);
            // 
            // LB_RegPW2
            // 
            this.LB_RegPW2.AutoSize = true;
            this.LB_RegPW2.Location = new System.Drawing.Point(192, 240);
            this.LB_RegPW2.Name = "LB_RegPW2";
            this.LB_RegPW2.Size = new System.Drawing.Size(98, 13);
            this.LB_RegPW2.TabIndex = 28;
            this.LB_RegPW2.Text = "Jelszó mégegyszer:";
            // 
            // TB_RegPW2
            // 
            this.TB_RegPW2.Location = new System.Drawing.Point(311, 240);
            this.TB_RegPW2.Name = "TB_RegPW2";
            this.TB_RegPW2.Size = new System.Drawing.Size(134, 20);
            this.TB_RegPW2.TabIndex = 29;
            // 
            // BTN_RegShowAndHidePW
            // 
            this.BTN_RegShowAndHidePW.Location = new System.Drawing.Point(467, 181);
            this.BTN_RegShowAndHidePW.Name = "BTN_RegShowAndHidePW";
            this.BTN_RegShowAndHidePW.Size = new System.Drawing.Size(85, 45);
            this.BTN_RegShowAndHidePW.TabIndex = 30;
            this.BTN_RegShowAndHidePW.Text = "Megjelenítés / elrejtés";
            this.BTN_RegShowAndHidePW.UseVisualStyleBackColor = true;
            this.BTN_RegShowAndHidePW.Click += new System.EventHandler(this.BTN_RegShowAndHidePW_Click);
            // 
            // BTN_RegShowAndHidePW2
            // 
            this.BTN_RegShowAndHidePW2.Location = new System.Drawing.Point(467, 232);
            this.BTN_RegShowAndHidePW2.Name = "BTN_RegShowAndHidePW2";
            this.BTN_RegShowAndHidePW2.Size = new System.Drawing.Size(85, 43);
            this.BTN_RegShowAndHidePW2.TabIndex = 31;
            this.BTN_RegShowAndHidePW2.Text = "Megjelenítés / elrejtés";
            this.BTN_RegShowAndHidePW2.UseVisualStyleBackColor = true;
            this.BTN_RegShowAndHidePW2.Click += new System.EventHandler(this.BTN_RegShowAndHidePW2_Click);
            // 
            // RegWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_RegShowAndHidePW2);
            this.Controls.Add(this.BTN_RegShowAndHidePW);
            this.Controls.Add(this.TB_RegPW2);
            this.Controls.Add(this.LB_RegPW2);
            this.Controls.Add(this.BTN_RegExit);
            this.Controls.Add(this.TB_RegEmail);
            this.Controls.Add(this.LB_RegEmail);
            this.Controls.Add(this.BTN_RegUser);
            this.Controls.Add(this.LB_RegUser);
            this.Controls.Add(this.LB_RegPW);
            this.Controls.Add(this.LB_RegName);
            this.Controls.Add(this.BTN_RegCreate);
            this.Controls.Add(this.TB_RegPW);
            this.Controls.Add(this.TB_RegName);
            this.Controls.Add(this.LB_RegWindowTitle);
            this.Name = "RegWindow";
            this.Text = "Regisztráció";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_RegUser;
        private System.Windows.Forms.Label LB_RegUser;
        private System.Windows.Forms.Label LB_RegPW;
        private System.Windows.Forms.Label LB_RegName;
        private System.Windows.Forms.Button BTN_RegCreate;
        private System.Windows.Forms.TextBox TB_RegPW;
        private System.Windows.Forms.TextBox TB_RegName;
        private System.Windows.Forms.Label LB_RegWindowTitle;
        private System.Windows.Forms.Label LB_RegEmail;
        private System.Windows.Forms.TextBox TB_RegEmail;
        private System.Windows.Forms.Button BTN_RegExit;
        private System.Windows.Forms.Label LB_RegPW2;
        private System.Windows.Forms.TextBox TB_RegPW2;
        private System.Windows.Forms.Button BTN_RegShowAndHidePW;
        private System.Windows.Forms.Button BTN_RegShowAndHidePW2;
    }
}