using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class FeTextEffectParam
	{
		private readonly PARAM _param;
		public FeTextEffectParam(PARAM param) => _param = param;
		public IEnumerable<FeTextEffectParamRow> Entries => _param.Rows.Select(r => new FeTextEffectParamRow(r));
	}
	public class FeTextEffectParamRow
	{
		private readonly PARAM.Row _row;
		public FeTextEffectParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public short resId => (short)_row["resId"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public int textId => (int)_row["textId"].Value;
		public int seId => (int)_row["seId"].Value;
		public byte[] canMixMapName => (byte[])_row["canMixMapName"].Value;
		public byte[] pad3 => (byte[])_row["pad3"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | resId: {resId} | textId: {textId} | seId: {seId}";
	}
}
