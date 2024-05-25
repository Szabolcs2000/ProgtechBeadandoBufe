namespace BufeBeadandoProject
{
    partial class FoodOrderWindow
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
            this.BTN_FoodOrderExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BTN_FoodOrderExit
            // 
            this.BTN_FoodOrderExit.Location = new System.Drawing.Point(637, 40);
            this.BTN_FoodOrderExit.Name = "BTN_FoodOrderExit";
            this.BTN_FoodOrderExit.Size = new System.Drawing.Size(104, 33);
            this.BTN_FoodOrderExit.TabIndex = 18;
            this.BTN_FoodOrderExit.Text = "Kilépés";
            this.BTN_FoodOrderExit.UseVisualStyleBackColor = true;
            this.BTN_FoodOrderExit.Click += new System.EventHandler(this.BTN_FoodOrderExit_Click);
            // 
            // FoodOrderWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTN_FoodOrderExit);
            this.Name = "FoodOrderWindow";
            this.Text = "FoodOrderWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BTN_FoodOrderExit;
    }
}