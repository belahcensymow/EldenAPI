using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class WetAspectParam
	{
		private readonly PARAM _param;
		public WetAspectParam(PARAM param) => _param = param;
		public IEnumerable<WetAspectParamRow> Entries => _param.Rows.Select(r => new WetAspectParamRow(r));
	}
	public class WetAspectParamRow
	{
		private readonly PARAM.Row _row;
		public WetAspectParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte baseColorR => (byte)_row["baseColorR"].Value;
		public byte baseColorG => (byte)_row["baseColorG"].Value;
		public byte baseColorB => (byte)_row["baseColorB"].Value;
		public byte[] reserve_0 => (byte[])_row["reserve_0"].Value;
		public float baseColorA => (float)_row["baseColorA"].Value;
		public byte metallic => (byte)_row["metallic"].Value;
		public byte[] reserve_1 => (byte[])_row["reserve_1"].Value;
		public byte[] reserve_2 => (byte[])_row["reserve_2"].Value;
		public byte[] reserve_3 => (byte[])_row["reserve_3"].Value;
		public float metallicRate => (float)_row["metallicRate"].Value;
		public float shininessRate => (float)_row["shininessRate"].Value;
		public byte shininess => (byte)_row["shininess"].Value;
		public byte[] reserve_4 => (byte[])_row["reserve_4"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | baseColorR: {baseColorR} | baseColorG: {baseColorG} | baseColorB: {baseColorB} | baseColorA: {baseColorA} | metallic: {metallic} | metallicRate: {metallicRate} | shininessRate: {shininessRate} | shininess: {shininess}";
	}
}
