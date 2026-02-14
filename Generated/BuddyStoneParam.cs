using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class BuddyStoneParam
	{
		private readonly PARAM _param;
		public BuddyStoneParam(PARAM param) => _param = param;
		public IEnumerable<BuddyStoneParamRow> Entries => _param.Rows.Select(r => new BuddyStoneParamRow(r));
	}
	public class BuddyStoneParamRow
	{
		private readonly PARAM.Row _row;
		public BuddyStoneParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] disableParam_NT => (byte[])_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public uint talkChrEntityId => (uint)_row["talkChrEntityId"].Value;
		public uint eliminateTargetEntityId => (uint)_row["eliminateTargetEntityId"].Value;
		public uint summonedEventFlagId => (uint)_row["summonedEventFlagId"].Value;
		public byte[] isSpecial => (byte[])_row["isSpecial"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public int buddyId => (int)_row["buddyId"].Value;
		public int dopingSpEffectId => (int)_row["dopingSpEffectId"].Value;
		public ushort activateRange => (ushort)_row["activateRange"].Value;
		public short overwriteReturnRange => (short)_row["overwriteReturnRange"].Value;
		public uint overwriteActivateRegionEntityId => (uint)_row["overwriteActivateRegionEntityId"].Value;
		public uint warnRegionEntityId => (uint)_row["warnRegionEntityId"].Value;
		public byte[] pad3 => (byte[])_row["pad3"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | talkChrEntityId: {talkChrEntityId} | eliminateTargetEntityId: {eliminateTargetEntityId} | summonedEventFlagId: {summonedEventFlagId} | buddyId: {buddyId} | dopingSpEffectId: {dopingSpEffectId} | activateRange: {activateRange} | overwriteReturnRange: {overwriteReturnRange} | overwriteActivateRegionEntityId: {overwriteActivateRegionEntityId} | warnRegionEntityId: {warnRegionEntityId}";
	}
}
