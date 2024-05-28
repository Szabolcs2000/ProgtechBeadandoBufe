using System.Windows.Forms;

namespace BufeBeadandoProject
{
    partial class AboutPaymentWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutPaymentWindow));
            this.BTN_AboutPaymentExit = new System.Windows.Forms.Button();
            this.TB_PaymentMessage = new System.Windows.Forms.TextBox();
            this.TB_PaymentMessage2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTN_AboutPaymentExit
            // 
            this.BTN_AboutPaymentExit.BackColor = System.Drawing.Color.White;
            this.BTN_AboutPaymentExit.Location = new System.Drawing.Point(673, 405);
            this.BTN_AboutPaymentExit.Name = "BTN_AboutPaymentExit";
            this.BTN_AboutPaymentExit.Size = new System.Drawing.Size(104, 33);
            this.BTN_AboutPaymentExit.TabIndex = 19;
            this.BTN_AboutPaymentExit.Text = "Kilépés";
            this.BTN_AboutPaymentExit.UseVisualStyleBackColor = false;
            this.BTN_AboutPaymentExit.Click += new System.EventHandler(this.BTN_AboutPaymentExit_Click);
            // 
            // TB_PaymentMessage
            // 
            this.TB_PaymentMessage.BackColor = System.Drawing.Color.White;
            this.TB_PaymentMessage.Enabled = false;
            this.TB_PaymentMessage.Location = new System.Drawing.Point(264, 207);
            this.TB_PaymentMessage.Name = "TB_PaymentMessage";
            this.TB_PaymentMessage.ReadOnly = true;
            this.TB_PaymentMessage.Size = new System.Drawing.Size(229, 20);
            this.TB_PaymentMessage.TabIndex = 20;
            this.TB_PaymentMessage.Text = "Köszünjük, hogy minket választott!";
            this.TB_PaymentMessage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TB_PaymentMessage2
            // 
            this.TB_PaymentMessage2.BackColor = System.Drawing.Color.White;
            this.TB_PaymentMessage2.Enabled = false;
            this.TB_PaymentMessage2.Location = new System.Drawing.Point(264, 233);
            this.TB_PaymentMessage2.Name = "TB_PaymentMessage2";
            this.TB_PaymentMessage2.ReadOnly = true;
            this.TB_PaymentMessage2.Size = new System.Drawing.Size(229, 20);
            this.TB_PaymentMessage2.TabIndex = 21;
            this.TB_PaymentMessage2.Text = "Kérem fáradjon a kasszához a fizetéshez!";
            this.TB_PaymentMessage2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AboutPaymentWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB_PaymentMessage2);
            this.Controls.Add(this.TB_PaymentMessage);
            this.Controls.Add(this.BTN_AboutPaymentExit);
            this.Name = "AboutPaymentWindow";
            this.Text = "Információ a fizetésről";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTN_AboutPaymentExit;
        private System.Windows.Forms.TextBox TB_PaymentMessage;
        private System.Windows.Forms.TextBox TB_PaymentMessage2;
    }
}