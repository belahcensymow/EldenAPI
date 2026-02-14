using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class CharmakemenuListitemParam
	{
		private readonly PARAM _param;
		public CharmakemenuListitemParam(PARAM param) => _param = param;
		public IEnumerable<CharmakemenuListitemParamRow> Entries => _param.Rows.Select(r => new CharmakemenuListitemParamRow(r));
	}
	public class CharmakemenuListitemParamRow
	{
		private readonly PARAM.Row _row;
		public CharmakemenuListitemParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int value => (int)_row["value"].Value;
		public int captionId => (int)_row["captionId"].Value;
		public byte iconId => (byte)_row["iconId"].Value;
		public byte[] reserved => (byte[])_row["reserved"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | value: {value} | captionId: {captionId} | iconId: {iconId}";
	}
}
