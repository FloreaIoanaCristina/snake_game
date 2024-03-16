
namespace Snake_Game
{
    partial class MainMenu
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
            this.buttonPlay = new System.Windows.Forms.Button();
            this.labelMenu = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(291, 226);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(183, 23);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "PLAY";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.Location = new System.Drawing.Point(324, 81);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(129, 17);
            this.labelMenu.TabIndex = 1;
            this.labelMenu.Text = "Welcome to Snake!";
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(291, 280);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(183, 23);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "LOG IN";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(291, 335);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(183, 23);
            this.buttonCreate.TabIndex = 3;
            this.buttonCreate.Text = "NEW ACCOUNT";
            this.buttonCreate.UseVisualStyleBackColor = true;
            this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
            // 
            // MainMenu
            // 
            this.ClientSize = new System.Drawing.Size(814, 606);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.buttonPlay);
            this.Name = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

    
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCreate;
    }
}

