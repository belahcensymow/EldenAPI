using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class ItemlotParam
	{
		private readonly PARAM _param;
		public ItemlotParam(PARAM param) => _param = param;
		public IEnumerable<ItemlotParamRow> Entries => _param.Rows.Select(r => new ItemlotParamRow(r));
	}
	public class ItemlotParamRow
	{
		private readonly PARAM.Row _row;
		public ItemlotParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int lotItemId01 => (int)_row["lotItemId01"].Value;
		public int lotItemId02 => (int)_row["lotItemId02"].Value;
		public int lotItemId03 => (int)_row["lotItemId03"].Value;
		public int lotItemId04 => (int)_row["lotItemId04"].Value;
		public int lotItemId05 => (int)_row["lotItemId05"].Value;
		public int lotItemId06 => (int)_row["lotItemId06"].Value;
		public int lotItemId07 => (int)_row["lotItemId07"].Value;
		public int lotItemId08 => (int)_row["lotItemId08"].Value;
		public byte[] lotItemCategory01 => (byte[])_row["lotItemCategory01"].Value;
		public byte[] lotItemCategory02 => (byte[])_row["lotItemCategory02"].Value;
		public byte[] lotItemCategory03 => (byte[])_row["lotItemCategory03"].Value;
		public byte[] lotItemCategory04 => (byte[])_row["lotItemCategory04"].Value;
		public byte[] lotItemCategory05 => (byte[])_row["lotItemCategory05"].Value;
		public byte[] lotItemCategory06 => (byte[])_row["lotItemCategory06"].Value;
		public byte[] lotItemCategory07 => (byte[])_row["lotItemCategory07"].Value;
		public byte[] lotItemCategory08 => (byte[])_row["lotItemCategory08"].Value;
		public ushort lotItemBasePoint01 => (ushort)_row["lotItemBasePoint01"].Value;
		public ushort lotItemBasePoint02 => (ushort)_row["lotItemBasePoint02"].Value;
		public ushort lotItemBasePoint03 => (ushort)_row["lotItemBasePoint03"].Value;
		public ushort lotItemBasePoint04 => (ushort)_row["lotItemBasePoint04"].Value;
		public ushort lotItemBasePoint05 => (ushort)_row["lotItemBasePoint05"].Value;
		public ushort lotItemBasePoint06 => (ushort)_row["lotItemBasePoint06"].Value;
		public ushort lotItemBasePoint07 => (ushort)_row["lotItemBasePoint07"].Value;
		public ushort lotItemBasePoint08 => (ushort)_row["lotItemBasePoint08"].Value;
		public ushort cumulateLotPoint01 => (ushort)_row["cumulateLotPoint01"].Value;
		public ushort cumulateLotPoint02 => (ushort)_row["cumulateLotPoint02"].Value;
		public ushort cumulateLotPoint03 => (ushort)_row["cumulateLotPoint03"].Value;
		public ushort cumulateLotPoint04 => (ushort)_row["cumulateLotPoint04"].Value;
		public ushort cumulateLotPoint05 => (ushort)_row["cumulateLotPoint05"].Value;
		public ushort cumulateLotPoint06 => (ushort)_row["cumulateLotPoint06"].Value;
		public ushort cumulateLotPoint07 => (ushort)_row["cumulateLotPoint07"].Value;
		public ushort cumulateLotPoint08 => (ushort)_row["cumulateLotPoint08"].Value;
		public uint getItemFlagId01 => (uint)_row["getItemFlagId01"].Value;
		public uint getItemFlagId02 => (uint)_row["getItemFlagId02"].Value;
		public uint getItemFlagId03 => (uint)_row["getItemFlagId03"].Value;
		public uint getItemFlagId04 => (uint)_row["getItemFlagId04"].Value;
		public uint getItemFlagId05 => (uint)_row["getItemFlagId05"].Value;
		public uint getItemFlagId06 => (uint)_row["getItemFlagId06"].Value;
		public uint getItemFlagId07 => (uint)_row["getItemFlagId07"].Value;
		public uint getItemFlagId08 => (uint)_row["getItemFlagId08"].Value;
		public uint getItemFlagId => (uint)_row["getItemFlagId"].Value;
		public uint cumulateNumFlagId => (uint)_row["cumulateNumFlagId"].Value;
		public byte cumulateNumMax => (byte)_row["cumulateNumMax"].Value;
		public sbyte lotItem_Rarity => (sbyte)_row["lotItem_Rarity"].Value;
		public byte lotItemNum01 => (byte)_row["lotItemNum01"].Value;
		public byte lotItemNum02 => (byte)_row["lotItemNum02"].Value;
		public byte lotItemNum03 => (byte)_row["lotItemNum03"].Value;
		public byte lotItemNum04 => (byte)_row["lotItemNum04"].Value;
		public byte lotItemNum05 => (byte)_row["lotItemNum05"].Value;
		public byte lotItemNum06 => (byte)_row["lotItemNum06"].Value;
		public byte lotItemNum07 => (byte)_row["lotItemNum07"].Value;
		public byte lotItemNum08 => (byte)_row["lotItemNum08"].Value;
		public byte[] enableLuck01 => (byte[])_row["enableLuck01"].Value;
		public byte[] enableLuck02 => (byte[])_row["enableLuck02"].Value;
		public byte[] enableLuck03 => (byte[])_row["enableLuck03"].Value;
		public byte[] enableLuck04 => (byte[])_row["enableLuck04"].Value;
		public byte[] enableLuck05 => (byte[])_row["enableLuck05"].Value;
		public byte[] enableLuck06 => (byte[])_row["enableLuck06"].Value;
		public byte[] enableLuck07 => (byte[])_row["enableLuck07"].Value;
		public byte[] enableLuck08 => (byte[])_row["enableLuck08"].Value;
		public byte[] cumulateReset01 => (byte[])_row["cumulateReset01"].Value;
		public byte[] cumulateReset02 => (byte[])_row["cumulateReset02"].Value;
		public byte[] cumulateReset03 => (byte[])_row["cumulateReset03"].Value;
		public byte[] cumulateReset04 => (byte[])_row["cumulateReset04"].Value;
		public byte[] cumulateReset05 => (byte[])_row["cumulateReset05"].Value;
		public byte[] cumulateReset06 => (byte[])_row["cumulateReset06"].Value;
		public byte[] cumulateReset07 => (byte[])_row["cumulateReset07"].Value;
		public byte[] cumulateReset08 => (byte[])_row["cumulateReset08"].Value;
		public byte[] GameClearOffset => (byte[])_row["GameClearOffset"].Value;
		public byte[] canExecByFriendlyGhost => (byte[])_row["canExecByFriendlyGhost"].Value;
		public byte[] canExecByHostileGhost => (byte[])_row["canExecByHostileGhost"].Value;
		public byte PAD1 => (byte)_row["PAD1"].Value;
		public ushort PAD2 => (ushort)_row["PAD2"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | lotItemId01: {lotItemId01} | lotItemId02: {lotItemId02} | lotItemId03: {lotItemId03} | lotItemId04: {lotItemId04} | lotItemId05: {lotItemId05} | lotItemId06: {lotItemId06} | lotItemId07: {lotItemId07} | lotItemId08: {lotItemId08} | lotItemBasePoint01: {lotItemBasePoint01} | lotItemBasePoint02: {lotItemBasePoint02} | lotItemBasePoint03: {lotItemBasePoint03} | lotItemBasePoint04: {lotItemBasePoint04} | lotItemBasePoint05: {lotItemBasePoint05} | lotItemBasePoint06: {lotItemBasePoint06} | lotItemBasePoint07: {lotItemBasePoint07} | lotItemBasePoint08: {lotItemBasePoint08} | cumulateLotPoint01: {cumulateLotPoint01} | cumulateLotPoint02: {cumulateLotPoint02} | cumulateLotPoint03: {cumulateLotPoint03} | cumulateLotPoint04: {cumulateLotPoint04} | cumulateLotPoint05: {cumulateLotPoint05} | cumulateLotPoint06: {cumulateLotPoint06} | cumulateLotPoint07: {cumulateLotPoint07} | cumulateLotPoint08: {cumulateLotPoint08} | getItemFlagId01: {getItemFlagId01} | getItemFlagId02: {getItemFlagId02} | getItemFlagId03: {getItemFlagId03} | getItemFlagId04: {getItemFlagId04} | getItemFlagId05: {getItemFlagId05} | getItemFlagId06: {getItemFlagId06} | getItemFlagId07: {getItemFlagId07} | getItemFlagId08: {getItemFlagId08} | getItemFlagId: {getItemFlagId} | cumulateNumFlagId: {cumulateNumFlagId} | cumulateNumMax: {cumulateNumMax} | lotItem_Rarity: {lotItem_Rarity} | lotItemNum01: {lotItemNum01} | lotItemNum02: {lotItemNum02} | lotItemNum03: {lotItemNum03} | lotItemNum04: {lotItemNum04} | lotItemNum05: {lotItemNum05} | lotItemNum06: {lotItemNum06} | lotItemNum07: {lotItemNum07} | lotItemNum08: {lotItemNum08} | PAD1: {PAD1} | PAD2: {PAD2}";
	}
}
