using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class SoundCutsceneParam
	{
		private readonly PARAM _param;
		public SoundCutsceneParam(PARAM param) => _param = param;
		public IEnumerable<SoundCutsceneParamRow> Entries => _param.Rows.Select(r => new SoundCutsceneParamRow(r));
	}
	public class SoundCutsceneParamRow
	{
		private readonly PARAM.Row _row;
		public SoundCutsceneParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] disableParam_NT => (byte[])_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public byte ReverbType => (byte)_row["ReverbType"].Value;
		public byte[] pad0 => (byte[])_row["pad0"].Value;
		public byte[] BgmBehaviorTypeOnStart => (byte[])_row["BgmBehaviorTypeOnStart"].Value;
		public byte[] OneShotBgmBehaviorOnStart => (byte[])_row["OneShotBgmBehaviorOnStart"].Value;
		public int PostPlaySeId => (int)_row["PostPlaySeId"].Value;
		public int PostPlaySeIdForSkip => (int)_row["PostPlaySeIdForSkip"].Value;
		public float EnterMapMuteStopTimeOnDrawCutscene => (float)_row["EnterMapMuteStopTimeOnDrawCutscene"].Value;
		public byte[] reserved => (byte[])_row["reserved"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | ReverbType: {ReverbType} | PostPlaySeId: {PostPlaySeId} | PostPlaySeIdForSkip: {PostPlaySeIdForSkip} | EnterMapMuteStopTimeOnDrawCutscene: {EnterMapMuteStopTimeOnDrawCutscene}";
	}
}
