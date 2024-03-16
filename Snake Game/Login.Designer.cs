
namespace Snake_Game
{
    partial class Login
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
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelLogIn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonLogIn.Location = new System.Drawing.Point(352, 299);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(105, 44);
            this.buttonLogIn.TabIndex = 21;
            this.buttonLogIn.Text = "Login";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(294, 214);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(251, 22);
            this.textBoxPassword.TabIndex = 19;
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(294, 175);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(251, 22);
            this.textBoxUserName.TabIndex = 18;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(160, 219);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(68, 17);
            this.labelPassword.TabIndex = 15;
            this.labelPassword.Text = "password";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(160, 180);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(71, 17);
            this.labelUser.TabIndex = 14;
            this.labelUser.Text = "username";
            // 
            // labelLogIn
            // 
            this.labelLogIn.AutoSize = true;
            this.labelLogIn.Location = new System.Drawing.Point(361, 58);
            this.labelLogIn.Name = "labelLogIn";
            this.labelLogIn.Size = new System.Drawing.Size(110, 17);
            this.labelLogIn.TabIndex = 12;
            this.labelLogIn.Text = "Log in to Snake!";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonLogIn);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelLogIn);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelLogIn;
    }
}