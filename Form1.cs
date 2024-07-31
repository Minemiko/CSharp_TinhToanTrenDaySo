namespace CSharp_TinhToanTrenDaySo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtSbd.Text);
            double b = Convert.ToDouble(txtSkt.Text);
            double Tong = 0;
            double Tich = 1;
            double TongC = 0;
            double TongL = 0;
            for (double i = a; i <= b; i++)
            {
                Tong += i;
                Tich *= i;
                if (i % 2 == 0)
                {
                    TongC += i;
                }
                else
                {
                    TongL += i;
                }
            }
            txtTong.Text = Tong.ToString();
            txtTich.Text = Tich.ToString();
            txtTongC.Text = TongC.ToString();
            txtTongL.Text = TongL.ToString();
        }
    }
}
