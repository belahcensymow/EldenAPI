using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class MapGdRegionDrawParam
	{
		private readonly PARAM _param;
		public MapGdRegionDrawParam(PARAM param) => _param = param;
		public IEnumerable<MapGdRegionDrawParamRow> Entries => _param.Rows.Select(r => new MapGdRegionDrawParamRow(r));
	}
	public class MapGdRegionDrawParamRow
	{
		private readonly PARAM.Row _row;
		public MapGdRegionDrawParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte disableParam_NT => (byte)_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public float overrideIVLocalLightScale => (float)_row["overrideIVLocalLightScale"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | disableParam_NT: {disableParam_NT} | overrideIVLocalLightScale: {overrideIVLocalLightScale}";
	}
}
