using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class KnockbackParam
	{
		private readonly PARAM _param;
		public KnockbackParam(PARAM param) => _param = param;
		public IEnumerable<KnockbackParamRow> Entries => _param.Rows.Select(r => new KnockbackParamRow(r));
	}
	public class KnockbackParamRow
	{
		private readonly PARAM.Row _row;
		public KnockbackParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float damage_Min_ContTime => (float)_row["damage_Min_ContTime"].Value;
		public float damage_S_ContTime => (float)_row["damage_S_ContTime"].Value;
		public float damage_M_ContTime => (float)_row["damage_M_ContTime"].Value;
		public float damage_L_ContTime => (float)_row["damage_L_ContTime"].Value;
		public float damage_BlowS_ContTime => (float)_row["damage_BlowS_ContTime"].Value;
		public float damage_BlowM_ContTime => (float)_row["damage_BlowM_ContTime"].Value;
		public float damage_Strike_ContTime => (float)_row["damage_Strike_ContTime"].Value;
		public float damage_Uppercut_ContTime => (float)_row["damage_Uppercut_ContTime"].Value;
		public float damage_Push_ContTime => (float)_row["damage_Push_ContTime"].Value;
		public float damage_Breath_ContTime => (float)_row["damage_Breath_ContTime"].Value;
		public float damage_HeadShot_ContTime => (float)_row["damage_HeadShot_ContTime"].Value;
		public float guard_S_ContTime => (float)_row["guard_S_ContTime"].Value;
		public float guard_L_ContTime => (float)_row["guard_L_ContTime"].Value;
		public float guard_LL_ContTime => (float)_row["guard_LL_ContTime"].Value;
		public float guardBrake_ContTime => (float)_row["guardBrake_ContTime"].Value;
		public float damage_Min_DecTime => (float)_row["damage_Min_DecTime"].Value;
		public float damage_S_DecTime => (float)_row["damage_S_DecTime"].Value;
		public float damage_M_DecTime => (float)_row["damage_M_DecTime"].Value;
		public float damage_L_DecTime => (float)_row["damage_L_DecTime"].Value;
		public float damage_BlowS_DecTime => (float)_row["damage_BlowS_DecTime"].Value;
		public float damage_BlowM_DecTime => (float)_row["damage_BlowM_DecTime"].Value;
		public float damage_Strike_DecTime => (float)_row["damage_Strike_DecTime"].Value;
		public float damage_Uppercut_DecTime => (float)_row["damage_Uppercut_DecTime"].Value;
		public float damage_Push_DecTime => (float)_row["damage_Push_DecTime"].Value;
		public float damage_Breath_DecTime => (float)_row["damage_Breath_DecTime"].Value;
		public float damage_HeadShot_DecTime => (float)_row["damage_HeadShot_DecTime"].Value;
		public float guard_S_DecTime => (float)_row["guard_S_DecTime"].Value;
		public float guard_L_DecTime => (float)_row["guard_L_DecTime"].Value;
		public float guard_LL_DecTime => (float)_row["guard_LL_DecTime"].Value;
		public float guardBrake_DecTime => (float)_row["guardBrake_DecTime"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | damage_Min_ContTime: {damage_Min_ContTime} | damage_S_ContTime: {damage_S_ContTime} | damage_M_ContTime: {damage_M_ContTime} | damage_L_ContTime: {damage_L_ContTime} | damage_BlowS_ContTime: {damage_BlowS_ContTime} | damage_BlowM_ContTime: {damage_BlowM_ContTime} | damage_Strike_ContTime: {damage_Strike_ContTime} | damage_Uppercut_ContTime: {damage_Uppercut_ContTime} | damage_Push_ContTime: {damage_Push_ContTime} | damage_Breath_ContTime: {damage_Breath_ContTime} | damage_HeadShot_ContTime: {damage_HeadShot_ContTime} | guard_S_ContTime: {guard_S_ContTime} | guard_L_ContTime: {guard_L_ContTime} | guard_LL_ContTime: {guard_LL_ContTime} | guardBrake_ContTime: {guardBrake_ContTime} | damage_Min_DecTime: {damage_Min_DecTime} | damage_S_DecTime: {damage_S_DecTime} | damage_M_DecTime: {damage_M_DecTime} | damage_L_DecTime: {damage_L_DecTime} | damage_BlowS_DecTime: {damage_BlowS_DecTime} | damage_BlowM_DecTime: {damage_BlowM_DecTime} | damage_Strike_DecTime: {damage_Strike_DecTime} | damage_Uppercut_DecTime: {damage_Uppercut_DecTime} | damage_Push_DecTime: {damage_Push_DecTime} | damage_Breath_DecTime: {damage_Breath_DecTime} | damage_HeadShot_DecTime: {damage_HeadShot_DecTime} | guard_S_DecTime: {guard_S_DecTime} | guard_L_DecTime: {guard_L_DecTime} | guard_LL_DecTime: {guard_LL_DecTime} | guardBrake_DecTime: {guardBrake_DecTime}";
	}
}
