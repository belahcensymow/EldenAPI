using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class MultiPlayCorrectionParam
	{
		private readonly PARAM _param;
		public MultiPlayCorrectionParam(PARAM param) => _param = param;
		public IEnumerable<MultiPlayCorrectionParamRow> Entries => _param.Rows.Select(r => new MultiPlayCorrectionParamRow(r));
	}
	public class MultiPlayCorrectionParamRow
	{
		private readonly PARAM.Row _row;
		public MultiPlayCorrectionParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte disableParam_NT => (byte)_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public int client1SpEffectId => (int)_row["client1SpEffectId"].Value;
		public int client2SpEffectId => (int)_row["client2SpEffectId"].Value;
		public int client3SpEffectId => (int)_row["client3SpEffectId"].Value;
		public byte bOverrideSpEffect => (byte)_row["bOverrideSpEffect"].Value;
		public byte[] pad3 => (byte[])_row["pad3"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | disableParam_NT: {disableParam_NT} | client1SpEffectId: {client1SpEffectId} | client2SpEffectId: {client2SpEffectId} | client3SpEffectId: {client3SpEffectId} | bOverrideSpEffect: {bOverrideSpEffect}";
	}
}
