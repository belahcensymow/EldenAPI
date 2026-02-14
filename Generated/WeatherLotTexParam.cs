using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class WeatherLotTexParam
	{
		private readonly PARAM _param;
		public WeatherLotTexParam(PARAM param) => _param = param;
		public IEnumerable<WeatherLotTexParamRow> Entries => _param.Rows.Select(r => new WeatherLotTexParamRow(r));
	}
	public class WeatherLotTexParamRow
	{
		private readonly PARAM.Row _row;
		public WeatherLotTexParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] disableParam_NT => (byte[])_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public byte srcR => (byte)_row["srcR"].Value;
		public byte srcG => (byte)_row["srcG"].Value;
		public byte srcB => (byte)_row["srcB"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public int weatherLogId => (int)_row["weatherLogId"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | srcR: {srcR} | srcG: {srcG} | srcB: {srcB} | weatherLogId: {weatherLogId}";
	}
}
