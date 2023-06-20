namespace Jahresprojekt_Eugene
{
    partial class Mainform
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
            this.btn_packshop = new System.Windows.Forms.Button();
            this.btn_trading = new System.Windows.Forms.Button();
            this.btn_invetory = new System.Windows.Forms.Button();
            this.btn_allcards = new System.Windows.Forms.Button();
            this.btn_newcard = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_cardshop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_packshop
            // 
            this.btn_packshop.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_packshop.Location = new System.Drawing.Point(23, 140);
            this.btn_packshop.Name = "btn_packshop";
            this.btn_packshop.Size = new System.Drawing.Size(121, 211);
            this.btn_packshop.TabIndex = 0;
            this.btn_packshop.Text = "Pack Shop";
            this.btn_packshop.UseVisualStyleBackColor = true;
            this.btn_packshop.Click += new System.EventHandler(this.btn_shop_Click);
            // 
            // btn_trading
            // 
            this.btn_trading.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_trading.Location = new System.Drawing.Point(277, 140);
            this.btn_trading.Name = "btn_trading";
            this.btn_trading.Size = new System.Drawing.Size(121, 211);
            this.btn_trading.TabIndex = 1;
            this.btn_trading.Text = "Karten Verkaufen";
            this.btn_trading.UseVisualStyleBackColor = true;
            this.btn_trading.Click += new System.EventHandler(this.btn_trading_Click);
            // 
            // btn_invetory
            // 
            this.btn_invetory.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_invetory.Location = new System.Drawing.Point(531, 140);
            this.btn_invetory.Name = "btn_invetory";
            this.btn_invetory.Size = new System.Drawing.Size(121, 211);
            this.btn_invetory.TabIndex = 3;
            this.btn_invetory.Text = "Inventar";
            this.btn_invetory.UseVisualStyleBackColor = true;
            this.btn_invetory.Click += new System.EventHandler(this.btn_invetory_Click);
            // 
            // btn_allcards
            // 
            this.btn_allcards.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_allcards.Location = new System.Drawing.Point(404, 140);
            this.btn_allcards.Name = "btn_allcards";
            this.btn_allcards.Size = new System.Drawing.Size(121, 211);
            this.btn_allcards.TabIndex = 4;
            this.btn_allcards.Text = "Alle Karten";
            this.btn_allcards.UseVisualStyleBackColor = true;
            this.btn_allcards.Click += new System.EventHandler(this.btn_allcards_Click);
            // 
            // btn_newcard
            // 
            this.btn_newcard.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_newcard.Location = new System.Drawing.Point(658, 140);
            this.btn_newcard.Name = "btn_newcard";
            this.btn_newcard.Size = new System.Drawing.Size(121, 211);
            this.btn_newcard.TabIndex = 5;
            this.btn_newcard.Text = "Neue Karte";
            this.btn_newcard.UseVisualStyleBackColor = true;
            this.btn_newcard.Click += new System.EventHandler(this.btn_newcard_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(713, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 17;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_cardshop
            // 
            this.btn_cardshop.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_cardshop.Location = new System.Drawing.Point(150, 140);
            this.btn_cardshop.Name = "btn_cardshop";
            this.btn_cardshop.Size = new System.Drawing.Size(121, 211);
            this.btn_cardshop.TabIndex = 18;
            this.btn_cardshop.Text = "Karten Shop";
            this.btn_cardshop.UseVisualStyleBackColor = true;
            this.btn_cardshop.Click += new System.EventHandler(this.btn_cardshop_Click);
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_cardshop);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_newcard);
            this.Controls.Add(this.btn_allcards);
            this.Controls.Add(this.btn_invetory);
            this.Controls.Add(this.btn_trading);
            this.Controls.Add(this.btn_packshop);
            this.Name = "Mainform";
            this.Text = "Mainform";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_packshop;
        private Button btn_trading;
        private Button btn_invetory;
        private Button btn_allcards;
        private Button btn_newcard;
        private Button btn_exit;
        private Button btn_cardshop;
    }
}