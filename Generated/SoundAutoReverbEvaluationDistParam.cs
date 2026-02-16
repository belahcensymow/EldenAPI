using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class SoundAutoReverbEvaluationDistParam
	{
		private readonly PARAM _param;
		public SoundAutoReverbEvaluationDistParam(PARAM param) => _param = param;
		public IEnumerable<SoundAutoReverbEvaluationDistParamRow> Entries => _param.Rows.Select(r => new SoundAutoReverbEvaluationDistParamRow(r));
	}
	public class SoundAutoReverbEvaluationDistParamRow
	{
		private readonly PARAM.Row _row;
		public SoundAutoReverbEvaluationDistParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float NoHitDist => (float)_row["NoHitDist"].Value;
		public byte isCollectNoHitPoint => (byte)_row["isCollectNoHitPoint"].Value;
		public byte isCollectOutdoorPoint => (byte)_row["isCollectOutdoorPoint"].Value;
		public byte isCollectFloorPoint => (byte)_row["isCollectFloorPoint"].Value;
		public byte distValCalcType => (byte)_row["distValCalcType"].Value;
		public float enableLifeTime => (float)_row["enableLifeTime"].Value;
		public uint maxDistRecordNum => (uint)_row["maxDistRecordNum"].Value;
		public uint ignoreDistNumForMax => (uint)_row["ignoreDistNumForMax"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | NoHitDist: {NoHitDist} | isCollectNoHitPoint: {isCollectNoHitPoint} | isCollectOutdoorPoint: {isCollectOutdoorPoint} | isCollectFloorPoint: {isCollectFloorPoint} | distValCalcType: {distValCalcType} | enableLifeTime: {enableLifeTime} | maxDistRecordNum: {maxDistRecordNum} | ignoreDistNumForMax: {ignoreDistNumForMax}";
	}
}
