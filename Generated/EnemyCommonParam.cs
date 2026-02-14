using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class EnemyCommonParam
	{
		private readonly PARAM _param;
		public EnemyCommonParam(PARAM param) => _param = param;
		public IEnumerable<EnemyCommonParamRow> Entries => _param.Rows.Select(r => new EnemyCommonParamRow(r));
	}
	public class EnemyCommonParamRow
	{
		private readonly PARAM.Row _row;
		public EnemyCommonParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] reserved0 => (byte[])_row["reserved0"].Value;
		public int soundTargetTryApproachTime => (int)_row["soundTargetTryApproachTime"].Value;
		public int searchTargetTryApproachTime => (int)_row["searchTargetTryApproachTime"].Value;
		public int memoryTargetTryApproachTime => (int)_row["memoryTargetTryApproachTime"].Value;
		public byte[] reserved5 => (byte[])_row["reserved5"].Value;
		public int activateChrByTime_PhantomId => (int)_row["activateChrByTime_PhantomId"].Value;
		public float findUnfavorableFailedPointDist => (float)_row["findUnfavorableFailedPointDist"].Value;
		public float findUnfavorableFailedPointHeight => (float)_row["findUnfavorableFailedPointHeight"].Value;
		public byte[] reserved18 => (byte[])_row["reserved18"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | soundTargetTryApproachTime: {soundTargetTryApproachTime} | searchTargetTryApproachTime: {searchTargetTryApproachTime} | memoryTargetTryApproachTime: {memoryTargetTryApproachTime} | activateChrByTime_PhantomId: {activateChrByTime_PhantomId} | findUnfavorableFailedPointDist: {findUnfavorableFailedPointDist} | findUnfavorableFailedPointHeight: {findUnfavorableFailedPointHeight}";
	}
}
