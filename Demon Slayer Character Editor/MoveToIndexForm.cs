using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Demon_Slayer_Character_Editor
{
    public partial class MoveToIndexForm : Form
	{
		public Regex reg = new Regex(@"^[1-9][0-9]*$");
		public int MoveToIndex = 1;
		public int AmountToMove = 1;
		public bool PressedOK = false;
		public bool IsCheckBoxChecked = false;

		public MoveToIndexForm()
        {
            InitializeComponent();
			if (Properties.Settings.Default.RememberMoveToIndexText != null)
			{
				MoveToTextBox.Text = Properties.Settings.Default.RememberMoveToIndexText;
			}
			if (Properties.Settings.Default.RememberMoveToCheck)
			{
				MoveToCheckBox.Checked = true;
			}
			else
			{
				MoveToCheckBox.Checked = false;
			}
			if (Properties.Settings.Default.RememberSectionMoveText != null)
			{
				AmountOfTextBox.Text = Properties.Settings.Default.RememberSectionMoveText;
			}

			if (MoveToTextBox.Text == "")
			{
				MoveToTextBox.Text = "1";
			}
			if (AmountOfTextBox.Text == "")
			{
				AmountOfTextBox.Font = new Font(AmountOfTextBox.Font, FontStyle.Italic);
			}
		}

        private void MoveToTextBox_TextChanged(object sender, EventArgs e)
		{
			if (MoveToTextBox.Focused)
			{
				if (MoveToTextBox.Text == "")
				{
					try
					{
						MoveToIndex = int.Parse(MoveToTextBox.Text);
					}
					catch
					{
						MoveToIndex = 1;
					}
				}
			}
		}

        private void MoveToTextBox_Leave(object sender, EventArgs e)
		{
			if (MoveToTextBox.Focused == false)
			{
				int.TryParse(MoveToTextBox.Text, out MoveToIndex);

				if (MoveToIndex.ToString() != MoveToTextBox.Text)
				{
					MoveToIndex = 1;
					MoveToTextBox.Text = "1";
				}

				MoveToTextBox.Text = MoveToIndex.ToString();
			}
		}

        private void MoveToTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (MoveToTextBox.Focused)
			{
				if (char.IsControl(e.KeyChar)) return;
				if (!reg.IsMatch(MoveToTextBox.Text.Insert(MoveToTextBox.SelectionStart, e.KeyChar.ToString()) + "1")) e.Handled = true;
			}
		}

        private void OKButton_Click(object sender, EventArgs e)
		{
			if (MoveToTextBox.Text == "")
			{
				MessageBox.Show("Insert a number to move this section to.");
			}
			else
			{
				PressedOK = true;
				this.Close();
			}
		}

		private void NoButton_Click(object sender, EventArgs e)
		{
			PressedOK = false;
			this.Close();
		}

        private void MoveToIndexForm_FormClosed(object sender, FormClosedEventArgs e)
        {
			Properties.Settings.Default.RememberMoveToIndexText = MoveToTextBox.Text;
			Properties.Settings.Default.RememberSectionMoveText = AmountOfTextBox.Text;
			if (PressedOK)
			{
				int.TryParse(MoveToTextBox.Text, out MoveToIndex);
				int.TryParse(AmountOfTextBox.Text, out AmountToMove);
			}
			Properties.Settings.Default.Save();
		}

        private void MoveToCheckBox_CheckedChanged(object sender, EventArgs e)
        {
			if (MoveToCheckBox.Checked)
			{
				IsCheckBoxChecked = true;
				AmountOfTextBox.Enabled = true;
				AmountOfTextBox.Text = "1";
				AmountToMove = 1;
				AmountOfTextBox.Font = new Font(AmountOfTextBox.Font, FontStyle.Regular);
				Properties.Settings.Default.RememberMoveToCheck = true;
			}
			else
			{
				IsCheckBoxChecked = false;
				AmountOfTextBox.Enabled = false;
				AmountOfTextBox.Text = "";
				AmountOfTextBox.Font = new Font(AmountOfTextBox.Font, FontStyle.Italic);
				Properties.Settings.Default.RememberMoveToCheck = false;
			}
        }

        private void AmountOfTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (AmountOfTextBox.Focused)
			{
				if (char.IsControl(e.KeyChar)) return;
				if (!reg.IsMatch(MoveToTextBox.Text.Insert(MoveToTextBox.SelectionStart, e.KeyChar.ToString()) + "1")) e.Handled = true;
			}
		}

        private void AmountOfTextBox_Leave(object sender, EventArgs e)
		{
			if (AmountOfTextBox.Focused == false)
			{
				int.TryParse(AmountOfTextBox.Text, out AmountToMove);

				if (AmountToMove.ToString() != AmountOfTextBox.Text)
				{
					AmountToMove = 1;
					AmountOfTextBox.Text = "1";
				}

				AmountOfTextBox.Text = AmountToMove.ToString();
			}
		}

        private void AmountOfTextBox_TextChanged(object sender, EventArgs e)
		{
			if (AmountOfTextBox.Text == "")
			{
				try
				{
					AmountToMove = int.Parse(AmountOfTextBox.Text);
				}
				catch
				{
					AmountToMove = 1;
				}
			}
		}
    }
}
