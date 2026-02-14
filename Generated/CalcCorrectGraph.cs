using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class CalcCorrectGraph
	{
		private readonly PARAM _param;
		public CalcCorrectGraph(PARAM param) => _param = param;
		public IEnumerable<CalcCorrectGraphRow> Entries => _param.Rows.Select(r => new CalcCorrectGraphRow(r));
	}
	public class CalcCorrectGraphRow
	{
		private readonly PARAM.Row _row;
		public CalcCorrectGraphRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float stageMaxVal0 => (float)_row["stageMaxVal0"].Value;
		public float stageMaxVal1 => (float)_row["stageMaxVal1"].Value;
		public float stageMaxVal2 => (float)_row["stageMaxVal2"].Value;
		public float stageMaxVal3 => (float)_row["stageMaxVal3"].Value;
		public float stageMaxVal4 => (float)_row["stageMaxVal4"].Value;
		public float stageMaxGrowVal0 => (float)_row["stageMaxGrowVal0"].Value;
		public float stageMaxGrowVal1 => (float)_row["stageMaxGrowVal1"].Value;
		public float stageMaxGrowVal2 => (float)_row["stageMaxGrowVal2"].Value;
		public float stageMaxGrowVal3 => (float)_row["stageMaxGrowVal3"].Value;
		public float stageMaxGrowVal4 => (float)_row["stageMaxGrowVal4"].Value;
		public float adjPt_maxGrowVal0 => (float)_row["adjPt_maxGrowVal0"].Value;
		public float adjPt_maxGrowVal1 => (float)_row["adjPt_maxGrowVal1"].Value;
		public float adjPt_maxGrowVal2 => (float)_row["adjPt_maxGrowVal2"].Value;
		public float adjPt_maxGrowVal3 => (float)_row["adjPt_maxGrowVal3"].Value;
		public float adjPt_maxGrowVal4 => (float)_row["adjPt_maxGrowVal4"].Value;
		public float init_inclination_soul => (float)_row["init_inclination_soul"].Value;
		public float adjustment_value => (float)_row["adjustment_value"].Value;
		public float boundry_inclination_soul => (float)_row["boundry_inclination_soul"].Value;
		public float boundry_value => (float)_row["boundry_value"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | stageMaxVal0: {stageMaxVal0} | stageMaxVal1: {stageMaxVal1} | stageMaxVal2: {stageMaxVal2} | stageMaxVal3: {stageMaxVal3} | stageMaxVal4: {stageMaxVal4} | stageMaxGrowVal0: {stageMaxGrowVal0} | stageMaxGrowVal1: {stageMaxGrowVal1} | stageMaxGrowVal2: {stageMaxGrowVal2} | stageMaxGrowVal3: {stageMaxGrowVal3} | stageMaxGrowVal4: {stageMaxGrowVal4} | adjPt_maxGrowVal0: {adjPt_maxGrowVal0} | adjPt_maxGrowVal1: {adjPt_maxGrowVal1} | adjPt_maxGrowVal2: {adjPt_maxGrowVal2} | adjPt_maxGrowVal3: {adjPt_maxGrowVal3} | adjPt_maxGrowVal4: {adjPt_maxGrowVal4} | init_inclination_soul: {init_inclination_soul} | adjustment_value: {adjustment_value} | boundry_inclination_soul: {boundry_inclination_soul} | boundry_value: {boundry_value}";
	}
}
