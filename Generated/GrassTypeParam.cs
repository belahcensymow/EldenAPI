using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class GrassTypeParam
	{
		private readonly PARAM _param;
		public GrassTypeParam(PARAM param) => _param = param;
		public IEnumerable<GrassTypeParamRow> Entries => _param.Rows.Select(r => new GrassTypeParamRow(r));
	}
	public class GrassTypeParamRow
	{
		private readonly PARAM.Row _row;
		public GrassTypeParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public ushort lodRange => (ushort)_row["lodRange"].Value;
		public byte[] lod0ClusterType => (byte[])_row["lod0ClusterType"].Value;
		public byte[] lod1ClusterType => (byte[])_row["lod1ClusterType"].Value;
		public byte[] lod2ClusterType => (byte[])_row["lod2ClusterType"].Value;
		public byte[] pad0 => (byte[])_row["pad0"].Value;
		public byte[] distributionType => (byte[])_row["distributionType"].Value;
		public float baseDensity => (float)_row["baseDensity"].Value;
		public string model0Name => (string)_row["model0Name"].Value;
		public string flatTextureName => (string)_row["flatTextureName"].Value;
		public string billboardTextureName => (string)_row["billboardTextureName"].Value;
		public byte normalInfluence => (byte)_row["normalInfluence"].Value;
		public byte inclinationMax => (byte)_row["inclinationMax"].Value;
		public byte inclinationJitter => (byte)_row["inclinationJitter"].Value;
		public byte scaleBaseMin => (byte)_row["scaleBaseMin"].Value;
		public byte scaleBaseMax => (byte)_row["scaleBaseMax"].Value;
		public byte scaleHeightMin => (byte)_row["scaleHeightMin"].Value;
		public byte scaleHeightMax => (byte)_row["scaleHeightMax"].Value;
		public byte colorShade1_r => (byte)_row["colorShade1_r"].Value;
		public byte colorShade1_g => (byte)_row["colorShade1_g"].Value;
		public byte colorShade1_b => (byte)_row["colorShade1_b"].Value;
		public byte colorShade2_r => (byte)_row["colorShade2_r"].Value;
		public byte colorShade2_g => (byte)_row["colorShade2_g"].Value;
		public byte colorShade2_b => (byte)_row["colorShade2_b"].Value;
		public byte[] flatSplitType => (byte[])_row["flatSplitType"].Value;
		public byte flatBladeCount => (byte)_row["flatBladeCount"].Value;
		public sbyte flatSlant => (sbyte)_row["flatSlant"].Value;
		public float flatRadius => (float)_row["flatRadius"].Value;
		public byte[] castShadow => (byte[])_row["castShadow"].Value;
		public byte windAmplitude => (byte)_row["windAmplitude"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public byte windCycle => (byte)_row["windCycle"].Value;
		public float orientationAngle => (float)_row["orientationAngle"].Value;
		public float orientationRange => (float)_row["orientationRange"].Value;
		public float spacing => (float)_row["spacing"].Value;
		public byte[] dithering => (byte[])_row["dithering"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public string simpleModelName => (string)_row["simpleModelName"].Value;
		public string model1Name => (string)_row["model1Name"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | lodRange: {lodRange} | baseDensity: {baseDensity} | model0Name: {model0Name} | flatTextureName: {flatTextureName} | billboardTextureName: {billboardTextureName} | normalInfluence: {normalInfluence} | inclinationMax: {inclinationMax} | inclinationJitter: {inclinationJitter} | scaleBaseMin: {scaleBaseMin} | scaleBaseMax: {scaleBaseMax} | scaleHeightMin: {scaleHeightMin} | scaleHeightMax: {scaleHeightMax} | colorShade1_r: {colorShade1_r} | colorShade1_g: {colorShade1_g} | colorShade1_b: {colorShade1_b} | colorShade2_r: {colorShade2_r} | colorShade2_g: {colorShade2_g} | colorShade2_b: {colorShade2_b} | flatBladeCount: {flatBladeCount} | flatSlant: {flatSlant} | flatRadius: {flatRadius} | windAmplitude: {windAmplitude} | windCycle: {windCycle} | orientationAngle: {orientationAngle} | orientationRange: {orientationRange} | spacing: {spacing} | simpleModelName: {simpleModelName} | model1Name: {model1Name}";
	}
}
