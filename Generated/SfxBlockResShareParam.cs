using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class SfxBlockResShareParam
	{
		private readonly PARAM _param;
		public SfxBlockResShareParam(PARAM param) => _param = param;
		public IEnumerable<SfxBlockResShareParamRow> Entries => _param.Rows.Select(r => new SfxBlockResShareParamRow(r));
	}
	public class SfxBlockResShareParamRow
	{
		private readonly PARAM.Row _row;
		public SfxBlockResShareParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public uint shareBlockRsMapUidVal => (uint)_row["shareBlockRsMapUidVal"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | shareBlockRsMapUidVal: {shareBlockRsMapUidVal}";
	}
}
