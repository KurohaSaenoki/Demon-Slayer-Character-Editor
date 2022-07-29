namespace Demon_Slayer_Character_Editor
{
    partial class MoveToIndexForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MoveToIndexForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NoButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.MoveToTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MoveToCheckBox = new System.Windows.Forms.CheckBox();
            this.AmountOfTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.NoButton);
            this.panel1.Controls.Add(this.OKButton);
            this.panel1.Location = new System.Drawing.Point(-2, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 50);
            this.panel1.TabIndex = 0;
            // 
            // NoButton
            // 
            this.NoButton.Location = new System.Drawing.Point(148, 13);
            this.NoButton.Name = "NoButton";
            this.NoButton.Size = new System.Drawing.Size(75, 23);
            this.NoButton.TabIndex = 1;
            this.NoButton.Text = "Cancel";
            this.NoButton.UseVisualStyleBackColor = true;
            this.NoButton.Click += new System.EventHandler(this.NoButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(36, 13);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 0;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // MoveToTextBox
            // 
            this.MoveToTextBox.Location = new System.Drawing.Point(34, 36);
            this.MoveToTextBox.Name = "MoveToTextBox";
            this.MoveToTextBox.Size = new System.Drawing.Size(222, 23);
            this.MoveToTextBox.TabIndex = 1;
            this.MoveToTextBox.TextChanged += new System.EventHandler(this.MoveToTextBox_TextChanged);
            this.MoveToTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MoveToTextBox_KeyPress);
            this.MoveToTextBox.Leave += new System.EventHandler(this.MoveToTextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Move To Index:";
            // 
            // MoveToCheckBox
            // 
            this.MoveToCheckBox.AutoSize = true;
            this.MoveToCheckBox.Location = new System.Drawing.Point(34, 71);
            this.MoveToCheckBox.Name = "MoveToCheckBox";
            this.MoveToCheckBox.Size = new System.Drawing.Size(103, 19);
            this.MoveToCheckBox.TabIndex = 3;
            this.MoveToCheckBox.Text = "Move Sections";
            this.MoveToCheckBox.UseVisualStyleBackColor = true;
            this.MoveToCheckBox.CheckedChanged += new System.EventHandler(this.MoveToCheckBox_CheckedChanged);
            // 
            // AmountOfTextBox
            // 
            this.AmountOfTextBox.Enabled = false;
            this.AmountOfTextBox.Location = new System.Drawing.Point(34, 89);
            this.AmountOfTextBox.Name = "AmountOfTextBox";
            this.AmountOfTextBox.PlaceholderText = "Amount of Sections to Move...";
            this.AmountOfTextBox.Size = new System.Drawing.Size(222, 23);
            this.AmountOfTextBox.TabIndex = 4;
            this.AmountOfTextBox.TextChanged += new System.EventHandler(this.AmountOfTextBox_TextChanged);
            this.AmountOfTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AmountOfTextBox_KeyPress);
            this.AmountOfTextBox.Leave += new System.EventHandler(this.AmountOfTextBox_Leave);
            // 
            // MoveToIndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(302, 180);
            this.Controls.Add(this.AmountOfTextBox);
            this.Controls.Add(this.MoveToTextBox);
            this.Controls.Add(this.MoveToCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MoveToIndexForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MoveToIndexForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button NoButton;
        private Button OKButton;
        private TextBox MoveToTextBox;
        private Label label1;
        private CheckBox MoveToCheckBox;
        private TextBox AmountOfTextBox;
    }
}