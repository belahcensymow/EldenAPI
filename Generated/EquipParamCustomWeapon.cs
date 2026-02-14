using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class EquipParamCustomWeapon
	{
		private readonly PARAM _param;
		public EquipParamCustomWeapon(PARAM param) => _param = param;
		public IEnumerable<EquipParamCustomWeaponRow> Entries => _param.Rows.Select(r => new EquipParamCustomWeaponRow(r));
	}
	public class EquipParamCustomWeaponRow
	{
		private readonly PARAM.Row _row;
		public EquipParamCustomWeaponRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int baseWepId => (int)_row["baseWepId"].Value;
		public int gemId => (int)_row["gemId"].Value;
		public byte reinforceLv => (byte)_row["reinforceLv"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | baseWepId: {baseWepId} | gemId: {gemId} | reinforceLv: {reinforceLv}";
	}
}
