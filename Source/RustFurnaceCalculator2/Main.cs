using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RustFurnaceCalculator2
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

		int charcoalTotal = 0;
		int woodNeeded = 0;
		double woodHqCalc = 10.0 / 12.0;
		double woodMetalCalc = 5.0 / 12.0;
		double woodSulfurCalc = 2.5 / 12.0;
		double extra = 0.0;
		int extraCheck = 0;
		int seconds = 0;
		int minutes = 0;
		int stackSize = 0;
		int stackSizeApprox = 0;
		int stackSizeApproxHigh = 0;
		int totalSeconds = 0;
		int secondsTimer = 0;
		int minutesTimer = 0;
		int woodTotalNeeded = 0;
		bool pausing = false;
		bool resetting = false;

		public void resetCommand()
		{
			resetting = true;
			pausing = true;
			Timer.Enabled = false;
			lblError.ResetText();
			txtFurnaces.ResetText();
			txtFurnaces.AppendText("1");
			txtMetal.ResetText();
			txtSulfur.ResetText();
			txtHQM.ResetText();
			txtStackSize.ResetText();
			txtWoodPerFurnace.ResetText();
			txtWoodTotal.ResetText();
			txtCharcoal.ResetText();
			txtTime.ResetText();
			txtOrePerFurnace.ResetText();
			btnStartTimer.Text = "Start Timer";
			totalSeconds = 0;
			secondsTimer = 0;
			minutesTimer = 0;
		}

		public void resetOutput()
		{
			txtStackSize.ResetText();
			txtWoodPerFurnace.ResetText();
			txtWoodTotal.ResetText();
			txtCharcoal.ResetText();
			txtTime.ResetText();
			totalSeconds = 0;
			secondsTimer = 0;
			minutesTimer = 0;
			lblError.ResetText();
			txtOrePerFurnace.ResetText();
		}

		public void calculateCommand()
		{
			resetting = true;
			resetOutput();
			if (btnStartTimer.Text == "Pause Timer")
			{
				btnStartTimer.Text = "Start Timer";
			}
			if (txtMetal.Text != "" && txtSulfur.Text != "")
			{
				lblError.Text = "There was an error. Check your inputs.";
			}
			else if (txtMetal.Text != "" && txtHQM.Text != "")
			{
				lblError.Text = "There was an error. Check your inputs.";
			}
			else if (txtSulfur.Text != "" && txtHQM.Text != "")
			{
				lblError.Text = "There was an error. Check your inputs.";
			}
			else if (txtMetal.Text != "" && txtSulfur.Text == "" && txtHQM.Text == "")
			{
				metalCommand();
			}
			else if (txtMetal.Text == "" && txtSulfur.Text != "" && txtHQM.Text == "")
			{
				sulfurCommand();
			}
			else if (txtMetal.Text == "" && txtSulfur.Text == "" && txtHQM.Text != "")
			{
				hqCommand();
			}
		}

		public void metalCommand()
		{
			seconds = 0;
			minutes = 0;
			double metalOreCheck = Convert.ToDouble(txtMetal.Text) / Convert.ToDouble(txtFurnaces.Text);
			extra = metalOreCheck / 12.0;
			extraCheck = (int)extra;
			woodNeeded = (int)Math.Ceiling(metalOreCheck * woodMetalCalc);
			if (Convert.ToInt32(txtFurnaces.Text) > 1 && extra != (double)extraCheck)
            {
				woodNeeded = woodNeeded + (5 * (Convert.ToInt32(txtFurnaces.Text) - 1));
            }
			if (extra == (double)extraCheck && extra >= 1.0)
			{
				stackSize = (int)Math.Floor(metalOreCheck / 12.0);
				txtStackSize.Text = Convert.ToString(stackSize);
				txtOrePerFurnace.Text = Convert.ToString(stackSize * 12);
			}
			else if (extra < 1.0)
			{
				woodNeeded = 5;
				txtStackSize.Text = "<1";
			}
			else
			{
				stackSize = (int)(metalOreCheck / 12.0);
				stackSizeApprox = stackSize;
				stackSizeApproxHigh = stackSizeApprox + 1;
				woodNeeded = stackSizeApproxHigh * 5;
				txtStackSize.Text = Convert.ToString(stackSizeApprox) + " - " + Convert.ToString(stackSizeApproxHigh);
				txtOrePerFurnace.Text = Convert.ToString(stackSizeApprox * 12) + " - " + Convert.ToString(stackSizeApproxHigh * 12);
				lblError.Text = "[INFO] Nearest even ore amounts are " + stackSizeApprox * 12 * Convert.ToInt32(txtFurnaces.Text) + " and " + stackSizeApproxHigh * 12 * Convert.ToInt32(txtFurnaces.Text) + ".";
			}
			charcoalTotal = (int)Math.Ceiling((double)woodNeeded * 0.75 * (double)Convert.ToInt32(txtFurnaces.Text));
			txtCharcoal.Text = Convert.ToString(charcoalTotal);
			seconds = woodNeeded * 2;
			secondsTimer = seconds;
			for (totalSeconds = seconds; seconds >= 60; seconds -= 60)
			{
				minutes++;
			}
			if (metalOreCheck > 3000.0)
			{
				lblError.Text = "You are smelting too much. This will cause overflow.";
			}
			woodTotalNeeded = woodNeeded * Convert.ToInt32(txtFurnaces.Text);
			txtWoodPerFurnace.Text = Convert.ToString(woodNeeded);
			txtWoodTotal.Text = Convert.ToString(woodTotalNeeded);
			txtTime.Text = minutes.ToString("00") + "m " + seconds.ToString("00") + "s";
		}

		public void sulfurCommand()
		{
			seconds = 0;
			minutes = 0;
			double sulfurOreCheck = Convert.ToDouble(txtSulfur.Text) / Convert.ToDouble(txtFurnaces.Text);
			extra = sulfurOreCheck / 12.0;
			extraCheck = (int)extra;
			woodNeeded = (int)Math.Ceiling(sulfurOreCheck * woodSulfurCalc);
			if (Convert.ToInt32(txtFurnaces.Text) > 1 && extra != (double)extraCheck)
			{
				woodNeeded = woodNeeded + (3 * (Convert.ToInt32(txtFurnaces.Text) - 1));
			}
			if (extra == (double)extraCheck && extra >= 1.0)
			{
				stackSize = (int)Math.Floor(sulfurOreCheck / 12.0);
				txtStackSize.Text = Convert.ToString(stackSize);
				txtOrePerFurnace.Text = Convert.ToString(stackSize * 12);
			}
			else if (extra < 1.0)
			{
				woodNeeded = 3;
				txtStackSize.Text = "<1";
			}
			else
			{
				stackSize = (int)(sulfurOreCheck / 12.0);
				stackSizeApprox = stackSize;
				stackSizeApproxHigh = stackSizeApprox + 1;
				woodNeeded = (int)Math.Ceiling(stackSizeApproxHigh * 2.5);
				txtStackSize.Text = Convert.ToString(stackSizeApprox) + " - " + Convert.ToString(stackSizeApproxHigh);
				txtOrePerFurnace.Text = Convert.ToString(stackSizeApprox * 12) + " - " + Convert.ToString(stackSizeApproxHigh * 12);
				lblError.Text = "[INFO] Nearest even ore amounts are " + stackSizeApprox * 12 * Convert.ToInt32(txtFurnaces.Text) + " and " + stackSizeApproxHigh * 12 * Convert.ToInt32(txtFurnaces.Text) + ".";
			}
			charcoalTotal = (int)Math.Ceiling((double)woodNeeded * 0.75 * (double)Convert.ToInt32(txtFurnaces.Text));
			txtCharcoal.Text = Convert.ToString(charcoalTotal);
			seconds = woodNeeded * 2;
			secondsTimer = seconds;
			for (totalSeconds = seconds; seconds >= 60; seconds -= 60)
			{
				minutes++;
			}
			if (sulfurOreCheck > 3960.0)
			{
				lblError.Text = "You are smelting too much. This will cause overflow.";
			}
			woodTotalNeeded = woodNeeded * Convert.ToInt32(txtFurnaces.Text);
			txtWoodPerFurnace.Text = Convert.ToString(woodNeeded);
			txtWoodTotal.Text = Convert.ToString(woodTotalNeeded);
			txtTime.Text = minutes.ToString("00") + "m " + seconds.ToString("00") + "s";
		}

		public void hqCommand()
		{
			seconds = 0;
			minutes = 0;
			double hqOreCheck = Convert.ToDouble(txtHQM.Text) / Convert.ToDouble(txtFurnaces.Text);
			extra = hqOreCheck / 12.0;
			extraCheck = (int)extra;
			woodNeeded = (int)Math.Ceiling(hqOreCheck * woodHqCalc);
			if (Convert.ToInt32(txtFurnaces.Text) > 1 && extra != (double)extraCheck)
			{
				woodNeeded = woodNeeded + (10 * (Convert.ToInt32(txtFurnaces.Text) - 1));
			}
			if (extra == (double)extraCheck && extra >= 1.0)
			{
				stackSize = (int)Math.Floor(hqOreCheck / 12.0);
				txtStackSize.Text = Convert.ToString(stackSize);
				txtOrePerFurnace.Text = Convert.ToString(stackSize * 12);
			}
			else if (extra < 1.0)
			{
				woodNeeded = 10;
				txtStackSize.Text = "<1";
			}
			else
			{
				stackSize = (int)(hqOreCheck / 12.0);
				stackSizeApprox = stackSize;
				stackSizeApproxHigh = stackSizeApprox + 1;
				woodNeeded = stackSizeApproxHigh * 10;
				txtStackSize.Text = Convert.ToString(stackSizeApprox) + " - " + Convert.ToString(stackSizeApproxHigh);
				txtOrePerFurnace.Text = Convert.ToString(stackSizeApprox * 12) + " - " + Convert.ToString(stackSizeApproxHigh * 12);
				lblError.Text = "[INFO] Nearest even ore amounts are " + stackSizeApprox * 12 * Convert.ToInt32(txtFurnaces.Text) + " and " + stackSizeApproxHigh * 12 * Convert.ToInt32(txtFurnaces.Text) + ".";
			}
			charcoalTotal = (int)Math.Ceiling((double)woodNeeded * 0.75 * (double)Convert.ToInt32(txtFurnaces.Text));
			txtCharcoal.Text = Convert.ToString(charcoalTotal);
			seconds = woodNeeded * 2;
			secondsTimer = seconds;
			for (totalSeconds = seconds; seconds >= 60; seconds -= 60)
			{
				minutes++;
			}
			if (hqOreCheck > 396.0)
			{
				lblError.Text = "You are smelting too much. This will cause overflow.";
			}
			woodTotalNeeded = woodNeeded * Convert.ToInt32(txtFurnaces.Text);
			txtWoodPerFurnace.Text = Convert.ToString(woodNeeded);
			txtWoodTotal.Text = Convert.ToString(woodTotalNeeded);
			txtTime.Text = minutes.ToString("00") + "m " + seconds.ToString("00") + "s";
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			resetting = false;
			pausing = false;
			if (pausing)
			{
				Timer.Enabled = false;
			}
			while (secondsTimer > 60)
			{
				minutesTimer++;
				secondsTimer -= 60;
			}
			if (secondsTimer > 0 && txtStackSize.Text != "" && !resetting)
			{
				if (secondsTimer == 60)
				{
					int tempMin = minutesTimer + 1;
					txtTime.Text = tempMin.ToString("00") + "m " + 0.ToString("00") + "s";
				}
				else
				{
					txtTime.Text = minutesTimer.ToString("00") + "m " + secondsTimer.ToString("00") + "s";
				}
				secondsTimer--;
				if (minutesTimer > 0 && secondsTimer == 0)
				{
					minutesTimer--;
					secondsTimer += 60;
				}
			}
			else if (txtStackSize.Text == "")
			{
				txtTime.ResetText();
				secondsTimer = 0;
				totalSeconds = 0;
				minutesTimer = 0;
				btnStartTimer.Text = "Start Timer";
			}
			else if (resetting)
			{
				Timer.Enabled = false;
			}
			else
			{
				txtTime.Text = "Smelting Complete!";
				btnStartTimer.Text = "Start Timer";
			}
			if (totalSeconds == 0)
			{
				Timer.Enabled = false;
			}
		}

		private void Timer_Tick_1(object sender, EventArgs e)
		{
			resetting = false;
			pausing = false;
			if (pausing)
			{
				Timer.Enabled = false;
			}
			while (secondsTimer > 60)
			{
				minutesTimer++;
				secondsTimer -= 60;
			}
			if (secondsTimer > 0 && txtStackSize.Text != "" && !resetting)
			{
				if (secondsTimer == 60)
				{
					int tempMin = minutesTimer + 1;
					txtTime.Text = tempMin.ToString("00") + "m " + 0.ToString("00") + "s";
				}
				else
				{
					txtTime.Text = minutesTimer.ToString("00") + "m " + secondsTimer.ToString("00") + "s";
				}
				secondsTimer--;
				if (minutesTimer > 0 && secondsTimer == 0)
				{
					minutesTimer--;
					secondsTimer += 60;
				}
			}
			else if (txtStackSize.Text == "")
			{
				txtTime.ResetText();
				secondsTimer = 0;
				totalSeconds = 0;
				minutesTimer = 0;
				btnStartTimer.Text = "Start Timer";
			}
			else if (resetting)
			{
				Timer.Enabled = false;
			}
			else
			{
				txtTime.Text = "Smelting Complete!";
				btnStartTimer.Text = "Start Timer";
			}
			if (totalSeconds == 0)
			{
				Timer.Enabled = false;
			}
		}

		private void lblSulfur_Click(object sender, EventArgs e)
        {
			string tempFurnaces = txtFurnaces.Text;
			resetCommand();
			txtFurnaces.Text = tempFurnaces;
			txtSulfur.Text = Convert.ToString(Convert.ToInt32(txtFurnaces.Text) * 3960);
			calculateCommand();
		}

        private void lblMetal_Click(object sender, EventArgs e)
        {
			string tempFurnaces = txtFurnaces.Text;
			resetCommand();
			txtFurnaces.Text = tempFurnaces;
			txtMetal.Text = Convert.ToString(Convert.ToInt32(txtFurnaces.Text) * 3000);
			calculateCommand();
		}

        private void lblHQM_Click(object sender, EventArgs e)
        {
			string tempFurnaces = txtFurnaces.Text;
			resetCommand();
			txtFurnaces.Text = tempFurnaces;
			txtHQM.Text = Convert.ToString(Convert.ToInt32(txtFurnaces.Text) * 396);
			calculateCommand();
		}

        private void btnCalculate_Click(object sender, EventArgs e)
        {
			calculateCommand();
		}

        private void btnReset_Click(object sender, EventArgs e)
        {
			resetCommand();
		}

        private void btnStartTimer_Click(object sender, EventArgs e)
        {
			if (btnStartTimer.Text == "Start Timer")
			{
				Timer.Enabled = true;
				btnStartTimer.Text = "Pause Timer";
			}
			else if (btnStartTimer.Text == "Pause Timer")
			{
				Timer.Enabled = false;
				btnStartTimer.Text = "Start Timer";
			}
		}

        private void txtMetal_TextChanged(object sender, EventArgs e)
        {
			int number;
			bool success = Int32.TryParse(txtMetal.Text, out number);
			if (success) {
				Timer.Enabled = false;
				calculateCommand();
			}
			else if (txtMetal.Text == "")
            {
				Timer.Enabled = false;
				lblError.ResetText();
			}
			else
            {
				lblError.Text = "There was an error. Check your inputs.";
			}
			
		}

        private void txtSulfur_TextChanged(object sender, EventArgs e)
        {
			int number;
			bool success = Int32.TryParse(txtSulfur.Text, out number);
			if (success)
			{
				Timer.Enabled = false;
				calculateCommand();
			}
			else if (txtSulfur.Text == "")
			{
				Timer.Enabled = false;
				lblError.ResetText();
			}
			else
			{
				lblError.Text = "There was an error. Check your inputs.";
			}
		}

        private void txtHQM_TextChanged(object sender, EventArgs e)
        {
			int number;
			bool success = Int32.TryParse(txtHQM.Text, out number);
			if (success)
			{
				Timer.Enabled = false;
				calculateCommand();
			}
			else if (txtHQM.Text == "")
			{
				Timer.Enabled = false;
				lblError.ResetText();
			}
			else
			{
				lblError.Text = "There was an error. Check your inputs.";
			}
		}

        private void txtFurnaces_TextChanged(object sender, EventArgs e)
        {
			int number;
			bool success = Int32.TryParse(txtFurnaces.Text, out number);
			if (success)
			{
				Timer.Enabled = false;
				calculateCommand();
			}
			else if (txtFurnaces.Text == "")
			{
				Timer.Enabled = false;
				lblError.ResetText();
			}
			else
			{
				lblError.Text = "There was an error. Check your inputs.";
			}
		}
    }
}
