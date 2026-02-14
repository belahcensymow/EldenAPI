using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class DirectionCameraParam
	{
		private readonly PARAM _param;
		public DirectionCameraParam(PARAM param) => _param = param;
		public IEnumerable<DirectionCameraParamRow> Entries => _param.Rows.Select(r => new DirectionCameraParamRow(r));
	}
	public class DirectionCameraParamRow
	{
		private readonly PARAM.Row _row;
		public DirectionCameraParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] isUseOption => (byte[])_row["isUseOption"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name}";
	}
}
