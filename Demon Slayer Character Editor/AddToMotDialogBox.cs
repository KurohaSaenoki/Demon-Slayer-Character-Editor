namespace Demon_Slayer_Character_Editor
{
    public partial class AddToMotDialogBox : Form
    {
        public bool BasicButtonClicked = false;
        public bool DamageReactButtonClicked = false;
        public bool MeleeButtonClicked = false;
        public bool SupportButtonClicked = false;
        public AddToMotDialogBox()
        {
            InitializeComponent();

        }

        private void AddToMotDialogBox_Load(object sender, EventArgs e)
        {
        }

        private void BasicButton_Click(object sender, EventArgs e)
        {
            BasicButtonClicked = true;
            DamageReactButtonClicked = false;
            MeleeButtonClicked = false;
            SupportButtonClicked = false;
            this.Close();
        }

        private void DamageReactionButton_Click(object sender, EventArgs e)
        {
            BasicButtonClicked = false;
            DamageReactButtonClicked = true;
            MeleeButtonClicked = false;
            SupportButtonClicked = false;
            this.Close();
        }

        private void MeleeButton_Click(object sender, EventArgs e)
        {
            BasicButtonClicked = false;
            DamageReactButtonClicked = false;
            MeleeButtonClicked = true;
            SupportButtonClicked = false;
            this.Close();
        }

        private void SupportButton_Click(object sender, EventArgs e)
        {
            BasicButtonClicked = false;
            DamageReactButtonClicked = false;
            MeleeButtonClicked = false;
            SupportButtonClicked = true;
            this.Close();
        }
    }
}
