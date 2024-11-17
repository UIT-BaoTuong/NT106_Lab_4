namespace Lab_4
{
    partial class Bai3_NangCao
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
            button_Get = new Button();
            label1 = new Label();
            textBox_Url = new TextBox();
            SuspendLayout();
            // 
            // richTextBox_Data
            // 
            richTextBox_Data.Location = new Point(39, 74);
            richTextBox_Data.Name = "richTextBox_Data";
            richTextBox_Data.Size = new Size(722, 347);
            richTextBox_Data.TabIndex = 20;
            richTextBox_Data.Text = "";
            // 
            // button_Get
            // 
            button_Get.Location = new Point(667, 29);
            button_Get.Name = "button_Get";
            button_Get.Size = new Size(94, 29);
            button_Get.TabIndex = 19;
            button_Get.Text = "GetAPI";
            button_Get.UseVisualStyleBackColor = true;
            button_Get.Click += button_Get_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 36);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 18;
            label1.Text = "Web URL";
            // 
            // textBox_Url
            // 
            textBox_Url.Location = new Point(114, 29);
            textBox_Url.Name = "textBox_Url";
            textBox_Url.Size = new Size(528, 27);
            textBox_Url.TabIndex = 17;
            // 
            // Bai3_NangCao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox_Data);
            Controls.Add(button_Get);
            Controls.Add(label1);
            Controls.Add(textBox_Url);
            Name = "Bai3_NangCao";
            Text = "Bài 3 Nâng Cao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox_Data;
        private Button button_Get;
        private Label label1;
        private TextBox textBox_Url;
    }
}