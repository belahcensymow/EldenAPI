using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class CutsceneGparamTimeParam
	{
		private readonly PARAM _param;
		public CutsceneGparamTimeParam(PARAM param) => _param = param;
		public IEnumerable<CutsceneGparamTimeParamRow> Entries => _param.Rows.Select(r => new CutsceneGparamTimeParamRow(r));
	}
	public class CutsceneGparamTimeParamRow
	{
		private readonly PARAM.Row _row;
		public CutsceneGparamTimeParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte disableParam_NT => (byte)_row["disableParam_NT"].Value;
		public byte disableParam_Debug => (byte)_row["disableParam_Debug"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public byte DstTimezone_Morning => (byte)_row["DstTimezone_Morning"].Value;
		public byte DstTimezone_Noon => (byte)_row["DstTimezone_Noon"].Value;
		public byte DstTimezone_AfterNoon => (byte)_row["DstTimezone_AfterNoon"].Value;
		public byte DstTimezone_Evening => (byte)_row["DstTimezone_Evening"].Value;
		public byte DstTimezone_Night => (byte)_row["DstTimezone_Night"].Value;
		public byte DstTimezone_DeepNightA => (byte)_row["DstTimezone_DeepNightA"].Value;
		public byte DstTimezone_DeepNightB => (byte)_row["DstTimezone_DeepNightB"].Value;
		public byte[] reserved => (byte[])_row["reserved"].Value;
		public float PostPlayIngameTime => (float)_row["PostPlayIngameTime"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | disableParam_NT: {disableParam_NT} | disableParam_Debug: {disableParam_Debug} | DstTimezone_Morning: {DstTimezone_Morning} | DstTimezone_Noon: {DstTimezone_Noon} | DstTimezone_AfterNoon: {DstTimezone_AfterNoon} | DstTimezone_Evening: {DstTimezone_Evening} | DstTimezone_Night: {DstTimezone_Night} | DstTimezone_DeepNightA: {DstTimezone_DeepNightA} | DstTimezone_DeepNightB: {DstTimezone_DeepNightB} | PostPlayIngameTime: {PostPlayIngameTime}";
	}
}
