using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class CutsceneTimezoneConvertParam
	{
		private readonly PARAM _param;
		public CutsceneTimezoneConvertParam(PARAM param) => _param = param;
		public IEnumerable<CutsceneTimezoneConvertParamRow> Entries => _param.Rows.Select(r => new CutsceneTimezoneConvertParamRow(r));
	}
	public class CutsceneTimezoneConvertParamRow
	{
		private readonly PARAM.Row _row;
		public CutsceneTimezoneConvertParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float SrcTimezoneStart => (float)_row["SrcTimezoneStart"].Value;
		public float DstCutscenTime => (float)_row["DstCutscenTime"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | SrcTimezoneStart: {SrcTimezoneStart} | DstCutscenTime: {DstCutscenTime}";
	}
}
