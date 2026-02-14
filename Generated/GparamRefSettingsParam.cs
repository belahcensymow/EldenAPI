using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class GparamRefSettingsParam
	{
		private readonly PARAM _param;
		public GparamRefSettingsParam(PARAM param) => _param = param;
		public IEnumerable<GparamRefSettingsParamRow> Entries => _param.Rows.Select(r => new GparamRefSettingsParamRow(r));
	}
	public class GparamRefSettingsParamRow
	{
		private readonly PARAM.Row _row;
		public GparamRefSettingsParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] disableParam_NT => (byte[])_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public int RefTargetMapId => (int)_row["RefTargetMapId"].Value;
		public byte[] Reserve => (byte[])_row["Reserve"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | RefTargetMapId: {RefTargetMapId}";
	}
}
