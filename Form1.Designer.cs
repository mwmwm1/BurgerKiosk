namespace BurgerKiosk
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            rbBurger1 = new RadioButton();
            rbBurger2 = new RadioButton();
            rbBurger3 = new RadioButton();
            cbFries = new CheckBox();
            cbCoke = new CheckBox();
            cbCheese = new CheckBox();
            cbSauce = new CheckBox();
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            lblTotal = new Label();
            lstOrder = new ListBox();
            btnOrder = new Button();
            btnReset = new Button();
            lblAppname = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // rbBurger1
            // 
            rbBurger1.Location = new Point(27, 32);
            rbBurger1.Name = "rbBurger1";
            rbBurger1.Size = new Size(104, 24);
            rbBurger1.TabIndex = 0;
            rbBurger1.TabStop = true;
            rbBurger1.Text = "햄버거";
            rbBurger1.UseVisualStyleBackColor = true;
            rbBurger1.CheckedChanged += rbBurger1_CheckedChanged;
            // 
            // rbBurger2
            // 
            rbBurger2.Location = new Point(27, 118);
            rbBurger2.Name = "rbBurger2";
            rbBurger2.Size = new Size(114, 19);
            rbBurger2.TabIndex = 1;
            rbBurger2.TabStop = true;
            rbBurger2.Text = "불고기버거";
            rbBurger2.UseVisualStyleBackColor = true;
            rbBurger2.CheckedChanged += rbBurger2_CheckedChanged;
            // 
            // rbBurger3
            // 
            rbBurger3.Location = new Point(27, 199);
            rbBurger3.Name = "rbBurger3";
            rbBurger3.Size = new Size(95, 19);
            rbBurger3.TabIndex = 2;
            rbBurger3.TabStop = true;
            rbBurger3.Text = "치킨버거";
            rbBurger3.UseVisualStyleBackColor = true;
            rbBurger3.CheckedChanged += rbBurger3_CheckedChanged;
            // 
            // cbFries
            // 
            cbFries.AutoSize = true;
            cbFries.Location = new Point(36, 37);
            cbFries.Name = "cbFries";
            cbFries.Size = new Size(74, 19);
            cbFries.TabIndex = 3;
            cbFries.Text = "감자튀김";
            cbFries.UseVisualStyleBackColor = true;
            cbFries.CheckedChanged += cbFries_CheckedChanged;
            // 
            // cbCoke
            // 
            cbCoke.AutoSize = true;
            cbCoke.Location = new Point(36, 91);
            cbCoke.Name = "cbCoke";
            cbCoke.Size = new Size(50, 19);
            cbCoke.TabIndex = 4;
            cbCoke.Text = "콜라";
            cbCoke.UseVisualStyleBackColor = true;
            cbCoke.CheckedChanged += cbCoke_CheckedChanged;
            // 
            // cbCheese
            // 
            cbCheese.AutoSize = true;
            cbCheese.Location = new Point(36, 138);
            cbCheese.Name = "cbCheese";
            cbCheese.Size = new Size(78, 19);
            cbCheese.TabIndex = 5;
            cbCheese.Text = "치즈 추가";
            cbCheese.UseVisualStyleBackColor = true;
            cbCheese.CheckedChanged += cbCheese_CheckedChanged;
            // 
            // cbSauce
            // 
            cbSauce.AutoSize = true;
            cbSauce.Location = new Point(36, 185);
            cbSauce.Name = "cbSauce";
            cbSauce.Size = new Size(78, 19);
            cbSauce.TabIndex = 6;
            cbSauce.Text = "소스 추가";
            cbSauce.UseVisualStyleBackColor = true;
            cbSauce.CheckedChanged += cbSauce_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(pictureBox3);
            groupBox1.Controls.Add(pictureBox2);
            groupBox1.Controls.Add(rbBurger3);
            groupBox1.Controls.Add(rbBurger1);
            groupBox1.Controls.Add(rbBurger2);
            groupBox1.Location = new Point(12, 90);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(246, 307);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "메뉴 선택";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(137, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(77, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(137, 199);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(77, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(137, 118);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(77, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbFries);
            groupBox2.Controls.Add(cbCoke);
            groupBox2.Controls.Add(cbCheese);
            groupBox2.Controls.Add(cbSauce);
            groupBox2.Location = new Point(264, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(197, 249);
            groupBox2.TabIndex = 8;
            groupBox2.TabStop = false;
            groupBox2.Text = "추가 옵션";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblTotal);
            groupBox3.Controls.Add(lstOrder);
            groupBox3.Location = new Point(503, 90);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(246, 235);
            groupBox3.TabIndex = 9;
            groupBox3.TabStop = false;
            groupBox3.Text = "주문 내역";
            // 
            // lblTotal
            // 
            lblTotal.ForeColor = Color.Blue;
            lblTotal.Location = new Point(23, 201);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(194, 23);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "총 금액 : 0원";
            // 
            // lstOrder
            // 
            lstOrder.FormattingEnabled = true;
            lstOrder.Location = new Point(23, 40);
            lstOrder.Name = "lstOrder";
            lstOrder.Size = new Size(194, 139);
            lstOrder.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Chartreuse;
            btnOrder.Location = new Point(503, 348);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(134, 37);
            btnOrder.TabIndex = 10;
            btnOrder.Text = "주문하기";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Tomato;
            btnReset.Location = new Point(651, 348);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(98, 37);
            btnReset.TabIndex = 11;
            btnReset.Text = "초기화";
            btnReset.UseVisualStyleBackColor = false;
            btnReset.Click += btnReset_Click;
            // 
            // lblAppname
            // 
            lblAppname.AutoSize = true;
            lblAppname.Font = new Font("맑은 고딕", 18F);
            lblAppname.Location = new Point(12, 20);
            lblAppname.Name = "lblAppname";
            lblAppname.Size = new Size(222, 32);
            lblAppname.TabIndex = 12;
            lblAppname.Text = "버거 주문 키오스크";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblAppname);
            Controls.Add(btnReset);
            Controls.Add(btnOrder);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Burger Kiosk v1.0";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbBurger1;
        private RadioButton rbBurger2;
        private RadioButton rbBurger3;
        private CheckBox cbFries;
        private CheckBox cbCoke;
        private CheckBox cbCheese;
        private CheckBox cbSauce;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button btnOrder;
        private Button btnReset;
        private Label lblAppname;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private ListBox lstOrder;
        private Label lblTotal;
    }
}
