using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class ThrowDirectionSfxParam
	{
		private readonly PARAM _param;
		public ThrowDirectionSfxParam(PARAM param) => _param = param;
		public IEnumerable<ThrowDirectionSfxParamRow> Entries => _param.Rows.Select(r => new ThrowDirectionSfxParamRow(r));
	}
	public class ThrowDirectionSfxParamRow
	{
		private readonly PARAM.Row _row;
		public ThrowDirectionSfxParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int sfxId_00 => (int)_row["sfxId_00"].Value;
		public int sfxId_01 => (int)_row["sfxId_01"].Value;
		public int sfxId_02 => (int)_row["sfxId_02"].Value;
		public int sfxId_03 => (int)_row["sfxId_03"].Value;
		public int sfxId_04 => (int)_row["sfxId_04"].Value;
		public int sfxId_05 => (int)_row["sfxId_05"].Value;
		public int sfxId_06 => (int)_row["sfxId_06"].Value;
		public int sfxId_07 => (int)_row["sfxId_07"].Value;
		public int sfxId_08 => (int)_row["sfxId_08"].Value;
		public int sfxId_09 => (int)_row["sfxId_09"].Value;
		public int sfxId_10 => (int)_row["sfxId_10"].Value;
		public int sfxId_11 => (int)_row["sfxId_11"].Value;
		public int sfxId_12 => (int)_row["sfxId_12"].Value;
		public int sfxId_13 => (int)_row["sfxId_13"].Value;
		public int sfxId_14 => (int)_row["sfxId_14"].Value;
		public int sfxId_15 => (int)_row["sfxId_15"].Value;
		public int sfxId_16 => (int)_row["sfxId_16"].Value;
		public int sfxId_17 => (int)_row["sfxId_17"].Value;
		public int sfxId_18 => (int)_row["sfxId_18"].Value;
		public int sfxId_19 => (int)_row["sfxId_19"].Value;
		public int sfxId_20 => (int)_row["sfxId_20"].Value;
		public int sfxId_21 => (int)_row["sfxId_21"].Value;
		public int sfxId_22 => (int)_row["sfxId_22"].Value;
		public int sfxId_23 => (int)_row["sfxId_23"].Value;
		public int sfxId_24 => (int)_row["sfxId_24"].Value;
		public int sfxId_25 => (int)_row["sfxId_25"].Value;
		public int sfxId_26 => (int)_row["sfxId_26"].Value;
		public int sfxId_27 => (int)_row["sfxId_27"].Value;
		public int sfxId_28 => (int)_row["sfxId_28"].Value;
		public int sfxId_29 => (int)_row["sfxId_29"].Value;
		public int sfxId_30 => (int)_row["sfxId_30"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | sfxId_00: {sfxId_00} | sfxId_01: {sfxId_01} | sfxId_02: {sfxId_02} | sfxId_03: {sfxId_03} | sfxId_04: {sfxId_04} | sfxId_05: {sfxId_05} | sfxId_06: {sfxId_06} | sfxId_07: {sfxId_07} | sfxId_08: {sfxId_08} | sfxId_09: {sfxId_09} | sfxId_10: {sfxId_10} | sfxId_11: {sfxId_11} | sfxId_12: {sfxId_12} | sfxId_13: {sfxId_13} | sfxId_14: {sfxId_14} | sfxId_15: {sfxId_15} | sfxId_16: {sfxId_16} | sfxId_17: {sfxId_17} | sfxId_18: {sfxId_18} | sfxId_19: {sfxId_19} | sfxId_20: {sfxId_20} | sfxId_21: {sfxId_21} | sfxId_22: {sfxId_22} | sfxId_23: {sfxId_23} | sfxId_24: {sfxId_24} | sfxId_25: {sfxId_25} | sfxId_26: {sfxId_26} | sfxId_27: {sfxId_27} | sfxId_28: {sfxId_28} | sfxId_29: {sfxId_29} | sfxId_30: {sfxId_30}";
	}
}
