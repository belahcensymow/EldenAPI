using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class MenuPropertyLayoutParam
	{
		private readonly PARAM _param;
		public MenuPropertyLayoutParam(PARAM param) => _param = param;
		public IEnumerable<MenuPropertyLayoutParamRow> Entries => _param.Rows.Select(r => new MenuPropertyLayoutParamRow(r));
	}
	public class MenuPropertyLayoutParamRow
	{
		private readonly PARAM.Row _row;
		public MenuPropertyLayoutParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public string LayoutPath => (string)_row["LayoutPath"].Value;
		public byte PropertyID => (byte)_row["PropertyID"].Value;
		public int CaptionTextID => (int)_row["CaptionTextID"].Value;
		public int HelpTextID => (int)_row["HelpTextID"].Value;
		public byte[] reserved => (byte[])_row["reserved"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | LayoutPath: {LayoutPath} | PropertyID: {PropertyID} | CaptionTextID: {CaptionTextID} | HelpTextID: {HelpTextID}";
	}
}
