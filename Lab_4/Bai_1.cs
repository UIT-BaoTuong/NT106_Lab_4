using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
namespace Lab_4
{
    public partial class Bai_1 : Form
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = new HttpResponseMessage();
        public Bai_1()
        {
            InitializeComponent();
        }
        private async Task<string> getHTML(string url)
        {
            response = await client.GetAsync(textBox_Url.Text);
            response.EnsureSuccessStatusCode();
            string respondBody = await response.Content.ReadAsStringAsync();
            return respondBody;
        }
        private async void button_Download_Click(object sender, EventArgs e)
        {
            string html = await getHTML(textBox_Url.Text);
            richTextBox_Data.Text = html;
            var headers = response.Headers;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("STT");
            dataTable.Columns.Add("Header");
            dataTable.Columns.Add("Value");
            int i = 1;
            foreach (var header in headers)
            {
                dataTable.Rows.Add(i, header.Key, string.Join(", ", header.Value));
                i++;
            }
            dataGridView_Header.DataSource = dataTable;
        }
    }
}
