using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class WorldMapPieceParam
	{
		private readonly PARAM _param;
		public WorldMapPieceParam(PARAM param) => _param = param;
		public IEnumerable<WorldMapPieceParamRow> Entries => _param.Rows.Select(r => new WorldMapPieceParamRow(r));
	}
	public class WorldMapPieceParamRow
	{
		private readonly PARAM.Row _row;
		public WorldMapPieceParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] disableParam_NT => (byte[])_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public uint openEventFlagId => (uint)_row["openEventFlagId"].Value;
		public float openTravelAreaLeft => (float)_row["openTravelAreaLeft"].Value;
		public float openTravelAreaRight => (float)_row["openTravelAreaRight"].Value;
		public float openTravelAreaTop => (float)_row["openTravelAreaTop"].Value;
		public float openTravelAreaBottom => (float)_row["openTravelAreaBottom"].Value;
		public uint acquisitionEventFlagId => (uint)_row["acquisitionEventFlagId"].Value;
		public float acquisitionEventScale => (float)_row["acquisitionEventScale"].Value;
		public float acquisitionEventCenterX => (float)_row["acquisitionEventCenterX"].Value;
		public float acquisitionEventCenterY => (float)_row["acquisitionEventCenterY"].Value;
		public float acquisitionEventResScale => (float)_row["acquisitionEventResScale"].Value;
		public float acquisitionEventResOffsetX => (float)_row["acquisitionEventResOffsetX"].Value;
		public float acquisitionEventResOffsetY => (float)_row["acquisitionEventResOffsetY"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | openEventFlagId: {openEventFlagId} | openTravelAreaLeft: {openTravelAreaLeft} | openTravelAreaRight: {openTravelAreaRight} | openTravelAreaTop: {openTravelAreaTop} | openTravelAreaBottom: {openTravelAreaBottom} | acquisitionEventFlagId: {acquisitionEventFlagId} | acquisitionEventScale: {acquisitionEventScale} | acquisitionEventCenterX: {acquisitionEventCenterX} | acquisitionEventCenterY: {acquisitionEventCenterY} | acquisitionEventResScale: {acquisitionEventResScale} | acquisitionEventResOffsetX: {acquisitionEventResOffsetX} | acquisitionEventResOffsetY: {acquisitionEventResOffsetY}";
	}
}
