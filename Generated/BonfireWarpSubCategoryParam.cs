using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class BonfireWarpSubCategoryParam
	{
		private readonly PARAM _param;
		public BonfireWarpSubCategoryParam(PARAM param) => _param = param;
		public IEnumerable<BonfireWarpSubCategoryParamRow> Entries => _param.Rows.Select(r => new BonfireWarpSubCategoryParamRow(r));
	}
	public class BonfireWarpSubCategoryParamRow
	{
		private readonly PARAM.Row _row;
		public BonfireWarpSubCategoryParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] disableParam_NT => (byte[])_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public int textId => (int)_row["textId"].Value;
		public ushort tabId => (ushort)_row["tabId"].Value;
		public ushort sortId => (ushort)_row["sortId"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | textId: {textId} | tabId: {tabId} | sortId: {sortId}";
	}
}
