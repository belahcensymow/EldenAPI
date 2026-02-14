using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class SignPuddleSubCategoryParam
	{
		private readonly PARAM _param;
		public SignPuddleSubCategoryParam(PARAM param) => _param = param;
		public IEnumerable<SignPuddleSubCategoryParamRow> Entries => _param.Rows.Select(r => new SignPuddleSubCategoryParamRow(r));
	}
	public class SignPuddleSubCategoryParamRow
	{
		private readonly PARAM.Row _row;
		public SignPuddleSubCategoryParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] startPad => (byte[])_row["startPad"].Value;
		public int signPuddleCategoryText => (int)_row["signPuddleCategoryText"].Value;
		public ushort signPuddleTabId => (ushort)_row["signPuddleTabId"].Value;
		public ushort unknown_0xa => (ushort)_row["unknown_0xa"].Value;
		public byte[] endPad => (byte[])_row["endPad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | signPuddleCategoryText: {signPuddleCategoryText} | signPuddleTabId: {signPuddleTabId} | unknown_0xa: {unknown_0xa}";
	}
}
