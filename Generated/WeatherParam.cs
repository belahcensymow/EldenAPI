using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class WeatherParam
	{
		private readonly PARAM _param;
		public WeatherParam(PARAM param) => _param = param;
		public IEnumerable<WeatherParamRow> Entries => _param.Rows.Select(r => new WeatherParamRow(r));
	}
	public class WeatherParamRow
	{
		private readonly PARAM.Row _row;
		public WeatherParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int SfxId => (int)_row["SfxId"].Value;
		public int WindSfxId => (int)_row["WindSfxId"].Value;
		public int GroundHitSfxId => (int)_row["GroundHitSfxId"].Value;
		public int SoundId => (int)_row["SoundId"].Value;
		public float WetTime => (float)_row["WetTime"].Value;
		public uint GparamId => (uint)_row["GparamId"].Value;
		public uint NextLotIngameSecondsMin => (uint)_row["NextLotIngameSecondsMin"].Value;
		public uint NextLotIngameSecondsMax => (uint)_row["NextLotIngameSecondsMax"].Value;
		public int WetSpEffectId00 => (int)_row["WetSpEffectId00"].Value;
		public int WetSpEffectId01 => (int)_row["WetSpEffectId01"].Value;
		public int WetSpEffectId02 => (int)_row["WetSpEffectId02"].Value;
		public int WetSpEffectId03 => (int)_row["WetSpEffectId03"].Value;
		public int WetSpEffectId04 => (int)_row["WetSpEffectId04"].Value;
		public int SfxIdInoor => (int)_row["SfxIdInoor"].Value;
		public int SfxIdOutdoor => (int)_row["SfxIdOutdoor"].Value;
		public float aiSightRate => (float)_row["aiSightRate"].Value;
		public float DistViewWeatherGparamOverrideWeight => (float)_row["DistViewWeatherGparamOverrideWeight"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | SfxId: {SfxId} | WindSfxId: {WindSfxId} | GroundHitSfxId: {GroundHitSfxId} | SoundId: {SoundId} | WetTime: {WetTime} | GparamId: {GparamId} | NextLotIngameSecondsMin: {NextLotIngameSecondsMin} | NextLotIngameSecondsMax: {NextLotIngameSecondsMax} | WetSpEffectId00: {WetSpEffectId00} | WetSpEffectId01: {WetSpEffectId01} | WetSpEffectId02: {WetSpEffectId02} | WetSpEffectId03: {WetSpEffectId03} | WetSpEffectId04: {WetSpEffectId04} | SfxIdInoor: {SfxIdInoor} | SfxIdOutdoor: {SfxIdOutdoor} | aiSightRate: {aiSightRate} | DistViewWeatherGparamOverrideWeight: {DistViewWeatherGparamOverrideWeight}";
	}
}
