using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class SeActivationRangeParam
	{
		private readonly PARAM _param;
		public SeActivationRangeParam(PARAM param) => _param = param;
		public IEnumerable<SeActivationRangeParamRow> Entries => _param.Rows.Select(r => new SeActivationRangeParamRow(r));
	}
	public class SeActivationRangeParamRow
	{
		private readonly PARAM.Row _row;
		public SeActivationRangeParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float activateRange => (float)_row["activateRange"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | activateRange: {activateRange}";
	}
}
