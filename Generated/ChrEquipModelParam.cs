using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class ChrEquipModelParam
	{
		private readonly PARAM _param;
		public ChrEquipModelParam(PARAM param) => _param = param;
		public IEnumerable<ChrEquipModelParamRow> Entries => _param.Rows.Select(r => new ChrEquipModelParamRow(r));
	}
	public class ChrEquipModelParamRow
	{
		private readonly PARAM.Row _row;
		public ChrEquipModelParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int unknown_0x0 => (int)_row["unknown_0x0"].Value;
		public int unknown_0x4 => (int)_row["unknown_0x4"].Value;
		public int unknown_0x8 => (int)_row["unknown_0x8"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | unknown_0x0: {unknown_0x0} | unknown_0x4: {unknown_0x4} | unknown_0x8: {unknown_0x8}";
	}
}
