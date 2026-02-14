using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class GraphicsCommonParam
	{
		private readonly PARAM _param;
		public GraphicsCommonParam(PARAM param) => _param = param;
		public IEnumerable<GraphicsCommonParamRow> Entries => _param.Rows.Select(r => new GraphicsCommonParamRow(r));
	}
	public class GraphicsCommonParamRow
	{
		private readonly PARAM.Row _row;
		public GraphicsCommonParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float hitBulletDecalOffset_HitIns => (float)_row["hitBulletDecalOffset_HitIns"].Value;
		public byte[] reserved02 => (byte[])_row["reserved02"].Value;
		public float charaWetDecalFadeRange => (float)_row["charaWetDecalFadeRange"].Value;
		public byte[] reserved04 => (byte[])_row["reserved04"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | hitBulletDecalOffset_HitIns: {hitBulletDecalOffset_HitIns} | charaWetDecalFadeRange: {charaWetDecalFadeRange}";
	}
}
