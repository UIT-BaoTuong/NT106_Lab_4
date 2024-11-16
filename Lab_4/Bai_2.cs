using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_4
{
    public partial class Bai_2 : Form
    {
        HttpClient client = new HttpClient();
        HttpResponseMessage response = new HttpResponseMessage();
        public Bai_2()
        {
            InitializeComponent();
            InitializeWebViewAsync();
            this.WindowState = FormWindowState.Maximized;
            textBox_Url.Text = "https://www.uit.edu.vn/";
        }
        private async Task<string> getHTML(string url)
        {
            response = await client.GetAsync(textBox_Url.Text);
            response.EnsureSuccessStatusCode();
            string respondBody = await response.Content.ReadAsStringAsync();
            return respondBody;
        }
        private void webView21_Click(object sender, EventArgs e)
        {

        }
        private async void InitializeWebViewAsync()
        {
            await webView21.EnsureCoreWebView2Async(null);
        }
        private async void button_Show_Click(object sender, EventArgs e)
        {
            string html = await getHTML(textBox_Url.Text);
            switch (comboBox_Device.SelectedItem.ToString())
            {
                case "Desktop":
                    webView21.Dock = DockStyle.None;
                    webView21.Size = new System.Drawing.Size(1024, 768);
                    break;
                case "Tablet":
                    webView21.Dock = DockStyle.None;
                    webView21.Size = new System.Drawing.Size(768, 1024);
                    break;
                case "Mobile":
                    webView21.Dock = DockStyle.None;
                    webView21.Size = new System.Drawing.Size(375, 667);
                    break;
                default:
                    webView21.Dock = DockStyle.Fill;
                    break;
            }

            webView21.Location = new System.Drawing.Point(
                (this.ClientSize.Width - webView21.Width) / 2,
                (this.ClientSize.Height - webView21.Height) / 2
            );
            webView21.NavigateToString(html);
        }
    }
}