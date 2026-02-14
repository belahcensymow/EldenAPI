using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class MapGridCreateHeightLimitInfo
	{
		private readonly PARAM _param;
		public MapGridCreateHeightLimitInfo(PARAM param) => _param = param;
		public IEnumerable<MapGridCreateHeightLimitInfoRow> Entries => _param.Rows.Select(r => new MapGridCreateHeightLimitInfoRow(r));
	}
	public class MapGridCreateHeightLimitInfoRow
	{
		private readonly PARAM.Row _row;
		public MapGridCreateHeightLimitInfoRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float GridEnableCreateHeightMin => (float)_row["GridEnableCreateHeightMin"].Value;
		public float GridEnableCreateHeightMax => (float)_row["GridEnableCreateHeightMax"].Value;
		public byte[] Reserve => (byte[])_row["Reserve"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | GridEnableCreateHeightMin: {GridEnableCreateHeightMin} | GridEnableCreateHeightMax: {GridEnableCreateHeightMax}";
	}
}
