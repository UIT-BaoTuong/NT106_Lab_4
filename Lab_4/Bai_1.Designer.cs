namespace Lab_4
{
    partial class Bai_1
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
            richTextBox_Data = new RichTextBox();
            dataGridView_Header = new DataGridView();
            textBox_Url = new TextBox();
            label1 = new Label();
            button_Download = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Header).BeginInit();
            SuspendLayout();
            // 
            // richTextBox_Data
            // 
            richTextBox_Data.Location = new Point(12, 97);
            richTextBox_Data.Name = "richTextBox_Data";
            richTextBox_Data.Size = new Size(427, 312);
            richTextBox_Data.TabIndex = 0;
            richTextBox_Data.Text = "";
            // 
            // dataGridView_Header
            // 
            dataGridView_Header.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Header.Location = new Point(464, 97);
            dataGridView_Header.Name = "dataGridView_Header";
            dataGridView_Header.RowHeadersWidth = 51;
            dataGridView_Header.Size = new Size(324, 312);
            dataGridView_Header.TabIndex = 1;
            // 
            // textBox_Url
            // 
            textBox_Url.Location = new Point(87, 36);
            textBox_Url.Name = "textBox_Url";
            textBox_Url.Size = new Size(352, 27);
            textBox_Url.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 43);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 3;
            label1.Text = "Web URL";
            // 
            // button_Download
            // 
            button_Download.Location = new Point(464, 34);
            button_Download.Name = "button_Download";
            button_Download.Size = new Size(94, 29);
            button_Download.TabIndex = 4;
            button_Download.Text = "Download";
            button_Download.UseVisualStyleBackColor = true;
            button_Download.Click += button_Download_Click;
            // 
            // Bai_1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Download);
            Controls.Add(label1);
            Controls.Add(textBox_Url);
            Controls.Add(dataGridView_Header);
            Controls.Add(richTextBox_Data);
            Name = "Bai_1";
            Text = "Bài 1";
            ((System.ComponentModel.ISupportInitialize)dataGridView_Header).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox_Data;
        private DataGridView dataGridView_Header;
        private TextBox textBox_Url;
        private Label label1;
        private Button button_Download;
    }
}