namespace BufeBeadandoProject
{
    partial class MenuWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuWindow));
            this.listBox_result = new System.Windows.Forms.ListBox();
            this.btn_soups = new System.Windows.Forms.Button();
            this.lbl_information = new System.Windows.Forms.Label();
            this.lbl_inf_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox_result
            // 
            this.listBox_result.BackColor = System.Drawing.Color.White;
            this.listBox_result.Location = new System.Drawing.Point(480, 30);
            this.listBox_result.Name = "listBox_result";
            this.listBox_result.Size = new System.Drawing.Size(294, 225);
            this.listBox_result.TabIndex = 1;
            this.listBox_result.SelectedIndexChanged += new System.EventHandler(this.listBox_result_SelectedIndexChanged);
            // 
            // btn_soups
            // 
            this.btn_soups.AccessibleName = "";
            this.btn_soups.BackColor = System.Drawing.Color.White;
            this.btn_soups.Location = new System.Drawing.Point(296, 30);
            this.btn_soups.Name = "btn_soups";
            this.btn_soups.Size = new System.Drawing.Size(167, 52);
            this.btn_soups.TabIndex = 0;
            this.btn_soups.Text = "Levesek kilistázása";
            this.btn_soups.UseVisualStyleBackColor = false;
            this.btn_soups.Click += new System.EventHandler(this.btn_soups_Click);
            // 
            // lbl_information
            // 
            this.lbl_information.AutoSize = true;
            this.lbl_information.Location = new System.Drawing.Point(486, 281);
            this.lbl_information.Name = "lbl_information";
            this.lbl_information.Size = new System.Drawing.Size(57, 13);
            this.lbl_information.TabIndex = 2;
            this.lbl_information.Text = "Részletek:";
            this.lbl_information.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_inf_result
            // 
            this.lbl_inf_result.AutoSize = true;
            this.lbl_inf_result.Location = new System.Drawing.Point(560, 47);
            this.lbl_inf_result.Name = "lbl_inf_result";
            this.lbl_inf_result.Size = new System.Drawing.Size(0, 13);
            this.lbl_inf_result.TabIndex = 3;
            // 
            // MenuWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_inf_result);
            this.Controls.Add(this.lbl_information);
            this.Controls.Add(this.btn_soups);
            this.Controls.Add(this.listBox_result);
            this.Name = "MenuWindow";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_result;
        private System.Windows.Forms.Button btn_soups;
        private System.Windows.Forms.Label lbl_information;
        private System.Windows.Forms.Label lbl_inf_result;
    }
}