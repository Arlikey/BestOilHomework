using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestOilHomework
{
    public partial class AdditionalTask2 : Form
    {
        public AdditionalTask2()
        {
            InitializeComponent();
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            decimal growthRate = (decimal)Math.Pow((double)(1 + interestRateNumericUpDown.Value / 100), (double)depositPeriodNumericUpDown.Value);
            finalAmountTextBox.Text = (depositAmountNumericUpDown.Value * growthRate).ToString("0.00");
        }
    }
}
