using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class EquipMtrlSetParam
	{
		private readonly PARAM _param;
		public EquipMtrlSetParam(PARAM param) => _param = param;
		public IEnumerable<EquipMtrlSetParamRow> Entries => _param.Rows.Select(r => new EquipMtrlSetParamRow(r));
	}
	public class EquipMtrlSetParamRow
	{
		private readonly PARAM.Row _row;
		public EquipMtrlSetParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int materialId01 => (int)_row["materialId01"].Value;
		public int materialId02 => (int)_row["materialId02"].Value;
		public int materialId03 => (int)_row["materialId03"].Value;
		public int materialId04 => (int)_row["materialId04"].Value;
		public int materialId05 => (int)_row["materialId05"].Value;
		public int materialId06 => (int)_row["materialId06"].Value;
		public byte[] pad_id => (byte[])_row["pad_id"].Value;
		public sbyte itemNum01 => (sbyte)_row["itemNum01"].Value;
		public sbyte itemNum02 => (sbyte)_row["itemNum02"].Value;
		public sbyte itemNum03 => (sbyte)_row["itemNum03"].Value;
		public sbyte itemNum04 => (sbyte)_row["itemNum04"].Value;
		public sbyte itemNum05 => (sbyte)_row["itemNum05"].Value;
		public sbyte itemNum06 => (sbyte)_row["itemNum06"].Value;
		public byte[] pad_num => (byte[])_row["pad_num"].Value;
		public byte[] materialCate01 => (byte[])_row["materialCate01"].Value;
		public byte[] materialCate02 => (byte[])_row["materialCate02"].Value;
		public byte[] materialCate03 => (byte[])_row["materialCate03"].Value;
		public byte[] materialCate04 => (byte[])_row["materialCate04"].Value;
		public byte[] materialCate05 => (byte[])_row["materialCate05"].Value;
		public byte[] materialCate06 => (byte[])_row["materialCate06"].Value;
		public byte[] pad_cate => (byte[])_row["pad_cate"].Value;
		public byte isDisableDispNum01 => (byte)_row["isDisableDispNum01"].Value;
		public byte isDisableDispNum02 => (byte)_row["isDisableDispNum02"].Value;
		public byte isDisableDispNum03 => (byte)_row["isDisableDispNum03"].Value;
		public byte isDisableDispNum04 => (byte)_row["isDisableDispNum04"].Value;
		public byte isDisableDispNum05 => (byte)_row["isDisableDispNum05"].Value;
		public byte isDisableDispNum06 => (byte)_row["isDisableDispNum06"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | materialId01: {materialId01} | materialId02: {materialId02} | materialId03: {materialId03} | materialId04: {materialId04} | materialId05: {materialId05} | materialId06: {materialId06} | itemNum01: {itemNum01} | itemNum02: {itemNum02} | itemNum03: {itemNum03} | itemNum04: {itemNum04} | itemNum05: {itemNum05} | itemNum06: {itemNum06} | isDisableDispNum01: {isDisableDispNum01} | isDisableDispNum02: {isDisableDispNum02} | isDisableDispNum03: {isDisableDispNum03} | isDisableDispNum04: {isDisableDispNum04} | isDisableDispNum05: {isDisableDispNum05} | isDisableDispNum06: {isDisableDispNum06}";
	}
}
