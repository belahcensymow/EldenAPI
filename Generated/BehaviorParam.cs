using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class BehaviorParam
	{
		private readonly PARAM _param;
		public BehaviorParam(PARAM param) => _param = param;
		public IEnumerable<BehaviorParamRow> Entries => _param.Rows.Select(r => new BehaviorParamRow(r));
	}
	public class BehaviorParamRow
	{
		private readonly PARAM.Row _row;
		public BehaviorParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int variationId => (int)_row["variationId"].Value;
		public int behaviorJudgeId => (int)_row["behaviorJudgeId"].Value;
		public byte ezStateBehaviorType_old => (byte)_row["ezStateBehaviorType_old"].Value;
		public byte refType => (byte)_row["refType"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public int refId => (int)_row["refId"].Value;
		public float consumeSA => (float)_row["consumeSA"].Value;
		public int stamina => (int)_row["stamina"].Value;
		public int consumeDurability => (int)_row["consumeDurability"].Value;
		public byte category => (byte)_row["category"].Value;
		public byte heroPoint => (byte)_row["heroPoint"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | variationId: {variationId} | behaviorJudgeId: {behaviorJudgeId} | ezStateBehaviorType_old: {ezStateBehaviorType_old} | refType: {refType} | refId: {refId} | consumeSA: {consumeSA} | stamina: {stamina} | consumeDurability: {consumeDurability} | category: {category} | heroPoint: {heroPoint}";
	}
}
