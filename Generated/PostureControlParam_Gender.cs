using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class PostureControlParam_Gender
	{
		private readonly PARAM _param;
		public PostureControlParam_Gender(PARAM param) => _param = param;
		public IEnumerable<PostureControlParam_GenderRow> Entries => _param.Rows.Select(r => new PostureControlParam_GenderRow(r));
	}
	public class PostureControlParam_GenderRow
	{
		private readonly PARAM.Row _row;
		public PostureControlParam_GenderRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public short a000_rightElbowIO => (short)_row["a000_rightElbowIO"].Value;
		public short a000_leftElbowIO => (short)_row["a000_leftElbowIO"].Value;
		public short a000_bothLegsIO => (short)_row["a000_bothLegsIO"].Value;
		public short a002_rightElbowIO => (short)_row["a002_rightElbowIO"].Value;
		public short a002_leftElbowIO => (short)_row["a002_leftElbowIO"].Value;
		public short a002_bothLegsIO => (short)_row["a002_bothLegsIO"].Value;
		public short a003_rightElbowIO => (short)_row["a003_rightElbowIO"].Value;
		public short a003_leftElbowIO => (short)_row["a003_leftElbowIO"].Value;
		public short a003_bothLegsIO => (short)_row["a003_bothLegsIO"].Value;
		public short a010_rightElbowIO => (short)_row["a010_rightElbowIO"].Value;
		public short a010_leftElbowIO => (short)_row["a010_leftElbowIO"].Value;
		public short a010_bothLegsIO => (short)_row["a010_bothLegsIO"].Value;
		public short a012_rightElbowIO => (short)_row["a012_rightElbowIO"].Value;
		public short a012_leftElbowIO => (short)_row["a012_leftElbowIO"].Value;
		public short a012_bothLegsIO => (short)_row["a012_bothLegsIO"].Value;
		public short a013_rightElbowIO => (short)_row["a013_rightElbowIO"].Value;
		public short a013_leftElbowIO => (short)_row["a013_leftElbowIO"].Value;
		public short a013_bothLegsIO => (short)_row["a013_bothLegsIO"].Value;
		public short a014_rightElbowIO => (short)_row["a014_rightElbowIO"].Value;
		public short a014_leftElbowIO => (short)_row["a014_leftElbowIO"].Value;
		public short a014_bothLegsIO => (short)_row["a014_bothLegsIO"].Value;
		public short a015_rightElbowIO => (short)_row["a015_rightElbowIO"].Value;
		public short a015_leftElbowIO => (short)_row["a015_leftElbowIO"].Value;
		public short a015_bothLegsIO => (short)_row["a015_bothLegsIO"].Value;
		public short a016_rightElbowIO => (short)_row["a016_rightElbowIO"].Value;
		public short a016_leftElbowIO => (short)_row["a016_leftElbowIO"].Value;
		public short a016_bothLegsIO => (short)_row["a016_bothLegsIO"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | a000_rightElbowIO: {a000_rightElbowIO} | a000_leftElbowIO: {a000_leftElbowIO} | a000_bothLegsIO: {a000_bothLegsIO} | a002_rightElbowIO: {a002_rightElbowIO} | a002_leftElbowIO: {a002_leftElbowIO} | a002_bothLegsIO: {a002_bothLegsIO} | a003_rightElbowIO: {a003_rightElbowIO} | a003_leftElbowIO: {a003_leftElbowIO} | a003_bothLegsIO: {a003_bothLegsIO} | a010_rightElbowIO: {a010_rightElbowIO} | a010_leftElbowIO: {a010_leftElbowIO} | a010_bothLegsIO: {a010_bothLegsIO} | a012_rightElbowIO: {a012_rightElbowIO} | a012_leftElbowIO: {a012_leftElbowIO} | a012_bothLegsIO: {a012_bothLegsIO} | a013_rightElbowIO: {a013_rightElbowIO} | a013_leftElbowIO: {a013_leftElbowIO} | a013_bothLegsIO: {a013_bothLegsIO} | a014_rightElbowIO: {a014_rightElbowIO} | a014_leftElbowIO: {a014_leftElbowIO} | a014_bothLegsIO: {a014_bothLegsIO} | a015_rightElbowIO: {a015_rightElbowIO} | a015_leftElbowIO: {a015_leftElbowIO} | a015_bothLegsIO: {a015_bothLegsIO} | a016_rightElbowIO: {a016_rightElbowIO} | a016_leftElbowIO: {a016_leftElbowIO} | a016_bothLegsIO: {a016_bothLegsIO}";
	}
}
