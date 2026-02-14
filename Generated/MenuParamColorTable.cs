using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class MenuParamColorTable
	{
		private readonly PARAM _param;
		public MenuParamColorTable(PARAM param) => _param = param;
		public IEnumerable<MenuParamColorTableRow> Entries => _param.Rows.Select(r => new MenuParamColorTableRow(r));
	}
	public class MenuParamColorTableRow
	{
		private readonly PARAM.Row _row;
		public MenuParamColorTableRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] lerpMode => (byte[])_row["lerpMode"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public ushort h => (ushort)_row["h"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public float s1 => (float)_row["s1"].Value;
		public float v1 => (float)_row["v1"].Value;
		public float s2 => (float)_row["s2"].Value;
		public float v2 => (float)_row["v2"].Value;
		public float s3 => (float)_row["s3"].Value;
		public float v3 => (float)_row["v3"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | h: {h} | s1: {s1} | v1: {v1} | s2: {s2} | v2: {v2} | s3: {s3} | v3: {v3}";
	}
}
