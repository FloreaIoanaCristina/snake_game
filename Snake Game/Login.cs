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
using Firebase.Auth;
using Google.Apis.Auth.OAuth2;
using Newtonsoft.Json;

namespace Snake_Game
{
    public partial class Login : Form
    {
        //string pathToFirebaseCredentials = "C:/Users/Ioana/Downloads/snake-cfe77-firebase-adminsdk-d8amd-b10294df58.json";

        public String username;

        IFirebaseConfig config = new FireSharp.Config.FirebaseConfig
        {
            AuthSecret = "aat8x6msYBoBp32CEWmGnKnxvSxzB1paVas5Ogpk",
            BasePath = "https://snake-cfe77-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;
        public Login()
        {
            InitializeComponent();
           
        
            //var credential = GoogleCredential.FromFile(pathToFirebaseCredentials);
            //FirebaseApp.Create(new AppOptions
            //{
            //    Credential = credential
            //});
            
        }

        private async void buttonLogIn_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text != null && textBoxPassword.Text != null)
            {
                client = new FireSharp.FirebaseClient(config);
                if (client != null)
                {
                    FirebaseResponse response =  client.Get($"Users/{textBoxUserName.Text}/email/");
                        // Extract email from response
                        
                        
                        if (response != null && response.Body != "null")
                        {
                        // Deserialize the response into a custom class
                        String email = response.Body;
                        String trim_email = email.Substring(1, email.Length - 2);

                        var auth = new FirebaseAuthProvider(new Firebase.Auth.FirebaseConfig("AIzaSyB2SCPsjXF62_ufKcgbY1eCYkl4xNmRcBY"));
                            var result = await auth.SignInWithEmailAndPasswordAsync(trim_email, textBoxPassword.Text);
                            var user = result.User;


                            if (user != null)
                            {
                            // Authentication successful
                            username = textBoxUserName.Text;

                                this.Close();

                            }
                            else
                            {
                                // Authentication failed
                                Console.WriteLine("Authentication failed.");
                                DialogResult message = MessageBox.Show("Try again", "Authentication failed.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                if (message == DialogResult.OK)
                                {

                                    this.Close();
                                }
                            }
                        }
                }
            }
        }
    }
}
