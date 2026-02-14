using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class SoundAutoEnvSoundGroupParam
	{
		private readonly PARAM _param;
		public SoundAutoEnvSoundGroupParam(PARAM param) => _param = param;
		public IEnumerable<SoundAutoEnvSoundGroupParamRow> Entries => _param.Rows.Select(r => new SoundAutoEnvSoundGroupParamRow(r));
	}
	public class SoundAutoEnvSoundGroupParamRow
	{
		private readonly PARAM.Row _row;
		public SoundAutoEnvSoundGroupParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int SoundNo => (int)_row["SoundNo"].Value;
		public float ExpandRange => (float)_row["ExpandRange"].Value;
		public float FollowSpeed => (float)_row["FollowSpeed"].Value;
		public float FollowRate => (float)_row["FollowRate"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | SoundNo: {SoundNo} | ExpandRange: {ExpandRange} | FollowSpeed: {FollowSpeed} | FollowRate: {FollowRate}";
	}
}
