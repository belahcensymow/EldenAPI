using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class TalkParam
	{
		private readonly PARAM _param;
		public TalkParam(PARAM param) => _param = param;
		public IEnumerable<TalkParamRow> Entries => _param.Rows.Select(r => new TalkParamRow(r));
	}
	public class TalkParamRow
	{
		private readonly PARAM.Row _row;
		public TalkParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte disableParam_NT => (byte)_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public int msgId => (int)_row["msgId"].Value;
		public int voiceId => (int)_row["voiceId"].Value;
		public int spEffectId0 => (int)_row["spEffectId0"].Value;
		public int motionId0 => (int)_row["motionId0"].Value;
		public int spEffectId1 => (int)_row["spEffectId1"].Value;
		public int motionId1 => (int)_row["motionId1"].Value;
		public int returnPos => (int)_row["returnPos"].Value;
		public int reactionId => (int)_row["reactionId"].Value;
		public int eventId => (int)_row["eventId"].Value;
		public int msgId_female => (int)_row["msgId_female"].Value;
		public int voiceId_female => (int)_row["voiceId_female"].Value;
		public short lipSyncStart => (short)_row["lipSyncStart"].Value;
		public short lipSyncTime => (short)_row["lipSyncTime"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public float timeout => (float)_row["timeout"].Value;
		public int talkAnimationId => (int)_row["talkAnimationId"].Value;
		public byte isForceDisp => (byte)_row["isForceDisp"].Value;
		public byte[] pad3 => (byte[])_row["pad3"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | disableParam_NT: {disableParam_NT} | msgId: {msgId} | voiceId: {voiceId} | spEffectId0: {spEffectId0} | motionId0: {motionId0} | spEffectId1: {spEffectId1} | motionId1: {motionId1} | returnPos: {returnPos} | reactionId: {reactionId} | eventId: {eventId} | msgId_female: {msgId_female} | voiceId_female: {voiceId_female} | lipSyncStart: {lipSyncStart} | lipSyncTime: {lipSyncTime} | timeout: {timeout} | talkAnimationId: {talkAnimationId} | isForceDisp: {isForceDisp}";
	}
}
