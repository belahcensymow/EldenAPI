using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class PlayerCommonParam
	{
		private readonly PARAM _param;
		public PlayerCommonParam(PARAM param) => _param = param;
		public IEnumerable<PlayerCommonParamRow> Entries => _param.Rows.Select(r => new PlayerCommonParamRow(r));
	}
	public class PlayerCommonParamRow
	{
		private readonly PARAM.Row _row;
		public PlayerCommonParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int playerFootEffect_bySFX => (int)_row["playerFootEffect_bySFX"].Value;
		public float snipeModeDrawAlpha_FadeTime => (float)_row["snipeModeDrawAlpha_FadeTime"].Value;
		public float toughnessRecoverCorrection => (float)_row["toughnessRecoverCorrection"].Value;
		public byte baseMagicSlotSize => (byte)_row["baseMagicSlotSize"].Value;
		public byte baseAccSlotNum => (byte)_row["baseAccSlotNum"].Value;
		public byte[] reserved02 => (byte[])_row["reserved02"].Value;
		public int animeID_DropItemPick => (int)_row["animeID_DropItemPick"].Value;
		public float resistRecoverPoint_Sleep_Player => (float)_row["resistRecoverPoint_Sleep_Player"].Value;
		public int flareOverrideHomingAngle => (int)_row["flareOverrideHomingAngle"].Value;
		public float flareOverrideHomingStopRange => (float)_row["flareOverrideHomingStopRange"].Value;
		public int animeID_SleepCollectorItemPick => (int)_row["animeID_SleepCollectorItemPick"].Value;
		public uint unlockEventFlagBaseId_forWepAttr => (uint)_row["unlockEventFlagBaseId_forWepAttr"].Value;
		public int systemEnchant_BigRune => (int)_row["systemEnchant_BigRune"].Value;
		public float lowStatus_AtkPowDown => (float)_row["lowStatus_AtkPowDown"].Value;
		public float lowStatus_ConsumeStaminaRate => (float)_row["lowStatus_ConsumeStaminaRate"].Value;
		public short lowStatus_AtkGuardBreak => (short)_row["lowStatus_AtkGuardBreak"].Value;
		public short guardStatusCorrect_MaxStatusVal => (short)_row["guardStatusCorrect_MaxStatusVal"].Value;
		public ushort unlockEventFlagStepNum_forWepAttr => (ushort)_row["unlockEventFlagStepNum_forWepAttr"].Value;
		public ushort retributionMagic_damageCountNum => (ushort)_row["retributionMagic_damageCountNum"].Value;
		public ushort retributionMagic_damageCountRemainTime => (ushort)_row["retributionMagic_damageCountRemainTime"].Value;
		public ushort retributionMagic_burstDmypolyId => (ushort)_row["retributionMagic_burstDmypolyId"].Value;
		public int retributionMagic_burstMagicParamId => (int)_row["retributionMagic_burstMagicParamId"].Value;
		public float chrAimCam_rideOffsetHeight => (float)_row["chrAimCam_rideOffsetHeight"].Value;
		public byte[] reserved23 => (byte[])_row["reserved23"].Value;
		public int arrowCaseWepBindDmypolyId => (int)_row["arrowCaseWepBindDmypolyId"].Value;
		public int boltPouchWepBindDmypolyId => (int)_row["boltPouchWepBindDmypolyId"].Value;
		public float estusFlaskAllocateRate => (float)_row["estusFlaskAllocateRate"].Value;
		public byte[] reserved38 => (byte[])_row["reserved38"].Value;
		public byte kickAcceptanceDeg => (byte)_row["kickAcceptanceDeg"].Value;
		public byte npcPlayerAnalogWeightRate_Light => (byte)_row["npcPlayerAnalogWeightRate_Light"].Value;
		public byte npcPlayerAnalogWeightRate_Normal => (byte)_row["npcPlayerAnalogWeightRate_Normal"].Value;
		public byte npcPlayerAnalogWeightRate_Heavy => (byte)_row["npcPlayerAnalogWeightRate_Heavy"].Value;
		public byte npcPlayerAnalogWeightRate_WeightOver => (byte)_row["npcPlayerAnalogWeightRate_WeightOver"].Value;
		public byte npcPlayerAnalogWeightRate_SuperLight => (byte)_row["npcPlayerAnalogWeightRate_SuperLight"].Value;
		public byte[] reserved45 => (byte[])_row["reserved45"].Value;
		public int clearCountCorrectBaseSpEffectId => (int)_row["clearCountCorrectBaseSpEffectId"].Value;
		public int arrowBoltModelIdOffset => (int)_row["arrowBoltModelIdOffset"].Value;
		public sbyte arrowBoltRemainingNumModelMaskThreshold1 => (sbyte)_row["arrowBoltRemainingNumModelMaskThreshold1"].Value;
		public sbyte arrowBoltRemainingNumModelMaskThreshold2 => (sbyte)_row["arrowBoltRemainingNumModelMaskThreshold2"].Value;
		public byte[] reserved27 => (byte[])_row["reserved27"].Value;
		public float resistRecoverPoint_Poision_Player => (float)_row["resistRecoverPoint_Poision_Player"].Value;
		public float resistRecoverPoint_Desease_Player => (float)_row["resistRecoverPoint_Desease_Player"].Value;
		public float resistRecoverPoint_Blood_Player => (float)_row["resistRecoverPoint_Blood_Player"].Value;
		public float resistRecoverPoint_Curse_Player => (float)_row["resistRecoverPoint_Curse_Player"].Value;
		public float resistRecoverPoint_Freeze_Player => (float)_row["resistRecoverPoint_Freeze_Player"].Value;
		public float resistRecoverPoint_Poision_Enemy => (float)_row["resistRecoverPoint_Poision_Enemy"].Value;
		public float resistRecoverPoint_Desease_Enemy => (float)_row["resistRecoverPoint_Desease_Enemy"].Value;
		public float resistRecoverPoint_Blood_Enemy => (float)_row["resistRecoverPoint_Blood_Enemy"].Value;
		public float resistRecoverPoint_Curse_Enemy => (float)_row["resistRecoverPoint_Curse_Enemy"].Value;
		public float resistRecoverPoint_Freeze_Enemy => (float)_row["resistRecoverPoint_Freeze_Enemy"].Value;
		public float requestTimeLeftBothHand => (float)_row["requestTimeLeftBothHand"].Value;
		public float resistRecoverPoint_Madness_Player => (float)_row["resistRecoverPoint_Madness_Player"].Value;
		public int animeID_MaterialItemPick => (int)_row["animeID_MaterialItemPick"].Value;
		public float hpEstusFlaskAllocateRateForYellowMonk => (float)_row["hpEstusFlaskAllocateRateForYellowMonk"].Value;
		public int hpEstusFlaskAllocateOffsetForYellowMonk => (int)_row["hpEstusFlaskAllocateOffsetForYellowMonk"].Value;
		public float mpEstusFlaskAllocateRateForYellowMonk => (float)_row["mpEstusFlaskAllocateRateForYellowMonk"].Value;
		public int mpEstusFlaskAllocateOffsetForYellowMonk => (int)_row["mpEstusFlaskAllocateOffsetForYellowMonk"].Value;
		public float resistRecoverPoint_Sleep_Enemy => (float)_row["resistRecoverPoint_Sleep_Enemy"].Value;
		public float resistRecoverPoint_Madness_Enemy => (float)_row["resistRecoverPoint_Madness_Enemy"].Value;
		public int resistCurseItemId => (int)_row["resistCurseItemId"].Value;
		public byte resistCurseItemMaxNum => (byte)_row["resistCurseItemMaxNum"].Value;
		public byte[] reserved_123 => (byte[])_row["reserved_123"].Value;
		public int resistCurseItemSpEffectBaseId => (int)_row["resistCurseItemSpEffectBaseId"].Value;
		public int resistCurseItemLotParamId_map => (int)_row["resistCurseItemLotParamId_map"].Value;
		public byte[] reserved41 => (byte[])_row["reserved41"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | playerFootEffect_bySFX: {playerFootEffect_bySFX} | snipeModeDrawAlpha_FadeTime: {snipeModeDrawAlpha_FadeTime} | toughnessRecoverCorrection: {toughnessRecoverCorrection} | baseMagicSlotSize: {baseMagicSlotSize} | baseAccSlotNum: {baseAccSlotNum} | animeID_DropItemPick: {animeID_DropItemPick} | resistRecoverPoint_Sleep_Player: {resistRecoverPoint_Sleep_Player} | flareOverrideHomingAngle: {flareOverrideHomingAngle} | flareOverrideHomingStopRange: {flareOverrideHomingStopRange} | animeID_SleepCollectorItemPick: {animeID_SleepCollectorItemPick} | unlockEventFlagBaseId_forWepAttr: {unlockEventFlagBaseId_forWepAttr} | systemEnchant_BigRune: {systemEnchant_BigRune} | lowStatus_AtkPowDown: {lowStatus_AtkPowDown} | lowStatus_ConsumeStaminaRate: {lowStatus_ConsumeStaminaRate} | lowStatus_AtkGuardBreak: {lowStatus_AtkGuardBreak} | guardStatusCorrect_MaxStatusVal: {guardStatusCorrect_MaxStatusVal} | unlockEventFlagStepNum_forWepAttr: {unlockEventFlagStepNum_forWepAttr} | retributionMagic_damageCountNum: {retributionMagic_damageCountNum} | retributionMagic_damageCountRemainTime: {retributionMagic_damageCountRemainTime} | retributionMagic_burstDmypolyId: {retributionMagic_burstDmypolyId} | retributionMagic_burstMagicParamId: {retributionMagic_burstMagicParamId} | chrAimCam_rideOffsetHeight: {chrAimCam_rideOffsetHeight} | arrowCaseWepBindDmypolyId: {arrowCaseWepBindDmypolyId} | boltPouchWepBindDmypolyId: {boltPouchWepBindDmypolyId} | estusFlaskAllocateRate: {estusFlaskAllocateRate} | kickAcceptanceDeg: {kickAcceptanceDeg} | npcPlayerAnalogWeightRate_Light: {npcPlayerAnalogWeightRate_Light} | npcPlayerAnalogWeightRate_Normal: {npcPlayerAnalogWeightRate_Normal} | npcPlayerAnalogWeightRate_Heavy: {npcPlayerAnalogWeightRate_Heavy} | npcPlayerAnalogWeightRate_WeightOver: {npcPlayerAnalogWeightRate_WeightOver} | npcPlayerAnalogWeightRate_SuperLight: {npcPlayerAnalogWeightRate_SuperLight} | clearCountCorrectBaseSpEffectId: {clearCountCorrectBaseSpEffectId} | arrowBoltModelIdOffset: {arrowBoltModelIdOffset} | arrowBoltRemainingNumModelMaskThreshold1: {arrowBoltRemainingNumModelMaskThreshold1} | arrowBoltRemainingNumModelMaskThreshold2: {arrowBoltRemainingNumModelMaskThreshold2} | resistRecoverPoint_Poision_Player: {resistRecoverPoint_Poision_Player} | resistRecoverPoint_Desease_Player: {resistRecoverPoint_Desease_Player} | resistRecoverPoint_Blood_Player: {resistRecoverPoint_Blood_Player} | resistRecoverPoint_Curse_Player: {resistRecoverPoint_Curse_Player} | resistRecoverPoint_Freeze_Player: {resistRecoverPoint_Freeze_Player} | resistRecoverPoint_Poision_Enemy: {resistRecoverPoint_Poision_Enemy} | resistRecoverPoint_Desease_Enemy: {resistRecoverPoint_Desease_Enemy} | resistRecoverPoint_Blood_Enemy: {resistRecoverPoint_Blood_Enemy} | resistRecoverPoint_Curse_Enemy: {resistRecoverPoint_Curse_Enemy} | resistRecoverPoint_Freeze_Enemy: {resistRecoverPoint_Freeze_Enemy} | requestTimeLeftBothHand: {requestTimeLeftBothHand} | resistRecoverPoint_Madness_Player: {resistRecoverPoint_Madness_Player} | animeID_MaterialItemPick: {animeID_MaterialItemPick} | hpEstusFlaskAllocateRateForYellowMonk: {hpEstusFlaskAllocateRateForYellowMonk} | hpEstusFlaskAllocateOffsetForYellowMonk: {hpEstusFlaskAllocateOffsetForYellowMonk} | mpEstusFlaskAllocateRateForYellowMonk: {mpEstusFlaskAllocateRateForYellowMonk} | mpEstusFlaskAllocateOffsetForYellowMonk: {mpEstusFlaskAllocateOffsetForYellowMonk} | resistRecoverPoint_Sleep_Enemy: {resistRecoverPoint_Sleep_Enemy} | resistRecoverPoint_Madness_Enemy: {resistRecoverPoint_Madness_Enemy} | resistCurseItemId: {resistCurseItemId} | resistCurseItemMaxNum: {resistCurseItemMaxNum} | resistCurseItemSpEffectBaseId: {resistCurseItemSpEffectBaseId} | resistCurseItemLotParamId_map: {resistCurseItemLotParamId_map}";
	}
}
