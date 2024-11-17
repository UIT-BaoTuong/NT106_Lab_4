namespace Lab_4
{
    partial class DashBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_Bai4 = new Button();
            button_Bai3 = new Button();
            button_Bai2 = new Button();
            button_Bai1 = new Button();
            SuspendLayout();
            // 
            // button_Bai4
            // 
            button_Bai4.Location = new Point(449, 247);
            button_Bai4.Name = "button_Bai4";
            button_Bai4.Size = new Size(170, 77);
            button_Bai4.TabIndex = 1;
            button_Bai4.Text = "Bài 3 Nâng Cao";
            button_Bai4.UseVisualStyleBackColor = true;
            button_Bai4.Click += button_Bai4_Click;
            // 
            // button_Bai3
            // 
            button_Bai3.Location = new Point(142, 247);
            button_Bai3.Name = "button_Bai3";
            button_Bai3.Size = new Size(170, 77);
            button_Bai3.TabIndex = 2;
            button_Bai3.Text = "Bài 3";
            button_Bai3.UseVisualStyleBackColor = true;
            button_Bai3.Click += button_Bai3_Click;
            // 
            // button_Bai2
            // 
            button_Bai2.Location = new Point(449, 107);
            button_Bai2.Name = "button_Bai2";
            button_Bai2.Size = new Size(170, 77);
            button_Bai2.TabIndex = 3;
            button_Bai2.Text = "Bài 2 ";
            button_Bai2.UseVisualStyleBackColor = true;
            button_Bai2.Click += button_Bai2_Click;
            // 
            // button_Bai1
            // 
            button_Bai1.Location = new Point(142, 107);
            button_Bai1.Name = "button_Bai1";
            button_Bai1.Size = new Size(170, 77);
            button_Bai1.TabIndex = 4;
            button_Bai1.Text = "Bài 1";
            button_Bai1.UseVisualStyleBackColor = true;
            button_Bai1.Click += button_Bai1_Click;
            // 
            // DashBoard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button_Bai4);
            Controls.Add(button_Bai3);
            Controls.Add(button_Bai2);
            Controls.Add(button_Bai1);
            Name = "DashBoard";
            Text = "Dashboard";
            ResumeLayout(false);
        }

        #endregion

        private Button button_Bai4;
        private Button button_Bai3;
        private Button button_Bai2;
        private Button button_Bai1;
    }
}
