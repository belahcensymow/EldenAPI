using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class SoundCommonIngameParam
	{
		private readonly PARAM _param;
		public SoundCommonIngameParam(PARAM param) => _param = param;
		public IEnumerable<SoundCommonIngameParamRow> Entries => _param.Rows.Select(r => new SoundCommonIngameParamRow(r));
	}
	public class SoundCommonIngameParamRow
	{
		private readonly PARAM.Row _row;
		public SoundCommonIngameParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public string ParamKeyStr => (string)_row["ParamKeyStr"].Value;
		public string ParamValueStr => (string)_row["ParamValueStr"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | ParamKeyStr: {ParamKeyStr} | ParamValueStr: {ParamValueStr}";
	}
}
