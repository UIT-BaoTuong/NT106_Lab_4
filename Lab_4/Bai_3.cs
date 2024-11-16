using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Lab_4
{
    public partial class Bai_3 : Form
    {
        HttpClient client = new HttpClient();
        public Bai_3()
        {
            InitializeComponent();
            textBox_Url.Text = "https://jsonplaceholder.typicode.com/posts";
        }
        public class Post
        {
            public int UserId { get; set; }
            public int Id { get; set; }
            public string Title { get; set; }
            public string Body { get; set; }
        }
        private async Task<string> GetAsync(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
        private string FormatPosts(List<Post> posts)
        {
            var formattedText = new System.Text.StringBuilder();

            foreach (var post in posts)
            {
                formattedText.AppendLine($"UserId: {post.UserId}");
                formattedText.AppendLine($"Id: {post.Id}");
                formattedText.AppendLine($"Title: {post.Title}");
                formattedText.AppendLine($"Body: {post.Body}");
                formattedText.AppendLine(new string('-', 50));
            }

            return formattedText.ToString();
        }
        private async void button_Get_Click(object sender, EventArgs e)
        {
            string url = textBox_Url.Text;
            string json = await GetAsync(url);
            var post = JsonConvert.DeserializeObject<List<Post>>(json);
            string formatText = FormatPosts(post);
            richTextBox_Data.Text = formatText;
        }
    }
}
