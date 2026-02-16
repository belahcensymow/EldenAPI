using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class NetworkAreaParam
	{
		private readonly PARAM _param;
		public NetworkAreaParam(PARAM param) => _param = param;
		public IEnumerable<NetworkAreaParamRow> Entries => _param.Rows.Select(r => new NetworkAreaParamRow(r));
	}
	public class NetworkAreaParamRow
	{
		private readonly PARAM.Row _row;
		public NetworkAreaParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float cellSizeX => (float)_row["cellSizeX"].Value;
		public float cellSizeY => (float)_row["cellSizeY"].Value;
		public float cellSizeZ => (float)_row["cellSizeZ"].Value;
		public float cellOffsetX => (float)_row["cellOffsetX"].Value;
		public float cellOffsetY => (float)_row["cellOffsetY"].Value;
		public float cellOffsetZ => (float)_row["cellOffsetZ"].Value;
		public byte enableBloodstain => (byte)_row["enableBloodstain"].Value;
		public byte enableBloodMessage => (byte)_row["enableBloodMessage"].Value;
		public byte enableGhost => (byte)_row["enableGhost"].Value;
		public byte enableMultiPlay => (byte)_row["enableMultiPlay"].Value;
		public byte enableRingSearch => (byte)_row["enableRingSearch"].Value;
		public byte enableBreakInSearch => (byte)_row["enableBreakInSearch"].Value;
		public byte[] dummy => (byte[])_row["dummy"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | cellSizeX: {cellSizeX} | cellSizeY: {cellSizeY} | cellSizeZ: {cellSizeZ} | cellOffsetX: {cellOffsetX} | cellOffsetY: {cellOffsetY} | cellOffsetZ: {cellOffsetZ} | enableBloodstain: {enableBloodstain} | enableBloodMessage: {enableBloodMessage} | enableGhost: {enableGhost} | enableMultiPlay: {enableMultiPlay} | enableRingSearch: {enableRingSearch} | enableBreakInSearch: {enableBreakInSearch}";
	}
}
