using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class MultiEstusFlaskBonusParam
	{
		private readonly PARAM _param;
		public MultiEstusFlaskBonusParam(PARAM param) => _param = param;
		public IEnumerable<MultiEstusFlaskBonusParamRow> Entries => _param.Rows.Select(r => new MultiEstusFlaskBonusParamRow(r));
	}
	public class MultiEstusFlaskBonusParamRow
	{
		private readonly PARAM.Row _row;
		public MultiEstusFlaskBonusParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte host => (byte)_row["host"].Value;
		public byte WhiteGhost_None => (byte)_row["WhiteGhost_None"].Value;
		public byte WhiteGhost_Umbasa => (byte)_row["WhiteGhost_Umbasa"].Value;
		public byte WhiteGhost_Berserker => (byte)_row["WhiteGhost_Berserker"].Value;
		public byte BlackGhost_None_Sign => (byte)_row["BlackGhost_None_Sign"].Value;
		public byte BlackGhost_Umbasa_Sign => (byte)_row["BlackGhost_Umbasa_Sign"].Value;
		public byte BlackGhost_Berserker_Sign => (byte)_row["BlackGhost_Berserker_Sign"].Value;
		public byte BlackGhost_None_Invade => (byte)_row["BlackGhost_None_Invade"].Value;
		public byte BlackGhost_Umbasa_Invade => (byte)_row["BlackGhost_Umbasa_Invade"].Value;
		public byte BlackGhost_Berserker_Invade => (byte)_row["BlackGhost_Berserker_Invade"].Value;
		public byte RedHunter1 => (byte)_row["RedHunter1"].Value;
		public byte RedHunter2 => (byte)_row["RedHunter2"].Value;
		public byte GuardianOfForest => (byte)_row["GuardianOfForest"].Value;
		public byte GuardianOfAnor => (byte)_row["GuardianOfAnor"].Value;
		public byte BattleRoyal => (byte)_row["BattleRoyal"].Value;
		public byte YellowMonk => (byte)_row["YellowMonk"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | host: {host} | WhiteGhost_None: {WhiteGhost_None} | WhiteGhost_Umbasa: {WhiteGhost_Umbasa} | WhiteGhost_Berserker: {WhiteGhost_Berserker} | BlackGhost_None_Sign: {BlackGhost_None_Sign} | BlackGhost_Umbasa_Sign: {BlackGhost_Umbasa_Sign} | BlackGhost_Berserker_Sign: {BlackGhost_Berserker_Sign} | BlackGhost_None_Invade: {BlackGhost_None_Invade} | BlackGhost_Umbasa_Invade: {BlackGhost_Umbasa_Invade} | BlackGhost_Berserker_Invade: {BlackGhost_Berserker_Invade} | RedHunter1: {RedHunter1} | RedHunter2: {RedHunter2} | GuardianOfForest: {GuardianOfForest} | GuardianOfAnor: {GuardianOfAnor} | BattleRoyal: {BattleRoyal} | YellowMonk: {YellowMonk}";
	}
}
