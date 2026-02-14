using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class SpEffectSetParam
	{
		private readonly PARAM _param;
		public SpEffectSetParam(PARAM param) => _param = param;
		public IEnumerable<SpEffectSetParamRow> Entries => _param.Rows.Select(r => new SpEffectSetParamRow(r));
	}
	public class SpEffectSetParamRow
	{
		private readonly PARAM.Row _row;
		public SpEffectSetParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int spEffectId1 => (int)_row["spEffectId1"].Value;
		public int spEffectId2 => (int)_row["spEffectId2"].Value;
		public int spEffectId3 => (int)_row["spEffectId3"].Value;
		public int spEffectId4 => (int)_row["spEffectId4"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | spEffectId1: {spEffectId1} | spEffectId2: {spEffectId2} | spEffectId3: {spEffectId3} | spEffectId4: {spEffectId4}";
	}
}
