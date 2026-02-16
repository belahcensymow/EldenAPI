using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class WeatherAssetCreateParam
	{
		private readonly PARAM _param;
		public WeatherAssetCreateParam(PARAM param) => _param = param;
		public IEnumerable<WeatherAssetCreateParamRow> Entries => _param.Rows.Select(r => new WeatherAssetCreateParamRow(r));
	}
	public class WeatherAssetCreateParamRow
	{
		private readonly PARAM.Row _row;
		public WeatherAssetCreateParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public uint AssetId => (uint)_row["AssetId"].Value;
		public uint SlotNo => (uint)_row["SlotNo"].Value;
		public byte CreateConditionType => (byte)_row["CreateConditionType"].Value;
		public byte[] padding0 => (byte[])_row["padding0"].Value;
		public byte TransitionSrcWeather => (byte)_row["TransitionSrcWeather"].Value;
		public byte TransitionDstWeather => (byte)_row["TransitionDstWeather"].Value;
		public byte ElapsedTimeCheckweather => (byte)_row["ElapsedTimeCheckweather"].Value;
		public byte[] padding1 => (byte[])_row["padding1"].Value;
		public float ElapsedTime => (float)_row["ElapsedTime"].Value;
		public float CreateDelayTime => (float)_row["CreateDelayTime"].Value;
		public uint CreateProbability => (uint)_row["CreateProbability"].Value;
		public float LifeTime => (float)_row["LifeTime"].Value;
		public float FadeTime => (float)_row["FadeTime"].Value;
		public float EnableCreateTimeMin => (float)_row["EnableCreateTimeMin"].Value;
		public float EnableCreateTimeMax => (float)_row["EnableCreateTimeMax"].Value;
		public short CreatePoint0 => (short)_row["CreatePoint0"].Value;
		public short CreatePoint1 => (short)_row["CreatePoint1"].Value;
		public short CreatePoint2 => (short)_row["CreatePoint2"].Value;
		public short CreatePoint3 => (short)_row["CreatePoint3"].Value;
		public sbyte CreateAssetLimitId0 => (sbyte)_row["CreateAssetLimitId0"].Value;
		public sbyte CreateAssetLimitId1 => (sbyte)_row["CreateAssetLimitId1"].Value;
		public sbyte CreateAssetLimitId2 => (sbyte)_row["CreateAssetLimitId2"].Value;
		public sbyte CreateAssetLimitId3 => (sbyte)_row["CreateAssetLimitId3"].Value;
		public byte[] Reserved2 => (byte[])_row["Reserved2"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | AssetId: {AssetId} | SlotNo: {SlotNo} | CreateConditionType: {CreateConditionType} | TransitionSrcWeather: {TransitionSrcWeather} | TransitionDstWeather: {TransitionDstWeather} | ElapsedTimeCheckweather: {ElapsedTimeCheckweather} | ElapsedTime: {ElapsedTime} | CreateDelayTime: {CreateDelayTime} | CreateProbability: {CreateProbability} | LifeTime: {LifeTime} | FadeTime: {FadeTime} | EnableCreateTimeMin: {EnableCreateTimeMin} | EnableCreateTimeMax: {EnableCreateTimeMax} | CreatePoint0: {CreatePoint0} | CreatePoint1: {CreatePoint1} | CreatePoint2: {CreatePoint2} | CreatePoint3: {CreatePoint3} | CreateAssetLimitId0: {CreateAssetLimitId0} | CreateAssetLimitId1: {CreateAssetLimitId1} | CreateAssetLimitId2: {CreateAssetLimitId2} | CreateAssetLimitId3: {CreateAssetLimitId3}";
	}
}
