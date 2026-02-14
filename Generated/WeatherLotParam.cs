using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class WeatherLotParam
	{
		private readonly PARAM _param;
		public WeatherLotParam(PARAM param) => _param = param;
		public IEnumerable<WeatherLotParamRow> Entries => _param.Rows.Select(r => new WeatherLotParamRow(r));
	}
	public class WeatherLotParamRow
	{
		private readonly PARAM.Row _row;
		public WeatherLotParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] disableParam_NT => (byte[])_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public byte[] weatherType0 => (byte[])_row["weatherType0"].Value;
		public byte[] weatherType1 => (byte[])_row["weatherType1"].Value;
		public byte[] weatherType2 => (byte[])_row["weatherType2"].Value;
		public byte[] weatherType3 => (byte[])_row["weatherType3"].Value;
		public byte[] weatherType4 => (byte[])_row["weatherType4"].Value;
		public byte[] weatherType5 => (byte[])_row["weatherType5"].Value;
		public byte[] weatherType6 => (byte[])_row["weatherType6"].Value;
		public byte[] weatherType7 => (byte[])_row["weatherType7"].Value;
		public byte[] weatherType8 => (byte[])_row["weatherType8"].Value;
		public byte[] weatherType9 => (byte[])_row["weatherType9"].Value;
		public byte[] weatherType10 => (byte[])_row["weatherType10"].Value;
		public byte[] weatherType11 => (byte[])_row["weatherType11"].Value;
		public byte[] weatherType12 => (byte[])_row["weatherType12"].Value;
		public byte[] weatherType13 => (byte[])_row["weatherType13"].Value;
		public byte[] weatherType14 => (byte[])_row["weatherType14"].Value;
		public byte[] weatherType15 => (byte[])_row["weatherType15"].Value;
		public ushort lotteryWeight0 => (ushort)_row["lotteryWeight0"].Value;
		public ushort lotteryWeight1 => (ushort)_row["lotteryWeight1"].Value;
		public ushort lotteryWeight2 => (ushort)_row["lotteryWeight2"].Value;
		public ushort lotteryWeight3 => (ushort)_row["lotteryWeight3"].Value;
		public ushort lotteryWeight4 => (ushort)_row["lotteryWeight4"].Value;
		public ushort lotteryWeight5 => (ushort)_row["lotteryWeight5"].Value;
		public ushort lotteryWeight6 => (ushort)_row["lotteryWeight6"].Value;
		public ushort lotteryWeight7 => (ushort)_row["lotteryWeight7"].Value;
		public ushort lotteryWeight8 => (ushort)_row["lotteryWeight8"].Value;
		public ushort lotteryWeight9 => (ushort)_row["lotteryWeight9"].Value;
		public ushort lotteryWeight10 => (ushort)_row["lotteryWeight10"].Value;
		public ushort lotteryWeight11 => (ushort)_row["lotteryWeight11"].Value;
		public ushort lotteryWeight12 => (ushort)_row["lotteryWeight12"].Value;
		public ushort lotteryWeight13 => (ushort)_row["lotteryWeight13"].Value;
		public ushort lotteryWeight14 => (ushort)_row["lotteryWeight14"].Value;
		public ushort lotteryWeight15 => (ushort)_row["lotteryWeight15"].Value;
		public byte[] timezoneLimit => (byte[])_row["timezoneLimit"].Value;
		public byte timezoneStartHour => (byte)_row["timezoneStartHour"].Value;
		public byte timezoneStartMinute => (byte)_row["timezoneStartMinute"].Value;
		public byte timezoneEndHour => (byte)_row["timezoneEndHour"].Value;
		public byte timezoneEndMinute => (byte)_row["timezoneEndMinute"].Value;
		public byte[] reserve => (byte[])_row["reserve"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | lotteryWeight0: {lotteryWeight0} | lotteryWeight1: {lotteryWeight1} | lotteryWeight2: {lotteryWeight2} | lotteryWeight3: {lotteryWeight3} | lotteryWeight4: {lotteryWeight4} | lotteryWeight5: {lotteryWeight5} | lotteryWeight6: {lotteryWeight6} | lotteryWeight7: {lotteryWeight7} | lotteryWeight8: {lotteryWeight8} | lotteryWeight9: {lotteryWeight9} | lotteryWeight10: {lotteryWeight10} | lotteryWeight11: {lotteryWeight11} | lotteryWeight12: {lotteryWeight12} | lotteryWeight13: {lotteryWeight13} | lotteryWeight14: {lotteryWeight14} | lotteryWeight15: {lotteryWeight15} | timezoneStartHour: {timezoneStartHour} | timezoneStartMinute: {timezoneStartMinute} | timezoneEndHour: {timezoneEndHour} | timezoneEndMinute: {timezoneEndMinute}";
	}
}
