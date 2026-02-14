using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class WwiseValueToStrConvertParamFormat
	{
		private readonly PARAM _param;
		public WwiseValueToStrConvertParamFormat(PARAM param) => _param = param;
		public IEnumerable<WwiseValueToStrConvertParamFormatRow> Entries => _param.Rows.Select(r => new WwiseValueToStrConvertParamFormatRow(r));
	}
	public class WwiseValueToStrConvertParamFormatRow
	{
		private readonly PARAM.Row _row;
		public WwiseValueToStrConvertParamFormatRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] disableParam_NT => (byte[])_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public string ParamStr => (string)_row["ParamStr"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | ParamStr: {ParamStr}";
	}
}
