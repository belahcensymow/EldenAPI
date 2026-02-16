using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class ObjActParam
	{
		private readonly PARAM _param;
		public ObjActParam(PARAM param) => _param = param;
		public IEnumerable<ObjActParamRow> Entries => _param.Rows.Select(r => new ObjActParamRow(r));
	}
	public class ObjActParamRow
	{
		private readonly PARAM.Row _row;
		public ObjActParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int actionEnableMsgId => (int)_row["actionEnableMsgId"].Value;
		public int actionFailedMsgId => (int)_row["actionFailedMsgId"].Value;
		public uint spQualifiedPassEventFlag => (uint)_row["spQualifiedPassEventFlag"].Value;
		public uint playerAnimId => (uint)_row["playerAnimId"].Value;
		public uint chrAnimId => (uint)_row["chrAnimId"].Value;
		public ushort validDist => (ushort)_row["validDist"].Value;
		public ushort spQualifiedId => (ushort)_row["spQualifiedId"].Value;
		public ushort spQualifiedId2 => (ushort)_row["spQualifiedId2"].Value;
		public byte objDummyId => (byte)_row["objDummyId"].Value;
		public byte isEventKickSync => (byte)_row["isEventKickSync"].Value;
		public uint objAnimId => (uint)_row["objAnimId"].Value;
		public byte validPlayerAngle => (byte)_row["validPlayerAngle"].Value;
		public byte spQualifiedType => (byte)_row["spQualifiedType"].Value;
		public byte spQualifiedType2 => (byte)_row["spQualifiedType2"].Value;
		public byte validObjAngle => (byte)_row["validObjAngle"].Value;
		public byte chrSorbType => (byte)_row["chrSorbType"].Value;
		public byte eventKickTiming => (byte)_row["eventKickTiming"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public int actionButtonParamId => (int)_row["actionButtonParamId"].Value;
		public float enableTreasureDelaySec => (float)_row["enableTreasureDelaySec"].Value;
		public int preActionSfxDmypolyId => (int)_row["preActionSfxDmypolyId"].Value;
		public int preActionSfxId => (int)_row["preActionSfxId"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | actionEnableMsgId: {actionEnableMsgId} | actionFailedMsgId: {actionFailedMsgId} | spQualifiedPassEventFlag: {spQualifiedPassEventFlag} | playerAnimId: {playerAnimId} | chrAnimId: {chrAnimId} | validDist: {validDist} | spQualifiedId: {spQualifiedId} | spQualifiedId2: {spQualifiedId2} | objDummyId: {objDummyId} | isEventKickSync: {isEventKickSync} | objAnimId: {objAnimId} | validPlayerAngle: {validPlayerAngle} | spQualifiedType: {spQualifiedType} | spQualifiedType2: {spQualifiedType2} | validObjAngle: {validObjAngle} | chrSorbType: {chrSorbType} | eventKickTiming: {eventKickTiming} | actionButtonParamId: {actionButtonParamId} | enableTreasureDelaySec: {enableTreasureDelaySec} | preActionSfxDmypolyId: {preActionSfxDmypolyId} | preActionSfxId: {preActionSfxId}";
	}
}
