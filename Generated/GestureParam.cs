using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class GestureParam
	{
		private readonly PARAM _param;
		public GestureParam(PARAM param) => _param = param;
		public IEnumerable<GestureParamRow> Entries => _param.Rows.Select(r => new GestureParamRow(r));
	}
	public class GestureParamRow
	{
		private readonly PARAM.Row _row;
		public GestureParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] disableParam_NT => (byte[])_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public int itemId => (int)_row["itemId"].Value;
		public int msgAnimId => (int)_row["msgAnimId"].Value;
		public byte[] cannotUseRiding => (byte[])_row["cannotUseRiding"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | itemId: {itemId} | msgAnimId: {msgAnimId}";
	}
}
