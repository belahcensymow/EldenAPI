using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class LegacyDistantViewPartsReplaceParam
	{
		private readonly PARAM _param;
		public LegacyDistantViewPartsReplaceParam(PARAM param) => _param = param;
		public IEnumerable<LegacyDistantViewPartsReplaceParamRow> Entries => _param.Rows.Select(r => new LegacyDistantViewPartsReplaceParamRow(r));
	}
	public class LegacyDistantViewPartsReplaceParamRow
	{
		private readonly PARAM.Row _row;
		public LegacyDistantViewPartsReplaceParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int TargetMapId => (int)_row["TargetMapId"].Value;
		public uint TargetEventId => (uint)_row["TargetEventId"].Value;
		public int SrcAssetId => (int)_row["SrcAssetId"].Value;
		public int SrcAssetPartsNo => (int)_row["SrcAssetPartsNo"].Value;
		public int DstAssetId => (int)_row["DstAssetId"].Value;
		public int DstAssetPartsNo => (int)_row["DstAssetPartsNo"].Value;
		public int SrcAssetIdRangeMin => (int)_row["SrcAssetIdRangeMin"].Value;
		public int SrcAssetIdRangeMax => (int)_row["SrcAssetIdRangeMax"].Value;
		public int DstAssetIdRangeMin => (int)_row["DstAssetIdRangeMin"].Value;
		public int DstAssetIdRangeMax => (int)_row["DstAssetIdRangeMax"].Value;
		public sbyte LimitedMapRegionId0 => (sbyte)_row["LimitedMapRegionId0"].Value;
		public sbyte LimitedMapRegionId1 => (sbyte)_row["LimitedMapRegionId1"].Value;
		public sbyte LimitedMapRegionId2 => (sbyte)_row["LimitedMapRegionId2"].Value;
		public sbyte LimitedMapRegionId3 => (sbyte)_row["LimitedMapRegionId3"].Value;
		public byte[] reserve => (byte[])_row["reserve"].Value;
		public int LimitedMapRegionAssetId => (int)_row["LimitedMapRegionAssetId"].Value;
		public int LimitedMapRegioAssetPartsNo => (int)_row["LimitedMapRegioAssetPartsNo"].Value;
		public int LimitedMapRegioAssetIdRangeMin => (int)_row["LimitedMapRegioAssetIdRangeMin"].Value;
		public int LimitedMapRegioAssetIdRangeMax => (int)_row["LimitedMapRegioAssetIdRangeMax"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | TargetMapId: {TargetMapId} | TargetEventId: {TargetEventId} | SrcAssetId: {SrcAssetId} | SrcAssetPartsNo: {SrcAssetPartsNo} | DstAssetId: {DstAssetId} | DstAssetPartsNo: {DstAssetPartsNo} | SrcAssetIdRangeMin: {SrcAssetIdRangeMin} | SrcAssetIdRangeMax: {SrcAssetIdRangeMax} | DstAssetIdRangeMin: {DstAssetIdRangeMin} | DstAssetIdRangeMax: {DstAssetIdRangeMax} | LimitedMapRegionId0: {LimitedMapRegionId0} | LimitedMapRegionId1: {LimitedMapRegionId1} | LimitedMapRegionId2: {LimitedMapRegionId2} | LimitedMapRegionId3: {LimitedMapRegionId3} | LimitedMapRegionAssetId: {LimitedMapRegionAssetId} | LimitedMapRegioAssetPartsNo: {LimitedMapRegioAssetPartsNo} | LimitedMapRegioAssetIdRangeMin: {LimitedMapRegioAssetIdRangeMin} | LimitedMapRegioAssetIdRangeMax: {LimitedMapRegioAssetIdRangeMax}";
	}
}
