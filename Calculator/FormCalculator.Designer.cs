namespace Calculator
{
    partial class FormCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculator));
            txtScoreboard = new TextBox();
            btnOne = new Button();
            btnTwo = new Button();
            btnThree = new Button();
            btnFour = new Button();
            btnFive = new Button();
            btnSix = new Button();
            btnSeven = new Button();
            btnEight = new Button();
            btnNine = new Button();
            btnZero = new Button();
            btnDecimalPoint = new Button();
            btnEqualSign = new Button();
            btnCleanEntry = new Button();
            btnCancel = new Button();
            btnNumberSign = new Button();
            btnAddition = new Button();
            btnSubtraction = new Button();
            btnMultiplication = new Button();
            btnDivision = new Button();
            txtBoxValue = new TextBox();
            SuspendLayout();
            // 
            // txtScoreboard
            // 
            txtScoreboard.Location = new Point(10, 32);
            txtScoreboard.Margin = new Padding(3, 2, 3, 2);
            txtScoreboard.MaxLength = 20;
            txtScoreboard.Name = "txtScoreboard";
            txtScoreboard.Size = new Size(226, 23);
            txtScoreboard.TabIndex = 0;
            txtScoreboard.TextAlign = HorizontalAlignment.Right;
            txtScoreboard.KeyPress += TxtScoreboard_KeyPress;
            // 
            // btnOne
            // 
            btnOne.BackColor = SystemColors.HighlightText;
            btnOne.Location = new Point(10, 205);
            btnOne.Margin = new Padding(3, 2, 3, 2);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(52, 45);
            btnOne.TabIndex = 1;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += BtnNumber_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = SystemColors.HighlightText;
            btnTwo.Location = new Point(68, 205);
            btnTwo.Margin = new Padding(3, 2, 3, 2);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(52, 45);
            btnTwo.TabIndex = 2;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += BtnNumber_Click;
            // 
            // btnThree
            // 
            btnThree.BackColor = SystemColors.HighlightText;
            btnThree.Location = new Point(126, 205);
            btnThree.Margin = new Padding(3, 2, 3, 2);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(52, 45);
            btnThree.TabIndex = 3;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += BtnNumber_Click;
            // 
            // btnFour
            // 
            btnFour.BackColor = SystemColors.HighlightText;
            btnFour.Location = new Point(10, 155);
            btnFour.Margin = new Padding(3, 2, 3, 2);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(52, 45);
            btnFour.TabIndex = 4;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += BtnNumber_Click;
            // 
            // btnFive
            // 
            btnFive.BackColor = SystemColors.HighlightText;
            btnFive.Location = new Point(68, 155);
            btnFive.Margin = new Padding(3, 2, 3, 2);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(52, 45);
            btnFive.TabIndex = 5;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += BtnNumber_Click;
            // 
            // btnSix
            // 
            btnSix.BackColor = SystemColors.HighlightText;
            btnSix.Location = new Point(126, 155);
            btnSix.Margin = new Padding(3, 2, 3, 2);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(52, 45);
            btnSix.TabIndex = 6;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += BtnNumber_Click;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = SystemColors.HighlightText;
            btnSeven.Location = new Point(10, 106);
            btnSeven.Margin = new Padding(3, 2, 3, 2);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(52, 45);
            btnSeven.TabIndex = 7;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += BtnNumber_Click;
            // 
            // btnEight
            // 
            btnEight.BackColor = SystemColors.HighlightText;
            btnEight.Location = new Point(68, 106);
            btnEight.Margin = new Padding(3, 2, 3, 2);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(52, 45);
            btnEight.TabIndex = 8;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += BtnNumber_Click;
            // 
            // btnNine
            // 
            btnNine.BackColor = SystemColors.HighlightText;
            btnNine.Location = new Point(126, 106);
            btnNine.Margin = new Padding(3, 2, 3, 2);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(52, 45);
            btnNine.TabIndex = 9;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += BtnNumber_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = SystemColors.HighlightText;
            btnZero.Location = new Point(68, 254);
            btnZero.Margin = new Padding(3, 2, 3, 2);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(52, 45);
            btnZero.TabIndex = 10;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += BtnNumber_Click;
            // 
            // btnDecimalPoint
            // 
            btnDecimalPoint.BackColor = SystemColors.HighlightText;
            btnDecimalPoint.Location = new Point(10, 254);
            btnDecimalPoint.Margin = new Padding(3, 2, 3, 2);
            btnDecimalPoint.Name = "btnDecimalPoint";
            btnDecimalPoint.Size = new Size(52, 45);
            btnDecimalPoint.TabIndex = 11;
            btnDecimalPoint.Text = ".";
            btnDecimalPoint.UseVisualStyleBackColor = false;
            btnDecimalPoint.Click += BtnDecimalPoint_Click;
            // 
            // btnEqualSign
            // 
            btnEqualSign.BackColor = SystemColors.HighlightText;
            btnEqualSign.Location = new Point(126, 254);
            btnEqualSign.Margin = new Padding(3, 2, 3, 2);
            btnEqualSign.Name = "btnEqualSign";
            btnEqualSign.Size = new Size(110, 45);
            btnEqualSign.TabIndex = 12;
            btnEqualSign.Text = "=";
            btnEqualSign.UseVisualStyleBackColor = false;
            btnEqualSign.Click += BtnEqualSign_Click;
            // 
            // btnCleanEntry
            // 
            btnCleanEntry.BackColor = SystemColors.HighlightText;
            btnCleanEntry.Location = new Point(10, 56);
            btnCleanEntry.Margin = new Padding(3, 2, 3, 2);
            btnCleanEntry.Name = "btnCleanEntry";
            btnCleanEntry.Size = new Size(52, 45);
            btnCleanEntry.TabIndex = 13;
            btnCleanEntry.Text = "CE";
            btnCleanEntry.UseVisualStyleBackColor = false;
            btnCleanEntry.Click += BtnCleanEntry_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.HighlightText;
            btnCancel.BackgroundImageLayout = ImageLayout.Zoom;
            btnCancel.Image = (Image)resources.GetObject("btnCancel.Image");
            btnCancel.Location = new Point(68, 56);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(52, 45);
            btnCancel.TabIndex = 14;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += BtnCancel_Click;
            // 
            // btnNumberSign
            // 
            btnNumberSign.BackColor = SystemColors.HighlightText;
            btnNumberSign.Location = new Point(126, 56);
            btnNumberSign.Margin = new Padding(3, 2, 3, 2);
            btnNumberSign.Name = "btnNumberSign";
            btnNumberSign.Size = new Size(52, 45);
            btnNumberSign.TabIndex = 15;
            btnNumberSign.Text = "+/-";
            btnNumberSign.UseVisualStyleBackColor = false;
            btnNumberSign.Click += BtnNumberSign_Click;
            // 
            // btnAddition
            // 
            btnAddition.BackColor = SystemColors.HighlightText;
            btnAddition.Location = new Point(184, 56);
            btnAddition.Margin = new Padding(3, 2, 3, 2);
            btnAddition.Name = "btnAddition";
            btnAddition.Size = new Size(52, 45);
            btnAddition.TabIndex = 16;
            btnAddition.Text = "+";
            btnAddition.UseVisualStyleBackColor = false;
            btnAddition.Click += BtnArithmeticOperation_Click;
            // 
            // btnSubtraction
            // 
            btnSubtraction.BackColor = SystemColors.HighlightText;
            btnSubtraction.Location = new Point(184, 106);
            btnSubtraction.Margin = new Padding(3, 2, 3, 2);
            btnSubtraction.Name = "btnSubtraction";
            btnSubtraction.Size = new Size(52, 45);
            btnSubtraction.TabIndex = 17;
            btnSubtraction.Text = "-";
            btnSubtraction.UseVisualStyleBackColor = false;
            btnSubtraction.Click += BtnArithmeticOperation_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.BackColor = SystemColors.HighlightText;
            btnMultiplication.Location = new Point(184, 155);
            btnMultiplication.Margin = new Padding(3, 2, 3, 2);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(52, 45);
            btnMultiplication.TabIndex = 18;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = false;
            btnMultiplication.Click += BtnArithmeticOperation_Click;
            // 
            // btnDivision
            // 
            btnDivision.BackColor = SystemColors.HighlightText;
            btnDivision.Location = new Point(184, 205);
            btnDivision.Margin = new Padding(3, 2, 3, 2);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(52, 45);
            btnDivision.TabIndex = 19;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = false;
            btnDivision.Click += BtnArithmeticOperation_Click;
            // 
            // txtBoxValue
            // 
            txtBoxValue.Location = new Point(68, 8);
            txtBoxValue.Margin = new Padding(3, 2, 3, 2);
            txtBoxValue.MaxLength = 15;
            txtBoxValue.Name = "txtBoxValue";
            txtBoxValue.ReadOnly = true;
            txtBoxValue.Size = new Size(168, 23);
            txtBoxValue.TabIndex = 20;
            txtBoxValue.TextAlign = HorizontalAlignment.Right;
            // 
            // FormCalculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(248, 308);
            Controls.Add(txtBoxValue);
            Controls.Add(btnDivision);
            Controls.Add(btnMultiplication);
            Controls.Add(btnSubtraction);
            Controls.Add(btnAddition);
            Controls.Add(btnNumberSign);
            Controls.Add(btnCancel);
            Controls.Add(btnCleanEntry);
            Controls.Add(btnEqualSign);
            Controls.Add(btnDecimalPoint);
            Controls.Add(btnZero);
            Controls.Add(btnNine);
            Controls.Add(btnEight);
            Controls.Add(btnSeven);
            Controls.Add(btnSix);
            Controls.Add(btnFive);
            Controls.Add(btnFour);
            Controls.Add(btnThree);
            Controls.Add(btnTwo);
            Controls.Add(btnOne);
            Controls.Add(txtScoreboard);
            Margin = new Padding(3, 2, 3, 2);
            MaximumSize = new Size(264, 347);
            MinimumSize = new Size(264, 347);
            Name = "FormCalculator";
            Text = "Калькулятор";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtScoreboard;
        private Button btnOne;
        private Button btnTwo;
        private Button btnThree;
        private Button btnFour;
        private Button btnFive;
        private Button btnSix;
        private Button btnSeven;
        private Button btnEight;
        private Button btnNine;
        private Button btnZero;
        private Button btnDecimalPoint;
        private Button btnEqualSign;
        private Button btnCleanEntry;
        private Button btnCancel;
        private Button btnNumberSign;
        private Button btnAddition;
        private Button btnSubtraction;
        private Button btnMultiplication;
        private Button btnDivision;
        private TextBox txtBoxValue;
    }
}