using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class PlayRegionParam
	{
		private readonly PARAM _param;
		public PlayRegionParam(PARAM param) => _param = param;
		public IEnumerable<PlayRegionParamRow> Entries => _param.Rows.Select(r => new PlayRegionParamRow(r));
	}
	public class PlayRegionParamRow
	{
		private readonly PARAM.Row _row;
		public PlayRegionParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte disableParam_NT => (byte)_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public int matchAreaId => (int)_row["matchAreaId"].Value;
		public uint multiPlayStartLimitEventFlagId => (uint)_row["multiPlayStartLimitEventFlagId"].Value;
		public float otherDisableDistance => (float)_row["otherDisableDistance"].Value;
		public uint pcPositionSaveLimitEventFlagId => (uint)_row["pcPositionSaveLimitEventFlagId"].Value;
		public uint bossAreaId => (uint)_row["bossAreaId"].Value;
		public short cultNpcWhiteGhostEntityId_byFree => (short)_row["cultNpcWhiteGhostEntityId_byFree"].Value;
		public byte bMapGuradianRegion => (byte)_row["bMapGuradianRegion"].Value;
		public byte bYellowCostumeRegion => (byte)_row["bYellowCostumeRegion"].Value;
		public byte multiPlayStartLimitEventFlagId_targetFlagState => (byte)_row["multiPlayStartLimitEventFlagId_targetFlagState"].Value;
		public byte breakInLimitEventFlagId_1_targetFlagState => (byte)_row["breakInLimitEventFlagId_1_targetFlagState"].Value;
		public byte whiteSignLimitEventFlagId_1_targetFlagState => (byte)_row["whiteSignLimitEventFlagId_1_targetFlagState"].Value;
		public byte redSignLimitEventFlagId_1_targetFlagState => (byte)_row["redSignLimitEventFlagId_1_targetFlagState"].Value;
		public byte breakInLimitEventFlagId_2_targetFlagState => (byte)_row["breakInLimitEventFlagId_2_targetFlagState"].Value;
		public byte breakInLimitEventFlagId_3_targetFlagState => (byte)_row["breakInLimitEventFlagId_3_targetFlagState"].Value;
		public byte whiteSignLimitEventFlagId_2_targetFlagState => (byte)_row["whiteSignLimitEventFlagId_2_targetFlagState"].Value;
		public uint warpItemUsePermitBonfireId_1 => (uint)_row["warpItemUsePermitBonfireId_1"].Value;
		public uint warpItemUsePermitBonfireId_2 => (uint)_row["warpItemUsePermitBonfireId_2"].Value;
		public uint warpItemUsePermitBonfireId_3 => (uint)_row["warpItemUsePermitBonfireId_3"].Value;
		public uint warpItemUsePermitBonfireId_4 => (uint)_row["warpItemUsePermitBonfireId_4"].Value;
		public uint warpItemUsePermitBonfireId_5 => (uint)_row["warpItemUsePermitBonfireId_5"].Value;
		public uint warpItemProhibitionEventFlagId_1 => (uint)_row["warpItemProhibitionEventFlagId_1"].Value;
		public uint warpItemProhibitionEventFlagId_2 => (uint)_row["warpItemProhibitionEventFlagId_2"].Value;
		public uint warpItemProhibitionEventFlagId_3 => (uint)_row["warpItemProhibitionEventFlagId_3"].Value;
		public uint warpItemProhibitionEventFlagId_4 => (uint)_row["warpItemProhibitionEventFlagId_4"].Value;
		public uint warpItemProhibitionEventFlagId_5 => (uint)_row["warpItemProhibitionEventFlagId_5"].Value;
		public byte enableBloodstain => (byte)_row["enableBloodstain"].Value;
		public byte enableBloodMessage => (byte)_row["enableBloodMessage"].Value;
		public byte enableGhost => (byte)_row["enableGhost"].Value;
		public byte dispMask00 => (byte)_row["dispMask00"].Value;
		public byte dispMask01 => (byte)_row["dispMask01"].Value;
		public byte whiteSignLimitEventFlagId_3_targetFlagState => (byte)_row["whiteSignLimitEventFlagId_3_targetFlagState"].Value;
		public byte redSignLimitEventFlagId_2_targetFlagState => (byte)_row["redSignLimitEventFlagId_2_targetFlagState"].Value;
		public byte redSignLimitEventFlagId_3_targetFlagState => (byte)_row["redSignLimitEventFlagId_3_targetFlagState"].Value;
		public byte isAutoIntrudePoint => (byte)_row["isAutoIntrudePoint"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public uint multiPlayHASHostLimitEventFlagId => (uint)_row["multiPlayHASHostLimitEventFlagId"].Value;
		public float otherMaxDistance => (float)_row["otherMaxDistance"].Value;
		public uint signPuddleOpenEventFlagId => (uint)_row["signPuddleOpenEventFlagId"].Value;
		public byte areaNo => (byte)_row["areaNo"].Value;
		public byte gridXNo => (byte)_row["gridXNo"].Value;
		public byte gridZNo => (byte)_row["gridZNo"].Value;
		public byte[] pad4 => (byte[])_row["pad4"].Value;
		public float posX => (float)_row["posX"].Value;
		public float posY => (float)_row["posY"].Value;
		public float posZ => (float)_row["posZ"].Value;
		public uint breakInLimitEventFlagId_1 => (uint)_row["breakInLimitEventFlagId_1"].Value;
		public uint whiteSignLimitEventFlagId_1 => (uint)_row["whiteSignLimitEventFlagId_1"].Value;
		public uint matchAreaSignCreateLimitEventFlagId => (uint)_row["matchAreaSignCreateLimitEventFlagId"].Value;
		public uint signAimId_1 => (uint)_row["signAimId_1"].Value;
		public uint signAimId_2 => (uint)_row["signAimId_2"].Value;
		public uint signAimId_3 => (uint)_row["signAimId_3"].Value;
		public uint signAimId_4 => (uint)_row["signAimId_4"].Value;
		public uint signAimId_5 => (uint)_row["signAimId_5"].Value;
		public uint signAimId_6 => (uint)_row["signAimId_6"].Value;
		public uint signAimId_7 => (uint)_row["signAimId_7"].Value;
		public uint signAimId_8 => (uint)_row["signAimId_8"].Value;
		public uint redSignLimitEventFlagId_1 => (uint)_row["redSignLimitEventFlagId_1"].Value;
		public uint breakInLimitEventFlagId_2 => (uint)_row["breakInLimitEventFlagId_2"].Value;
		public uint breakInLimitEventFlagId_3 => (uint)_row["breakInLimitEventFlagId_3"].Value;
		public uint whiteSignLimitEventFlagId_2 => (uint)_row["whiteSignLimitEventFlagId_2"].Value;
		public uint whiteSignLimitEventFlagId_3 => (uint)_row["whiteSignLimitEventFlagId_3"].Value;
		public uint redSignLimitEventFlagId_2 => (uint)_row["redSignLimitEventFlagId_2"].Value;
		public uint redSignLimitEventFlagId_3 => (uint)_row["redSignLimitEventFlagId_3"].Value;
		public uint bossId_1 => (uint)_row["bossId_1"].Value;
		public uint bossId_2 => (uint)_row["bossId_2"].Value;
		public uint bossId_3 => (uint)_row["bossId_3"].Value;
		public uint bossId_4 => (uint)_row["bossId_4"].Value;
		public uint bossId_5 => (uint)_row["bossId_5"].Value;
		public uint bossId_6 => (uint)_row["bossId_6"].Value;
		public uint bossId_7 => (uint)_row["bossId_7"].Value;
		public uint bossId_8 => (uint)_row["bossId_8"].Value;
		public uint bossId_9 => (uint)_row["bossId_9"].Value;
		public uint bossId_10 => (uint)_row["bossId_10"].Value;
		public uint bossId_11 => (uint)_row["bossId_11"].Value;
		public uint bossId_12 => (uint)_row["bossId_12"].Value;
		public uint bossId_13 => (uint)_row["bossId_13"].Value;
		public uint bossId_14 => (uint)_row["bossId_14"].Value;
		public uint bossId_15 => (uint)_row["bossId_15"].Value;
		public uint bossId_16 => (uint)_row["bossId_16"].Value;
		public uint mapMenuUnlockEventId => (uint)_row["mapMenuUnlockEventId"].Value;
		public byte[] pad5 => (byte[])_row["pad5"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | disableParam_NT: {disableParam_NT} | matchAreaId: {matchAreaId} | multiPlayStartLimitEventFlagId: {multiPlayStartLimitEventFlagId} | otherDisableDistance: {otherDisableDistance} | pcPositionSaveLimitEventFlagId: {pcPositionSaveLimitEventFlagId} | bossAreaId: {bossAreaId} | cultNpcWhiteGhostEntityId_byFree: {cultNpcWhiteGhostEntityId_byFree} | bMapGuradianRegion: {bMapGuradianRegion} | bYellowCostumeRegion: {bYellowCostumeRegion} | multiPlayStartLimitEventFlagId_targetFlagState: {multiPlayStartLimitEventFlagId_targetFlagState} | breakInLimitEventFlagId_1_targetFlagState: {breakInLimitEventFlagId_1_targetFlagState} | whiteSignLimitEventFlagId_1_targetFlagState: {whiteSignLimitEventFlagId_1_targetFlagState} | redSignLimitEventFlagId_1_targetFlagState: {redSignLimitEventFlagId_1_targetFlagState} | breakInLimitEventFlagId_2_targetFlagState: {breakInLimitEventFlagId_2_targetFlagState} | breakInLimitEventFlagId_3_targetFlagState: {breakInLimitEventFlagId_3_targetFlagState} | whiteSignLimitEventFlagId_2_targetFlagState: {whiteSignLimitEventFlagId_2_targetFlagState} | warpItemUsePermitBonfireId_1: {warpItemUsePermitBonfireId_1} | warpItemUsePermitBonfireId_2: {warpItemUsePermitBonfireId_2} | warpItemUsePermitBonfireId_3: {warpItemUsePermitBonfireId_3} | warpItemUsePermitBonfireId_4: {warpItemUsePermitBonfireId_4} | warpItemUsePermitBonfireId_5: {warpItemUsePermitBonfireId_5} | warpItemProhibitionEventFlagId_1: {warpItemProhibitionEventFlagId_1} | warpItemProhibitionEventFlagId_2: {warpItemProhibitionEventFlagId_2} | warpItemProhibitionEventFlagId_3: {warpItemProhibitionEventFlagId_3} | warpItemProhibitionEventFlagId_4: {warpItemProhibitionEventFlagId_4} | warpItemProhibitionEventFlagId_5: {warpItemProhibitionEventFlagId_5} | enableBloodstain: {enableBloodstain} | enableBloodMessage: {enableBloodMessage} | enableGhost: {enableGhost} | dispMask00: {dispMask00} | dispMask01: {dispMask01} | whiteSignLimitEventFlagId_3_targetFlagState: {whiteSignLimitEventFlagId_3_targetFlagState} | redSignLimitEventFlagId_2_targetFlagState: {redSignLimitEventFlagId_2_targetFlagState} | redSignLimitEventFlagId_3_targetFlagState: {redSignLimitEventFlagId_3_targetFlagState} | isAutoIntrudePoint: {isAutoIntrudePoint} | multiPlayHASHostLimitEventFlagId: {multiPlayHASHostLimitEventFlagId} | otherMaxDistance: {otherMaxDistance} | signPuddleOpenEventFlagId: {signPuddleOpenEventFlagId} | areaNo: {areaNo} | gridXNo: {gridXNo} | gridZNo: {gridZNo} | posX: {posX} | posY: {posY} | posZ: {posZ} | breakInLimitEventFlagId_1: {breakInLimitEventFlagId_1} | whiteSignLimitEventFlagId_1: {whiteSignLimitEventFlagId_1} | matchAreaSignCreateLimitEventFlagId: {matchAreaSignCreateLimitEventFlagId} | signAimId_1: {signAimId_1} | signAimId_2: {signAimId_2} | signAimId_3: {signAimId_3} | signAimId_4: {signAimId_4} | signAimId_5: {signAimId_5} | signAimId_6: {signAimId_6} | signAimId_7: {signAimId_7} | signAimId_8: {signAimId_8} | redSignLimitEventFlagId_1: {redSignLimitEventFlagId_1} | breakInLimitEventFlagId_2: {breakInLimitEventFlagId_2} | breakInLimitEventFlagId_3: {breakInLimitEventFlagId_3} | whiteSignLimitEventFlagId_2: {whiteSignLimitEventFlagId_2} | whiteSignLimitEventFlagId_3: {whiteSignLimitEventFlagId_3} | redSignLimitEventFlagId_2: {redSignLimitEventFlagId_2} | redSignLimitEventFlagId_3: {redSignLimitEventFlagId_3} | bossId_1: {bossId_1} | bossId_2: {bossId_2} | bossId_3: {bossId_3} | bossId_4: {bossId_4} | bossId_5: {bossId_5} | bossId_6: {bossId_6} | bossId_7: {bossId_7} | bossId_8: {bossId_8} | bossId_9: {bossId_9} | bossId_10: {bossId_10} | bossId_11: {bossId_11} | bossId_12: {bossId_12} | bossId_13: {bossId_13} | bossId_14: {bossId_14} | bossId_15: {bossId_15} | bossId_16: {bossId_16} | mapMenuUnlockEventId: {mapMenuUnlockEventId}";
	}
}
