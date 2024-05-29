namespace BufeBeadandoProject
{
    partial class AdminWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminWindow));
            this.BTN_FoodEditExit = new System.Windows.Forms.Button();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_FoodEditExit
            // 
            this.BTN_FoodEditExit.BackColor = System.Drawing.Color.White;
            this.BTN_FoodEditExit.Location = new System.Drawing.Point(674, 38);
            this.BTN_FoodEditExit.Name = "BTN_FoodEditExit";
            this.BTN_FoodEditExit.Size = new System.Drawing.Size(104, 33);
            this.BTN_FoodEditExit.TabIndex = 19;
            this.BTN_FoodEditExit.Text = "Kilépés";
            this.BTN_FoodEditExit.UseVisualStyleBackColor = false;
            this.BTN_FoodEditExit.Click += new System.EventHandler(this.BTN_FoodEditExit_Click);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(28, 38);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(238, 368);
            this.listBoxUsers.TabIndex = 20;
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Location = new System.Drawing.Point(272, 119);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(0, 13);
            this.lbl_Message.TabIndex = 21;
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(272, 48);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 68);
            this.buttonDelete.TabIndex = 22;
            this.buttonDelete.Text = "Felhasználó törlése";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click_1);
            // 
            // AdminWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.listBoxUsers);
            this.Controls.Add(this.BTN_FoodEditExit);
            this.Name = "AdminWindow";
            this.Text = "Étlap szerkesztés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_FoodEditExit;
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Button buttonDelete;
    }
}