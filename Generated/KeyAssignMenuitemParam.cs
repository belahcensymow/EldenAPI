using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class KeyAssignMenuitemParam
	{
		private readonly PARAM _param;
		public KeyAssignMenuitemParam(PARAM param) => _param = param;
		public IEnumerable<KeyAssignMenuitemParamRow> Entries => _param.Rows.Select(r => new KeyAssignMenuitemParamRow(r));
	}
	public class KeyAssignMenuitemParamRow
	{
		private readonly PARAM.Row _row;
		public KeyAssignMenuitemParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int textID => (int)_row["textID"].Value;
		public byte key => (byte)_row["key"].Value;
		public byte enableUnassign => (byte)_row["enableUnassign"].Value;
		public byte enablePadConfig => (byte)_row["enablePadConfig"].Value;
		public byte enableMouseConfig => (byte)_row["enableMouseConfig"].Value;
		public byte group => (byte)_row["group"].Value;
		public int mappingTextID => (int)_row["mappingTextID"].Value;
		public byte viewPad => (byte)_row["viewPad"].Value;
		public byte viewKeyboardMouse => (byte)_row["viewKeyboardMouse"].Value;
		public byte[] padding => (byte[])_row["padding"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | textID: {textID} | key: {key} | enableUnassign: {enableUnassign} | enablePadConfig: {enablePadConfig} | enableMouseConfig: {enableMouseConfig} | group: {group} | mappingTextID: {mappingTextID} | viewPad: {viewPad} | viewKeyboardMouse: {viewKeyboardMouse}";
	}
}
