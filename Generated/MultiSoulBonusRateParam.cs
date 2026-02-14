using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class MultiSoulBonusRateParam
	{
		private readonly PARAM _param;
		public MultiSoulBonusRateParam(PARAM param) => _param = param;
		public IEnumerable<MultiSoulBonusRateParamRow> Entries => _param.Rows.Select(r => new MultiSoulBonusRateParamRow(r));
	}
	public class MultiSoulBonusRateParamRow
	{
		private readonly PARAM.Row _row;
		public MultiSoulBonusRateParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float host => (float)_row["host"].Value;
		public float WhiteGhost_None => (float)_row["WhiteGhost_None"].Value;
		public float WhiteGhost_Umbasa => (float)_row["WhiteGhost_Umbasa"].Value;
		public float WhiteGhost_Berserker => (float)_row["WhiteGhost_Berserker"].Value;
		public float BlackGhost_None_Sign => (float)_row["BlackGhost_None_Sign"].Value;
		public float BlackGhost_Umbasa_Sign => (float)_row["BlackGhost_Umbasa_Sign"].Value;
		public float BlackGhost_Berserker_Sign => (float)_row["BlackGhost_Berserker_Sign"].Value;
		public float BlackGhost_None_Invade => (float)_row["BlackGhost_None_Invade"].Value;
		public float BlackGhost_Umbasa_Invade => (float)_row["BlackGhost_Umbasa_Invade"].Value;
		public float BlackGhost_Berserker_Invade => (float)_row["BlackGhost_Berserker_Invade"].Value;
		public float RedHunter1 => (float)_row["RedHunter1"].Value;
		public float RedHunter2 => (float)_row["RedHunter2"].Value;
		public float GuardianOfForest => (float)_row["GuardianOfForest"].Value;
		public float GuardianOfAnor => (float)_row["GuardianOfAnor"].Value;
		public float BattleRoyal => (float)_row["BattleRoyal"].Value;
		public float YellowMonk => (float)_row["YellowMonk"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | host: {host} | WhiteGhost_None: {WhiteGhost_None} | WhiteGhost_Umbasa: {WhiteGhost_Umbasa} | WhiteGhost_Berserker: {WhiteGhost_Berserker} | BlackGhost_None_Sign: {BlackGhost_None_Sign} | BlackGhost_Umbasa_Sign: {BlackGhost_Umbasa_Sign} | BlackGhost_Berserker_Sign: {BlackGhost_Berserker_Sign} | BlackGhost_None_Invade: {BlackGhost_None_Invade} | BlackGhost_Umbasa_Invade: {BlackGhost_Umbasa_Invade} | BlackGhost_Berserker_Invade: {BlackGhost_Berserker_Invade} | RedHunter1: {RedHunter1} | RedHunter2: {RedHunter2} | GuardianOfForest: {GuardianOfForest} | GuardianOfAnor: {GuardianOfAnor} | BattleRoyal: {BattleRoyal} | YellowMonk: {YellowMonk}";
	}
}
