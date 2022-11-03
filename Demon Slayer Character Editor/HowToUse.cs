using System.Diagnostics;

namespace Demon_Slayer_Character_Editor
{
    public partial class DamageEditorHowToUseForm : Form
    {
        public DamageEditorHowToUseForm()
        {
            InitializeComponent();
            HowToComboBox.SelectedIndex = 0;
        }

        private void HowToComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Random RNG = new Random();
            int RNGNum = RNG.Next(0, 100);

            if (HowToComboBox.SelectedIndex == 0)
            {
                ObtainingDamageFileLabel.Visible = true;
                ObtainingDamageFileLabel1.Visible = true;
                ObtainingDamageFileLabel2.Visible = true;
                pictureBox1.Visible = true;
                pictureBox2.Visible = true;
                pictureBox3.Visible = true;

                ModifyingDamageFileLabel.Visible = false;
                ModifyingDamageFileLabel1.Visible = false;
                ModifyingDamageFileLabel2.Visible = false;
                TurningBackLabel.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                thebestestboypicture.Visible = false;

                ApplyChangesLabel.Visible = false;
                ApplyChangesLabel1.Visible = false;
                ApplyChangesLabel2.Visible = false;
                ApplyChangesLabel3.Visible = false;
                ApplyChangesLabel4.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;

                EventLabel.Visible = false;
            }
            if (HowToComboBox.SelectedIndex == 1)
            {
                ObtainingDamageFileLabel.Visible = false;
                ObtainingDamageFileLabel1.Visible = false;
                ObtainingDamageFileLabel2.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;

                ModifyingDamageFileLabel.Visible = true;
                ModifyingDamageFileLabel1.Visible = true;
                ModifyingDamageFileLabel2.Visible = true;
                TurningBackLabel.Visible = true;
                pictureBox4.Visible = true;
                pictureBox5.Visible = true;
                pictureBox6.Visible = true;
                pictureBox7.Visible = true;
                if (RNGNum == 7 && Properties.Settings.Default.RNGWinner == false)
                {
                    Properties.Settings.Default.RNGWinner = true;
                    Properties.Settings.Default.Save();
                    MessageBox.Show("Congratulations! You got the lucky random number!\nThis was a 1 in 100 chance!\n\nEnjoy this lovely picture of my cat.");
                    thebestestboypicture.Visible = true;
                }
                else
                {
                    thebestestboypicture.Visible = false;
                }

                ApplyChangesLabel.Visible = false;
                ApplyChangesLabel1.Visible = false;
                ApplyChangesLabel2.Visible = false;
                ApplyChangesLabel3.Visible = false;
                ApplyChangesLabel4.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;

                EventLabel.Visible = false;
            }
            if (HowToComboBox.SelectedIndex == 2)
            {
                ObtainingDamageFileLabel.Visible = false;
                ObtainingDamageFileLabel1.Visible = false;
                ObtainingDamageFileLabel2.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;

                ModifyingDamageFileLabel.Visible = false;
                ModifyingDamageFileLabel1.Visible = false;
                ModifyingDamageFileLabel2.Visible = false;
                TurningBackLabel.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                thebestestboypicture.Visible = false;

                ApplyChangesLabel.Visible = true;
                ApplyChangesLabel1.Visible = true;
                ApplyChangesLabel2.Visible = true;
                ApplyChangesLabel3.Visible = true;
                ApplyChangesLabel4.Visible = true;
                pictureBox8.Visible = true;
                pictureBox9.Visible = true;
                pictureBox10.Visible = true;
                pictureBox11.Visible = true;
                pictureBox12.Visible = true;
                pictureBox13.Visible = true;

                EventLabel.Visible = false;
            }
            if (HowToComboBox.SelectedIndex == 3)
            {
                ObtainingDamageFileLabel.Visible = false;
                ObtainingDamageFileLabel1.Visible = false;
                ObtainingDamageFileLabel2.Visible = false;
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;

                ModifyingDamageFileLabel.Visible = false;
                ModifyingDamageFileLabel1.Visible = false;
                ModifyingDamageFileLabel2.Visible = false;
                TurningBackLabel.Visible = false;
                pictureBox4.Visible = false;
                pictureBox5.Visible = false;
                pictureBox6.Visible = false;
                pictureBox7.Visible = false;
                thebestestboypicture.Visible = false;

                ApplyChangesLabel.Visible = false;
                ApplyChangesLabel1.Visible = false;
                ApplyChangesLabel2.Visible = false;
                ApplyChangesLabel3.Visible = false;
                ApplyChangesLabel4.Visible = false;
                pictureBox8.Visible = false;
                pictureBox9.Visible = false;
                pictureBox10.Visible = false;
                pictureBox11.Visible = false;
                pictureBox12.Visible = false;
                pictureBox13.Visible = false;

                EventLabel.Visible = true;
            }
        }

        private void ObtainingDamageFileLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://fmodel.app/") { UseShellExecute = true });
        }

        private void ModifyingDamageFileLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/atenfyr/UAssetGUI/tags") { UseShellExecute = true });
        }

        private void ApplyChangesLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("http://fluffyquack.com/tools/unrealpak.rar") { UseShellExecute = true });
        }

        private void DamageEditorHowToUseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            StartupForm startform = (StartupForm)this.Owner;
            startform.HowToUseButton.Enabled = true;
        }
    }
}
