using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class MenuCommonParam
	{
		private readonly PARAM _param;
		public MenuCommonParam(PARAM param) => _param = param;
		public IEnumerable<MenuCommonParamRow> Entries => _param.Rows.Select(r => new MenuCommonParamRow(r));
	}
	public class MenuCommonParamRow
	{
		private readonly PARAM.Row _row;
		public MenuCommonParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float soloPlayDeath_ToFadeOutTime => (float)_row["soloPlayDeath_ToFadeOutTime"].Value;
		public float partyGhostDeath_ToFadeOutTime => (float)_row["partyGhostDeath_ToFadeOutTime"].Value;
		public int playerMaxHpLimit => (int)_row["playerMaxHpLimit"].Value;
		public int playerMaxMpLimit => (int)_row["playerMaxMpLimit"].Value;
		public int playerMaxSpLimit => (int)_row["playerMaxSpLimit"].Value;
		public float actionPanelChangeThreshold_Vel => (float)_row["actionPanelChangeThreshold_Vel"].Value;
		public float actionPanelChangeThreshold_PassTime => (float)_row["actionPanelChangeThreshold_PassTime"].Value;
		public int kgIconVspace => (int)_row["kgIconVspace"].Value;
		public float worldMapCursorSelectRadius => (float)_row["worldMapCursorSelectRadius"].Value;
		public byte[] reserved8 => (byte[])_row["reserved8"].Value;
		public int decalPosOffsetX => (int)_row["decalPosOffsetX"].Value;
		public int decalPosOffsetY => (int)_row["decalPosOffsetY"].Value;
		public float targetStateSearchDurationTime => (float)_row["targetStateSearchDurationTime"].Value;
		public float targetStateBattleDurationTime => (float)_row["targetStateBattleDurationTime"].Value;
		public float worldMapCursorSpeed => (float)_row["worldMapCursorSpeed"].Value;
		public float worldMapCursorFirstDistance => (float)_row["worldMapCursorFirstDistance"].Value;
		public float worldMapCursorFirstDelay => (float)_row["worldMapCursorFirstDelay"].Value;
		public float worldMapCursorWaitTime => (float)_row["worldMapCursorWaitTime"].Value;
		public float worldMapCursorSnapRadius => (float)_row["worldMapCursorSnapRadius"].Value;
		public float worldMapCursorSnapTime => (float)_row["worldMapCursorSnapTime"].Value;
		public float itemGetLogAliveTime => (float)_row["itemGetLogAliveTime"].Value;
		public int playerMaxSaLimit => (int)_row["playerMaxSaLimit"].Value;
		public uint worldMap_IsChangeableLayerEventFlagId => (uint)_row["worldMap_IsChangeableLayerEventFlagId"].Value;
		public float worldMap_TravelMargin => (float)_row["worldMap_TravelMargin"].Value;
		public float systemAnnounceScrollBufferTime => (float)_row["systemAnnounceScrollBufferTime"].Value;
		public int systemAnnounceScrollSpeed => (int)_row["systemAnnounceScrollSpeed"].Value;
		public float systemAnnounceNoScrollWaitTime => (float)_row["systemAnnounceNoScrollWaitTime"].Value;
		public byte systemAnnounceScrollCount => (byte)_row["systemAnnounceScrollCount"].Value;
		public byte[] reserved17 => (byte[])_row["reserved17"].Value;
		public float compassMemoDispDistance => (float)_row["compassMemoDispDistance"].Value;
		public float compassBonfireDispDistance => (float)_row["compassBonfireDispDistance"].Value;
		public float markerGoalThreshold => (float)_row["markerGoalThreshold"].Value;
		public float svSliderStep => (float)_row["svSliderStep"].Value;
		public float preOpeningMovie_WaitSec => (float)_row["preOpeningMovie_WaitSec"].Value;
		public float kgIconScale => (float)_row["kgIconScale"].Value;
		public float kgIconScale_forTable => (float)_row["kgIconScale_forTable"].Value;
		public int kgIconVspace_forTable => (int)_row["kgIconVspace_forTable"].Value;
		public float kgIconScale_forConfig => (float)_row["kgIconScale_forConfig"].Value;
		public int kgIconVspace_forConfig => (int)_row["kgIconVspace_forConfig"].Value;
		public float worldMap_SearchRadius => (float)_row["worldMap_SearchRadius"].Value;
		public float tutorialDisplayTime => (float)_row["tutorialDisplayTime"].Value;
		public float compassFriendHostInnerDistance => (float)_row["compassFriendHostInnerDistance"].Value;
		public float compassEnemyHostInnerDistance => (float)_row["compassEnemyHostInnerDistance"].Value;
		public float compassFriendGuestInnerDistance => (float)_row["compassFriendGuestInnerDistance"].Value;
		public float cutsceneKeyGuideAliveTime => (float)_row["cutsceneKeyGuideAliveTime"].Value;
		public float autoHideHpThresholdRatio => (float)_row["autoHideHpThresholdRatio"].Value;
		public int autoHideHpThresholdValue => (int)_row["autoHideHpThresholdValue"].Value;
		public float autoHideMpThresholdRatio => (float)_row["autoHideMpThresholdRatio"].Value;
		public int autoHideMpThresholdValue => (int)_row["autoHideMpThresholdValue"].Value;
		public float autoHideSpThresholdRatio => (float)_row["autoHideSpThresholdRatio"].Value;
		public int autoHideSpThresholdValue => (int)_row["autoHideSpThresholdValue"].Value;
		public float worldMapZoomAnimationTime => (float)_row["worldMapZoomAnimationTime"].Value;
		public float worldMapIconScaleMin => (float)_row["worldMapIconScaleMin"].Value;
		public float worldMap_TravelMargin_Point => (float)_row["worldMap_TravelMargin_Point"].Value;
		public ushort enemyTagSafeLeft => (ushort)_row["enemyTagSafeLeft"].Value;
		public ushort enemyTagSafeRight => (ushort)_row["enemyTagSafeRight"].Value;
		public ushort enemyTagSafeTop => (ushort)_row["enemyTagSafeTop"].Value;
		public ushort enemyTagSafeBottom => (ushort)_row["enemyTagSafeBottom"].Value;
		public uint pcHorseHpRecoverDispThreshold => (uint)_row["pcHorseHpRecoverDispThreshold"].Value;
		public byte[] reserved33 => (byte[])_row["reserved33"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | soloPlayDeath_ToFadeOutTime: {soloPlayDeath_ToFadeOutTime} | partyGhostDeath_ToFadeOutTime: {partyGhostDeath_ToFadeOutTime} | playerMaxHpLimit: {playerMaxHpLimit} | playerMaxMpLimit: {playerMaxMpLimit} | playerMaxSpLimit: {playerMaxSpLimit} | actionPanelChangeThreshold_Vel: {actionPanelChangeThreshold_Vel} | actionPanelChangeThreshold_PassTime: {actionPanelChangeThreshold_PassTime} | kgIconVspace: {kgIconVspace} | worldMapCursorSelectRadius: {worldMapCursorSelectRadius} | decalPosOffsetX: {decalPosOffsetX} | decalPosOffsetY: {decalPosOffsetY} | targetStateSearchDurationTime: {targetStateSearchDurationTime} | targetStateBattleDurationTime: {targetStateBattleDurationTime} | worldMapCursorSpeed: {worldMapCursorSpeed} | worldMapCursorFirstDistance: {worldMapCursorFirstDistance} | worldMapCursorFirstDelay: {worldMapCursorFirstDelay} | worldMapCursorWaitTime: {worldMapCursorWaitTime} | worldMapCursorSnapRadius: {worldMapCursorSnapRadius} | worldMapCursorSnapTime: {worldMapCursorSnapTime} | itemGetLogAliveTime: {itemGetLogAliveTime} | playerMaxSaLimit: {playerMaxSaLimit} | worldMap_IsChangeableLayerEventFlagId: {worldMap_IsChangeableLayerEventFlagId} | worldMap_TravelMargin: {worldMap_TravelMargin} | systemAnnounceScrollBufferTime: {systemAnnounceScrollBufferTime} | systemAnnounceScrollSpeed: {systemAnnounceScrollSpeed} | systemAnnounceNoScrollWaitTime: {systemAnnounceNoScrollWaitTime} | systemAnnounceScrollCount: {systemAnnounceScrollCount} | compassMemoDispDistance: {compassMemoDispDistance} | compassBonfireDispDistance: {compassBonfireDispDistance} | markerGoalThreshold: {markerGoalThreshold} | svSliderStep: {svSliderStep} | preOpeningMovie_WaitSec: {preOpeningMovie_WaitSec} | kgIconScale: {kgIconScale} | kgIconScale_forTable: {kgIconScale_forTable} | kgIconVspace_forTable: {kgIconVspace_forTable} | kgIconScale_forConfig: {kgIconScale_forConfig} | kgIconVspace_forConfig: {kgIconVspace_forConfig} | worldMap_SearchRadius: {worldMap_SearchRadius} | tutorialDisplayTime: {tutorialDisplayTime} | compassFriendHostInnerDistance: {compassFriendHostInnerDistance} | compassEnemyHostInnerDistance: {compassEnemyHostInnerDistance} | compassFriendGuestInnerDistance: {compassFriendGuestInnerDistance} | cutsceneKeyGuideAliveTime: {cutsceneKeyGuideAliveTime} | autoHideHpThresholdRatio: {autoHideHpThresholdRatio} | autoHideHpThresholdValue: {autoHideHpThresholdValue} | autoHideMpThresholdRatio: {autoHideMpThresholdRatio} | autoHideMpThresholdValue: {autoHideMpThresholdValue} | autoHideSpThresholdRatio: {autoHideSpThresholdRatio} | autoHideSpThresholdValue: {autoHideSpThresholdValue} | worldMapZoomAnimationTime: {worldMapZoomAnimationTime} | worldMapIconScaleMin: {worldMapIconScaleMin} | worldMap_TravelMargin_Point: {worldMap_TravelMargin_Point} | enemyTagSafeLeft: {enemyTagSafeLeft} | enemyTagSafeRight: {enemyTagSafeRight} | enemyTagSafeTop: {enemyTagSafeTop} | enemyTagSafeBottom: {enemyTagSafeBottom} | pcHorseHpRecoverDispThreshold: {pcHorseHpRecoverDispThreshold}";
	}
}
