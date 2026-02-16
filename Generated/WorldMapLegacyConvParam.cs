using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class WorldMapLegacyConvParam
	{
		private readonly PARAM _param;
		public WorldMapLegacyConvParam(PARAM param) => _param = param;
		public IEnumerable<WorldMapLegacyConvParamRow> Entries => _param.Rows.Select(r => new WorldMapLegacyConvParamRow(r));
	}
	public class WorldMapLegacyConvParamRow
	{
		private readonly PARAM.Row _row;
		public WorldMapLegacyConvParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte disableParam_NT => (byte)_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public byte srcAreaNo => (byte)_row["srcAreaNo"].Value;
		public byte srcGridXNo => (byte)_row["srcGridXNo"].Value;
		public byte srcGridZNo => (byte)_row["srcGridZNo"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public float srcPosX => (float)_row["srcPosX"].Value;
		public float srcPosY => (float)_row["srcPosY"].Value;
		public float srcPosZ => (float)_row["srcPosZ"].Value;
		public byte dstAreaNo => (byte)_row["dstAreaNo"].Value;
		public byte dstGridXNo => (byte)_row["dstGridXNo"].Value;
		public byte dstGridZNo => (byte)_row["dstGridZNo"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public float dstPosX => (float)_row["dstPosX"].Value;
		public float dstPosY => (float)_row["dstPosY"].Value;
		public float dstPosZ => (float)_row["dstPosZ"].Value;
		public byte isBasePoint => (byte)_row["isBasePoint"].Value;
		public byte[] pad3 => (byte[])_row["pad3"].Value;
		public byte[] pad4 => (byte[])_row["pad4"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | disableParam_NT: {disableParam_NT} | srcAreaNo: {srcAreaNo} | srcGridXNo: {srcGridXNo} | srcGridZNo: {srcGridZNo} | srcPosX: {srcPosX} | srcPosY: {srcPosY} | srcPosZ: {srcPosZ} | dstAreaNo: {dstAreaNo} | dstGridXNo: {dstGridXNo} | dstGridZNo: {dstGridZNo} | dstPosX: {dstPosX} | dstPosY: {dstPosY} | dstPosZ: {dstPosZ} | isBasePoint: {isBasePoint}";
	}
}
