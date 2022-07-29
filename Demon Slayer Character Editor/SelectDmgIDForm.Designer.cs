namespace Demon_Slayer_Character_Editor
{
    partial class SelectDmgIDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectDmgIDForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NoButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.DamageIDLabel = new System.Windows.Forms.Label();
            this.DamageIDComboBox = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.NoButton);
            this.panel1.Controls.Add(this.OKButton);
            this.panel1.Location = new System.Drawing.Point(-2, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 50);
            this.panel1.TabIndex = 0;
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(143, 13);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 1;
            this.NoButton.Text = "Cancel";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(39, 13);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // DamageIDLabel
            // 
            this.DamageIDLabel.AutoSize = true;
            this.DamageIDLabel.Location = new System.Drawing.Point(12, 17);
            this.DamageIDLabel.Name = "DamageIDLabel";
            this.DamageIDLabel.Size = new System.Drawing.Size(68, 15);
            this.DamageIDLabel.TabIndex = 1;
            this.DamageIDLabel.Text = "Damage ID:";
            // 
            // DamageIDComboBox
            // 
            this.DamageIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DamageIDComboBox.FormattingEnabled = true;
            this.DamageIDComboBox.Location = new System.Drawing.Point(12, 35);
            this.DamageIDComboBox.Name = "DamageIDComboBox";
            this.DamageIDComboBox.Size = new System.Drawing.Size(232, 23);
            this.DamageIDComboBox.TabIndex = 1031;
            // 
            // SelectDmgIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(256, 127);
            this.Controls.Add(this.DamageIDComboBox);
            this.Controls.Add(this.DamageIDLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectDmgIDForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectDmgIDForm_FormClosed);
            this.Load += new System.EventHandler(this.SelectDmgIDForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button NoButton;
        private Button OKButton;
        private Label DamageIDLabel;
        public ComboBox DamageIDComboBox;
    }
}