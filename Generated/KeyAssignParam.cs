using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class KeyAssignParam
	{
		private readonly PARAM _param;
		public KeyAssignParam(PARAM param) => _param = param;
		public IEnumerable<KeyAssignParamRow> Entries => _param.Rows.Select(r => new KeyAssignParamRow(r));
	}
	public class KeyAssignParamRow
	{
		private readonly PARAM.Row _row;
		public KeyAssignParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte padKeyId => (byte)_row["padKeyId"].Value;
		public byte keyboardModifyKey => (byte)_row["keyboardModifyKey"].Value;
		public byte keyboardKeyId => (byte)_row["keyboardKeyId"].Value;
		public byte mouseModifyKey => (byte)_row["mouseModifyKey"].Value;
		public byte mouseKeyId => (byte)_row["mouseKeyId"].Value;
		public byte[] reserved => (byte[])_row["reserved"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | padKeyId: {padKeyId} | keyboardModifyKey: {keyboardModifyKey} | keyboardKeyId: {keyboardKeyId} | mouseModifyKey: {mouseModifyKey} | mouseKeyId: {mouseKeyId}";
	}
}
