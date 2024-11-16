namespace Lab_4
{
    partial class Bai_3
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
            button_Get = new Button();
            label1 = new Label();
            textBox_Url = new TextBox();
            richTextBox_Data = new RichTextBox();
            SuspendLayout();
            // 
            // button_Get
            // 
            button_Get.Location = new Point(649, 28);
            button_Get.Name = "button_Get";
            button_Get.Size = new Size(94, 29);
            button_Get.TabIndex = 15;
            button_Get.Text = "GetAPI";
            button_Get.UseVisualStyleBackColor = true;
            button_Get.Click += button_Get_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 35);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 14;
            label1.Text = "Web URL";
            // 
            // textBox_Url
            // 
            textBox_Url.Location = new Point(96, 28);
            textBox_Url.Name = "textBox_Url";
            textBox_Url.Size = new Size(528, 27);
            textBox_Url.TabIndex = 12;

            // 
            // richTextBox_Data
            // 
            richTextBox_Data.Location = new Point(21, 73);
            richTextBox_Data.Name = "richTextBox_Data";
            richTextBox_Data.Size = new Size(722, 347);
            richTextBox_Data.TabIndex = 16;
            richTextBox_Data.Text = "";
            // 
            // Bai_3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox_Data);
            Controls.Add(button_Get);
            Controls.Add(label1);
            Controls.Add(textBox_Url);
            Name = "Bai_3";
            Text = "Bài 3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_Get;
        private Label label1;
        private TextBox textBox_Url;
        private RichTextBox richTextBox_Data;
    }
}