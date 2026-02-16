using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class SeMaterialConvertParam
	{
		private readonly PARAM _param;
		public SeMaterialConvertParam(PARAM param) => _param = param;
		public IEnumerable<SeMaterialConvertParamRow> Entries => _param.Rows.Select(r => new SeMaterialConvertParamRow(r));
	}
	public class SeMaterialConvertParamRow
	{
		private readonly PARAM.Row _row;
		public SeMaterialConvertParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte seMaterialId => (byte)_row["seMaterialId"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | seMaterialId: {seMaterialId}";
	}
}
