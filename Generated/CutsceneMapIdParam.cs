using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class CutsceneMapIdParam
	{
		private readonly PARAM _param;
		public CutsceneMapIdParam(PARAM param) => _param = param;
		public IEnumerable<CutsceneMapIdParamRow> Entries => _param.Rows.Select(r => new CutsceneMapIdParamRow(r));
	}
	public class CutsceneMapIdParamRow
	{
		private readonly PARAM.Row _row;
		public CutsceneMapIdParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] disableParam_NT => (byte[])_row["disableParam_NT"].Value;
		public byte[] disableParam_Debug => (byte[])_row["disableParam_Debug"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public uint PlayMapId => (uint)_row["PlayMapId"].Value;
		public uint RequireMapId0 => (uint)_row["RequireMapId0"].Value;
		public uint RequireMapId1 => (uint)_row["RequireMapId1"].Value;
		public uint RequireMapId2 => (uint)_row["RequireMapId2"].Value;
		public int RefCamPosHitPartsID => (int)_row["RefCamPosHitPartsID"].Value;
		public byte[] reserved_2 => (byte[])_row["reserved_2"].Value;
		public ushort ClientDisableViewTimeForProgress => (ushort)_row["ClientDisableViewTimeForProgress"].Value;
		public byte[] reserved => (byte[])_row["reserved"].Value;
		public int HitParts_0 => (int)_row["HitParts_0"].Value;
		public int HitParts_1 => (int)_row["HitParts_1"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | PlayMapId: {PlayMapId} | RequireMapId0: {RequireMapId0} | RequireMapId1: {RequireMapId1} | RequireMapId2: {RequireMapId2} | RefCamPosHitPartsID: {RefCamPosHitPartsID} | ClientDisableViewTimeForProgress: {ClientDisableViewTimeForProgress} | HitParts_0: {HitParts_0} | HitParts_1: {HitParts_1}";
	}
}
