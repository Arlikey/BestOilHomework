namespace BestOilHomework
{
    partial class BestOilForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestOilForm));
            gasStationGroupBox = new GroupBox();
            sumGasolineNumericUpDown = new NumericUpDown();
            countGasolineNumericUpDown = new NumericUpDown();
            gasolinePayGroupBox = new GroupBox();
            totalGasolineUnitsLabel = new Label();
            unitsLabel = new Label();
            countOrSumGroupBox = new GroupBox();
            sumRadioButton = new RadioButton();
            countRadioButton = new RadioButton();
            priceTextBox = new TextBox();
            gasolinesComboBox = new ComboBox();
            litresLabel = new Label();
            hrnLabel2 = new Label();
            hrnLabel = new Label();
            priceLabel = new Label();
            gasolineLabel = new Label();
            totalToPayGroupBox = new GroupBox();
            pictureBox1 = new PictureBox();
            payButton = new Button();
            totalToPayLabel = new Label();
            hrnLabel4 = new Label();
            miniCafeGroupBox = new GroupBox();
            countMinicafeLabel = new Label();
            priceMinicafeLabel = new Label();
            miniCafePayGroupBox = new GroupBox();
            totalMiniCafePriceLabel = new Label();
            hrnLabel3 = new Label();
            gasStationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sumGasolineNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)countGasolineNumericUpDown).BeginInit();
            gasolinePayGroupBox.SuspendLayout();
            countOrSumGroupBox.SuspendLayout();
            totalToPayGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            miniCafeGroupBox.SuspendLayout();
            miniCafePayGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // gasStationGroupBox
            // 
            gasStationGroupBox.Controls.Add(sumGasolineNumericUpDown);
            gasStationGroupBox.Controls.Add(countGasolineNumericUpDown);
            gasStationGroupBox.Controls.Add(gasolinePayGroupBox);
            gasStationGroupBox.Controls.Add(countOrSumGroupBox);
            gasStationGroupBox.Controls.Add(priceTextBox);
            gasStationGroupBox.Controls.Add(gasolinesComboBox);
            gasStationGroupBox.Controls.Add(litresLabel);
            gasStationGroupBox.Controls.Add(hrnLabel2);
            gasStationGroupBox.Controls.Add(hrnLabel);
            gasStationGroupBox.Controls.Add(priceLabel);
            gasStationGroupBox.Controls.Add(gasolineLabel);
            gasStationGroupBox.Location = new Point(31, 12);
            gasStationGroupBox.Name = "gasStationGroupBox";
            gasStationGroupBox.Size = new Size(259, 295);
            gasStationGroupBox.TabIndex = 0;
            gasStationGroupBox.TabStop = false;
            gasStationGroupBox.Text = "Автозаправка";
            // 
            // sumGasolineNumericUpDown
            // 
            sumGasolineNumericUpDown.DecimalPlaces = 2;
            sumGasolineNumericUpDown.Enabled = false;
            sumGasolineNumericUpDown.Location = new Point(124, 173);
            sumGasolineNumericUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            sumGasolineNumericUpDown.Name = "sumGasolineNumericUpDown";
            sumGasolineNumericUpDown.Size = new Size(72, 23);
            sumGasolineNumericUpDown.TabIndex = 5;
            sumGasolineNumericUpDown.ValueChanged += sumGasolineNumericUpDown_ValueChanged;
            // 
            // countGasolineNumericUpDown
            // 
            countGasolineNumericUpDown.DecimalPlaces = 2;
            countGasolineNumericUpDown.Location = new Point(124, 138);
            countGasolineNumericUpDown.Maximum = new decimal(new int[] { 500, 0, 0, 0 });
            countGasolineNumericUpDown.Name = "countGasolineNumericUpDown";
            countGasolineNumericUpDown.Size = new Size(72, 23);
            countGasolineNumericUpDown.TabIndex = 5;
            countGasolineNumericUpDown.ValueChanged += countGasolineNumericUpDown_ValueChanged;
            // 
            // gasolinePayGroupBox
            // 
            gasolinePayGroupBox.Controls.Add(totalGasolineUnitsLabel);
            gasolinePayGroupBox.Controls.Add(unitsLabel);
            gasolinePayGroupBox.Location = new Point(10, 219);
            gasolinePayGroupBox.Name = "gasolinePayGroupBox";
            gasolinePayGroupBox.Size = new Size(221, 70);
            gasolinePayGroupBox.TabIndex = 4;
            gasolinePayGroupBox.TabStop = false;
            gasolinePayGroupBox.Text = "К оплате :";
            // 
            // totalGasolineUnitsLabel
            // 
            totalGasolineUnitsLabel.AutoSize = true;
            totalGasolineUnitsLabel.Dock = DockStyle.Right;
            totalGasolineUnitsLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            totalGasolineUnitsLabel.Location = new Point(132, 19);
            totalGasolineUnitsLabel.Name = "totalGasolineUnitsLabel";
            totalGasolineUnitsLabel.Padding = new Padding(0, 0, 25, 0);
            totalGasolineUnitsLabel.Size = new Size(57, 37);
            totalGasolineUnitsLabel.TabIndex = 1;
            totalGasolineUnitsLabel.Text = "0";
            // 
            // unitsLabel
            // 
            unitsLabel.AutoSize = true;
            unitsLabel.Dock = DockStyle.Right;
            unitsLabel.Location = new Point(189, 19);
            unitsLabel.Name = "unitsLabel";
            unitsLabel.Padding = new Padding(0, 20, 0, 0);
            unitsLabel.Size = new Size(29, 35);
            unitsLabel.TabIndex = 0;
            unitsLabel.Text = "грн.";
            // 
            // countOrSumGroupBox
            // 
            countOrSumGroupBox.Controls.Add(sumRadioButton);
            countOrSumGroupBox.Controls.Add(countRadioButton);
            countOrSumGroupBox.Location = new Point(10, 126);
            countOrSumGroupBox.Name = "countOrSumGroupBox";
            countOrSumGroupBox.Size = new Size(108, 78);
            countOrSumGroupBox.TabIndex = 3;
            countOrSumGroupBox.TabStop = false;
            // 
            // sumRadioButton
            // 
            sumRadioButton.AutoSize = true;
            sumRadioButton.Location = new Point(8, 47);
            sumRadioButton.Name = "sumRadioButton";
            sumRadioButton.Size = new Size(54, 19);
            sumRadioButton.TabIndex = 0;
            sumRadioButton.Text = "Сума";
            sumRadioButton.UseVisualStyleBackColor = true;
            sumRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // countRadioButton
            // 
            countRadioButton.AutoSize = true;
            countRadioButton.Checked = true;
            countRadioButton.Location = new Point(8, 16);
            countRadioButton.Name = "countRadioButton";
            countRadioButton.Size = new Size(90, 19);
            countRadioButton.TabIndex = 0;
            countRadioButton.TabStop = true;
            countRadioButton.Text = "Количество";
            countRadioButton.UseVisualStyleBackColor = true;
            countRadioButton.CheckedChanged += RadioButton_CheckedChanged;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(75, 83);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.ReadOnly = true;
            priceTextBox.Size = new Size(121, 23);
            priceTextBox.TabIndex = 2;
            // 
            // gasolinesComboBox
            // 
            gasolinesComboBox.FormattingEnabled = true;
            gasolinesComboBox.Location = new Point(75, 41);
            gasolinesComboBox.Name = "gasolinesComboBox";
            gasolinesComboBox.Size = new Size(121, 23);
            gasolinesComboBox.TabIndex = 1;
            gasolinesComboBox.SelectedIndexChanged += gasolinesComboBox_SelectedIndexChanged;
            // 
            // litresLabel
            // 
            litresLabel.AutoSize = true;
            litresLabel.Location = new Point(202, 148);
            litresLabel.Name = "litresLabel";
            litresLabel.Size = new Size(17, 15);
            litresLabel.TabIndex = 0;
            litresLabel.Text = "л.";
            // 
            // hrnLabel2
            // 
            hrnLabel2.AutoSize = true;
            hrnLabel2.Location = new Point(202, 181);
            hrnLabel2.Name = "hrnLabel2";
            hrnLabel2.Size = new Size(29, 15);
            hrnLabel2.TabIndex = 0;
            hrnLabel2.Text = "грн.";
            // 
            // hrnLabel
            // 
            hrnLabel.AutoSize = true;
            hrnLabel.Location = new Point(202, 91);
            hrnLabel.Name = "hrnLabel";
            hrnLabel.Size = new Size(29, 15);
            hrnLabel.TabIndex = 0;
            hrnLabel.Text = "грн.";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(10, 86);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(35, 15);
            priceLabel.TabIndex = 0;
            priceLabel.Text = "Цена";
            // 
            // gasolineLabel
            // 
            gasolineLabel.AutoSize = true;
            gasolineLabel.Location = new Point(10, 44);
            gasolineLabel.Name = "gasolineLabel";
            gasolineLabel.Size = new Size(46, 15);
            gasolineLabel.TabIndex = 0;
            gasolineLabel.Text = "Бензин";
            // 
            // totalToPayGroupBox
            // 
            totalToPayGroupBox.Controls.Add(pictureBox1);
            totalToPayGroupBox.Controls.Add(payButton);
            totalToPayGroupBox.Controls.Add(totalToPayLabel);
            totalToPayGroupBox.Controls.Add(hrnLabel4);
            totalToPayGroupBox.Location = new Point(31, 325);
            totalToPayGroupBox.Name = "totalToPayGroupBox";
            totalToPayGroupBox.Size = new Size(577, 100);
            totalToPayGroupBox.TabIndex = 1;
            totalToPayGroupBox.TabStop = false;
            totalToPayGroupBox.Text = "ВСЕГО к оплате";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.payment_method;
            pictureBox1.Location = new Point(18, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // payButton
            // 
            payButton.BackColor = SystemColors.ControlLight;
            payButton.FlatStyle = FlatStyle.Flat;
            payButton.Font = new Font("Sitka Small", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            payButton.Location = new Point(85, 33);
            payButton.Name = "payButton";
            payButton.Size = new Size(121, 51);
            payButton.TabIndex = 2;
            payButton.Text = "Заплатить";
            payButton.UseVisualStyleBackColor = false;
            payButton.Click += payButton_Click;
            // 
            // totalToPayLabel
            // 
            totalToPayLabel.AutoSize = true;
            totalToPayLabel.Dock = DockStyle.Right;
            totalToPayLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            totalToPayLabel.Location = new Point(468, 19);
            totalToPayLabel.Name = "totalToPayLabel";
            totalToPayLabel.Padding = new Padding(0, 24, 45, 0);
            totalToPayLabel.Size = new Size(77, 61);
            totalToPayLabel.TabIndex = 1;
            totalToPayLabel.Text = "0";
            // 
            // hrnLabel4
            // 
            hrnLabel4.AutoSize = true;
            hrnLabel4.Dock = DockStyle.Right;
            hrnLabel4.Location = new Point(545, 19);
            hrnLabel4.Name = "hrnLabel4";
            hrnLabel4.Padding = new Padding(0, 40, 0, 0);
            hrnLabel4.Size = new Size(29, 55);
            hrnLabel4.TabIndex = 0;
            hrnLabel4.Text = "грн.";
            // 
            // miniCafeGroupBox
            // 
            miniCafeGroupBox.Controls.Add(countMinicafeLabel);
            miniCafeGroupBox.Controls.Add(priceMinicafeLabel);
            miniCafeGroupBox.Controls.Add(miniCafePayGroupBox);
            miniCafeGroupBox.Location = new Point(330, 12);
            miniCafeGroupBox.Name = "miniCafeGroupBox";
            miniCafeGroupBox.Size = new Size(278, 295);
            miniCafeGroupBox.TabIndex = 1;
            miniCafeGroupBox.TabStop = false;
            miniCafeGroupBox.Text = "Мини-Кафе";
            // 
            // countMinicafeLabel
            // 
            countMinicafeLabel.AutoSize = true;
            countMinicafeLabel.Location = new Point(183, 28);
            countMinicafeLabel.Name = "countMinicafeLabel";
            countMinicafeLabel.Size = new Size(72, 15);
            countMinicafeLabel.TabIndex = 6;
            countMinicafeLabel.Text = "Количество";
            // 
            // priceMinicafeLabel
            // 
            priceMinicafeLabel.AutoSize = true;
            priceMinicafeLabel.Location = new Point(132, 28);
            priceMinicafeLabel.Name = "priceMinicafeLabel";
            priceMinicafeLabel.Size = new Size(35, 15);
            priceMinicafeLabel.TabIndex = 5;
            priceMinicafeLabel.Text = "Цена";
            // 
            // miniCafePayGroupBox
            // 
            miniCafePayGroupBox.Controls.Add(totalMiniCafePriceLabel);
            miniCafePayGroupBox.Controls.Add(hrnLabel3);
            miniCafePayGroupBox.Location = new Point(34, 219);
            miniCafePayGroupBox.Name = "miniCafePayGroupBox";
            miniCafePayGroupBox.Size = new Size(221, 70);
            miniCafePayGroupBox.TabIndex = 4;
            miniCafePayGroupBox.TabStop = false;
            miniCafePayGroupBox.Text = "К оплате :";
            // 
            // totalMiniCafePriceLabel
            // 
            totalMiniCafePriceLabel.AutoSize = true;
            totalMiniCafePriceLabel.Dock = DockStyle.Right;
            totalMiniCafePriceLabel.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            totalMiniCafePriceLabel.Location = new Point(132, 19);
            totalMiniCafePriceLabel.Name = "totalMiniCafePriceLabel";
            totalMiniCafePriceLabel.Padding = new Padding(0, 0, 25, 0);
            totalMiniCafePriceLabel.Size = new Size(57, 37);
            totalMiniCafePriceLabel.TabIndex = 1;
            totalMiniCafePriceLabel.Text = "0";
            // 
            // hrnLabel3
            // 
            hrnLabel3.AutoSize = true;
            hrnLabel3.Dock = DockStyle.Right;
            hrnLabel3.Location = new Point(189, 19);
            hrnLabel3.Name = "hrnLabel3";
            hrnLabel3.Padding = new Padding(0, 20, 0, 0);
            hrnLabel3.Size = new Size(29, 35);
            hrnLabel3.TabIndex = 0;
            hrnLabel3.Text = "грн.";
            // 
            // BestOilForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(636, 450);
            Controls.Add(miniCafeGroupBox);
            Controls.Add(totalToPayGroupBox);
            Controls.Add(gasStationGroupBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "BestOilForm";
            Text = "BestOil";
            FormClosing += BestOilForm_FormClosing;
            Load += BestOilForm_Load;
            gasStationGroupBox.ResumeLayout(false);
            gasStationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)sumGasolineNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)countGasolineNumericUpDown).EndInit();
            gasolinePayGroupBox.ResumeLayout(false);
            gasolinePayGroupBox.PerformLayout();
            countOrSumGroupBox.ResumeLayout(false);
            countOrSumGroupBox.PerformLayout();
            totalToPayGroupBox.ResumeLayout(false);
            totalToPayGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            miniCafeGroupBox.ResumeLayout(false);
            miniCafeGroupBox.PerformLayout();
            miniCafePayGroupBox.ResumeLayout(false);
            miniCafePayGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gasStationGroupBox;
        private GroupBox totalToPayGroupBox;
        private GroupBox miniCafeGroupBox;
        private Label priceLabel;
        private Label gasolineLabel;
        private ComboBox gasolinesComboBox;
        private Label hrnLabel;
        private GroupBox countOrSumGroupBox;
        private RadioButton countRadioButton;
        private RadioButton sumRadioButton;
        private TextBox priceTextBox;
        private Label hrnLabel2;
        private GroupBox gasolinePayGroupBox;
        private Label litresLabel;
        private Label totalGasolineUnitsLabel;
        private Label unitsLabel;
        private Button payButton;
        private Label totalToPayLabel;
        private Label hrnLabel4;
        private PictureBox pictureBox1;
        private Label countMinicafeLabel;
        private Label priceMinicafeLabel;
        private GroupBox miniCafePayGroupBox;
        private Label totalMiniCafePriceLabel;
        private Label hrnLabel3;
        private NumericUpDown sumGasolineNumericUpDown;
        private NumericUpDown countGasolineNumericUpDown;
    }
}
