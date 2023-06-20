namespace Jahresprojekt_Eugene
{
    partial class Tradingmarket
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
            this.dgv_inv = new System.Windows.Forms.DataGridView();
            this.lbl_question = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.btn_sell = new System.Windows.Forms.Button();
            this.lbl_q2 = new System.Windows.Forms.Label();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.btn_show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_inv
            // 
            this.dgv_inv.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inv.Location = new System.Drawing.Point(12, 134);
            this.dgv_inv.Name = "dgv_inv";
            this.dgv_inv.RowTemplate.Height = 25;
            this.dgv_inv.Size = new System.Drawing.Size(776, 304);
            this.dgv_inv.TabIndex = 0;
            // 
            // lbl_question
            // 
            this.lbl_question.AutoSize = true;
            this.lbl_question.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_question.ForeColor = System.Drawing.Color.White;
            this.lbl_question.Location = new System.Drawing.Point(25, 23);
            this.lbl_question.Name = "lbl_question";
            this.lbl_question.Size = new System.Drawing.Size(361, 30);
            this.lbl_question.TabIndex = 3;
            this.lbl_question.Text = "Geben Sie Ihren Benutzernamen ein";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(433, 32);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(100, 23);
            this.tb_username.TabIndex = 5;
            // 
            // btn_sell
            // 
            this.btn_sell.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_sell.Location = new System.Drawing.Point(585, 83);
            this.btn_sell.Name = "btn_sell";
            this.btn_sell.Size = new System.Drawing.Size(122, 31);
            this.btn_sell.TabIndex = 6;
            this.btn_sell.Text = "Verkaufen";
            this.btn_sell.UseVisualStyleBackColor = true;
            this.btn_sell.Click += new System.EventHandler(this.btn_sell_Click);
            // 
            // lbl_q2
            // 
            this.lbl_q2.AutoSize = true;
            this.lbl_q2.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_q2.ForeColor = System.Drawing.Color.White;
            this.lbl_q2.Location = new System.Drawing.Point(25, 74);
            this.lbl_q2.Name = "lbl_q2";
            this.lbl_q2.Size = new System.Drawing.Size(357, 30);
            this.lbl_q2.TabIndex = 7;
            this.lbl_q2.Text = "Welche Karte wollen Sie verkaufen?";
            // 
            // tb_id
            // 
            this.tb_id.Location = new System.Drawing.Point(433, 83);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 23);
            this.tb_id.TabIndex = 8;
            // 
            // btn_show
            // 
            this.btn_show.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_show.Location = new System.Drawing.Point(585, 32);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(122, 31);
            this.btn_show.TabIndex = 9;
            this.btn_show.Text = "Anzeigen";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.btn_show_Click);
            // 
            // Tradingmarket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_show);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.lbl_q2);
            this.Controls.Add(this.btn_sell);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.lbl_question);
            this.Controls.Add(this.dgv_inv);
            this.Name = "Tradingmarket";
            this.Text = "Tradingmarket";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_inv;
        private Label lbl_question;
        private TextBox tb_username;
        private Button btn_sell;
        private Label lbl_q2;
        private TextBox tb_id;
        private Button btn_show;
    }
}