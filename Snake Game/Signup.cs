using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using FirebaseAdmin;
using FirebaseAdmin.Auth;
using Google.Apis.Auth.OAuth2;

namespace Snake_Game
{
    public partial class Signup : Form
    {
        
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "**********************",
            BasePath = "https://*************.firebaseio.com/"
        };
        IFirebaseClient client;


        public Signup()
        {
            InitializeComponent();
           

        }

        private void Signup_Load(object sender, EventArgs e)
        {
            client = new FireSharp.FirebaseClient(config);
           

        }

        private async void buttonSignUp_Click(object sender, EventArgs e)
        {
            if (textBoxEmail.Text != null &&
                textBoxUsername.Text != null &&
                textBoxPassword.Text.Equals(textBoxConfirmPassword.Text) &&
                textBoxPassword.Text != null)
            {
                FirebaseAuth.DefaultInstance.CreateUserAsync(new UserRecordArgs
                {
                    Email = textBoxEmail.Text,
                    Password = textBoxPassword.Text
                });

                var data = new User
                {
                    
                    email = textBoxEmail.Text,
                    username = textBoxUsername.Text,
                    highscore = 0
                };
                SetResponse response = await client.SetTaskAsync("Users/"+ textBoxUsername.Text, data);
                DialogResult result = MessageBox.Show("Your account has been created", "Account created",MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {

                    this.Close();
                }
            }
        }
    }
}
