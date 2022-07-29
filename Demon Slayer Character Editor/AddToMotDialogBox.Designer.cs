namespace Demon_Slayer_Character_Editor
{
    partial class AddToMotDialogBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddToMotDialogBox));
            this.BasicButton = new System.Windows.Forms.Button();
            this.DamageReactionButton = new System.Windows.Forms.Button();
            this.MeleeButton = new System.Windows.Forms.Button();
            this.SupportButton = new System.Windows.Forms.Button();
            this.AddToMotLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BasicButton
            // 
            this.BasicButton.Location = new System.Drawing.Point(26, 17);
            this.BasicButton.Name = "BasicButton";
            this.BasicButton.Size = new System.Drawing.Size(109, 32);
            this.BasicButton.TabIndex = 0;
            this.BasicButton.Text = "Basic";
            this.BasicButton.UseVisualStyleBackColor = true;
            this.BasicButton.Click += new System.EventHandler(this.BasicButton_Click);
            // 
            // DamageReactionButton
            // 
            this.DamageReactionButton.Location = new System.Drawing.Point(141, 17);
            this.DamageReactionButton.Name = "DamageReactionButton";
            this.DamageReactionButton.Size = new System.Drawing.Size(109, 32);
            this.DamageReactionButton.TabIndex = 1;
            this.DamageReactionButton.Text = "Damage Reaction";
            this.DamageReactionButton.UseVisualStyleBackColor = true;
            this.DamageReactionButton.Click += new System.EventHandler(this.DamageReactionButton_Click);
            // 
            // MeleeButton
            // 
            this.MeleeButton.Location = new System.Drawing.Point(256, 17);
            this.MeleeButton.Name = "MeleeButton";
            this.MeleeButton.Size = new System.Drawing.Size(109, 32);
            this.MeleeButton.TabIndex = 2;
            this.MeleeButton.Text = "Melee";
            this.MeleeButton.UseVisualStyleBackColor = true;
            this.MeleeButton.Click += new System.EventHandler(this.MeleeButton_Click);
            // 
            // SupportButton
            // 
            this.SupportButton.Location = new System.Drawing.Point(371, 17);
            this.SupportButton.Name = "SupportButton";
            this.SupportButton.Size = new System.Drawing.Size(109, 32);
            this.SupportButton.TabIndex = 3;
            this.SupportButton.Text = "Support";
            this.SupportButton.UseVisualStyleBackColor = true;
            this.SupportButton.Click += new System.EventHandler(this.SupportButton_Click);
            // 
            // AddToMotLabel
            // 
            this.AddToMotLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddToMotLabel.Location = new System.Drawing.Point(26, 30);
            this.AddToMotLabel.Name = "AddToMotLabel";
            this.AddToMotLabel.Size = new System.Drawing.Size(454, 40);
            this.AddToMotLabel.TabIndex = 4;
            this.AddToMotLabel.Text = "This Animation ID does not exist within any of your mot files.\r\nSelect a file to " +
    "add it to.";
            this.AddToMotLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.BasicButton);
            this.panel1.Controls.Add(this.SupportButton);
            this.panel1.Controls.Add(this.DamageReactionButton);
            this.panel1.Controls.Add(this.MeleeButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 92);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(506, 65);
            this.panel1.TabIndex = 5;
            // 
            // AddToMotDialogBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(506, 157);
            this.Controls.Add(this.AddToMotLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddToMotDialogBox";
            this.Text = " ";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddToMotDialogBox_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button BasicButton;
        private Button DamageReactionButton;
        private Button MeleeButton;
        private Button SupportButton;
        private Label AddToMotLabel;
        private Panel panel1;
    }
}