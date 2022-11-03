using System.Globalization;
using System.Text.RegularExpressions;

namespace Demon_Slayer_Character_Editor
{
	public partial class EventEditorForm : Form
	{
		public Regex reg = new Regex(@"^-?\d+[.]?\d*$", System.Text.RegularExpressions.RegexOptions.CultureInvariant);
		public string[] ReadAllLines = Array.Empty<string>();
		public string[] ReadAllLinesOrig = Array.Empty<string>();
		public string[] ReadAllLinesBasic = Array.Empty<string>();
		public string[] ReadAllLinesBasicOrig = Array.Empty<string>();
		public string[] ReadAllLinesDamageReac = Array.Empty<string>();
		public string[] ReadAllLinesDamageReacOrig = Array.Empty<string>();
		public string[] ReadAllLinesMelee = Array.Empty<string>();
		public string[] ReadAllLinesMeleeOrig = Array.Empty<string>();
		public string[] ReadAllLinesSupport = Array.Empty<string>();
		public string[] ReadAllLinesSupportOrig = Array.Empty<string>();
		public string StreamingPath = "";
		public string StreamingPathOrig = "";
		public string StreamingPathBak = "";
		public string BasicStreamingPath = "";
		public string BasicStreamingPathOrig = "";
		public string BasicStreamingPathBak = "";
		public string DamageReacStreamingPath = "";
		public string DamageReacStreamingPathOrig = "";
		public string DamageReacStreamingPathBak = "";
		public string MeleeStreamingPath = "";
		public string MeleeStreamingPathOrig = "";
		public string MeleeStreamingPathBak = "";
		public string SupportStreamingPath = "";
		public string SupportStreamingPathOrig = "";
		public string SupportStreamingPathBak = "";
		public string YoinkStreamingPath = "";
		public string[] ReadAllLinesYoink = Array.Empty<string>();
		public string SaveAsPath = "";
		public bool IsEventFile = false;
		public bool FoundExport = false;
		public bool SavingFile = false;
		public string NewTblValueStr = "";
		public int NewVal = 1;
		public decimal Amount = 0;
		public string BlankName = "                \"Value\": \"\"";
		public string BlankValue = "                \"Value\": ";
		public string ValueStr = "                \"Value\": ";
		public string NewSectionPart1Str = @"          },
          {
            ""$type"": ""UAssetAPI.PropertyTypes.Structs.StructPropertyData, UAssetAPI"",
            ""StructType"": ""APKMotionEventImportParam"",
            ""SerializeNone"": true,
            ""StructGUID"": ""00000000-0000-0000-0000-000000000000"",
            ""Name"": """;
		public string NewSectionPart2Str = @""",
            ""DuplicationIndex"": 0,
            ""Value"": [
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.EnumPropertyData, UAssetAPI"",
                ""EnumType"": ""EAnimationId"",
                ""Name"": ""AnmId"",
                ""DuplicationIndex"": 0,
                ""Value"": ""EAnimationId::";
		public string NewSectionPart3Str = @"""
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
                ""Name"": ""Timing"",
                ""DuplicationIndex"": 0,
                ""Value"": 0
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
                ""Name"": ""Evid"",
                ""DuplicationIndex"": 0,
                ""Value"": 0
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.NamePropertyData, UAssetAPI"",
                ""Name"": ""CoordName"",
                ""DuplicationIndex"": 0,
                ""Value"": ""None""
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
                ""Name"": ""ArgN1"",
                ""DuplicationIndex"": 0,
                ""Value"": 0
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
                ""Name"": ""ArgN2"",
                ""DuplicationIndex"": 0,
                ""Value"": 0
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
                ""Name"": ""ArgN3"",
                ""DuplicationIndex"": 0,
                ""Value"": 0
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
                ""Value"": ""+0"",
                ""Name"": ""ArgF1"",
                ""DuplicationIndex"": 0
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
                ""Value"": ""+0"",
                ""Name"": ""ArgF2"",
                ""DuplicationIndex"": 0
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
                ""Value"": ""+0"",
                ""Name"": ""ArgF3"",
                ""DuplicationIndex"": 0
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
                ""Value"": ""+0"",
                ""Name"": ""ArgF4"",
                ""DuplicationIndex"": 0
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
                ""Value"": ""+0"",
                ""Name"": ""ArgF5"",
                ""DuplicationIndex"": 0
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
                ""Value"": ""+0"",
                ""Name"": ""ArgF6"",
                ""DuplicationIndex"": 0
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.NamePropertyData, UAssetAPI"",
                ""Name"": ""DamageId"",
                ""DuplicationIndex"": 0,
                ""Value"": ""None""
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.NamePropertyData, UAssetAPI"",
                ""Name"": ""EndureId"",
                ""DuplicationIndex"": 0,
                ""Value"": ""None""
              }
            ]
          }";
		public string AddToMotSectionPart1Str = @"          },
          {
            ""$type"": ""UAssetAPI.PropertyTypes.Structs.StructPropertyData, UAssetAPI"",
            ""StructType"": ""APKPlayerMotionHeaderImportParam"",
            ""SerializeNone"": true,
            ""StructGUID"": ""00000000-0000-0000-0000-000000000000"",
            ""Name"": """;
		public string AddToMotSectionPart2Str = @""",
            ""DuplicationIndex"": 0,
            ""Value"": [
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.EnumPropertyData, UAssetAPI"",
                ""EnumType"": ""EAnimationId"",
                ""Name"": ""AnmId"",
                ""DuplicationIndex"": 0,
                ""Value"": ""EAnimationId::";
		public string AddToMotSectionPart3Str = @"""
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
                ""Name"": ""EventNum"",
                ""DuplicationIndex"": 0,
                ""Value"": 0
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.NamePropertyData, UAssetAPI"",
                ""Name"": ""ConnectNextId"",
                ""DuplicationIndex"": 0,
                ""Value"": ""None""
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
                ""Name"": ""ConnectNextInputLever"",
                ""DuplicationIndex"": 0,
                ""Value"": 0
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
                ""Name"": ""ConnectNextInputButton"",
                ""DuplicationIndex"": 0,
                ""Value"": 0
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
                ""Name"": ""ConnectNextCondition"",
                ""DuplicationIndex"": 0,
                ""Value"": 0
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
                ""Name"": ""ConnectNextTimBegin"",
                ""DuplicationIndex"": 0,
                ""Value"": 0
              },
              {
                ""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
                ""Name"": ""ConnectNextTimEnd"",
                ""DuplicationIndex"": 0,
                ""Value"": 0
              }
            ]
          }";
		public int ioffset = 0;
		public int StructGUIDFound = 0;
		public Int32 ListBoxIndex = 0;
		public Int32 FinalIndex = 0;
		public string GetENumValue = "";
		public string GetENumValueSub = "";
		public string CurrentAnimationID = "";
		public string PreviousAnimationID = "";
		public int PrevAnimIDAmount = 0;
		public int NewAnimIDAmount = 0;
		public bool IsCorrectFile = false;
		public bool IsBasicFile = false;
		public bool IsDamageReacFile = false;
		public bool IsMeleeFile = false;
		public bool IsSupportFile = false;
		public bool FoundAnimIDInsideOtherFiles = false;
		public bool IsRemoving = false;
		public bool UndoChanges = false;
		public string[] EventIDFunctions = {
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
"ME_BELOW_GROUND_WARP_PARTNER"};
		public bool NotifyUserBasic = true;
		public bool NotifyUserDamageReac = true;
		public bool NotifyUserMelee = true;
		public bool NotifyUserSupport = true;
		public int MoveToIndex = 0;
		public int MoveMultiplier = 1;
		public int AmountToMoveMultiplier = 1;
		public bool CloningSections = false;
		public bool AllowToolTips = false;
		public bool ClickedApply = false;
		public int RememberIndexForResize = 0;
		public ToolTip ttTiming = new ToolTip();
		public ToolTip ttEvID = new ToolTip();
		public ToolTip ttArgN1 = new ToolTip();
		public ToolTip ttArgN2 = new ToolTip();
		public ToolTip ttArgN3 = new ToolTip();
		public ToolTip ttArgF1 = new ToolTip();
		public ToolTip ttArgF2 = new ToolTip();
		public ToolTip ttArgF3 = new ToolTip();
		public ToolTip ttArgF4 = new ToolTip();
		public ToolTip ttArgF5 = new ToolTip();
		public ToolTip ttArgF6 = new ToolTip();
		public ToolTip ttCoordName = new ToolTip();
		public ToolTip ttDamageId = new ToolTip();
		public ToolTip ttEndureId = new ToolTip();

		public EventEditorForm()
		{
			InitializeComponent();
			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
		}

		private void EventEditorForm_Load(object sender, EventArgs e)
		{
			if (Properties.Settings.Default.CreateBackupsEvent)
			{
				BackupsButton.Checked = true;
			}
			else
			{
				BackupsButton.Checked = false;
			}
			if (Properties.Settings.Default.AutoRename)
			{
				AutoUpdateCheckBox.Checked = true;
			}
			else
			{
				AutoUpdateCheckBox.Checked = false;
			}
		}

		private void EventEditorForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (File.Exists(StreamingPath))
			{
				File.Delete(StreamingPath);

				if (BackupsButton.Checked && IsEventFile)
				{
					File.WriteAllLines(StreamingPathBak, ReadAllLinesOrig);
				}
			}

