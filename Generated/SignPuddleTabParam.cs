using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class SignPuddleTabParam
	{
		private readonly PARAM _param;
		public SignPuddleTabParam(PARAM param) => _param = param;
		public IEnumerable<SignPuddleTabParamRow> Entries => _param.Rows.Select(r => new SignPuddleTabParamRow(r));
	}
	public class SignPuddleTabParamRow
	{
		private readonly PARAM.Row _row;
		public SignPuddleTabParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int isDlcTab => (int)_row["isDlcTab"].Value;
		public int tabTextId => (int)_row["tabTextId"].Value;
		public int unknown_0x8 => (int)_row["unknown_0x8"].Value;
		public int unknown_0xc => (int)_row["unknown_0xc"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | isDlcTab: {isDlcTab} | tabTextId: {tabTextId} | unknown_0x8: {unknown_0x8} | unknown_0xc: {unknown_0xc}";
	}
}
