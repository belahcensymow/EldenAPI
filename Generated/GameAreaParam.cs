using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class GameAreaParam
	{
		private readonly PARAM _param;
		public GameAreaParam(PARAM param) => _param = param;
		public IEnumerable<GameAreaParamRow> Entries => _param.Rows.Select(r => new GameAreaParamRow(r));
	}
	public class GameAreaParamRow
	{
		private readonly PARAM.Row _row;
		public GameAreaParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] disableParam_NT => (byte[])_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public uint bonusSoul_single => (uint)_row["bonusSoul_single"].Value;
		public uint bonusSoul_multi => (uint)_row["bonusSoul_multi"].Value;
		public uint humanityPointCountFlagIdTop => (uint)_row["humanityPointCountFlagIdTop"].Value;
		public ushort humanityDropPoint1 => (ushort)_row["humanityDropPoint1"].Value;
		public ushort humanityDropPoint2 => (ushort)_row["humanityDropPoint2"].Value;
		public ushort humanityDropPoint3 => (ushort)_row["humanityDropPoint3"].Value;
		public ushort humanityDropPoint4 => (ushort)_row["humanityDropPoint4"].Value;
		public ushort humanityDropPoint5 => (ushort)_row["humanityDropPoint5"].Value;
		public ushort humanityDropPoint6 => (ushort)_row["humanityDropPoint6"].Value;
		public ushort humanityDropPoint7 => (ushort)_row["humanityDropPoint7"].Value;
		public ushort humanityDropPoint8 => (ushort)_row["humanityDropPoint8"].Value;
		public ushort humanityDropPoint9 => (ushort)_row["humanityDropPoint9"].Value;
		public ushort humanityDropPoint10 => (ushort)_row["humanityDropPoint10"].Value;
		public uint soloBreakInPoint_Min => (uint)_row["soloBreakInPoint_Min"].Value;
		public uint soloBreakInPoint_Max => (uint)_row["soloBreakInPoint_Max"].Value;
		public uint defeatBossFlagId_forSignAimList => (uint)_row["defeatBossFlagId_forSignAimList"].Value;
		public uint displayAimFlagId => (uint)_row["displayAimFlagId"].Value;
		public uint foundBossFlagId => (uint)_row["foundBossFlagId"].Value;
		public int foundBossTextId => (int)_row["foundBossTextId"].Value;
		public int notFindBossTextId => (int)_row["notFindBossTextId"].Value;
		public uint bossChallengeFlagId => (uint)_row["bossChallengeFlagId"].Value;
		public uint defeatBossFlagId => (uint)_row["defeatBossFlagId"].Value;
		public float bossPosX => (float)_row["bossPosX"].Value;
		public float bossPosY => (float)_row["bossPosY"].Value;
		public float bossPosZ => (float)_row["bossPosZ"].Value;
		public byte bossMapAreaNo => (byte)_row["bossMapAreaNo"].Value;
		public byte bossMapBlockNo => (byte)_row["bossMapBlockNo"].Value;
		public byte bossMapMapNo => (byte)_row["bossMapMapNo"].Value;
		public byte[] reserve => (byte[])_row["reserve"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | bonusSoul_single: {bonusSoul_single} | bonusSoul_multi: {bonusSoul_multi} | humanityPointCountFlagIdTop: {humanityPointCountFlagIdTop} | humanityDropPoint1: {humanityDropPoint1} | humanityDropPoint2: {humanityDropPoint2} | humanityDropPoint3: {humanityDropPoint3} | humanityDropPoint4: {humanityDropPoint4} | humanityDropPoint5: {humanityDropPoint5} | humanityDropPoint6: {humanityDropPoint6} | humanityDropPoint7: {humanityDropPoint7} | humanityDropPoint8: {humanityDropPoint8} | humanityDropPoint9: {humanityDropPoint9} | humanityDropPoint10: {humanityDropPoint10} | soloBreakInPoint_Min: {soloBreakInPoint_Min} | soloBreakInPoint_Max: {soloBreakInPoint_Max} | defeatBossFlagId_forSignAimList: {defeatBossFlagId_forSignAimList} | displayAimFlagId: {displayAimFlagId} | foundBossFlagId: {foundBossFlagId} | foundBossTextId: {foundBossTextId} | notFindBossTextId: {notFindBossTextId} | bossChallengeFlagId: {bossChallengeFlagId} | defeatBossFlagId: {defeatBossFlagId} | bossPosX: {bossPosX} | bossPosY: {bossPosY} | bossPosZ: {bossPosZ} | bossMapAreaNo: {bossMapAreaNo} | bossMapBlockNo: {bossMapBlockNo} | bossMapMapNo: {bossMapMapNo}";
	}
}
