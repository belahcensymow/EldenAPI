using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class SwordArtsParam
	{
		private readonly PARAM _param;
		public SwordArtsParam(PARAM param) => _param = param;
		public IEnumerable<SwordArtsParamRow> Entries => _param.Rows.Select(r => new SwordArtsParamRow(r));
	}
	public class SwordArtsParamRow
	{
		private readonly PARAM.Row _row;
		public SwordArtsParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] disableParam_NT => (byte[])_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public byte swordArtsType => (byte)_row["swordArtsType"].Value;
		public byte artsSpeedType => (byte)_row["artsSpeedType"].Value;
		public byte[] refStatus => (byte[])_row["refStatus"].Value;
		public byte[] isRefRightArts => (byte[])_row["isRefRightArts"].Value;
		public byte[] isGrayoutLeftHand => (byte[])_row["isGrayoutLeftHand"].Value;
		public byte[] isGrayoutRightHand => (byte[])_row["isGrayoutRightHand"].Value;
		public byte[] isGrayoutBothHand => (byte[])_row["isGrayoutBothHand"].Value;
		public byte[] reserve2 => (byte[])_row["reserve2"].Value;
		public sbyte usePoint_L1 => (sbyte)_row["usePoint_L1"].Value;
		public sbyte usePoint_L2 => (sbyte)_row["usePoint_L2"].Value;
		public sbyte usePoint_R1 => (sbyte)_row["usePoint_R1"].Value;
		public sbyte usePoint_R2 => (sbyte)_row["usePoint_R2"].Value;
		public int textId => (int)_row["textId"].Value;
		public short useMagicPoint_L1 => (short)_row["useMagicPoint_L1"].Value;
		public short useMagicPoint_L2 => (short)_row["useMagicPoint_L2"].Value;
		public short useMagicPoint_R1 => (short)_row["useMagicPoint_R1"].Value;
		public short useMagicPoint_R2 => (short)_row["useMagicPoint_R2"].Value;
		public byte[] shieldIconType => (byte[])_row["shieldIconType"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public ushort iconId => (ushort)_row["iconId"].Value;
		public int aiUsageId => (int)_row["aiUsageId"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | swordArtsType: {swordArtsType} | artsSpeedType: {artsSpeedType} | usePoint_L1: {usePoint_L1} | usePoint_L2: {usePoint_L2} | usePoint_R1: {usePoint_R1} | usePoint_R2: {usePoint_R2} | textId: {textId} | useMagicPoint_L1: {useMagicPoint_L1} | useMagicPoint_L2: {useMagicPoint_L2} | useMagicPoint_R1: {useMagicPoint_R1} | useMagicPoint_R2: {useMagicPoint_R2} | iconId: {iconId} | aiUsageId: {aiUsageId}";
	}
}
