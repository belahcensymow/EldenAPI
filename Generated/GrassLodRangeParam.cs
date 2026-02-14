using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class GrassLodRangeParam
	{
		private readonly PARAM _param;
		public GrassLodRangeParam(PARAM param) => _param = param;
		public IEnumerable<GrassLodRangeParamRow> Entries => _param.Rows.Select(r => new GrassLodRangeParamRow(r));
	}
	public class GrassLodRangeParamRow
	{
		private readonly PARAM.Row _row;
		public GrassLodRangeParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float LOD0_range => (float)_row["LOD0_range"].Value;
		public float LOD0_play => (float)_row["LOD0_play"].Value;
		public float LOD1_range => (float)_row["LOD1_range"].Value;
		public float LOD1_play => (float)_row["LOD1_play"].Value;
		public float LOD2_range => (float)_row["LOD2_range"].Value;
		public float LOD2_play => (float)_row["LOD2_play"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | LOD0_range: {LOD0_range} | LOD0_play: {LOD0_play} | LOD1_range: {LOD1_range} | LOD1_play: {LOD1_play} | LOD2_range: {LOD2_range} | LOD2_play: {LOD2_play}";
	}
}
