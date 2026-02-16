using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class NpcAiActionParam
	{
		private readonly PARAM _param;
		public NpcAiActionParam(PARAM param) => _param = param;
		public IEnumerable<NpcAiActionParamRow> Entries => _param.Rows.Select(r => new NpcAiActionParamRow(r));
	}
	public class NpcAiActionParamRow
	{
		private readonly PARAM.Row _row;
		public NpcAiActionParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte moveDir => (byte)_row["moveDir"].Value;
		public byte key1 => (byte)_row["key1"].Value;
		public byte key2 => (byte)_row["key2"].Value;
		public byte key3 => (byte)_row["key3"].Value;
		public byte bMoveDirHold => (byte)_row["bMoveDirHold"].Value;
		public byte bKeyHold1 => (byte)_row["bKeyHold1"].Value;
		public byte bKeyHold2 => (byte)_row["bKeyHold2"].Value;
		public byte bKeyHold3 => (byte)_row["bKeyHold3"].Value;
		public int gestureId => (int)_row["gestureId"].Value;
		public byte bLifeEndSuccess => (byte)_row["bLifeEndSuccess"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | moveDir: {moveDir} | key1: {key1} | key2: {key2} | key3: {key3} | bMoveDirHold: {bMoveDirHold} | bKeyHold1: {bKeyHold1} | bKeyHold2: {bKeyHold2} | bKeyHold3: {bKeyHold3} | gestureId: {gestureId} | bLifeEndSuccess: {bLifeEndSuccess}";
	}
}
