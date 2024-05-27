namespace BufeBeadandoProject
{
    partial class AdminFoodEditWindow
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
            this.BTN_FoodEditExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_FoodEditExit
            // 
            this.BTN_FoodEditExit.Location = new System.Drawing.Point(624, 51);
            this.BTN_FoodEditExit.Name = "BTN_FoodEditExit";
            this.BTN_FoodEditExit.Size = new System.Drawing.Size(104, 33);
            this.BTN_FoodEditExit.TabIndex = 19;
            this.BTN_FoodEditExit.Text = "Kilépés";
            this.BTN_FoodEditExit.UseVisualStyleBackColor = true;
            this.BTN_FoodEditExit.Click += new System.EventHandler(this.BTN_FoodEditExit_Click);
            // 
            // AdminFoodEditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_FoodEditExit);
            this.Name = "AdminFoodEditWindow";
            this.Text = "Étlap szerkesztés";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_FoodEditExit;
    }
}