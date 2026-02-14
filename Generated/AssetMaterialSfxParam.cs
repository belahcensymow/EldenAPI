using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class AssetMaterialSfxParam
	{
		private readonly PARAM _param;
		public AssetMaterialSfxParam(PARAM param) => _param = param;
		public IEnumerable<AssetMaterialSfxParamRow> Entries => _param.Rows.Select(r => new AssetMaterialSfxParamRow(r));
	}
	public class AssetMaterialSfxParamRow
	{
		private readonly PARAM.Row _row;
		public AssetMaterialSfxParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public uint sfxId_00 => (uint)_row["sfxId_00"].Value;
		public uint sfxId_01 => (uint)_row["sfxId_01"].Value;
		public uint sfxId_02 => (uint)_row["sfxId_02"].Value;
		public uint sfxId_03 => (uint)_row["sfxId_03"].Value;
		public uint sfxId_04 => (uint)_row["sfxId_04"].Value;
		public uint sfxId_05 => (uint)_row["sfxId_05"].Value;
		public uint sfxId_06 => (uint)_row["sfxId_06"].Value;
		public uint sfxId_07 => (uint)_row["sfxId_07"].Value;
		public uint sfxId_08 => (uint)_row["sfxId_08"].Value;
		public uint sfxId_09 => (uint)_row["sfxId_09"].Value;
		public uint sfxId_10 => (uint)_row["sfxId_10"].Value;
		public uint sfxId_11 => (uint)_row["sfxId_11"].Value;
		public uint sfxId_12 => (uint)_row["sfxId_12"].Value;
		public uint sfxId_13 => (uint)_row["sfxId_13"].Value;
		public uint sfxId_14 => (uint)_row["sfxId_14"].Value;
		public uint sfxId_15 => (uint)_row["sfxId_15"].Value;
		public uint sfxId_16 => (uint)_row["sfxId_16"].Value;
		public uint sfxId_17 => (uint)_row["sfxId_17"].Value;
		public uint sfxId_18 => (uint)_row["sfxId_18"].Value;
		public uint sfxId_19 => (uint)_row["sfxId_19"].Value;
		public uint sfxId_20 => (uint)_row["sfxId_20"].Value;
		public uint sfxId_21 => (uint)_row["sfxId_21"].Value;
		public uint sfxId_22 => (uint)_row["sfxId_22"].Value;
		public uint sfxId_23 => (uint)_row["sfxId_23"].Value;
		public uint sfxId_24 => (uint)_row["sfxId_24"].Value;
		public uint sfxId_25 => (uint)_row["sfxId_25"].Value;
		public uint sfxId_26 => (uint)_row["sfxId_26"].Value;
		public uint sfxId_27 => (uint)_row["sfxId_27"].Value;
		public uint sfxId_28 => (uint)_row["sfxId_28"].Value;
		public uint sfxId_29 => (uint)_row["sfxId_29"].Value;
		public uint sfxId_30 => (uint)_row["sfxId_30"].Value;
		public uint sfxId_31 => (uint)_row["sfxId_31"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | sfxId_00: {sfxId_00} | sfxId_01: {sfxId_01} | sfxId_02: {sfxId_02} | sfxId_03: {sfxId_03} | sfxId_04: {sfxId_04} | sfxId_05: {sfxId_05} | sfxId_06: {sfxId_06} | sfxId_07: {sfxId_07} | sfxId_08: {sfxId_08} | sfxId_09: {sfxId_09} | sfxId_10: {sfxId_10} | sfxId_11: {sfxId_11} | sfxId_12: {sfxId_12} | sfxId_13: {sfxId_13} | sfxId_14: {sfxId_14} | sfxId_15: {sfxId_15} | sfxId_16: {sfxId_16} | sfxId_17: {sfxId_17} | sfxId_18: {sfxId_18} | sfxId_19: {sfxId_19} | sfxId_20: {sfxId_20} | sfxId_21: {sfxId_21} | sfxId_22: {sfxId_22} | sfxId_23: {sfxId_23} | sfxId_24: {sfxId_24} | sfxId_25: {sfxId_25} | sfxId_26: {sfxId_26} | sfxId_27: {sfxId_27} | sfxId_28: {sfxId_28} | sfxId_29: {sfxId_29} | sfxId_30: {sfxId_30} | sfxId_31: {sfxId_31}";
	}
}
