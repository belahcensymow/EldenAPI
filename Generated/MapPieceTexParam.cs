using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class MapPieceTexParam
	{
		private readonly PARAM _param;
		public MapPieceTexParam(PARAM param) => _param = param;
		public IEnumerable<MapPieceTexParamRow> Entries => _param.Rows.Select(r => new MapPieceTexParamRow(r));
	}
	public class MapPieceTexParamRow
	{
		private readonly PARAM.Row _row;
		public MapPieceTexParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte disableParam_NT => (byte)_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public byte srcR => (byte)_row["srcR"].Value;
		public byte srcG => (byte)_row["srcG"].Value;
		public byte srcB => (byte)_row["srcB"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public int saveMapNameId => (int)_row["saveMapNameId"].Value;
		public int multiPlayAreaId => (int)_row["multiPlayAreaId"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | disableParam_NT: {disableParam_NT} | srcR: {srcR} | srcG: {srcG} | srcB: {srcB} | saveMapNameId: {saveMapNameId} | multiPlayAreaId: {multiPlayAreaId}";
	}
}
