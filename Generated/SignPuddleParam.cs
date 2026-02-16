using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class SignPuddleParam
	{
		private readonly PARAM _param;
		public SignPuddleParam(PARAM param) => _param = param;
		public IEnumerable<SignPuddleParamRow> Entries => _param.Rows.Select(r => new SignPuddleParamRow(r));
	}
	public class SignPuddleParamRow
	{
		private readonly PARAM.Row _row;
		public SignPuddleParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte disableParam_NT => (byte)_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public int matchAreaId => (int)_row["matchAreaId"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | disableParam_NT: {disableParam_NT} | matchAreaId: {matchAreaId}";
	}
}
