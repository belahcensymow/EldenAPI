using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class ToughnessParam
	{
		private readonly PARAM _param;
		public ToughnessParam(PARAM param) => _param = param;
		public IEnumerable<ToughnessParamRow> Entries => _param.Rows.Select(r => new ToughnessParamRow(r));
	}
	public class ToughnessParamRow
	{
		private readonly PARAM.Row _row;
		public ToughnessParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float correctionRate => (float)_row["correctionRate"].Value;
		public ushort minToughness => (ushort)_row["minToughness"].Value;
		public byte isNonEffectiveCorrectionForMin => (byte)_row["isNonEffectiveCorrectionForMin"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public int spEffectId => (int)_row["spEffectId"].Value;
		public float proCorrectionRate => (float)_row["proCorrectionRate"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | correctionRate: {correctionRate} | minToughness: {minToughness} | isNonEffectiveCorrectionForMin: {isNonEffectiveCorrectionForMin} | spEffectId: {spEffectId} | proCorrectionRate: {proCorrectionRate}";
	}
}
