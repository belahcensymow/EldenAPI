using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class AssetModelSfxParam
	{
		private readonly PARAM _param;
		public AssetModelSfxParam(PARAM param) => _param = param;
		public IEnumerable<AssetModelSfxParamRow> Entries => _param.Rows.Select(r => new AssetModelSfxParamRow(r));
	}
	public class AssetModelSfxParamRow
	{
		private readonly PARAM.Row _row;
		public AssetModelSfxParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int sfxId_0 => (int)_row["sfxId_0"].Value;
		public int dmypolyId_0 => (int)_row["dmypolyId_0"].Value;
		public byte[] reserve_0 => (byte[])_row["reserve_0"].Value;
		public int sfxId_1 => (int)_row["sfxId_1"].Value;
		public int dmypolyId_1 => (int)_row["dmypolyId_1"].Value;
		public byte[] reserve_1 => (byte[])_row["reserve_1"].Value;
		public int sfxId_2 => (int)_row["sfxId_2"].Value;
		public int dmypolyId_2 => (int)_row["dmypolyId_2"].Value;
		public byte[] reserve_2 => (byte[])_row["reserve_2"].Value;
		public int sfxId_3 => (int)_row["sfxId_3"].Value;
		public int dmypolyId_3 => (int)_row["dmypolyId_3"].Value;
		public byte[] reserve_3 => (byte[])_row["reserve_3"].Value;
		public int sfxId_4 => (int)_row["sfxId_4"].Value;
		public int dmypolyId_4 => (int)_row["dmypolyId_4"].Value;
		public byte[] reserve_4 => (byte[])_row["reserve_4"].Value;
		public int sfxId_5 => (int)_row["sfxId_5"].Value;
		public int dmypolyId_5 => (int)_row["dmypolyId_5"].Value;
		public byte[] reserve_5 => (byte[])_row["reserve_5"].Value;
		public int sfxId_6 => (int)_row["sfxId_6"].Value;
		public int dmypolyId_6 => (int)_row["dmypolyId_6"].Value;
		public byte[] reserve_6 => (byte[])_row["reserve_6"].Value;
		public int sfxId_7 => (int)_row["sfxId_7"].Value;
		public int dmypolyId_7 => (int)_row["dmypolyId_7"].Value;
		public byte isDisableIV => (byte)_row["isDisableIV"].Value;
		public byte[] reserve_7 => (byte[])_row["reserve_7"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | sfxId_0: {sfxId_0} | dmypolyId_0: {dmypolyId_0} | sfxId_1: {sfxId_1} | dmypolyId_1: {dmypolyId_1} | sfxId_2: {sfxId_2} | dmypolyId_2: {dmypolyId_2} | sfxId_3: {sfxId_3} | dmypolyId_3: {dmypolyId_3} | sfxId_4: {sfxId_4} | dmypolyId_4: {dmypolyId_4} | sfxId_5: {sfxId_5} | dmypolyId_5: {dmypolyId_5} | sfxId_6: {sfxId_6} | dmypolyId_6: {dmypolyId_6} | sfxId_7: {sfxId_7} | dmypolyId_7: {dmypolyId_7} | isDisableIV: {isDisableIV}";
	}
}
