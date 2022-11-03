namespace Demon_Slayer_Character_Editor
{
    partial class StartupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartupForm));
            this.LaunchDmgEditorButton = new System.Windows.Forms.Button();
            this.LaunchEventButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.HowToUseButton = new System.Windows.Forms.ToolStripButton();
            this.AboutButton = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // LaunchDmgEditorButton
            // 
            this.LaunchDmgEditorButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LaunchDmgEditorButton.Location = new System.Drawing.Point(147, 175);
            this.LaunchDmgEditorButton.Name = "LaunchDmgEditorButton";
            this.LaunchDmgEditorButton.Size = new System.Drawing.Size(145, 39);
            this.LaunchDmgEditorButton.TabIndex = 0;
            this.LaunchDmgEditorButton.Text = "Damage Editor";
            this.LaunchDmgEditorButton.UseVisualStyleBackColor = true;
            this.LaunchDmgEditorButton.Click += new System.EventHandler(this.LaunchDmgEditorButton_Click);
            // 
            // LaunchEventButton
            // 
            this.LaunchEventButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LaunchEventButton.Location = new System.Drawing.Point(306, 175);
            this.LaunchEventButton.Name = "LaunchEventButton";
            this.LaunchEventButton.Size = new System.Drawing.Size(145, 39);
            this.LaunchEventButton.TabIndex = 1;
            this.LaunchEventButton.Text = "Event Editor";
            this.LaunchEventButton.UseVisualStyleBackColor = true;
            this.LaunchEventButton.Click += new System.EventHandler(this.LaunchEventButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HowToUseButton,
            this.AboutButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(598, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // HowToUseButton
            // 
            this.HowToUseButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.HowToUseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.HowToUseButton.Image = ((System.Drawing.Image)(resources.GetObject("HowToUseButton.Image")));
            this.HowToUseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HowToUseButton.Name = "HowToUseButton";
            this.HowToUseButton.Size = new System.Drawing.Size(73, 22);
            this.HowToUseButton.Text = "How To Use";
            this.HowToUseButton.Click += new System.EventHandler(this.HowToUseButton_Click);
            // 
            // AboutButton
            // 
            this.AboutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AboutButton.Image = ((System.Drawing.Image)(resources.GetObject("AboutButton.Image")));
            this.AboutButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AboutButton.Name = "AboutButton";
            this.AboutButton.Size = new System.Drawing.Size(44, 22);
            this.AboutButton.Text = "About";
            this.AboutButton.Click += new System.EventHandler(this.AboutButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 110);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(148, 324);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(460, 84);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // StartupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Demon_Slayer_Character_Editor.Properties.Resources.white;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(598, 400);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LaunchEventButton);
            this.Controls.Add(this.LaunchDmgEditorButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(614, 439);
            this.Name = "StartupForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Demon Slayer Character Editor | Ver 1.0.1";
            this.Activated += new System.EventHandler(this.StartupForm_Activated);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton AboutButton;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        public Button LaunchDmgEditorButton;
        public Button LaunchEventButton;
        public ToolStripButton HowToUseButton;
    }
}