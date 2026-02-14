using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class BulletCreateLimitParam
	{
		private readonly PARAM _param;
		public BulletCreateLimitParam(PARAM param) => _param = param;
		public IEnumerable<BulletCreateLimitParamRow> Entries => _param.Rows.Select(r => new BulletCreateLimitParamRow(r));
	}
	public class BulletCreateLimitParamRow
	{
		private readonly PARAM.Row _row;
		public BulletCreateLimitParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte limitNum_byGroup => (byte)_row["limitNum_byGroup"].Value;
		public byte[] isLimitEachOwner => (byte[])_row["isLimitEachOwner"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | limitNum_byGroup: {limitNum_byGroup}";
	}
}
