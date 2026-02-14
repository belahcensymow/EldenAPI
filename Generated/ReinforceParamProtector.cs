using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class ReinforceParamProtector
	{
		private readonly PARAM _param;
		public ReinforceParamProtector(PARAM param) => _param = param;
		public IEnumerable<ReinforceParamProtectorRow> Entries => _param.Rows.Select(r => new ReinforceParamProtectorRow(r));
	}
	public class ReinforceParamProtectorRow
	{
		private readonly PARAM.Row _row;
		public ReinforceParamProtectorRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float physicsDefRate => (float)_row["physicsDefRate"].Value;
		public float magicDefRate => (float)_row["magicDefRate"].Value;
		public float fireDefRate => (float)_row["fireDefRate"].Value;
		public float thunderDefRate => (float)_row["thunderDefRate"].Value;
		public float slashDefRate => (float)_row["slashDefRate"].Value;
		public float blowDefRate => (float)_row["blowDefRate"].Value;
		public float thrustDefRate => (float)_row["thrustDefRate"].Value;
		public float resistPoisonRate => (float)_row["resistPoisonRate"].Value;
		public float resistDiseaseRate => (float)_row["resistDiseaseRate"].Value;
		public float resistBloodRate => (float)_row["resistBloodRate"].Value;
		public float resistCurseRate => (float)_row["resistCurseRate"].Value;
		public byte residentSpEffectId1 => (byte)_row["residentSpEffectId1"].Value;
		public byte residentSpEffectId2 => (byte)_row["residentSpEffectId2"].Value;
		public byte residentSpEffectId3 => (byte)_row["residentSpEffectId3"].Value;
		public byte materialSetId => (byte)_row["materialSetId"].Value;
		public float darkDefRate => (float)_row["darkDefRate"].Value;
		public float resistFreezeRate => (float)_row["resistFreezeRate"].Value;
		public float resistSleepRate => (float)_row["resistSleepRate"].Value;
		public float resistMadnessRate => (float)_row["resistMadnessRate"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | physicsDefRate: {physicsDefRate} | magicDefRate: {magicDefRate} | fireDefRate: {fireDefRate} | thunderDefRate: {thunderDefRate} | slashDefRate: {slashDefRate} | blowDefRate: {blowDefRate} | thrustDefRate: {thrustDefRate} | resistPoisonRate: {resistPoisonRate} | resistDiseaseRate: {resistDiseaseRate} | resistBloodRate: {resistBloodRate} | resistCurseRate: {resistCurseRate} | residentSpEffectId1: {residentSpEffectId1} | residentSpEffectId2: {residentSpEffectId2} | residentSpEffectId3: {residentSpEffectId3} | materialSetId: {materialSetId} | darkDefRate: {darkDefRate} | resistFreezeRate: {resistFreezeRate} | resistSleepRate: {resistSleepRate} | resistMadnessRate: {resistMadnessRate}";
	}
}
