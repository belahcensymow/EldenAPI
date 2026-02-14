using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class WeatherAssetReplaceParam
	{
		private readonly PARAM _param;
		public WeatherAssetReplaceParam(PARAM param) => _param = param;
		public IEnumerable<WeatherAssetReplaceParamRow> Entries => _param.Rows.Select(r => new WeatherAssetReplaceParamRow(r));
	}
	public class WeatherAssetReplaceParamRow
	{
		private readonly PARAM.Row _row;
		public WeatherAssetReplaceParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public uint mapId => (uint)_row["mapId"].Value;
		public byte[] TransitionSrcWeather => (byte[])_row["TransitionSrcWeather"].Value;
		public byte[] padding0 => (byte[])_row["padding0"].Value;
		public byte[] isFireAsh => (byte[])_row["isFireAsh"].Value;
		public byte[] padding1 => (byte[])_row["padding1"].Value;
		public uint reserved2 => (uint)_row["reserved2"].Value;
		public int AssetId0 => (int)_row["AssetId0"].Value;
		public int AssetId1 => (int)_row["AssetId1"].Value;
		public int AssetId2 => (int)_row["AssetId2"].Value;
		public int AssetId3 => (int)_row["AssetId3"].Value;
		public int AssetId4 => (int)_row["AssetId4"].Value;
		public int AssetId5 => (int)_row["AssetId5"].Value;
		public int AssetId6 => (int)_row["AssetId6"].Value;
		public int AssetId7 => (int)_row["AssetId7"].Value;
		public byte[] reserved0 => (byte[])_row["reserved0"].Value;
		public sbyte CreateAssetLimitId0 => (sbyte)_row["CreateAssetLimitId0"].Value;
		public sbyte CreateAssetLimitId1 => (sbyte)_row["CreateAssetLimitId1"].Value;
		public sbyte CreateAssetLimitId2 => (sbyte)_row["CreateAssetLimitId2"].Value;
		public sbyte CreateAssetLimitId3 => (sbyte)_row["CreateAssetLimitId3"].Value;
		public byte[] reserved1 => (byte[])_row["reserved1"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | mapId: {mapId} | reserved2: {reserved2} | AssetId0: {AssetId0} | AssetId1: {AssetId1} | AssetId2: {AssetId2} | AssetId3: {AssetId3} | AssetId4: {AssetId4} | AssetId5: {AssetId5} | AssetId6: {AssetId6} | AssetId7: {AssetId7} | CreateAssetLimitId0: {CreateAssetLimitId0} | CreateAssetLimitId1: {CreateAssetLimitId1} | CreateAssetLimitId2: {CreateAssetLimitId2} | CreateAssetLimitId3: {CreateAssetLimitId3}";
	}
}
