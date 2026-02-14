using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class MapGridCreateHeightDetailLimitInfo
	{
		private readonly PARAM _param;
		public MapGridCreateHeightDetailLimitInfo(PARAM param) => _param = param;
		public IEnumerable<MapGridCreateHeightDetailLimitInfoRow> Entries => _param.Rows.Select(r => new MapGridCreateHeightDetailLimitInfoRow(r));
	}
	public class MapGridCreateHeightDetailLimitInfoRow
	{
		private readonly PARAM.Row _row;
		public MapGridCreateHeightDetailLimitInfoRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int mapId => (int)_row["mapId"].Value;
		public int unknown_0x4 => (int)_row["unknown_0x4"].Value;
		public int unknown_0x8 => (int)_row["unknown_0x8"].Value;
		public int unknown_0xc => (int)_row["unknown_0xc"].Value;
		public int unknown_0x10 => (int)_row["unknown_0x10"].Value;
		public int unknown_0x14 => (int)_row["unknown_0x14"].Value;
		public int unknown_0x18 => (int)_row["unknown_0x18"].Value;
		public int unknown_0x1c => (int)_row["unknown_0x1c"].Value;
		public int unknown_0x20 => (int)_row["unknown_0x20"].Value;
		public int unknown_0x24 => (int)_row["unknown_0x24"].Value;
		public int unknown_0x28 => (int)_row["unknown_0x28"].Value;
		public byte unknown_0x2c => (byte)_row["unknown_0x2c"].Value;
		public byte unknown_0x2d => (byte)_row["unknown_0x2d"].Value;
		public byte unknown_0x2e => (byte)_row["unknown_0x2e"].Value;
		public byte unknown_0x2f => (byte)_row["unknown_0x2f"].Value;
		public byte unknown_0x30 => (byte)_row["unknown_0x30"].Value;
		public byte unknown_0x31 => (byte)_row["unknown_0x31"].Value;
		public ushort unknown_0x32 => (ushort)_row["unknown_0x32"].Value;
		public int unknown_0x34 => (int)_row["unknown_0x34"].Value;
		public int unknown_0x38 => (int)_row["unknown_0x38"].Value;
		public int unknown_0x3c => (int)_row["unknown_0x3c"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | mapId: {mapId} | unknown_0x4: {unknown_0x4} | unknown_0x8: {unknown_0x8} | unknown_0xc: {unknown_0xc} | unknown_0x10: {unknown_0x10} | unknown_0x14: {unknown_0x14} | unknown_0x18: {unknown_0x18} | unknown_0x1c: {unknown_0x1c} | unknown_0x20: {unknown_0x20} | unknown_0x24: {unknown_0x24} | unknown_0x28: {unknown_0x28} | unknown_0x2c: {unknown_0x2c} | unknown_0x2d: {unknown_0x2d} | unknown_0x2e: {unknown_0x2e} | unknown_0x2f: {unknown_0x2f} | unknown_0x30: {unknown_0x30} | unknown_0x31: {unknown_0x31} | unknown_0x32: {unknown_0x32} | unknown_0x34: {unknown_0x34} | unknown_0x38: {unknown_0x38} | unknown_0x3c: {unknown_0x3c}";
	}
}
