using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class CutsceneGparamWeatherParam
	{
		private readonly PARAM _param;
		public CutsceneGparamWeatherParam(PARAM param) => _param = param;
		public IEnumerable<CutsceneGparamWeatherParamRow> Entries => _param.Rows.Select(r => new CutsceneGparamWeatherParamRow(r));
	}
	public class CutsceneGparamWeatherParamRow
	{
		private readonly PARAM.Row _row;
		public CutsceneGparamWeatherParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte disableParam_NT => (byte)_row["disableParam_NT"].Value;
		public byte disableParam_Debug => (byte)_row["disableParam_Debug"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public byte DstWeather_Sunny => (byte)_row["DstWeather_Sunny"].Value;
		public byte DstWeather_ClearSky => (byte)_row["DstWeather_ClearSky"].Value;
		public byte DstWeather_WeakCloudy => (byte)_row["DstWeather_WeakCloudy"].Value;
		public byte DstWeather_Cloud => (byte)_row["DstWeather_Cloud"].Value;
		public byte DstWeather_Rain => (byte)_row["DstWeather_Rain"].Value;
		public byte DstWeather_HeavyRain => (byte)_row["DstWeather_HeavyRain"].Value;
		public byte DstWeather_Storm => (byte)_row["DstWeather_Storm"].Value;
		public byte DstWeather_StormForBattle => (byte)_row["DstWeather_StormForBattle"].Value;
		public byte DstWeather_Snow => (byte)_row["DstWeather_Snow"].Value;
		public byte DstWeather_HeavySnow => (byte)_row["DstWeather_HeavySnow"].Value;
		public byte DstWeather_Fog => (byte)_row["DstWeather_Fog"].Value;
		public byte DstWeather_HeavyFog => (byte)_row["DstWeather_HeavyFog"].Value;
		public byte DstWeather_SandStorm => (byte)_row["DstWeather_SandStorm"].Value;
		public byte DstWeather_HeavyFogRain => (byte)_row["DstWeather_HeavyFogRain"].Value;
		public byte PostPlayIngameWeather => (byte)_row["PostPlayIngameWeather"].Value;
		public byte IndoorOutdoorType => (byte)_row["IndoorOutdoorType"].Value;
		public byte TakeOverDstWeather_Sunny => (byte)_row["TakeOverDstWeather_Sunny"].Value;
		public byte TakeOverDstWeather_ClearSky => (byte)_row["TakeOverDstWeather_ClearSky"].Value;
		public byte TakeOverDstWeather_WeakCloudy => (byte)_row["TakeOverDstWeather_WeakCloudy"].Value;
		public byte TakeOverDstWeather_Cloud => (byte)_row["TakeOverDstWeather_Cloud"].Value;
		public byte TakeOverDstWeather_Rain => (byte)_row["TakeOverDstWeather_Rain"].Value;
		public byte TakeOverDstWeather_HeavyRain => (byte)_row["TakeOverDstWeather_HeavyRain"].Value;
		public byte TakeOverDstWeather_Storm => (byte)_row["TakeOverDstWeather_Storm"].Value;
		public byte TakeOverDstWeather_StormForBattle => (byte)_row["TakeOverDstWeather_StormForBattle"].Value;
		public byte TakeOverDstWeather_Snow => (byte)_row["TakeOverDstWeather_Snow"].Value;
		public byte TakeOverDstWeather_HeavySnow => (byte)_row["TakeOverDstWeather_HeavySnow"].Value;
		public byte TakeOverDstWeather_Fog => (byte)_row["TakeOverDstWeather_Fog"].Value;
		public byte TakeOverDstWeather_HeavyFog => (byte)_row["TakeOverDstWeather_HeavyFog"].Value;
		public byte TakeOverDstWeather_SandStorm => (byte)_row["TakeOverDstWeather_SandStorm"].Value;
		public byte TakeOverDstWeather_HeavyFogRain => (byte)_row["TakeOverDstWeather_HeavyFogRain"].Value;
		public byte[] reserved => (byte[])_row["reserved"].Value;
		public byte DstWeather_Snowstorm => (byte)_row["DstWeather_Snowstorm"].Value;
		public byte DstWeather_LightningStorm => (byte)_row["DstWeather_LightningStorm"].Value;
		public byte DstWeather_Reserved3 => (byte)_row["DstWeather_Reserved3"].Value;
		public byte DstWeather_Reserved4 => (byte)_row["DstWeather_Reserved4"].Value;
		public byte DstWeather_Reserved5 => (byte)_row["DstWeather_Reserved5"].Value;
		public byte DstWeather_Reserved6 => (byte)_row["DstWeather_Reserved6"].Value;
		public byte DstWeather_Reserved7 => (byte)_row["DstWeather_Reserved7"].Value;
		public byte DstWeather_Reserved8 => (byte)_row["DstWeather_Reserved8"].Value;
		public byte TakeOverDstWeather_Snowstorm => (byte)_row["TakeOverDstWeather_Snowstorm"].Value;
		public byte TakeOverDstWeather_LightningStorm => (byte)_row["TakeOverDstWeather_LightningStorm"].Value;
		public byte TakeOverDstWeather_Reserved3 => (byte)_row["TakeOverDstWeather_Reserved3"].Value;
		public byte TakeOverDstWeather_Reserved4 => (byte)_row["TakeOverDstWeather_Reserved4"].Value;
		public byte TakeOverDstWeather_Reserved5 => (byte)_row["TakeOverDstWeather_Reserved5"].Value;
		public byte TakeOverDstWeather_Reserved6 => (byte)_row["TakeOverDstWeather_Reserved6"].Value;
		public byte TakeOverDstWeather_Reserved7 => (byte)_row["TakeOverDstWeather_Reserved7"].Value;
		public byte TakeOverDstWeather_Reserved8 => (byte)_row["TakeOverDstWeather_Reserved8"].Value;
		public byte IsEnableApplyMapGdRegionIdForGparam => (byte)_row["IsEnableApplyMapGdRegionIdForGparam"].Value;
		public byte[] reserved2 => (byte[])_row["reserved2"].Value;
		public short OverrideMapGdRegionId => (short)_row["OverrideMapGdRegionId"].Value;
		public byte[] reserved1 => (byte[])_row["reserved1"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | disableParam_NT: {disableParam_NT} | disableParam_Debug: {disableParam_Debug} | DstWeather_Sunny: {DstWeather_Sunny} | DstWeather_ClearSky: {DstWeather_ClearSky} | DstWeather_WeakCloudy: {DstWeather_WeakCloudy} | DstWeather_Cloud: {DstWeather_Cloud} | DstWeather_Rain: {DstWeather_Rain} | DstWeather_HeavyRain: {DstWeather_HeavyRain} | DstWeather_Storm: {DstWeather_Storm} | DstWeather_StormForBattle: {DstWeather_StormForBattle} | DstWeather_Snow: {DstWeather_Snow} | DstWeather_HeavySnow: {DstWeather_HeavySnow} | DstWeather_Fog: {DstWeather_Fog} | DstWeather_HeavyFog: {DstWeather_HeavyFog} | DstWeather_SandStorm: {DstWeather_SandStorm} | DstWeather_HeavyFogRain: {DstWeather_HeavyFogRain} | PostPlayIngameWeather: {PostPlayIngameWeather} | IndoorOutdoorType: {IndoorOutdoorType} | TakeOverDstWeather_Sunny: {TakeOverDstWeather_Sunny} | TakeOverDstWeather_ClearSky: {TakeOverDstWeather_ClearSky} | TakeOverDstWeather_WeakCloudy: {TakeOverDstWeather_WeakCloudy} | TakeOverDstWeather_Cloud: {TakeOverDstWeather_Cloud} | TakeOverDstWeather_Rain: {TakeOverDstWeather_Rain} | TakeOverDstWeather_HeavyRain: {TakeOverDstWeather_HeavyRain} | TakeOverDstWeather_Storm: {TakeOverDstWeather_Storm} | TakeOverDstWeather_StormForBattle: {TakeOverDstWeather_StormForBattle} | TakeOverDstWeather_Snow: {TakeOverDstWeather_Snow} | TakeOverDstWeather_HeavySnow: {TakeOverDstWeather_HeavySnow} | TakeOverDstWeather_Fog: {TakeOverDstWeather_Fog} | TakeOverDstWeather_HeavyFog: {TakeOverDstWeather_HeavyFog} | TakeOverDstWeather_SandStorm: {TakeOverDstWeather_SandStorm} | TakeOverDstWeather_HeavyFogRain: {TakeOverDstWeather_HeavyFogRain} | DstWeather_Snowstorm: {DstWeather_Snowstorm} | DstWeather_LightningStorm: {DstWeather_LightningStorm} | DstWeather_Reserved3: {DstWeather_Reserved3} | DstWeather_Reserved4: {DstWeather_Reserved4} | DstWeather_Reserved5: {DstWeather_Reserved5} | DstWeather_Reserved6: {DstWeather_Reserved6} | DstWeather_Reserved7: {DstWeather_Reserved7} | DstWeather_Reserved8: {DstWeather_Reserved8} | TakeOverDstWeather_Snowstorm: {TakeOverDstWeather_Snowstorm} | TakeOverDstWeather_LightningStorm: {TakeOverDstWeather_LightningStorm} | TakeOverDstWeather_Reserved3: {TakeOverDstWeather_Reserved3} | TakeOverDstWeather_Reserved4: {TakeOverDstWeather_Reserved4} | TakeOverDstWeather_Reserved5: {TakeOverDstWeather_Reserved5} | TakeOverDstWeather_Reserved6: {TakeOverDstWeather_Reserved6} | TakeOverDstWeather_Reserved7: {TakeOverDstWeather_Reserved7} | TakeOverDstWeather_Reserved8: {TakeOverDstWeather_Reserved8} | IsEnableApplyMapGdRegionIdForGparam: {IsEnableApplyMapGdRegionIdForGparam} | OverrideMapGdRegionId: {OverrideMapGdRegionId}";
	}
}
