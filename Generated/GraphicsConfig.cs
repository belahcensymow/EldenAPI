using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class GraphicsConfig
	{
		private readonly PARAM _param;
		public GraphicsConfig(PARAM param) => _param = param;
		public IEnumerable<GraphicsConfigRow> Entries => _param.Rows.Select(r => new GraphicsConfigRow(r));
	}
	public class GraphicsConfigRow
	{
		private readonly PARAM.Row _row;
		public GraphicsConfigRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte m_textureFilterQuality => (byte)_row["m_textureFilterQuality"].Value;
		public byte m_aaQuality => (byte)_row["m_aaQuality"].Value;
		public byte m_ssaoQuality => (byte)_row["m_ssaoQuality"].Value;
		public byte m_dofQuality => (byte)_row["m_dofQuality"].Value;
		public byte m_motionBlurQuality => (byte)_row["m_motionBlurQuality"].Value;
		public byte m_shadowQuality => (byte)_row["m_shadowQuality"].Value;
		public byte m_lightingQuality => (byte)_row["m_lightingQuality"].Value;
		public byte m_effectQuality => (byte)_row["m_effectQuality"].Value;
		public byte m_decalQuality => (byte)_row["m_decalQuality"].Value;
		public byte m_reflectionQuality => (byte)_row["m_reflectionQuality"].Value;
		public byte m_waterQuality => (byte)_row["m_waterQuality"].Value;
		public byte m_shaderQuality => (byte)_row["m_shaderQuality"].Value;
		public byte m_volumetricEffectQuality => (byte)_row["m_volumetricEffectQuality"].Value;
		public byte[] m_dummy => (byte[])_row["m_dummy"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | m_textureFilterQuality: {m_textureFilterQuality} | m_aaQuality: {m_aaQuality} | m_ssaoQuality: {m_ssaoQuality} | m_dofQuality: {m_dofQuality} | m_motionBlurQuality: {m_motionBlurQuality} | m_shadowQuality: {m_shadowQuality} | m_lightingQuality: {m_lightingQuality} | m_effectQuality: {m_effectQuality} | m_decalQuality: {m_decalQuality} | m_reflectionQuality: {m_reflectionQuality} | m_waterQuality: {m_waterQuality} | m_shaderQuality: {m_shaderQuality} | m_volumetricEffectQuality: {m_volumetricEffectQuality}";
	}
}
