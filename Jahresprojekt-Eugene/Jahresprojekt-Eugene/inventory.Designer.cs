namespace Jahresprojekt_Eugene
{
    partial class inventory
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_show = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_inv
            // 
            this.dgv_inv.BackgroundColor = System.Drawing.Color.Silver;
            this.dgv_inv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_inv.Location = new System.Drawing.Point(12, 59);
            this.dgv_inv.Name = "dgv_inv";
            this.dgv_inv.RowTemplate.Height = 25;
            this.dgv_inv.Size = new System.Drawing.Size(764, 379);
            this.dgv_inv.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl1.ForeColor = System.Drawing.Color.White;
            this.lbl1.Location = new System.Drawing.Point(12, 20);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(446, 25);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Von welchen Spieler wollen Sie das Inventar sehen?";
            // 
            // tb_Name
            // 
            this.tb_Name.Location = new System.Drawing.Point(464, 25);
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(100, 23);
            this.tb_Name.TabIndex = 2;
            // 
            // tb_show
            // 
            this.tb_show.Location = new System.Drawing.Point(601, 25);
            this.tb_show.Name = "tb_show";
            this.tb_show.Size = new System.Drawing.Size(75, 23);
            this.tb_show.TabIndex = 3;
            this.tb_show.Text = "Anzeigen";
            this.tb_show.UseVisualStyleBackColor = true;
            this.tb_show.Click += new System.EventHandler(this.tb_show_Click);
            // 
            // inventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_show);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.dgv_inv);
            this.Name = "inventory";
            this.Text = "inventory";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_inv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgv_inv;
        private Label lbl1;
        private TextBox tb_Name;
        private Button tb_show;
    }
}