using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class BonfireWarpTabParam
	{
		private readonly PARAM _param;
		public BonfireWarpTabParam(PARAM param) => _param = param;
		public IEnumerable<BonfireWarpTabParamRow> Entries => _param.Rows.Select(r => new BonfireWarpTabParamRow(r));
	}
	public class BonfireWarpTabParamRow
	{
		private readonly PARAM.Row _row;
		public BonfireWarpTabParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte disableParam_NT => (byte)_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public int textId => (int)_row["textId"].Value;
		public int sortId => (int)_row["sortId"].Value;
		public ushort iconId => (ushort)_row["iconId"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | disableParam_NT: {disableParam_NT} | textId: {textId} | sortId: {sortId} | iconId: {iconId}";
	}
}
