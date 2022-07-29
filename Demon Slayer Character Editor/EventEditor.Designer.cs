namespace Demon_Slayer_Character_Editor
{
    partial class EventEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventEditorForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.OpenButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveAsButton = new System.Windows.Forms.ToolStripButton();
            this.BackupsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.YoinkFromFileButton = new System.Windows.Forms.ToolStripButton();
            this.NameOfTableIDLabel = new System.Windows.Forms.Label();
            this.NameOfTableIDTextbox = new System.Windows.Forms.TextBox();
            this.EventListBox = new System.Windows.Forms.ListBox();
            this.DuplicateButton = new System.Windows.Forms.Button();
            this.MoveDownButton = new System.Windows.Forms.Button();
            this.MoveUpButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.SaveChangesToMoveButton = new System.Windows.Forms.Button();
            this.EAnimationIdLabel = new System.Windows.Forms.Label();
            this.TimingLabel = new System.Windows.Forms.Label();
            this.EvidLabel = new System.Windows.Forms.Label();
            this.CoordNameLabel = new System.Windows.Forms.Label();
            this.ArgN1Label = new System.Windows.Forms.Label();
            this.ArgN2Label = new System.Windows.Forms.Label();
            this.ArgN3Label = new System.Windows.Forms.Label();
            this.ArgF3Label = new System.Windows.Forms.Label();
            this.ArgF2Label = new System.Windows.Forms.Label();
            this.ArgF1Label = new System.Windows.Forms.Label();
            this.ArgF6Label = new System.Windows.Forms.Label();
            this.ArgF5Label = new System.Windows.Forms.Label();
            this.ArgF4Label = new System.Windows.Forms.Label();
            this.EndureIdLabel = new System.Windows.Forms.Label();
            this.DamageIdLabel = new System.Windows.Forms.Label();
            this.EAnimationIdComboBox = new System.Windows.Forms.ComboBox();
            this.TimingTextBox = new System.Windows.Forms.TextBox();
            this.CoordNameTextBox = new System.Windows.Forms.TextBox();
            this.ArgN1TextBox = new System.Windows.Forms.TextBox();
            this.ArgN2TextBox = new System.Windows.Forms.TextBox();
            this.ArgN3TextBox = new System.Windows.Forms.TextBox();
            this.ArgF1TextBox = new System.Windows.Forms.TextBox();
            this.ArgF6TextBox = new System.Windows.Forms.TextBox();
            this.ArgF5TextBox = new System.Windows.Forms.TextBox();
            this.ArgF4TextBox = new System.Windows.Forms.TextBox();
            this.ArgF3TextBox = new System.Windows.Forms.TextBox();
            this.ArgF2TextBox = new System.Windows.Forms.TextBox();
            this.EndureIDTextBox = new System.Windows.Forms.TextBox();
            this.DamageIDTextBox = new System.Windows.Forms.TextBox();
            this.MassRenameButton = new System.Windows.Forms.Button();
            this.EvidComboBox = new System.Windows.Forms.ComboBox();
            this.MoveToButton = new System.Windows.Forms.Button();
            this.AutoUpdateCheckBox = new System.Windows.Forms.CheckBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenButton,
            this.toolStripSeparator1,
            this.SaveButton,
            this.toolStripSeparator2,
            this.SaveAsButton,
            this.BackupsButton,
            this.toolStripSeparator3,
            this.YoinkFromFileButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(625, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // OpenButton
            // 
            this.OpenButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.OpenButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenButton.Image")));
            this.OpenButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenButton.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(40, 22);
            this.OpenButton.Text = "Open";
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveButton
            // 
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveButton.Enabled = false;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(35, 22);
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SaveAsButton.Enabled = false;
            this.SaveAsButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsButton.Image")));
            this.SaveAsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAsButton.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(51, 22);
            this.SaveAsButton.Text = "Save As";
            this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // BackupsButton
            // 
            this.BackupsButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.BackupsButton.CheckOnClick = true;
            this.BackupsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BackupsButton.Image = ((System.Drawing.Image)(resources.GetObject("BackupsButton.Image")));
            this.BackupsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackupsButton.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.BackupsButton.Name = "BackupsButton";
            this.BackupsButton.Size = new System.Drawing.Size(106, 22);
            this.BackupsButton.Text = "✘ Enable Backups";
            this.BackupsButton.CheckStateChanged += new System.EventHandler(this.BackupsButton_CheckStateChanged);
            this.BackupsButton.Click += new System.EventHandler(this.BackupsButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator3.Margin = new System.Windows.Forms.Padding(0, 0, 5, 0);
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // YoinkFromFileButton
            // 
            this.YoinkFromFileButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.YoinkFromFileButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.YoinkFromFileButton.Enabled = false;
            this.YoinkFromFileButton.Image = ((System.Drawing.Image)(resources.GetObject("YoinkFromFileButton.Image")));
            this.YoinkFromFileButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.YoinkFromFileButton.Margin = new System.Windows.Forms.Padding(0, 1, 5, 2);
            this.YoinkFromFileButton.Name = "YoinkFromFileButton";
            this.YoinkFromFileButton.Size = new System.Drawing.Size(175, 22);
            this.YoinkFromFileButton.Text = "Copy Entries From Another File";
            this.YoinkFromFileButton.Click += new System.EventHandler(this.YoinkFromFileButton_Click);
            // 
            // NameOfTableIDLabel
            // 
            this.NameOfTableIDLabel.AutoSize = true;
            this.NameOfTableIDLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameOfTableIDLabel.ForeColor = System.Drawing.Color.White;
            this.NameOfTableIDLabel.Location = new System.Drawing.Point(12, 38);
            this.NameOfTableIDLabel.Name = "NameOfTableIDLabel";
            this.NameOfTableIDLabel.Size = new System.Drawing.Size(97, 15);
            this.NameOfTableIDLabel.TabIndex = 1002;
            this.NameOfTableIDLabel.Text = "Name of Table ID";
            // 
            // NameOfTableIDTextbox
            // 
            this.NameOfTableIDTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameOfTableIDTextbox.Enabled = false;
            this.NameOfTableIDTextbox.Location = new System.Drawing.Point(12, 56);
            this.NameOfTableIDTextbox.Name = "NameOfTableIDTextbox";
            this.NameOfTableIDTextbox.Size = new System.Drawing.Size(120, 23);
            this.NameOfTableIDTextbox.TabIndex = 0;
            // 
            // EventListBox
            // 
            this.EventListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EventListBox.ImeMode = System.Windows.Forms.ImeMode.On;
            this.EventListBox.ItemHeight = 15;
            this.EventListBox.Location = new System.Drawing.Point(12, 82);
            this.EventListBox.Name = "EventListBox";
            this.EventListBox.ScrollAlwaysVisible = true;
            this.EventListBox.Size = new System.Drawing.Size(270, 484);
            this.EventListBox.TabIndex = 1;
            this.EventListBox.SelectedIndexChanged += new System.EventHandler(this.EventListBox_SelectedIndexChanged);
            // 
            // DuplicateButton
            // 
            this.DuplicateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DuplicateButton.Enabled = false;
            this.DuplicateButton.Location = new System.Drawing.Point(12, 600);
            this.DuplicateButton.Margin = new System.Windows.Forms.Padding(10);
            this.DuplicateButton.Name = "DuplicateButton";
            this.DuplicateButton.Size = new System.Drawing.Size(90, 25);
            this.DuplicateButton.TabIndex = 19;
            this.DuplicateButton.Text = "Duplicate";
            this.DuplicateButton.UseVisualStyleBackColor = true;
            this.DuplicateButton.Click += new System.EventHandler(this.DuplicateButton_Click);
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MoveDownButton.Enabled = false;
            this.MoveDownButton.Location = new System.Drawing.Point(102, 600);
            this.MoveDownButton.Margin = new System.Windows.Forms.Padding(10);
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(90, 25);
            this.MoveDownButton.TabIndex = 21;
            this.MoveDownButton.Text = "Move Down";
            this.MoveDownButton.UseVisualStyleBackColor = true;
            this.MoveDownButton.Click += new System.EventHandler(this.MoveDownButton_Click);
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MoveUpButton.Enabled = false;
            this.MoveUpButton.Location = new System.Drawing.Point(102, 570);
            this.MoveUpButton.Margin = new System.Windows.Forms.Padding(10);
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(90, 25);
            this.MoveUpButton.TabIndex = 20;
            this.MoveUpButton.Text = "Move Up";
            this.MoveUpButton.UseVisualStyleBackColor = true;
            this.MoveUpButton.Click += new System.EventHandler(this.MoveUpButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoveButton.Enabled = false;
            this.RemoveButton.Location = new System.Drawing.Point(192, 600);
            this.RemoveButton.Margin = new System.Windows.Forms.Padding(10);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(90, 25);
            this.RemoveButton.TabIndex = 23;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(12, 570);
            this.AddButton.Margin = new System.Windows.Forms.Padding(10);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(90, 25);
            this.AddButton.TabIndex = 18;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // SaveChangesToMoveButton
            // 
            this.SaveChangesToMoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveChangesToMoveButton.Enabled = false;
            this.SaveChangesToMoveButton.Location = new System.Drawing.Point(507, 600);
            this.SaveChangesToMoveButton.Name = "SaveChangesToMoveButton";
            this.SaveChangesToMoveButton.Size = new System.Drawing.Size(106, 25);
            this.SaveChangesToMoveButton.TabIndex = 24;
            this.SaveChangesToMoveButton.Text = "Apply Changes";
            this.SaveChangesToMoveButton.UseVisualStyleBackColor = true;
            this.SaveChangesToMoveButton.Click += new System.EventHandler(this.SaveChangesToMoveButton_Click);
            // 
            // EAnimationIdLabel
            // 
            this.EAnimationIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EAnimationIdLabel.AutoSize = true;
            this.EAnimationIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.EAnimationIdLabel.ForeColor = System.Drawing.Color.White;
            this.EAnimationIdLabel.Location = new System.Drawing.Point(300, 38);
            this.EAnimationIdLabel.Name = "EAnimationIdLabel";
            this.EAnimationIdLabel.Size = new System.Drawing.Size(77, 15);
            this.EAnimationIdLabel.TabIndex = 1009;
            this.EAnimationIdLabel.Text = "Animation ID";
            // 
            // TimingLabel
            // 
            this.TimingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimingLabel.AutoSize = true;
            this.TimingLabel.BackColor = System.Drawing.Color.Transparent;
            this.TimingLabel.ForeColor = System.Drawing.Color.White;
            this.TimingLabel.Location = new System.Drawing.Point(300, 146);
            this.TimingLabel.Name = "TimingLabel";
            this.TimingLabel.Size = new System.Drawing.Size(44, 15);
            this.TimingLabel.TabIndex = 1010;
            this.TimingLabel.Text = "Timing";
            // 
            // EvidLabel
            // 
            this.EvidLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EvidLabel.AutoSize = true;
            this.EvidLabel.BackColor = System.Drawing.Color.Transparent;
            this.EvidLabel.ForeColor = System.Drawing.Color.White;
            this.EvidLabel.Location = new System.Drawing.Point(300, 93);
            this.EvidLabel.Name = "EvidLabel";
            this.EvidLabel.Size = new System.Drawing.Size(50, 15);
            this.EvidLabel.TabIndex = 1011;
            this.EvidLabel.Text = "Event ID";
            // 
            // CoordNameLabel
            // 
            this.CoordNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoordNameLabel.AutoSize = true;
            this.CoordNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.CoordNameLabel.ForeColor = System.Drawing.Color.White;
            this.CoordNameLabel.Location = new System.Drawing.Point(300, 400);
            this.CoordNameLabel.Name = "CoordNameLabel";
            this.CoordNameLabel.Size = new System.Drawing.Size(101, 15);
            this.CoordNameLabel.TabIndex = 1012;
            this.CoordNameLabel.Text = "Coordinate Name";
            // 
            // ArgN1Label
            // 
            this.ArgN1Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgN1Label.AutoSize = true;
            this.ArgN1Label.BackColor = System.Drawing.Color.Transparent;
            this.ArgN1Label.ForeColor = System.Drawing.Color.White;
            this.ArgN1Label.Location = new System.Drawing.Point(300, 214);
            this.ArgN1Label.Name = "ArgN1Label";
            this.ArgN1Label.Size = new System.Drawing.Size(87, 15);
            this.ArgN1Label.TabIndex = 1013;
            this.ArgN1Label.Text = "Argument Int 1";
            // 
            // ArgN2Label
            // 
            this.ArgN2Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgN2Label.AutoSize = true;
            this.ArgN2Label.BackColor = System.Drawing.Color.Transparent;
            this.ArgN2Label.ForeColor = System.Drawing.Color.White;
            this.ArgN2Label.Location = new System.Drawing.Point(300, 276);
            this.ArgN2Label.Name = "ArgN2Label";
            this.ArgN2Label.Size = new System.Drawing.Size(87, 15);
            this.ArgN2Label.TabIndex = 1014;
            this.ArgN2Label.Text = "Argument Int 2";
            // 
            // ArgN3Label
            // 
            this.ArgN3Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgN3Label.AutoSize = true;
            this.ArgN3Label.BackColor = System.Drawing.Color.Transparent;
            this.ArgN3Label.ForeColor = System.Drawing.Color.White;
            this.ArgN3Label.Location = new System.Drawing.Point(300, 338);
            this.ArgN3Label.Name = "ArgN3Label";
            this.ArgN3Label.Size = new System.Drawing.Size(87, 15);
            this.ArgN3Label.TabIndex = 1015;
            this.ArgN3Label.Text = "Argument Int 3";
            // 
            // ArgF3Label
            // 
            this.ArgF3Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgF3Label.AutoSize = true;
            this.ArgF3Label.BackColor = System.Drawing.Color.Transparent;
            this.ArgF3Label.ForeColor = System.Drawing.Color.White;
            this.ArgF3Label.Location = new System.Drawing.Point(469, 338);
            this.ArgF3Label.Name = "ArgF3Label";
            this.ArgF3Label.Size = new System.Drawing.Size(99, 15);
            this.ArgF3Label.TabIndex = 1018;
            this.ArgF3Label.Text = "Argument Float 3";
            // 
            // ArgF2Label
            // 
            this.ArgF2Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgF2Label.AutoSize = true;
            this.ArgF2Label.BackColor = System.Drawing.Color.Transparent;
            this.ArgF2Label.ForeColor = System.Drawing.Color.White;
            this.ArgF2Label.Location = new System.Drawing.Point(469, 276);
            this.ArgF2Label.Name = "ArgF2Label";
            this.ArgF2Label.Size = new System.Drawing.Size(99, 15);
            this.ArgF2Label.TabIndex = 1017;
            this.ArgF2Label.Text = "Argument Float 2";
            // 
            // ArgF1Label
            // 
            this.ArgF1Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgF1Label.AutoSize = true;
            this.ArgF1Label.BackColor = System.Drawing.Color.Transparent;
            this.ArgF1Label.ForeColor = System.Drawing.Color.White;
            this.ArgF1Label.Location = new System.Drawing.Point(469, 214);
            this.ArgF1Label.Name = "ArgF1Label";
            this.ArgF1Label.Size = new System.Drawing.Size(99, 15);
            this.ArgF1Label.TabIndex = 1016;
            this.ArgF1Label.Text = "Argument Float 1";
            // 
            // ArgF6Label
            // 
            this.ArgF6Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgF6Label.AutoSize = true;
            this.ArgF6Label.BackColor = System.Drawing.Color.Transparent;
            this.ArgF6Label.ForeColor = System.Drawing.Color.White;
            this.ArgF6Label.Location = new System.Drawing.Point(469, 524);
            this.ArgF6Label.Name = "ArgF6Label";
            this.ArgF6Label.Size = new System.Drawing.Size(99, 15);
            this.ArgF6Label.TabIndex = 1021;
            this.ArgF6Label.Text = "Argument Float 6";
            // 
            // ArgF5Label
            // 
            this.ArgF5Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgF5Label.AutoSize = true;
            this.ArgF5Label.BackColor = System.Drawing.Color.Transparent;
            this.ArgF5Label.ForeColor = System.Drawing.Color.White;
            this.ArgF5Label.Location = new System.Drawing.Point(469, 462);
            this.ArgF5Label.Name = "ArgF5Label";
            this.ArgF5Label.Size = new System.Drawing.Size(99, 15);
            this.ArgF5Label.TabIndex = 1020;
            this.ArgF5Label.Text = "Argument Float 5";
            // 
            // ArgF4Label
            // 
            this.ArgF4Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgF4Label.AutoSize = true;
            this.ArgF4Label.BackColor = System.Drawing.Color.Transparent;
            this.ArgF4Label.ForeColor = System.Drawing.Color.White;
            this.ArgF4Label.Location = new System.Drawing.Point(469, 400);
            this.ArgF4Label.Name = "ArgF4Label";
            this.ArgF4Label.Size = new System.Drawing.Size(99, 15);
            this.ArgF4Label.TabIndex = 1019;
            this.ArgF4Label.Text = "Argument Float 4";
            // 
            // EndureIdLabel
            // 
            this.EndureIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndureIdLabel.AutoSize = true;
            this.EndureIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.EndureIdLabel.ForeColor = System.Drawing.Color.White;
            this.EndureIdLabel.Location = new System.Drawing.Point(300, 524);
            this.EndureIdLabel.Name = "EndureIdLabel";
            this.EndureIdLabel.Size = new System.Drawing.Size(58, 15);
            this.EndureIdLabel.TabIndex = 1023;
            this.EndureIdLabel.Text = "Endure ID";
            // 
            // DamageIdLabel
            // 
            this.DamageIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DamageIdLabel.AutoSize = true;
            this.DamageIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.DamageIdLabel.ForeColor = System.Drawing.Color.White;
            this.DamageIdLabel.Location = new System.Drawing.Point(300, 462);
            this.DamageIdLabel.Name = "DamageIdLabel";
            this.DamageIdLabel.Size = new System.Drawing.Size(65, 15);
            this.DamageIdLabel.TabIndex = 1022;
            this.DamageIdLabel.Text = "Damage ID";
            // 
            // EAnimationIdComboBox
            // 
            this.EAnimationIdComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EAnimationIdComboBox.DropDownWidth = 200;
            this.EAnimationIdComboBox.Enabled = false;
            this.EAnimationIdComboBox.FormattingEnabled = true;
            this.EAnimationIdComboBox.Items.AddRange(new object[] {
            "ADV_ATK_FINISH_CUT",
            "ADV_ATK_FINISH_ST",
            "ADV_ATK_FINISH_ST_A",
            "ADV_BATTLE_ST01",
            "ADV_BATTLE_ST02",
            "ADV_BATTLE_ST03",
            "ADV_BATTLE_ST04",
            "ADV_BATTLE_ST05",
            "ADV_CHASERUN",
            "ADV_CHASERUN_ED",
            "ADV_COWARDWALK",
            "ADV_COWARDWALK_ED",
            "ADV_COWARD_TURN_L180",
            "ADV_COWARD_TURN_L90",
            "ADV_COWARD_TURN_R180",
            "ADV_COWARD_TURN_R90",
            "ADV_COWARD_WALK_L180",
            "ADV_COWARD_WALK_L90",
            "ADV_COWARD_WALK_R180",
            "ADV_COWARD_WALK_R90",
            "ADV_ENCOUNTER_CUT01",
            "ADV_ENCOUNTER_CUT02",
            "ADV_ENCOUNTER_CUT03",
            "ADV_ENCOUNTER_CUT04",
            "ADV_ENCOUNTER_CUT05",
            "ADV_FINISH_CHANCE",
            "ADV_FREEBATTLE_ST01",
            "ADV_JUMP_F",
            "ADV_JUMP_F_WALK",
            "ADV_JUMP_N",
            "ADV_MINIGAME_NPC_DECIDE",
            "ADV_MINIGAME_NPC_DECIDE_LP",
            "ADV_MINIGAME_NPC_IN",
            "ADV_MINIGAME_NPC_IN_LP",
            "ADV_NUT",
            "ADV_PAILRUN",
            "ADV_PAILRUN_ED",
            "ADV_PREIA_M00_P0001_00",
            "ADV_PREIA_M00_P0008_00",
            "ADV_PREIA_M01_P0001_00",
            "ADV_PREIA_M01_P1002_00",
            "ADV_PREIA_M02_P0001_00",
            "ADV_PREIA_M02_P1003_00",
            "ADV_PREIA_M03_P0001_00",
            "ADV_PREIA_M03_P1004_00",
            "ADV_PREIA_M04_P0001_00",
            "ADV_PREIA_M04_P1006_00",
            "ADV_PREIA_M05_P0001_00",
            "ADV_PREIA_M05_P0001_01",
            "ADV_PREIA_M05_P1007_00",
            "ADV_PREIA_M05_P1007_01",
            "ADV_PREIA_M08_P0001_00",
            "ADV_PREIA_M08_P0012_00",
            "ADV_PREIA_M08_P0012_01",
            "ADV_PREIA_M08_P1011_00",
            "ADV_PREIA_M08_P1012_00",
            "ADV_PREIA_M08_P1012_01",
            "ADV_PREIA_M09_P0001_00",
            "ADV_PREIA_M09_P0012_00",
            "ADV_RUN",
            "ADV_RUNAWAY",
            "ADV_RUNAWAY_ED",
            "ADV_RUN_ED",
            "ADV_RUSHMOVE",
            "ADV_RUSHMOVE_ED",
            "ADV_SMALLRUN",
            "ADV_SMALLRUN_ED",
            "ADV_TREEWALK",
            "ADV_TREEWALK_ED",
            "ADV_TURN_L180",
            "ADV_TURN_L90",
            "ADV_TURN_R180",
            "ADV_TURN_R90",
            "ADV_VS_ED",
            "ADV_VS_ED_UPPER",
            "ADV_VS_ST",
            "ADV_VS_ST_UPPER",
            "ADV_WALK",
            "ADV_WALK_ED",
            "ADV_WALK_L180",
            "ADV_WALK_L90",
            "ADV_WALK_R180",
            "ADV_WALK_R90",
            "ATK_CMB_W1_LIGHT",
            "ATK_CMB_W1",
            "ATK_CMB_W2",
            "ATK_CMB_W3",
            "ATK_CMB_W4",
            "ATK_CMB_W5",
            "ATK_CMB_W6",
            "ATK_CMB_W7",
            "ATK_CMB_W8",
            "ATK_CMB_W9",
            "ATK_CMB_W10",
            "ATK_CMB_D3",
            "ATK_CMB_U3",
            "ATK_CMB_S1",
            "ATK_CMB_W1_A",
            "ATK_CMB_W2_A",
            "ATK_CMB_W3_A",
            "ATK_CMB_W4_A",
            "ATK_CMB_W5_A",
            "ATK_CMB_W6_A",
            "ATK_CMB_W7_A",
            "ATK_CMB_W8_A",
            "ATK_CMB_W9_A",
            "ATK_CMB_W10_A",
            "ATK_CMB_D3_A",
            "ATK_CMB_U3_A",
            "ATK_BURST1",
            "ATK_BURST1_A",
            "ATK_PUSHBACK_GUARD",
            "ATK_SKILL1_01",
            "ATK_SKILL1_01_A",
            "ATK_SKILL1_02",
            "ATK_SKILL1_02_A",
            "ATK_SKILL1_03",
            "ATK_SKILL1_03_A",
            "ATK_SKILL1_CUT",
            "ATK_SKILL2_01",
            "ATK_SKILL2_01_A",
            "ATK_SKILL2_02",
            "ATK_SKILL2_02_A",
            "ATK_SKILL2_03",
            "ATK_SKILL2_03_A",
            "ATK_SKILL2_CUT",
            "ATK_SKILL3_01",
            "ATK_SKILL3_01_A",
            "ATK_SKILL3_02",
            "ATK_SKILL3_02_A",
            "ATK_SKILL3_03",
            "ATK_SKILL3_03_A",
            "ATK_SKILL3_CUT",
            "ATK_SKILL4_01",
            "ATK_SKILL4_01_A",
            "ATK_SKILL4_02",
            "ATK_SKILL4_02_A",
            "ATK_SKILL4_03",
            "ATK_SKILL4_03_A",
            "ATK_SKILL4_CUT",
            "ATK_SKILL5_01",
            "ATK_SKILL5_01_A",
            "ATK_SKILL5_02",
            "ATK_SKILL5_02_A",
            "ATK_SKILL5_03",
            "ATK_SKILL5_03_A",
            "ATK_SKILL5_CUT",
            "ATK_SKILL6_01",
            "ATK_SKILL6_01_A",
            "ATK_SKILL6_02",
            "ATK_SKILL6_02_A",
            "ATK_SKILL6_03",
            "ATK_SKILL6_03_A",
            "ATK_SKILL6_CUT",
            "ATK_SKILL7_01",
            "ATK_SKILL7_01_A",
            "ATK_SKILL7_02",
            "ATK_SKILL7_02_A",
            "ATK_SKILL7_03",
            "ATK_SKILL7_03_A",
            "ATK_SKILL7_CUT",
            "ATK_SKILL8_01",
            "ATK_SKILL8_01_A",
            "ATK_SKILL8_02",
            "ATK_SKILL8_02_A",
            "ATK_SKILL8_03",
            "ATK_SKILL8_03_A",
            "ATK_SKILL8_CUT",
            "ATK_SKILL9_01",
            "ATK_SKILL9_01_A",
            "ATK_SKILL9_02",
            "ATK_SKILL9_02_A",
            "ATK_SKILL9_03",
            "ATK_SKILL9_03_A",
            "ATK_SKILL9_CUT",
            "ATK_SKILL10_01",
            "ATK_SKILL10_01_A",
            "ATK_SKILL10_02",
            "ATK_SKILL10_02_A",
            "ATK_SKILL10_03",
            "ATK_SKILL10_03_A",
            "ATK_SKILL10_CUT",
            "ATK_SKILL11_01",
            "ATK_SKILL11_01_A",
            "ATK_SKILL11_02",
            "ATK_SKILL11_02_A",
            "ATK_SKILL11_03",
            "ATK_SKILL11_03_A",
            "ATK_SKILL11_CUT",
            "ATK_SKILL12_01",
            "ATK_SKILL12_01_A",
            "ATK_SKILL12_02",
            "ATK_SKILL12_02_A",
            "ATK_SKILL12_03",
            "ATK_SKILL12_03_A",
            "ATK_SKILL12_CUT",
            "ATK_SKILL13_01",
            "ATK_SKILL13_01_A",
            "ATK_SKILL13_02",
            "ATK_SKILL13_02_A",
            "ATK_SKILL13_03",
            "ATK_SKILL13_03_A",
            "ATK_SKILL13_CUT",
            "ATK_SKILL14_01",
            "ATK_SKILL14_01_A",
            "ATK_SKILL14_02",
            "ATK_SKILL14_02_A",
            "ATK_SKILL14_03",
            "ATK_SKILL14_03_A",
            "ATK_SKILL14_CUT",
            "ATK_SKILL15_01",
            "ATK_SKILL15_01_A",
            "ATK_SKILL15_02",
            "ATK_SKILL15_02_A",
            "ATK_SKILL15_03",
            "ATK_SKILL15_03_A",
            "ATK_SKILL15_CUT",
            "ATK_SPL_ST",
            "ATK_SPL_ST_AUTO",
            "ATK_THROW_CUT",
            "ATK_THROW_ST",
            "ATK_TRACKING_A",
            "ATK_UNIQUE_ACT1",
            "ATK_UNIQUE_ACT1_A",
            "ATK_UNIQUE_ACT2",
            "ATK_UNIQUE_ACT2_A",
            "ATK_UNIQUE_ACT3",
            "ATK_UNIQUE_ACT3_A",
            "ATK_UNIQUE_ACT4",
            "ATK_UNIQUE_ACT4_A",
            "ATK_UNIQUE_ACT5",
            "ATK_UNIQUE_ACT5_A",
            "ATK_UNQ_W1",
            "ATK_UNQ_W1_A",
            "BASE_ATTACKED_LAND",
            "BASE_AWAKE_N",
            "BASE_AWAKE_SP_CUT",
            "BASE_CHARGE",
            "BASE_CLASH",
            "BASE_DAMAGED_LAND",
            "BASE_DASH",
            "BASE_DASH_A",
            "BASE_DASH_ATK",
            "BASE_DASH_BLEND_L",
            "BASE_DASH_BLEND_R",
            "BASE_DASH_CLASH",
            "BASE_DASH_ED",
            "BASE_DASH_JUMP",
            "BASE_DASH_JUMP_LAND",
            "BASE_EMOTE_V1",
            "BASE_EMOTE_V2",
            "BASE_EMOTE_V3",
            "BASE_EMOTE_V4",
            "BASE_EMOTE_V5",
            "BASE_GUARD_ED",
            "BASE_GUARD_LP",
            "BASE_GUARD_ST",
            "BASE_JUMP_F",
            "BASE_JUMP_F2",
            "BASE_JUMP_F_FALL",
            "BASE_JUMP_F_LAND",
            "BASE_JUMP_F_WALK",
            "BASE_JUMP_F_WALK2",
            "BASE_JUMP_N",
            "BASE_JUMP_N2",
            "BASE_JUMP_N_FALL",
            "BASE_JUMP_N_FALL_LIGHT",
            "BASE_JUMP_N_LAND",
            "BASE_NUT",
            "BASE_REPEL",
            "BASE_REPEL_SUCSESS",
            "BASE_RUN",
            "BASE_RUN_ED",
            "BASE_RUN_FAST",
            "BASE_STEP_A_B",
            "BASE_STEP_A_F",
            "BASE_STEP_A_L",
            "BASE_STEP_A_R",
            "BASE_STEP_B",
            "BASE_STEP_F",
            "BASE_STEP_L",
            "BASE_STEP_L2",
            "BASE_STEP_R",
            "BASE_STEP_R2",
            "BASE_TIRED",
            "BASE_TIRED_A",
            "BASE_TIRED_ED",
            "BASE_WALK_B",
            "BASE_WALK_B_ED",
            "BASE_WALK_F",
            "BASE_WALK_F_ED",
            "BASE_WALK_L",
            "BASE_WALK_L_ED",
            "BASE_WALK_R",
            "BASE_WALK_R_ED",
            "BOSS_BATTLE_ST01",
            "BOSS_BATTLE_ST02",
            "BOSS_BATTLE_ST03",
            "BOSS_BATTLE_ST04",
            "BOSS_BATTLE_ST05",
            "BOSS_BATTLE_ST06",
            "BOSS_BATTLE_ST07",
            "BOSS_BATTLE_ST08",
            "BOSS_BATTLE_ST09",
            "BOSS_BATTLE_ST10",
            "BOSS_BATTLE_ST11",
            "BOSS_BATTLE_ST12",
            "BOSS_BATTLE_ST13",
            "BOSS_BATTLE_ST14",
            "BOSS_BATTLE_ST15",
            "BOSS_BATTLE_ST16",
            "BOSS_BATTLE_ST17",
            "BOSS_BATTLE_ST18",
            "BOSS_BATTLE_ST19",
            "BOSS_BATTLE_ST20",
            "BOSS_DMG_PUSH",
            "BOSS_E0005_DMG_WEBBIND",
            "BOSS_EVENT_DOWN",
            "BOSS_P1002_HEAL_HAND_BOTH",
            "BOSS_P1002_HEAL_HAND_L",
            "BOSS_P1002_HEAL_HAND_R",
            "BOSS_P1002_PAIN_HAND_L01",
            "BOSS_P1002_PAIN_HAND_L02",
            "BOSS_P1002_PAIN_HAND_R01",
            "BOSS_P1002_PAIN_HAND_R02",
            "BOSS_P1003_DMG_TRAP",
            "BOSS_P1003_DOWN_A_IN",
            "BOSS_P1003_DOWN_G_IN",
            "BOSS_P1003_DOWN_IN",
            "BOSS_P1003_STEP_IN1",
            "BOSS_P1003_STEP_IN2",
            "BOSS_P1003_STEP_OUT1",
            "BOSS_P1003_STEP_OUT2",
            "BOSS_P1003_STEP_OUT3",
            "BOSS_P1003_TURN2_L180",
            "BOSS_P1003_TURN2_L90",
            "BOSS_P1003_TURN2_R180",
            "BOSS_P1003_TURN2_R90",
            "BOSS_P1004_DMG_2HIT",
            "BOSS_P1004_DMG_ALLOW",
            "BOSS_P1004_DMG_BLOW_B",
            "BOSS_P1004_DMG_FALL",
            "BOSS_P1004_DMG_STRIKE",
            "BOSS_P1006_DMG_ROOM_ROT",
            "BOSS_RAGE_COOLDOWN_ED",
            "BOSS_RAGE_COOLDOWN_LP",
            "BOSS_RAGE_COOLDOWN_ST",
            "BOSS_RAGE_ED",
            "BOSS_RAGE_ST",
            "DMG_ADD",
            "DMG_ADD10",
            "DMG_ADD2",
            "DMG_ADD3",
            "DMG_ADD4",
            "DMG_ADD5",
            "DMG_ADD6",
            "DMG_ADD7",
            "DMG_ADD8",
            "DMG_ADD9",
            "DMG_BIND",
            "DMG_BLOW_B",
            "DMG_BLOW_F",
            "DMG_BLOW_SPIN",
            "DMG_BOUND_F",
            "DMG_CONNECT1",
            "DMG_CONNECT2",
            "DMG_CONNECT3",
            "DMG_CONNECT4",
            "DMG_CONNECT5",
            "DMG_CUT",
            "DMG_CUT_FEMALE",
            "DMG_DEAD",
            "DMG_DEAD_A",
            "DMG_DEAD_DOWN",
            "DMG_DEAD_DOWN_D",
            "DMG_DEFEAT",
            "DMG_DIZZY",
            "DMG_DOWN",
            "DMG_DOWN_B_LP",
            "DMG_DOWN_B_ST_STRIKE",
            "DMG_DOWN_FALL",
            "DMG_DOWN_F_LP",
            "DMG_DOWN_F_ST_L",
            "DMG_DOWN_F_ST_S",
            "DMG_DOWN_F_ST_STRIKE",
            "DMG_FINISH_BLOW",
            "DMG_FINISH_BLOW_FEMALE",
            "DMG_GET_UP_B",
            "DMG_GET_UP_F",
            "DMG_GET_UP_FAST",
            "DMG_GUARD",
            "DMG_GUARD_CLASH",
            "DMG_GUARD_L",
            "DMG_L_A_B",
            "DMG_L_A_F",
            "DMG_L_A_U",
            "DMG_L_B",
            "DMG_L_F",
            "DMG_L_G",
            "DMG_L_U",
            "DMG_RECOVERY_B",
            "DMG_REPEL",
            "DMG_REPEL_A",
            "DMG_SKILL1",
            "DMG_SKILL10",
            "DMG_SKILL10_FEMALE",
            "DMG_SKILL11",
            "DMG_SKILL11_FEMALE",
            "DMG_SKILL12",
            "DMG_SKILL12_FEMALE",
            "DMG_SKILL13",
            "DMG_SKILL13_FEMALE",
            "DMG_SKILL14",
            "DMG_SKILL14_FEMALE",
            "DMG_SKILL15",
            "DMG_SKILL15_FEMALE",
            "DMG_SKILL1_FEMALE",
            "DMG_SKILL2",
            "DMG_SKILL2_FEMALE",
            "DMG_SKILL3",
            "DMG_SKILL3_FEMALE",
            "DMG_SKILL4",
            "DMG_SKILL4_FEMALE",
            "DMG_SKILL5",
            "DMG_SKILL5_FEMALE",
            "DMG_SKILL6",
            "DMG_SKILL6_FEMALE",
            "DMG_SKILL7",
            "DMG_SKILL7_FEMALE",
            "DMG_SKILL8",
            "DMG_SKILL8_FEMALE",
            "DMG_SKILL9",
            "DMG_SKILL9_FEMALE",
            "DMG_SLEEP",
            "DMG_SLIDE_B_ROLLING",
            "DMG_SLIDE_F",
            "DMG_SLIDE_F_ROLLING",
            "DMG_SPL",
            "DMG_SPL_FEMALE",
            "DMG_STRIKE_B",
            "DMG_STRIKE_F",
            "DMG_SUPPORT_ASSIST_L",
            "DMG_SUPPORT_ASSIST_R",
            "DMG_S_A_B",
            "DMG_S_A_F",
            "DMG_S_A_L",
            "DMG_S_A_R",
            "DMG_S_A_U",
            "DMG_S_B",
            "DMG_S_F",
            "DMG_S_L",
            "DMG_S_R",
            "DMG_S_U",
            "DMG_THROW",
            "DMG_THROW_CUT",
            "DMG_THROW_CUT_FEMALE",
            "DMG_THROW_FEMALE",
            "DMG_UPPER_B",
            "DMG_UPPER_F",
            "FACE_ADV_ANGRY01",
            "FACE_ADV_NUT01",
            "FACE_ADV_SAD01",
            "FACE_ADV_SCARED01",
            "FACE_ADV_SMILE01",
            "FACE_DMG_BIND",
            "FACE_DMG_DOWN",
            "FACE_DMG_DOWN_LP",
            "FACE_DMG_GETUP",
            "FACE_DMG_L",
            "FACE_DMG_NUT03",
            "FACE_DMG_S",
            "FACE_DMG_SLEEP",
            "FACE_NUT01",
            "FACE_NUT02",
            "FACE_TALK_LP",
            "FACE_VS_BATTLE_ED_RXN",
            "MINIGAME_DMG",
            "MINIGAME_JUMP",
            "MINIGAME_STEP_B",
            "MINIGAME_STEP_L",
            "MINIGAME_STEP_R",
            "ONI_AVOIDANCE",
            "ONI_AVOIDANCE_A",
            "SUPPORT_ACTION",
            "SUPPORT_ACTION02",
            "SUPPORT_ACTION_RUSH",
            "SUPPORT_ASSIST",
            "SUPPORT_ASSIST_A",
            "SUPPORT_ASSIST_L",
            "SUPPORT_ASSIST_R",
            "SUPPORT_ENTER",
            "SUPPORT_EXIT",
            "USE_ITEM",
            "VS_BATTLE_ED_RXN",
            "VS_BATTLE_ST01",
            "VS_BATTLE_ST02",
            "VS_BATTLE_ST03",
            "VS_BATTLE_ST04",
            "VS_BATTLE_ST05",
            "VS_WIN_CUT01",
            "VS_WIN_CUT02",
            "VS_WIN_CUT03",
            "VS_WIN_CUT04",
            "VS_WIN_CUT05"});
            this.EAnimationIdComboBox.Location = new System.Drawing.Point(300, 56);
            this.EAnimationIdComboBox.Name = "EAnimationIdComboBox";
            this.EAnimationIdComboBox.Size = new System.Drawing.Size(313, 23);
            this.EAnimationIdComboBox.TabIndex = 3;
            this.EAnimationIdComboBox.Leave += new System.EventHandler(this.EAnimationIdComboBox_Leave);
            // 
            // TimingTextBox
            // 
            this.TimingTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TimingTextBox.Enabled = false;
            this.TimingTextBox.Location = new System.Drawing.Point(300, 164);
            this.TimingTextBox.Name = "TimingTextBox";
            this.TimingTextBox.Size = new System.Drawing.Size(313, 23);
            this.TimingTextBox.TabIndex = 5;
            this.TimingTextBox.TextChanged += new System.EventHandler(this.Generalized_TextChanged);
            this.TimingTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Generalized_KeyPress);
            this.TimingTextBox.Leave += new System.EventHandler(this.Generalized_Leave);
            // 
            // CoordNameTextBox
            // 
            this.CoordNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoordNameTextBox.Enabled = false;
            this.CoordNameTextBox.Location = new System.Drawing.Point(300, 418);
            this.CoordNameTextBox.Name = "CoordNameTextBox";
            this.CoordNameTextBox.Size = new System.Drawing.Size(144, 23);
            this.CoordNameTextBox.TabIndex = 9;
            // 
            // ArgN1TextBox
            // 
            this.ArgN1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgN1TextBox.Enabled = false;
            this.ArgN1TextBox.Location = new System.Drawing.Point(300, 232);
            this.ArgN1TextBox.Name = "ArgN1TextBox";
            this.ArgN1TextBox.Size = new System.Drawing.Size(144, 23);
            this.ArgN1TextBox.TabIndex = 6;
            this.ArgN1TextBox.TextChanged += new System.EventHandler(this.Generalized_TextChanged);
            this.ArgN1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Generalized_KeyPress);
            this.ArgN1TextBox.Leave += new System.EventHandler(this.Generalized_Leave);
            // 
            // ArgN2TextBox
            // 
            this.ArgN2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgN2TextBox.Enabled = false;
            this.ArgN2TextBox.Location = new System.Drawing.Point(300, 294);
            this.ArgN2TextBox.Name = "ArgN2TextBox";
            this.ArgN2TextBox.Size = new System.Drawing.Size(144, 23);
            this.ArgN2TextBox.TabIndex = 7;
            this.ArgN2TextBox.TextChanged += new System.EventHandler(this.Generalized_TextChanged);
            this.ArgN2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Generalized_KeyPress);
            this.ArgN2TextBox.Leave += new System.EventHandler(this.Generalized_Leave);
            // 
            // ArgN3TextBox
            // 
            this.ArgN3TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgN3TextBox.Enabled = false;
            this.ArgN3TextBox.Location = new System.Drawing.Point(300, 356);
            this.ArgN3TextBox.Name = "ArgN3TextBox";
            this.ArgN3TextBox.Size = new System.Drawing.Size(144, 23);
            this.ArgN3TextBox.TabIndex = 8;
            this.ArgN3TextBox.TextChanged += new System.EventHandler(this.Generalized_TextChanged);
            this.ArgN3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Generalized_KeyPress);
            this.ArgN3TextBox.Leave += new System.EventHandler(this.Generalized_Leave);
            // 
            // ArgF1TextBox
            // 
            this.ArgF1TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgF1TextBox.Enabled = false;
            this.ArgF1TextBox.Location = new System.Drawing.Point(469, 232);
            this.ArgF1TextBox.Name = "ArgF1TextBox";
            this.ArgF1TextBox.Size = new System.Drawing.Size(144, 23);
            this.ArgF1TextBox.TabIndex = 12;
            this.ArgF1TextBox.TextChanged += new System.EventHandler(this.Generalized_TextChanged);
            this.ArgF1TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Generalized_KeyPress);
            this.ArgF1TextBox.Leave += new System.EventHandler(this.Generalized_Leave);
            // 
            // ArgF6TextBox
            // 
            this.ArgF6TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgF6TextBox.Enabled = false;
            this.ArgF6TextBox.Location = new System.Drawing.Point(469, 542);
            this.ArgF6TextBox.Name = "ArgF6TextBox";
            this.ArgF6TextBox.Size = new System.Drawing.Size(144, 23);
            this.ArgF6TextBox.TabIndex = 17;
            this.ArgF6TextBox.TextChanged += new System.EventHandler(this.Generalized_TextChanged);
            this.ArgF6TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Generalized_KeyPress);
            this.ArgF6TextBox.Leave += new System.EventHandler(this.Generalized_Leave);
            // 
            // ArgF5TextBox
            // 
            this.ArgF5TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgF5TextBox.Enabled = false;
            this.ArgF5TextBox.Location = new System.Drawing.Point(469, 480);
            this.ArgF5TextBox.Name = "ArgF5TextBox";
            this.ArgF5TextBox.Size = new System.Drawing.Size(144, 23);
            this.ArgF5TextBox.TabIndex = 16;
            this.ArgF5TextBox.TextChanged += new System.EventHandler(this.Generalized_TextChanged);
            this.ArgF5TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Generalized_KeyPress);
            this.ArgF5TextBox.Leave += new System.EventHandler(this.Generalized_Leave);
            // 
            // ArgF4TextBox
            // 
            this.ArgF4TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgF4TextBox.Enabled = false;
            this.ArgF4TextBox.Location = new System.Drawing.Point(469, 418);
            this.ArgF4TextBox.Name = "ArgF4TextBox";
            this.ArgF4TextBox.Size = new System.Drawing.Size(144, 23);
            this.ArgF4TextBox.TabIndex = 15;
            this.ArgF4TextBox.TextChanged += new System.EventHandler(this.Generalized_TextChanged);
            this.ArgF4TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Generalized_KeyPress);
            this.ArgF4TextBox.Leave += new System.EventHandler(this.Generalized_Leave);
            // 
            // ArgF3TextBox
            // 
            this.ArgF3TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgF3TextBox.Enabled = false;
            this.ArgF3TextBox.Location = new System.Drawing.Point(469, 357);
            this.ArgF3TextBox.Name = "ArgF3TextBox";
            this.ArgF3TextBox.Size = new System.Drawing.Size(144, 23);
            this.ArgF3TextBox.TabIndex = 14;
            this.ArgF3TextBox.TextChanged += new System.EventHandler(this.Generalized_TextChanged);
            this.ArgF3TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Generalized_KeyPress);
            this.ArgF3TextBox.Leave += new System.EventHandler(this.Generalized_Leave);
            // 
            // ArgF2TextBox
            // 
            this.ArgF2TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ArgF2TextBox.Enabled = false;
            this.ArgF2TextBox.Location = new System.Drawing.Point(469, 294);
            this.ArgF2TextBox.Name = "ArgF2TextBox";
            this.ArgF2TextBox.Size = new System.Drawing.Size(144, 23);
            this.ArgF2TextBox.TabIndex = 13;
            this.ArgF2TextBox.TextChanged += new System.EventHandler(this.Generalized_TextChanged);
            this.ArgF2TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Generalized_KeyPress);
            this.ArgF2TextBox.Leave += new System.EventHandler(this.Generalized_Leave);
            // 
            // EndureIDTextBox
            // 
            this.EndureIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EndureIDTextBox.Enabled = false;
            this.EndureIDTextBox.Location = new System.Drawing.Point(300, 542);
            this.EndureIDTextBox.Name = "EndureIDTextBox";
            this.EndureIDTextBox.Size = new System.Drawing.Size(144, 23);
            this.EndureIDTextBox.TabIndex = 11;
            // 
            // DamageIDTextBox
            // 
            this.DamageIDTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DamageIDTextBox.Enabled = false;
            this.DamageIDTextBox.Location = new System.Drawing.Point(300, 480);
            this.DamageIDTextBox.Name = "DamageIDTextBox";
            this.DamageIDTextBox.Size = new System.Drawing.Size(144, 23);
            this.DamageIDTextBox.TabIndex = 10;
            // 
            // MassRenameButton
            // 
            this.MassRenameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MassRenameButton.Enabled = false;
            this.MassRenameButton.Location = new System.Drawing.Point(138, 56);
            this.MassRenameButton.Name = "MassRenameButton";
            this.MassRenameButton.Size = new System.Drawing.Size(144, 24);
            this.MassRenameButton.TabIndex = 2;
            this.MassRenameButton.Text = "Mass Rename Table IDs";
            this.MassRenameButton.UseVisualStyleBackColor = true;
            this.MassRenameButton.Click += new System.EventHandler(this.MassRenameButton_Click);
            // 
            // EvidComboBox
            // 
            this.EvidComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EvidComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EvidComboBox.DropDownWidth = 180;
            this.EvidComboBox.Enabled = false;
            this.EvidComboBox.FormattingEnabled = true;
            this.EvidComboBox.Items.AddRange(new object[] {
            "NONE",
            "ME_SET_SPEED",
            "ME_OVERRIDE_SPEED",
            "ME_RESET_SPEED",
            "ME_ALL_RESET_SPEED",
            "ME_WARP_AROUND_PLAYER",
            "ME_WARP_AROUND_ENEMY",
            "ME_SET_Z_SPEED_TARGET_LENGTH",
            "ME_SET_SPEED_TARGET_LENGTH",
            "ME_SET_SPEED_DECELERATION",
            "ME_RESERVE_ALL_RESET_SPEED",
            "ME_LANDING_STATE_SET_AIR",
            "ME_Z_SPEED_GROUND_LENGTH",
            "ME_SET_SPEED_INERTIA",
            "ME_DROP_GROUND",
            "ME_SET_ROTATION",
            "ME_START_TURN_LOCKON_TARGET",
            "ME_END_TURN_LOCKON_TARGET",
            "ME_START_TURN_ANGLE",
            "ME_END_TURN_ANGLE",
            "ME_HOMING_SET",
            "ME_HOMING_END",
            "ME_TOBE_TRACKED_ON",
            "ME_TOBE_TRACKED_OFF",
            "ME_AND_TAR_RELATIVE_TURN",
            "ME_ACT_FINISH_RESERVE_ROTATION",
            "ME_ATKHIT_ON",
            "ME_ATKHIT_OFF",
            "ME_ADD_GROUPE_ATTACK_HIT_ON",
            "ME_INCREDIBLE_ON",
            "ME_INCREDIBLE_OFF",
            "ME_INVINCIBLE_TIMER",
            "ME_THIS_COLLISION_CHANNEL_OFF",
            "ME_THIS_COLLISION_CHANNEL_ON",
            "ME_OPP_COLLISION_CHANNEL_OFF",
            "ME_OPP_COLLISION_CHANNEL_ON",
            "ME_OPP_COLLISION_ON",
            "ME_OPP_COLLISION_OFF",
            "ME_SET_BODY_COLLISION_SIZE",
            "ME_SENSING_COLLISION_ON",
            "ME_SENSING_COLLISION_OFF",
            "ME_MELEE_COLLISION_ENABLE_BRANCH_TPYE_SET",
            "ME_MELEE_COLLISION_ENABLE_BRANCH_TPYE_REMOVE",
            "ME_SECTION_JUMP_CHECK",
            "ME_CHECK_ANIM_FRAME_JUMP",
            "ME_PROC_SECTION_JUMP",
            "ME_SECTION_CHECK",
            "ME_CHECK_HEIGHT",
            "ME_TIMER_CHECK",
            "ME_ON_COLLIDE_SENSING",
            "ME_LANDING_CHECK",
            "ME_ON_MELEE_ATTACK_HIT",
            "ME_ON_SKILL_ATTACK_HIT",
            "ME_ON_NOT_CAPTURE_ANGLE",
            "ME_ON_CAPTURE_CAMERA_ANGLE",
            "ME_ON_NOT_CAPTURE_CAMERA_ANGLE",
            "ME_ON_ANIM_CAMERA_END",
            "ME_DELETE_STATE_SENSING_EVENT",
            "ME_ON_LAND",
            "ME_ON_ATTACK_HIT",
            "ME_ON_APPROACHED_TARGET",
            "ME_ON_CAPTURE_ANGLE",
            "ME_CHECK_TARGET_DAMAGE_REACTION",
            "ME_CHECK_ADVENTURE_MODE",
            "ME_ON_FALL",
            "ME_ON_HIT_WALL",
            "ME_IS_STRENGTH_BREATH_STATE",
            "ME_NO_STRENGTHEN_STATE",
            "ME_WEAPON_BREAK_CHECK",
            "ME_ON_ATTACK_HIT_TO_LOCKON_TARGET",
            "ME_ON_COMPARATIVE_BRUNCH_OF_TARGET_POSITION",
            "ME_CHECK_ACTION_BRANCH_PRM",
            "ME_OUT_CAPTURE_ANGLE",
            "ME_CHECK_DETECTING",
            "ME_ALL_EVENT_RESET",
            "ME_ACTION_CANCEL_ON",
            "ME_ACTION_CANCEL_OFF",
            "ME_TREAT_ACTION_FINISH",
            "ME_ON_NO_ACCEPT_INPUT_WITH_TIME",
            "ME_ANIMATION_RATE_CHANGE",
            "ME_SET_MOTION_RATE",
            "ME_SUPER_ARMOR_ON",
            "ME_SUPER_ARMOR_OFF",
            "ME_SET_ON_COMBAT",
            "ME_SET_OFF_COMBAT",
            "ME_SET_ACTION_CHARGE",
            "ME_SLOW_TO_SELF",
            "ME_SLOW_TO_SELF_AND_TARGET",
            "ME_SLOW_TO_OTHERS",
            "ME_MOTION_MOVE_LINK_ON",
            "ME_MOTION_MOVE_LINK_OFF",
            "ME_RIGOR_TIME_ADDITION",
            "ME_BOUND",
            "ME_RELEASE_THROW_STATE",
            "ME_SET_RECOVERY_FLAG",
            "ME_SET_ACTION_BRANCH_PRM",
            "ME_TRACKING_DASH_AIR",
            "ME_JUMP_RANDOM_COUNTER",
            "ME_DISABLE_ADD_DAMAGE_MOTION",
            "ME_ENABLE_ADD_DAMAGE_MOTION",
            "ME_SET_LANDING_ACTION",
            "ME_BROADCAST_KILL_EVENT",
            "ME_WEAPON_VISIBLE_ON",
            "ME_WEAPON_VISIBLE_OFF",
            "ME_TAKE_CHARACTER_WEAPON",
            "ME_PUT_BACK_CHARACTER_WEAPON",
            "ME_CHARA_DRAW_ON",
            "ME_CHARA_DRAW_OFF",
            "SET_SCALE",
            "ME_CHARACTER_OTHER_VISIBLE_ON",
            "ME_CHARACTER_OTHER_VISIBLE_OFF",
            "ME_SET_NO_DEAD_FLG",
            "ME_ONE_SIDE_WEAPON_ON",
            "ME_ONE_SIDE_WEAPON_OFF",
            "ME_SET_ADD_DAMAGE_RATE",
            "ME_RESET_ADD_DAMAGE_RATE",
            "ME_SET_DETECT_RECEIVE",
            "RESET_MATERIAL_ANIMATION",
            "ME_ATTACH_SOCKETS",
            "ME_DETACH_SOCKETS",
            "ME_NON_SLIDE_WALL_ON",
            "ME_NON_SLIDE_WALL_OFF",
            "ME_ON_LOCKON",
            "SET_SP_CAMERA_TYPE",
            "ME_ATTACH_ANIM_CAMERA",
            "ME_DETACH_ANIM_CAMERA",
            "ME_LOCKON_CHANGE_INPUT_ON",
            "ME_LOCKON_CHANGE_INPUT_OFF",
            "ME_PAUSE_TO_OTHERS",
            "ME_RELEASE_PAUSE_TO_OTHERS",
            "ME_SET_ALL_SLOW",
            "ME_OPP_CHARACTER_MOVE",
            "ME_THIS_SAVE_POS_AND_ROT",
            "ME_THIS_LOAD_POS_AND_ROT",
            "ME_OPP_SAVE_POS_AND_ROT",
            "ME_OPP_LOAD_POS_AND_ROT",
            "ME_PLAY_SEQUENCER",
            "ME_SET_MATERIAL_SECTION",
            "ME_SEND_NEXT_ROUND_ENABLE",
            "ME_END_SPL",
            "ME_SET_WARP_BATTLE_AREA_PERFORMANCE",
            "ME_START_ACTION_PERFORMANCE",
            "ME_END_ACTION_PERFORMANCE",
            "ME_SET_OFFSET_LOCATION",
            "CHILD_REQUEST_ACTION",
            "ME_RESERVE_DISABLE_AND_HIDDEN",
            "CHILD_REQUEST_ACTION_FINISH",
            "CHILD_SECTION_JUMP_CHECK",
            "ME_OPP_SET_PAUSE",
            "CHILD_START_TURN_ANGLE",
            "CIHLD_END_TURN_ANGLE",
            "CHILD_SET_DETECT_RECEIVE",
            "ME_ENTRY_PROJECTILE",
            "ME_ENTRY_PROJECTILE_OFFSET",
            "ME_DELETE_RECENTLY_PROJECTILE",
            "ME_RESERVE_DELETE_RECENTLY_PROJECTILE",
            "ME_CANCEL_DELETE_RECENTLY_PROJECTILE",
            "ME_CHECK_HIT_STOP",
            "RESERVE_PERFORMANCE",
            "ME_ON_ATTACK_HIT_TO_INVINCIBLE_TARGET",
            "CHECK_TARGET_UNENABLE_ACTION",
            "ME_MOVE_TO_TARGET_DIR",
            "ME_SET_STRENGTHEN_SPEED_BY_CHARGE",
            "ME_RESET_STRENGTHEN_SPEED_BY_CHARGE",
            "ME_ALL_RESET_STRENGTHEN_SPEED_BY_CHARGE",
            "ME_APPLY_STRENGTHEN_SPEED",
            "ME_APPLY_STRENGTHEN_MOVE_TO_TARGET_DIR",
            "ME_CHARA_PUSH_ENABLE",
            "ME_MY_CHARACTER_STATUS_BUFF_DEBUFF_SETTING",
            "ME_CHECK_INPUT",
            "ME_CHANGE_MOTION_EVENT",
            "ME_ADD_VALUE_MOTION_EVENT",
            "ME_SAVE_VALUE_MOTION_EVENT",
            "ME_CHECK_AUTO_COMBO",
            "ME_SET_CHECK_FALL",
            "ME_ADD_PUSH_LEVEL",
            "ME_OVERRIDE_SPEED_BRAKE",
            "ME_START_MOVE_HOMING",
            "ME_END_MOVE_HOMING",
            "ME_OPP_OWNER_COLLISION_ON",
            "ME_OPP_OWNER_COLLISION_OFF",
            "TARGET_RESET_SPEED",
            "TARGET_ALL_RESET_SPEED",
            "CAMERA_SET_CLIP",
            "TARGET_PHYSICAL_REVISE_POSITION",
            "ME_ON_ATTACK_HIT_TO_DOWN_TARGET",
            "REQUEST_FADE_IN_OUT",
            "REQUEST_FADE_CLEAR",
            "ME_SET_WEAKNING",
            "MOVE_TO_TARGET",
            "SETUP_TARGET",
            "MOVE_TO_TARGET_FINISH",
            "ME_EXIT_FROM_WORLD",
            "ME_ENTRY_IN_WORLD",
            "ME_REMOVE_LOCKON",
            "ME_ADD_LOCKON",
            "ME_START_TARGET_FOLLOW",
            "ME_END_TARGET_FOLLOW",
            "START_ACTION_CHILD",
            "STOP_NUMA_EFFECT",
            "SET_LANDING_NUMA",
            "PLAY_NUMA_EFFECT",
            "RECIVE_ATTACK",
            "SET_ADJUST_GRAVITY",
            "SET_GARAVITY_SPEED",
            "SET_ADJUST_FRICTION",
            "SET_FRICTION_VALUE",
            "SET_ANM_CAMERA_FLIP_ON",
            "SET_ANM_CAMERA_FLIP_OFF",
            "TARGET_CHANGE_LOCKON_SUPPORT",
            "CHECK_MAIN_CHARACTER_SPECIFY_ANIMATION",
            "SET_ROOT_MOVE_SCALE_BY_TARGET_DIST",
            "RESET_ROOT_MOVE_SCALE",
            "SET_ENERGY_RECOVERY_RATE",
            "SET_NO_ACCEPT_INPUT",
            "REQUEST_ACTION_ANIM_ID",
            "ME_UNIQUE_ACTION_SUPER_ARMOR_ON",
            "START_CANCEL_RECEPTION",
            "END_CANCEL_RECEPTION",
            "ADD_SAME_SKILL_CANCEL_ENABLE_TO_CANCEL",
            "SET_TARGET_RELATIVE_POSITION",
            "WARP_TARGET_RELATIVE_POSITION",
            "ME_THIS_ENV_COLLISION_CHANNEL_OFF",
            "ME_THIS_ENV_COLLISION_CHANNEL_ON",
            "SET_DISABLE_CLOTH_SIMULATION",
            "SET_BOUNDS_SCALE",
            "ME_Z_SPEED_TARGET_LENGTH",
            "SET_ACTOR_ROTATION",
            "ME_AND_TAR_SAME_TURN",
            "MESH_SET_RELATIVE_LOCATION",
            "ME_MOVE_DIR_UPDATE",
            "CHECK_WALL_TO_FRAME_JUMP",
            "ME_HITSTOP_TO_ALL_RESET_SPEED",
            "SET_HITSTOP_TO_GRAVITY",
            "ME_INVINCIBLE_GROUND_ON",
            "ME_INVINCIBLE_AIR_ON",
            "ME_INVINCIBLE_GROUND_AIR_OFF",
            "ADD_CMB_CANCEL_ENABLE_TO_CANCEL",
            "ME_SET_SPEED_RATE_TARGET_LENGTH",
            "ME_RESET_SPEED_RATE",
            "ME_ALL_RESET_SPEED_RATE",
            "ME_CHECK_BUFF_DEBUFF_ENABLE",
            "RESET_ALL_SLOW",
            "ME_ON_ATTACK_HIT_TARGET_OF_ALL_STATE",
            "CHECK_TARGET_DEAD",
            "ME_RELEASE_RESERVATION_DEAD",
            "ME_P1005_CHANGE_BALL_VISIBLE",
            "ME_REMOTE_SKILL_COUNT",
            "CHECK_TARGET_AIR",
            "RAGE_AURASTART",
            "RAGE_AURAEND",
            "ME_RESET_ADD_SPEED",
            "ME_START_TURN_LOCATOR",
            "ME_ON_MAIN_CHARACTER_MELEE_ATTACK_HIT",
            "ME_CHECK_UNIQUE_ACTION_COST",
            "START_DARK_CHANGE_POST_PROCESS",
            "END_DARK_CHANGE_POST_PROCESS",
            "PAUSE_PARTICLE",
            "RELEASE_PAUSE_PARTICLE",
            "HIDE_PARTICLE",
            "RELEASE_HIDE_PARTICLE",
            "HIDE_REMOTE_SKILL",
            "RELEASE_HIDE_REMOTE_SKILL",
            "ME_ON_APPROACHED_PARTNER",
            "ME_MOVE_TO_PARTNER_DIR",
            "ME_PARTNER_ATTACH_SOCKETS",
            "ME_PARTNER_DETACH_SOCKETS",
            "ME_AND_PARTNER_SAME_TURN",
            "ME_PARTNER_COLLISION_CHANNEL_ON",
            "ME_PARTNER_COLLISION_CHANNEL_OFF",
            "CHECK_ACTION_SPL_PERFORMING",
            "CHECK_DASH_AIR",
            "ME_SET_DMG_ACTION_TO_CONNECT_DOWN",
            "CHECK_NEXT_ACTION",
            "ME_1003_DRAGIN_ATTACK_START",
            "INTERP_OFFSET_MOVE",
            "CONTROLLER_VIBRATION",
            "ME_SET_ADV_TURN_SPEED",
            "ME_JUMP_MAIN_MOTION_EVENT",
            "ME_ADD_VALUE_SUB_MOTION_EVENT",
            "ME_SAVE_VALUE_SUB_MOTION_EVENT",
            "ME_STOP_SUB_MOTION_EVENT",
            "ME_1003_COMMAND",
            "ME_1003_REVIVE",
            "SET_FACIAL_ENABLE",
            "ME_SET_PUSH_IGNORE_TEAM",
            "FINISH_SPECIAL_SEQUENCER",
            "REQUEST_SPL_PERFORMANCE",
            "SET_RETURN_TO_VS_CAMERA_LOCATION",
            "ME_CREATE_MELEECOLLISION_UNITGROUP",
            "ME_CREATE_MELEECOLLISION_UNIT",
            "ME_DELETE_MELEECOLLISION_UNIT",
            "ME_DELETE_MELEECOLLISION_UNITGROUP",
            "END_COMBO_CAMERA",
            "ME_1006_ROOM_ROT_COMMAND",
            "ME_RESET_CAMERA_AFTER_SPL_PERFORMANCE",
            "ME_SHOW_SUPER_AWAKE_STAGE_EFFECT",
            "ME_SHOW_SUPER_AWAKE_CAMERA_EFFECT",
            "ME_1008_TREE_MOVE",
            "ME_1008_TREE_END",
            "ME_1008_TREE_START",
            "ME_DIST_CHECK_MAIN_MOTION_EVENT_JUMP",
            "ME_1008_MOVE_RUIN",
            "ME_CHECK_STAGE_EDGE",
            "ME_TURN_OWN_AND_TARGET_KEEP_REL_TRANSFORM",
            "ME_RESET_ALL_SPEED_AT_STAGE_EDGE",
            "ME_ENABLE_REPEL",
            "ME_DISABLE_REPEL",
            "ME_RECOVERY_SUPPORT_GUAGE",
            "ME_SET_BODY_COLLISION_ENABLE",
            "ME_E0001_V02_SET_ABILITY",
            "ME_P1011_V02_ARM_TARGET_CHASE_START",
            "ME_P1011_V02_ARM_TARGET_CHASE_END",
            "ME_P1011_V02_ARM_POSTURE_CALC_SET",
            "ME_START_TURN_MOVE_LOCATOR",
            "ME_ON_CAPTURE_ANGLE_BONE_BASE",
            "ME_WARP_TO_LOCATOR",
            "ME_P1011_V02_ARM_TARGET_EFF_SET",
            "ME_CHILD_START_TURN_PARENT_ANGLE",
            "ME_CHANGE_TO_DESTRUCTION_MESH",
            "ME_RECOVER_LIFE",
            "ME_ENABLE_SUPPORT",
            "ME_DISABLE_SUPPORT",
            "ME_ROUND_END_PERFORM_SET",
            "ME_ROUND_END_PERFORM_CLEAN",
            "ME_1003_DRAGIN_ATTACK_ANOTHER_START",
            "ME_SHOW_JUMP_GUIDE_UI",
            "ME_INSTANT_RECOVER_LIFE",
            "ME_DURATION_RECOVER_LIFE",
            "ME_DURATION_RECOVER_PAUSE_ON",
            "ME_DURATION_RECOVER_PAUSE_OFF",
            "ME_SET_ROTATION_TO_INPUT_DIRECTION",
            "ME_ENABLE_SUPPORT_ENEMY",
            "ME_DISABLE_SUPPORT_ENEMY",
            "ME_BELOW_GROUND_WARP_PARTNER"});
            this.EvidComboBox.Location = new System.Drawing.Point(300, 111);
            this.EvidComboBox.Name = "EvidComboBox";
            this.EvidComboBox.Size = new System.Drawing.Size(313, 23);
            this.EvidComboBox.TabIndex = 4;
            // 
            // MoveToButton
            // 
            this.MoveToButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MoveToButton.Enabled = false;
            this.MoveToButton.Location = new System.Drawing.Point(192, 570);
            this.MoveToButton.Name = "MoveToButton";
            this.MoveToButton.Size = new System.Drawing.Size(90, 25);
            this.MoveToButton.TabIndex = 22;
            this.MoveToButton.Text = "Move to...";
            this.MoveToButton.UseVisualStyleBackColor = true;
            this.MoveToButton.Click += new System.EventHandler(this.MoveToButton_Click);
            // 
            // AutoUpdateCheckBox
            // 
            this.AutoUpdateCheckBox.AutoSize = true;
            this.AutoUpdateCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.AutoUpdateCheckBox.Enabled = false;
            this.AutoUpdateCheckBox.ForeColor = System.Drawing.Color.White;
            this.AutoUpdateCheckBox.Location = new System.Drawing.Point(138, 37);
            this.AutoUpdateCheckBox.Name = "AutoUpdateCheckBox";
            this.AutoUpdateCheckBox.Size = new System.Drawing.Size(93, 19);
            this.AutoUpdateCheckBox.TabIndex = 25;
            this.AutoUpdateCheckBox.Text = "Auto Update";
            this.AutoUpdateCheckBox.UseVisualStyleBackColor = false;
            this.AutoUpdateCheckBox.CheckedChanged += new System.EventHandler(this.AutoUpdateCheckBox_CheckedChanged);
            // 
            // EventEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(625, 634);
            this.Controls.Add(this.AutoUpdateCheckBox);
            this.Controls.Add(this.MoveToButton);
            this.Controls.Add(this.EvidComboBox);
            this.Controls.Add(this.MassRenameButton);
            this.Controls.Add(this.EndureIDTextBox);
            this.Controls.Add(this.DamageIDTextBox);
            this.Controls.Add(this.ArgF6TextBox);
            this.Controls.Add(this.ArgF5TextBox);
            this.Controls.Add(this.ArgF4TextBox);
            this.Controls.Add(this.ArgF3TextBox);
            this.Controls.Add(this.ArgF2TextBox);
            this.Controls.Add(this.ArgF1TextBox);
            this.Controls.Add(this.ArgN3TextBox);
            this.Controls.Add(this.ArgN2TextBox);
            this.Controls.Add(this.ArgN1TextBox);
            this.Controls.Add(this.CoordNameTextBox);
            this.Controls.Add(this.TimingTextBox);
            this.Controls.Add(this.EAnimationIdComboBox);
            this.Controls.Add(this.EndureIdLabel);
            this.Controls.Add(this.DamageIdLabel);
            this.Controls.Add(this.ArgF6Label);
            this.Controls.Add(this.ArgF5Label);
            this.Controls.Add(this.ArgF4Label);
            this.Controls.Add(this.ArgF3Label);
            this.Controls.Add(this.ArgF2Label);
            this.Controls.Add(this.ArgF1Label);
            this.Controls.Add(this.ArgN3Label);
            this.Controls.Add(this.ArgN2Label);
            this.Controls.Add(this.ArgN1Label);
            this.Controls.Add(this.CoordNameLabel);
            this.Controls.Add(this.EvidLabel);
            this.Controls.Add(this.TimingLabel);
            this.Controls.Add(this.EAnimationIdLabel);
            this.Controls.Add(this.DuplicateButton);
            this.Controls.Add(this.MoveDownButton);
            this.Controls.Add(this.MoveUpButton);
            this.Controls.Add(this.RemoveButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.SaveChangesToMoveButton);
            this.Controls.Add(this.NameOfTableIDLabel);
            this.Controls.Add(this.NameOfTableIDTextbox);
            this.Controls.Add(this.EventListBox);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(641, 673);
            this.Name = "EventEditorForm";
            this.Text = "Demon Slayer Event Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.EventEditorForm_FormClosed);
            this.Load += new System.EventHandler(this.EventEditorForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton OpenButton;
        private ToolStripButton SaveButton;
        private ToolStripButton SaveAsButton;
        private ToolStripButton BackupsButton;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private Label NameOfTableIDLabel;
        private TextBox NameOfTableIDTextbox;
        private Button DuplicateButton;
        private Button MoveDownButton;
        private Button MoveUpButton;
        private Button RemoveButton;
        private Button AddButton;
        private Button SaveChangesToMoveButton;
        private Label EAnimationIdLabel;
        private Label TimingLabel;
        private Label EvidLabel;
        private Label CoordNameLabel;
        private Label ArgN1Label;
        private Label ArgN2Label;
        private Label ArgN3Label;
        private Label ArgF3Label;
        private Label ArgF2Label;
        private Label ArgF1Label;
        private Label ArgF6Label;
        private Label ArgF5Label;
        private Label ArgF4Label;
        private Label EndureIdLabel;
        private Label DamageIdLabel;
        private ComboBox EAnimationIdComboBox;
        private TextBox TimingTextBox;
        private TextBox CoordNameTextBox;
        private TextBox ArgN1TextBox;
        private TextBox ArgN2TextBox;
        private TextBox ArgN3TextBox;
        private TextBox ArgF1TextBox;
        private TextBox ArgF6TextBox;
        private TextBox ArgF5TextBox;
        private TextBox ArgF4TextBox;
        private TextBox ArgF3TextBox;
        private TextBox ArgF2TextBox;
        private TextBox EndureIDTextBox;
        private TextBox DamageIDTextBox;
        private Button MassRenameButton;
        private ComboBox EvidComboBox;
        internal ListBox EventListBox;
        private Button MoveToButton;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripButton YoinkFromFileButton;
        private CheckBox AutoUpdateCheckBox;
    }
}