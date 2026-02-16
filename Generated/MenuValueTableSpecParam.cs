using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class MenuValueTableSpecParam
	{
		private readonly PARAM _param;
		public MenuValueTableSpecParam(PARAM param) => _param = param;
		public IEnumerable<MenuValueTableSpecParamRow> Entries => _param.Rows.Select(r => new MenuValueTableSpecParamRow(r));
	}
	public class MenuValueTableSpecParamRow
	{
		private readonly PARAM.Row _row;
		public MenuValueTableSpecParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int value => (int)_row["value"].Value;
		public int textId => (int)_row["textId"].Value;
		public byte compareType => (byte)_row["compareType"].Value;
		public byte[] padding => (byte[])_row["padding"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | value: {value} | textId: {textId} | compareType: {compareType}";
	}
}
