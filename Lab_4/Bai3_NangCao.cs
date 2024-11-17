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
    public partial class Bai3_NangCao : Form
    {
        public Bai3_NangCao()
        {

            InitializeComponent();
            textBox_Url.Text = "https://localhost:44352/api/student";
        }
        HttpClient client = new HttpClient();
        private async Task<string> GetAsync(string url)
        {
            HttpResponseMessage response = await client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            return responseBody;
        }
        public class Student
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string School { get; set; }
        }
        private string FormatStudents(List<Student> students)
        {
            var formattedText = new System.Text.StringBuilder();

            foreach (var student in students)
            {
                formattedText.AppendLine($"ID: {student.ID}");
                formattedText.AppendLine($"Name: {student.Name}");
                formattedText.AppendLine($"DateOfBirth: {student.DateOfBirth:yyyy-MM-dd}");
                formattedText.AppendLine($"School: {student.School}");
                formattedText.AppendLine(new string('-', 50));
            }

            return formattedText.ToString();
        }
        private async void button_Get_Click(object sender, EventArgs e)
        {
            string url = textBox_Url.Text;
            string html = await GetAsync(url);
            JToken token = JToken.Parse(html);
            List<Student> students;
            if (token is JArray)
            {
                students = JsonConvert.DeserializeObject<List<Student>>(html);
            }    
            else
            {
                Student student = JsonConvert.DeserializeObject<Student>(html);
                students = new List<Student> { student };
            }    
            html = FormatStudents(students);
            richTextBox_Data.Text = html;

        }
    }
}
