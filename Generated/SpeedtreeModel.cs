using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class SpeedtreeModel
	{
		private readonly PARAM _param;
		public SpeedtreeModel(PARAM param) => _param = param;
		public IEnumerable<SpeedtreeModelRow> Entries => _param.Rows.Select(r => new SpeedtreeModelRow(r));
	}
	public class SpeedtreeModelRow
	{
		private readonly PARAM.Row _row;
		public SpeedtreeModelRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float MinFadeLeaf => (float)_row["MinFadeLeaf"].Value;
		public float MinFadeFrond => (float)_row["MinFadeFrond"].Value;
		public float MinFadeBranch => (float)_row["MinFadeBranch"].Value;
		public float MinTranslucencyLeaf => (float)_row["MinTranslucencyLeaf"].Value;
		public float MaxTranslucencyLeaf => (float)_row["MaxTranslucencyLeaf"].Value;
		public float MinTranslucencyFrond => (float)_row["MinTranslucencyFrond"].Value;
		public float MaxTranslucencyFrond => (float)_row["MaxTranslucencyFrond"].Value;
		public float MinTranslucencyBranch => (float)_row["MinTranslucencyBranch"].Value;
		public float MaxTranslucencyBranch => (float)_row["MaxTranslucencyBranch"].Value;
		public float BillboardBackSpecularWeakenParam => (float)_row["BillboardBackSpecularWeakenParam"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | MinFadeLeaf: {MinFadeLeaf} | MinFadeFrond: {MinFadeFrond} | MinFadeBranch: {MinFadeBranch} | MinTranslucencyLeaf: {MinTranslucencyLeaf} | MaxTranslucencyLeaf: {MaxTranslucencyLeaf} | MinTranslucencyFrond: {MinTranslucencyFrond} | MaxTranslucencyFrond: {MaxTranslucencyFrond} | MinTranslucencyBranch: {MinTranslucencyBranch} | MaxTranslucencyBranch: {MaxTranslucencyBranch} | BillboardBackSpecularWeakenParam: {BillboardBackSpecularWeakenParam}";
	}
}
