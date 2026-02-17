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
		public byte disableParam_NT => (byte)_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public uint EnableFastTravelEventFlagId => (uint)_row["EnableFastTravelEventFlagId"].Value;
		public int WeatherLotTimeOffsetIngameSeconds => (int)_row["WeatherLotTimeOffsetIngameSeconds"].Value;
		public sbyte WeatherCreateAssetLimitId => (sbyte)_row["WeatherCreateAssetLimitId"].Value;
		public byte MapAiSightType => (byte)_row["MapAiSightType"].Value;
		public byte SoundIndoorType => (byte)_row["SoundIndoorType"].Value;
		public SByte ReverbDefaultType => (SByte)_row["ReverbDefaultType"].Value;
		public Int16 BgmPlaceInfo => (Int16)_row["BgmPlaceInfo"].Value;
		public Int16 EnvPlaceInfo => (Int16)_row["EnvPlaceInfo"].Value;
		public int MapAdditionalSoundBankId => (int)_row["MapAdditionalSoundBankId"].Value;
		public short MapHeightForSound => (short)_row["MapHeightForSound"].Value;
		public byte IsEnableBlendTimezoneEnvmap => (byte)_row["IsEnableBlendTimezoneEnvmap"].Value;
		public SByte OverrideGIResolution_XSS => (SByte)_row["OverrideGIResolution_XSS"].Value;
		public float MapLoHiChangeBorderDist_XZ => (float)_row["MapLoHiChangeBorderDist_XZ"].Value;
		public float MapLoHiChangeBorderDist_Y => (float)_row["MapLoHiChangeBorderDist_Y"].Value;
		public float MapLoHiChangePlayDist => (float)_row["MapLoHiChangePlayDist"].Value;
		public uint MapAutoDrawGroupBackFacePixelNum => (uint)_row["MapAutoDrawGroupBackFacePixelNum"].Value;
		public float PlayerLigntScale => (float)_row["PlayerLigntScale"].Value;
		public byte IsEnableTimezonnePlayerLigntScale => (byte)_row["IsEnableTimezonnePlayerLigntScale"].Value;
		public byte isDisableAutoCliffWind => (byte)_row["isDisableAutoCliffWind"].Value;
		public short OpenChrActivateThreshold => (short)_row["OpenChrActivateThreshold"].Value;
		public int MapMimicryEstablishmentParamId => (int)_row["MapMimicryEstablishmentParamId"].Value;
		public SByte OverrideGIResolution_XSX => (SByte)_row["OverrideGIResolution_XSX"].Value;
		public byte[] Reserve => (byte[])_row["Reserve"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | disableParam_NT: {disableParam_NT} | EnableFastTravelEventFlagId: {EnableFastTravelEventFlagId} | WeatherLotTimeOffsetIngameSeconds: {WeatherLotTimeOffsetIngameSeconds} | WeatherCreateAssetLimitId: {WeatherCreateAssetLimitId} | MapAiSightType: {MapAiSightType} | SoundIndoorType: {SoundIndoorType} | ReverbDefaultType: {ReverbDefaultType} | BgmPlaceInfo: {BgmPlaceInfo} | EnvPlaceInfo: {EnvPlaceInfo} | MapAdditionalSoundBankId: {MapAdditionalSoundBankId} | MapHeightForSound: {MapHeightForSound} | IsEnableBlendTimezoneEnvmap: {IsEnableBlendTimezoneEnvmap} | OverrideGIResolution_XSS: {OverrideGIResolution_XSS} | MapLoHiChangeBorderDist_XZ: {MapLoHiChangeBorderDist_XZ} | MapLoHiChangeBorderDist_Y: {MapLoHiChangeBorderDist_Y} | MapLoHiChangePlayDist: {MapLoHiChangePlayDist} | MapAutoDrawGroupBackFacePixelNum: {MapAutoDrawGroupBackFacePixelNum} | PlayerLigntScale: {PlayerLigntScale} | IsEnableTimezonnePlayerLigntScale: {IsEnableTimezonnePlayerLigntScale} | isDisableAutoCliffWind: {isDisableAutoCliffWind} | OpenChrActivateThreshold: {OpenChrActivateThreshold} | MapMimicryEstablishmentParamId: {MapMimicryEstablishmentParamId} | OverrideGIResolution_XSX: {OverrideGIResolution_XSX}";
	}
}
