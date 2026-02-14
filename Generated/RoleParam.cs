using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class RoleParam
	{
		private readonly PARAM _param;
		public RoleParam(PARAM param) => _param = param;
		public IEnumerable<RoleParamRow> Entries => _param.Rows.Select(r => new RoleParamRow(r));
	}
	public class RoleParamRow
	{
		private readonly PARAM.Row _row;
		public RoleParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] teamType => (byte[])_row["teamType"].Value;
		public byte[] pad10 => (byte[])_row["pad10"].Value;
		public int phantomParamId => (int)_row["phantomParamId"].Value;
		public int spEffectID0 => (int)_row["spEffectID0"].Value;
		public int spEffectID1 => (int)_row["spEffectID1"].Value;
		public int spEffectID2 => (int)_row["spEffectID2"].Value;
		public int spEffectID3 => (int)_row["spEffectID3"].Value;
		public int spEffectID4 => (int)_row["spEffectID4"].Value;
		public int spEffectID5 => (int)_row["spEffectID5"].Value;
		public int spEffectID6 => (int)_row["spEffectID6"].Value;
		public int spEffectID7 => (int)_row["spEffectID7"].Value;
		public int spEffectID8 => (int)_row["spEffectID8"].Value;
		public int spEffectID9 => (int)_row["spEffectID9"].Value;
		public int sosSignSfxId => (int)_row["sosSignSfxId"].Value;
		public int mySosSignSfxId => (int)_row["mySosSignSfxId"].Value;
		public int summonStartAnimId => (int)_row["summonStartAnimId"].Value;
		public int itemlotParamId => (int)_row["itemlotParamId"].Value;
		public byte[] voiceChatGroup => (byte[])_row["voiceChatGroup"].Value;
		public byte[] roleNameColor => (byte[])_row["roleNameColor"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public int roleNameId => (int)_row["roleNameId"].Value;
		public uint threatLv => (uint)_row["threatLv"].Value;
		public int phantomParamId_vowRank1 => (int)_row["phantomParamId_vowRank1"].Value;
		public int phantomParamId_vowRank2 => (int)_row["phantomParamId_vowRank2"].Value;
		public int phantomParamId_vowRank3 => (int)_row["phantomParamId_vowRank3"].Value;
		public int spEffectID_vowRank0 => (int)_row["spEffectID_vowRank0"].Value;
		public int spEffectID_vowRank1 => (int)_row["spEffectID_vowRank1"].Value;
		public int spEffectID_vowRank2 => (int)_row["spEffectID_vowRank2"].Value;
		public int spEffectID_vowRank3 => (int)_row["spEffectID_vowRank3"].Value;
		public int signPhantomId => (int)_row["signPhantomId"].Value;
		public int nonPlayerSummonStartAnimId => (int)_row["nonPlayerSummonStartAnimId"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | phantomParamId: {phantomParamId} | spEffectID0: {spEffectID0} | spEffectID1: {spEffectID1} | spEffectID2: {spEffectID2} | spEffectID3: {spEffectID3} | spEffectID4: {spEffectID4} | spEffectID5: {spEffectID5} | spEffectID6: {spEffectID6} | spEffectID7: {spEffectID7} | spEffectID8: {spEffectID8} | spEffectID9: {spEffectID9} | sosSignSfxId: {sosSignSfxId} | mySosSignSfxId: {mySosSignSfxId} | summonStartAnimId: {summonStartAnimId} | itemlotParamId: {itemlotParamId} | roleNameId: {roleNameId} | threatLv: {threatLv} | phantomParamId_vowRank1: {phantomParamId_vowRank1} | phantomParamId_vowRank2: {phantomParamId_vowRank2} | phantomParamId_vowRank3: {phantomParamId_vowRank3} | spEffectID_vowRank0: {spEffectID_vowRank0} | spEffectID_vowRank1: {spEffectID_vowRank1} | spEffectID_vowRank2: {spEffectID_vowRank2} | spEffectID_vowRank3: {spEffectID_vowRank3} | signPhantomId: {signPhantomId} | nonPlayerSummonStartAnimId: {nonPlayerSummonStartAnimId}";
	}
}
