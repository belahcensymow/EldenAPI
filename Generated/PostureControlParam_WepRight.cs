using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class PostureControlParam_WepRight
	{
		private readonly PARAM _param;
		public PostureControlParam_WepRight(PARAM param) => _param = param;
		public IEnumerable<PostureControlParam_WepRightRow> Entries => _param.Rows.Select(r => new PostureControlParam_WepRightRow(r));
	}
	public class PostureControlParam_WepRightRow
	{
		private readonly PARAM.Row _row;
		public PostureControlParam_WepRightRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public short a000_rightArmFB => (short)_row["a000_rightArmFB"].Value;
		public short a000_rightWristFB => (short)_row["a000_rightWristFB"].Value;
		public short a000_rightWristIO => (short)_row["a000_rightWristIO"].Value;
		public short a000_leftArmFB => (short)_row["a000_leftArmFB"].Value;
		public short a000_leftWristFB => (short)_row["a000_leftWristFB"].Value;
		public short a000_leftWristIO => (short)_row["a000_leftWristIO"].Value;
		public short a002_rightArmFB => (short)_row["a002_rightArmFB"].Value;
		public short a002_rightWristFB => (short)_row["a002_rightWristFB"].Value;
		public short a002_rightWristIO => (short)_row["a002_rightWristIO"].Value;
		public short a002_leftArmFB => (short)_row["a002_leftArmFB"].Value;
		public short a002_leftWristFB => (short)_row["a002_leftWristFB"].Value;
		public short a002_leftWristIO => (short)_row["a002_leftWristIO"].Value;
		public short a003_rightArmFB => (short)_row["a003_rightArmFB"].Value;
		public short a003_rightWristFB => (short)_row["a003_rightWristFB"].Value;
		public short a003_rightWristIO => (short)_row["a003_rightWristIO"].Value;
		public short a003_leftArmFB => (short)_row["a003_leftArmFB"].Value;
		public short a003_leftWristFB => (short)_row["a003_leftWristFB"].Value;
		public short a003_leftWristIO => (short)_row["a003_leftWristIO"].Value;
		public short a010_rightArmFB => (short)_row["a010_rightArmFB"].Value;
		public short a010_rightWristFB => (short)_row["a010_rightWristFB"].Value;
		public short a010_rightWristIO => (short)_row["a010_rightWristIO"].Value;
		public short a010_leftArmFB => (short)_row["a010_leftArmFB"].Value;
		public short a010_leftWristFB => (short)_row["a010_leftWristFB"].Value;
		public short a010_leftWristIO => (short)_row["a010_leftWristIO"].Value;
		public short a012_rightArmFB => (short)_row["a012_rightArmFB"].Value;
		public short a012_rightWristFB => (short)_row["a012_rightWristFB"].Value;
		public short a012_rightWristIO => (short)_row["a012_rightWristIO"].Value;
		public short a012_leftArmFB => (short)_row["a012_leftArmFB"].Value;
		public short a012_leftWristFB => (short)_row["a012_leftWristFB"].Value;
		public short a012_leftWristIO => (short)_row["a012_leftWristIO"].Value;
		public short a013_rightArmFB => (short)_row["a013_rightArmFB"].Value;
		public short a013_rightWristFB => (short)_row["a013_rightWristFB"].Value;
		public short a013_rightWristIO => (short)_row["a013_rightWristIO"].Value;
		public short a013_leftArmFB => (short)_row["a013_leftArmFB"].Value;
		public short a013_leftWristFB => (short)_row["a013_leftWristFB"].Value;
		public short a013_leftWristIO => (short)_row["a013_leftWristIO"].Value;
		public short a014_rightArmFB => (short)_row["a014_rightArmFB"].Value;
		public short a014_rightWristFB => (short)_row["a014_rightWristFB"].Value;
		public short a014_rightWristIO => (short)_row["a014_rightWristIO"].Value;
		public short a014_leftArmFB => (short)_row["a014_leftArmFB"].Value;
		public short a014_leftWristFB => (short)_row["a014_leftWristFB"].Value;
		public short a014_leftWristIO => (short)_row["a014_leftWristIO"].Value;
		public short a015_rightArmFB => (short)_row["a015_rightArmFB"].Value;
		public short a015_rightWristFB => (short)_row["a015_rightWristFB"].Value;
		public short a015_rightWristIO => (short)_row["a015_rightWristIO"].Value;
		public short a015_leftArmFB => (short)_row["a015_leftArmFB"].Value;
		public short a015_leftWristFB => (short)_row["a015_leftWristFB"].Value;
		public short a015_leftWristIO => (short)_row["a015_leftWristIO"].Value;
		public short a016_rightArmFB => (short)_row["a016_rightArmFB"].Value;
		public short a016_rightWristFB => (short)_row["a016_rightWristFB"].Value;
		public short a016_rightWristIO => (short)_row["a016_rightWristIO"].Value;
		public short a016_leftArmFB => (short)_row["a016_leftArmFB"].Value;
		public short a016_leftWristFB => (short)_row["a016_leftWristFB"].Value;
		public short a016_leftWristIO => (short)_row["a016_leftWristIO"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | a000_rightArmFB: {a000_rightArmFB} | a000_rightWristFB: {a000_rightWristFB} | a000_rightWristIO: {a000_rightWristIO} | a000_leftArmFB: {a000_leftArmFB} | a000_leftWristFB: {a000_leftWristFB} | a000_leftWristIO: {a000_leftWristIO} | a002_rightArmFB: {a002_rightArmFB} | a002_rightWristFB: {a002_rightWristFB} | a002_rightWristIO: {a002_rightWristIO} | a002_leftArmFB: {a002_leftArmFB} | a002_leftWristFB: {a002_leftWristFB} | a002_leftWristIO: {a002_leftWristIO} | a003_rightArmFB: {a003_rightArmFB} | a003_rightWristFB: {a003_rightWristFB} | a003_rightWristIO: {a003_rightWristIO} | a003_leftArmFB: {a003_leftArmFB} | a003_leftWristFB: {a003_leftWristFB} | a003_leftWristIO: {a003_leftWristIO} | a010_rightArmFB: {a010_rightArmFB} | a010_rightWristFB: {a010_rightWristFB} | a010_rightWristIO: {a010_rightWristIO} | a010_leftArmFB: {a010_leftArmFB} | a010_leftWristFB: {a010_leftWristFB} | a010_leftWristIO: {a010_leftWristIO} | a012_rightArmFB: {a012_rightArmFB} | a012_rightWristFB: {a012_rightWristFB} | a012_rightWristIO: {a012_rightWristIO} | a012_leftArmFB: {a012_leftArmFB} | a012_leftWristFB: {a012_leftWristFB} | a012_leftWristIO: {a012_leftWristIO} | a013_rightArmFB: {a013_rightArmFB} | a013_rightWristFB: {a013_rightWristFB} | a013_rightWristIO: {a013_rightWristIO} | a013_leftArmFB: {a013_leftArmFB} | a013_leftWristFB: {a013_leftWristFB} | a013_leftWristIO: {a013_leftWristIO} | a014_rightArmFB: {a014_rightArmFB} | a014_rightWristFB: {a014_rightWristFB} | a014_rightWristIO: {a014_rightWristIO} | a014_leftArmFB: {a014_leftArmFB} | a014_leftWristFB: {a014_leftWristFB} | a014_leftWristIO: {a014_leftWristIO} | a015_rightArmFB: {a015_rightArmFB} | a015_rightWristFB: {a015_rightWristFB} | a015_rightWristIO: {a015_rightWristIO} | a015_leftArmFB: {a015_leftArmFB} | a015_leftWristFB: {a015_leftWristFB} | a015_leftWristIO: {a015_leftWristIO} | a016_rightArmFB: {a016_rightArmFB} | a016_rightWristFB: {a016_rightWristFB} | a016_rightWristIO: {a016_rightWristIO} | a016_leftArmFB: {a016_leftArmFB} | a016_leftWristFB: {a016_leftWristFB} | a016_leftWristIO: {a016_leftWristIO}";
	}
}
