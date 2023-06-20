namespace Jahresprojekt_Eugene
{
    partial class Cardshop
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_questionone = new System.Windows.Forms.Label();
            this.lbl_questiontwo = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.btn_buy = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 103);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // lbl_questionone
            // 
            this.lbl_questionone.AutoSize = true;
            this.lbl_questionone.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_questionone.ForeColor = System.Drawing.Color.White;
            this.lbl_questionone.Location = new System.Drawing.Point(12, 9);
            this.lbl_questionone.Name = "lbl_questionone";
            this.lbl_questionone.Size = new System.Drawing.Size(323, 30);
            this.lbl_questionone.TabIndex = 1;
            this.lbl_questionone.Text = "Welche Karte wollen sie kaufen?";
            // 
            // lbl_questiontwo
            // 
            this.lbl_questiontwo.AutoSize = true;
            this.lbl_questiontwo.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_questiontwo.ForeColor = System.Drawing.Color.White;
            this.lbl_questiontwo.Location = new System.Drawing.Point(12, 52);
            this.lbl_questiontwo.Name = "lbl_questiontwo";
            this.lbl_questiontwo.Size = new System.Drawing.Size(361, 30);
            this.lbl_questiontwo.TabIndex = 2;
            this.lbl_questiontwo.Text = "Geben Sie Ihren Benutzernamen ein";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(374, 9);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 23);
            this.tb_id.TabIndex = 3;
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(374, 59);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(100, 23);
            this.tb_username.TabIndex = 4;
            // 
            // btn_buy
            // 
            this.btn_buy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_buy.Location = new System.Drawing.Point(480, 56);
            this.btn_buy.Name = "btn_buy";
            this.btn_buy.Size = new System.Drawing.Size(122, 31);
            this.btn_buy.TabIndex = 5;
            this.btn_buy.Text = "Kaufen";
            this.btn_buy.UseVisualStyleBackColor = true;
            this.btn_buy.Click += new System.EventHandler(this.btn_buy_Click);
            // 
            // Cardshop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_buy);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lbl_questiontwo);
            this.Controls.Add(this.lbl_questionone);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Cardshop";
            this.Text = "Cardshop";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label lbl_questionone;
        private Label lbl_questiontwo;
        private TextBox tb_id;
        private TextBox tb_username;
        private Button btn_buy;
    }
}