			if (File.Exists(BasicStreamingPath))
			{
				File.Delete(BasicStreamingPath);

				if (BackupsButton.Checked && IsEventFile)
				{
					File.WriteAllLines(BasicStreamingPathBak, ReadAllLinesBasicOrig);
				}
			}
			if (File.Exists(DamageReacStreamingPath))
			{
				File.Delete(DamageReacStreamingPath);

				if (BackupsButton.Checked && IsEventFile)
				{
					File.WriteAllLines(DamageReacStreamingPathBak, ReadAllLinesDamageReacOrig);
				}
			}
			if (File.Exists(MeleeStreamingPath))
			{
				File.Delete(MeleeStreamingPath);

				if (BackupsButton.Checked && IsEventFile)
				{
					File.WriteAllLines(MeleeStreamingPathBak, ReadAllLinesMeleeOrig);
				}
			}
			if (File.Exists(SupportStreamingPath))
			{
				File.Delete(SupportStreamingPath);

				if (BackupsButton.Checked && IsEventFile)
				{
					File.WriteAllLines(SupportStreamingPathBak, ReadAllLinesSupportOrig);
				}
			}
			Properties.Settings.Default.Save();
			StartupForm startform = (StartupForm)this.Owner;
			startform.LaunchEventButton.Enabled = true;
		}

		private void DisableStuff()
		{
			AutoUpdateCheckBox.Enabled = false;
			YoinkFromFileButton.Enabled = false;
			MassRenameButton.Enabled = false;
			DuplicateButton.Enabled = false;
			RemoveButton.Enabled = false;
			MoveUpButton.Enabled = false;
			MoveDownButton.Enabled = false;
			MoveToButton.Enabled = false;
			SaveChangesToMoveButton.Enabled = false;

			NameOfTableIDTextbox.Enabled = false;
			NameOfTableIDTextbox.Text = "";
			EAnimationIdComboBox.Enabled = false;
			EAnimationIdComboBox.Text = "";
			TimingTextBox.Enabled = false;
			TimingTextBox.Text = "";
			EvidComboBox.Enabled = false;
			EvidComboBox.Text = "";
			CoordNameTextBox.Enabled = false;
			CoordNameTextBox.Text = "";
			ArgN1TextBox.Enabled = false;
			ArgN1TextBox.Text = "";
			ArgN2TextBox.Enabled = false;
			ArgN2TextBox.Text = "";
			ArgN3TextBox.Enabled = false;
			ArgN3TextBox.Text = "";
			ArgF1TextBox.Enabled = false;
			ArgF1TextBox.Text = "";
			ArgF2TextBox.Enabled = false;
			ArgF2TextBox.Text = "";
			ArgF3TextBox.Enabled = false;
			ArgF3TextBox.Text = "";
			ArgF4TextBox.Enabled = false;
			ArgF4TextBox.Text = "";
			ArgF5TextBox.Enabled = false;
			ArgF5TextBox.Text = "";
			ArgF6TextBox.Enabled = false;
			ArgF6TextBox.Text = "";
			DamageIDTextBox.Enabled = false;
			DamageIDTextBox.Text = "";
			EndureIDTextBox.Enabled = false;
			EndureIDTextBox.Text = "";
		}

		private void OpenButton_Click(object sender, EventArgs e)
		{
			AllowToolTips = false;
			OpenFileDialog OpenDialogStreaming = new OpenFileDialog();
			OpenDialogStreaming.Title = "Open a mot_event.json";
			OpenDialogStreaming.Filter = "JavaScript Object Notation (*.json)|*.json|Backup File (*.bak)|*.bak|All files (*.*)|*.*";
			if (Properties.Settings.Default.RememberEventPath != null)
			{
				OpenDialogStreaming.FileName = Properties.Settings.Default.RememberEventPath;
			}
			OpenDialogStreaming.FilterIndex = 1;
			OpenDialogStreaming.CheckFileExists = true;
			OpenDialogStreaming.CheckPathExists = true;
			OpenDialogStreaming.RestoreDirectory = true;
			if (OpenDialogStreaming.ShowDialog() == DialogResult.OK)
			{
				//If opening a new file, when one was already opened, delete the old temp.
				if (File.Exists(StreamingPath))
				{
					File.Delete(StreamingPath);
				}
				if (File.Exists(BasicStreamingPath))
				{
					File.Delete(BasicStreamingPath);
				}
				if (File.Exists(DamageReacStreamingPath))
				{
					File.Delete(DamageReacStreamingPath);
				}
				if (File.Exists(MeleeStreamingPath))
				{
					File.Delete(MeleeStreamingPath);
				}
				if (File.Exists(SupportStreamingPath))
				{
					File.Delete(SupportStreamingPath);
				}

				StreamingPath = OpenDialogStreaming.FileName;
				Properties.Settings.Default.RememberEventPath = StreamingPath;
				Properties.Settings.Default.Save();

				ReadAllLines = File.ReadAllLines(StreamingPath);
				//The original stuff, used for reverting file names and creating backups.
				StreamingPathOrig = StreamingPath;
				ReadAllLinesOrig = File.ReadAllLines(StreamingPath);
				StreamingPathBak = StreamingPath.ToString() + ".bak";

				//Reset Stuff here so new files properly open.
				IsEventFile = false;

				foreach (var Line in ReadAllLines)
				{
					if (Line.Contains("prm_mot_event"))
					{
						IsEventFile = true;
					}
				}

				if (IsEventFile)
				{
					//File Successfully Opened.
					BasicStreamingPath = "";
					BasicStreamingPathBak = "";
					BasicStreamingPathOrig = "";
					DamageReacStreamingPath = "";
					DamageReacStreamingPathBak = "";
					DamageReacStreamingPathOrig = "";
					MeleeStreamingPath = "";
					MeleeStreamingPathBak = "";
					MeleeStreamingPathOrig = "";
					SupportStreamingPath = "";
					SupportStreamingPathBak = "";
					SupportStreamingPathOrig = "";

					//Open other files allow adding.
					DialogResult dialogResult = MessageBox.Show("Open additional four prm_mot files?\nThis will allow you to Add/Remove Data Entries.", "", MessageBoxButtons.YesNo);
					bool legallyagreed = false;
					if (dialogResult == DialogResult.Yes)
					{
						OpenSubFiles("Open a prm_mot_basic.json", "prm_mot_basic", "Error: This is not a prm_mot_basic .json", BasicStreamingPath, BasicStreamingPathOrig, BasicStreamingPathBak, ReadAllLinesBasic, ReadAllLinesOrig);
						if (IsCorrectFile)
						{
							NotifyUserBasic = true;
							OpenSubFiles("Open a prm_mot_damageReaction.json", "prm_mot_damageR", "Error: This is not a prm_mot_damageReaction .json", DamageReacStreamingPath, DamageReacStreamingPathOrig, DamageReacStreamingPathBak, ReadAllLinesDamageReac, ReadAllLinesDamageReacOrig);
							if (IsCorrectFile)
							{
								NotifyUserDamageReac = true;
								OpenSubFiles("Open a prm_mot_melee.json", "prm_mot_melee", "Error: This is not a prm_mot_melee .json", MeleeStreamingPath, MeleeStreamingPathOrig, MeleeStreamingPathBak, ReadAllLinesMelee, ReadAllLinesMeleeOrig);
								if (IsCorrectFile)
								{
									NotifyUserMelee = true;
									OpenSubFiles("Open a prm_mot_support.json", "prm_mot_support", "Error: This is not a prm_mot_support .json", SupportStreamingPath, SupportStreamingPathOrig, SupportStreamingPathBak, ReadAllLinesSupport, ReadAllLinesSupportOrig);
									if (IsCorrectFile)
									{
										NotifyUserSupport = true;
									}
								}
							}
						}
						legallyagreed = true;
					}
					else
					{
						BasicStreamingPath = "";
						BasicStreamingPathBak = "";
						BasicStreamingPathOrig = "";
						DamageReacStreamingPath = "";
						DamageReacStreamingPathBak = "";
						DamageReacStreamingPathOrig = "";
						MeleeStreamingPath = "";
						MeleeStreamingPathBak = "";
						MeleeStreamingPathOrig = "";
						SupportStreamingPath = "";
						SupportStreamingPathBak = "";
						SupportStreamingPathOrig = "";
					}

					//Will be saved as a .temp file to allow me to edit this in real time.
					StreamingPath = StreamingPath.ToString() + ".temp";
					File.WriteAllLines(StreamingPath, ReadAllLines);

					EventListBox.Items.Clear();
					SaveButton.Enabled = true;
					SaveAsButton.Enabled = true;

					if (legallyagreed)
					{
						if (File.Exists(StreamingPathOrig) && File.Exists(BasicStreamingPathOrig) && File.Exists(DamageReacStreamingPathOrig) && File.Exists(MeleeStreamingPathOrig) && File.Exists(SupportStreamingPathOrig))
						{
							AddButton.Enabled = true;
							DuplicateButton.Enabled = true;
							YoinkFromFileButton.Enabled = true;
						}
						else
						{
							MessageBox.Show("Error: One of the files were not correctly loaded.\nAdd/Remove features will not be accessible.");
							BasicStreamingPath = "";
							BasicStreamingPathBak = "";
							BasicStreamingPathOrig = "";
							DamageReacStreamingPath = "";
							DamageReacStreamingPathBak = "";
							DamageReacStreamingPathOrig = "";
							MeleeStreamingPath = "";
							MeleeStreamingPathBak = "";
							MeleeStreamingPathOrig = "";
							SupportStreamingPath = "";
							SupportStreamingPathBak = "";
							SupportStreamingPathOrig = "";
							AddButton.Enabled = false;
							DuplicateButton.Enabled = false;
							RemoveButton.Enabled = false;
						}
					}
					else
					{
						AddButton.Enabled = false;
						DuplicateButton.Enabled = false;
						RemoveButton.Enabled = false;
					}

					StructGUIDFound = 0;

					//Search through whole File
					for (int i = 0; i < ReadAllLines.Length; i++)
					{
						//When Line Finds "StructGUID"
						var Line = ReadAllLines[i];
						if (Line.Contains("StructGUID"))
						{
							StructGUIDFound++;
							//Go to the next Line where the Name is determined.
							string[] NextLine = { ReadAllLines[++i] };

							//Search through the NextLine with "Name"
							foreach (string s in NextLine)
							{
								//Changes the Index Int to "18" since that's how many characters until the ": "
								int Index = s.IndexOf(": ");

								//Trim off the Quotations and Commas at the ending.
								char[] charsToTrim = { '"', ',' };
								string TrimmedCharString = s.Trim(charsToTrim);
								//The +3 is used to get past the " : " ", the three additional characters past Index.
								string NameOfTableEntry = (TrimmedCharString.Substring(Index + 3));

								EventListBox.Items.Add(NameOfTableEntry);
								EventListBox.SelectedIndex++;
								ResizeForm();
							}
							FindFinalIndex();

							//Finds final value in the ListBox and checks if you have more than just one entry. If so, then allow MoveDown button.
							if (EventListBox.SelectedIndex == FinalIndex - 1)
							{
								MoveDownButton.Enabled = false;
								RemoveButton.Enabled = false;
							}
							else
							{
								MoveDownButton.Enabled = true;

								if (File.Exists(StreamingPath) && File.Exists(BasicStreamingPath) && File.Exists(DamageReacStreamingPath))
								{
									RemoveButton.Enabled = true;
								}
							}
						}
					}

					if (StructGUIDFound == 0)
					{
						DisableStuff();

						for (int i = 0; i < ReadAllLines.Length; i++)
						{
							var Line = ReadAllLines[i];
							if (Line.Contains("\"Exports\": ["))
							{
								FoundExport = true;

								string[] BlankCheck = { ReadAllLines[i + 6] };
								string BlankCheckStr = "";

								foreach (string item in BlankCheck)
								{
									BlankCheckStr = item;
								}

								//Checks 6 lines down to see if the value is: "		", if not create this. This is incase the user opens the file, saves the file, then reopens it.
								if (BlankCheckStr == "		")
								{
									break;
								}
								else
								{
									List<string> lines = File.ReadAllLines(StreamingPath).ToList();

									//Replaces the Data Line and adds a blank space between the brackets so you can add a new section to it.
									lines.RemoveAt(i + 5);
									lines.Insert(i + 5, @"        ""Data"": [
		
		]");
									File.WriteAllLines(StreamingPath, lines);

									//Reload the file after saving.
									ReadAllLines = File.ReadAllLines(StreamingPath);
									break;
								}
							}
						}

						if (FoundExport == false)
						{
							SaveButton.Enabled = false;
							SaveAsButton.Enabled = false;
							AddButton.Enabled = false;
							MessageBox.Show("Couldn't find any Sections nor Export Header." + "\nThis is likely not the correct file, or it's corrupted." + "\n\nClosing File.");

							if (File.Exists(StreamingPath))
							{
								File.Delete(StreamingPath);
								StreamingPath = "";
								IsEventFile = false;
							}
						}
					}
					else
					{
						AllowToolTips = true;
						EventListBox.SelectedIndex = 0;
					}
				}
				else
				{
					MessageBox.Show("This is not a prm_mot_event.json file.");
					StreamingPath = "";
					ReadAllLines = Array.Empty<string>();
					EventListBox.Items.Clear();
					AddButton.Enabled = false;
					SaveButton.Enabled = false;
					SaveAsButton.Enabled = false;

					DisableStuff();
				}
			}
		}

		private void OpenSubFiles(string Title, string Contains, string Error, string FilePath, string FilePathOrig, string FilePathBak, string[] readlines, string[] readlinesOrig)
		{
			IsCorrectFile = false;
			string RememberPath = "";

			if (Title.Contains("basic"))
			{
				RememberPath = Properties.Settings.Default.RememberBasicPath;
			}
			if (Title.Contains("damage"))
			{
				RememberPath = Properties.Settings.Default.RememberDamageReacPath;
			}
			if (Title.Contains("melee"))
			{
				RememberPath = Properties.Settings.Default.RememberMeleePath;
			}
			if (Title.Contains("support"))
			{
				RememberPath = Properties.Settings.Default.RememberSupportPath;
			}

			OpenFileDialog OpenSubFile = new OpenFileDialog();
			OpenSubFile.Title = Title;
			OpenSubFile.Filter = "JavaScript Object Notation (*.json)|*.json|Backup File (*.bak)|*.bak|All files (*.*)|*.*";
			if (RememberPath != null)
			{
				OpenSubFile.FileName = RememberPath;
			}
			OpenSubFile.FilterIndex = 1;
			OpenSubFile.CheckFileExists = true;
			OpenSubFile.CheckPathExists = true;
			OpenSubFile.RestoreDirectory = true;
			if (OpenSubFile.ShowDialog() == DialogResult.OK)
			{
				//If opening a new file, when one was already opened, delete the old temp.
				if (File.Exists(FilePath))
				{
					File.Delete(FilePath);
				}

				FilePath = OpenSubFile.FileName;
				if (RememberPath != null && Title.Contains("basic"))
				{
					Properties.Settings.Default.RememberBasicPath = FilePath;
				}
				if (RememberPath != null && Title.Contains("damage"))
				{
					Properties.Settings.Default.RememberDamageReacPath = FilePath;
				}
				if (RememberPath != null && Title.Contains("melee"))
				{
					Properties.Settings.Default.RememberMeleePath = FilePath;
				}
				if (RememberPath != null && Title.Contains("support"))
				{
					Properties.Settings.Default.RememberSupportPath = FilePath;
				}
				Properties.Settings.Default.Save();

				FilePathOrig = FilePath;
				readlines = File.ReadAllLines(FilePath);

				FilePathBak = FilePath.ToString() + ".bak";
				FilePath = FilePath.ToString() + ".temp";
				File.WriteAllLines(FilePath, readlines);

				readlinesOrig = readlines;

				foreach (var Line in readlines)
				{
					if (Line.Contains(Contains))
					{
						IsCorrectFile = true;
						break;
					}
				}

				if (IsCorrectFile == false)
				{
					IsCorrectFile = false;
					FilePath = "";
					FilePathOrig = "";
					FilePathBak = "";
					readlines = Array.Empty<string>();
					readlinesOrig = Array.Empty<string>();
					MessageBox.Show(Error);
				}
			}

			if (Title.Contains("basic"))
			{
				BasicStreamingPath = FilePath;
				BasicStreamingPathOrig = FilePathOrig;
				BasicStreamingPathBak = FilePathBak;
				ReadAllLinesBasic = readlines;
				ReadAllLinesBasicOrig = readlinesOrig;
			}
			if (Title.Contains("damage"))
			{
				DamageReacStreamingPath = FilePath;
				DamageReacStreamingPathOrig = FilePathOrig;
				DamageReacStreamingPathBak = FilePathBak;
				ReadAllLinesDamageReac = readlines;
				ReadAllLinesDamageReacOrig = readlinesOrig;
			}
			if (Title.Contains("melee"))
			{
				MeleeStreamingPath = FilePath;
				MeleeStreamingPathOrig = FilePathOrig;
				MeleeStreamingPathBak = FilePathBak;
				ReadAllLinesMelee = readlines;
				ReadAllLinesMeleeOrig = readlinesOrig;
			}
			if (Title.Contains("support"))
			{
				SupportStreamingPath = FilePath;
				SupportStreamingPathOrig = FilePathOrig;
				SupportStreamingPathBak = FilePathBak;
				ReadAllLinesSupport = readlines;
				ReadAllLinesSupportOrig = readlinesOrig;
			}
		}

		private void EventListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (SavingFile)
			{
				//Prevents this Function from fucking with the saving process. It would revert values back since this would happen as well.
			}
			else
			{
				AutoUpdateCheckBox.Enabled = true;
				MassRenameButton.Enabled = true;
				SaveChangesToMoveButton.Enabled = true;
				NameOfTableIDTextbox.Enabled = true;

				if (File.Exists(StreamingPath) && File.Exists(BasicStreamingPath) && File.Exists(DamageReacStreamingPath) && File.Exists(MeleeStreamingPath) && File.Exists(SupportStreamingPath))
				{
					EAnimationIdComboBox.Enabled = true;
				}
				else
				{
					EAnimationIdComboBox.Enabled = false;
				}

				TimingTextBox.Enabled = true;
				EvidComboBox.Enabled = true;
				CoordNameTextBox.Enabled = true;
				ArgN1TextBox.Enabled = true;
				ArgN2TextBox.Enabled = true;
				ArgN3TextBox.Enabled = true;
				ArgF1TextBox.Enabled = true;
				ArgF2TextBox.Enabled = true;
				ArgF3TextBox.Enabled = true;
				ArgF4TextBox.Enabled = true;
				ArgF5TextBox.Enabled = true;
				ArgF6TextBox.Enabled = true;
				DamageIDTextBox.Enabled = true;
				EndureIDTextBox.Enabled = true;

				StructGUIDFound = 0;

				NameOfTableIDTextbox.Text = EventListBox.GetItemText(EventListBox.SelectedItem);

				//Gets the numbered index of the ListBox ID. That way if you rename it, it will still read correctly.
				try
				{
					ListBoxIndex = EventListBox.Items.IndexOf(EventListBox.SelectedItem) + 1;
				}
				catch (System.ArgumentNullException)
				{
					ListBoxIndex = -1;
				}

				FindFinalIndex();

				if (FinalIndex > 2)
				{
					MoveToButton.Enabled = true;
				}
				else
				{
					MoveToButton.Enabled = false;
				}


				if (FinalIndex <= 1 || File.Exists(StreamingPath) == false || File.Exists(BasicStreamingPath) == false || File.Exists(DamageReacStreamingPath) == false || File.Exists(MeleeStreamingPath) == false || File.Exists(SupportStreamingPath) == false)
				{
					RemoveButton.Enabled = false;
				}
				if (FinalIndex > 1 && File.Exists(StreamingPath) && File.Exists(BasicStreamingPath) && File.Exists(DamageReacStreamingPath) && File.Exists(MeleeStreamingPath) && File.Exists(SupportStreamingPath))
				{
					RemoveButton.Enabled = true;
				}

				//Search through whole File
				for (int i = 0; i < ReadAllLines.Length; i++)
				{
					//When Line Finds "StructGUID"
					var Line = ReadAllLines[i];

					if (Line.Contains("StructGUID"))
					{
						StructGUIDFound++;
						if (ListBoxIndex > 1)
						{
							MoveUpButton.Enabled = true;
						}
						else
						{
							MoveUpButton.Enabled = false;
						}
						if (ListBoxIndex == FinalIndex)
						{
							MoveDownButton.Enabled = false;
						}
						else
						{
							MoveDownButton.Enabled = true;
						}
					}
				}
				StructGUIDFound = 0;

			Restart:

				for (int i = 0; i < ReadAllLines.Length; i++)
				{
					var Line = "0";
					try
					{
						Line = ReadAllLines[ioffset];
						ioffset = i;
					}
					catch
					{
						ioffset = i;
						goto Restart;
					}

					if (Line.Contains("StructGUID"))
					{
						StructGUIDFound++;
						if (StructGUIDFound == ListBoxIndex)
						{
							GetEnum("EAnimationId::", EAnimationIdComboBox, 10, 17);
							GetInt(TimingTextBox, 16);
							GetIntComboBox(EvidComboBox, 22);
							GetName(CoordNameTextBox, 28);
							GetInt(ArgN1TextBox, 34);
							GetInt(ArgN2TextBox, 40);
							GetInt(ArgN3TextBox, 46);
							GetFloat(ArgF1TextBox, 50);
							GetFloat(ArgF2TextBox, 56);
							GetFloat(ArgF3TextBox, 62);
							GetFloat(ArgF4TextBox, 68);
							GetFloat(ArgF5TextBox, 74);
							GetFloat(ArgF6TextBox, 80);
							GetName(DamageIDTextBox, 88);
							GetName(EndureIDTextBox, 94);

							if (IsRemoving == false)
							{
								PreviousAnimationID = EAnimationIdComboBox.Text;
							}
						}
					}
				}
			}
		}

		private void EvidComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			string OriginalTimingLabel = TimingLabel.Text.Replace(" ⍰", "");
			string OriginalEvidLabel = EvidLabel.Text.Replace(" ⍰", "");
			string OriginalArgN1Label = ArgN1Label.Text.Replace(" ⍰", "");
			string OriginalArgN2Label = ArgN2Label.Text.Replace(" ⍰", "");
			string OriginalArgN3Label = ArgN3Label.Text.Replace(" ⍰", "");
			string OriginalArgF1Label = ArgF1Label.Text.Replace(" ⍰", "");
			string OriginalArgF2Label = ArgF2Label.Text.Replace(" ⍰", "");
			string OriginalArgF3Label = ArgF3Label.Text.Replace(" ⍰", "");
			string OriginalArgF4Label = ArgF4Label.Text.Replace(" ⍰", "");
			string OriginalArgF5Label = ArgF5Label.Text.Replace(" ⍰", "");
			string OriginalArgF6Label = ArgF6Label.Text.Replace(" ⍰", "");
			string OriginalCoordNameLabel = CoordNameLabel.Text.Replace(" ⍰", "");
			string OriginalDamageIdLabel = DamageIdLabel.Text.Replace(" ⍰", "");
			string OriginalEndureIdLabel = EndureIdLabel.Text.Replace(" ⍰", "");
			TimingLabel.Text = OriginalTimingLabel;
			EvidLabel.Text = OriginalEvidLabel;
			ArgN1Label.Text = OriginalArgN1Label;
			ArgN2Label.Text = OriginalArgN2Label;
			ArgN3Label.Text = OriginalArgN3Label;
			ArgF1Label.Text = OriginalArgF1Label;
			ArgF2Label.Text = OriginalArgF2Label;
			ArgF3Label.Text = OriginalArgF3Label;
			ArgF4Label.Text = OriginalArgF4Label;
			ArgF5Label.Text = OriginalArgF5Label;
			ArgF6Label.Text = OriginalArgF6Label;
			CoordNameLabel.Text = OriginalCoordNameLabel;
			DamageIdLabel.Text = OriginalDamageIdLabel;
			EndureIdLabel.Text = OriginalEndureIdLabel;

			if (AllowToolTips)
			{
				ttEvID.RemoveAll();
				string TimingLabelStr = "";
				string EvIdLabelStr = "";
				string ArgN1LabelStr = "";
				string ArgN2LabelStr = "";
				string ArgN3LabelStr = "";
				string ArgF1LabelStr = "";
				string ArgF2LabelStr = "";
				string ArgF3LabelStr = "";
				string ArgF4LabelStr = "";
				string ArgF5LabelStr = "";
				string ArgF6LabelStr = "";
				string CoordNameLabelStr = "";
				string DamageIdLabelStr = "";
				string EndureIdLabelStr = "";

				if (TimingTextBox.Text != "")
				{
					TimingLabelStr = "Timing is when this function happens.\nThese must be in proper order with -1 at the end.\n-1 means it happens when the animation finishes no matter what.";
				}
				if (EvidComboBox.Text == "ME_SET_SPEED")
				{
					EvIdLabelStr = "Causes Player to move";
					ArgN2LabelStr = "Speed?";
				}
				if (EvidComboBox.Text == "ME_HOMING_SET")
				{
					EvIdLabelStr = "Causes Player to track the Opponent";
				}
				if (EvidComboBox.Text == "ME_HOMING_END")
				{
					EvIdLabelStr = "Disables ME_HOMING_SET";
				}
				if (EvidComboBox.Text == "ME_ON_LAND")
				{
					EvIdLabelStr = "Skips ahead to another Timing";
					ArgN2LabelStr = "Timing to skip to";
				}
				if (EvidComboBox.Text == "ME_ANIMATION_RATE_CHANGE")
				{
					EvIdLabelStr = "Changing Animation Speed";
					ArgF1LabelStr = "Animation Speed Rate";
				}
				if (EvidComboBox.Text == "ME_SUPER_ARMOR_ON")
				{
					EvIdLabelStr = "This Enables Super Armor used for Surge/Ground Tilt Attacks";
					ArgN1LabelStr = "Priority? Surge entries has it marked as 10000 while Tilts have it as 5000.";
					ArgN2LabelStr = "Determines when it activates.\n01 = Base, 02 = Surge.";
				}
				if (EvidComboBox.Text == "ME_SUPER_ARMOR_OFF")
				{
					EvIdLabelStr = "Disables ME_SUPER_ARMOR_ON";
				}
				if (EvidComboBox.Text == "REQUEST_ACTION_ANIM_ID")
				{
					EvIdLabelStr = "Causes this move to end and starts any AnimationID you want to happen";
					CoordNameLabelStr = "AnimationID to start";
				}
				if (EvidComboBox.Text == "START_CANCEL_RECEPTION")
				{
					EvIdLabelStr = "Allows you to Cancel this Animation";
					CoordNameLabelStr = "Moves you can cancel into.\n\nCancel Data List is determined within:\n\"APK\\Content\\BluePrints\\APK\\Battle\\B_PlayerCancelDataTable.uasset\"";
				}
				if (EvidComboBox.Text == "END_CANCEL_RECEPTION")
				{
					EvIdLabelStr = "Disables START_CANCEL_RECEPTION";
				}
				if (EvidComboBox.Text == "ADD_CMB_CANCEL_ENABLE_TO_CANCEL")
				{
					EvIdLabelStr = "Lose Skill Gauge upon using START_CANCEL_RECEPTION, has to be used after it.\n\nSkill Gauge Prices is determined within:\n\"APK\\Content\\MasterData\\DA_MasterSkillData.uasset\"";
					CoordNameLabelStr = "This should be the same CoordName as START_CANCEL_RECEPTION.\nDetermines which Cancel Group should cost skill gauge.";
				}
				if (EvidComboBox.Text == "ME_CREATE_MELEECOLLISION_UNITGROUP")
				{
					EvIdLabelStr = "Damage ID to use for the next Hitbox. Use ME_CREATE_MELEECOLLISION_UNIT after this.";
					CoordNameLabelStr = "Damage ID.\n\nDamage IDs are determined within <charID>prm_damage.uasset";
				}
				if (EvidComboBox.Text == "ME_CREATE_MELEECOLLISION_UNIT")
				{
					EvIdLabelStr = "Creates a Hitbox. Use ME_CREATE_MELEECOLLISION_UNITGROUP before this.";
					ArgN1LabelStr = "Which ME_CREATE_MELEECOLLISION_UNITGROUP ID to use";
					ArgN2LabelStr = "Hitbox #";
					ArgF1LabelStr = "Size of the Hitbox";
					ArgF4LabelStr = "X Offset Position?";
					ArgF5LabelStr = "Y Offset Position?";
					ArgF6LabelStr = "Z Offset Position?";
					CoordNameLabelStr = "Bone to attach the Hitbox onto";
				}
				if (EvidComboBox.Text == "ME_DELETE_MELEECOLLISION_UNITGROUP")
				{
					EvIdLabelStr = "Disables ME_DELETE_MELEECOLLISION_UNITGROUP. (Removes Damage IDs)";
					ArgN1LabelStr = "Which ME_DELETE_MELEECOLLISION_UNITGROUP ID to remove";
				}
				if (EvidComboBox.Text == "ME_DELETE_MELEECOLLISION_UNIT")
				{
					EvIdLabelStr = "Disables ME_CREATE_MELEECOLLISION_UNIT. (Deletes Hitboxes)";
				}
				if (EvidComboBox.Text == "ME_INSTANT_RECOVER_LIFE")
				{
					EvIdLabelStr = "Instantly Heals the Player";
					ArgF1LabelStr = "Amount to Heal the Player (Akaza Heals by 1000)";
				}
				if (EvidComboBox.Text == "ME_DURATION_RECOVER_LIFE")
				{
					EvIdLabelStr = "Heals the Player Overtime";
					ArgN1LabelStr = "Time it lasts? (Akaza has this as 300)";
					ArgF1LabelStr = "Amount of Health to Gain (Akaza has this as 6.0)";
				}
				if (EvidComboBox.Text == "SET_SCALE")
				{
					EvIdLabelStr = "Sets the Players Size";
					ArgF1LabelStr = "X Scale";
					ArgF2LabelStr = "Y Scale";
					ArgF3LabelStr = "Z Scale";
				}
				if (EvidComboBox.Text == "ME_ENABLE_SUPPORT")
				{
					EvIdLabelStr = "Allows the Player to call Assists & swap out with them";
				}
				if (EvidComboBox.Text == "ME_DISABLE_SUPPORT")
				{
					EvIdLabelStr = "Disables the Player from being able to call Assists & swap out with them";
				}
				if (EvidComboBox.Text == "ME_ENABLE_SUPPORT_ENEMY")
				{
					EvIdLabelStr = "Allows the Opponent to call Assists & swap out with them";
				}
				if (EvidComboBox.Text == "ME_DISABLE_SUPPORT_ENEMY")
				{
					EvIdLabelStr = "Disables the Opponent from being able to call Assists & swap out with them";
				}
				if (EvidComboBox.Text == "RESERVE_PERFORMANCE")
				{
					EvIdLabelStr = "\"PerformanceParam\" to start.\n\nThis is determined within \"APK\\Content\\BluePrints\\APK\\Characters\\Plc\\<CharID>\\<VersionID>\\B_<CharID>_<VersionID>.uasset\"";
					CoordNameLabelStr = "Cinematic to start";
				}
				if (EvidComboBox.Text == "ME_ON_MAIN_CHARACTER_MELEE_ATTACK_HIT")
				{
					EvIdLabelStr = "Causes various stuff to happen upon hitting the opponent";
					ArgN1LabelStr = "?";
					ArgN2LabelStr = "Timing to skip to";
					ArgN3LabelStr = "Hitting opponent as a main?";
					ArgF1LabelStr = "?";
					CoordNameLabelStr = "Always have seen this as \"Hit\"";
				}

				ApplyToolTip(TimingLabel, TimingLabelStr, ttTiming);
				ApplyToolTip(EvidLabel, EvIdLabelStr, ttEvID);
				ApplyToolTip(ArgN1Label, ArgN1LabelStr, ttArgN1);
				ApplyToolTip(ArgN2Label, ArgN2LabelStr, ttArgN2);
				ApplyToolTip(ArgN3Label, ArgN3LabelStr, ttArgN3);
				ApplyToolTip(ArgF1Label, ArgF1LabelStr, ttArgF1);
				ApplyToolTip(ArgF2Label, ArgF2LabelStr, ttArgF2);
				ApplyToolTip(ArgF3Label, ArgF3LabelStr, ttArgF3);
				ApplyToolTip(ArgF4Label, ArgF4LabelStr, ttArgF4);
				ApplyToolTip(ArgF5Label, ArgF5LabelStr, ttArgF5);
				ApplyToolTip(ArgF6Label, ArgF6LabelStr, ttArgF6);
				ApplyToolTip(CoordNameLabel, CoordNameLabelStr, ttCoordName);
				ApplyToolTip(DamageIdLabel, DamageIdLabelStr, ttDamageId);
				ApplyToolTip(EndureIdLabel, EndureIdLabelStr, ttEndureId);
			}
		}

		private void ApplyToolTip(Label labelname, String labelstr, ToolTip tooltip)
		{
			if (labelstr != "" && labelname.Text.Contains(" ⍰") == false)
			{
				labelname.Text += " ⍰";
				tooltip.SetToolTip(labelname, labelstr);
			}
		}

		private void MassRenameButton_Click(object sender, EventArgs e)
		{
			AllowToolTips = false;
			//Gets the current Selected Index and exports it as a Int.
			int RememberIndexNum = EventListBox.Items.IndexOf(EventListBox.SelectedItem);
			SavingFile = false;
			EventListBox.SelectedIndex = 0;

			for (int i = 0; i < FinalIndex; i++)
			{
				string EventIDStr = EventIDFunctions.GetValue(EvidComboBox.SelectedIndex)!.ToString()!;

				EventListBox.Items[EventListBox.SelectedIndex] = (EventListBox.Items.IndexOf(EventListBox.SelectedItem) + 1) + " Anm: " + EAnimationIdComboBox.Text + ", Ev: " + EventIDStr + ", Timing: " + TimingTextBox.Text;

				UpdateSaveData();

				if (EventListBox.SelectedIndex < FinalIndex - 1)
				{
					ResizeForm();
					EventListBox.SelectedIndex++;
				}
			}
			AllowToolTips = true;
			EventListBox.SelectedIndex = RememberIndexNum;
		}

		private void SaveChangesToMoveButton_Click(object sender, EventArgs e)
		{
			if (EventListBox.GetItemText(EventListBox.SelectedItem) != NameOfTableIDTextbox.Text && EventListBox.Items.Contains(NameOfTableIDTextbox.Text))
			{
				MessageBox.Show("This name already exists!\nYou cannot have two Table IDs with the same name.");
			}
			else
			{
				ClickedApply = true;
				if (EAnimationIdComboBox.Text == "")
				{
					EAnimationIdComboBox.Text = PreviousAnimationID;
				}
				UpdateSaveData();
				ClickedApply = false;
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			ClickedApply = true;
			UpdateSaveData();
			ClickedApply = false;

			//Event File
			//Saves the normal file with the current changes.
			StreamingPath = StreamingPathOrig;
			File.WriteAllLines(StreamingPath, ReadAllLines);

			//Reopens it as a temp.
			StreamingPath = StreamingPath.ToString() + ".temp";
			File.WriteAllLines(StreamingPath, ReadAllLines);


			if (File.Exists(BasicStreamingPath))
			{
				//Basic File
				BasicStreamingPath = BasicStreamingPathOrig;
				File.WriteAllLines(BasicStreamingPath, ReadAllLinesBasic);

				//Reopens it as a temp.
				BasicStreamingPath = BasicStreamingPath.ToString() + ".temp";
				File.WriteAllLines(BasicStreamingPath, ReadAllLinesBasic);
			}

			if (File.Exists(DamageReacStreamingPath))
			{
				//DamageReac File
				DamageReacStreamingPath = DamageReacStreamingPathOrig;
				File.WriteAllLines(DamageReacStreamingPath, ReadAllLinesDamageReac);

				//Reopens it as a temp.
				DamageReacStreamingPath = DamageReacStreamingPath.ToString() + ".temp";
				File.WriteAllLines(DamageReacStreamingPath, ReadAllLinesDamageReac);
			}

			if (File.Exists(MeleeStreamingPath))
			{
				//Melee File
				MeleeStreamingPath = MeleeStreamingPathOrig;
				File.WriteAllLines(MeleeStreamingPath, ReadAllLinesMelee);

				//Reopens it as a temp.
				MeleeStreamingPath = MeleeStreamingPath.ToString() + ".temp";
				File.WriteAllLines(MeleeStreamingPath, ReadAllLinesMelee);
			}

			if (File.Exists(SupportStreamingPath))
			{
				//Support File
				SupportStreamingPath = SupportStreamingPathOrig;
				File.WriteAllLines(SupportStreamingPath, ReadAllLinesSupport);

				//Reopens it as a temp.
				SupportStreamingPath = SupportStreamingPath.ToString() + ".temp";
				File.WriteAllLines(SupportStreamingPath, ReadAllLinesSupport);
			}


			//Creates a backup, then reloads so the next save will be an accurate backup.
			if (BackupsButton.Checked)
			{
				File.WriteAllLines(StreamingPathBak, ReadAllLinesOrig);
				ReadAllLinesOrig = File.ReadAllLines(StreamingPath);

				if (File.Exists(BasicStreamingPath))
				{
					File.WriteAllLines(BasicStreamingPathBak, ReadAllLinesBasicOrig);
					ReadAllLinesBasicOrig = File.ReadAllLines(BasicStreamingPath);
				}
				if (File.Exists(DamageReacStreamingPath))
				{
					File.WriteAllLines(DamageReacStreamingPathBak, ReadAllLinesDamageReacOrig);
					ReadAllLinesDamageReacOrig = File.ReadAllLines(DamageReacStreamingPath);
				}
				if (File.Exists(MeleeStreamingPath))
				{
					File.WriteAllLines(MeleeStreamingPathBak, ReadAllLinesMeleeOrig);
					ReadAllLinesMeleeOrig = File.ReadAllLines(MeleeStreamingPath);
				}
				if (File.Exists(SupportStreamingPath))
				{
					File.WriteAllLines(SupportStreamingPathBak, ReadAllLinesSupportOrig);
					ReadAllLinesSupportOrig = File.ReadAllLines(SupportStreamingPath);
				}
			}

			if (File.Exists(StreamingPath) && File.Exists(BasicStreamingPath) && File.Exists(DamageReacStreamingPath) && File.Exists(MeleeStreamingPath) && File.Exists(SupportStreamingPath))
			{
				MessageBox.Show("Files Saved Successfully.");
				NotifyUserBasic = true;
				NotifyUserDamageReac = true;
				NotifyUserMelee = true;
				NotifyUserSupport = true;
			}
			else if (File.Exists(StreamingPath) && File.Exists(BasicStreamingPath) == false && File.Exists(DamageReacStreamingPath) == false && File.Exists(MeleeStreamingPath) == false && File.Exists(SupportStreamingPath) == false)
			{
				MessageBox.Show("File Saved Successfully.");
			}
		}

		private void SaveAsButton_Click(object sender, EventArgs e)
		{
			ClickedApply = true;
			UpdateSaveData();
			ClickedApply = false;

			SaveAs("Saving prm_mot_event File...", StreamingPath, StreamingPathBak, StreamingPathOrig, ReadAllLines, ReadAllLinesOrig);

			if (File.Exists(BasicStreamingPath))
			{
				SaveAs("Saving prm_mot_basic File...", BasicStreamingPath, BasicStreamingPathBak, BasicStreamingPathOrig, ReadAllLinesBasic, ReadAllLinesBasicOrig);
			}
			if (File.Exists(DamageReacStreamingPath))
			{
				SaveAs("Saving prm_mot_damageReaction File...", DamageReacStreamingPath, DamageReacStreamingPathBak, DamageReacStreamingPathOrig, ReadAllLinesDamageReac, ReadAllLinesDamageReacOrig);
			}
			if (File.Exists(MeleeStreamingPath))
			{
				SaveAs("Saving prm_mot_melee File...", MeleeStreamingPath, MeleeStreamingPathBak, MeleeStreamingPathOrig, ReadAllLinesMelee, ReadAllLinesMeleeOrig);
			}
			if (File.Exists(SupportStreamingPath))
			{
				SaveAs("Saving prm_mot_support File...", SupportStreamingPath, SupportStreamingPathBak, SupportStreamingPathOrig, ReadAllLinesSupport, ReadAllLinesSupportOrig);
			}
			if (File.Exists(StreamingPath) && File.Exists(BasicStreamingPath) && File.Exists(DamageReacStreamingPath) && File.Exists(MeleeStreamingPath) && File.Exists(SupportStreamingPath))
			{
				MessageBox.Show("Files Saved Successfully.");
				NotifyUserBasic = true;
				NotifyUserDamageReac = true;
				NotifyUserMelee = true;
				NotifyUserSupport = true;
			}
			else if (File.Exists(StreamingPath) && File.Exists(BasicStreamingPath) == false && File.Exists(DamageReacStreamingPath) == false && File.Exists(MeleeStreamingPath) == false && File.Exists(SupportStreamingPath) == false)
			{
				MessageBox.Show("File Saved Successfully.");
			}
		}

		private void SaveAs(string Title, string FilePath, string FilePathBak, string FilePathOrig, string[] ReadAllLinesArray, string[] ReadAllLinesArrayOrig)
		{
			Stream myStream;
			SaveFileDialog SaveFileDialog = new SaveFileDialog();
			string RememberPath = "";

			if (Title.Contains("event"))
			{
				RememberPath = Properties.Settings.Default.RememberEventPath;
			}
			if (Title.Contains("basic"))
			{
				RememberPath = Properties.Settings.Default.RememberBasicPath;
			}
			if (Title.Contains("damage"))
			{
				RememberPath = Properties.Settings.Default.RememberDamageReacPath;
			}
			if (Title.Contains("melee"))
			{
				RememberPath = Properties.Settings.Default.RememberMeleePath;
			}
			if (Title.Contains("support"))
			{
				RememberPath = Properties.Settings.Default.RememberSupportPath;
			}

			SaveFileDialog.Title = Title;
			SaveFileDialog.Filter = "JavaScript Object Notation (*.json)|*.json|Backup File (*.bak)|*.bak|All files (*.*)|*.*";
			if (RememberPath != null)
			{
				SaveFileDialog.FileName = RememberPath;
			}
			SaveFileDialog.FilterIndex = 1;
			SaveFileDialog.RestoreDirectory = true;

			if (SaveFileDialog.ShowDialog() == DialogResult.OK)
			{
				if ((myStream = SaveFileDialog.OpenFile()) != null)
				{
					SaveAsPath = SaveFileDialog.FileName;
					myStream.Close();
				}

				//Deletes the temp file
				if (File.Exists(FilePath))
				{
					File.Delete(FilePath);
				}
				//Deletes the bak file
				if (File.Exists(FilePathBak))
				{
					File.Delete(FilePathBak);
				}


				//Changes the StreamingPath to the new pathway.
				FilePath = SaveAsPath;
				FilePathBak = FilePath.ToString() + ".bak";
				FilePathOrig = FilePath;
				File.WriteAllLines(FilePath, ReadAllLinesArray);
				FilePath = FilePath.ToString() + ".temp";
				File.WriteAllLines(FilePath, ReadAllLinesArray);

				//Creates a backup, then reloads so the next save will be an accurate backup.
				if (BackupsButton.Checked)
				{
					File.WriteAllLines(FilePathBak, ReadAllLinesArrayOrig);
					ReadAllLinesArrayOrig = File.ReadAllLines(FilePath);
				}

				if (RememberPath != null && Title.Contains("basic"))
				{
					Properties.Settings.Default.RememberBasicPath = FilePath;
				}
				if (RememberPath != null && Title.Contains("damage"))
				{
					Properties.Settings.Default.RememberDamageReacPath = FilePath;
				}
				if (RememberPath != null && Title.Contains("melee"))
				{
					Properties.Settings.Default.RememberMeleePath = FilePath;
				}
				if (RememberPath != null && Title.Contains("support"))
				{
					Properties.Settings.Default.RememberSupportPath = FilePath;
				}
			}
		}

		private void BackupsButton_Click(object sender, EventArgs e)
		{
			if (BackupsButton.Checked)
			{
				BackupsButton.Text = "✔ Enable Backups";
			}
			else
			{
				BackupsButton.Text = "✘ Enable Backups";
			}
			Properties.Settings.Default.CreateBackupsEvent = !Properties.Settings.Default.CreateBackupsEvent;
		}

		private void BackupsButton_CheckStateChanged(object sender, EventArgs e)
		{
			if (BackupsButton.Checked)
			{
				BackupsButton.Text = "✔ Enable Backups";
			}
			else
			{
				BackupsButton.Text = "✘ Enable Backups";
			}
		}

		private void AutoUpdateCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			Properties.Settings.Default.AutoRename = !Properties.Settings.Default.AutoRename;
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			SavingFile = true;
			StructGUIDFound = 0;

			//FoundExport is only true if the table had 0 entries when opened, this creates the first entry then sets it to False.
			//This shouldn't need to ever play out in any other scenario because the Remove button disables when there's only one entry left.
			//If False, add new entry like normal.
			if (FoundExport)
			{
				for (int i = 0; i < ReadAllLines.Length; i++)
				{
					var Line = ReadAllLines[i];
					if (Line.Contains("\"Exports\": ["))
					{
						List<string> lines = File.ReadAllLines(StreamingPath).ToList();

						//Replaces the blank space added from opening the file.
						lines.RemoveAt(i + 6);
						//At index 0, Removes 14 bytes from NewSectionPart1Str, this way it doesn't start with }, followed by a linebreak.
						//Sets the ID as 1 and adds a item to the EventListBox with the same name.
						lines.Insert(i + 6, NewSectionPart1Str.Remove(0, 14) + "1" + NewSectionPart2Str);
						File.WriteAllLines(StreamingPath, lines);
						ReadAllLines = File.ReadAllLines(StreamingPath);

						EventListBox.Items.Add("1");
						//Makes it so everything functions from here on out as if it's a normal file.
						FoundExport = false;
						break;
					}
				}
			}
			else
			{
				//Gets the current Selected Index and exports it as a Int.
				ListBoxIndex = EventListBox.Items.IndexOf(EventListBox.SelectedItem) + 1;

				FindFinalIndex();

				NewTblValueStr = (FinalIndex + 1).ToString() + " Anm: " + EAnimationIdComboBox.Text + ", Ev: " + "NONE" + ", Timing: " + TimingTextBox.Text;

				//Adds new section to file.
				int NewLineNum = 0;

				//Search through whole File
				for (int i = 0; i < ReadAllLines.Length; i++)
				{
					var Line = ReadAllLines[i];
					if (Line.Contains("StructGUID"))
					{
						StructGUIDFound++;
						if (StructGUIDFound == ListBoxIndex)
						{
							NewLineNum = i;
							NewLineNum += 97;

							string[] arrLine = File.ReadAllLines(StreamingPath);

							if (ListBoxIndex == FinalIndex)
							{
								arrLine[NewLineNum - 1] = NewSectionPart1Str + NewTblValueStr + NewSectionPart2Str + EAnimationIdComboBox.Text + NewSectionPart3Str;
							}
							else
							{
								arrLine[NewLineNum - 1] = NewSectionPart1Str + NewTblValueStr + NewSectionPart2Str + EAnimationIdComboBox.Text + NewSectionPart3Str + ",";
							}
							File.WriteAllLines(StreamingPath, arrLine.ToArray());

							//Reload the file after saving.
							ReadAllLines = File.ReadAllLines(StreamingPath);
							break;
						}
					}
				}
				PreviousAnimationID = "";
				ReloadListBox();
				UpdateSaveData();
				if (EventListBox.SelectedIndex == FinalIndex - 1)
				{
					EventListBox.Items.Add(1);
				}
				EventListBox.SelectedIndex++;
				EventListBox.Items[EventListBox.SelectedIndex] = NewTblValueStr;
				NameOfTableIDTextbox.Text = NewTblValueStr;

				if (ListBoxIndex == FinalIndex)
				{
					MoveDownButton.Enabled = false;
				}
				else
				{
					MoveDownButton.Enabled = true;
				}
				MoveUpButton.Enabled = true;

				UpdateMotFiles();
				SavingFile = false;
			}
		}

		private void DuplicateButton_Click(object sender, EventArgs e)
		{
			StructGUIDFound = 0;

			SavingFile = true;

			FindFinalIndex();

			string EventIDStr = EventIDFunctions.GetValue(EvidComboBox.SelectedIndex)!.ToString()!;
			NewTblValueStr = (FinalIndex + 1).ToString() + " Anm: " + EAnimationIdComboBox.Text + ", Ev: " + EventIDStr + ", Timing: " + TimingTextBox.Text;

			//Gets the current Selected Index and exports it as a Int.
			ListBoxIndex = EventListBox.Items.IndexOf(EventListBox.SelectedItem) + 1;

			//Search through whole File
			for (int i = 0; i < ReadAllLines.Length; i++)
			{
				//When Line Finds "StructGUID"
				var Line = ReadAllLines[i];

				if (Line.Contains("StructGUID"))
				{
					StructGUIDFound++;
					if (StructGUIDFound == ListBoxIndex)
					{
						List<string> lines = File.ReadAllLines(StreamingPath).ToList();

						//Gets the values from start to end of section
						string[] Section = lines.GetRange(i - 4, 101).ToArray();

						//Goes from StructGUID to the end of the section, then pastes the copied Section array.
						lines.InsertRange(i + 97, Section);

						if (ListBoxIndex == (FinalIndex))
						{
							lines.RemoveAt(i - 5);
							lines.Insert(i - 5, "          },");
							//- 1 of Insert Range
							lines.RemoveAt(i + 96);
							lines.Insert(i + 96, "          },");
						}

						File.WriteAllLines(StreamingPath, lines.ToArray());

						//Reload the file after saving.
						ReadAllLines = File.ReadAllLines(StreamingPath);

						//Makes it do the thing once, then stop the loop.
						break;
					}
				}
			}
			if (EventListBox.SelectedIndex == FinalIndex - 1)
			{
				EventListBox.Items.Add(1);
			}
			EventListBox.SelectedIndex++;
			EventListBox.Items[EventListBox.SelectedIndex] = NewTblValueStr;
			NameOfTableIDTextbox.Text = NewTblValueStr;
			PreviousAnimationID = "";
			ReloadListBox();
			UpdateSaveData();

			if (ListBoxIndex == FinalIndex)
			{
				MoveDownButton.Enabled = false;
			}
			else
			{
				MoveDownButton.Enabled = true;
			}
			MoveUpButton.Enabled = true;

			UpdateMotFiles();
			SavingFile = false;
		}

		private void RemoveButton_Click(object sender, EventArgs e)
		{
			string RememberAnim = EAnimationIdComboBox.Text;

			StructGUIDFound = 0;
			SavingFile = true;

			FindFinalIndex();
			//Gets the current Selected Index and exports it as a Int.
			ListBoxIndex = EventListBox.Items.IndexOf(EventListBox.SelectedItem) + 1;

			int RememberIndexNum = ListBoxIndex;

			if (RememberIndexNum == FinalIndex)
			{
				RememberIndexNum = ListBoxIndex - 1;
			}

			//Search through whole File
			for (int i = 0; i < ReadAllLines.Length; i++)
			{
				//When Line Finds "StructGUID"
				var Line = ReadAllLines[i];

				if (Line.Contains("StructGUID"))
				{
					StructGUIDFound++;
					if (StructGUIDFound == ListBoxIndex)
					{
						//Removes 562 lines starting at the beginning of the section you picked, then resaves the file.
						List<string> list = new List<string>(ReadAllLines);
						//Goes an extra byte up into the first
						if (ListBoxIndex == 1)
						{
							list.RemoveRange(i - 4, 101);
						}
						else
						{
							list.RemoveRange(i - 5, 101);
						}

						File.WriteAllLines(StreamingPath, list);

						//Reload the file after saving.
						ReadAllLines = File.ReadAllLines(StreamingPath);

						//Makes it do the thing once, then stop the loop.
						break;
					}
				}
			}
			EventListBox.SelectedIndex = RememberIndexNum - 1;

			IsRemoving = true;
			PreviousAnimationID = "";
			CurrentAnimationID = RememberAnim;
			//RELOAD HAS TO HAPPEN FIRST OR ELSE THE EVENTNUM IS WRONG.
			ReloadListBox();
			UpdateSaveData();

			SavingFile = false;
			IsRemoving = false;
		}

		private void MoveUpButton_Click(object sender, EventArgs e)
		{
			StructGUIDFound = 0;
			SavingFile = true;

			//Gets the current Selected Index and exports it as a Int.
			ListBoxIndex = EventListBox.Items.IndexOf(EventListBox.SelectedItem) + 1;
			FindFinalIndex();

			for (int a = 1; a > 0; a--)
			{
				//Search through whole File
				for (int i = 0; i < ReadAllLines.Length; i++)
				{
					//When Line Finds "StructGUID"
					var Line = ReadAllLines[i];

					if (Line.Contains("StructGUID"))
					{
						StructGUIDFound++;
						if (StructGUIDFound == ListBoxIndex)
						{
							List<string> lines = File.ReadAllLines(StreamingPath).ToList();

							lines.RemoveAt(i - 5 + (101 * 1));
							lines.Insert(i - 5 + (101 * 1), "          },");

							string[] Section = lines.GetRange(i - 4, (101 * 1)).ToArray();
							lines.RemoveRange((i - 4), (101 * 1));
							lines.InsertRange((i - 4) - (101 * 1), Section);

							if (StructGUIDFound == FinalIndex)
							{
								//One line behind section
								lines.RemoveAt(i - 5 + 101);
								lines.Insert(i - 5 + 101, "          },");

								//Goes to the start of the section, then the total length * AmountToMove
								lines.RemoveAt(i - 5 + (101 * 1));
								lines.Insert(i - 5 + (101 * 1), "          }");
							}

							File.WriteAllLines(StreamingPath, lines.ToArray());

							//Reload the file after saving.
							ReadAllLines = File.ReadAllLines(StreamingPath);

							//Makes it do the thing once, then stop the loop.
							break;
						}
					}
				}
				ReloadListBox();
				EventListBox.SelectedIndex = ListBoxIndex - 2;
				ListBoxIndex = EventListBox.Items.IndexOf(EventListBox.SelectedItem) + 1;

				if (ListBoxIndex > 1)
				{
					MoveUpButton.Enabled = true;
				}
				else
				{
					MoveUpButton.Enabled = false;
				}
				MoveDownButton.Enabled = true;
				SavingFile = false;
				UpdateSaveData();
			}
		}

		private void MoveDownButton_Click(object sender, EventArgs e)
		{
			StructGUIDFound = 0;
			SavingFile = true;

			//Gets the current Selected Index and exports it as a Int.
			ListBoxIndex = EventListBox.Items.IndexOf(EventListBox.SelectedItem) + 1;
			FindFinalIndex();

			for (int a = 1; a > 0; a--)
			{
				//Search through whole File
				for (int i = 0; i < ReadAllLines.Length; i++)
				{
					//When Line Finds "StructGUID"
					var Line = ReadAllLines[i];

					if (Line.Contains("StructGUID"))
					{
						StructGUIDFound++;
						if (StructGUIDFound == ListBoxIndex)
						{
							List<string> lines = File.ReadAllLines(StreamingPath).ToList();

							lines.RemoveAt(i - 5 + (101 * 1));
							lines.Insert(i - 5 + (101 * 1), "          },");

							string[] Section = lines.GetRange(i - 4, (101 * 1)).ToArray();
							lines.RemoveRange(i - 4, (101 * 1));
							lines.InsertRange((i - 4) + 101, Section);

							if (StructGUIDFound == FinalIndex - 1)
							{
								//One line behind section
								lines.RemoveAt(i - 5 + 101);
								lines.Insert(i - 5 + 101, "          },");
								lines.RemoveAt(i - 5 + (101 * (1 + 1)));
								lines.Insert(i - 5 + (101 * (1 + 1)), "          }");
							}

							File.WriteAllLines(StreamingPath, lines.ToArray());

							//Reload the file after saving.
							ReadAllLines = File.ReadAllLines(StreamingPath);

							//Makes it do the thing once, then stop the loop.
							break;
						}
					}
				}
				ReloadListBox();
				EventListBox.SelectedIndex = ListBoxIndex;
				ListBoxIndex = EventListBox.Items.IndexOf(EventListBox.SelectedItem) + 1;

				if (ListBoxIndex == FinalIndex)
				{
					MoveDownButton.Enabled = false;
				}
				else
				{
					MoveDownButton.Enabled = true;
				}
				MoveUpButton.Enabled = true;

				SavingFile = false;
				UpdateSaveData();
			}
		}

		private void MoveToButton_Click(object sender, EventArgs e)
		{
			MoveToIndexForm IndexForm = new MoveToIndexForm();
			IndexForm.ShowDialog();

			FindFinalIndex();
			int PreviousIndex = EventListBox.SelectedIndex + 1;
			MoveMultiplier = 1;

			if (IndexForm.PressedOK)
			{
				if (IndexForm.MoveToIndex == 0)
				{
					MessageBox.Show("Somehow this is 0? How did you manage that???");
				}
				else
				{
					if (IndexForm.MoveToIndex > FinalIndex)
					{
						IndexForm.MoveToIndex = FinalIndex;
					}

					if (IndexForm.IsCheckBoxChecked)
					{
						if (IndexForm.MoveToIndex != EventListBox.SelectedIndex + 1)
						{
							MoveMultiplier = IndexForm.MoveToIndex - PreviousIndex;
							MoveToIndex = IndexForm.MoveToIndex;
							AmountToMoveMultiplier = IndexForm.AmountToMove;
							bool PosNum = MoveMultiplier > 0;

							if (PosNum)
							{
								MoveDown();
							}
							else
							{
								MoveMultiplier = Math.Abs(MoveMultiplier);
								MoveUp();
							}
						}
						else
						{
							MessageBox.Show("Selected Index is the one your currently on.");
						}
					}
					else
					{
						EventListBox.SelectedIndex = IndexForm.MoveToIndex - 1;
					}
				}
			}
		}

		private void MoveUp()
		{
			SavingFile = true;
			StructGUIDFound = 0;
			ListBoxIndex = EventListBox.Items.IndexOf(EventListBox.SelectedItem) + 1;
			FindFinalIndex();

			int RememberIndexNum = ListBoxIndex;
			EventListBox.SelectedIndex = -1;

			string[] Section = Array.Empty<string>();

			if (FinalIndex - ListBoxIndex <= 0)
			{
				AmountToMoveMultiplier = 1;
			}

			//Searches through file and gets amount of lines to post.
			for (int i = 0; i < ReadAllLines.Length; i++)
			{
				//When Line Finds "StructGUID"
				var Line = ReadAllLines[i];

				if (Line.Contains("StructGUID"))
				{
					StructGUIDFound++;
					if (StructGUIDFound == RememberIndexNum)
					{
						List<string> lines = File.ReadAllLines(StreamingPath).ToList();

						lines.RemoveAt(i - 5 + (101 * AmountToMoveMultiplier));
						lines.Insert(i - 5 + (101 * AmountToMoveMultiplier), "          },");

						Section = lines.GetRange(i - 4, (101 * AmountToMoveMultiplier)).ToArray();
						lines.RemoveRange((i - 4), (101 * AmountToMoveMultiplier));

						File.WriteAllLines(StreamingPath, lines.ToArray());

						//Reload the file after saving.
						ReadAllLines = File.ReadAllLines(StreamingPath);
						break;
					}
				}
			}
			ReloadListBox();
			StructGUIDFound = 0;
			FindFinalIndex();
			if (MoveToIndex > FinalIndex)
			{
				MoveToIndex = FinalIndex;
			}

			for (int i = 0; i < ReadAllLines.Length; i++)
			{
				//When Line Finds "StructGUID"
				var Line = ReadAllLines[i];

				if (Line.Contains("StructGUID"))
				{
					StructGUIDFound++;
					List<string> lines = File.ReadAllLines(StreamingPath).ToList();
					if (StructGUIDFound == MoveToIndex)
					{
						lines.InsertRange((i - 4), Section);
					}
					if (StructGUIDFound == FinalIndex)
					{
						//Goes to the start of the section, then the total length * AmountToMove
						lines.RemoveAt(i - 5 + (101 * 1));
						lines.Insert(i - 5 + (101 * 1), "          }");
					}
					File.WriteAllLines(StreamingPath, lines.ToArray());

					//Reload the file after saving.
					ReadAllLines = File.ReadAllLines(StreamingPath);
				}
			}
			ReloadListBox();
			EventListBox.SelectedIndex = MoveToIndex - 1;

			if (EventListBox.SelectedIndex == 0)
			{
				MoveUpButton.Enabled = false;
			}
			else
			{
				MoveUpButton.Enabled = true;
			}
			MoveDownButton.Enabled = true;

			SavingFile = false;
		}

		private void MoveDown()
		{
			SavingFile = true;
			StructGUIDFound = 0;
			ListBoxIndex = EventListBox.Items.IndexOf(EventListBox.SelectedItem) + 1;
			FindFinalIndex();

			int RememberIndexNum = ListBoxIndex;
			EventListBox.SelectedIndex = -1;

			string[] Section = Array.Empty<string>();

			if (AmountToMoveMultiplier > FinalIndex)
			{
				AmountToMoveMultiplier = FinalIndex - 1;
			}

			//Searches through file and gets amount of lines to post.
			for (int i = 0; i < ReadAllLines.Length; i++)
			{
				//When Line Finds "StructGUID"
				var Line = ReadAllLines[i];

				if (Line.Contains("StructGUID"))
				{
					StructGUIDFound++;
					if (StructGUIDFound == RememberIndexNum)
					{
						List<string> lines = File.ReadAllLines(StreamingPath).ToList();

						lines.RemoveAt(i - 5 + (101 * AmountToMoveMultiplier));
						lines.Insert(i - 5 + (101 * AmountToMoveMultiplier), "          },");

						Section = lines.GetRange(i - 4, (101 * AmountToMoveMultiplier)).ToArray();
						lines.RemoveRange((i - 4), (101 * AmountToMoveMultiplier));

						File.WriteAllLines(StreamingPath, lines.ToArray());

						//Reload the file after saving.
						ReadAllLines = File.ReadAllLines(StreamingPath);
						break;
					}
				}
			}
			ReloadListBox();
			StructGUIDFound = 0;
			FindFinalIndex();
			if (MoveToIndex >= FinalIndex)
			{
				MoveToIndex = FinalIndex;
			}

			for (int i = 0; i < ReadAllLines.Length; i++)
			{
				//When Line Finds "StructGUID"
				var Line = ReadAllLines[i];

				if (Line.Contains("StructGUID"))
				{
					StructGUIDFound++;
					List<string> lines = File.ReadAllLines(StreamingPath).ToList();

					if (StructGUIDFound == MoveToIndex)
					{
						lines.InsertRange((i - 4 + 101), Section);
					}
					if (StructGUIDFound == FinalIndex)
					{
						//Goes to the start of the section, then the total length * AmountToMove
						lines.RemoveAt(i - 5 + (101 * 1));
						lines.Insert(i - 5 + (101 * 1), "          }");
					}
					File.WriteAllLines(StreamingPath, lines.ToArray());

					//Reload the file after saving.
					ReadAllLines = File.ReadAllLines(StreamingPath);
				}
			}
			ReloadListBox();
			EventListBox.SelectedIndex = MoveToIndex;

			if (EventListBox.SelectedIndex == FinalIndex - 1)
			{
				MoveDownButton.Enabled = false;
			}
			else
			{
				MoveDownButton.Enabled = true;
			}
			MoveUpButton.Enabled = true;

			SavingFile = false;
		}

		private void NumberKeyPress(TextBox textBox, KeyPressEventArgs e)
		{
			if (textBox.Focused && (textBox.Text != "-" || textBox.Text != ""))
			{
				if (char.IsControl(e.KeyChar))
					return;

				if (!reg.IsMatch(textBox.Text.Insert(textBox.SelectionStart, e.KeyChar.ToString()) + "1"))
					e.Handled = true;
			}
		}

		private void NumberTextChanged(TextBox textBox, decimal Amount)
		{
			if (textBox.Focused && (textBox.Text != "-" || textBox.Text != ""))
			{
				try
				{
					Decimal.TryParse(textBox.Text, NumberStyles.Any, new CultureInfo("en-US"), out Amount);
				}
				catch
				{
					Amount = 0;
					textBox.Text = "0";
				}
			}
		}

		private void NumberLeave(TextBox textBox, decimal Amount)
		{
			if (textBox.Text == "-" || textBox.Text == "" || textBox.Text == "-0" || textBox.Text == "-0.")
			{
				Amount = 0;
				textBox.Text = "0";
			}

			if (textBox.Focused == false)
			{
				try
				{
					Decimal.TryParse(textBox.Text, NumberStyles.Any, new CultureInfo("en-US"), out Amount);
				}
				catch
				{
					Amount = 0;
					MessageBox.Show("Something went wrong inside NumberLeave function. Amount changed to 0");
				}
			}

			//Trims off a remaining . if you forget to remove it.
			char[] charsToTrim = { '.' };
			string TrimmedCharString = textBox.Text.Trim(charsToTrim);

			textBox.Text = TrimmedCharString;
		}

		private void Generalized_KeyPress(object sender, KeyPressEventArgs e)
		{
			NumberKeyPress(TimingTextBox, e);
			NumberKeyPress(ArgN1TextBox, e);
			NumberKeyPress(ArgN2TextBox, e);
			NumberKeyPress(ArgN3TextBox, e);
			NumberKeyPress(ArgF1TextBox, e);
			NumberKeyPress(ArgF2TextBox, e);
			NumberKeyPress(ArgF3TextBox, e);
			NumberKeyPress(ArgF4TextBox, e);
			NumberKeyPress(ArgF5TextBox, e);
			NumberKeyPress(ArgF6TextBox, e);
		}

		private void Generalized_TextChanged(object sender, EventArgs e)
		{
			NumberTextChanged(TimingTextBox, Amount);
			NumberTextChanged(ArgN1TextBox, Amount);
			NumberTextChanged(ArgN2TextBox, Amount);
			NumberTextChanged(ArgN3TextBox, Amount);
			NumberTextChanged(ArgF1TextBox, Amount);
			NumberTextChanged(ArgF2TextBox, Amount);
			NumberTextChanged(ArgF3TextBox, Amount);
			NumberTextChanged(ArgF4TextBox, Amount);
			NumberTextChanged(ArgF5TextBox, Amount);
			NumberTextChanged(ArgF6TextBox, Amount);
		}

		private void Generalized_Leave(object sender, EventArgs e)
		{
			NumberLeave(TimingTextBox, Amount);
			NumberLeave(ArgN1TextBox, Amount);
			NumberLeave(ArgN2TextBox, Amount);
			NumberLeave(ArgN3TextBox, Amount);
			NumberLeave(ArgF1TextBox, Amount);
			NumberLeave(ArgF2TextBox, Amount);
			NumberLeave(ArgF3TextBox, Amount);
			NumberLeave(ArgF4TextBox, Amount);
			NumberLeave(ArgF5TextBox, Amount);
			NumberLeave(ArgF6TextBox, Amount);
		}

		private void EAnimationIdComboBox_Leave(object sender, EventArgs e)
		{
			if (EAnimationIdComboBox.Text == "")
			{
				EAnimationIdComboBox.Text = PreviousAnimationID;
			}
		}

		private void FindFinalIndex()
		{
			//Made this it's own function since it has that null potential, and I didn't want several warnings.
			//Fixed warnings, too lazy to replace things.
			//Gets Final Index of ListBox
			try
			{
				FinalIndex = EventListBox.Items.IndexOf(EventListBox.Items[EventListBox.Items.Count - 1].ToString()!) + 1;
			}
			catch
			{
				FinalIndex = -1;
			}
		}

		private void ReloadListBox()
		{
			RememberIndexForResize = EventListBox.SelectedIndex;

			//Reload ListBox, recreating the list.
			EventListBox.Items.Clear();

			//Search through whole File
			for (int i = 0; i < ReadAllLines.Length; i++)
			{
				//When Line Finds "StructGUID"
				var Line = ReadAllLines[i];
				if (Line.Contains("StructGUID"))
				{
					//Go to the next Line where the Name is determined.
					string[] NextLine = { ReadAllLines[++i] };

					//Search through the NextLine with "Name"
					foreach (string s in NextLine)
					{
						//Trim off the Quotations and Commas at the ending.
						char[] charsToTrim = { '"', ',' };
						string TrimmedCharString = s.Trim(charsToTrim);
						string NameOfTableEntry = TrimmedCharString.Replace("            \"Name\": \"", "");


						if (EventListBox.Items.Contains(NameOfTableEntry))
						{
							if (CloningSections)
							{
								NameOfTableEntry = (FinalIndex + 1).ToString() + " Cloned ID: " + NameOfTableEntry;
							}
							else
							{
								NameOfTableEntry = (FinalIndex + 1).ToString() + " Duplicate ID: " + NameOfTableEntry + "?";
							}
						}

						EventListBox.Items.Add(NameOfTableEntry);
						FindFinalIndex();
					}
				}
			}
			//Breaks Add/Moving/Removing/Duplicating if inside the For.
			ResizeForm();
		}

		private void ResizeForm()
		{
			var CurrentItemWidth = 0;
			var NewItemWidth = 0;
			try
			{
				CurrentItemWidth = (int)this.CreateGraphics().MeasureString(EventListBox.Items[EventListBox.SelectedIndex].ToString(), EventListBox.Font, TextRenderer.MeasureText(EventListBox.Items[EventListBox.SelectedIndex].ToString(), new Font("Arial", 12.0F))).Width;
			}
			catch
			{
				EventListBox.SelectedIndex = RememberIndexForResize;
				if (RememberIndexForResize != -1)
				{
					CurrentItemWidth = (int)this.CreateGraphics().MeasureString(EventListBox.Items[EventListBox.SelectedIndex].ToString(), EventListBox.Font, TextRenderer.MeasureText(EventListBox.Items[EventListBox.SelectedIndex].ToString(), new Font("Arial", 12.0F))).Width;
				}
				else
				{
					CurrentItemWidth = (int)this.CreateGraphics().MeasureString(EventListBox.Items[EventListBox.Items.Count - 1].ToString(), EventListBox.Font, TextRenderer.MeasureText(EventListBox.Items[EventListBox.Items.Count - 1].ToString(), new Font("Arial", 12.0F))).Width;
				}
			}
			if (CurrentItemWidth > EventListBox.Width)
			{
				NewItemWidth = CurrentItemWidth - EventListBox.Width;
				this.Width = this.Size.Width + NewItemWidth + 30;
			}
		}

		private void GetEnum(string Enum, ComboBox text, int offset, int SubStringOffset)
		{
			//Adjusts the LineNum so the offset is correct.
			int LineNum = ioffset + offset - 2;

			var GetENumValue = ReadAllLines[LineNum];
			//Changes the Index Int to "18" since that's how many characters until the ": "
			int GetENumIndex = GetENumValue.IndexOf(": \"" + Enum);
			//Trim off the Quotations and Commas at the ending.
			char[] charsToTrim = { '"', ',' };
			string TrimmedCharString = GetENumValue.Trim(charsToTrim);
			//If the value is blank, keep it blank instead of trying to index stuff that don't exist.
			string GetENumValueSub = "";
			//The +3 is used to get past the " : " ", the three additional characters past Index.
			if (BlankName != GetENumValue)
			{
				GetENumValueSub = (TrimmedCharString.Substring(GetENumIndex + SubStringOffset));
			}

			text.Text = GetENumValueSub;
		}

		private void GetEnumCount(string[] readlines)
		{
			//Adjusts the LineNum so the offset is correct.
			int LineNum = ioffset + 10 - 2;
			GetENumValue = readlines[LineNum];

			//Used Replace instead of a Index due to it repeatedly erroring for some reason.
			//Seems to be caused due to loading into the basic file, but not sure. No reason to fix what isn't broken though.
			char[] charsToTrim = { '"', ',' };
			string TrimmedCharString = GetENumValue.Trim(charsToTrim);
			GetENumValueSub = TrimmedCharString.Replace("                \"Value\": \"EAnimationId::", "");
		}

		private void GetInt(TextBox text, int offset)
		{
			int LineNum = ioffset + offset - 2;
			var GetIntValue = ReadAllLines[LineNum];
			int GetIntIndex = GetIntValue.IndexOf(": ");
			char[] charsToTrim = { '"', ',' };
			string TrimmedCharString = GetIntValue.Trim(charsToTrim);
			string GetIntValueSub = (TrimmedCharString.Substring(GetIntIndex + 2));
			if (GetIntValue == BlankValue)
			{
				GetIntValueSub = "0";
			}
			text.Text = GetIntValueSub;
		}

		private void GetIntComboBox(ComboBox text, int offset)
		{
			//Gets Value
			int LineNum = ioffset + offset - 2;
			//Gets Name (Evid)
			var CheckLine = ReadAllLines[ioffset + offset - 4];

			var GetIntComboBoxValue = ReadAllLines[LineNum];
			int GetIntComboBoxIndex = GetIntComboBoxValue.IndexOf(": ");
			char[] charsToTrim = { '"', ',' };
			string TrimmedCharString = GetIntComboBoxValue.Trim(charsToTrim);
			string GetIntComboBoxValueSub = (TrimmedCharString.Substring(GetIntComboBoxIndex + 2));
			if (GetIntComboBoxValue == BlankValue)
			{
				GetIntComboBoxValueSub = "0";
			}

			int.TryParse(GetIntComboBoxValueSub, out int GetIntComboBoxValueSubInt);

			string EventIDStr = EventIDFunctions.GetValue(GetIntComboBoxValueSubInt)!.ToString()!;

			if (CheckLine.Contains("Evid"))
			{
				text.Text = EventIDStr;
			}
		}

		private void GetName(TextBox text, int offset)
		{
			//Adjusts the LineNum so the offset is correct.
			int LineNum = ioffset + offset - 2;

			var GetNameValue = ReadAllLines[LineNum];

			//Changes the Index to "18" since that's how many characters until the ": "
			int GetNameIndex = GetNameValue.IndexOf(": ");
			//Trim off the Quotations and Commas at the ending.
			char[] charsToTrim = { '"', ',' };
			string TrimmedCharString = GetNameValue.Trim(charsToTrim);
			//If the value is blank, keep it blank instead of trying to index stuff that don't exist.
			string GetNameValueSub = "";
			//The +3 is used to get past the " : " ", the three additional characters past Index.
			if (BlankName != GetNameValue)
			{
				GetNameValueSub = (TrimmedCharString.Substring(GetNameIndex + 3));
			}
			text.Text = GetNameValueSub;
		}

		private void GetFloat(TextBox text, int offset)
		{
			int LineNum = ioffset + offset - 2;
			var GetFloatValue = ReadAllLines[LineNum];
			int GetFloatIndex = GetFloatValue.IndexOf(": ");
			char[] charsToTrim = { '"', ',', '+' };
			string TrimmedCharString = GetFloatValue.Trim(charsToTrim);
			string GetFloatValueSub = (TrimmedCharString.Substring(GetFloatIndex + 2));
			int FoundPlus = GetFloatValueSub.IndexOf("+");
			if (FoundPlus > 0)
			{
				GetFloatValueSub = TrimmedCharString.Substring(GetFloatIndex + 4);
			}
			if (GetFloatValue == BlankValue)
			{
				GetFloatValueSub = "0";
			}
			text.Text = GetFloatValueSub;
		}

		private void SetEnum(string Enum, ComboBox text, int offset)
		{
			int LineNum = ioffset + offset - 2;
			string Str = ValueStr + "\"" + Enum + text.Text + "\"";
			ReadAllLines[LineNum] = Str;
		}

		private void SetInt(TextBox text, int offset)
		{
			int LineNum = ioffset + offset - 2;
			Decimal.TryParse(text.Text, out Amount);
			string Str = ValueStr + Amount;
			ReadAllLines[LineNum] = Str;
		}

		private void SetIntComboBox(int offset)
		{
			int LineNum = ioffset + offset - 2;
			var CheckLine = ReadAllLines[ioffset + offset - 4];

			if (CheckLine.Contains("Evid"))
			{
				int.TryParse(EvidComboBox.SelectedIndex.ToString(), out int EventIDNumber);
				String Str = ValueStr + EventIDNumber;
				ReadAllLines[LineNum] = Str;
			}
		}

		private void SetName(TextBox text, int offset)
		{
			//Adjusts the LineNum so the offset is correct.
			int LineNum = ioffset + offset - 2;
			string Str = ValueStr + "\"" + text.Text + "\"";
			ReadAllLines[LineNum] = Str;
		}

		private void SetFloat(TextBox text, int offset)
		{
			int LineNum = ioffset + offset - 2;
			Decimal.TryParse(text.Text, out Amount);
			string Str = ValueStr + Amount + ",";
			ReadAllLines[LineNum] = Str;
		}

		private void UpdateSaveData()
		{
			SavingFile = true;

			FindFinalIndex();

			if (FinalIndex == -1)
			{
				//Prevents trying to access the ListBox when no items exist.
			}
			else
			{
				//Prevents breaking if you somehow unselect the ListBox.
				if (EventListBox.SelectedIndex == -1)
				{
					EventListBox.SelectedIndex = 0;
				}

				if (AutoUpdateCheckBox.Checked && ClickedApply)
				{
					int SelectedIndexNumberForLoop = EventListBox.Items.IndexOf(EventListBox.SelectedItem) + 1;

					string EventIDStr = EventIDFunctions.GetValue(EvidComboBox.SelectedIndex)!.ToString()!;
					NameOfTableIDTextbox.Text = SelectedIndexNumberForLoop.ToString() + " Anm: " + EAnimationIdComboBox.Text + ", Ev: " + EventIDStr + ", Timing: " + TimingTextBox.Text;

				RedoRename:
					if (EventListBox.Items.Contains(NameOfTableIDTextbox.Text))
					{
						SelectedIndexNumberForLoop++;
						NameOfTableIDTextbox.Text = SelectedIndexNumberForLoop.ToString() + " Anm: " + EAnimationIdComboBox.Text + ", Ev: " + EventIDStr + ", Timing: " + TimingTextBox.Text;
						goto RedoRename;
					}
				}

				//Sets the current Textbox name to the ListBox name.
				//Causes the EventListBox_SelectedIndexChanged to happen.
				if (IsRemoving == false)
				{
					EventListBox.Items[EventListBox.SelectedIndex] = NameOfTableIDTextbox.Text;
				}
				StructGUIDFound = 0;
				ListBoxIndex = EventListBox.Items.IndexOf(EventListBox.SelectedItem) + 1;

				bool UndoMotChanges = false;

			Restart:

				//Sets values for current ID
				for (int i = 0; i < ReadAllLines.Length; i++)
				{
					var Line = "0";
					try
					{
						Line = ReadAllLines[ioffset];
						ioffset = i;
					}
					catch
					{
						ioffset = i;
						goto Restart;
					}

					if (Line.Contains("StructGUID"))
					{
						StructGUIDFound++;

						if (IsRemoving == false)
						{
							if (StructGUIDFound == ListBoxIndex)
							{
								//Sets the TableID Value
								string Str = "            \"Name\": \"" + NameOfTableIDTextbox.Text + "\",";
								ReadAllLines[ioffset] = Str;

								if (UndoChanges)
								{
									EAnimationIdComboBox.Text = PreviousAnimationID;
									CurrentAnimationID = PreviousAnimationID;
									UndoChanges = false;
									UndoMotChanges = true;
								}
								else
								{
									if (CloningSections == false)
									{
										CurrentAnimationID = EAnimationIdComboBox.Text;
									}
								}

								SetEnum("EAnimationId::", EAnimationIdComboBox, 10);
								SetInt(TimingTextBox, 16);
								SetIntComboBox(22);
								SetName(CoordNameTextBox, 28);
								SetInt(ArgN1TextBox, 34);
								SetInt(ArgN2TextBox, 40);
								SetInt(ArgN3TextBox, 46);
								SetFloat(ArgF1TextBox, 50);
								SetFloat(ArgF2TextBox, 56);
								SetFloat(ArgF3TextBox, 62);
								SetFloat(ArgF4TextBox, 68);
								SetFloat(ArgF5TextBox, 74);
								SetFloat(ArgF6TextBox, 80);
								SetName(DamageIDTextBox, 88);
								SetName(EndureIDTextBox, 94);
							}
						}
					}
				}

				//Updates the mot_ file with your new changes only if the combobox was changed upon hitting Save.
				if (CurrentAnimationID != PreviousAnimationID || UndoMotChanges || CloningSections)
				{
					UndoMotChanges = false;

					UpdateMotFiles();
					if (FoundAnimIDInsideOtherFiles == false)
					{
						AddToMotDialogBox AddMot = new AddToMotDialogBox();
						AddMot.ShowDialog();

						if (AddMot.BasicButtonClicked)
						{
							AddToMotFile(BasicStreamingPath, ReadAllLinesBasic);
							ReadAllLinesBasic = File.ReadAllLines(BasicStreamingPath);
						}

						if (AddMot.DamageReactButtonClicked)
						{
							AddToMotFile(DamageReacStreamingPath, ReadAllLinesDamageReac);
							ReadAllLinesDamageReac = File.ReadAllLines(DamageReacStreamingPath);
						}

						if (AddMot.MeleeButtonClicked)
						{
							AddToMotFile(MeleeStreamingPath, ReadAllLinesMelee);
							ReadAllLinesMelee = File.ReadAllLines(MeleeStreamingPath);
						}

						if (AddMot.SupportButtonClicked)
						{
							AddToMotFile(SupportStreamingPath, ReadAllLinesSupport);
							ReadAllLinesSupport = File.ReadAllLines(SupportStreamingPath);
						}

						if (AddMot.BasicButtonClicked || AddMot.DamageReactButtonClicked || AddMot.MeleeButtonClicked || AddMot.SupportButtonClicked)
						{
							UpdateMotFiles();
							PreviousAnimationID = CurrentAnimationID;
						}

						if (AddMot.BasicButtonClicked == false && AddMot.DamageReactButtonClicked == false && AddMot.MeleeButtonClicked == false && AddMot.SupportButtonClicked == false)
						{
							MessageBox.Show("Error: No mot file selected. Reverting Animation ID.");
							UndoChanges = true;
							UpdateSaveData();
						}
					}
				}
			}

			File.WriteAllLines(StreamingPath, ReadAllLines);

			ResizeForm();

			SavingFile = false;
		}

		private void AddToMotFile(string FilePath, string[] ReadLines)
		{
			bool NoSections = false;

			if (File.Exists(StreamingPathOrig) && File.Exists(BasicStreamingPathOrig) && File.Exists(DamageReacStreamingPathOrig) && File.Exists(MeleeStreamingPathOrig) && File.Exists(SupportStreamingPathOrig))
			{
				int FinalStructGUID = 0;
				StructGUIDFound = 0;

				for (int i = 0; i < ReadLines.Length; i++)
				{
					var Line = ReadLines[i];
					if (Line.Contains("StructGUID"))
					{
						StructGUIDFound++;
					}
				}

				if (StructGUIDFound == 0)
				{
					MessageBox.Show("Somehow this file has no sections in it?\nFile will not be updated.");
					NoSections = true;
				}

				FinalStructGUID = StructGUIDFound;
				StructGUIDFound = 0;
				int NewLineNum = 0;

				if (NoSections == false)
				{
					for (int i = 0; i < ReadLines.Length; i++)
					{
						var Line = ReadLines[i];
						if (Line.Contains("StructGUID"))
						{
							StructGUIDFound++;
							if (StructGUIDFound == FinalStructGUID)
							{
								NewLineNum = i;
								NewLineNum += 55;

								string[] arrLine = File.ReadAllLines(FilePath);

								arrLine[NewLineNum - 1] = AddToMotSectionPart1Str + (StructGUIDFound + 1) + AddToMotSectionPart2Str + CurrentAnimationID + AddToMotSectionPart3Str;
								File.WriteAllLines(FilePath, arrLine.ToArray());
								break;
							}
						}
					}
					UpdateMotFiles();
				}
			}
		}

		private void UpdateMotFiles()
		{
			int RememberIndexNum = ListBoxIndex;
			StructGUIDFound = 0;
			PrevAnimIDAmount = 0;
			NewAnimIDAmount = 0;
			FoundAnimIDInsideOtherFiles = false;

			if (File.Exists(StreamingPathOrig) && File.Exists(BasicStreamingPathOrig) && File.Exists(DamageReacStreamingPathOrig) && File.Exists(MeleeStreamingPathOrig) && File.Exists(SupportStreamingPathOrig))
			{
				for (int a = 0; a < FinalIndex; a++)
				{
					if (ListBoxIndex < FinalIndex - 1)
					{
						ListBoxIndex = EventListBox.SelectedIndex + 1;
					}

					for (int b = 0; b < ReadAllLines.Length; b++)
					{
						var Line = ReadAllLines[ioffset];
						ioffset = b;

						if (Line.Contains("StructGUID"))
						{
							StructGUIDFound++;

							if (StructGUIDFound <= FinalIndex)
							{
								GetEnum("EAnimationId::", EAnimationIdComboBox, 10, 17);
								GetEnumCount(ReadAllLines);

								if (GetENumValue == "                \"Value\": \"EAnimationId::" + PreviousAnimationID + "\"")
								{
									PrevAnimIDAmount++;
									//MessageBox.Show("PreviousAnimationID: " + PreviousAnimationID + "\nPrevAnimIDAmount: " + PrevAnimIDAmount + "\nCurrentAnimationID: " + CurrentAnimationID + "\nNewAnimIDAmount: " + NewAnimIDAmount);
								}
								if (GetENumValue == "                \"Value\": \"EAnimationId::" + CurrentAnimationID + "\"")
								{
									NewAnimIDAmount++;
									//MessageBox.Show("PreviousAnimationID: " + PreviousAnimationID + "\nPrevAnimIDAmount: " + PrevAnimIDAmount + "\nCurrentAnimationID: " + CurrentAnimationID + "\nNewAnimIDAmount: " + NewAnimIDAmount);
								}
							}
							if (StructGUIDFound == FinalIndex)
							{
								EAnimationIdComboBox.Text = CurrentAnimationID;
							}
						}
					}
				}

				//Basic, DamageReac, Melee, Support
				WriteToMotFiles(BasicStreamingPath, ReadAllLinesBasic, "prm_mot_basic");
				WriteToMotFiles(DamageReacStreamingPath, ReadAllLinesDamageReac, "prm_mot_damageReaction");
				WriteToMotFiles(MeleeStreamingPath, ReadAllLinesMelee, "prm_mot_melee");
				WriteToMotFiles(SupportStreamingPath, ReadAllLinesSupport, "prm_mot_support");
			}
		}

		private void WriteToMotFiles(string FilePath, string[] ReadLines, string FileName)
		{
			for (int i = 0; i < ReadLines.Length; i++)
			{
				//Has to load this first or get an exception error.
				ioffset = i;

				var Line = ReadLines[ioffset];
				ioffset = i + 1;
				string Str = "";
				bool UpdateOldAnim = false;
				bool UpdateNewAnim = false;
				if (Line.Contains("StructGUID"))
				{
					GetEnumCount(ReadLines);

					if (GetENumValue == "                \"Value\": \"EAnimationId::" + PreviousAnimationID + "\"")
					{
						Str = ValueStr + PrevAnimIDAmount;
						UpdateOldAnim = true;
					}
					if (GetENumValue == "                \"Value\": \"EAnimationId::" + CurrentAnimationID + "\"")
					{
						FoundAnimIDInsideOtherFiles = true;
						UpdateNewAnim = true;
						Str = ValueStr + NewAnimIDAmount;
					}

					if (UpdateOldAnim || UpdateNewAnim)
					{

						int LineNum = ioffset + 16 - 2;
						ReadLines[LineNum] = Str;
						File.WriteAllLines(FilePath, ReadLines);

						string MessageBoxStr = FileName + " has been updated.\nMake sure to convert this file back with UAssetGUI as well.\n\nYou will not be prompted again for this file until after you save.";
						if (FileName.Contains("prm_mot_basic"))
						{
							if (NotifyUserBasic)
							{
								MessageBox.Show(MessageBoxStr);
								NotifyUserBasic = false;
							}
						}
						if (FileName.Contains("prm_mot_damageReaction"))
						{
							if (NotifyUserDamageReac)
							{
								MessageBox.Show(MessageBoxStr);
								NotifyUserDamageReac = false;
							}
						}
						if (FileName.Contains("prm_mot_melee"))
						{
							if (NotifyUserMelee)
							{
								MessageBox.Show(MessageBoxStr);
								NotifyUserMelee = false;
							}
						}
						if (FileName.Contains("prm_mot_support"))
						{
							if (NotifyUserSupport)
							{
								MessageBox.Show(MessageBoxStr);
								NotifyUserSupport = false;
							}
						}
					}
				}
			}
		}

		private void YoinkFromFileButton_Click(object sender, EventArgs e)
		{
			AllowToolTips = false;
			bool UserBackedOut = false;
			bool IsValidEventFileToYoink = false;
			bool IsValidIDToYoink = false;
			bool AppendToMainFile = false;
			int AppendCount = 0;
			int FoundAnimIDToYoink = 0;
			int IndexToSelect = 0;
			string[] SectionToYoink = Array.Empty<string>();
			List<string> lines = new List<string>();
			StructGUIDFound = 0;

			OpenFileDialog OpenYoinkFile = new OpenFileDialog();
			OpenYoinkFile.Title = "Open a mot_event.json";
			OpenYoinkFile.Filter = "JavaScript Object Notation (*.json)|*.json|Backup File (*.bak)|*.bak|All files (*.*)|*.*";
			if (Properties.Settings.Default.RememberYoinkPath != null)
			{
				OpenYoinkFile.FileName = Properties.Settings.Default.RememberYoinkPath;
			}
			OpenYoinkFile.FilterIndex = 1;
			OpenYoinkFile.CheckFileExists = true;
			OpenYoinkFile.CheckPathExists = true;
			OpenYoinkFile.RestoreDirectory = true;
			if (OpenYoinkFile.ShowDialog() == DialogResult.OK)
			{
				YoinkStreamingPath = OpenYoinkFile.FileName;
				Properties.Settings.Default.RememberYoinkPath = YoinkStreamingPath;
				ReadAllLinesYoink = File.ReadAllLines(YoinkStreamingPath);
				string AnimIDSelection = "";

				foreach (var Line in ReadAllLinesYoink)
				{
					if (Line.Contains("prm_mot_event"))
					{
						IsValidEventFileToYoink = true;
						SelectAnimIDForm AnimIDForm = new SelectAnimIDForm();
						AnimIDForm.ShowDialog();

						if (AnimIDForm.PressedOK)
						{
							AnimIDSelection = AnimIDForm.ComboBoxSelection;
							break;
						}
						else
						{
							UserBackedOut = true;
							break;
						}
					}
					else
					{
						IsValidEventFileToYoink = false;
					}
				}

				if (UserBackedOut == false)
				{
					if (IsValidEventFileToYoink)
					{
						for (int i = 0; i < ReadAllLinesYoink.Length; i++)
						{
							var Line = ReadAllLinesYoink[i];

							if (Line.Contains("\"Value\": \"EAnimationId::" + AnimIDSelection + "\""))
							{
								IsValidIDToYoink = true;
								FoundAnimIDToYoink++;
							}
						}
						for (int i = 0; i < ReadAllLines.Length; i++)
						{
							var Line = ReadAllLines[i];
							if (Line.Contains("StructGUID"))
							{
								StructGUIDFound++;
							}
							if (Line.Contains("\"Value\": \"EAnimationId::" + AnimIDSelection + "\""))
							{
								AppendToMainFile = true;
								AppendCount++;

								if (AppendCount == 1)
								{
									IndexToSelect = StructGUIDFound;
								}
							}
						}
					}
					else
					{
						MessageBox.Show("This is not a prm_mot_event.json file.");
						YoinkStreamingPath = "";
						ReadAllLinesYoink = Array.Empty<string>();
					}

					//Reset this so it knows what to look for in legit file.
					int FinalStructGUID = StructGUIDFound;
					int FinalAppendCount = AppendCount;
					int CurrentYoinkCount = 0;
					int FinalYoinkCount = 1;

					StructGUIDFound = 0;
					AppendCount = 0;

					if (IsValidEventFileToYoink)
					{
						SavingFile = true;

						//Redo it so the error will properly trigger if not found.
						if (IsValidIDToYoink)
						{
						YoinkFromFile:
							CurrentYoinkCount = 0;
							for (int i = 0; i < ReadAllLinesYoink.Length; i++)
							{
								var Line = ReadAllLinesYoink[i];
								if (Line.Contains("\"Value\": \"EAnimationId::" + AnimIDSelection + "\""))
								{
									CurrentYoinkCount++;
									if (CurrentYoinkCount == FinalYoinkCount)
									{
										lines = File.ReadAllLines(YoinkStreamingPath).ToList();
										SectionToYoink = lines.GetRange(i - 13, 101).ToArray();

										if ((FinalYoinkCount - 1) < FoundAnimIDToYoink)
										{
											FinalYoinkCount++;
											goto AddToFile;
										}
										else
										{
											break;
										}
									}
								}
							}
						AddToFile:
							StructGUIDFound = 0;
							AppendCount = 0;
							for (int a = 0; a < ReadAllLines.Length; a++)
							{
								var Line = ReadAllLines[a];
								bool FixBracket = false;
								if (AppendToMainFile == false)
								{
									if (Line.Contains("StructGUID"))
									{
										StructGUIDFound++;
										if (StructGUIDFound == FinalStructGUID)
										{
											FinalStructGUID++;
											lines = File.ReadAllLines(StreamingPath).ToList();

											lines.RemoveAt(a + 96);
											lines.Insert(a + 96, "          },");

											lines.InsertRange(a - 4 + 101, SectionToYoink);

											if (FinalYoinkCount == FoundAnimIDToYoink)
											{
												lines.RemoveAt(a + 197);
												lines.Insert(a + 197, "          }");
											}

											File.WriteAllLines(StreamingPath, lines.ToArray());
											ReadAllLines = File.ReadAllLines(StreamingPath);
											if ((FinalYoinkCount - 1) < FoundAnimIDToYoink)
											{
												goto YoinkFromFile;
											}
											else
											{
												break;
											}
										}
									}
								}
								else
								{
									if (Line.Contains("\"Value\": \"EAnimationId::" + AnimIDSelection + "\""))
									{
										AppendCount++;
										if (AppendCount == FinalAppendCount)
										{
											if (ReadAllLines[a + 87] == "          }")
											{
												FixBracket = true;
											}

											FinalAppendCount++;
											lines = File.ReadAllLines(StreamingPath).ToList();
											lines.RemoveAt(a + 87);
											lines.Insert(a + 87, "          },");
											lines.InsertRange(a - 13 + 101, SectionToYoink);

											if (FinalYoinkCount == FoundAnimIDToYoink && FixBracket)
											{
												lines.RemoveAt(a + 188);
												lines.Insert(a + 188, "          }");
											}

											File.WriteAllLines(StreamingPath, lines.ToArray());
											ReadAllLines = File.ReadAllLines(StreamingPath);
											if ((FinalYoinkCount - 1) < FoundAnimIDToYoink)
											{
												goto YoinkFromFile;
											}
											else
											{
												break;
											}
										}
									}
								}
							}
							//Sets the proper names and allows the mot files to get updated.
							CloningSections = true;
							//Changes these so the correct mot files get updated.
							PreviousAnimationID = "";
							CurrentAnimationID = AnimIDSelection;
							EventListBox.SelectedIndex = -1;
							ReloadListBox();
							UpdateSaveData();

							if (AppendToMainFile)
							{
								EventListBox.SelectedIndex = IndexToSelect + FinalAppendCount - 2;
							}
							else
							{
								EventListBox.SelectedIndex = FinalIndex - 1;
							}
						}
						else
						{
							MessageBox.Show("This ID does not exist within this Event File.");
						}
						AllowToolTips = true;
						SavingFile = false;
						CloningSections = false;
					}
				}
			}
		}
	}
}