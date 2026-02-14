using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class ReinforceParamWeapon
	{
		private readonly PARAM _param;
		public ReinforceParamWeapon(PARAM param) => _param = param;
		public IEnumerable<ReinforceParamWeaponRow> Entries => _param.Rows.Select(r => new ReinforceParamWeaponRow(r));
	}
	public class ReinforceParamWeaponRow
	{
		private readonly PARAM.Row _row;
		public ReinforceParamWeaponRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float physicsAtkRate => (float)_row["physicsAtkRate"].Value;
		public float magicAtkRate => (float)_row["magicAtkRate"].Value;
		public float fireAtkRate => (float)_row["fireAtkRate"].Value;
		public float thunderAtkRate => (float)_row["thunderAtkRate"].Value;
		public float staminaAtkRate => (float)_row["staminaAtkRate"].Value;
		public float saWeaponAtkRate => (float)_row["saWeaponAtkRate"].Value;
		public float saDurabilityRate => (float)_row["saDurabilityRate"].Value;
		public float correctStrengthRate => (float)_row["correctStrengthRate"].Value;
		public float correctAgilityRate => (float)_row["correctAgilityRate"].Value;
		public float correctMagicRate => (float)_row["correctMagicRate"].Value;
		public float correctFaithRate => (float)_row["correctFaithRate"].Value;
		public float physicsGuardCutRate => (float)_row["physicsGuardCutRate"].Value;
		public float magicGuardCutRate => (float)_row["magicGuardCutRate"].Value;
		public float fireGuardCutRate => (float)_row["fireGuardCutRate"].Value;
		public float thunderGuardCutRate => (float)_row["thunderGuardCutRate"].Value;
		public float poisonGuardResistRate => (float)_row["poisonGuardResistRate"].Value;
		public float diseaseGuardResistRate => (float)_row["diseaseGuardResistRate"].Value;
		public float bloodGuardResistRate => (float)_row["bloodGuardResistRate"].Value;
		public float curseGuardResistRate => (float)_row["curseGuardResistRate"].Value;
		public float staminaGuardDefRate => (float)_row["staminaGuardDefRate"].Value;
		public byte spEffectId1 => (byte)_row["spEffectId1"].Value;
		public byte spEffectId2 => (byte)_row["spEffectId2"].Value;
		public byte spEffectId3 => (byte)_row["spEffectId3"].Value;
		public byte residentSpEffectId1 => (byte)_row["residentSpEffectId1"].Value;
		public byte residentSpEffectId2 => (byte)_row["residentSpEffectId2"].Value;
		public byte residentSpEffectId3 => (byte)_row["residentSpEffectId3"].Value;
		public byte materialSetId => (byte)_row["materialSetId"].Value;
		public byte maxReinforceLevel => (byte)_row["maxReinforceLevel"].Value;
		public float darkAtkRate => (float)_row["darkAtkRate"].Value;
		public float darkGuardCutRate => (float)_row["darkGuardCutRate"].Value;
		public float correctLuckRate => (float)_row["correctLuckRate"].Value;
		public float freezeGuardDefRate => (float)_row["freezeGuardDefRate"].Value;
		public float reinforcePriceRate => (float)_row["reinforcePriceRate"].Value;
		public float baseChangePriceRate => (float)_row["baseChangePriceRate"].Value;
		public sbyte enableGemRank => (sbyte)_row["enableGemRank"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public float sleepGuardDefRate => (float)_row["sleepGuardDefRate"].Value;
		public float madnessGuardDefRate => (float)_row["madnessGuardDefRate"].Value;
		public float baseAtkRate => (float)_row["baseAtkRate"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | physicsAtkRate: {physicsAtkRate} | magicAtkRate: {magicAtkRate} | fireAtkRate: {fireAtkRate} | thunderAtkRate: {thunderAtkRate} | staminaAtkRate: {staminaAtkRate} | saWeaponAtkRate: {saWeaponAtkRate} | saDurabilityRate: {saDurabilityRate} | correctStrengthRate: {correctStrengthRate} | correctAgilityRate: {correctAgilityRate} | correctMagicRate: {correctMagicRate} | correctFaithRate: {correctFaithRate} | physicsGuardCutRate: {physicsGuardCutRate} | magicGuardCutRate: {magicGuardCutRate} | fireGuardCutRate: {fireGuardCutRate} | thunderGuardCutRate: {thunderGuardCutRate} | poisonGuardResistRate: {poisonGuardResistRate} | diseaseGuardResistRate: {diseaseGuardResistRate} | bloodGuardResistRate: {bloodGuardResistRate} | curseGuardResistRate: {curseGuardResistRate} | staminaGuardDefRate: {staminaGuardDefRate} | spEffectId1: {spEffectId1} | spEffectId2: {spEffectId2} | spEffectId3: {spEffectId3} | residentSpEffectId1: {residentSpEffectId1} | residentSpEffectId2: {residentSpEffectId2} | residentSpEffectId3: {residentSpEffectId3} | materialSetId: {materialSetId} | maxReinforceLevel: {maxReinforceLevel} | darkAtkRate: {darkAtkRate} | darkGuardCutRate: {darkGuardCutRate} | correctLuckRate: {correctLuckRate} | freezeGuardDefRate: {freezeGuardDefRate} | reinforcePriceRate: {reinforcePriceRate} | baseChangePriceRate: {baseChangePriceRate} | enableGemRank: {enableGemRank} | sleepGuardDefRate: {sleepGuardDefRate} | madnessGuardDefRate: {madnessGuardDefRate} | baseAtkRate: {baseAtkRate}";
	}
}
