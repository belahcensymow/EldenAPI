using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class ChrModelParam
	{
		private readonly PARAM _param;
		public ChrModelParam(PARAM param) => _param = param;
		public IEnumerable<ChrModelParamRow> Entries => _param.Rows.Select(r => new ChrModelParamRow(r));
	}
	public class ChrModelParamRow
	{
		private readonly PARAM.Row _row;
		public ChrModelParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte disableParam_NT => (byte)_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public byte modelMemoryType => (byte)_row["modelMemoryType"].Value;
		public byte texMemoryType => (byte)_row["texMemoryType"].Value;
		public short cameraDitherFadeId => (short)_row["cameraDitherFadeId"].Value;
		public float reportAnimMemSizeMb => (float)_row["reportAnimMemSizeMb"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | disableParam_NT: {disableParam_NT} | modelMemoryType: {modelMemoryType} | texMemoryType: {texMemoryType} | cameraDitherFadeId: {cameraDitherFadeId} | reportAnimMemSizeMb: {reportAnimMemSizeMb}";
	}
}
