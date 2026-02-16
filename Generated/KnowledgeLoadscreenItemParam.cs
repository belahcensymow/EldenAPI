using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class KnowledgeLoadscreenItemParam
	{
		private readonly PARAM _param;
		public KnowledgeLoadscreenItemParam(PARAM param) => _param = param;
		public IEnumerable<KnowledgeLoadscreenItemParamRow> Entries => _param.Rows.Select(r => new KnowledgeLoadscreenItemParamRow(r));
	}
	public class KnowledgeLoadscreenItemParamRow
	{
		private readonly PARAM.Row _row;
		public KnowledgeLoadscreenItemParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte disableParam_NT => (byte)_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public uint unlockFlagId => (uint)_row["unlockFlagId"].Value;
		public uint invalidFlagId => (uint)_row["invalidFlagId"].Value;
		public int msgId => (int)_row["msgId"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | disableParam_NT: {disableParam_NT} | unlockFlagId: {unlockFlagId} | invalidFlagId: {invalidFlagId} | msgId: {msgId}";
	}
}
