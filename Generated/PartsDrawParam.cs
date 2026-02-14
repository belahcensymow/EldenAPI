using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class PartsDrawParam
	{
		private readonly PARAM _param;
		public PartsDrawParam(PARAM param) => _param = param;
		public IEnumerable<PartsDrawParamRow> Entries => _param.Rows.Select(r => new PartsDrawParamRow(r));
	}
	public class PartsDrawParamRow
	{
		private readonly PARAM.Row _row;
		public PartsDrawParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float lv01_BorderDist => (float)_row["lv01_BorderDist"].Value;
		public float lv01_PlayDist => (float)_row["lv01_PlayDist"].Value;
		public float lv12_BorderDist => (float)_row["lv12_BorderDist"].Value;
		public float lv12_PlayDist => (float)_row["lv12_PlayDist"].Value;
		public float lv23_BorderDist => (float)_row["lv23_BorderDist"].Value;
		public float lv23_PlayDist => (float)_row["lv23_PlayDist"].Value;
		public float lv34_BorderDist => (float)_row["lv34_BorderDist"].Value;
		public float lv34_PlayDist => (float)_row["lv34_PlayDist"].Value;
		public float lv45_BorderDist => (float)_row["lv45_BorderDist"].Value;
		public float lv45_PlayDist => (float)_row["lv45_PlayDist"].Value;
		public float tex_lv01_BorderDist => (float)_row["tex_lv01_BorderDist"].Value;
		public float tex_lv01_PlayDist => (float)_row["tex_lv01_PlayDist"].Value;
		public uint enableCrossFade => (uint)_row["enableCrossFade"].Value;
		public float drawDist => (float)_row["drawDist"].Value;
		public float drawFadeRange => (float)_row["drawFadeRange"].Value;
		public float shadowDrawDist => (float)_row["shadowDrawDist"].Value;
		public float shadowFadeRange => (float)_row["shadowFadeRange"].Value;
		public float motionBlur_BorderDist => (float)_row["motionBlur_BorderDist"].Value;
		public sbyte isPointLightShadowSrc => (sbyte)_row["isPointLightShadowSrc"].Value;
		public sbyte isDirLightShadowSrc => (sbyte)_row["isDirLightShadowSrc"].Value;
		public sbyte isShadowDst => (sbyte)_row["isShadowDst"].Value;
		public sbyte isShadowOnly => (sbyte)_row["isShadowOnly"].Value;
		public sbyte drawByReflectCam => (sbyte)_row["drawByReflectCam"].Value;
		public sbyte drawOnlyReflectCam => (sbyte)_row["drawOnlyReflectCam"].Value;
		public sbyte IncludeLodMapLv => (sbyte)_row["IncludeLodMapLv"].Value;
		public byte isNoFarClipDraw => (byte)_row["isNoFarClipDraw"].Value;
		public byte[] lodType => (byte[])_row["lodType"].Value;
		public sbyte shadowDrawLodOffset => (sbyte)_row["shadowDrawLodOffset"].Value;
		public byte isTraceCameraXZ => (byte)_row["isTraceCameraXZ"].Value;
		public byte isSkydomeDrawPhase => (byte)_row["isSkydomeDrawPhase"].Value;
		public float DistantViewModel_BorderDist => (float)_row["DistantViewModel_BorderDist"].Value;
		public float DistantViewModel_PlayDist => (float)_row["DistantViewModel_PlayDist"].Value;
		public float LimtedActivate_BorderDist_forGrid => (float)_row["LimtedActivate_BorderDist_forGrid"].Value;
		public float LimtedActivate_PlayDist_forGrid => (float)_row["LimtedActivate_PlayDist_forGrid"].Value;
		public float zSortOffsetForNoFarClipDraw => (float)_row["zSortOffsetForNoFarClipDraw"].Value;
		public float shadowDrawAlphaTestDist => (float)_row["shadowDrawAlphaTestDist"].Value;
		public byte[] fowardDrawEnvmapBlendType => (byte[])_row["fowardDrawEnvmapBlendType"].Value;
		public byte LBDrawDistScaleParamID => (byte)_row["LBDrawDistScaleParamID"].Value;
		public byte[] resereve => (byte[])_row["resereve"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | lv01_BorderDist: {lv01_BorderDist} | lv01_PlayDist: {lv01_PlayDist} | lv12_BorderDist: {lv12_BorderDist} | lv12_PlayDist: {lv12_PlayDist} | lv23_BorderDist: {lv23_BorderDist} | lv23_PlayDist: {lv23_PlayDist} | lv34_BorderDist: {lv34_BorderDist} | lv34_PlayDist: {lv34_PlayDist} | lv45_BorderDist: {lv45_BorderDist} | lv45_PlayDist: {lv45_PlayDist} | tex_lv01_BorderDist: {tex_lv01_BorderDist} | tex_lv01_PlayDist: {tex_lv01_PlayDist} | enableCrossFade: {enableCrossFade} | drawDist: {drawDist} | drawFadeRange: {drawFadeRange} | shadowDrawDist: {shadowDrawDist} | shadowFadeRange: {shadowFadeRange} | motionBlur_BorderDist: {motionBlur_BorderDist} | isPointLightShadowSrc: {isPointLightShadowSrc} | isDirLightShadowSrc: {isDirLightShadowSrc} | isShadowDst: {isShadowDst} | isShadowOnly: {isShadowOnly} | drawByReflectCam: {drawByReflectCam} | drawOnlyReflectCam: {drawOnlyReflectCam} | IncludeLodMapLv: {IncludeLodMapLv} | isNoFarClipDraw: {isNoFarClipDraw} | shadowDrawLodOffset: {shadowDrawLodOffset} | isTraceCameraXZ: {isTraceCameraXZ} | isSkydomeDrawPhase: {isSkydomeDrawPhase} | DistantViewModel_BorderDist: {DistantViewModel_BorderDist} | DistantViewModel_PlayDist: {DistantViewModel_PlayDist} | LimtedActivate_BorderDist_forGrid: {LimtedActivate_BorderDist_forGrid} | LimtedActivate_PlayDist_forGrid: {LimtedActivate_PlayDist_forGrid} | zSortOffsetForNoFarClipDraw: {zSortOffsetForNoFarClipDraw} | shadowDrawAlphaTestDist: {shadowDrawAlphaTestDist} | LBDrawDistScaleParamID: {LBDrawDistScaleParamID}";
	}
}
