using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class CharmakemenutopParam
	{
		private readonly PARAM _param;
		public CharmakemenutopParam(PARAM param) => _param = param;
		public IEnumerable<CharmakemenutopParamRow> Entries => _param.Rows.Select(r => new CharmakemenutopParamRow(r));
	}
	public class CharmakemenutopParamRow
	{
		private readonly PARAM.Row _row;
		public CharmakemenutopParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte commandType => (byte)_row["commandType"].Value;
		public int captionId => (int)_row["captionId"].Value;
		public byte faceParamId => (byte)_row["faceParamId"].Value;
		public int tableId => (int)_row["tableId"].Value;
		public byte viewCondition => (byte)_row["viewCondition"].Value;
		public byte previewMode => (byte)_row["previewMode"].Value;
		public byte[] reserved2 => (byte[])_row["reserved2"].Value;
		public int tableId2 => (int)_row["tableId2"].Value;
		public byte refFaceParamId => (byte)_row["refFaceParamId"].Value;
		public int refTextId => (int)_row["refTextId"].Value;
		public int helpTextId => (int)_row["helpTextId"].Value;
		public uint unlockEventFlagId => (uint)_row["unlockEventFlagId"].Value;
		public byte[] reserved => (byte[])_row["reserved"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | commandType: {commandType} | captionId: {captionId} | faceParamId: {faceParamId} | tableId: {tableId} | viewCondition: {viewCondition} | previewMode: {previewMode} | tableId2: {tableId2} | refFaceParamId: {refFaceParamId} | refTextId: {refTextId} | helpTextId: {helpTextId} | unlockEventFlagId: {unlockEventFlagId}";
	}
}
