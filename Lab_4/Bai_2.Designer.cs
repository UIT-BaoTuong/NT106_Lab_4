namespace Lab_4
{
    partial class Bai_2
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
            button_Show = new Button();
            label1 = new Label();
            textBox_Url = new TextBox();
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            label2 = new Label();
            comboBox_Device = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // button_Show
            // 
            button_Show.Location = new Point(659, 40);
            button_Show.Name = "button_Show";
            button_Show.Size = new Size(94, 29);
            button_Show.TabIndex = 9;
            button_Show.Text = "Show";
            button_Show.UseVisualStyleBackColor = true;
            button_Show.Click += button_Show_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 47);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 8;
            label1.Text = "Web URL";
            // 
            // textBox_Url
            // 
            textBox_Url.Location = new Point(87, 40);
            textBox_Url.Name = "textBox_Url";
            textBox_Url.Size = new Size(351, 27);
            textBox_Url.TabIndex = 7;
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Location = new Point(0, 92);
            webView21.Name = "webView21";
            webView21.Size = new Size(800, 358);
            webView21.TabIndex = 10;
            webView21.ZoomFactor = 1D;
            webView21.Click += webView21_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(444, 47);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 8;
            label2.Text = "Device";
            // 
            // comboBox_Device
            // 
            comboBox_Device.FormattingEnabled = true;
            comboBox_Device.Items.AddRange(new object[] { "Desktop", "Mobile", "Tablet" });
            comboBox_Device.Location = new Point(504, 41);
            comboBox_Device.Name = "comboBox_Device";
            comboBox_Device.SelectedIndex = 0;
            comboBox_Device.Size = new Size(151, 28);
            comboBox_Device.TabIndex = 11;
            // 
            // Bai_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox_Device);
            Controls.Add(webView21);
            Controls.Add(button_Show);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox_Url);
            Name = "Bai_2";
            Text = "Bài 2";
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Show;
        private Label label1;
        private TextBox textBox_Url;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private Label label2;
        private ComboBox comboBox_Device;
    }
}