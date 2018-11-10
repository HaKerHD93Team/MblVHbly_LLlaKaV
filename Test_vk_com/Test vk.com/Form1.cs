using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;  


namespace Test_vk.com
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://oauth.vk.com/authorize?client_id=6703181&display=page&redirect_uri=https://oauth.vk.com/blank.html&scope=friends,wall,notify,status,offline,notifications,email&response_type=token&v=5.85");
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            string url = e.Url.ToString();
            if (url.Contains("access_token"))
            {
                string access_token;
                string user_id;
                int index = url.IndexOf("access_token");
                int index2 = url.IndexOf("&expires_in");
                access_token = url.Substring(index + 13, index2 - index- 13);
                index = url.IndexOf("user_id=");
                user_id = url.Substring(index + 8);
                //Запрос на инфу о человеке
                string request = "https://api.vk.com/method/users.get?user_ids=251202664&fields=photo_100,bdate,sex,deactivated,online,id,followers_count&access_token=" + access_token + "&v=5.85";
                //Запрос друзей
                string request1 = "https://api.vk.com/method/friends.get?order=name&access_token=" + access_token + "&v=5.85";
                //Запрос ид для Стены
                string request2 = "https://api.vk.com/method/wall.get?filter=owner&access_token=" + access_token + "&v=5.85";
                //Включение проги
                webBrowser1.Visible = false;
                pictureBox1.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label9.Visible = true;
                label11.Visible = true;
                label13.Visible = true;
                label17.Visible = true;
                label19.Visible = true;
                textBox1.Visible = true;
                //DLC
                if (label16.Text == "0")
                {
                    label16.Text = "Оффлайн";
                }
                if (label16.Text == "1")
                {
                    label16.Text = "Онлайн";
                }
                //Основа
                WebClient client = new WebClient();
                string answer = Encoding.UTF8.GetString(client.DownloadData(request));
                User user = JsonConvert.DeserializeObject<User>(answer);
                pictureBox1.Load(user.response[0].photo_100);
                label1.Text = user.response[0].first_name;
                label2.Text = user.response[0].last_name;
                label8.Text = user.response[0].bdate;
                label10.Text = user.response[0].sex;
                label12.Text = user.response[0].deactivated;
                label14.Text = user.response[0].online;
                label16.Text = user.response[0].id;
                label18.Text = user.response[0].followers_count;
                string answer1 = Encoding.UTF8.GetString(client.DownloadData(request1));
                Friends Friends = JsonConvert.DeserializeObject<Friends>(answer1);
                textBox1.Text = Friends.response.items[0];
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DevAuth Developer = new DevAuth();
            Developer.Show();
        }
    }
}
