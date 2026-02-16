using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class ChrActivateConditionParam
	{
		private readonly PARAM _param;
		public ChrActivateConditionParam(PARAM param) => _param = param;
		public IEnumerable<ChrActivateConditionParamRow> Entries => _param.Rows.Select(r => new ChrActivateConditionParamRow(r));
	}
	public class ChrActivateConditionParamRow
	{
		private readonly PARAM.Row _row;
		public ChrActivateConditionParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte weatherSunny => (byte)_row["weatherSunny"].Value;
		public byte weatherClearSky => (byte)_row["weatherClearSky"].Value;
		public byte weatherWeakCloudy => (byte)_row["weatherWeakCloudy"].Value;
		public byte weatherCloudy => (byte)_row["weatherCloudy"].Value;
		public byte weatherRain => (byte)_row["weatherRain"].Value;
		public byte weatherHeavyRain => (byte)_row["weatherHeavyRain"].Value;
		public byte weatherStorm => (byte)_row["weatherStorm"].Value;
		public byte weatherStormForBattle => (byte)_row["weatherStormForBattle"].Value;
		public byte weatherSnow => (byte)_row["weatherSnow"].Value;
		public byte weatherHeavySnow => (byte)_row["weatherHeavySnow"].Value;
		public byte weatherFog => (byte)_row["weatherFog"].Value;
		public byte weatherHeavyFog => (byte)_row["weatherHeavyFog"].Value;
		public byte weatherHeavyFogRain => (byte)_row["weatherHeavyFogRain"].Value;
		public byte weatherSandStorm => (byte)_row["weatherSandStorm"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public byte timeStartHour => (byte)_row["timeStartHour"].Value;
		public byte timeStartMin => (byte)_row["timeStartMin"].Value;
		public byte timeEndHour => (byte)_row["timeEndHour"].Value;
		public byte timeEndMin => (byte)_row["timeEndMin"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | weatherSunny: {weatherSunny} | weatherClearSky: {weatherClearSky} | weatherWeakCloudy: {weatherWeakCloudy} | weatherCloudy: {weatherCloudy} | weatherRain: {weatherRain} | weatherHeavyRain: {weatherHeavyRain} | weatherStorm: {weatherStorm} | weatherStormForBattle: {weatherStormForBattle} | weatherSnow: {weatherSnow} | weatherHeavySnow: {weatherHeavySnow} | weatherFog: {weatherFog} | weatherHeavyFog: {weatherHeavyFog} | weatherHeavyFogRain: {weatherHeavyFogRain} | weatherSandStorm: {weatherSandStorm} | timeStartHour: {timeStartHour} | timeStartMin: {timeStartMin} | timeEndHour: {timeEndHour} | timeEndMin: {timeEndMin}";
	}
}
