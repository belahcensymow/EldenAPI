using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class WhiteSignCoolTimeParam
	{
		private readonly PARAM _param;
		public WhiteSignCoolTimeParam(PARAM param) => _param = param;
		public IEnumerable<WhiteSignCoolTimeParamRow> Entries => _param.Rows.Select(r => new WhiteSignCoolTimeParamRow(r));
	}
	public class WhiteSignCoolTimeParamRow
	{
		private readonly PARAM.Row _row;
		public WhiteSignCoolTimeParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float limitationTime_Normal => (float)_row["limitationTime_Normal"].Value;
		public float limitationTime_NormalDriedFinger => (float)_row["limitationTime_NormalDriedFinger"].Value;
		public float limitationTime_Guardian => (float)_row["limitationTime_Guardian"].Value;
		public float limitationTime_GuardianDriedFinger => (float)_row["limitationTime_GuardianDriedFinger"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | limitationTime_Normal: {limitationTime_Normal} | limitationTime_NormalDriedFinger: {limitationTime_NormalDriedFinger} | limitationTime_Guardian: {limitationTime_Guardian} | limitationTime_GuardianDriedFinger: {limitationTime_GuardianDriedFinger}";
	}
}
