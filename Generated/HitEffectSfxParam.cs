using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class HitEffectSfxParam
	{
		private readonly PARAM _param;
		public HitEffectSfxParam(PARAM param) => _param = param;
		public IEnumerable<HitEffectSfxParamRow> Entries => _param.Rows.Select(r => new HitEffectSfxParamRow(r));
	}
	public class HitEffectSfxParamRow
	{
		private readonly PARAM.Row _row;
		public HitEffectSfxParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int Slash_Normal => (int)_row["Slash_Normal"].Value;
		public int Slash_S => (int)_row["Slash_S"].Value;
		public int Slash_L => (int)_row["Slash_L"].Value;
		public int Slash_Specific1 => (int)_row["Slash_Specific1"].Value;
		public int Slash_Specific2 => (int)_row["Slash_Specific2"].Value;
		public int Blow_Normal => (int)_row["Blow_Normal"].Value;
		public int Blow_S => (int)_row["Blow_S"].Value;
		public int Blow_L => (int)_row["Blow_L"].Value;
		public int Blow_Specific1 => (int)_row["Blow_Specific1"].Value;
		public int Blow_Specific2 => (int)_row["Blow_Specific2"].Value;
		public int Thrust_Normal => (int)_row["Thrust_Normal"].Value;
		public int Thrust_S => (int)_row["Thrust_S"].Value;
		public int Thrust_L => (int)_row["Thrust_L"].Value;
		public int Thrust_Specific1 => (int)_row["Thrust_Specific1"].Value;
		public int Thrust_Specific2 => (int)_row["Thrust_Specific2"].Value;
		public int Neutral_Normal => (int)_row["Neutral_Normal"].Value;
		public int Neutral_S => (int)_row["Neutral_S"].Value;
		public int Neutral_L => (int)_row["Neutral_L"].Value;
		public int Neutral_Specific1 => (int)_row["Neutral_Specific1"].Value;
		public int Neutral_Specific2 => (int)_row["Neutral_Specific2"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | Slash_Normal: {Slash_Normal} | Slash_S: {Slash_S} | Slash_L: {Slash_L} | Slash_Specific1: {Slash_Specific1} | Slash_Specific2: {Slash_Specific2} | Blow_Normal: {Blow_Normal} | Blow_S: {Blow_S} | Blow_L: {Blow_L} | Blow_Specific1: {Blow_Specific1} | Blow_Specific2: {Blow_Specific2} | Thrust_Normal: {Thrust_Normal} | Thrust_S: {Thrust_S} | Thrust_L: {Thrust_L} | Thrust_Specific1: {Thrust_Specific1} | Thrust_Specific2: {Thrust_Specific2} | Neutral_Normal: {Neutral_Normal} | Neutral_S: {Neutral_S} | Neutral_L: {Neutral_L} | Neutral_Specific1: {Neutral_Specific1} | Neutral_Specific2: {Neutral_Specific2}";
	}
}
