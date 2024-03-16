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
using FirebaseAdmin.Auth;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Newtonsoft.Json;

namespace Snake_Game
{
    public partial class MainMenu : Form
    {
        string pathToFirebaseCredentials = "***************************************";
        IFirebaseConfig config = new FirebaseConfig
        { AuthSecret = "****************",
            BasePath = "https://************.firebaseio.com/" };


        IFirebaseClient client;
        GameTab gameTab = new GameTab();
        Login login = new Login();
        Signup signup = new Signup();
        ListView listView = new ListView();

        public MainMenu()
        {
            InitializeComponent();
            var credential = GoogleCredential.FromFile(pathToFirebaseCredentials);
            FirebaseApp.Create(new AppOptions
            {
                Credential = credential
            });
            


        }
        private async void MainMenu_Load(object sender, EventArgs e)
        {

            
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            gameTab = new GameTab();
            gameTab.ShowDialog();
            if (login.username != null)
            {     
                client = new FireSharp.FirebaseClient(config);
                if (client != null)
                {
                    FirebaseResponse response = client.Get($"Users/{login.username}/highscore/");

                    if (response != null && response.Body != "null")
                    {
                        // Deserialize the response into a custom class
                        String highscore = response.Body;
                        int hs;
                        bool success = int.TryParse(highscore, out hs);
                        if (success)
                        {
                            if (gameTab.score > hs)
                            {
                                hs = gameTab.score;

                                FirebaseResponse responseEmail = client.Get($"Users/{login.username}/email/");
                                FirebaseResponse responseUsername = client.Get($"Users/{login.username}/username/");
                                String email_res = responseEmail.Body.Substring(1, responseEmail.Body.Length - 2); 
                                String username_res = responseUsername.Body.Substring(1, responseUsername.Body.Length - 2);
                                var data = new User
                                {
                                    highscore = hs,
                                    email = email_res,
                                    username = username_res
                                };


                                string score = gameTab.score.ToString();
                                FirebaseResponse update_response = client.Update("Users/" + login.username + "/", data);
                                if (update_response != null && update_response.Body != "null")
                                {
                                    MessageBox.Show("Highscore updated!", "New highscore:" + hs, MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }


                    }
                }
                displayListView();
            }
        
    
}
        

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            login = new Login();
            login.ShowDialog();
            if (login.username != null)
            {
                
                labelMenu.Text = "Welcome to Snake, " + login.username + " !";
                displayListView();
               
            }
            
        }

        private async void displayListView()
        {
            IFirebaseClient client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {
                try
                {
                    listView.Columns.Clear(); 
                    listView.Items.Clear();
                    FirebaseResponse response = await client.GetTaskAsync("Users/");

                    if (response.Body != "null")
                    {
                        
                        listView.Dock = DockStyle.Fill;
                        listView.View = View.Details;
                        listView.Columns.Add("Username", 150);
                        listView.Columns.Add("Highscore", 150);
                        dynamic jsonObject = JsonConvert.DeserializeObject(response.Body);
                        //MessageBox.Show(response.Body, "Response", MessageBoxButtons.OK);
                        Dictionary<string, User> dictionary = jsonObject.ToObject<Dictionary<string, User>>();
                        List<User> list = new List<User>();
                        foreach (User value in dictionary.Values)
                        {
                            list.Add(value);
                            // MessageBox.Show(value.ToString(), "Response", MessageBoxButtons.OK);
                        }
                        foreach (User user in list)
                        {
                            ListViewItem item = new ListViewItem(new[] { user.username, user.highscore.ToString() });
                            listView.Items.Add(item);

                        }
                        Controls.Add(listView);





                    }
                    else
                    {
                        Console.WriteLine("No data found in the database.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error retrieving data from Firebase: {ex.Message}");
                }
            }
            else
            {
                Console.WriteLine("Failed to initialize Firebase client.");
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            signup = new Signup();
            signup.ShowDialog();
        }
    }
}
