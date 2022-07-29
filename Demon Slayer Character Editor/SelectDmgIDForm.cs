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
    public partial class SelectDmgIDForm : Form
	{
		public bool PressedOK = false;
		public string SelectedDamageID = "";

		public SelectDmgIDForm()
        {
            InitializeComponent();
		}

		private void SelectDmgIDForm_Load(object sender, EventArgs e)
		{
			MessageBox.Show(DamageIDComboBox.Items.Count.ToString());

			if (DamageIDComboBox.Items.Contains(Properties.Settings.Default.RememberYoinkDamageText))
			{
				DamageIDComboBox.Text = Properties.Settings.Default.RememberYoinkDamageText;
			}
			else
			{
				if (DamageIDComboBox.Items.Count > 0)
				{
					DamageIDComboBox.SelectedIndex = 0;
				}
			}
		}

		private void OKButton_Click(object sender, EventArgs e)
		{
			PressedOK = true;
			this.Close();
		}

		private void NoButton_Click(object sender, EventArgs e)
		{
			PressedOK = false;
			this.Close();
		}

		private void SelectDmgIDForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (PressedOK)
			{
				SelectedDamageID = DamageIDComboBox.Text;
				Properties.Settings.Default.RememberYoinkDamageText = DamageIDComboBox.Text;
				Properties.Settings.Default.Save();
			}
		}

    }
}
