using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class AutoCreateEnvSoundParam
	{
		private readonly PARAM _param;
		public AutoCreateEnvSoundParam(PARAM param) => _param = param;
		public IEnumerable<AutoCreateEnvSoundParamRow> Entries => _param.Rows.Select(r => new AutoCreateEnvSoundParamRow(r));
	}
	public class AutoCreateEnvSoundParamRow
	{
		private readonly PARAM.Row _row;
		public AutoCreateEnvSoundParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float RangeMin => (float)_row["RangeMin"].Value;
		public float RangeMax => (float)_row["RangeMax"].Value;
		public float LifeTimeMin => (float)_row["LifeTimeMin"].Value;
		public float LifeTimeMax => (float)_row["LifeTimeMax"].Value;
		public float DeleteDist => (float)_row["DeleteDist"].Value;
		public float NearDist => (float)_row["NearDist"].Value;
		public float LimiteRotateMin => (float)_row["LimiteRotateMin"].Value;
		public float LimiteRotateMax => (float)_row["LimiteRotateMax"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | RangeMin: {RangeMin} | RangeMax: {RangeMax} | LifeTimeMin: {LifeTimeMin} | LifeTimeMax: {LifeTimeMax} | DeleteDist: {DeleteDist} | NearDist: {NearDist} | LimiteRotateMin: {LimiteRotateMin} | LimiteRotateMax: {LimiteRotateMax}";
	}
}
