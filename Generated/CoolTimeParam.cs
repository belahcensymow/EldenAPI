using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class CoolTimeParam
	{
		private readonly PARAM _param;
		public CoolTimeParam(PARAM param) => _param = param;
		public IEnumerable<CoolTimeParamRow> Entries => _param.Rows.Select(r => new CoolTimeParamRow(r));
	}
	public class CoolTimeParamRow
	{
		private readonly PARAM.Row _row;
		public CoolTimeParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float limitationTime => (float)_row["limitationTime"].Value;
		public float observeTime => (float)_row["observeTime"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | limitationTime: {limitationTime} | observeTime: {observeTime}";
	}
}
