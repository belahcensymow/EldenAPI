using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class PostureControlParam_WepLeft
	{
		private readonly PARAM _param;
		public PostureControlParam_WepLeft(PARAM param) => _param = param;
		public IEnumerable<PostureControlParam_WepLeftRow> Entries => _param.Rows.Select(r => new PostureControlParam_WepLeftRow(r));
	}
	public class PostureControlParam_WepLeftRow
	{
		private readonly PARAM.Row _row;
		public PostureControlParam_WepLeftRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public short a000_leftArmFB => (short)_row["a000_leftArmFB"].Value;
		public short a000_leftWristFB => (short)_row["a000_leftWristFB"].Value;
		public short a000_leftWristIO => (short)_row["a000_leftWristIO"].Value;
		public short a002_leftArmFB => (short)_row["a002_leftArmFB"].Value;
		public short a002_leftWristFB => (short)_row["a002_leftWristFB"].Value;
		public short a002_leftWristIO => (short)_row["a002_leftWristIO"].Value;
		public short a003_leftArmFB => (short)_row["a003_leftArmFB"].Value;
		public short a003_leftWristFB => (short)_row["a003_leftWristFB"].Value;
		public short a003_leftWristIO => (short)_row["a003_leftWristIO"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | a000_leftArmFB: {a000_leftArmFB} | a000_leftWristFB: {a000_leftWristFB} | a000_leftWristIO: {a000_leftWristIO} | a002_leftArmFB: {a002_leftArmFB} | a002_leftWristFB: {a002_leftWristFB} | a002_leftWristIO: {a002_leftWristIO} | a003_leftArmFB: {a003_leftArmFB} | a003_leftWristFB: {a003_leftWristFB} | a003_leftWristIO: {a003_leftWristIO}";
	}
}
