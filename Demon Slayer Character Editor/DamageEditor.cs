using System.Globalization;
using System.Text.RegularExpressions;

namespace Demon_Slayer_Character_Editor
{
	public partial class DamageEditorForm : Form
	{
		public Regex reg = new Regex(@"^-?\d+[.]?\d*$", System.Text.RegularExpressions.RegexOptions.CultureInvariant);
		public string[] ReadAllLines = Array.Empty<string>();
		public string[] ReadAllLinesOrig = Array.Empty<string>();
		public string StreamingPath = "";
		public string StreamingPathOrig = "";
		public string StreamingPathBak = "";
		public string SaveAsPath = "";
		public bool IsDamageFile = false;
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
			""StructType"": ""APKDamageImportParam"",
			""SerializeNone"": true,
			""StructGUID"": ""00000000-0000-0000-0000-000000000000"",
			""Name"": """;
		public string NewSectionPart2Str = @""",
			""DuplicationIndex"": 0,
			""Value"": [
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.NamePropertyData, UAssetAPI"",
				""Name"": ""Name"",
				""DuplicationIndex"": 0,
				""Value"": ""0""
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
				""Name"": ""AttackPriority"",
				""DuplicationIndex"": 0,
				""Value"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.NamePropertyData, UAssetAPI"",
				""Name"": ""DamageId"",
				""DuplicationIndex"": 0,
				""Value"": ""DAMAGE_ID""
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""bLockonPlayerOnly"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 0.0,
				""Name"": ""LifeDamage"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 0.0,
				""Name"": ""MinLifeDamage"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": -1,
				""Name"": ""OverrideRecovLifeDamageRate"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": ""+0"",
				""Name"": ""BreathDamage"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": ""+0"",
				""Name"": ""GuardVitalityDamage"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 0,
				""Name"": ""GuardPenetrationDamageRate"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 100.0,
				""Name"": ""StartupDamageCorrection"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 100.0,
				""Name"": ""BeforeDamageCorrection"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 100.0,
				""Name"": ""AfterDamageCorrection"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""bOverwriteAfterDamageCorrection"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 0.0,
				""Name"": ""ForwardSpeed"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 0.0,
				""Name"": ""VerticalSpeed"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": ""+0"",
				""Name"": ""HorizontalSpeed"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 0.0,
				""Name"": ""ForwardSpeed_Air"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 0.0,
				""Name"": ""VerticalSpeed_Air"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": ""+0"",
				""Name"": ""HorizontalSpeed_Air"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": ""+0"",
				""Name"": ""ForwardSpeed_Guard"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": ""+0"",
				""Name"": ""VerticalSpeed_Guard"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": ""+0"",
				""Name"": ""HorizontalSpeed_Guard"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": ""+0"",
				""Name"": ""BoundSpeed"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": ""+0"",
				""Name"": ""HeightLimit"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": ""+0"",
				""Name"": ""BrakeTime"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.EnumPropertyData, UAssetAPI"",
				""EnumType"": ""EHitBackType"",
				""Name"": ""HitbackDirectionType"",
				""DuplicationIndex"": 0,
				""Value"": ""EHitBackType::HIT_BACK_PL_FORWARD""
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": ""+0"",
				""Name"": ""HitbackYawOffset"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.NamePropertyData, UAssetAPI"",
				""Name"": ""StatusAilment_Id"",
				""DuplicationIndex"": 0,
				""Value"": ""None""
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": ""+0"",
				""Name"": ""StatusAilment_Time"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": ""+0"",
				""Name"": ""StatusAilment_Rate"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
				""Name"": ""ChargeMaxFrame"",
				""DuplicationIndex"": 0,
				""Value"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
				""Name"": ""ChargeGuardVitalityMaxValue"",
				""DuplicationIndex"": 0,
				""Value"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
				""Name"": ""ChargeLifeDamageMaxValue"",
				""DuplicationIndex"": 0,
				""Value"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": ""+0"",
				""Name"": ""Invinsible_Time"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": ""+0"",
				""Name"": ""GuardRigorTime"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.EnumPropertyData, UAssetAPI"",
				""EnumType"": ""EDamageReactionType"",
				""Name"": ""Reaction"",
				""DuplicationIndex"": 0,
				""Value"": ""EDamageReactionType::DMG_REAC_NOREACTION""
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
				""Name"": ""AdjustFrame"",
				""DuplicationIndex"": 0,
				""Value"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
				""Name"": ""AdjustFrame_Air"",
				""DuplicationIndex"": 0,
				""Value"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.EnumPropertyData, UAssetAPI"",
				""EnumType"": ""EGuardDamageReactionType"",
				""Name"": ""GuardReaction"",
				""DuplicationIndex"": 0,
				""Value"": ""EGuardDamageReactionType::GUARD_DMG_REAC_S""
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.EnumPropertyData, UAssetAPI"",
				""EnumType"": ""ECharacterWeaponAttachPoint"",
				""Name"": ""WeaponAttachPoint"",
				""DuplicationIndex"": 0,
				""Value"": ""ECharacterWeaponAttachPoint::None""
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.NamePropertyData, UAssetAPI"",
				""Name"": ""HitEffectID"",
				""DuplicationIndex"": 0,
				""Value"": ""None""
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.NamePropertyData, UAssetAPI"",
				""Name"": ""HitEffectID_Medium"",
				""DuplicationIndex"": 0,
				""Value"": ""None""
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.NamePropertyData, UAssetAPI"",
				""Name"": ""HitEffectID_Large"",
				""DuplicationIndex"": 0,
				""Value"": ""None""
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
				""Name"": ""HitEffectRandomRadius"",
				""DuplicationIndex"": 0,
				""Value"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.EnumPropertyData, UAssetAPI"",
				""EnumType"": ""EEffectAngleType"",
				""Name"": ""HitEffectAngleType"",
				""DuplicationIndex"": 0,
				""Value"": ""EEffectAngleType::None""
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": ""+0"",
				""Name"": ""HitEffectDegree"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.NamePropertyData, UAssetAPI"",
				""Name"": ""BloodEffectID"",
				""DuplicationIndex"": 0,
				""Value"": ""None""
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.NamePropertyData, UAssetAPI"",
				""Name"": ""BloodEffectID_Medium"",
				""DuplicationIndex"": 0,
				""Value"": ""None""
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.NamePropertyData, UAssetAPI"",
				""Name"": ""BloodEffectID_Large"",
				""DuplicationIndex"": 0,
				""Value"": ""None""
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.EnumPropertyData, UAssetAPI"",
				""EnumType"": ""EEffectAngleType"",
				""Name"": ""BloodEffectAngleType"",
				""DuplicationIndex"": 0,
				""Value"": ""EEffectAngleType::None""
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": ""+0"",
				""Name"": ""BloodEffectDegree"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.NamePropertyData, UAssetAPI"",
				""Name"": ""HitSEID"",
				""DuplicationIndex"": 0,
				""Value"": ""None""
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 0.0,
				""Name"": ""HitStopSelf"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 0.0,
				""Name"": ""HitStopTarget"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 0.0,
				""Name"": ""HitStopSelf_Awake"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 0.0,
				""Name"": ""HitStopTarget_Awake"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 0.0,
				""Name"": ""HitStopSelf_SuperAwake"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 0.0,
				""Name"": ""HitStopTarget_SuperAwake"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 0.0,
				""Name"": ""GuardHitStopSelf"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 0.0,
				""Name"": ""GuardHitStopTarget"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 0.0,
				""Name"": ""GuardHitStopSelf_Awake"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 0.0,
				""Name"": ""GuardHitStopTarget_Awake"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 0.0,
				""Name"": ""GuardHitStopSelf_SuperAwake"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.FloatPropertyData, UAssetAPI"",
				""Value"": 0.0,
				""Name"": ""GuardHitStopTarget_SuperAwake"",
				""DuplicationIndex"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
				""Name"": ""NonRecoveryTime"",
				""DuplicationIndex"": 0,
				""Value"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
				""Name"": ""ComboableFrame"",
				""DuplicationIndex"": 0,
				""Value"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
				""Name"": ""CameraShakeType"",
				""DuplicationIndex"": 0,
				""Value"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
				""Name"": ""CameraShakeType_Awake"",
				""DuplicationIndex"": 0,
				""Value"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.IntPropertyData, UAssetAPI"",
				""Name"": ""CameraShakeType_SuperAwake"",
				""DuplicationIndex"": 0,
				""Value"": 0
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""bNoKnockOut"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.NamePropertyData, UAssetAPI"",
				""Name"": ""SpecialCamName"",
				""DuplicationIndex"": 0,
				""Value"": ""None""
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""Attr_Slash"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""Attr_Blow"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""Attr_RemoteSkill"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""Attr_Skill"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""Attr_Spl"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""Attr_Throw"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""Attr_Unblockable"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""Attr_ChipDamage"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""Attr_ComboCamera"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""Attr_Landing"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""Attr_NoInvincible"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""Attr_NoRepel"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""Attr_PerformanceTrigger"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""Attr_NoSupportRescue"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""Attr_NoBurst"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""Attr_SkillErase"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""Attr_OnlyGround"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""Attr_NoSuperArmor"",
				""DuplicationIndex"": 0,
				""Value"": false
			  },
			  {
				""$type"": ""UAssetAPI.PropertyTypes.Objects.BoolPropertyData, UAssetAPI"",
				""Name"": ""Attr_DisableNoInvincibleToSupportAssist"",
				""DuplicationIndex"": 0,
				""Value"": false
			  }
			]
		  }";
		public string AllStatusAilmentIdLabel = "";
		public string AllEDamageReactionTypeLabel = "";
		public string AllAdjustFrameLabel = "";
		public int ioffset = 0;
		public int StructGUIDFound = 0;
		public bool ModifyAll = false;
		public Int32 ListBoxIndex = 0;
		public Int32 FinalIndex = 0;
		public string YoinkStreamingPath = "";
		public string[] ReadAllLinesYoink = Array.Empty<string>();
		public string[] DamageIDListArray = Array.Empty<string>();
		public bool CloningSections = false;

		public DamageEditorForm()
		{
			InitializeComponent();
			Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			ToolTip tt = new ToolTip();
			tt.SetToolTip(StatusAilmentIdLabel, @"Loads Table IDs within ""APK\Content\MasterData\BuffDebuff\MasterBuffDebuffData.uasset""

Default Values:
None = Load Nothing
1 = Attack
2 = Defence
3 = Speed
10 = Poison Damage
11 = Smell Poison
26 = Sleep
27 = BindSwamp
28 = Web1
29 = Web2");
			tt.SetToolTip(EDamageReactionTypeLabel, @"This is the Animation (Reaction) the opponent plays when they get hurt.
Loads Animations within ""APK\Content\BluePrints\APK\Characters\"" ""DT_Cmn_DamageAM.uasset"" and ""DT_Cmn_DamageAM_Female.uasset""

Notes on each ID:
DMG_REAC_NOREACTION = Nothing, knockback is not applied.
DMG_REAC_REPEL = No stagger animation, used when 'shoving', no stagger, but knockback is applied.
DMG_REAC_FINISH_BLOW = No stagger animation, hit counter never ends.
DMG_REAC_BLOW_SPIN = Used in Burst / ForceBlow, launches opponent but gives them i-frames.
DMG_REAC_DEFEAT = Clash when both players dash into each other.
DMG_REAC_PUSH = Forces the opponent to block.
DMG_REAC_BOUND = Bounces the opponent. Generally used in air combo finishers.
DMG_REAC_SLEEP = Enmu Sleep Stagger.
DMG_REAC_THROW = Causes Throw Cinematic.
DMG_REAC_S_RANDOM = Standard Small Stagger.
DMG_REAC_S_B = Back
DMG_REAC_S_F = Forward
DMG_REAC_S_L = Left
DMG_REAC_S_R = Right
DMG_REAC_S_U = Up (Tilts Head upwards, Forwards if hit from behind)
DMG_REAC_L_B = Large Back
DMG_REAC_L_F = Large Forward
DMG_REAC_L_G = Stumbles Back on First Hit, Trip on Further Hits.	
DMG_REAC_L_U = Large Up
DMG_REAC_BLOW_F = Launches Opponent Forwards.
DMG_REAC_BLOW_B = Downs the opponent immediately, but they can do a Quick Recovery. When in air it pushes them towards you.
DMG_REAC_UPPER_F = Launches Opponent Forwards. Just a slightly different animation for it.
DMG_REAC_UPPER_B = Causes the opponent to do a forced backflip Quick Recover, but only when on ground.
DMG_REAC_DOWN = Instantly downs the opponent. Cannot followup.
DMG_REAC_DOWN_B_LP = Instantly downs the opponent, laying facedown. Cannot followup.
DMG_REAC_DOWN_F_ST_S = Crumbles the opponent if grounded, can hit them off the floor. Short Stagger.
DMG_REAC_DOWN_F_ST_L = Crumbles the opponent if grounded, can hit them off the floor. Large Stagger.
DMG_REAC_DOWN_F_ST_STRIKE = Slams the opponent on the ground. Cannot followup.
DMG_REAC_DOWN_B_ST_STRIKE = Slams the opponent on the ground. Cannot followup.
DMG_REAC_SLIDE_F = Grounds the opponent with them sliding forward.
DMG_REAC_SLIDE_F_ROLLING = Grounds the opponent with them rolling around.
DMG_REAC_SLIDE_B_ROLLING = Grounds the opponent with them rolling around. Reversed Stagger animations when midair.
DMG_REAC_BOSS_P1004_ALLOW = Some sort of standard stagger, then they snap onto the floor like the DMG_REAC_DOWN stagger.
DMG_REAC_BIND = Falling Midair infinitely. Softlocks until hit again.
DMG_REAC_BOSS_P1006_ROOM_ROT = Causes the opponent to spaz out for a frame, then fall forever. Softlocks until hit again.
DMG_REAC_BOSS_P1003_BIND = Nothing.
DMG_REAC_BOSS_P1004_2HIT = Nothing.
DMG_REAC_BOSS_P1004_FALL = Nothing.
DMG_REAC_BOSS_P1004_SMASH = Nothing.
DMG_REAC_CUT = Nothing.
DMG_REAC_BOSS_E0005_BIND = Nothing.
DMG_REAC_BOSS_P1004_BLOW_B = Nothing.
DMG_REAC_BOSS_P1004_RAISE = Nothing.
DMG_REAC_SPL = Nothing.
DMG_REAC_P1011_SPL_ST = Nothing.");
			tt.SetToolTip(AdjustFrameLabel, @"This lets you speed up or slowdown the Damage Stagger to change the overall stun time of the attack.");
			tt.SetToolTip(AllLabel, @"If this is toggled, the ID selected will overwrite the value of every single table ID entry.
Example: If you set Combo Timer to Infinite, then toggle to this to Combo Timer, every move will update to be Infinite. Use with caution.");

			AllStatusAilmentIdLabel = StatusAilmentIdLabel.Text;
			AllEDamageReactionTypeLabel = EDamageReactionTypeLabel.Text;
			AllAdjustFrameLabel = AdjustFrameLabel.Text;
			string InfoChar = "⍰";

			AllStatusAilmentIdLabel = AllStatusAilmentIdLabel.Replace(InfoChar, "");
			AllEDamageReactionTypeLabel = AllEDamageReactionTypeLabel.Replace(InfoChar, "");
			AllAdjustFrameLabel = AllAdjustFrameLabel.Replace(InfoChar, "");

			AllComboBox.Items.Add(DamageIDLabel.Text);
			AllComboBox.Items.Add(UnknownNameLabel.Text);
			AllComboBox.Items.Add(AttackPriorityLabel.Text);
			AllComboBox.Items.Add(DamageLabel.Text);
			AllComboBox.Items.Add(MinDamageLabel.Text);
			AllComboBox.Items.Add(GuardDamageLabel.Text);
			AllComboBox.Items.Add(ChipDamageLabel.Text);
			AllComboBox.Items.Add(AllStatusAilmentIdLabel);
			AllComboBox.Items.Add(StatusAilmentTimeLabel.Text);
			AllComboBox.Items.Add(StatusAilmentRateLabel.Text);
			AllComboBox.Items.Add(ForwardSpeedLabel.Text);
			AllComboBox.Items.Add(VerticalSpeedLabel.Text);
			AllComboBox.Items.Add(HorizontalSpeedLabel.Text);
			AllComboBox.Items.Add(ForwardSpeedAirLabel.Text);
			AllComboBox.Items.Add(VerticalSpeedAirLabel.Text);
			AllComboBox.Items.Add(HorizontalSpeedAirLabel.Text);
			AllComboBox.Items.Add(ForwardGuardSpeedLabel.Text);
			AllComboBox.Items.Add(VerticalGuardSpeedLabel.Text);
			AllComboBox.Items.Add(HorizontalGuardSpeedLabel.Text);
			AllComboBox.Items.Add(BoundSpeedLabel.Text);
			AllComboBox.Items.Add(AllEDamageReactionTypeLabel);
			AllComboBox.Items.Add(AllAdjustFrameLabel);
			AllComboBox.Items.Add(AdjustFrameAirLabel.Text);
			AllComboBox.Items.Add(HitbackDirectionTypeLabel.Text);
			AllComboBox.Items.Add(HitbackYawOffsetLabel.Text);
			AllComboBox.Items.Add(EGuardDamageReactionType.Text);
			AllComboBox.Items.Add(GuardRigorTimeLabel.Text);
			AllComboBox.Items.Add(ChargeMaxFrameLabel.Text);
			AllComboBox.Items.Add(ChargeLifeDamageMaxValueLabel.Text);
			AllComboBox.Items.Add(ChargeGuardVitalityMaxValueLabel.Text);
			AllComboBox.Items.Add(HitSEIDLabel.Text);
			AllComboBox.Items.Add(HitEffectIDLabel.Text);
			AllComboBox.Items.Add(HitEffectIDMediumLabel.Text);
			AllComboBox.Items.Add(HitEffectIDLargeLabel.Text);
			AllComboBox.Items.Add(EffectAngleTypeLabel.Text);
			AllComboBox.Items.Add(HitEffectDegreeLabel.Text);
			AllComboBox.Items.Add(HitEffectRandomRadiusLabel.Text);
			AllComboBox.Items.Add(BloodEffectIDLabel.Text);
			AllComboBox.Items.Add(BloodEffectIDMediumLabel.Text);
			AllComboBox.Items.Add(BloodEffectIDLargeLabel.Text);
			AllComboBox.Items.Add(BloodEffectAngleTypeLabel.Text);
			AllComboBox.Items.Add(BloodEffectDegreeLabel.Text);
			AllComboBox.Items.Add(HitStopSelfLabel.Text);
			AllComboBox.Items.Add(HitStopTargetLabel.Text);
			AllComboBox.Items.Add(HitStopSelfAwakeLabel.Text);
			AllComboBox.Items.Add(HitStopTargetAwakeLabel.Text);
			AllComboBox.Items.Add(HitStopSelfSuperAwakeLabel.Text);
			AllComboBox.Items.Add(HitStopTargetSuperAwakeLabel.Text);
			AllComboBox.Items.Add(GuardHitStopSelfLabel.Text);
			AllComboBox.Items.Add(GuardHitStopTargetLabel.Text);
			AllComboBox.Items.Add(GuardHitStopSelfAwakeLabel.Text);
			AllComboBox.Items.Add(GuardHitStopTargetAwakeLabel.Text);
			AllComboBox.Items.Add(GuardHitStopSelfSuperAwakeLabel.Text);
			AllComboBox.Items.Add(GuardHitStopTargetSuperAwakeLabel.Text);
			AllComboBox.Items.Add(NonRecoveryTimeLabel.Text);
			AllComboBox.Items.Add(ComboableFrameLabel.Text);
			AllComboBox.Items.Add(CameraShakeTypeLabel.Text);
			AllComboBox.Items.Add(CameraShakeTypeAwakeLabel.Text);
			AllComboBox.Items.Add(CameraShakeTypeSuperAwakeLabel.Text);
			AllComboBox.Items.Add(SpecialCamNameLabel.Text);
			AllComboBox.Items.Add(WeaponAttachPointLabel.Text);
			AllComboBox.Items.Add(OverrideRecovLifeDamageRateLabel.Text);
			AllComboBox.Items.Add(BreathDamageLabel.Text);
			AllComboBox.Items.Add(StartupDamageCorrectionLabel.Text);
			AllComboBox.Items.Add(BeforeDamageCorrectionLabel.Text);
			AllComboBox.Items.Add(AfterDamageCorrectionLabel.Text);
			AllComboBox.Items.Add(HeightLimitLabel.Text);
			AllComboBox.Items.Add(BrakeTimeLabel.Text);
			AllComboBox.Items.Add(InvinsibleTimeLabel.Text);
			AllComboBox.Items.Add(AttrSlashCheckBox.Text);
			AllComboBox.Items.Add(AttrBlowCheckBox.Text);
			AllComboBox.Items.Add(AttrRemoteSkillCheckBox.Text);
			AllComboBox.Items.Add(AttrSkillCheckBox.Text);
			AllComboBox.Items.Add(AttrSplCheckBox.Text);
			AllComboBox.Items.Add(AttrThrowCheckBox.Text);
			AllComboBox.Items.Add(AttrUnblockableCheckBox.Text);
			AllComboBox.Items.Add(AttrChipDamageCheckBox.Text);
			AllComboBox.Items.Add(bLockonPlayerOnlyCheckBox.Text);
			AllComboBox.Items.Add(bOverwriteAfterDamageCorrectionCheckBox.Text);
			AllComboBox.Items.Add(AttrComboCameraCheckBox.Text);
			AllComboBox.Items.Add(AttrLandingCheckBox.Text);
			AllComboBox.Items.Add(AttrNoInvincibleCheckBox.Text);
			AllComboBox.Items.Add(AttrDisableNoInvincibleToSupportAssistCheckBox.Text);
			AllComboBox.Items.Add(AttrNoRepelCheckBox.Text);
			AllComboBox.Items.Add(AttrPerformanceTriggerCheckBox.Text);
			AllComboBox.Items.Add(bNoKnockOutCheckBox.Text);
			AllComboBox.Items.Add(AttrNoSupportRescueCheckBox.Text);
			AllComboBox.Items.Add(AttrNoBurstCheckBox.Text);
			AllComboBox.Items.Add(AttrSkillEraseCheckBox.Text);
			AllComboBox.Items.Add(AttrOnlyGroundCheckBox.Text);
			AllComboBox.Items.Add(AttrNoSuperArmorCheckBox.Text);

			if (AllComboBox.Text == "")
			{
				AllComboBox.SelectedIndex = 0;
			}

			if (Properties.Settings.Default.CreateBackupsDamage)
			{
				BackupsButton.Checked = true;
			}
			else
			{
				BackupsButton.Checked = false;
			}
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (File.Exists(StreamingPath))
			{
				File.Delete(StreamingPath);

				if (BackupsButton.Checked && IsDamageFile)
				{
					File.WriteAllLines(StreamingPathBak, ReadAllLinesOrig);
				}
			}
			Properties.Settings.Default.Save();
			StartupForm startform = (StartupForm)this.Owner;
			startform.LaunchDmgEditorButton.Enabled = true;
		}

		private void DisableStuff()
		{
			YoinkFromFileButton.Enabled = false;
			DuplicateButton.Enabled = false;
			RemoveButton.Enabled = false;
			MoveUpButton.Enabled = false;
			MoveDownButton.Enabled = false;
			SaveChangesToMoveButton.Enabled = false;
			bLockonPlayerOnlyCheckBox.Enabled = false;
			bLockonPlayerOnlyCheckBox.Checked = false;
			bOverwriteAfterDamageCorrectionCheckBox.Enabled = false;
			bOverwriteAfterDamageCorrectionCheckBox.Checked = false;
			NameOfTableIDTextbox.Enabled = false;
			NameOfTableIDTextbox.Text = "";
			AttackPriorityTextbox.Enabled = false;
			AttackPriorityTextbox.Text = "";
			DamageTextBox.Enabled = false;
			DamageTextBox.Text = "";
			DamageIDTextbox.Enabled = false;
			DamageIDTextbox.Text = "";
			JPNameTextBox.Enabled = false;
			JPNameTextBox.Text = "";
			MinDmgTextbox.Enabled = false;
			MinDmgTextbox.Text = "";
			OverrideRecovLifeDamageRateTextBox.Enabled = false;
			OverrideRecovLifeDamageRateTextBox.Text = "";
			BreathDamageTextBox.Enabled = false;
			BreathDamageTextBox.Text = "";
			GuardDamageTextBox.Enabled = false;
			GuardDamageTextBox.Text = "";
			ChipDamageTextBox.Enabled = false;
			ChipDamageTextBox.Text = "";
			StartupDamageCorrectionTextBox.Enabled = false;
			StartupDamageCorrectionTextBox.Text = "";
			BeforeDamageCorrectionTextBox.Enabled = false;
			BeforeDamageCorrectionTextBox.Text = "";
			AfterDamageCorrectionTextBox.Enabled = false;
			AfterDamageCorrectionTextBox.Text = "";
			ForwardSpeedTextBox.Enabled = false;
			ForwardSpeedTextBox.Text = "";
			VerticalSpeedTextBox.Enabled = false;
			VerticalSpeedTextBox.Text = "";
			HorizontalSpeedTextBox.Enabled = false;
			HorizontalSpeedTextBox.Text = "";
			ForwardSpeedAirTextBox.Enabled = false;
			ForwardSpeedAirTextBox.Text = "";
			VerticalSpeedAirTextBox.Enabled = false;
			VerticalSpeedAirTextBox.Text = "";
			HorizontalSpeedAirTextBox.Enabled = false;
			HorizontalSpeedAirTextBox.Text = "";
			ForwardSpeedGuardTextBox.Enabled = false;
			ForwardSpeedGuardTextBox.Text = "";
			VerticalSpeedGuardTextBox.Enabled = false;
			VerticalSpeedGuardTextBox.Text = "";
			HorizontalSpeedGuardTextBox.Enabled = false;
			HorizontalSpeedGuardTextBox.Text = "";
			BoundSpeedTextBox.Enabled = false;
			BoundSpeedTextBox.Text = "";
			HeightLimitTextBox.Enabled = false;
			HeightLimitTextBox.Text = "";
			BrakeTimeTextBox.Enabled = false;
			BrakeTimeTextBox.Text = "";
			HitbackDirectionTypeComboBox.Enabled = false;
			HitbackDirectionTypeComboBox.Text = "";
			HitbackYawOffsetTextBox.Enabled = false;
			HitbackYawOffsetTextBox.Text = "";
			StatusAilmentIdTextBox.Enabled = false;
			StatusAilmentIdTextBox.Text = "";
			StatusAilmentTimeTextBox.Enabled = false;
			StatusAilmentTimeTextBox.Text = "";
			StatusAilmentRateTextBox.Enabled = false;
			StatusAilmentRateTextBox.Text = "";
			ChargeMaxFrameTextBox.Enabled = false;
			ChargeMaxFrameTextBox.Text = "";
			ChargeGuardVitalityMaxValueTextBox.Enabled = false;
			ChargeGuardVitalityMaxValueTextBox.Text = "";
			ChargeLifeDamageMaxValueTextBox.Enabled = false;
			ChargeLifeDamageMaxValueTextBox.Text = "";
			InvinsibleTimeTextBox.Enabled = false;
			InvinsibleTimeTextBox.Text = "";
			GuardRigorTimeTextBox.Enabled = false;
			GuardRigorTimeTextBox.Text = "";
			EDamageReactionTypeComboBox.Enabled = false;
			EDamageReactionTypeComboBox.Text = "";
			AdjustFrameTextBox.Enabled = false;
			AdjustFrameTextBox.Text = "";
			AdjustFrameAirTextBox.Enabled = false;
			AdjustFrameAirTextBox.Text = "";
			EGuardDamageReactionTypeComboBox.Enabled = false;
			EGuardDamageReactionTypeComboBox.Text = "";
			WeaponAttachPointComboBox.Enabled = false;
			WeaponAttachPointComboBox.Text = "";
			HitEffectIDTextBox.Enabled = false;
			HitEffectIDTextBox.Text = "";
			HitEffectIDMediumTextBox.Enabled = false;
			HitEffectIDMediumTextBox.Text = "";
			HitEffectIDLargeTextBox.Enabled = false;
			HitEffectIDLargeTextBox.Text = "";
			HitEffectRandomRadiusTextBox.Enabled = false;
			HitEffectRandomRadiusTextBox.Text = "";
			EffectAngleTypeComboBox.Enabled = false;
			EffectAngleTypeComboBox.Text = "";
			HitEffectDegreeTextBox.Enabled = false;
			HitEffectDegreeTextBox.Text = "";
			BloodEffectIDTextBox.Enabled = false;
			BloodEffectIDTextBox.Text = "";
			BloodEffectIDMediumTextBox.Enabled = false;
			BloodEffectIDMediumTextBox.Text = "";
			BloodEffectIDLargeTextBox.Enabled = false;
			BloodEffectIDLargeTextBox.Text = "";
			BloodEffectAngleTypeComboBox.Enabled = false;
			BloodEffectAngleTypeComboBox.Text = "";
			BloodEffectDegreeTextBox.Enabled = false;
			BloodEffectDegreeTextBox.Text = "";
			HitSEIDTextBox.Enabled = false;
			HitSEIDTextBox.Text = "";
			HitStopSelfTextBox.Enabled = false;
			HitStopSelfTextBox.Text = "";
			HitStopTargetTextBox.Enabled = false;
			HitStopTargetTextBox.Text = "";
			HitStopSelfAwakeTextBox.Enabled = false;
			HitStopSelfAwakeTextBox.Text = "";
			HitStopTargetAwakeTextBox.Enabled = false;
			HitStopTargetAwakeTextBox.Text = "";
			HitStopSelfSuperAwakeTextBox.Enabled = false;
			HitStopSelfSuperAwakeTextBox.Text = "";
			HitStopTargetSuperAwakeTextBox.Enabled = false;
			HitStopTargetSuperAwakeTextBox.Text = "";
			GuardHitStopSelfTextBox.Enabled = false;
			GuardHitStopSelfTextBox.Text = "";
			GuardHitStopTargetTextBox.Enabled = false;
			GuardHitStopTargetTextBox.Text = "";
			GuardHitStopSelfAwakeTextBox.Enabled = false;
			GuardHitStopSelfAwakeTextBox.Text = "";
			GuardHitStopTargetAwakeTextBox.Enabled = false;
			GuardHitStopTargetAwakeTextBox.Text = "";
			GuardHitStopSelfSuperAwakeTextBox.Enabled = false;
			GuardHitStopSelfSuperAwakeTextBox.Text = "";
			GuardHitStopTargetSuperAwakeTextBox.Enabled = false;
			GuardHitStopTargetSuperAwakeTextBox.Text = "";
			NonRecoveryTimeTextBox.Enabled = false;
			NonRecoveryTimeTextBox.Text = "";
			ComboableFrameComboBox.Enabled = false;
			ComboableFrameComboBox.Text = "";
			CameraShakeTypeComboBox.Enabled = false;
			CameraShakeTypeComboBox.Text = "";
			CameraShakeTypeAwakeComboBox.Enabled = false;
			CameraShakeTypeAwakeComboBox.Text = "";
			CameraShakeTypeSuperAwakeComboBox.Enabled = false;
			CameraShakeTypeSuperAwakeComboBox.Text = "";
			SpecialCamNameTextBox.Enabled = false;
			SpecialCamNameTextBox.Text = "";
			bNoKnockOutCheckBox.Enabled = false;
			bNoKnockOutCheckBox.Checked = false;
			AttrSlashCheckBox.Enabled = false;
			AttrSlashCheckBox.Checked = false;
			AttrBlowCheckBox.Enabled = false;
			AttrBlowCheckBox.Checked = false;
			AttrRemoteSkillCheckBox.Enabled = false;
			AttrRemoteSkillCheckBox.Checked = false;
			AttrSkillCheckBox.Enabled = false;
			AttrSkillCheckBox.Checked = false;
			AttrSplCheckBox.Enabled = false;
			AttrSplCheckBox.Checked = false;
			AttrThrowCheckBox.Enabled = false;
			AttrThrowCheckBox.Checked = false;
			AttrChipDamageCheckBox.Enabled = false;
			AttrChipDamageCheckBox.Checked = false;
			AttrUnblockableCheckBox.Enabled = false;
			AttrUnblockableCheckBox.Checked = false;
			AttrComboCameraCheckBox.Enabled = false;
			AttrComboCameraCheckBox.Checked = false;
			AttrLandingCheckBox.Enabled = false;
			AttrLandingCheckBox.Checked = false;
			AttrNoInvincibleCheckBox.Enabled = false;
			AttrNoInvincibleCheckBox.Checked = false;
			AttrNoRepelCheckBox.Enabled = false;
			AttrNoRepelCheckBox.Checked = false;
			AttrPerformanceTriggerCheckBox.Enabled = false;
			AttrPerformanceTriggerCheckBox.Checked = false;
			AttrNoSupportRescueCheckBox.Enabled = false;
			AttrNoSupportRescueCheckBox.Checked = false;
			AttrNoBurstCheckBox.Enabled = false;
			AttrNoBurstCheckBox.Checked = false;
			AttrSkillEraseCheckBox.Enabled = false;
			AttrSkillEraseCheckBox.Checked = false;
			AttrOnlyGroundCheckBox.Enabled = false;
			AttrOnlyGroundCheckBox.Checked = false;
			AttrNoSuperArmorCheckBox.Enabled = false;
			AttrNoSuperArmorCheckBox.Checked = false;
			AttrDisableNoInvincibleToSupportAssistCheckBox.Enabled = false;
			AttrDisableNoInvincibleToSupportAssistCheckBox.Checked = false;
			AllCheckBox.Enabled = false;
			AllCheckBox.Checked = false;
			AllComboBox.Enabled = false;
		}

		private void OpenButton_Click(object sender, EventArgs e)
		{
			OpenFileDialog OpenDialogStreaming = new OpenFileDialog();
			OpenDialogStreaming.Title = "Open a prm_damage.json";
			OpenDialogStreaming.Filter = "JavaScript Object Notation (*.json)|*.json|Backup File (*.bak)|*.bak|All files (*.*)|*.*";
			if (Properties.Settings.Default.RememberDamagePath != null)
			{
				OpenDialogStreaming.FileName = Properties.Settings.Default.RememberDamagePath;
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

				StreamingPath = OpenDialogStreaming.FileName;
				Properties.Settings.Default.RememberDamagePath = StreamingPath;
				ReadAllLines = File.ReadAllLines(StreamingPath);
				//The original stuff, used for reverting file names and creating backups.
				StreamingPathOrig = StreamingPath;
				ReadAllLinesOrig = File.ReadAllLines(StreamingPath);
				StreamingPathBak = StreamingPath.ToString() + ".bak";

				//Reset Stuff here so new files properly open.
				IsDamageFile = false;

				foreach (var Line in ReadAllLines)
				{
					if (Line.Contains("prm_damage"))
					{
						IsDamageFile = true;
					}
				}

				if (IsDamageFile)
				{
					//File Successfully Opened.

					//Saves as a .temp file to allow me to edit this in real time.
					StreamingPath = StreamingPath.ToString() + ".temp";
					File.WriteAllLines(StreamingPath, ReadAllLines);

					DamageListBox.Items.Clear();
					SaveButton.Enabled = true;
					SaveAsButton.Enabled = true;
					AddButton.Enabled = true;

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

								DamageListBox.Items.Add(NameOfTableEntry);
								DamageListBox.SelectedIndex++;
								ResizeForm();
							}
							FindFinalIndex();

							//Finds final value in the ListBox and checks if you have more than just one entry. If so, then allow MoveDown button.
							if (DamageListBox.SelectedIndex == FinalIndex - 1)
							{
								MoveDownButton.Enabled = false;
								RemoveButton.Enabled = false;
							}
							else
							{
								MoveDownButton.Enabled = true;
								RemoveButton.Enabled = true;
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
								IsDamageFile = false;
							}
						}
					}
					else
					{
						DamageListBox.SelectedIndex = 0;
					}
				}
				else
				{
					MessageBox.Show("This is not a prm_damage.json file.");
					StreamingPath = "";
					DamageListBox.Items.Clear();
					AddButton.Enabled = false;
					SaveButton.Enabled = false;
					SaveAsButton.Enabled = false;

					DisableStuff();
				}
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			UpdateSaveData();

			//Saves the normal file with the current changes.
			StreamingPath = StreamingPathOrig;
			File.WriteAllLines(StreamingPath, ReadAllLines);

			//Reopens it as a temp.
			StreamingPath = StreamingPath.ToString() + ".temp";
			File.WriteAllLines(StreamingPath, ReadAllLines);

			//Creates a backup, then reloads so the next save will be an accurate backup.
			if (BackupsButton.Checked)
			{
				File.WriteAllLines(StreamingPathBak, ReadAllLinesOrig);
				ReadAllLinesOrig = File.ReadAllLines(StreamingPath);
			}
			MessageBox.Show("File Saved Successfully.");
		}

		private void SaveAsButton_Click(object sender, EventArgs e)
		{
			UpdateSaveData();

			Stream myStream;
			SaveFileDialog SaveFileDialog = new SaveFileDialog();

			SaveFileDialog.Filter = "JavaScript Object Notation (*.json)|*.json|Backup File (*.bak)|*.bak|All files (*.*)|*.*";
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
				if (File.Exists(StreamingPath))
				{
					File.Delete(StreamingPath);
				}
				if (File.Exists(StreamingPathBak))
				{
					File.Delete(StreamingPathBak);
				}

				//Changes the StreamingPath to the new pathway.
				StreamingPath = SaveAsPath;
				Properties.Settings.Default.RememberDamagePath = StreamingPath;
				StreamingPathBak = StreamingPath.ToString() + ".bak";
				StreamingPathOrig = StreamingPath;
				File.WriteAllLines(StreamingPath, ReadAllLines);
				StreamingPath = StreamingPath.ToString() + ".temp";
				File.WriteAllLines(StreamingPath, ReadAllLines);

				//Creates a backup, then reloads so the next save will be an accurate backup.
				if (BackupsButton.Checked)
				{
					File.WriteAllLines(StreamingPathBak, ReadAllLinesOrig);
					ReadAllLinesOrig = File.ReadAllLines(StreamingPath);
				}

				MessageBox.Show("File Saved Successfully.");
			}
		}

		private void SaveChangesToMoveButton_Click(object sender, EventArgs e)
		{
			if (DamageListBox.GetItemText(DamageListBox.SelectedItem) != NameOfTableIDTextbox.Text && DamageListBox.Items.Contains(NameOfTableIDTextbox.Text))
			{
				MessageBox.Show("This name already exists!\nYou cannot have two Table IDs with the same name.");
			}
			else
			{
				if (AllCheckBox.Checked)
				{
					ModifyAll = true;
				}
				else
				{
					ModifyAll = false;
				}
				UpdateSaveData();
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
			Properties.Settings.Default.CreateBackupsDamage = !Properties.Settings.Default.CreateBackupsDamage;
		}

		private void BackupsButton_CheckedChanged(object sender, EventArgs e)
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

		private void DamageListBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (SavingFile)
			{
				//Prevents this Function from fucking with the saving process. It would revert values back since this would happen as well.
			}
			else
			{
				YoinkFromFileButton.Enabled = true;
				SaveChangesToMoveButton.Enabled = true;
				RemoveButton.Enabled = true;
				DuplicateButton.Enabled = true;
				NameOfTableIDTextbox.Enabled = true;
				AttackPriorityTextbox.Enabled = true;
				DamageTextBox.Enabled = true;
				DamageIDTextbox.Enabled = true;
				JPNameTextBox.Enabled = true;
				bLockonPlayerOnlyCheckBox.Enabled = true;
				MinDmgTextbox.Enabled = true;
				OverrideRecovLifeDamageRateTextBox.Enabled = true;
				BreathDamageTextBox.Enabled = true;
				GuardDamageTextBox.Enabled = true;
				ChipDamageTextBox.Enabled = true;
				StartupDamageCorrectionTextBox.Enabled = true;
				BeforeDamageCorrectionTextBox.Enabled = true;
				AfterDamageCorrectionTextBox.Enabled = true;
				bOverwriteAfterDamageCorrectionCheckBox.Enabled = true;
				ForwardSpeedTextBox.Enabled = true;
				VerticalSpeedTextBox.Enabled = true;
				HorizontalSpeedTextBox.Enabled = true;
				ForwardSpeedAirTextBox.Enabled = true;
				VerticalSpeedAirTextBox.Enabled = true;
				HorizontalSpeedAirTextBox.Enabled = true;
				ForwardSpeedGuardTextBox.Enabled = true;
				VerticalSpeedGuardTextBox.Enabled = true;
				HorizontalSpeedGuardTextBox.Enabled = true;
				BoundSpeedTextBox.Enabled = true;
				HeightLimitTextBox.Enabled = true;
				BrakeTimeTextBox.Enabled = true;
				HitbackDirectionTypeComboBox.Enabled = true;
				HitbackYawOffsetTextBox.Enabled = true;
				StatusAilmentIdTextBox.Enabled = true;
				StatusAilmentTimeTextBox.Enabled = true;
				StatusAilmentRateTextBox.Enabled = true;
				ChargeMaxFrameTextBox.Enabled = true;
				ChargeGuardVitalityMaxValueTextBox.Enabled = true;
				ChargeLifeDamageMaxValueTextBox.Enabled = true;
				InvinsibleTimeTextBox.Enabled = true;
				GuardRigorTimeTextBox.Enabled = true;
				EDamageReactionTypeComboBox.Enabled = true;
				AdjustFrameTextBox.Enabled = true;
				AdjustFrameAirTextBox.Enabled = true;
				EGuardDamageReactionTypeComboBox.Enabled = true;
				WeaponAttachPointComboBox.Enabled = true;
				HitEffectIDTextBox.Enabled = true;
				HitEffectIDMediumTextBox.Enabled = true;
				HitEffectIDLargeTextBox.Enabled = true;
				HitEffectRandomRadiusTextBox.Enabled = true;
				EffectAngleTypeComboBox.Enabled = true;
				HitEffectDegreeTextBox.Enabled = true;
				BloodEffectIDTextBox.Enabled = true;
				BloodEffectIDMediumTextBox.Enabled = true;
				BloodEffectIDLargeTextBox.Enabled = true;
				BloodEffectAngleTypeComboBox.Enabled = true;
				BloodEffectDegreeTextBox.Enabled = true;
				HitSEIDTextBox.Enabled = true;
				HitStopSelfTextBox.Enabled = true;
				HitStopTargetTextBox.Enabled = true;
				HitStopSelfAwakeTextBox.Enabled = true;
				HitStopTargetAwakeTextBox.Enabled = true;
				HitStopSelfSuperAwakeTextBox.Enabled = true;
				HitStopTargetSuperAwakeTextBox.Enabled = true;
				GuardHitStopSelfTextBox.Enabled = true;
				GuardHitStopTargetTextBox.Enabled = true;
				GuardHitStopSelfAwakeTextBox.Enabled = true;
				GuardHitStopTargetAwakeTextBox.Enabled = true;
				GuardHitStopSelfSuperAwakeTextBox.Enabled = true;
				GuardHitStopTargetSuperAwakeTextBox.Enabled = true;
				NonRecoveryTimeTextBox.Enabled = true;
				ComboableFrameComboBox.Enabled = true;
				CameraShakeTypeComboBox.Enabled = true;
				CameraShakeTypeAwakeComboBox.Enabled = true;
				CameraShakeTypeSuperAwakeComboBox.Enabled = true;
				SpecialCamNameTextBox.Enabled = true;
				bNoKnockOutCheckBox.Enabled = true;
				AttrSlashCheckBox.Enabled = true;
				AttrBlowCheckBox.Enabled = true;
				AttrRemoteSkillCheckBox.Enabled = true;
				AttrSkillCheckBox.Enabled = true;
				AttrSplCheckBox.Enabled = true;
				AttrThrowCheckBox.Enabled = true;
				AttrChipDamageCheckBox.Enabled = true;
				AttrUnblockableCheckBox.Enabled = true;
				AttrComboCameraCheckBox.Enabled = true;
				AttrLandingCheckBox.Enabled = true;
				AttrNoInvincibleCheckBox.Enabled = true;
				AttrNoRepelCheckBox.Enabled = true;
				AttrPerformanceTriggerCheckBox.Enabled = true;
				AttrNoSupportRescueCheckBox.Enabled = true;
				AttrNoBurstCheckBox.Enabled = true;
				AttrSkillEraseCheckBox.Enabled = true;
				AttrOnlyGroundCheckBox.Enabled = true;
				AttrNoSuperArmorCheckBox.Enabled = true;
				AttrDisableNoInvincibleToSupportAssistCheckBox.Enabled = true;
				AllCheckBox.Enabled = true;

				StructGUIDFound = 0;

				NameOfTableIDTextbox.Text = DamageListBox.GetItemText(DamageListBox.SelectedItem);

				//Gets the numbered index of the ListBox ID. That way if you rename it, it will still read correctly.
				try
				{
					ListBoxIndex = DamageListBox.Items.IndexOf(DamageListBox.SelectedItem) + 1;
				}
				catch (System.ArgumentNullException)
				{
					ListBoxIndex = -1;
				}

				FindFinalIndex();

				if (FinalIndex <= 1)
				{
					RemoveButton.Enabled = false;
				}
				else
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
							GetName(JPNameTextBox, 9);
							GetInt(AttackPriorityTextbox, 15);
							GetName(DamageIDTextbox, 21);
							GetBool(bLockonPlayerOnlyCheckBox, 27);
							GetFloat(DamageTextBox, 31);
							GetFloat(MinDmgTextbox, 37);
							GetFloat(OverrideRecovLifeDamageRateTextBox, 43);
							GetFloat(BreathDamageTextBox, 49);
							GetFloat(GuardDamageTextBox, 55);
							GetFloat(ChipDamageTextBox, 61);
							GetFloat(StartupDamageCorrectionTextBox, 67);
							GetFloat(BeforeDamageCorrectionTextBox, 73);
							GetFloat(AfterDamageCorrectionTextBox, 79);
							GetBool(bOverwriteAfterDamageCorrectionCheckBox, 87);
							GetFloat(ForwardSpeedTextBox, 91);
							GetFloat(VerticalSpeedTextBox, 97);
							GetFloat(HorizontalSpeedTextBox, 103);
							GetFloat(ForwardSpeedAirTextBox, 109);
							GetFloat(VerticalSpeedAirTextBox, 115);
							GetFloat(HorizontalSpeedAirTextBox, 121);
							GetFloat(ForwardSpeedGuardTextBox, 127);
							GetFloat(VerticalSpeedGuardTextBox, 133);
							GetFloat(HorizontalSpeedGuardTextBox, 139);
							GetFloat(BoundSpeedTextBox, 145);
							GetFloat(HeightLimitTextBox, 151);
							GetFloat(BrakeTimeTextBox, 157);
							GetEnum("EHitBackType::", HitbackDirectionTypeComboBox, 166, 17);
							GetFloat(HitbackYawOffsetTextBox, 170);
							GetName(StatusAilmentIdTextBox, 178);
							GetFloat(StatusAilmentTimeTextBox, 182);
							GetFloat(StatusAilmentRateTextBox, 188);
							GetInt(ChargeMaxFrameTextBox, 196);
							GetInt(ChargeGuardVitalityMaxValueTextBox, 202);
							GetInt(ChargeLifeDamageMaxValueTextBox, 208);
							GetFloat(InvinsibleTimeTextBox, 212);
							GetFloat(GuardRigorTimeTextBox, 218);
							GetEnum("EDamageReactionType::", EDamageReactionTypeComboBox, 227, 24);
							GetInt(AdjustFrameTextBox, 233);
							GetInt(AdjustFrameAirTextBox, 239);
							GetEnum("EGuardDamageReactionType::", EGuardDamageReactionTypeComboBox, 246, 29);
							GetEnum("ECharacterWeaponAttachPoint::", WeaponAttachPointComboBox, 253, 32);
							GetName(HitEffectIDTextBox, 259);
							GetName(HitEffectIDMediumTextBox, 265);
							GetName(HitEffectIDLargeTextBox, 271);
							GetInt(HitEffectRandomRadiusTextBox, 277);
							GetEnum("EEffectAngleType::", EffectAngleTypeComboBox, 284, 21);
							GetFloat(HitEffectDegreeTextBox, 288);
							GetName(BloodEffectIDTextBox, 296);
							GetName(BloodEffectIDMediumTextBox, 302);
							GetName(BloodEffectIDLargeTextBox, 308);
							GetEnum("EEffectAngleType::", BloodEffectAngleTypeComboBox, 315, 21);
							GetFloat(BloodEffectDegreeTextBox, 319);
							GetName(HitSEIDTextBox, 327);
							GetFloat(HitStopSelfTextBox, 331);
							GetFloat(HitStopTargetTextBox, 337);
							GetFloat(HitStopSelfAwakeTextBox, 343);
							GetFloat(HitStopTargetAwakeTextBox, 349);
							GetFloat(HitStopSelfSuperAwakeTextBox, 355);
							GetFloat(HitStopTargetSuperAwakeTextBox, 361);
							GetFloat(GuardHitStopSelfTextBox, 367);
							GetFloat(GuardHitStopTargetTextBox, 373);
							GetFloat(GuardHitStopSelfAwakeTextBox, 379);
							GetFloat(GuardHitStopTargetAwakeTextBox, 385);
							GetFloat(GuardHitStopSelfSuperAwakeTextBox, 391);
							GetFloat(GuardHitStopTargetSuperAwakeTextBox, 397);
							GetInt(NonRecoveryTimeTextBox, 405);
							GetIntComboBox(ComboableFrameComboBox, 411);
							GetIntComboBox(CameraShakeTypeComboBox, 417);
							GetIntComboBox(CameraShakeTypeAwakeComboBox, 423);
							GetIntComboBox(CameraShakeTypeSuperAwakeComboBox, 429);
							GetBool(bNoKnockOutCheckBox, 435);
							GetName(SpecialCamNameTextBox, 441);
							GetBool(AttrSlashCheckBox, 447);
							GetBool(AttrBlowCheckBox, 453);
							GetBool(AttrRemoteSkillCheckBox, 459);
							GetBool(AttrSkillCheckBox, 465);
							GetBool(AttrSplCheckBox, 471);
							GetBool(AttrThrowCheckBox, 477);
							GetBool(AttrUnblockableCheckBox, 483);
							GetBool(AttrChipDamageCheckBox, 489);
							GetBool(AttrComboCameraCheckBox, 495);
							GetBool(AttrLandingCheckBox, 501);
							GetBool(AttrNoInvincibleCheckBox, 507);
							GetBool(AttrNoRepelCheckBox, 513);
							GetBool(AttrPerformanceTriggerCheckBox, 519);
							GetBool(AttrNoSupportRescueCheckBox, 525);
							GetBool(AttrNoBurstCheckBox, 531);
							GetBool(AttrSkillEraseCheckBox, 537);
							GetBool(AttrOnlyGroundCheckBox, 543);
							GetBool(AttrNoSuperArmorCheckBox, 549);
							GetBool(AttrDisableNoInvincibleToSupportAssistCheckBox, 555);
						}
					}
				}
			}
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
				bool FinishedModifyAll = false;

				//Prevents breaking if you somehow unselect the ListBox.
				if (DamageListBox.SelectedIndex == -1)
				{
					DamageListBox.SelectedIndex = 0;
				}

				//Sets the current Textbox name to the ListBox name.
				//Causes the DamageListBox_SelectedIndexChanged to happen.
				DamageListBox.Items[DamageListBox.SelectedIndex] = NameOfTableIDTextbox.Text;

				StructGUIDFound = 0;
				ListBoxIndex = DamageListBox.Items.IndexOf(DamageListBox.SelectedItem) + 1;

			FinishedModifyAllLabel:

				if (ModifyAll && FinishedModifyAll == false)
				{
					for (int i = 0; i < ReadAllLines.Length; i++)
					{
						var Line = ReadAllLines[ioffset];
						ioffset = i;

						if (Line.Contains("StructGUID"))
						{
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == UnknownNameLabel.Text)
							{
								SetName(JPNameTextBox, 9);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AttackPriorityLabel.Text)
							{
								SetInt(AttackPriorityTextbox, 15);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == DamageIDLabel.Text)
							{
								SetName(DamageIDTextbox, 21);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == bLockonPlayerOnlyCheckBox.Text)
							{
								SetBool(bLockonPlayerOnlyCheckBox, 27);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == DamageLabel.Text)
							{
								SetFloat(DamageTextBox, 31);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == MinDamageLabel.Text)
							{
								SetFloat(MinDmgTextbox, 37);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == OverrideRecovLifeDamageRateLabel.Text)
							{
								SetFloat(OverrideRecovLifeDamageRateTextBox, 43);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == BreathDamageLabel.Text)
							{
								SetFloat(BreathDamageTextBox, 49);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == GuardDamageLabel.Text)
							{
								SetFloat(GuardDamageTextBox, 55);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == ChipDamageLabel.Text)
							{
								SetFloat(ChipDamageTextBox, 61);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == StartupDamageCorrectionLabel.Text)
							{
								SetFloat(StartupDamageCorrectionTextBox, 67);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == BeforeDamageCorrectionLabel.Text)
							{
								SetFloat(BeforeDamageCorrectionTextBox, 73);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AfterDamageCorrectionLabel.Text)
							{
								SetFloat(AfterDamageCorrectionTextBox, 79);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == bOverwriteAfterDamageCorrectionCheckBox.Text)
							{
								SetBool(bOverwriteAfterDamageCorrectionCheckBox, 87);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == ForwardSpeedLabel.Text)
							{
								SetFloat(ForwardSpeedTextBox, 91);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == VerticalSpeedLabel.Text)
							{
								SetFloat(VerticalSpeedTextBox, 97);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == HorizontalSpeedLabel.Text)
							{
								SetFloat(HorizontalSpeedTextBox, 103);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == ForwardSpeedAirLabel.Text)
							{
								SetFloat(ForwardSpeedAirTextBox, 109);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == VerticalSpeedAirLabel.Text)
							{
								SetFloat(VerticalSpeedAirTextBox, 115);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == HorizontalSpeedAirLabel.Text)
							{
								SetFloat(HorizontalSpeedAirTextBox, 121);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == ForwardGuardSpeedLabel.Text)
							{
								SetFloat(ForwardSpeedGuardTextBox, 127);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == VerticalGuardSpeedLabel.Text)
							{
								SetFloat(VerticalSpeedGuardTextBox, 133);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == HorizontalGuardSpeedLabel.Text)
							{
								SetFloat(HorizontalSpeedGuardTextBox, 139);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == BoundSpeedLabel.Text)
							{
								SetFloat(BoundSpeedTextBox, 145);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == HeightLimitLabel.Text)
							{
								SetFloat(HeightLimitTextBox, 151);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == BrakeTimeLabel.Text)
							{
								SetFloat(BrakeTimeTextBox, 157);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == HitbackDirectionTypeComboBox.Text)
							{
								SetEnum("EHitBackType::", HitbackDirectionTypeComboBox, 166);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == HitbackYawOffsetLabel.Text)
							{
								SetFloat(HitbackYawOffsetTextBox, 170);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AllStatusAilmentIdLabel)
							{
								SetName(StatusAilmentIdTextBox, 178);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == StatusAilmentTimeLabel.Text)
							{
								SetFloat(StatusAilmentTimeTextBox, 182);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == StatusAilmentRateLabel.Text)
							{
								SetFloat(StatusAilmentRateTextBox, 188);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == ChargeMaxFrameLabel.Text)
							{
								SetInt(ChargeMaxFrameTextBox, 196);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == ChargeGuardVitalityMaxValueLabel.Text)
							{
								SetInt(ChargeGuardVitalityMaxValueTextBox, 202);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == ChargeLifeDamageMaxValueLabel.Text)
							{
								SetInt(ChargeLifeDamageMaxValueTextBox, 208);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == InvinsibleTimeLabel.Text)
							{
								SetFloat(InvinsibleTimeTextBox, 212);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == GuardRigorTimeLabel.Text)
							{
								SetFloat(GuardRigorTimeTextBox, 218);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AllEDamageReactionTypeLabel)
							{
								SetEnum("EDamageReactionType::", EDamageReactionTypeComboBox, 227);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AllAdjustFrameLabel)
							{
								SetInt(AdjustFrameTextBox, 233);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AdjustFrameAirLabel.Text)
							{
								SetInt(AdjustFrameAirTextBox, 239);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == EGuardDamageReactionTypeComboBox.Text)
							{
								SetEnum("EGuardDamageReactionType::", EGuardDamageReactionTypeComboBox, 246);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == WeaponAttachPointComboBox.Text)
							{
								SetEnum("ECharacterWeaponAttachPoint::", WeaponAttachPointComboBox, 253);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == HitEffectIDLabel.Text)
							{
								SetName(HitEffectIDTextBox, 259);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == HitEffectIDMediumLabel.Text)
							{
								SetName(HitEffectIDMediumTextBox, 265);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == HitEffectIDLargeLabel.Text)
							{
								SetName(HitEffectIDLargeTextBox, 271);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == HitEffectRandomRadiusLabel.Text)
							{
								SetInt(HitEffectRandomRadiusTextBox, 277);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == EffectAngleTypeComboBox.Text)
							{
								SetEnum("EEffectAngleType::", EffectAngleTypeComboBox, 284);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == HitEffectDegreeLabel.Text)
							{
								SetFloat(HitEffectDegreeTextBox, 288);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == BloodEffectIDLabel.Text)
							{
								SetName(BloodEffectIDTextBox, 296);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == BloodEffectIDMediumLabel.Text)
							{
								SetName(BloodEffectIDMediumTextBox, 302);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == BloodEffectIDLargeLabel.Text)
							{
								SetName(BloodEffectIDLargeTextBox, 308);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == BloodEffectAngleTypeComboBox.Text)
							{
								SetEnum("EEffectAngleType::", BloodEffectAngleTypeComboBox, 315);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == BloodEffectDegreeLabel.Text)
							{
								SetFloat(BloodEffectDegreeTextBox, 319);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == HitSEIDLabel.Text)
							{
								SetName(HitSEIDTextBox, 327);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == HitStopSelfLabel.Text)
							{
								SetFloat(HitStopSelfTextBox, 331);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == HitStopTargetLabel.Text)
							{
								SetFloat(HitStopTargetTextBox, 337);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == HitStopSelfAwakeLabel.Text)
							{
								SetFloat(HitStopSelfAwakeTextBox, 343);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == HitStopTargetAwakeLabel.Text)
							{
								SetFloat(HitStopTargetAwakeTextBox, 349);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == HitStopSelfSuperAwakeLabel.Text)
							{
								SetFloat(HitStopSelfSuperAwakeTextBox, 355);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == HitStopTargetSuperAwakeLabel.Text)
							{
								SetFloat(HitStopTargetSuperAwakeTextBox, 361);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == GuardHitStopSelfLabel.Text)
							{
								SetFloat(GuardHitStopSelfTextBox, 367);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == GuardHitStopTargetLabel.Text)
							{
								SetFloat(GuardHitStopTargetTextBox, 373);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == GuardHitStopSelfAwakeLabel.Text)
							{
								SetFloat(GuardHitStopSelfAwakeTextBox, 379);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == GuardHitStopTargetAwakeLabel.Text)
							{
								SetFloat(GuardHitStopTargetAwakeTextBox, 385);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == GuardHitStopSelfSuperAwakeLabel.Text)
							{
								SetFloat(GuardHitStopSelfSuperAwakeTextBox, 391);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == GuardHitStopTargetSuperAwakeLabel.Text)
							{
								SetFloat(GuardHitStopTargetSuperAwakeTextBox, 397);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == NonRecoveryTimeLabel.Text)
							{
								SetInt(NonRecoveryTimeTextBox, 405);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == ComboableFrameLabel.Text)
							{
								SetIntComboBox(ComboableFrameComboBox, 411);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == CameraShakeTypeLabel.Text)
							{
								SetIntComboBox(CameraShakeTypeComboBox, 417);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == CameraShakeTypeAwakeLabel.Text)
							{
								SetIntComboBox(CameraShakeTypeAwakeComboBox, 423);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == CameraShakeTypeSuperAwakeLabel.Text)
							{
								SetIntComboBox(CameraShakeTypeSuperAwakeComboBox, 429);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == bNoKnockOutCheckBox.Text)
							{
								SetBool(bNoKnockOutCheckBox, 435);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == SpecialCamNameLabel.Text)
							{
								SetName(SpecialCamNameTextBox, 441);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AttrSlashCheckBox.Text)
							{
								SetBool(AttrSlashCheckBox, 447);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AttrBlowCheckBox.Text)
							{
								SetBool(AttrBlowCheckBox, 453);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AttrRemoteSkillCheckBox.Text)
							{
								SetBool(AttrRemoteSkillCheckBox, 459);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AttrSkillCheckBox.Text)
							{
								SetBool(AttrSkillCheckBox, 465);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AttrSplCheckBox.Text)
							{
								SetBool(AttrSplCheckBox, 471);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AttrThrowCheckBox.Text)
							{
								SetBool(AttrThrowCheckBox, 477);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AttrUnblockableCheckBox.Text)
							{
								SetBool(AttrUnblockableCheckBox, 483);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AttrChipDamageCheckBox.Text)
							{
								SetBool(AttrChipDamageCheckBox, 489);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AttrComboCameraCheckBox.Text)
							{
								SetBool(AttrComboCameraCheckBox, 495);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AttrLandingCheckBox.Text)
							{
								SetBool(AttrLandingCheckBox, 501);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AttrNoInvincibleCheckBox.Text)
							{
								SetBool(AttrNoInvincibleCheckBox, 507);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AttrNoRepelCheckBox.Text)
							{
								SetBool(AttrNoRepelCheckBox, 513);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AttrPerformanceTriggerCheckBox.Text)
							{
								SetBool(AttrPerformanceTriggerCheckBox, 519);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AttrNoSupportRescueCheckBox.Text)
							{
								SetBool(AttrNoSupportRescueCheckBox, 525);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AttrNoBurstCheckBox.Text)
							{
								SetBool(AttrNoBurstCheckBox, 531);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AttrSkillEraseCheckBox.Text)
							{
								SetBool(AttrSkillEraseCheckBox, 537);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AttrOnlyGroundCheckBox.Text)
							{
								SetBool(AttrOnlyGroundCheckBox, 543);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AttrNoSuperArmorCheckBox.Text)
							{
								SetBool(AttrNoSuperArmorCheckBox, 549);
							}
							if (AllComboBox.GetItemText(AllComboBox.SelectedItem) == AttrDisableNoInvincibleToSupportAssistCheckBox.Text)
							{
								SetBool(AttrDisableNoInvincibleToSupportAssistCheckBox, 555);
							}
						}
					}
					FinishedModifyAll = true;
				}
				else
				{
					for (int i = 0; i < ReadAllLines.Length; i++)
					{
						var Line = ReadAllLines[ioffset];
						ioffset = i;

						if (Line.Contains("StructGUID"))
						{
							StructGUIDFound++;
							if (StructGUIDFound == ListBoxIndex)
							{
								//Sets the TableID Value
								int LineNum = ioffset + 2 - 2;
								string Str = "            \"Name\": \"" + NameOfTableIDTextbox.Text + "\",";
								ReadAllLines[LineNum] = Str;

								//String Enum, String TextBox/CheckBox/ComboBox, Int Offset, Bool ModifyAll = Edit everything in File.
								SetName(JPNameTextBox, 9);
								SetInt(AttackPriorityTextbox, 15);
								SetName(DamageIDTextbox, 21);
								SetBool(bLockonPlayerOnlyCheckBox, 27);
								SetFloat(DamageTextBox, 31);
								SetFloat(MinDmgTextbox, 37);
								SetFloat(OverrideRecovLifeDamageRateTextBox, 43);
								SetFloat(BreathDamageTextBox, 49);
								SetFloat(GuardDamageTextBox, 55);
								SetFloat(ChipDamageTextBox, 61);
								SetFloat(StartupDamageCorrectionTextBox, 67);
								SetFloat(BeforeDamageCorrectionTextBox, 73);
								SetFloat(AfterDamageCorrectionTextBox, 79);
								SetBool(bOverwriteAfterDamageCorrectionCheckBox, 87);
								SetFloat(ForwardSpeedTextBox, 91);
								SetFloat(VerticalSpeedTextBox, 97);
								SetFloat(HorizontalSpeedTextBox, 103);
								SetFloat(ForwardSpeedAirTextBox, 109);
								SetFloat(VerticalSpeedAirTextBox, 115);
								SetFloat(HorizontalSpeedAirTextBox, 121);
								SetFloat(ForwardSpeedGuardTextBox, 127);
								SetFloat(VerticalSpeedGuardTextBox, 133);
								SetFloat(HorizontalSpeedGuardTextBox, 139);
								SetFloat(BoundSpeedTextBox, 145);
								SetFloat(HeightLimitTextBox, 151);
								SetFloat(BrakeTimeTextBox, 157);
								SetEnum("EHitBackType::", HitbackDirectionTypeComboBox, 166);
								SetFloat(HitbackYawOffsetTextBox, 170);
								SetName(StatusAilmentIdTextBox, 178);
								SetFloat(StatusAilmentTimeTextBox, 182);
								SetFloat(StatusAilmentRateTextBox, 188);
								SetInt(ChargeMaxFrameTextBox, 196);
								SetInt(ChargeGuardVitalityMaxValueTextBox, 202);
								SetInt(ChargeLifeDamageMaxValueTextBox, 208);
								SetFloat(InvinsibleTimeTextBox, 212);
								SetFloat(GuardRigorTimeTextBox, 218);
								SetEnum("EDamageReactionType::", EDamageReactionTypeComboBox, 227);
								SetInt(AdjustFrameTextBox, 233);
								SetInt(AdjustFrameAirTextBox, 239);
								SetEnum("EGuardDamageReactionType::", EGuardDamageReactionTypeComboBox, 246);
								SetEnum("ECharacterWeaponAttachPoint::", WeaponAttachPointComboBox, 253);
								SetName(HitEffectIDTextBox, 259);
								SetName(HitEffectIDMediumTextBox, 265);
								SetName(HitEffectIDLargeTextBox, 271);
								SetInt(HitEffectRandomRadiusTextBox, 277);
								SetEnum("EEffectAngleType::", EffectAngleTypeComboBox, 284);
								SetFloat(HitEffectDegreeTextBox, 288);
								SetName(BloodEffectIDTextBox, 296);
								SetName(BloodEffectIDMediumTextBox, 302);
								SetName(BloodEffectIDLargeTextBox, 308);
								SetEnum("EEffectAngleType::", BloodEffectAngleTypeComboBox, 315);
								SetFloat(BloodEffectDegreeTextBox, 319);
								SetName(HitSEIDTextBox, 327);
								SetFloat(HitStopSelfTextBox, 331);
								SetFloat(HitStopTargetTextBox, 337);
								SetFloat(HitStopSelfAwakeTextBox, 343);
								SetFloat(HitStopTargetAwakeTextBox, 349);
								SetFloat(HitStopSelfSuperAwakeTextBox, 355);
								SetFloat(HitStopTargetSuperAwakeTextBox, 361);
								SetFloat(GuardHitStopSelfTextBox, 367);
								SetFloat(GuardHitStopTargetTextBox, 373);
								SetFloat(GuardHitStopSelfAwakeTextBox, 379);
								SetFloat(GuardHitStopTargetAwakeTextBox, 385);
								SetFloat(GuardHitStopSelfSuperAwakeTextBox, 391);
								SetFloat(GuardHitStopTargetSuperAwakeTextBox, 397);
								SetInt(NonRecoveryTimeTextBox, 405);
								SetIntComboBox(ComboableFrameComboBox, 411);
								SetIntComboBox(CameraShakeTypeComboBox, 417);
								SetIntComboBox(CameraShakeTypeAwakeComboBox, 423);
								SetIntComboBox(CameraShakeTypeSuperAwakeComboBox, 429);
								SetBool(bNoKnockOutCheckBox, 435);
								SetName(SpecialCamNameTextBox, 441);
								SetBool(AttrSlashCheckBox, 447);
								SetBool(AttrBlowCheckBox, 453);
								SetBool(AttrRemoteSkillCheckBox, 459);
								SetBool(AttrSkillCheckBox, 465);
								SetBool(AttrSplCheckBox, 471);
								SetBool(AttrThrowCheckBox, 477);
								SetBool(AttrUnblockableCheckBox, 483);
								SetBool(AttrChipDamageCheckBox, 489);
								SetBool(AttrComboCameraCheckBox, 495);
								SetBool(AttrLandingCheckBox, 501);
								SetBool(AttrNoInvincibleCheckBox, 507);
								SetBool(AttrNoRepelCheckBox, 513);
								SetBool(AttrPerformanceTriggerCheckBox, 519);
								SetBool(AttrNoSupportRescueCheckBox, 525);
								SetBool(AttrNoBurstCheckBox, 531);
								SetBool(AttrSkillEraseCheckBox, 537);
								SetBool(AttrOnlyGroundCheckBox, 543);
								SetBool(AttrNoSuperArmorCheckBox, 549);
								SetBool(AttrDisableNoInvincibleToSupportAssistCheckBox, 555);
							}
						}
					}
					FinishedModifyAll = false;
				}

				if (FinishedModifyAll)
				{
					goto FinishedModifyAllLabel;
				}
			}

			File.WriteAllLines(StreamingPath, ReadAllLines);

			var CurrentItemWidth = (int)this.CreateGraphics().MeasureString(DamageListBox.Items[DamageListBox.SelectedIndex].ToString(), DamageListBox.Font, TextRenderer.MeasureText(DamageListBox.Items[DamageListBox.SelectedIndex].ToString(), new Font("Arial", 12.0F))).Width;
			if (CurrentItemWidth > DamageListBox.Width)
			{
				ReloadListBox();
			}

			SavingFile = false;
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

		private void GetBool(CheckBox checkboxcheck, int offset)
		{
			int LineNum = ioffset + offset - 2;
			var GetBoolValue = ReadAllLines[LineNum];
			int GetBoolIndex = GetBoolValue.IndexOf(": ");
			char[] charsToTrim = { '"', ',' };
			string TrimmedCharString = GetBoolValue.Trim(charsToTrim);
			string GetBoolValueSub = (TrimmedCharString.Substring(GetBoolIndex + 2));
			if (GetBoolValueSub == "true")
			{
				checkboxcheck.Checked = true;
			}
			else
			{
				checkboxcheck.Checked = false;
			}
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
			int LineNum = ioffset + offset - 2;
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

			decimal GetIntComboBoxValueSubDec = 0;
			Decimal.TryParse(GetIntComboBoxValueSub, NumberStyles.Any, new CultureInfo("en-US"), out GetIntComboBoxValueSubDec);

			if (CheckLine.Contains("ComboableFrame"))
			{
				if (GetIntComboBoxValueSubDec == 0)
				{
					text.Text = "Infinite";
				}
				if (GetIntComboBoxValueSubDec == 1)
				{
					text.Text = "Short";
				}
				if (GetIntComboBoxValueSubDec == 2)
				{
					text.Text = "Medium";
				}
				if (GetIntComboBoxValueSubDec == 3)
				{
					text.Text = "Long";
				}
				if (GetIntComboBoxValueSubDec > 3 || GetIntComboBoxValueSubDec < 0)
				{
					text.Text = "Unknown?";
				}
			}
			if (CheckLine.Contains("CameraShakeType") || CheckLine.Contains("CameraShakeType_Awake") || CheckLine.Contains("CameraShakeType_SuperAwake"))
			{
				if (GetIntComboBoxValueSubDec == 0)
				{
					text.Text = "None";
				}
				if (GetIntComboBoxValueSubDec == 1)
				{
					text.Text = "Small";
				}
				if (GetIntComboBoxValueSubDec == 2)
				{
					text.Text = "Medium";
				}
				if (GetIntComboBoxValueSubDec == 3)
				{
					text.Text = "Large";
				}
				if (GetIntComboBoxValueSubDec > 3 || GetIntComboBoxValueSubDec < 0)
				{
					text.Text = "Unknown?";
				}
			}
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

		private void SetName(TextBox text, int offset)
		{
			//Adjusts the LineNum so the offset is correct.
			int LineNum = ioffset + offset - 2;
			string Str = ValueStr + "\"" + text.Text + "\"";
			ReadAllLines[LineNum] = Str;
		}

		private void SetBool(CheckBox checkboxcheck, int offset)
		{
			int LineNum = ioffset + offset - 2;
			string Str = ValueStr + "false";
			if (checkboxcheck.Checked)
			{
				Str = ValueStr + "true";
			}
			ReadAllLines[LineNum] = Str;
		}

		private void SetInt(TextBox text, int offset)
		{
			int LineNum = ioffset + offset - 2;
			Decimal.TryParse(text.Text, NumberStyles.Any, new CultureInfo("en-US"), out Amount);
			string Str = ValueStr + Amount;
			ReadAllLines[LineNum] = Str;
		}

		private void SetIntComboBox(ComboBox text, int offset)
		{
			int LineNum = ioffset + offset - 2;
			var CheckLine = ReadAllLines[ioffset + offset - 4];
			if (CheckLine.Contains("ComboableFrame"))
			{
				if (text.Text != "Unknown")
				{
					if (text.Text == "Infinite")
					{
						Amount = 0;
					}
					if (text.Text == "Short")
					{
						Amount = 1;
					}
					if (text.Text == "Medium")
					{
						Amount = 2;
					}
					if (text.Text == "Long")
					{
						Amount = 3;
					}
					string Str = ValueStr + Amount;
					ReadAllLines[LineNum] = Str;
				}
				else
				{
					MessageBox.Show("Unknown Value, \"" + ComboableFrameLabel.Text + "\" will not be changed.");
				}
			}

			if (CheckLine.Contains("CameraShakeType") || CheckLine.Contains("CameraShakeType_Awake") || CheckLine.Contains("CameraShakeType_SuperAwake"))
			{
				if (text.Text != "Unknown")
				{
					if (text.Text == "None")
					{
						Amount = 0;
					}
					if (text.Text == "Small")
					{
						Amount = 1;
					}
					if (text.Text == "Medium")
					{
						Amount = 2;
					}
					if (text.Text == "Large")
					{
						Amount = 3;
					}
					string Str = ValueStr + Amount;
					ReadAllLines[LineNum] = Str;
				}
				else
				{
					if (CheckLine.Contains("CameraShakeType"))
					{
						if (text.Text == "Unknown")
						{
							MessageBox.Show("Unknown Value, \"" + CameraShakeTypeLabel.Text + "\" will not be changed.");
						}
					}
					if (CheckLine.Contains("CameraShakeType_Awake"))
					{
						if (text.Text == "Unknown")
						{
							MessageBox.Show("Unknown Value, \"" + CameraShakeTypeAwakeLabel.Text + "\" will not be changed.");
						}
					}
					if (CheckLine.Contains("CameraShakeType_SuperAwake"))
					{
						if (text.Text == "Unknown")
						{
							MessageBox.Show("Unknown Value, \"" + CameraShakeTypeSuperAwakeLabel.Text + "\" will not be changed.");
						}
					}
				}
			}
		}

		private void SetFloat(TextBox text, int offset)
		{
			int LineNum = ioffset + offset - 2;
			Decimal.TryParse(text.Text, NumberStyles.Any, new CultureInfo("en-US"), out Amount);
			string Str = ValueStr + Amount + ",";
			//MessageBox.Show("TextBox Text: " + text.Text + "\nDecimal Amount: " + Amount.ToString() + "\n\n\n" + "String Damage Value for Table ID: " + StructGUIDFound + "\n" + Str.ToString());
			ReadAllLines[LineNum] = Str;
		}

		private void SetEnum(string Enum, ComboBox text, int offset)
		{
			int LineNum = ioffset + offset - 2;
			string Str = ValueStr + "\"" + Enum + text.Text + "\"";
			ReadAllLines[LineNum] = Str;
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
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
						//Sets the ID as 1 and adds a item to the DamageListBox with the same name.
						lines.Insert(i + 6, NewSectionPart1Str.Remove(0, 14) + "1" + NewSectionPart2Str);
						File.WriteAllLines(StreamingPath, lines);
						ReadAllLines = File.ReadAllLines(StreamingPath);

						DamageListBox.Items.Add("1");
						//Makes it so everything functions from here on out as if it's a normal file.
						FoundExport = false;
						break;
					}
				}
			}
			else
			{
				CreateNewName();

				//Creates new section to the ListBox.
				DamageListBox.Items.Add(NewTblValueStr);

				//Adds new section to file.
				int NewLineNum = 0;

				//Search through whole File
				for (int i = 0; i < ReadAllLines.Length; i++)
				{
					var Line = ReadAllLines[i];
					if (Line.Contains("StructGUID"))
					{
						NewLineNum = i;
					}
				}

				NewLineNum = NewLineNum + 558;

				string[] arrLine = File.ReadAllLines(StreamingPath);
				arrLine[NewLineNum - 1] = NewSectionPart1Str + NewTblValueStr + NewSectionPart2Str;
				File.WriteAllLines(StreamingPath, arrLine);

				//Reload the file after saving.
				ReadAllLines = File.ReadAllLines(StreamingPath);

				//Sends selection to the newly added entry.
				DamageListBox.SelectedIndex = NewVal - 1;
			}
		}

		private void RemoveButton_Click(object sender, EventArgs e)
		{
			StructGUIDFound = 0;
			SavingFile = true;

			//Gets the current Selected Index and exports it as a Int.
			ListBoxIndex = DamageListBox.Items.IndexOf(DamageListBox.SelectedItem) + 1;

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
							list.RemoveRange(i - 4, 562);
						}
						else
						{
							list.RemoveRange(i - 5, 562);
						}

						File.WriteAllLines(StreamingPath, list);

						//Reload the file after saving.
						ReadAllLines = File.ReadAllLines(StreamingPath);

						//Makes it do the thing once, then stop the loop.
						break;
					}
				}
			}
			DamageListBox.Items.Remove(DamageListBox.Items[DamageListBox.SelectedIndex]);

			//Sends selection to the previous entry.
			if (ListBoxIndex > 1)
			{
				DamageListBox.SelectedIndex = ListBoxIndex - 2;
			}
			else
			{
				DamageListBox.SelectedIndex = ListBoxIndex - 1;
			}

			UpdateSaveData();

			SavingFile = false;
		}

		private void MoveUpButton_Click(object sender, EventArgs e)
		{
			StructGUIDFound = 0;
			SavingFile = true;

			//Gets the current Selected Index and exports it as a Int.
			ListBoxIndex = DamageListBox.Items.IndexOf(DamageListBox.SelectedItem) + 1;

			FindFinalIndex();

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
						string[] Section = lines.GetRange(i - 4, 562).ToArray();

						lines.RemoveRange(i - 4, 562);
						lines.InsertRange(i - 566, Section);

						if (ListBoxIndex == (FinalIndex))
						{
							lines.RemoveAt(i - 5);
							lines.Insert(i - 5, "          },");
							lines.RemoveAt(i + 557);
							lines.Insert(i + 557, "          }");
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
			DamageListBox.SelectedIndex = ListBoxIndex - 2;
			ListBoxIndex = DamageListBox.Items.IndexOf(DamageListBox.SelectedItem) + 1;

			if (ListBoxIndex > 1)
			{
				MoveUpButton.Enabled = true;
			}
			else
			{
				MoveUpButton.Enabled = false;
			}
			MoveDownButton.Enabled = true;

			UpdateSaveData();

			SavingFile = false;
		}

		private void MoveDownButton_Click(object sender, EventArgs e)
		{
			StructGUIDFound = 0;

			SavingFile = true;

			//Gets the current Selected Index and exports it as a Int.
			ListBoxIndex = DamageListBox.Items.IndexOf(DamageListBox.SelectedItem) + 1;

			FindFinalIndex();

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

						string[] Section = lines.GetRange(i - 4, 562).ToArray();

						lines.RemoveRange(i - 4, 562);
						lines.InsertRange(i + 558, Section);

						if (ListBoxIndex == (FinalIndex - 1))
						{
							lines.RemoveAt(i + 557);
							lines.Insert(i + 557, "          },");
							lines.RemoveAt(i + 1119);
							lines.Insert(i + 1119, "          }");
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
			DamageListBox.SelectedIndex = ListBoxIndex;
			ListBoxIndex = DamageListBox.Items.IndexOf(DamageListBox.SelectedItem) + 1;

			if (ListBoxIndex == FinalIndex)
			{
				MoveDownButton.Enabled = false;
			}
			else
			{
				MoveDownButton.Enabled = true;
			}
			MoveUpButton.Enabled = true;

			UpdateSaveData();

			SavingFile = false;
		}

		private void DuplicateButton_Click(object sender, EventArgs e)
		{
			StructGUIDFound = 0;

			SavingFile = true;

			CreateNewName();

			//Gets the current Selected Index and exports it as a Int.
			ListBoxIndex = DamageListBox.Items.IndexOf(DamageListBox.SelectedItem) + 1;

			FindFinalIndex();

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

						string[] Section = lines.GetRange(i - 4, 562).ToArray();

						lines.InsertRange(i + 558, Section);

						if (ListBoxIndex == (FinalIndex))
						{
							lines.RemoveAt(i - 5);
							lines.Insert(i - 5, "          },");
							lines.RemoveAt(i + 557);
							lines.Insert(i + 557, "          },");
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
			DamageListBox.SelectedIndex = ListBoxIndex;
			DamageListBox.Items[DamageListBox.SelectedIndex] = NewTblValueStr;
			NameOfTableIDTextbox.Text = NewTblValueStr;
			ListBoxIndex = DamageListBox.Items.IndexOf(DamageListBox.SelectedItem) + 1;

			if (ListBoxIndex == FinalIndex)
			{
				MoveDownButton.Enabled = false;
			}
			else
			{
				MoveDownButton.Enabled = true;
			}
			MoveUpButton.Enabled = true;

			UpdateSaveData();

			SavingFile = false;
		}

		private void CreateNewName()
		{
			NewVal = 1;
		Restart:
			//Goes through every single ListBox id
			foreach (string s in DamageListBox.Items)
			{
				//MessageBox.Show(s.ToString());
				//Tries to convert the String IDs to Int, spits it out as InitVal.
				if (DamageListBox.Items.Contains(NewVal.ToString()))
				{
					NewVal++;
					goto Restart;
				}
			}
			NewTblValueStr = NewVal.ToString();
		}

		private void ReloadListBox()
		{
			//Reload ListBox, recreating the list.
			DamageListBox.Items.Clear();

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
						//Changes the Index Int to "18" since that's how many characters until the ": "
						int Index = s.IndexOf(": ");

						//Trim off the Quotations and Commas at the ending.
						char[] charsToTrim = { '"', ',' };
						string TrimmedCharString = s.Trim(charsToTrim);
						//The +3 is used to get past the " : " ", the three additional characters past Index.
						string NameOfTableEntry = (TrimmedCharString.Substring(Index + 3));

						if (DamageListBox.Items.Contains(NameOfTableEntry))
						{
							if (CloningSections)
							{
								NameOfTableEntry = (FinalIndex + 1).ToString() + " Possibly Cloned ID of: " + NameOfTableEntry;
							}
							else
							{
								NameOfTableEntry = (FinalIndex + 1).ToString() + " Duplicate ID: " + NameOfTableEntry + "?";
							}
						}

						DamageListBox.Items.Add(NameOfTableEntry);
					}
					ResizeForm();
				}
			}
		}

		private void ResizeForm()
		{
			var CurrentItemWidth = 0;
			var NewItemWidth = 0;
			try
			{
				CurrentItemWidth = (int)this.CreateGraphics().MeasureString(DamageListBox.Items[DamageListBox.SelectedIndex].ToString(), DamageListBox.Font, TextRenderer.MeasureText(DamageListBox.Items[DamageListBox.SelectedIndex].ToString(), new Font("Arial", 12.0F))).Width;
			}
			catch
			{
				CurrentItemWidth = (int)this.CreateGraphics().MeasureString(DamageListBox.Items[DamageListBox.Items.Count - 1].ToString(), DamageListBox.Font, TextRenderer.MeasureText(DamageListBox.Items[DamageListBox.Items.Count - 1].ToString(), new Font("Arial", 12.0F))).Width;
			}

			if (CurrentItemWidth > DamageListBox.Width)
			{
				NewItemWidth = CurrentItemWidth - DamageListBox.Width;
				this.Width = this.Size.Width + NewItemWidth + 30;
			}
		}

		private void FindFinalIndex()
		{
			//Made this it's own function since it has that null potential, and I didn't want several warnings.
			//Gets Final Index of ListBox
			try
			{
				FinalIndex = DamageListBox.Items.IndexOf(DamageListBox.Items[DamageListBox.Items.Count - 1].ToString()!) + 1;
			}
			catch
			{
				FinalIndex = -1;
			}
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
			NumberKeyPress(AttackPriorityTextbox, e);
			NumberKeyPress(DamageTextBox, e);
			NumberKeyPress(MinDmgTextbox, e);
			NumberKeyPress(OverrideRecovLifeDamageRateTextBox, e);
			NumberKeyPress(BreathDamageTextBox, e);
			NumberKeyPress(GuardDamageTextBox, e);
			NumberKeyPress(ChipDamageTextBox, e);
			NumberKeyPress(StartupDamageCorrectionTextBox, e);
			NumberKeyPress(BeforeDamageCorrectionTextBox, e);
			NumberKeyPress(AfterDamageCorrectionTextBox, e);
			NumberKeyPress(ForwardSpeedTextBox, e);
			NumberKeyPress(VerticalSpeedTextBox, e);
			NumberKeyPress(HorizontalSpeedTextBox, e);
			NumberKeyPress(ForwardSpeedAirTextBox, e);
			NumberKeyPress(VerticalSpeedAirTextBox, e);
			NumberKeyPress(HorizontalSpeedAirTextBox, e);
			NumberKeyPress(ForwardSpeedGuardTextBox, e);
			NumberKeyPress(VerticalSpeedGuardTextBox, e);
			NumberKeyPress(HorizontalSpeedGuardTextBox, e);
			NumberKeyPress(BoundSpeedTextBox, e);
			NumberKeyPress(HeightLimitTextBox, e);
			NumberKeyPress(BrakeTimeTextBox, e);
			NumberKeyPress(HitbackYawOffsetTextBox, e);
			NumberKeyPress(StatusAilmentTimeTextBox, e);
			NumberKeyPress(StatusAilmentRateTextBox, e);
			NumberKeyPress(ChargeGuardVitalityMaxValueTextBox, e);
			NumberKeyPress(ChargeLifeDamageMaxValueTextBox, e);
			NumberKeyPress(GuardRigorTimeTextBox, e);
			NumberKeyPress(AdjustFrameTextBox, e);
			NumberKeyPress(AdjustFrameAirTextBox, e);
			NumberKeyPress(HitEffectDegreeTextBox, e);
			NumberKeyPress(BloodEffectDegreeTextBox, e);
			NumberKeyPress(HitStopSelfTextBox, e);
			NumberKeyPress(HitStopTargetTextBox, e);
			NumberKeyPress(HitStopSelfAwakeTextBox, e);
			NumberKeyPress(HitStopTargetAwakeTextBox, e);
			NumberKeyPress(HitStopSelfSuperAwakeTextBox, e);
			NumberKeyPress(HitStopTargetSuperAwakeTextBox, e);
			NumberKeyPress(GuardHitStopSelfTextBox, e);
			NumberKeyPress(GuardHitStopTargetTextBox, e);
			NumberKeyPress(GuardHitStopSelfAwakeTextBox, e);
			NumberKeyPress(GuardHitStopTargetAwakeTextBox, e);
			NumberKeyPress(GuardHitStopSelfSuperAwakeTextBox, e);
			NumberKeyPress(GuardHitStopTargetSuperAwakeTextBox, e);
			NumberKeyPress(NonRecoveryTimeTextBox, e);
		}

		private void Generalized_TextChanged(object sender, EventArgs e)
		{
			NumberTextChanged(AttackPriorityTextbox, Amount);
			NumberTextChanged(DamageTextBox, Amount);
			NumberTextChanged(MinDmgTextbox, Amount);
			NumberTextChanged(OverrideRecovLifeDamageRateTextBox, Amount);
			NumberTextChanged(BreathDamageTextBox, Amount);
			NumberTextChanged(GuardDamageTextBox, Amount);
			NumberTextChanged(ChipDamageTextBox, Amount);
			NumberTextChanged(StartupDamageCorrectionTextBox, Amount);
			NumberTextChanged(BeforeDamageCorrectionTextBox, Amount);
			NumberTextChanged(AfterDamageCorrectionTextBox, Amount);
			NumberTextChanged(ForwardSpeedTextBox, Amount);
			NumberTextChanged(VerticalSpeedTextBox, Amount);
			NumberTextChanged(HorizontalSpeedTextBox, Amount);
			NumberTextChanged(ForwardSpeedAirTextBox, Amount);
			NumberTextChanged(VerticalSpeedAirTextBox, Amount);
			NumberTextChanged(HorizontalSpeedAirTextBox, Amount);
			NumberTextChanged(ForwardSpeedGuardTextBox, Amount);
			NumberTextChanged(VerticalSpeedGuardTextBox, Amount);
			NumberTextChanged(HorizontalSpeedGuardTextBox, Amount);
			NumberTextChanged(BoundSpeedTextBox, Amount);
			NumberTextChanged(HeightLimitTextBox, Amount);
			NumberTextChanged(BrakeTimeTextBox, Amount);
			NumberTextChanged(HitbackYawOffsetTextBox, Amount);
			NumberTextChanged(StatusAilmentTimeTextBox, Amount);
			NumberTextChanged(StatusAilmentRateTextBox, Amount);
			NumberTextChanged(ChargeGuardVitalityMaxValueTextBox, Amount);
			NumberTextChanged(ChargeLifeDamageMaxValueTextBox, Amount);
			NumberTextChanged(GuardRigorTimeTextBox, Amount);
			NumberTextChanged(AdjustFrameTextBox, Amount);
			NumberTextChanged(AdjustFrameAirTextBox, Amount);
			NumberTextChanged(HitEffectDegreeTextBox, Amount);
			NumberTextChanged(BloodEffectDegreeTextBox, Amount);
			NumberTextChanged(HitStopSelfTextBox, Amount);
			NumberTextChanged(HitStopTargetTextBox, Amount);
			NumberTextChanged(HitStopSelfAwakeTextBox, Amount);
			NumberTextChanged(HitStopTargetAwakeTextBox, Amount);
			NumberTextChanged(HitStopSelfSuperAwakeTextBox, Amount);
			NumberTextChanged(HitStopTargetSuperAwakeTextBox, Amount);
			NumberTextChanged(GuardHitStopSelfTextBox, Amount);
			NumberTextChanged(GuardHitStopTargetTextBox, Amount);
			NumberTextChanged(GuardHitStopSelfAwakeTextBox, Amount);
			NumberTextChanged(GuardHitStopTargetAwakeTextBox, Amount);
			NumberTextChanged(GuardHitStopSelfSuperAwakeTextBox, Amount);
			NumberTextChanged(GuardHitStopTargetSuperAwakeTextBox, Amount);
			NumberTextChanged(NonRecoveryTimeTextBox, Amount);
		}

		private void Generalized_Leave(object sender, EventArgs e)
		{
			NumberLeave(MinDmgTextbox, Amount);
			NumberLeave(AttackPriorityTextbox, Amount);
			NumberLeave(DamageTextBox, Amount);
			NumberLeave(OverrideRecovLifeDamageRateTextBox, Amount);
			NumberLeave(BreathDamageTextBox, Amount);
			NumberLeave(GuardDamageTextBox, Amount);
			NumberLeave(ChipDamageTextBox, Amount);
			NumberLeave(StartupDamageCorrectionTextBox, Amount);
			NumberLeave(BeforeDamageCorrectionTextBox, Amount);
			NumberLeave(AfterDamageCorrectionTextBox, Amount);
			NumberLeave(ForwardSpeedTextBox, Amount);
			NumberLeave(VerticalSpeedTextBox, Amount);
			NumberLeave(HorizontalSpeedTextBox, Amount);
			NumberLeave(ForwardSpeedAirTextBox, Amount);
			NumberLeave(VerticalSpeedAirTextBox, Amount);
			NumberLeave(HorizontalSpeedAirTextBox, Amount);
			NumberLeave(ForwardSpeedGuardTextBox, Amount);
			NumberLeave(VerticalSpeedGuardTextBox, Amount);
			NumberLeave(HorizontalSpeedGuardTextBox, Amount);
			NumberLeave(BoundSpeedTextBox, Amount);
			NumberLeave(HeightLimitTextBox, Amount);
			NumberLeave(BrakeTimeTextBox, Amount);
			NumberLeave(HitbackYawOffsetTextBox, Amount);
			NumberLeave(StatusAilmentTimeTextBox, Amount);
			NumberLeave(StatusAilmentRateTextBox, Amount);
			NumberLeave(ChargeGuardVitalityMaxValueTextBox, Amount);
			NumberLeave(ChargeLifeDamageMaxValueTextBox, Amount);
			NumberLeave(GuardRigorTimeTextBox, Amount);
			NumberLeave(AdjustFrameTextBox, Amount);
			NumberLeave(AdjustFrameAirTextBox, Amount);
			NumberLeave(HitEffectDegreeTextBox, Amount);
			NumberLeave(BloodEffectDegreeTextBox, Amount);
			NumberLeave(HitStopSelfTextBox, Amount);
			NumberLeave(HitStopTargetTextBox, Amount);
			NumberLeave(HitStopSelfAwakeTextBox, Amount);
			NumberLeave(HitStopTargetAwakeTextBox, Amount);
			NumberLeave(HitStopSelfSuperAwakeTextBox, Amount);
			NumberLeave(HitStopTargetSuperAwakeTextBox, Amount);
			NumberLeave(GuardHitStopSelfTextBox, Amount);
			NumberLeave(GuardHitStopTargetTextBox, Amount);
			NumberLeave(GuardHitStopSelfAwakeTextBox, Amount);
			NumberLeave(GuardHitStopTargetAwakeTextBox, Amount);
			NumberLeave(GuardHitStopSelfSuperAwakeTextBox, Amount);
			NumberLeave(GuardHitStopTargetSuperAwakeTextBox, Amount);
			NumberLeave(NonRecoveryTimeTextBox, Amount);
		}

		private void DamageIDTextbox_Leave(object sender, EventArgs e)
		{
			if (DamageIDTextbox.Text == "")
			{
				DamageIDTextbox.Text = "DAMAGE_ID_" + DamageListBox.Items.IndexOf(DamageListBox.SelectedItem) + 1;
			}
		}

		private void StatusAilmentIdTextBox_Leave(object sender, EventArgs e)
		{
			if (StatusAilmentIdTextBox.Text == "")
			{
				StatusAilmentIdTextBox.Text = "None";
			}
		}

		private void HitbackDirectionTypeComboBox_Leave(object sender, EventArgs e)
		{
			if (HitbackDirectionTypeComboBox.Text == "")
			{
				HitbackDirectionTypeComboBox.Text = "HIT_BACK_PL_FORWARD";
			}
		}

		private void EDamageReactionTypeComboBox_Leave(object sender, EventArgs e)
		{
			if (EDamageReactionTypeComboBox.Text == "")
			{
				EDamageReactionTypeComboBox.Text = "DMG_REAC_NOREACTION";
			}
		}

		private void EGuardDamageReactionTypeComboBox_Leave(object sender, EventArgs e)
		{
			if (EGuardDamageReactionTypeComboBox.Text == "")
			{
				EGuardDamageReactionTypeComboBox.Text = "GUARD_DMG_REAC_S";
			}
		}

		private void WeaponAttachPointComboBox_Leave(object sender, EventArgs e)
		{
			if (WeaponAttachPointComboBox.Text == "")
			{
				WeaponAttachPointComboBox.Text = "None";
			}
		}

		private void EffectAngleTypeComboBox_Leave(object sender, EventArgs e)
		{
			if (EffectAngleTypeComboBox.Text == "")
			{
				EffectAngleTypeComboBox.Text = "None";
			}
		}

		private void AllCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (AllCheckBox.Checked)
			{
				AllComboBox.Enabled = true;
			}
			else
			{
				AllComboBox.Enabled = false;
			}
		}

		private void ComboableFrameComboBox_DrawItem(object sender, DrawItemEventArgs e)
		{
			int index = e.Index >= 0 ? e.Index : -1;
			Brush brush = ((e.State & DrawItemState.Selected) > 0) ? SystemBrushes.HighlightText : new SolidBrush(ComboableFrameComboBox.ForeColor);
			e.DrawBackground();
			if (index != -1)
			{
				e.Graphics.DrawString(ComboableFrameComboBox.Items[index].ToString(), e.Font!, brush, e.Bounds, StringFormat.GenericDefault);
			}
			e.DrawFocusRectangle();
		}

		private void ComboableFrameComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (ComboableFrameComboBox.SelectedIndex <= 0 || ComboableFrameComboBox.SelectedIndex > 3)
			{
				ComboableFrameComboBox.BackColor = System.Drawing.SystemColors.Window;
			}
			if (ComboableFrameComboBox.SelectedIndex == 1)
			{
				ComboableFrameComboBox.BackColor = Color.Crimson;
			}
			if (ComboableFrameComboBox.SelectedIndex == 2)
			{
				ComboableFrameComboBox.BackColor = Color.Gold;
			}
			if (ComboableFrameComboBox.SelectedIndex == 3)
			{
				ComboableFrameComboBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			}
		}

		private void YoinkFromFileButton_Click(object sender, EventArgs e)
		{
			bool UserBackedOut = false;
			bool IsValidDamageFileToYoink = false;
			bool IsValidIDToYoink = false;
			string[] SectionToYoink = Array.Empty<string>();
			List<string> lines = new List<string>();
			StructGUIDFound = 0;

			OpenFileDialog OpenYoinkFile = new OpenFileDialog();
			OpenYoinkFile.Title = "Open a prm_damage.json";
			OpenYoinkFile.Filter = "JavaScript Object Notation (*.json)|*.json|Backup File (*.bak)|*.bak|All files (*.*)|*.*";
			if (Properties.Settings.Default.RememberYoinkDamagePath != null)
			{
				OpenYoinkFile.FileName = Properties.Settings.Default.RememberYoinkDamagePath;
			}
			OpenYoinkFile.FilterIndex = 1;
			OpenYoinkFile.CheckFileExists = true;
			OpenYoinkFile.CheckPathExists = true;

			OpenYoinkFile.RestoreDirectory = true;
			if (OpenYoinkFile.ShowDialog() == DialogResult.OK)
			{
				YoinkStreamingPath = OpenYoinkFile.FileName;
				Properties.Settings.Default.RememberYoinkDamagePath = YoinkStreamingPath;
				ReadAllLinesYoink = File.ReadAllLines(YoinkStreamingPath);
				string DmgIDSelection = "";

				//Detects if is Damage File.
				foreach (var Line in ReadAllLinesYoink)
				{
					if (Line.Contains("prm_damage"))
					{
						IsValidDamageFileToYoink = true;
						break;
					}
					else
					{
						IsValidDamageFileToYoink = false;
					}
				}

				if (IsValidDamageFileToYoink)
				{
					SelectDmgIDForm DmgIDForm = new SelectDmgIDForm();

					//Searches through the Damage File for Each DamageID to place in the ComboBox.
					for (int i = 0; i < ReadAllLinesYoink.Length; i++)
					{
						var Line = ReadAllLinesYoink[i];

						if (Line.Contains("StructGUID"))
						{
							List<string> DamageIDList = new List<string>();

							char[] charsToTrim = { '"', ',' };
							string TrimmedCharString = ReadAllLinesYoink[i + 20].Trim(charsToTrim);
							string DamageID = TrimmedCharString.Replace("                \"Value\": \"", "");
							DmgIDForm.DamageIDComboBox.Items.Add(DamageID);
						}
					}

					DmgIDForm.ShowDialog();

					if (DmgIDForm.PressedOK)
					{
						DmgIDSelection = DmgIDForm.SelectedDamageID;
					}
					else
					{
						UserBackedOut = true;
					}
				}

				if (UserBackedOut == false)
				{
					if (IsValidDamageFileToYoink)
					{
						for (int i = 0; i < ReadAllLinesYoink.Length; i++)
						{
							var Line = ReadAllLinesYoink[i];

							if (Line.Contains("\"Value\": \"" + DmgIDSelection + "\""))
							{
								IsValidIDToYoink = true;
								break;
							}
						}
						for (int i = 0; i < ReadAllLines.Length; i++)
						{
							var Line = ReadAllLines[i];
							if (Line.Contains("StructGUID"))
							{
								StructGUIDFound++;
							}
						}
					}
					else
					{
						MessageBox.Show("This is not a prm_damage.json file.");
						YoinkStreamingPath = "";
						ReadAllLinesYoink = Array.Empty<string>();
					}

					if (IsValidIDToYoink)
					{
						int FinalStructGUID = StructGUIDFound;
						StructGUIDFound = 0;

						for (int i = 0; i < ReadAllLinesYoink.Length; i++)
						{
							var Line = ReadAllLinesYoink[i];
							if (Line.Contains("\"Value\": \"" + DmgIDSelection + "\""))
							{
								lines = File.ReadAllLines(YoinkStreamingPath).ToList();
								SectionToYoink = lines.GetRange(i - 24, 562).ToArray();
								break;
							}
						}
						for (int a = 0; a < ReadAllLines.Length; a++)
						{
							var Line = ReadAllLines[a];
							if (Line.Contains("StructGUID"))
							{
								StructGUIDFound++;
								if (StructGUIDFound == FinalStructGUID)
								{
									FinalStructGUID++;
									lines = File.ReadAllLines(StreamingPath).ToList();

									lines.RemoveAt(a + 557);
									lines.Insert(a + 557, "          },");

									lines.InsertRange(a - 4 + 562, SectionToYoink);

									lines.RemoveAt(a + 1119);
									lines.Insert(a + 1119, "          }");

									File.WriteAllLines(StreamingPath, lines.ToArray());
									ReadAllLines = File.ReadAllLines(StreamingPath);
									break;
								}
							}
						}

						//Goes through and renames the List.
						CloningSections = true;
						ReloadListBox();
						FindFinalIndex();
						DamageListBox.SelectedIndex = 0;
						for (int i = 0; i < FinalIndex; i++)
						{
							if (DamageListBox.SelectedIndex < FinalIndex - 1)
							{
								DamageListBox.SelectedIndex++;
								UpdateSaveData();
							}
						}
						CloningSections = false;
						DamageListBox.SelectedIndex = DamageListBox.Items.Count - 1;
					}
					else
					{
						MessageBox.Show("This ID does not exist within this Damage File.");
					}
				}
			}
		}
	}
}