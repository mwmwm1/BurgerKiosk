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
            lblError.Text = "";
            lstOrder.Items.Clear(); // 리스트박스 초기화는 유지 (안 쓰더라도 비워줌)
            finalAmount = 0;

            // 버거 선택 확인 - 금액 계산만 남겨둡니다.
            if (rbBurger1.Checked)
            {
                 lstOrder.Items.Add("햄버거: 5,000원"); // 주석 처리
                finalAmount += 5000;
            }
            else if (rbBurger2.Checked)
            {
                lstOrder.Items.Add("불고기버거: 4,000원");
                finalAmount += 4000;
            }
            else if (rbBurger3.Checked)
            {
                lstOrder.Items.Add("치킨버거 : 3,000원");
                finalAmount += 3000;
            }

            // 추가 옵션 선택 확인 - 금액 계산만 남겨둡니다.
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
            if (!rbBurger1.Checked && !rbBurger2.Checked && !rbBurger3.Checked)
            {
                lblError.Text = "메뉴를 선택해주세요.";
                lblTotal.Text = "총 금액: 0원";
                return; // 아래 코드를 실행하지 않고 함수를 종료함
            }

            // 정상 선택된 경우 (에러 메시지 지우기)
            lblError.Text = "";

            // 최종 금액 표시
            lblTotal.Text = $"총 금액: {finalAmount:N0}원";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rbBurger1.Checked = false;
            rbBurger2.Checked = false;
            rbBurger3.Checked = false;
            this.ActiveControl = rbBurger1;

            // 리스트박스와 금액도 깨끗하게 비우기
            lstOrder.Items.Clear();
            finalAmount = 0;
            lblTotal.Text = "총 금액: 0원";
        }
    }

}