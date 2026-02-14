using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class CutsceneWeatherOverrideGparamIdConvertParam
	{
		private readonly PARAM _param;
		public CutsceneWeatherOverrideGparamIdConvertParam(PARAM param) => _param = param;
		public IEnumerable<CutsceneWeatherOverrideGparamIdConvertParamRow> Entries => _param.Rows.Select(r => new CutsceneWeatherOverrideGparamIdConvertParamRow(r));
	}
	public class CutsceneWeatherOverrideGparamIdConvertParamRow
	{
		private readonly PARAM.Row _row;
		public CutsceneWeatherOverrideGparamIdConvertParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public uint weatherOverrideGparamId => (uint)_row["weatherOverrideGparamId"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | weatherOverrideGparamId: {weatherOverrideGparamId}";
	}
}
