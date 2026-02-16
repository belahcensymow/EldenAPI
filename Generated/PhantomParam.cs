using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class PhantomParam
	{
		private readonly PARAM _param;
		public PhantomParam(PARAM param) => _param = param;
		public IEnumerable<PhantomParamRow> Entries => _param.Rows.Select(r => new PhantomParamRow(r));
	}
	public class PhantomParamRow
	{
		private readonly PARAM.Row _row;
		public PhantomParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float edgeColorA => (float)_row["edgeColorA"].Value;
		public float frontColorA => (float)_row["frontColorA"].Value;
		public float diffMulColorA => (float)_row["diffMulColorA"].Value;
		public float specMulColorA => (float)_row["specMulColorA"].Value;
		public float lightColorA => (float)_row["lightColorA"].Value;
		public byte edgeColorR => (byte)_row["edgeColorR"].Value;
		public byte edgeColorG => (byte)_row["edgeColorG"].Value;
		public byte edgeColorB => (byte)_row["edgeColorB"].Value;
		public byte frontColorR => (byte)_row["frontColorR"].Value;
		public byte frontColorG => (byte)_row["frontColorG"].Value;
		public byte frontColorB => (byte)_row["frontColorB"].Value;
		public byte diffMulColorR => (byte)_row["diffMulColorR"].Value;
		public byte diffMulColorG => (byte)_row["diffMulColorG"].Value;
		public byte diffMulColorB => (byte)_row["diffMulColorB"].Value;
		public byte specMulColorR => (byte)_row["specMulColorR"].Value;
		public byte specMulColorG => (byte)_row["specMulColorG"].Value;
		public byte specMulColorB => (byte)_row["specMulColorB"].Value;
		public byte lightColorR => (byte)_row["lightColorR"].Value;
		public byte lightColorG => (byte)_row["lightColorG"].Value;
		public byte lightColorB => (byte)_row["lightColorB"].Value;
		public byte[] reserve => (byte[])_row["reserve"].Value;
		public float alpha => (float)_row["alpha"].Value;
		public float blendRate => (float)_row["blendRate"].Value;
		public byte blendType => (byte)_row["blendType"].Value;
		public byte isEdgeSubtract => (byte)_row["isEdgeSubtract"].Value;
		public byte isFrontSubtract => (byte)_row["isFrontSubtract"].Value;
		public byte isNo2Pass => (byte)_row["isNo2Pass"].Value;
		public float edgePower => (float)_row["edgePower"].Value;
		public float glowScale => (float)_row["glowScale"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | edgeColorA: {edgeColorA} | frontColorA: {frontColorA} | diffMulColorA: {diffMulColorA} | specMulColorA: {specMulColorA} | lightColorA: {lightColorA} | edgeColorR: {edgeColorR} | edgeColorG: {edgeColorG} | edgeColorB: {edgeColorB} | frontColorR: {frontColorR} | frontColorG: {frontColorG} | frontColorB: {frontColorB} | diffMulColorR: {diffMulColorR} | diffMulColorG: {diffMulColorG} | diffMulColorB: {diffMulColorB} | specMulColorR: {specMulColorR} | specMulColorG: {specMulColorG} | specMulColorB: {specMulColorB} | lightColorR: {lightColorR} | lightColorG: {lightColorG} | lightColorB: {lightColorB} | alpha: {alpha} | blendRate: {blendRate} | blendType: {blendType} | isEdgeSubtract: {isEdgeSubtract} | isFrontSubtract: {isFrontSubtract} | isNo2Pass: {isNo2Pass} | edgePower: {edgePower} | glowScale: {glowScale}";
	}
}
