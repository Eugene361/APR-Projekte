namespace Jahresprojekt_Eugene
{
    partial class Newcard
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
            this.lbl_headline = new System.Windows.Forms.Label();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_rarity = new System.Windows.Forms.Label();
            this.lbl_quality = new System.Windows.Forms.Label();
            this.lbl_type = new System.Windows.Forms.Label();
            this.lbl_price = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.btn_create = new System.Windows.Forms.Button();
            this.cb_rarity = new System.Windows.Forms.ComboBox();
            this.cb_quality = new System.Windows.Forms.ComboBox();
            this.cb_type = new System.Windows.Forms.ComboBox();
            this.btn_home = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_headline
            // 
            this.lbl_headline.AutoSize = true;
            this.lbl_headline.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_headline.ForeColor = System.Drawing.Color.White;
            this.lbl_headline.Location = new System.Drawing.Point(267, 84);
            this.lbl_headline.Name = "lbl_headline";
            this.lbl_headline.Size = new System.Drawing.Size(285, 37);
            this.lbl_headline.TabIndex = 0;
            this.lbl_headline.Text = "Erstellen Sie eine Karte";
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_name.ForeColor = System.Drawing.Color.White;
            this.lbl_name.Location = new System.Drawing.Point(248, 143);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(62, 25);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Name";
            // 
            // lbl_rarity
            // 
            this.lbl_rarity.AutoSize = true;
            this.lbl_rarity.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_rarity.ForeColor = System.Drawing.Color.White;
            this.lbl_rarity.Location = new System.Drawing.Point(248, 182);
            this.lbl_rarity.Name = "lbl_rarity";
            this.lbl_rarity.Size = new System.Drawing.Size(96, 25);
            this.lbl_rarity.TabIndex = 2;
            this.lbl_rarity.Text = "Seltenheit";
            // 
            // lbl_quality
            // 
            this.lbl_quality.AutoSize = true;
            this.lbl_quality.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_quality.ForeColor = System.Drawing.Color.White;
            this.lbl_quality.Location = new System.Drawing.Point(248, 216);
            this.lbl_quality.Name = "lbl_quality";
            this.lbl_quality.Size = new System.Drawing.Size(79, 25);
            this.lbl_quality.TabIndex = 3;
            this.lbl_quality.Text = "Qualität";
            // 
            // lbl_type
            // 
            this.lbl_type.AutoSize = true;
            this.lbl_type.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_type.ForeColor = System.Drawing.Color.White;
            this.lbl_type.Location = new System.Drawing.Point(248, 250);
            this.lbl_type.Name = "lbl_type";
            this.lbl_type.Size = new System.Drawing.Size(41, 25);
            this.lbl_type.TabIndex = 4;
            this.lbl_type.Text = "Typ";
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_price.ForeColor = System.Drawing.Color.White;
            this.lbl_price.Location = new System.Drawing.Point(248, 285);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(53, 25);
            this.lbl_price.TabIndex = 5;
            this.lbl_price.Text = "Preis";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(467, 148);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(121, 23);
            this.tb_name.TabIndex = 6;
            // 
            // tb_price
            // 
            this.tb_price.Location = new System.Drawing.Point(467, 290);
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(121, 23);
            this.tb_price.TabIndex = 9;
            // 
            // btn_create
            // 
            this.btn_create.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_create.Location = new System.Drawing.Point(361, 365);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(87, 40);
            this.btn_create.TabIndex = 11;
            this.btn_create.Text = "Erstellen";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // cb_rarity
            // 
            this.cb_rarity.FormattingEnabled = true;
            this.cb_rarity.Items.AddRange(new object[] {
            "Gewöhnlich",
            "Selten",
            "Episch",
            "Legendär"});
            this.cb_rarity.Location = new System.Drawing.Point(467, 187);
            this.cb_rarity.Name = "cb_rarity";
            this.cb_rarity.Size = new System.Drawing.Size(121, 23);
            this.cb_rarity.TabIndex = 12;
            // 
            // cb_quality
            // 
            this.cb_quality.FormattingEnabled = true;
            this.cb_quality.Items.AddRange(new object[] {
            "Sehr schlecht",
            "Schlecht",
            "Normal",
            "Gut",
            "Sehr gut"});
            this.cb_quality.Location = new System.Drawing.Point(467, 221);
            this.cb_quality.Name = "cb_quality";
            this.cb_quality.Size = new System.Drawing.Size(121, 23);
            this.cb_quality.TabIndex = 13;
            // 
            // cb_type
            // 
            this.cb_type.FormattingEnabled = true;
            this.cb_type.Items.AddRange(new object[] {
            "Typ a",
            "Typ b",
            "Typ c"});
            this.cb_type.Location = new System.Drawing.Point(467, 255);
            this.cb_type.Name = "cb_type";
            this.cb_type.Size = new System.Drawing.Size(121, 23);
            this.cb_type.TabIndex = 14;
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(361, 411);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(87, 23);
            this.btn_home.TabIndex = 15;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(713, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 16;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Newcard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.cb_type);
            this.Controls.Add(this.cb_quality);
            this.Controls.Add(this.cb_rarity);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.tb_price);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.lbl_type);
            this.Controls.Add(this.lbl_quality);
            this.Controls.Add(this.lbl_rarity);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_headline);
            this.Name = "Newcard";
            this.Text = "Newcard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_headline;
        private Label lbl_name;
        private Label lbl_rarity;
        private Label lbl_quality;
        private Label lbl_type;
        private Label lbl_price;
        private TextBox tb_name;
        private TextBox tb_price;
        private Button btn_create;
        private ComboBox cb_rarity;
        private ComboBox cb_quality;
        private ComboBox cb_type;
        private Button btn_home;
        private Button btn_exit;
    }
}