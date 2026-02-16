using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class HitEffectSfxConceptParam
	{
		private readonly PARAM _param;
		public HitEffectSfxConceptParam(PARAM param) => _param = param;
		public IEnumerable<HitEffectSfxConceptParamRow> Entries => _param.Rows.Select(r => new HitEffectSfxConceptParamRow(r));
	}
	public class HitEffectSfxConceptParamRow
	{
		private readonly PARAM.Row _row;
		public HitEffectSfxConceptParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte atkIron_1 => (byte)_row["atkIron_1"].Value;
		public byte atkIron_2 => (byte)_row["atkIron_2"].Value;
		public byte atkLeather_1 => (byte)_row["atkLeather_1"].Value;
		public byte atkLeather_2 => (byte)_row["atkLeather_2"].Value;
		public byte atkWood_1 => (byte)_row["atkWood_1"].Value;
		public byte atkWood_2 => (byte)_row["atkWood_2"].Value;
		public byte atkBody_1 => (byte)_row["atkBody_1"].Value;
		public byte atkBody_2 => (byte)_row["atkBody_2"].Value;
		public byte atkStone_1 => (byte)_row["atkStone_1"].Value;
		public byte atkStone_2 => (byte)_row["atkStone_2"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public byte atkNone_1 => (byte)_row["atkNone_1"].Value;
		public byte atkNone_2 => (byte)_row["atkNone_2"].Value;
		public byte[] reserve => (byte[])_row["reserve"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | atkIron_1: {atkIron_1} | atkIron_2: {atkIron_2} | atkLeather_1: {atkLeather_1} | atkLeather_2: {atkLeather_2} | atkWood_1: {atkWood_1} | atkWood_2: {atkWood_2} | atkBody_1: {atkBody_1} | atkBody_2: {atkBody_2} | atkStone_1: {atkStone_1} | atkStone_2: {atkStone_2} | atkNone_1: {atkNone_1} | atkNone_2: {atkNone_2}";
	}
}
