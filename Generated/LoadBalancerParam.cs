using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class LoadBalancerParam
	{
		private readonly PARAM _param;
		public LoadBalancerParam(PARAM param) => _param = param;
		public IEnumerable<LoadBalancerParamRow> Entries => _param.Rows.Select(r => new LoadBalancerParamRow(r));
	}
	public class LoadBalancerParamRow
	{
		private readonly PARAM.Row _row;
		public LoadBalancerParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float lowerFpsThreshold => (float)_row["lowerFpsThreshold"].Value;
		public float upperFpsThreshold => (float)_row["upperFpsThreshold"].Value;
		public uint lowerFpsContinousCount => (uint)_row["lowerFpsContinousCount"].Value;
		public uint upperFpsContinousCount => (uint)_row["upperFpsContinousCount"].Value;
		public uint downAfterChangeSleep => (uint)_row["downAfterChangeSleep"].Value;
		public uint upAfterChangeSleep => (uint)_row["upAfterChangeSleep"].Value;
		public byte postProcessLightShaft => (byte)_row["postProcessLightShaft"].Value;
		public byte postProcessBloom => (byte)_row["postProcessBloom"].Value;
		public byte postProcessGlow => (byte)_row["postProcessGlow"].Value;
		public byte postProcessAA => (byte)_row["postProcessAA"].Value;
		public byte postProcessSSAO => (byte)_row["postProcessSSAO"].Value;
		public byte postProcessDOF => (byte)_row["postProcessDOF"].Value;
		public byte postProcessMotionBlur => (byte)_row["postProcessMotionBlur"].Value;
		public byte postProcessMotionBlurIteration => (byte)_row["postProcessMotionBlurIteration"].Value;
		public byte[] reserve0 => (byte[])_row["reserve0"].Value;
		public byte shadowBlur => (byte)_row["shadowBlur"].Value;
		public byte sfxParticleHalf => (byte)_row["sfxParticleHalf"].Value;
		public byte sfxReflection => (byte)_row["sfxReflection"].Value;
		public byte sfxWaterInteraction => (byte)_row["sfxWaterInteraction"].Value;
		public byte sfxGlow => (byte)_row["sfxGlow"].Value;
		public byte sfxDistortion => (byte)_row["sfxDistortion"].Value;
		public byte sftSoftSprite => (byte)_row["sftSoftSprite"].Value;
		public byte sfxLightShaft => (byte)_row["sfxLightShaft"].Value;
		public byte sfxScaleRenderDistanceScale => (byte)_row["sfxScaleRenderDistanceScale"].Value;
		public byte dynamicResolution => (byte)_row["dynamicResolution"].Value;
		public byte shadowCascade0ResolutionHalf => (byte)_row["shadowCascade0ResolutionHalf"].Value;
		public byte shadowCascade1ResolutionHalf => (byte)_row["shadowCascade1ResolutionHalf"].Value;
		public byte chrWetDisablePlayer => (byte)_row["chrWetDisablePlayer"].Value;
		public byte chrWetDisableRemotePlayer => (byte)_row["chrWetDisableRemotePlayer"].Value;
		public byte chrWetDisableEnemy => (byte)_row["chrWetDisableEnemy"].Value;
		public byte dynamicResolutionPercentageMin => (byte)_row["dynamicResolutionPercentageMin"].Value;
		public byte dynamicResolutionPercentageMax => (byte)_row["dynamicResolutionPercentageMax"].Value;
		public byte[] reserve1 => (byte[])_row["reserve1"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | lowerFpsThreshold: {lowerFpsThreshold} | upperFpsThreshold: {upperFpsThreshold} | lowerFpsContinousCount: {lowerFpsContinousCount} | upperFpsContinousCount: {upperFpsContinousCount} | downAfterChangeSleep: {downAfterChangeSleep} | upAfterChangeSleep: {upAfterChangeSleep} | postProcessLightShaft: {postProcessLightShaft} | postProcessBloom: {postProcessBloom} | postProcessGlow: {postProcessGlow} | postProcessAA: {postProcessAA} | postProcessSSAO: {postProcessSSAO} | postProcessDOF: {postProcessDOF} | postProcessMotionBlur: {postProcessMotionBlur} | postProcessMotionBlurIteration: {postProcessMotionBlurIteration} | shadowBlur: {shadowBlur} | sfxParticleHalf: {sfxParticleHalf} | sfxReflection: {sfxReflection} | sfxWaterInteraction: {sfxWaterInteraction} | sfxGlow: {sfxGlow} | sfxDistortion: {sfxDistortion} | sftSoftSprite: {sftSoftSprite} | sfxLightShaft: {sfxLightShaft} | sfxScaleRenderDistanceScale: {sfxScaleRenderDistanceScale} | dynamicResolution: {dynamicResolution} | shadowCascade0ResolutionHalf: {shadowCascade0ResolutionHalf} | shadowCascade1ResolutionHalf: {shadowCascade1ResolutionHalf} | chrWetDisablePlayer: {chrWetDisablePlayer} | chrWetDisableRemotePlayer: {chrWetDisableRemotePlayer} | chrWetDisableEnemy: {chrWetDisableEnemy} | dynamicResolutionPercentageMin: {dynamicResolutionPercentageMin} | dynamicResolutionPercentageMax: {dynamicResolutionPercentageMax}";
	}
}
