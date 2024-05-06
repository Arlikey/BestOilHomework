namespace BestOilHomework
{
    partial class AdditionalTask2
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
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            depositPeriodNumericUpDown = new NumericUpDown();
            interestRateNumericUpDown = new NumericUpDown();
            depositAmountNumericUpDown = new NumericUpDown();
            label2 = new Label();
            label1 = new Label();
            finalAmountTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)depositPeriodNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)interestRateNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)depositAmountNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(depositPeriodNumericUpDown);
            panel1.Controls.Add(interestRateNumericUpDown);
            panel1.Controls.Add(depositAmountNumericUpDown);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(finalAmountTextBox);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(326, 331);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label5.Location = new Point(275, 150);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 5;
            label5.Text = "%";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label6.Location = new Point(41, 193);
            label6.Name = "label6";
            label6.Size = new Size(167, 20);
            label6.TabIndex = 5;
            label6.Text = "Срок вклада (в годах):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(41, 150);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 5;
            label4.Text = "Процентная ставка :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(41, 105);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 5;
            label3.Text = "Сумма вклада :";
            // 
            // depositPeriodNumericUpDown
            // 
            depositPeriodNumericUpDown.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            depositPeriodNumericUpDown.Location = new Point(214, 191);
            depositPeriodNumericUpDown.Name = "depositPeriodNumericUpDown";
            depositPeriodNumericUpDown.Size = new Size(55, 27);
            depositPeriodNumericUpDown.TabIndex = 4;
            depositPeriodNumericUpDown.ValueChanged += numericUpDown_ValueChanged;
            // 
            // interestRateNumericUpDown
            // 
            interestRateNumericUpDown.DecimalPlaces = 2;
            interestRateNumericUpDown.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            interestRateNumericUpDown.Location = new Point(199, 148);
            interestRateNumericUpDown.Name = "interestRateNumericUpDown";
            interestRateNumericUpDown.Size = new Size(70, 27);
            interestRateNumericUpDown.TabIndex = 4;
            interestRateNumericUpDown.ValueChanged += numericUpDown_ValueChanged;
            // 
            // depositAmountNumericUpDown
            // 
            depositAmountNumericUpDown.DecimalPlaces = 2;
            depositAmountNumericUpDown.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            depositAmountNumericUpDown.Location = new Point(164, 103);
            depositAmountNumericUpDown.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            depositAmountNumericUpDown.Name = "depositAmountNumericUpDown";
            depositAmountNumericUpDown.Size = new Size(105, 27);
            depositAmountNumericUpDown.TabIndex = 4;
            depositAmountNumericUpDown.ValueChanged += numericUpDown_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(229, 299);
            label2.Name = "label2";
            label2.Size = new Size(37, 20);
            label2.TabIndex = 3;
            label2.Text = "грн.";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(41, 293);
            label1.Name = "label1";
            label1.Size = new Size(78, 21);
            label1.TabIndex = 2;
            label1.Text = "СУММА :";
            // 
            // finalAmountTextBox
            // 
            finalAmountTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            finalAmountTextBox.Location = new Point(125, 290);
            finalAmountTextBox.Name = "finalAmountTextBox";
            finalAmountTextBox.ReadOnly = true;
            finalAmountTextBox.Size = new Size(98, 29);
            finalAmountTextBox.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Image = Properties.Resources.free_icon_bank_4439453;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(326, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // AdditionalTask2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(326, 331);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdditionalTask2";
            Text = "Банковские вклады";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)depositPeriodNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)interestRateNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)depositAmountNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox finalAmountTextBox;
        private NumericUpDown depositAmountNumericUpDown;
        private Label label5;
        private Label label4;
        private Label label3;
        private NumericUpDown interestRateNumericUpDown;
        private Label label6;
        private NumericUpDown depositPeriodNumericUpDown;
    }
}