namespace Lab_4
{
    public partial class DashBoard : Form
    {
        public DashBoard()
        {
            InitializeComponent();
        }

        private void button_Bai1_Click(object sender, EventArgs e)
        {
            Bai_1 bai_1 = new Bai_1();
            bai_1.Show();
        }

        private void button_Bai2_Click(object sender, EventArgs e)
        {
            Bai_2 bai_2 = new Bai_2();
            bai_2.Show();
        }

        private void button_Bai3_Click(object sender, EventArgs e)
        {
            Bai_3 bai_3 = new Bai_3();
            bai_3.Show();
        }

        private void button_Bai4_Click(object sender, EventArgs e)
        {
            Bai3_NangCao bai3_NangCao = new Bai3_NangCao();
            bai3_NangCao.Show();
        }
    }
}
