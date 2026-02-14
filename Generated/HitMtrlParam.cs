using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class HitMtrlParam
	{
		private readonly PARAM _param;
		public HitMtrlParam(PARAM param) => _param = param;
		public IEnumerable<HitMtrlParamRow> Entries => _param.Rows.Select(r => new HitMtrlParamRow(r));
	}
	public class HitMtrlParamRow
	{
		private readonly PARAM.Row _row;
		public HitMtrlParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float aiVolumeRate => (float)_row["aiVolumeRate"].Value;
		public int spEffectIdOnHit0 => (int)_row["spEffectIdOnHit0"].Value;
		public int spEffectIdOnHit1 => (int)_row["spEffectIdOnHit1"].Value;
		public byte[] footEffectHeightType => (byte[])_row["footEffectHeightType"].Value;
		public byte[] footEffectDirType => (byte[])_row["footEffectDirType"].Value;
		public byte[] floorHeightType => (byte[])_row["floorHeightType"].Value;
		public byte disableFallDamage => (byte)_row["disableFallDamage"].Value;
		public byte isHardnessForSoundReverb => (byte)_row["isHardnessForSoundReverb"].Value;
		public byte[] hardnessType => (byte[])_row["hardnessType"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public int spEffectIdOnHit0_ClearCount_2 => (int)_row["spEffectIdOnHit0_ClearCount_2"].Value;
		public int spEffectIdOnHit0_ClearCount_3 => (int)_row["spEffectIdOnHit0_ClearCount_3"].Value;
		public int spEffectIdOnHit0_ClearCount_4 => (int)_row["spEffectIdOnHit0_ClearCount_4"].Value;
		public int spEffectIdOnHit0_ClearCount_5 => (int)_row["spEffectIdOnHit0_ClearCount_5"].Value;
		public int spEffectIdOnHit0_ClearCount_6 => (int)_row["spEffectIdOnHit0_ClearCount_6"].Value;
		public int spEffectIdOnHit0_ClearCount_7 => (int)_row["spEffectIdOnHit0_ClearCount_7"].Value;
		public int spEffectIdOnHit0_ClearCount_8 => (int)_row["spEffectIdOnHit0_ClearCount_8"].Value;
		public int spEffectIdOnHit1_ClearCount_2 => (int)_row["spEffectIdOnHit1_ClearCount_2"].Value;
		public int spEffectIdOnHit1_ClearCount_3 => (int)_row["spEffectIdOnHit1_ClearCount_3"].Value;
		public int spEffectIdOnHit1_ClearCount_4 => (int)_row["spEffectIdOnHit1_ClearCount_4"].Value;
		public int spEffectIdOnHit1_ClearCount_5 => (int)_row["spEffectIdOnHit1_ClearCount_5"].Value;
		public int spEffectIdOnHit1_ClearCount_6 => (int)_row["spEffectIdOnHit1_ClearCount_6"].Value;
		public int spEffectIdOnHit1_ClearCount_7 => (int)_row["spEffectIdOnHit1_ClearCount_7"].Value;
		public int spEffectIdOnHit1_ClearCount_8 => (int)_row["spEffectIdOnHit1_ClearCount_8"].Value;
		public short replaceMateiralId_Rain => (short)_row["replaceMateiralId_Rain"].Value;
		public byte[] pad4 => (byte[])_row["pad4"].Value;
		public int spEffectId_forWet00 => (int)_row["spEffectId_forWet00"].Value;
		public int spEffectId_forWet01 => (int)_row["spEffectId_forWet01"].Value;
		public int spEffectId_forWet02 => (int)_row["spEffectId_forWet02"].Value;
		public int spEffectId_forWet03 => (int)_row["spEffectId_forWet03"].Value;
		public int spEffectId_forWet04 => (int)_row["spEffectId_forWet04"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | aiVolumeRate: {aiVolumeRate} | spEffectIdOnHit0: {spEffectIdOnHit0} | spEffectIdOnHit1: {spEffectIdOnHit1} | disableFallDamage: {disableFallDamage} | isHardnessForSoundReverb: {isHardnessForSoundReverb} | spEffectIdOnHit0_ClearCount_2: {spEffectIdOnHit0_ClearCount_2} | spEffectIdOnHit0_ClearCount_3: {spEffectIdOnHit0_ClearCount_3} | spEffectIdOnHit0_ClearCount_4: {spEffectIdOnHit0_ClearCount_4} | spEffectIdOnHit0_ClearCount_5: {spEffectIdOnHit0_ClearCount_5} | spEffectIdOnHit0_ClearCount_6: {spEffectIdOnHit0_ClearCount_6} | spEffectIdOnHit0_ClearCount_7: {spEffectIdOnHit0_ClearCount_7} | spEffectIdOnHit0_ClearCount_8: {spEffectIdOnHit0_ClearCount_8} | spEffectIdOnHit1_ClearCount_2: {spEffectIdOnHit1_ClearCount_2} | spEffectIdOnHit1_ClearCount_3: {spEffectIdOnHit1_ClearCount_3} | spEffectIdOnHit1_ClearCount_4: {spEffectIdOnHit1_ClearCount_4} | spEffectIdOnHit1_ClearCount_5: {spEffectIdOnHit1_ClearCount_5} | spEffectIdOnHit1_ClearCount_6: {spEffectIdOnHit1_ClearCount_6} | spEffectIdOnHit1_ClearCount_7: {spEffectIdOnHit1_ClearCount_7} | spEffectIdOnHit1_ClearCount_8: {spEffectIdOnHit1_ClearCount_8} | replaceMateiralId_Rain: {replaceMateiralId_Rain} | spEffectId_forWet00: {spEffectId_forWet00} | spEffectId_forWet01: {spEffectId_forWet01} | spEffectId_forWet02: {spEffectId_forWet02} | spEffectId_forWet03: {spEffectId_forWet03} | spEffectId_forWet04: {spEffectId_forWet04}";
	}
}
