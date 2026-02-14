using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class ResistCorrectParam
	{
		private readonly PARAM _param;
		public ResistCorrectParam(PARAM param) => _param = param;
		public IEnumerable<ResistCorrectParamRow> Entries => _param.Rows.Select(r => new ResistCorrectParamRow(r));
	}
	public class ResistCorrectParamRow
	{
		private readonly PARAM.Row _row;
		public ResistCorrectParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float addPoint1 => (float)_row["addPoint1"].Value;
		public float addPoint2 => (float)_row["addPoint2"].Value;
		public float addPoint3 => (float)_row["addPoint3"].Value;
		public float addPoint4 => (float)_row["addPoint4"].Value;
		public float addPoint5 => (float)_row["addPoint5"].Value;
		public float addRate1 => (float)_row["addRate1"].Value;
		public float addRate2 => (float)_row["addRate2"].Value;
		public float addRate3 => (float)_row["addRate3"].Value;
		public float addRate4 => (float)_row["addRate4"].Value;
		public float addRate5 => (float)_row["addRate5"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | addPoint1: {addPoint1} | addPoint2: {addPoint2} | addPoint3: {addPoint3} | addPoint4: {addPoint4} | addPoint5: {addPoint5} | addRate1: {addRate1} | addRate2: {addRate2} | addRate3: {addRate3} | addRate4: {addRate4} | addRate5: {addRate5}";
	}
}
