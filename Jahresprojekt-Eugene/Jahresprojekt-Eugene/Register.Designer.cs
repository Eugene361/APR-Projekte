namespace Jahresprojekt_Eugene
{
    partial class Register
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
            this.lbl_create = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_conpassword = new System.Windows.Forms.Label();
            this.btn_create = new System.Windows.Forms.Button();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_conpassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_create
            // 
            this.lbl_create.AutoSize = true;
            this.lbl_create.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_create.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_create.Location = new System.Drawing.Point(289, 111);
            this.lbl_create.Name = "lbl_create";
            this.lbl_create.Size = new System.Drawing.Size(227, 32);
            this.lbl_create.TabIndex = 0;
            this.lbl_create.Text = "Registrieren Sie sich";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_username.ForeColor = System.Drawing.Color.White;
            this.lbl_username.Location = new System.Drawing.Point(260, 173);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(97, 25);
            this.lbl_username.TabIndex = 1;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_password.ForeColor = System.Drawing.Color.White;
            this.lbl_password.Location = new System.Drawing.Point(260, 215);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(91, 25);
            this.lbl_password.TabIndex = 2;
            this.lbl_password.Text = "Password";
            // 
            // lbl_conpassword
            // 
            this.lbl_conpassword.AutoSize = true;
            this.lbl_conpassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_conpassword.ForeColor = System.Drawing.Color.White;
            this.lbl_conpassword.Location = new System.Drawing.Point(260, 256);
            this.lbl_conpassword.Name = "lbl_conpassword";
            this.lbl_conpassword.Size = new System.Drawing.Size(164, 25);
            this.lbl_conpassword.TabIndex = 3;
            this.lbl_conpassword.Text = "Confirm Password";
            // 
            // btn_create
            // 
            this.btn_create.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_create.Location = new System.Drawing.Point(260, 295);
            this.btn_create.Name = "btn_create";
            this.btn_create.Size = new System.Drawing.Size(286, 49);
            this.btn_create.TabIndex = 4;
            this.btn_create.Text = "Registrieren";
            this.btn_create.UseVisualStyleBackColor = true;
            this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(446, 173);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(100, 23);
            this.tb_username.TabIndex = 5;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(446, 215);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 23);
            this.tb_password.TabIndex = 6;
            this.tb_password.UseSystemPasswordChar = true;
            // 
            // tb_conpassword
            // 
            this.tb_conpassword.Location = new System.Drawing.Point(446, 256);
            this.tb_conpassword.Name = "tb_conpassword";
            this.tb_conpassword.Size = new System.Drawing.Size(100, 23);
            this.tb_conpassword.TabIndex = 7;
            this.tb_conpassword.UseSystemPasswordChar = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tb_conpassword);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.btn_create);
            this.Controls.Add(this.lbl_conpassword);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_create);
            this.Name = "Register";
            this.Text = "Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_create;
        private Label lbl_username;
        private Label lbl_password;
        private Label lbl_conpassword;
        private Button btn_create;
        private TextBox tb_username;
        private TextBox tb_password;
        private TextBox tb_conpassword;
    }
}