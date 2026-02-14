using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class BasechrSelectMenuParam
	{
		private readonly PARAM _param;
		public BasechrSelectMenuParam(PARAM param) => _param = param;
		public IEnumerable<BasechrSelectMenuParamRow> Entries => _param.Rows.Select(r => new BasechrSelectMenuParamRow(r));
	}
	public class BasechrSelectMenuParamRow
	{
		private readonly PARAM.Row _row;
		public BasechrSelectMenuParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] disableParam_NT => (byte[])_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public uint chrInitParam => (uint)_row["chrInitParam"].Value;
		public uint originChrInitParam => (uint)_row["originChrInitParam"].Value;
		public int imageId => (int)_row["imageId"].Value;
		public int textId => (int)_row["textId"].Value;
		public byte[] reserve => (byte[])_row["reserve"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | chrInitParam: {chrInitParam} | originChrInitParam: {originChrInitParam} | imageId: {imageId} | textId: {textId}";
	}
}
