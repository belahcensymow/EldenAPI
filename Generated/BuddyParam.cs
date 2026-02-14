using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class BuddyParam
	{
		private readonly PARAM _param;
		public BuddyParam(PARAM param) => _param = param;
		public IEnumerable<BuddyParamRow> Entries => _param.Rows.Select(r => new BuddyParamRow(r));
	}
	public class BuddyParamRow
	{
		private readonly PARAM.Row _row;
		public BuddyParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] disableParam_NT => (byte[])_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public int triggerSpEffectId => (int)_row["triggerSpEffectId"].Value;
		public int npcParamId => (int)_row["npcParamId"].Value;
		public int npcThinkParamId => (int)_row["npcThinkParamId"].Value;
		public int npcParamId_ridden => (int)_row["npcParamId_ridden"].Value;
		public int npcThinkParamId_ridden => (int)_row["npcThinkParamId_ridden"].Value;
		public float x_offset => (float)_row["x_offset"].Value;
		public float z_offset => (float)_row["z_offset"].Value;
		public float y_angle => (float)_row["y_angle"].Value;
		public byte[] appearOnAroundSekihi => (byte[])_row["appearOnAroundSekihi"].Value;
		public byte[] disablePCTargetShare => (byte[])_row["disablePCTargetShare"].Value;
		public byte[] pcFollowType => (byte[])_row["pcFollowType"].Value;
		public byte[] Reserve => (byte[])_row["Reserve"].Value;
		public int dopingSpEffect_lv0 => (int)_row["dopingSpEffect_lv0"].Value;
		public int dopingSpEffect_lv1 => (int)_row["dopingSpEffect_lv1"].Value;
		public int dopingSpEffect_lv2 => (int)_row["dopingSpEffect_lv2"].Value;
		public int dopingSpEffect_lv3 => (int)_row["dopingSpEffect_lv3"].Value;
		public int dopingSpEffect_lv4 => (int)_row["dopingSpEffect_lv4"].Value;
		public int dopingSpEffect_lv5 => (int)_row["dopingSpEffect_lv5"].Value;
		public int dopingSpEffect_lv6 => (int)_row["dopingSpEffect_lv6"].Value;
		public int dopingSpEffect_lv7 => (int)_row["dopingSpEffect_lv7"].Value;
		public int dopingSpEffect_lv8 => (int)_row["dopingSpEffect_lv8"].Value;
		public int dopingSpEffect_lv9 => (int)_row["dopingSpEffect_lv9"].Value;
		public int dopingSpEffect_lv10 => (int)_row["dopingSpEffect_lv10"].Value;
		public int npcPlayerInitParamId => (int)_row["npcPlayerInitParamId"].Value;
		public int generateAnimId => (int)_row["generateAnimId"].Value;
		public byte[] Reserve2 => (byte[])_row["Reserve2"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | triggerSpEffectId: {triggerSpEffectId} | npcParamId: {npcParamId} | npcThinkParamId: {npcThinkParamId} | npcParamId_ridden: {npcParamId_ridden} | npcThinkParamId_ridden: {npcThinkParamId_ridden} | x_offset: {x_offset} | z_offset: {z_offset} | y_angle: {y_angle} | dopingSpEffect_lv0: {dopingSpEffect_lv0} | dopingSpEffect_lv1: {dopingSpEffect_lv1} | dopingSpEffect_lv2: {dopingSpEffect_lv2} | dopingSpEffect_lv3: {dopingSpEffect_lv3} | dopingSpEffect_lv4: {dopingSpEffect_lv4} | dopingSpEffect_lv5: {dopingSpEffect_lv5} | dopingSpEffect_lv6: {dopingSpEffect_lv6} | dopingSpEffect_lv7: {dopingSpEffect_lv7} | dopingSpEffect_lv8: {dopingSpEffect_lv8} | dopingSpEffect_lv9: {dopingSpEffect_lv9} | dopingSpEffect_lv10: {dopingSpEffect_lv10} | npcPlayerInitParamId: {npcPlayerInitParamId} | generateAnimId: {generateAnimId}";
	}
}
