
namespace Snake_Game
{
    partial class Signup
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
            this.labelSignUp = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.buttonSignUp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSignUp
            // 
            this.labelSignUp.AutoSize = true;
            this.labelSignUp.Location = new System.Drawing.Point(373, 52);
            this.labelSignUp.Name = "labelSignUp";
            this.labelSignUp.Size = new System.Drawing.Size(119, 17);
            this.labelSignUp.TabIndex = 0;
            this.labelSignUp.Text = "Sign up to Snake!";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(172, 136);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 17);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "email";
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(172, 174);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(71, 17);
            this.labelUser.TabIndex = 3;
            this.labelUser.Text = "username";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(172, 213);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(68, 17);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "password";
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Location = new System.Drawing.Point(172, 252);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(118, 17);
            this.labelConfirmPassword.TabIndex = 5;
            this.labelConfirmPassword.Text = "confirm password";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(306, 133);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(251, 22);
            this.textBoxEmail.TabIndex = 6;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(306, 169);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(251, 22);
            this.textBoxUsername.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(306, 208);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(251, 22);
            this.textBoxPassword.TabIndex = 8;
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(306, 247);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '*';
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(251, 22);
            this.textBoxConfirmPassword.TabIndex = 9;
            // 
            // buttonSignUp
            // 
            this.buttonSignUp.BackColor = System.Drawing.Color.SpringGreen;
            this.buttonSignUp.Location = new System.Drawing.Point(376, 313);
            this.buttonSignUp.Name = "buttonSignUp";
            this.buttonSignUp.Size = new System.Drawing.Size(105, 44);
            this.buttonSignUp.TabIndex = 11;
            this.buttonSignUp.Text = "Sign up";
            this.buttonSignUp.UseVisualStyleBackColor = false;
            this.buttonSignUp.Click += new System.EventHandler(this.buttonSignUp_Click);
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSignUp);
            this.Controls.Add(this.textBoxConfirmPassword);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelConfirmPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelSignUp);
            this.Name = "Signup";
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Signup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSignUp;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Button buttonSignUp;
    }
}