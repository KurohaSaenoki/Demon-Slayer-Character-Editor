namespace Demon_Slayer_Character_Editor
{
    partial class DamageEditorHowToUseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DamageEditorHowToUseForm));
            this.HowToComboBox = new System.Windows.Forms.ComboBox();
            this.TurningBackLabel = new System.Windows.Forms.Label();
            this.ApplyChangesLabel1 = new System.Windows.Forms.Label();
            this.ObtainingDamageFileLabel = new System.Windows.Forms.LinkLabel();
            this.ModifyingDamageFileLabel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ObtainingDamageFileLabel1 = new System.Windows.Forms.Label();
            this.ObtainingDamageFileLabel2 = new System.Windows.Forms.Label();
            this.ModifyingDamageFileLabel1 = new System.Windows.Forms.Label();
            this.ModifyingDamageFileLabel2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.ApplyChangesLabel = new System.Windows.Forms.LinkLabel();
            this.ApplyChangesLabel2 = new System.Windows.Forms.Label();
            this.ApplyChangesLabel3 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.ApplyChangesLabel4 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.thebestestboypicture = new System.Windows.Forms.PictureBox();
            this.EventLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thebestestboypicture)).BeginInit();
            this.SuspendLayout();
            // 
            // HowToComboBox
            // 
            this.HowToComboBox.FormattingEnabled = true;
            this.HowToComboBox.Items.AddRange(new object[] {
            "Obtaining Files from the game",
            "Modifying Files Using UAssetGUI",
            "Applying the changes to your game",
            "Specific Rules for Event Files"});
            this.HowToComboBox.Location = new System.Drawing.Point(12, 12);
            this.HowToComboBox.Name = "HowToComboBox";
            this.HowToComboBox.Size = new System.Drawing.Size(295, 23);
            this.HowToComboBox.TabIndex = 1;
            this.HowToComboBox.SelectedIndexChanged += new System.EventHandler(this.HowToComboBox_SelectedIndexChanged);
            // 
            // TurningBackLabel
            // 
            this.TurningBackLabel.AutoSize = true;
            this.TurningBackLabel.BackColor = System.Drawing.Color.Transparent;
            this.TurningBackLabel.Location = new System.Drawing.Point(335, 570);
            this.TurningBackLabel.Name = "TurningBackLabel";
            this.TurningBackLabel.Size = new System.Drawing.Size(537, 30);
            this.TurningBackLabel.TabIndex = 4;
            this.TurningBackLabel.Text = "After you\'ve saved the .json changes, simply drag and drop the .json into UAssetG" +
    "UI.\r\nIf nothing goes wrong, it will load the file like a normal .uasset, which y" +
    "ou can then Save As a .uasset.\r\n";
            this.TurningBackLabel.Visible = false;
            // 
            // ApplyChangesLabel1
            // 
            this.ApplyChangesLabel1.AutoSize = true;
            this.ApplyChangesLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ApplyChangesLabel1.Location = new System.Drawing.Point(332, 218);
            this.ApplyChangesLabel1.Name = "ApplyChangesLabel1";
            this.ApplyChangesLabel1.Size = new System.Drawing.Size(462, 45);
            this.ApplyChangesLabel1.TabIndex = 5;
            this.ApplyChangesLabel1.Text = "Example using Water Tanjiro:\r\n\"InstantKOTanjiro/APK/Content/MasterData/Plc/p0001_" +
    "v00/\"\r\nthen simply insert both the P0001_v00prm_damage.uasset and .uexp inside t" +
    "hat folder.";
            this.ApplyChangesLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ApplyChangesLabel1.Visible = false;
            // 
            // ObtainingDamageFileLabel
            // 
            this.ObtainingDamageFileLabel.BackColor = System.Drawing.Color.Transparent;
            this.ObtainingDamageFileLabel.LinkArea = new System.Windows.Forms.LinkArea(0, 16);
            this.ObtainingDamageFileLabel.Location = new System.Drawing.Point(38, 51);
            this.ObtainingDamageFileLabel.Name = "ObtainingDamageFileLabel";
            this.ObtainingDamageFileLabel.Size = new System.Drawing.Size(472, 74);
            this.ObtainingDamageFileLabel.TabIndex = 6;
            this.ObtainingDamageFileLabel.TabStop = true;
            this.ObtainingDamageFileLabel.Text = "Download FModel\r\n\r\nInside of Directory -> Selector, Select \"Add Undetected Game\"\r" +
    "\nSet the Directory to where the Paks are located. (\"Demon Slayer\\APK\\Content\\Pak" +
    "s\")";
            this.ObtainingDamageFileLabel.UseCompatibleTextRendering = true;
            this.ObtainingDamageFileLabel.Visible = false;
            this.ObtainingDamageFileLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ObtainingDamageFileLabel_LinkClicked);
            // 
            // ModifyingDamageFileLabel
            // 
            this.ModifyingDamageFileLabel.BackColor = System.Drawing.Color.Transparent;
            this.ModifyingDamageFileLabel.LinkArea = new System.Windows.Forms.LinkArea(0, 18);
            this.ModifyingDamageFileLabel.Location = new System.Drawing.Point(38, 51);
            this.ModifyingDamageFileLabel.Name = "ModifyingDamageFileLabel";
            this.ModifyingDamageFileLabel.Size = new System.Drawing.Size(238, 72);
            this.ModifyingDamageFileLabel.TabIndex = 7;
            this.ModifyingDamageFileLabel.TabStop = true;
            this.ModifyingDamageFileLabel.Text = "Download UAssetGUI\r\n\r\nOpen the file with UAssetGUI\r\nSelect the version on the top" +
    " right as 4.25";
            this.ModifyingDamageFileLabel.UseCompatibleTextRendering = true;
            this.ModifyingDamageFileLabel.Visible = false;
            this.ModifyingDamageFileLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ModifyingDamageFileLabel_LinkClicked);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(37, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(491, 212);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(319, 256);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(128, 372);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(261, 240);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Visible = false;
            // 
            // ObtainingDamageFileLabel1
            // 
            this.ObtainingDamageFileLabel1.AutoSize = true;
            this.ObtainingDamageFileLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ObtainingDamageFileLabel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ObtainingDamageFileLabel1.Location = new System.Drawing.Point(449, 174);
            this.ObtainingDamageFileLabel1.Name = "ObtainingDamageFileLabel1";
            this.ObtainingDamageFileLabel1.Size = new System.Drawing.Size(361, 30);
            this.ObtainingDamageFileLabel1.TabIndex = 11;
            this.ObtainingDamageFileLabel1.Text = "Inside of Settings, set to UE version to \"GAME_UE4_25_Plus\"\r\nSet the location whe" +
    "re you want the Exported files to be Outputted.";
            this.ObtainingDamageFileLabel1.Visible = false;
            // 
            // ObtainingDamageFileLabel2
            // 
            this.ObtainingDamageFileLabel2.AutoSize = true;
            this.ObtainingDamageFileLabel2.BackColor = System.Drawing.Color.Transparent;
            this.ObtainingDamageFileLabel2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ObtainingDamageFileLabel2.Location = new System.Drawing.Point(432, 522);
            this.ObtainingDamageFileLabel2.Name = "ObtainingDamageFileLabel2";
            this.ObtainingDamageFileLabel2.Size = new System.Drawing.Size(404, 90);
            this.ObtainingDamageFileLabel2.TabIndex = 12;
            this.ObtainingDamageFileLabel2.Text = resources.GetString("ObtainingDamageFileLabel2.Text");
            this.ObtainingDamageFileLabel2.Visible = false;
            // 
            // ModifyingDamageFileLabel1
            // 
            this.ModifyingDamageFileLabel1.AutoSize = true;
            this.ModifyingDamageFileLabel1.BackColor = System.Drawing.Color.Transparent;
            this.ModifyingDamageFileLabel1.Location = new System.Drawing.Point(28, 159);
            this.ModifyingDamageFileLabel1.Name = "ModifyingDamageFileLabel1";
            this.ModifyingDamageFileLabel1.Size = new System.Drawing.Size(297, 15);
            this.ModifyingDamageFileLabel1.TabIndex = 13;
            this.ModifyingDamageFileLabel1.Text = "You can simply change the values within that program.";
            this.ModifyingDamageFileLabel1.Visible = false;
            // 
            // ModifyingDamageFileLabel2
            // 
            this.ModifyingDamageFileLabel2.AutoSize = true;
            this.ModifyingDamageFileLabel2.BackColor = System.Drawing.Color.Transparent;
            this.ModifyingDamageFileLabel2.Location = new System.Drawing.Point(195, 453);
            this.ModifyingDamageFileLabel2.Name = "ModifyingDamageFileLabel2";
            this.ModifyingDamageFileLabel2.Size = new System.Drawing.Size(433, 30);
            this.ModifyingDamageFileLabel2.TabIndex = 14;
            this.ModifyingDamageFileLabel2.Text = "Alternatively, you can go to File -> Save As -> <filename>.json\r\nOnce it\'s saved " +
    "as .json you can open it in this program and modify it a bit easier.\r\n";
            this.ModifyingDamageFileLabel2.Visible = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(301, 70);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(154, 86);
            this.pictureBox4.TabIndex = 15;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(28, 193);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(412, 212);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 16;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(335, 498);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(217, 65);
            this.pictureBox6.TabIndex = 17;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(74, 498);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(201, 114);
            this.pictureBox7.TabIndex = 18;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // ApplyChangesLabel
            // 
            this.ApplyChangesLabel.BackColor = System.Drawing.Color.Transparent;
            this.ApplyChangesLabel.LinkArea = new System.Windows.Forms.LinkArea(34, 18);
            this.ApplyChangesLabel.Location = new System.Drawing.Point(96, 94);
            this.ApplyChangesLabel.Name = "ApplyChangesLabel";
            this.ApplyChangesLabel.Size = new System.Drawing.Size(315, 43);
            this.ApplyChangesLabel.TabIndex = 19;
            this.ApplyChangesLabel.TabStop = true;
            this.ApplyChangesLabel.Text = "After you\'ve made your new .json, Download UnrealPak\r\nExtract it with 7Zip or Win" +
    "rar";
            this.ApplyChangesLabel.UseCompatibleTextRendering = true;
            this.ApplyChangesLabel.Visible = false;
            this.ApplyChangesLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ApplyChangesLabel_LinkClicked);
            // 
            // ApplyChangesLabel2
            // 
            this.ApplyChangesLabel2.AutoSize = true;
            this.ApplyChangesLabel2.BackColor = System.Drawing.Color.Transparent;
            this.ApplyChangesLabel2.Location = new System.Drawing.Point(132, 406);
            this.ApplyChangesLabel2.Name = "ApplyChangesLabel2";
            this.ApplyChangesLabel2.Size = new System.Drawing.Size(534, 45);
            this.ApplyChangesLabel2.TabIndex = 20;
            this.ApplyChangesLabel2.Text = resources.GetString("ApplyChangesLabel2.Text");
            this.ApplyChangesLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ApplyChangesLabel2.Visible = false;
            // 
            // ApplyChangesLabel3
            // 
            this.ApplyChangesLabel3.AutoSize = true;
            this.ApplyChangesLabel3.BackColor = System.Drawing.Color.Transparent;
            this.ApplyChangesLabel3.Location = new System.Drawing.Point(96, 580);
            this.ApplyChangesLabel3.Name = "ApplyChangesLabel3";
            this.ApplyChangesLabel3.Size = new System.Drawing.Size(679, 30);
            this.ApplyChangesLabel3.TabIndex = 21;
            this.ApplyChangesLabel3.Text = "If everything works, your changes will be applied.\r\nFor your first time, I recomm" +
    "end changing something that will be immediately noticable like changing the dama" +
    "ge to be 99999.";
            this.ApplyChangesLabel3.Visible = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(461, 51);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(300, 164);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 22;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            // 
            // ApplyChangesLabel4
            // 
            this.ApplyChangesLabel4.AutoSize = true;
            this.ApplyChangesLabel4.BackColor = System.Drawing.Color.Transparent;
            this.ApplyChangesLabel4.Location = new System.Drawing.Point(82, 172);
            this.ApplyChangesLabel4.Name = "ApplyChangesLabel4";
            this.ApplyChangesLabel4.Size = new System.Drawing.Size(373, 30);
            this.ApplyChangesLabel4.TabIndex = 23;
            this.ApplyChangesLabel4.Text = "Make a New Folder named as whatever you want the modname to be\r\nWithin this new f" +
    "older, create the pathways for the original file.\r\n";
            this.ApplyChangesLabel4.Visible = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(86, 240);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(175, 156);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 24;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Visible = false;
            // 
            // pictureBox10
            // 
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(267, 266);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(539, 128);
            this.pictureBox10.TabIndex = 25;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Visible = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(95, 454);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(194, 90);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 26;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Visible = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(302, 454);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(226, 108);
            this.pictureBox12.TabIndex = 27;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Visible = false;
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(549, 454);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(256, 108);
            this.pictureBox13.TabIndex = 28;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Visible = false;
            // 
            // thebestestboypicture
            // 
            this.thebestestboypicture.Image = ((System.Drawing.Image)(resources.GetObject("thebestestboypicture.Image")));
            this.thebestestboypicture.Location = new System.Drawing.Point(575, 129);
            this.thebestestboypicture.Name = "thebestestboypicture";
            this.thebestestboypicture.Size = new System.Drawing.Size(235, 321);
            this.thebestestboypicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thebestestboypicture.TabIndex = 29;
            this.thebestestboypicture.TabStop = false;
            this.thebestestboypicture.Visible = false;
            // 
            // EventLabel
            // 
            this.EventLabel.AutoSize = true;
            this.EventLabel.BackColor = System.Drawing.Color.Transparent;
            this.EventLabel.Location = new System.Drawing.Point(38, 94);
            this.EventLabel.Name = "EventLabel";
            this.EventLabel.Size = new System.Drawing.Size(847, 495);
            this.EventLabel.TabIndex = 30;
            this.EventLabel.Text = resources.GetString("EventLabel.Text");
            // 
            // DamageEditorHowToUseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(941, 685);
            this.Controls.Add(this.ApplyChangesLabel1);
            this.Controls.Add(this.ApplyChangesLabel4);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.ApplyChangesLabel2);
            this.Controls.Add(this.ApplyChangesLabel);
            this.Controls.Add(this.thebestestboypicture);
            this.Controls.Add(this.HowToComboBox);
            this.Controls.Add(this.ObtainingDamageFileLabel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ObtainingDamageFileLabel);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.ModifyingDamageFileLabel1);
            this.Controls.Add(this.ModifyingDamageFileLabel);
            this.Controls.Add(this.TurningBackLabel);
            this.Controls.Add(this.ApplyChangesLabel3);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ModifyingDamageFileLabel2);
            this.Controls.Add(this.EventLabel);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.ObtainingDamageFileLabel2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(792, 724);
            this.Name = "DamageEditorHowToUseForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "How to use";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DamageEditorHowToUseForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thebestestboypicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox HowToComboBox;
        private Label TurningBackLabel;
        private Label ApplyChangesLabel1;
        private LinkLabel ObtainingDamageFileLabel;
        private LinkLabel ModifyingDamageFileLabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label ObtainingDamageFileLabel1;
        private Label ObtainingDamageFileLabel2;
        private Label ModifyingDamageFileLabel1;
        private Label ModifyingDamageFileLabel2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private LinkLabel ApplyChangesLabel;
        private Label ApplyChangesLabel2;
        private Label ApplyChangesLabel3;
        private PictureBox pictureBox8;
        private Label ApplyChangesLabel4;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox thebestestboypicture;
        private Label EventLabel;
    }
}