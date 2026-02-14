using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class ShopLineupParam
	{
		private readonly PARAM _param;
		public ShopLineupParam(PARAM param) => _param = param;
		public IEnumerable<ShopLineupParamRow> Entries => _param.Rows.Select(r => new ShopLineupParamRow(r));
	}
	public class ShopLineupParamRow
	{
		private readonly PARAM.Row _row;
		public ShopLineupParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int equipId => (int)_row["equipId"].Value;
		public int value => (int)_row["value"].Value;
		public int mtrlId => (int)_row["mtrlId"].Value;
		public uint eventFlag_forStock => (uint)_row["eventFlag_forStock"].Value;
		public uint eventFlag_forRelease => (uint)_row["eventFlag_forRelease"].Value;
		public short sellQuantity => (short)_row["sellQuantity"].Value;
		public byte[] pad3 => (byte[])_row["pad3"].Value;
		public byte[] equipType => (byte[])_row["equipType"].Value;
		public byte[] costType => (byte[])_row["costType"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public ushort setNum => (ushort)_row["setNum"].Value;
		public int value_Add => (int)_row["value_Add"].Value;
		public float value_Magnification => (float)_row["value_Magnification"].Value;
		public int iconId => (int)_row["iconId"].Value;
		public int nameMsgId => (int)_row["nameMsgId"].Value;
		public int menuTitleMsgId => (int)_row["menuTitleMsgId"].Value;
		public short menuIconId => (short)_row["menuIconId"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | equipId: {equipId} | value: {value} | mtrlId: {mtrlId} | eventFlag_forStock: {eventFlag_forStock} | eventFlag_forRelease: {eventFlag_forRelease} | sellQuantity: {sellQuantity} | setNum: {setNum} | value_Add: {value_Add} | value_Magnification: {value_Magnification} | iconId: {iconId} | nameMsgId: {nameMsgId} | menuTitleMsgId: {menuTitleMsgId} | menuIconId: {menuIconId}";
	}
}
