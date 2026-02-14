using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class MenuPropertySpecParam
	{
		private readonly PARAM _param;
		public MenuPropertySpecParam(PARAM param) => _param = param;
		public IEnumerable<MenuPropertySpecParamRow> Entries => _param.Rows.Select(r => new MenuPropertySpecParamRow(r));
	}
	public class MenuPropertySpecParamRow
	{
		private readonly PARAM.Row _row;
		public MenuPropertySpecParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int CaptionTextID => (int)_row["CaptionTextID"].Value;
		public int IconID => (int)_row["IconID"].Value;
		public byte[] RequiredPropertyID => (byte[])_row["RequiredPropertyID"].Value;
		public byte[] CompareType => (byte[])_row["CompareType"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public byte[] FormatType => (byte[])_row["FormatType"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | CaptionTextID: {CaptionTextID} | IconID: {IconID}";
	}
}
