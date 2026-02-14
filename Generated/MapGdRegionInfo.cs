using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class MapGdRegionInfo
	{
		private readonly PARAM _param;
		public MapGdRegionInfo(PARAM param) => _param = param;
		public IEnumerable<MapGdRegionInfoRow> Entries => _param.Rows.Select(r => new MapGdRegionInfoRow(r));
	}
	public class MapGdRegionInfoRow
	{
		private readonly PARAM.Row _row;
		public MapGdRegionInfoRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] disableParam_NT => (byte[])_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public uint mapRegionId => (uint)_row["mapRegionId"].Value;
		public byte[] Reserve => (byte[])_row["Reserve"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | mapRegionId: {mapRegionId}";
	}
}
