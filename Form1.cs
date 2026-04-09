namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        int finalAmount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rbBurger1.Checked = true;
            cbFries.Checked = false;
            cbCoke.Checked = false;
            cbCheese.Checked = false;
            cbSauce.Checked = false;

            UpdateOrder();
            lblTotal.Text = "총 금액: 0원";
        }

        private void rbBurger1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrder();
        }

        private void UpdateOrder()
        {
            // 리스트박스와 합계 초기화
            lstOrder.Items.Clear(); 
            finalAmount = 0; // 클래스 변수인 finalAmount를 초기화

            // 버거 선택 확인
            if (rbBurger1.Checked)
            {
                lstOrder.Items.Add("버거 1 : 5,000원");
                finalAmount += 5000;
            }
            else if (rbBurger2.Checked)
            {
                lstOrder.Items.Add("버거 2 : 4,000원");
                finalAmount += 4000;
            }
            else if (rbBurger3.Checked)
            {
                lstOrder.Items.Add("버거 3 : 3,000원");
                finalAmount += 3000;
            }

            // 추가 옵션 선택 확인
            if (cbFries.Checked)
            {
                lstOrder.Items.Add("+ 감자튀김 : 2,000원");
                finalAmount += 2000;
            }
            if (cbCoke.Checked)
            {
                lstOrder.Items.Add("+ 콜라 : 2,000원");
                finalAmount += 2000;
            }
            if (cbCheese.Checked)
            {
                lstOrder.Items.Add("+ 치즈 : 1,000원");
                finalAmount += 1000;
            }
            if (cbSauce.Checked)
            {
                lstOrder.Items.Add("+ 소스 : 1,000원");
                finalAmount += 1000;
            }

        }

        private void cbFries_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrder();
        }

        private void cbCoke_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrder();
        }

        private void cbCheese_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrder();
        }

        private void cbSauce_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrder();
        }

        private void rbBurger2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrder();
        }

        private void rbBurger3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateOrder();
        }
        private void btnOrder_Click(object sender, EventArgs e)
        {
            lblTotal.Text = $"총 금액: {finalAmount:N0}원";
        }
    }

}