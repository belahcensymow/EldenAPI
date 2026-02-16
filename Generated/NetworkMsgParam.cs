using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class NetworkMsgParam
	{
		private readonly PARAM _param;
		public NetworkMsgParam(PARAM param) => _param = param;
		public IEnumerable<NetworkMsgParamRow> Entries => _param.Rows.Select(r => new NetworkMsgParamRow(r));
	}
	public class NetworkMsgParamRow
	{
		private readonly PARAM.Row _row;
		public NetworkMsgParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public ushort priority => (ushort)_row["priority"].Value;
		public byte forcePlay => (byte)_row["forcePlay"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public int normalWhite => (int)_row["normalWhite"].Value;
		public int umbasaWhite => (int)_row["umbasaWhite"].Value;
		public int berserkerWhite => (int)_row["berserkerWhite"].Value;
		public int sinnerHeroWhite => (int)_row["sinnerHeroWhite"].Value;
		public int normalBlack => (int)_row["normalBlack"].Value;
		public int umbasaBlack => (int)_row["umbasaBlack"].Value;
		public int berserkerBlack => (int)_row["berserkerBlack"].Value;
		public int forceJoinBlack => (int)_row["forceJoinBlack"].Value;
		public int forceJoinUmbasaBlack => (int)_row["forceJoinUmbasaBlack"].Value;
		public int forceJoinBerserkerBlack => (int)_row["forceJoinBerserkerBlack"].Value;
		public int sinnerHunterVisitor => (int)_row["sinnerHunterVisitor"].Value;
		public int redHunterVisitor => (int)_row["redHunterVisitor"].Value;
		public int guardianOfBossVisitor => (int)_row["guardianOfBossVisitor"].Value;
		public int guardianOfForestMapVisitor => (int)_row["guardianOfForestMapVisitor"].Value;
		public int guardianOfAnolisVisitor => (int)_row["guardianOfAnolisVisitor"].Value;
		public int rosaliaBlack => (int)_row["rosaliaBlack"].Value;
		public int forceJoinRosaliaBlack => (int)_row["forceJoinRosaliaBlack"].Value;
		public int redHunterVisitor2 => (int)_row["redHunterVisitor2"].Value;
		public int npc1 => (int)_row["npc1"].Value;
		public int npc2 => (int)_row["npc2"].Value;
		public int npc3 => (int)_row["npc3"].Value;
		public int npc4 => (int)_row["npc4"].Value;
		public int battleRoyal => (int)_row["battleRoyal"].Value;
		public int npc5 => (int)_row["npc5"].Value;
		public int npc6 => (int)_row["npc6"].Value;
		public int npc7 => (int)_row["npc7"].Value;
		public int npc8 => (int)_row["npc8"].Value;
		public int npc9 => (int)_row["npc9"].Value;
		public int npc10 => (int)_row["npc10"].Value;
		public int npc11 => (int)_row["npc11"].Value;
		public int npc12 => (int)_row["npc12"].Value;
		public int npc13 => (int)_row["npc13"].Value;
		public int npc14 => (int)_row["npc14"].Value;
		public int npc15 => (int)_row["npc15"].Value;
		public int npc16 => (int)_row["npc16"].Value;
		public int forceJoinBlack_B => (int)_row["forceJoinBlack_B"].Value;
		public int normalWhite_Npc => (int)_row["normalWhite_Npc"].Value;
		public int forceJoinBlack_Npc => (int)_row["forceJoinBlack_Npc"].Value;
		public int forceJoinBlack_B_Npc => (int)_row["forceJoinBlack_B_Npc"].Value;
		public int forceJoinBlack_C_Npc => (int)_row["forceJoinBlack_C_Npc"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | priority: {priority} | forcePlay: {forcePlay} | normalWhite: {normalWhite} | umbasaWhite: {umbasaWhite} | berserkerWhite: {berserkerWhite} | sinnerHeroWhite: {sinnerHeroWhite} | normalBlack: {normalBlack} | umbasaBlack: {umbasaBlack} | berserkerBlack: {berserkerBlack} | forceJoinBlack: {forceJoinBlack} | forceJoinUmbasaBlack: {forceJoinUmbasaBlack} | forceJoinBerserkerBlack: {forceJoinBerserkerBlack} | sinnerHunterVisitor: {sinnerHunterVisitor} | redHunterVisitor: {redHunterVisitor} | guardianOfBossVisitor: {guardianOfBossVisitor} | guardianOfForestMapVisitor: {guardianOfForestMapVisitor} | guardianOfAnolisVisitor: {guardianOfAnolisVisitor} | rosaliaBlack: {rosaliaBlack} | forceJoinRosaliaBlack: {forceJoinRosaliaBlack} | redHunterVisitor2: {redHunterVisitor2} | npc1: {npc1} | npc2: {npc2} | npc3: {npc3} | npc4: {npc4} | battleRoyal: {battleRoyal} | npc5: {npc5} | npc6: {npc6} | npc7: {npc7} | npc8: {npc8} | npc9: {npc9} | npc10: {npc10} | npc11: {npc11} | npc12: {npc12} | npc13: {npc13} | npc14: {npc14} | npc15: {npc15} | npc16: {npc16} | forceJoinBlack_B: {forceJoinBlack_B} | normalWhite_Npc: {normalWhite_Npc} | forceJoinBlack_Npc: {forceJoinBlack_Npc} | forceJoinBlack_B_Npc: {forceJoinBlack_B_Npc} | forceJoinBlack_C_Npc: {forceJoinBlack_C_Npc}";
	}
}
