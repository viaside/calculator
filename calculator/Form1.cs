namespace calculator
{
    public partial class form1 : Form
    {
        ConvertNum cn = new ConvertNum();
        public form1()
        {
            InitializeComponent();
        }

        private void num1_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(cn.Num1(1));
        }

        private void num2_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(cn.Num1(2));
        }

        private void num3_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(cn.Num1(3));
        }

        private void num4_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(cn.Num1(4));
        }

        private void num5_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(cn.Num1(5));
        }

        private void num6_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(cn.Num1(6));
        }

        private void num7_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(cn.Num1(7));
        }

        private void num8_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(cn.Num1(8));
        }

        private void num9_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(cn.Num1(9));
        }

        private void num0_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(cn.Num1(0));
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void division_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(cn.Oper('/'));
        }

        private void multiplication_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(cn.Oper('*'));
        }

        private void plus_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(cn.Oper('+'));
        }

        private void minus_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(cn.Oper('-'));
        }

        private void result_Click(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(cn.operation());
        }

        private void clear_Click(object sender, EventArgs e)
        {
            cn.Clear();
            label1.Text = String.Empty;
        }
    }
}