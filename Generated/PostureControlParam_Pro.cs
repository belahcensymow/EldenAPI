using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class PostureControlParam_Pro
	{
		private readonly PARAM _param;
		public PostureControlParam_Pro(PARAM param) => _param = param;
		public IEnumerable<PostureControlParam_ProRow> Entries => _param.Rows.Select(r => new PostureControlParam_ProRow(r));
	}
	public class PostureControlParam_ProRow
	{
		private readonly PARAM.Row _row;
		public PostureControlParam_ProRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public short a000_rightArmIO => (short)_row["a000_rightArmIO"].Value;
		public short a000_rightArmFB => (short)_row["a000_rightArmFB"].Value;
		public short a000_leftArmIO => (short)_row["a000_leftArmIO"].Value;
		public short a000_leftArmFB => (short)_row["a000_leftArmFB"].Value;
		public short a002_rightArmIO => (short)_row["a002_rightArmIO"].Value;
		public short a002_rightArmFB => (short)_row["a002_rightArmFB"].Value;
		public short a002_leftArmIO => (short)_row["a002_leftArmIO"].Value;
		public short a002_leftArmFB => (short)_row["a002_leftArmFB"].Value;
		public short a003_rightArmIO => (short)_row["a003_rightArmIO"].Value;
		public short a003_rightArmFB => (short)_row["a003_rightArmFB"].Value;
		public short a003_leftArmIO => (short)_row["a003_leftArmIO"].Value;
		public short a003_leftArmFB => (short)_row["a003_leftArmFB"].Value;
		public short a010_rightArmIO => (short)_row["a010_rightArmIO"].Value;
		public short a010_rightArmFB => (short)_row["a010_rightArmFB"].Value;
		public short a010_leftArmIO => (short)_row["a010_leftArmIO"].Value;
		public short a010_leftArmFB => (short)_row["a010_leftArmFB"].Value;
		public short a012_rightArmIO => (short)_row["a012_rightArmIO"].Value;
		public short a012_rightArmFB => (short)_row["a012_rightArmFB"].Value;
		public short a012_leftArmIO => (short)_row["a012_leftArmIO"].Value;
		public short a012_leftArmFB => (short)_row["a012_leftArmFB"].Value;
		public short a013_rightArmIO => (short)_row["a013_rightArmIO"].Value;
		public short a013_rightArmFB => (short)_row["a013_rightArmFB"].Value;
		public short a013_leftArmIO => (short)_row["a013_leftArmIO"].Value;
		public short a013_leftArmFB => (short)_row["a013_leftArmFB"].Value;
		public short a014_rightArmIO => (short)_row["a014_rightArmIO"].Value;
		public short a014_rightArmFB => (short)_row["a014_rightArmFB"].Value;
		public short a014_leftArmIO => (short)_row["a014_leftArmIO"].Value;
		public short a014_leftArmFB => (short)_row["a014_leftArmFB"].Value;
		public short a015_rightArmIO => (short)_row["a015_rightArmIO"].Value;
		public short a015_rightArmFB => (short)_row["a015_rightArmFB"].Value;
		public short a015_leftArmIO => (short)_row["a015_leftArmIO"].Value;
		public short a015_leftArmFB => (short)_row["a015_leftArmFB"].Value;
		public short a016_rightArmIO => (short)_row["a016_rightArmIO"].Value;
		public short a016_rightArmFB => (short)_row["a016_rightArmFB"].Value;
		public short a016_leftArmIO => (short)_row["a016_leftArmIO"].Value;
		public short a016_leftArmFB => (short)_row["a016_leftArmFB"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | a000_rightArmIO: {a000_rightArmIO} | a000_rightArmFB: {a000_rightArmFB} | a000_leftArmIO: {a000_leftArmIO} | a000_leftArmFB: {a000_leftArmFB} | a002_rightArmIO: {a002_rightArmIO} | a002_rightArmFB: {a002_rightArmFB} | a002_leftArmIO: {a002_leftArmIO} | a002_leftArmFB: {a002_leftArmFB} | a003_rightArmIO: {a003_rightArmIO} | a003_rightArmFB: {a003_rightArmFB} | a003_leftArmIO: {a003_leftArmIO} | a003_leftArmFB: {a003_leftArmFB} | a010_rightArmIO: {a010_rightArmIO} | a010_rightArmFB: {a010_rightArmFB} | a010_leftArmIO: {a010_leftArmIO} | a010_leftArmFB: {a010_leftArmFB} | a012_rightArmIO: {a012_rightArmIO} | a012_rightArmFB: {a012_rightArmFB} | a012_leftArmIO: {a012_leftArmIO} | a012_leftArmFB: {a012_leftArmFB} | a013_rightArmIO: {a013_rightArmIO} | a013_rightArmFB: {a013_rightArmFB} | a013_leftArmIO: {a013_leftArmIO} | a013_leftArmFB: {a013_leftArmFB} | a014_rightArmIO: {a014_rightArmIO} | a014_rightArmFB: {a014_rightArmFB} | a014_leftArmIO: {a014_leftArmIO} | a014_leftArmFB: {a014_leftArmFB} | a015_rightArmIO: {a015_rightArmIO} | a015_rightArmFB: {a015_rightArmFB} | a015_leftArmIO: {a015_leftArmIO} | a015_leftArmFB: {a015_leftArmFB} | a016_rightArmIO: {a016_rightArmIO} | a016_rightArmFB: {a016_rightArmFB} | a016_leftArmIO: {a016_leftArmIO} | a016_leftArmFB: {a016_leftArmFB}";
	}
}
