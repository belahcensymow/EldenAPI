using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class WorldMapPlaceNameParam
	{
		private readonly PARAM _param;
		public WorldMapPlaceNameParam(PARAM param) => _param = param;
		public IEnumerable<WorldMapPlaceNameParamRow> Entries => _param.Rows.Select(r => new WorldMapPlaceNameParamRow(r));
	}
	public class WorldMapPlaceNameParamRow
	{
		private readonly PARAM.Row _row;
		public WorldMapPlaceNameParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] disableParam_NT => (byte[])_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public int worldMapPieceId => (int)_row["worldMapPieceId"].Value;
		public int textId => (int)_row["textId"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public byte areaNo => (byte)_row["areaNo"].Value;
		public byte gridXNo => (byte)_row["gridXNo"].Value;
		public byte gridZNo => (byte)_row["gridZNo"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public float posX => (float)_row["posX"].Value;
		public float posY => (float)_row["posY"].Value;
		public float posZ => (float)_row["posZ"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | worldMapPieceId: {worldMapPieceId} | textId: {textId} | areaNo: {areaNo} | gridXNo: {gridXNo} | gridZNo: {gridZNo} | posX: {posX} | posY: {posY} | posZ: {posZ}";
	}
}
