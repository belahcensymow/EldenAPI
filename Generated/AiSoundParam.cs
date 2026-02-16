using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class AiSoundParam
	{
		private readonly PARAM _param;
		public AiSoundParam(PARAM param) => _param = param;
		public IEnumerable<AiSoundParamRow> Entries => _param.Rows.Select(r => new AiSoundParamRow(r));
	}
	public class AiSoundParamRow
	{
		private readonly PARAM.Row _row;
		public AiSoundParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float radius => (float)_row["radius"].Value;
		public float lifeFrame => (float)_row["lifeFrame"].Value;
		public byte bSpEffectEnable => (byte)_row["bSpEffectEnable"].Value;
		public byte type => (byte)_row["type"].Value;
		public byte opposeTarget => (byte)_row["opposeTarget"].Value;
		public byte friendlyTarget => (byte)_row["friendlyTarget"].Value;
		public byte selfTarget => (byte)_row["selfTarget"].Value;
		public byte disableOnTargetPCompany => (byte)_row["disableOnTargetPCompany"].Value;
		public byte rank => (byte)_row["rank"].Value;
		public float forgetTime => (float)_row["forgetTime"].Value;
		public int priority => (int)_row["priority"].Value;
		public int soundBehaviorId => (int)_row["soundBehaviorId"].Value;
		public byte aiSoundLevel => (byte)_row["aiSoundLevel"].Value;
		public byte replaningState => (byte)_row["replaningState"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | radius: {radius} | lifeFrame: {lifeFrame} | bSpEffectEnable: {bSpEffectEnable} | type: {type} | opposeTarget: {opposeTarget} | friendlyTarget: {friendlyTarget} | selfTarget: {selfTarget} | disableOnTargetPCompany: {disableOnTargetPCompany} | rank: {rank} | forgetTime: {forgetTime} | priority: {priority} | soundBehaviorId: {soundBehaviorId} | aiSoundLevel: {aiSoundLevel} | replaningState: {replaningState}";
	}
}
