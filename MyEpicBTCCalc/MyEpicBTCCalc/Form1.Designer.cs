namespace MyEpicBTCCalc
{
    partial class bitcoinAmountInput
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
            label1 = new Label();
            currencySelector = new ComboBox();
            toCurrencyLable = new Label();
            getRate = new Button();
            bitcoinResultLable = new Label();
            resultDisplayLable = new Label();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 16);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 1;
            label1.Text = "Bitcoini kogus:";
            // 
            // currencySelector
            // 
            currencySelector.AutoCompleteCustomSource.AddRange(new string[] { "EUR", "USD" });
            currencySelector.FormattingEnabled = true;
            currencySelector.Items.AddRange(new object[] { "EUR", "USD" });
            currencySelector.Location = new Point(37, 99);
            currencySelector.Name = "currencySelector";
            currencySelector.Size = new Size(121, 23);
            currencySelector.TabIndex = 2;
            currencySelector.Text = "USD";
            currencySelector.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // toCurrencyLable
            // 
            toCurrencyLable.AutoSize = true;
            toCurrencyLable.Location = new Point(37, 81);
            toCurrencyLable.Name = "toCurrencyLable";
            toCurrencyLable.Size = new Size(69, 15);
            toCurrencyLable.TabIndex = 3;
            toCurrencyLable.Text = "Sihtvaluuta:";
            // 
            // getRate
            // 
            getRate.Location = new Point(158, 145);
            getRate.Name = "getRate";
            getRate.Size = new Size(75, 23);
            getRate.TabIndex = 4;
            getRate.Text = "Arvuta";
            getRate.UseVisualStyleBackColor = true;
            // 
            // bitcoinResultLable
            // 
            bitcoinResultLable.AutoSize = true;
            bitcoinResultLable.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 186);
            bitcoinResultLable.Location = new Point(12, 511);
            bitcoinResultLable.Name = "bitcoinResultLable";
            bitcoinResultLable.Size = new Size(78, 32);
            bitcoinResultLable.TabIndex = 5;
            bitcoinResultLable.Text = "label1";
            bitcoinResultLable.Click += bitcoinResultLable_Click;
            // 
            // resultDisplayLable
            // 
            resultDisplayLable.AutoSize = true;
            resultDisplayLable.BackColor = Color.White;
            resultDisplayLable.Location = new Point(12, 496);
            resultDisplayLable.Name = "resultDisplayLable";
            resultDisplayLable.Size = new Size(103, 15);
            resultDisplayLable.TabIndex = 6;
            resultDisplayLable.Text = "Arvutuse tulemus:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 34);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // bitcoinAmountInput
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.bitcoin_2;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(388, 552);
            Controls.Add(textBox1);
            Controls.Add(resultDisplayLable);
            Controls.Add(bitcoinResultLable);
            Controls.Add(getRate);
            Controls.Add(toCurrencyLable);
            Controls.Add(currencySelector);
            Controls.Add(label1);
            Name = "bitcoinAmountInput";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox bitcoinAmountinput;
        private Label label1;
        private ComboBox currencySelector;
        private Label toCurrencyLable;
        private Button getRate;
        private Label bitcoinResultLable;
        private Label resultDisplayLable;
        private TextBox textBox1;
    }
}
