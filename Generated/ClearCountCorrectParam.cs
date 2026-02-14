using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class ClearCountCorrectParam
	{
		private readonly PARAM _param;
		public ClearCountCorrectParam(PARAM param) => _param = param;
		public IEnumerable<ClearCountCorrectParamRow> Entries => _param.Rows.Select(r => new ClearCountCorrectParamRow(r));
	}
	public class ClearCountCorrectParamRow
	{
		private readonly PARAM.Row _row;
		public ClearCountCorrectParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float MaxHpRate => (float)_row["MaxHpRate"].Value;
		public float MaxMpRate => (float)_row["MaxMpRate"].Value;
		public float MaxStaminaRate => (float)_row["MaxStaminaRate"].Value;
		public float PhysicsAttackRate => (float)_row["PhysicsAttackRate"].Value;
		public float SlashAttackRate => (float)_row["SlashAttackRate"].Value;
		public float BlowAttackRate => (float)_row["BlowAttackRate"].Value;
		public float ThrustAttackRate => (float)_row["ThrustAttackRate"].Value;
		public float NeturalAttackRate => (float)_row["NeturalAttackRate"].Value;
		public float MagicAttackRate => (float)_row["MagicAttackRate"].Value;
		public float FireAttackRate => (float)_row["FireAttackRate"].Value;
		public float ThunderAttackRate => (float)_row["ThunderAttackRate"].Value;
		public float DarkAttackRate => (float)_row["DarkAttackRate"].Value;
		public float PhysicsDefenseRate => (float)_row["PhysicsDefenseRate"].Value;
		public float MagicDefenseRate => (float)_row["MagicDefenseRate"].Value;
		public float FireDefenseRate => (float)_row["FireDefenseRate"].Value;
		public float ThunderDefenseRate => (float)_row["ThunderDefenseRate"].Value;
		public float DarkDefenseRate => (float)_row["DarkDefenseRate"].Value;
		public float StaminaAttackRate => (float)_row["StaminaAttackRate"].Value;
		public float SoulRate => (float)_row["SoulRate"].Value;
		public float PoisionResistRate => (float)_row["PoisionResistRate"].Value;
		public float DiseaseResistRate => (float)_row["DiseaseResistRate"].Value;
		public float BloodResistRate => (float)_row["BloodResistRate"].Value;
		public float CurseResistRate => (float)_row["CurseResistRate"].Value;
		public float FreezeResistRate => (float)_row["FreezeResistRate"].Value;
		public float BloodDamageRate => (float)_row["BloodDamageRate"].Value;
		public float SuperArmorDamageRate => (float)_row["SuperArmorDamageRate"].Value;
		public float FreezeDamageRate => (float)_row["FreezeDamageRate"].Value;
		public float SleepResistRate => (float)_row["SleepResistRate"].Value;
		public float MadnessResistRate => (float)_row["MadnessResistRate"].Value;
		public float SleepDamageRate => (float)_row["SleepDamageRate"].Value;
		public float MadnessDamageRate => (float)_row["MadnessDamageRate"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | MaxHpRate: {MaxHpRate} | MaxMpRate: {MaxMpRate} | MaxStaminaRate: {MaxStaminaRate} | PhysicsAttackRate: {PhysicsAttackRate} | SlashAttackRate: {SlashAttackRate} | BlowAttackRate: {BlowAttackRate} | ThrustAttackRate: {ThrustAttackRate} | NeturalAttackRate: {NeturalAttackRate} | MagicAttackRate: {MagicAttackRate} | FireAttackRate: {FireAttackRate} | ThunderAttackRate: {ThunderAttackRate} | DarkAttackRate: {DarkAttackRate} | PhysicsDefenseRate: {PhysicsDefenseRate} | MagicDefenseRate: {MagicDefenseRate} | FireDefenseRate: {FireDefenseRate} | ThunderDefenseRate: {ThunderDefenseRate} | DarkDefenseRate: {DarkDefenseRate} | StaminaAttackRate: {StaminaAttackRate} | SoulRate: {SoulRate} | PoisionResistRate: {PoisionResistRate} | DiseaseResistRate: {DiseaseResistRate} | BloodResistRate: {BloodResistRate} | CurseResistRate: {CurseResistRate} | FreezeResistRate: {FreezeResistRate} | BloodDamageRate: {BloodDamageRate} | SuperArmorDamageRate: {SuperArmorDamageRate} | FreezeDamageRate: {FreezeDamageRate} | SleepResistRate: {SleepResistRate} | MadnessResistRate: {MadnessResistRate} | SleepDamageRate: {SleepDamageRate} | MadnessDamageRate: {MadnessDamageRate}";
	}
}
