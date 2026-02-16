using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class TutorialParam
	{
		private readonly PARAM _param;
		public TutorialParam(PARAM param) => _param = param;
		public IEnumerable<TutorialParamRow> Entries => _param.Rows.Select(r => new TutorialParamRow(r));
	}
	public class TutorialParamRow
	{
		private readonly PARAM.Row _row;
		public TutorialParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte disableParam_NT => (byte)_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public byte menuType => (byte)_row["menuType"].Value;
		public byte triggerType => (byte)_row["triggerType"].Value;
		public byte repeatType => (byte)_row["repeatType"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public ushort imageId => (ushort)_row["imageId"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public uint unlockEventFlagId => (uint)_row["unlockEventFlagId"].Value;
		public int textId => (int)_row["textId"].Value;
		public float displayMinTime => (float)_row["displayMinTime"].Value;
		public float displayTime => (float)_row["displayTime"].Value;
		public byte[] pad3 => (byte[])_row["pad3"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | disableParam_NT: {disableParam_NT} | menuType: {menuType} | triggerType: {triggerType} | repeatType: {repeatType} | imageId: {imageId} | unlockEventFlagId: {unlockEventFlagId} | textId: {textId} | displayMinTime: {displayMinTime} | displayTime: {displayTime}";
	}
}
