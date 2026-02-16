using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class WaypointParam
	{
		private readonly PARAM _param;
		public WaypointParam(PARAM param) => _param = param;
		public IEnumerable<WaypointParamRow> Entries => _param.Rows.Select(r => new WaypointParamRow(r));
	}
	public class WaypointParamRow
	{
		private readonly PARAM.Row _row;
		public WaypointParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte attribute1 => (byte)_row["attribute1"].Value;
		public byte attribute2 => (byte)_row["attribute2"].Value;
		public byte attribute3 => (byte)_row["attribute3"].Value;
		public byte attribute4 => (byte)_row["attribute4"].Value;
		public byte[] padding4 => (byte[])_row["padding4"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | attribute1: {attribute1} | attribute2: {attribute2} | attribute3: {attribute3} | attribute4: {attribute4}";
	}
}
