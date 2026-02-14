using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class MapDefaultInfoParam
	{
		private readonly PARAM _param;
		public MapDefaultInfoParam(PARAM param) => _param = param;
		public IEnumerable<MapDefaultInfoParamRow> Entries => _param.Rows.Select(r => new MapDefaultInfoParamRow(r));
	}
	public class MapDefaultInfoParamRow
	{
		private readonly PARAM.Row _row;
		public MapDefaultInfoParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] disableParam_NT => (byte[])_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public uint EnableFastTravelEventFlagId => (uint)_row["EnableFastTravelEventFlagId"].Value;
		public int WeatherLotTimeOffsetIngameSeconds => (int)_row["WeatherLotTimeOffsetIngameSeconds"].Value;
		public sbyte WeatherCreateAssetLimitId => (sbyte)_row["WeatherCreateAssetLimitId"].Value;
		public byte[] MapAiSightType => (byte[])_row["MapAiSightType"].Value;
		public byte[] SoundIndoorType => (byte[])_row["SoundIndoorType"].Value;
		public byte[] ReverbDefaultType => (byte[])_row["ReverbDefaultType"].Value;
		public byte[] BgmPlaceInfo => (byte[])_row["BgmPlaceInfo"].Value;
		public byte[] EnvPlaceInfo => (byte[])_row["EnvPlaceInfo"].Value;
		public int MapAdditionalSoundBankId => (int)_row["MapAdditionalSoundBankId"].Value;
		public short MapHeightForSound => (short)_row["MapHeightForSound"].Value;
		public byte[] IsEnableBlendTimezoneEnvmap => (byte[])_row["IsEnableBlendTimezoneEnvmap"].Value;
		public byte[] OverrideGIResolution_XSS => (byte[])_row["OverrideGIResolution_XSS"].Value;
		public float MapLoHiChangeBorderDist_XZ => (float)_row["MapLoHiChangeBorderDist_XZ"].Value;
		public float MapLoHiChangeBorderDist_Y => (float)_row["MapLoHiChangeBorderDist_Y"].Value;
		public float MapLoHiChangePlayDist => (float)_row["MapLoHiChangePlayDist"].Value;
		public uint MapAutoDrawGroupBackFacePixelNum => (uint)_row["MapAutoDrawGroupBackFacePixelNum"].Value;
		public float PlayerLigntScale => (float)_row["PlayerLigntScale"].Value;
		public byte[] IsEnableTimezonnePlayerLigntScale => (byte[])_row["IsEnableTimezonnePlayerLigntScale"].Value;
		public byte[] isDisableAutoCliffWind => (byte[])_row["isDisableAutoCliffWind"].Value;
		public short OpenChrActivateThreshold => (short)_row["OpenChrActivateThreshold"].Value;
		public int MapMimicryEstablishmentParamId => (int)_row["MapMimicryEstablishmentParamId"].Value;
		public byte[] OverrideGIResolution_XSX => (byte[])_row["OverrideGIResolution_XSX"].Value;
		public byte[] Reserve => (byte[])_row["Reserve"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | EnableFastTravelEventFlagId: {EnableFastTravelEventFlagId} | WeatherLotTimeOffsetIngameSeconds: {WeatherLotTimeOffsetIngameSeconds} | WeatherCreateAssetLimitId: {WeatherCreateAssetLimitId} | MapAdditionalSoundBankId: {MapAdditionalSoundBankId} | MapHeightForSound: {MapHeightForSound} | MapLoHiChangeBorderDist_XZ: {MapLoHiChangeBorderDist_XZ} | MapLoHiChangeBorderDist_Y: {MapLoHiChangeBorderDist_Y} | MapLoHiChangePlayDist: {MapLoHiChangePlayDist} | MapAutoDrawGroupBackFacePixelNum: {MapAutoDrawGroupBackFacePixelNum} | PlayerLigntScale: {PlayerLigntScale} | OpenChrActivateThreshold: {OpenChrActivateThreshold} | MapMimicryEstablishmentParamId: {MapMimicryEstablishmentParamId}";
	}
}
