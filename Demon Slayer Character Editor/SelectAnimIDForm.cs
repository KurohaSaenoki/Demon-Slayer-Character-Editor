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
    public partial class SelectAnimIDForm : Form
	{
		public bool PressedOK = false;
		public string ComboBoxSelection = "";

		public SelectAnimIDForm()
        {
            InitializeComponent();
			if (Properties.Settings.Default.RememberYoinkText != null)
			{
				EAnimationIdComboBox.Text = Properties.Settings.Default.RememberYoinkText;
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

		private void SelectAnimIDForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (PressedOK)
			{
				ComboBoxSelection = EAnimationIdComboBox.Text;
				Properties.Settings.Default.RememberYoinkText = ComboBoxSelection;
				Properties.Settings.Default.Save();
			}
		}
    }
}
