using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demon_Slayer_Character_Editor
{
    public partial class StartupForm : Form
    {
        public StartupForm()
        {
            InitializeComponent();
            Random RNG = new Random();
            int RNGNum = RNG.Next(0, 3);

            if (RNGNum == 0)
            {
                this.BackgroundImage = global::Demon_Slayer_Character_Editor.Properties.Resources.white;
            }
            if (RNGNum == 1)
            {
               this.BackgroundImage = global::Demon_Slayer_Character_Editor.Properties.Resources.redbg;
            }
            if (RNGNum >= 2)
            {
               this.BackgroundImage = global::Demon_Slayer_Character_Editor.Properties.Resources.bluebg;
            }
        }

        private void StartupForm_Activated(object sender, EventArgs e)
        {
        }

        public void EnableButtons()
        {
            if (Application.OpenForms.OfType<DamageEditorForm>().Any() == false)
            {
                LaunchDmgEditorButton.Enabled = true;
            }
            if (Application.OpenForms.OfType<EventEditorForm>().Any() == false)
            {
                LaunchEventButton.Enabled = true;
            }
            if (Application.OpenForms.OfType<DamageEditorHowToUseForm>().Any() == false)
            {
                HowToUseButton.Enabled = true;
            }
        }

        private void LaunchDmgEditorButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<DamageEditorForm>().Any() == false)
            {
                DamageEditorForm dmgform = new DamageEditorForm();
                dmgform.Owner = this;
                dmgform.Show();
                LaunchDmgEditorButton.Enabled = false;
            }
        }

        private void LaunchEventButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<EventEditorForm>().Any() == false)
            {
                EventEditorForm evtform = new EventEditorForm();
                evtform.Owner = this;
                evtform.Show();
                LaunchEventButton.Enabled = false;
            }
        }

        private void HowToUseButton_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<EventEditorForm>().Any() == false)
            {
                DamageEditorHowToUseForm tutform = new DamageEditorHowToUseForm();
                tutform.Owner = this;
                tutform.Show();
                HowToUseButton.Enabled = false;
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This tool was created by Kuroha Saenoki.\n\nIt is meant to be used after exporting\na .uasset into a .json via UAssetGUI.");
        }
    }
}
