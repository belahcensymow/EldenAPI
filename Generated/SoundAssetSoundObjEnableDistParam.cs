using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class SoundAssetSoundObjEnableDistParam
	{
		private readonly PARAM _param;
		public SoundAssetSoundObjEnableDistParam(PARAM param) => _param = param;
		public IEnumerable<SoundAssetSoundObjEnableDistParamRow> Entries => _param.Rows.Select(r => new SoundAssetSoundObjEnableDistParamRow(r));
	}
	public class SoundAssetSoundObjEnableDistParamRow
	{
		private readonly PARAM.Row _row;
		public SoundAssetSoundObjEnableDistParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float SoundObjEnableDist => (float)_row["SoundObjEnableDist"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | SoundObjEnableDist: {SoundObjEnableDist}";
	}
}
