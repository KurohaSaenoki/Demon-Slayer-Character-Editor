﻿namespace Demon_Slayer_Character_Editor
{
    partial class SelectAnimIDForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SelectAnimIDForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.NoButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.EAnimationIDLabel = new System.Windows.Forms.Label();
            this.EAnimationIdComboBox = new System.Windows.Forms.ComboBox();
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
            // EAnimationIDLabel
            // 
            this.EAnimationIDLabel.AutoSize = true;
            this.EAnimationIDLabel.Location = new System.Drawing.Point(12, 17);
            this.EAnimationIDLabel.Name = "EAnimationIDLabel";
            this.EAnimationIDLabel.Size = new System.Drawing.Size(80, 15);
            this.EAnimationIDLabel.TabIndex = 1;
            this.EAnimationIDLabel.Text = "Animation ID:";
            // 
            // EAnimationIdComboBox
            // 
            this.EAnimationIdComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EAnimationIdComboBox.DropDownWidth = 200;
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
            this.EAnimationIdComboBox.Location = new System.Drawing.Point(12, 35);
            this.EAnimationIdComboBox.Name = "EAnimationIdComboBox";
            this.EAnimationIdComboBox.Size = new System.Drawing.Size(232, 23);
            this.EAnimationIdComboBox.TabIndex = 1029;
            // 
            // SelectAnimIDForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(256, 127);
            this.Controls.Add(this.EAnimationIdComboBox);
            this.Controls.Add(this.EAnimationIDLabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SelectAnimIDForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SelectAnimIDForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button NoButton;
        private Button OKButton;
        private Label EAnimationIDLabel;
        private ComboBox EAnimationIdComboBox;
    }
}