using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class ThrowParam
	{
		private readonly PARAM _param;
		public ThrowParam(PARAM param) => _param = param;
		public IEnumerable<ThrowParamRow> Entries => _param.Rows.Select(r => new ThrowParamRow(r));
	}
	public class ThrowParamRow
	{
		private readonly PARAM.Row _row;
		public ThrowParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int AtkChrId => (int)_row["AtkChrId"].Value;
		public int DefChrId => (int)_row["DefChrId"].Value;
		public float Dist => (float)_row["Dist"].Value;
		public float DiffAngMin => (float)_row["DiffAngMin"].Value;
		public float DiffAngMax => (float)_row["DiffAngMax"].Value;
		public float upperYRange => (float)_row["upperYRange"].Value;
		public float lowerYRange => (float)_row["lowerYRange"].Value;
		public float diffAngMyToDef => (float)_row["diffAngMyToDef"].Value;
		public int throwTypeId => (int)_row["throwTypeId"].Value;
		public int atkAnimId => (int)_row["atkAnimId"].Value;
		public int defAnimId => (int)_row["defAnimId"].Value;
		public ushort escHp => (ushort)_row["escHp"].Value;
		public ushort selfEscCycleTime => (ushort)_row["selfEscCycleTime"].Value;
		public ushort sphereCastRadiusRateTop => (ushort)_row["sphereCastRadiusRateTop"].Value;
		public ushort sphereCastRadiusRateLow => (ushort)_row["sphereCastRadiusRateLow"].Value;
		public byte PadType => (byte)_row["PadType"].Value;
		public byte AtkEnableState => (byte)_row["AtkEnableState"].Value;
		public byte throwFollowingType => (byte)_row["throwFollowingType"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public byte throwType => (byte)_row["throwType"].Value;
		public byte selfEscCycleCnt => (byte)_row["selfEscCycleCnt"].Value;
		public byte dmyHasChrDirType => (byte)_row["dmyHasChrDirType"].Value;
		public byte isTurnAtker => (byte)_row["isTurnAtker"].Value;
		public byte isSkipWepCate => (byte)_row["isSkipWepCate"].Value;
		public byte isSkipSphereCast => (byte)_row["isSkipSphereCast"].Value;
		public byte isEnableCorrectPos_forThrowAdjust => (byte)_row["isEnableCorrectPos_forThrowAdjust"].Value;
		public byte isEnableThrowFollowingFallAssist => (byte)_row["isEnableThrowFollowingFallAssist"].Value;
		public byte isEnableThrowFollowingFeedback => (byte)_row["isEnableThrowFollowingFeedback"].Value;
		public byte[] pad0 => (byte[])_row["pad0"].Value;
		public short atkSorbDmyId => (short)_row["atkSorbDmyId"].Value;
		public short defSorbDmyId => (short)_row["defSorbDmyId"].Value;
		public float Dist_start => (float)_row["Dist_start"].Value;
		public float DiffAngMin_start => (float)_row["DiffAngMin_start"].Value;
		public float DiffAngMax_start => (float)_row["DiffAngMax_start"].Value;
		public float upperYRange_start => (float)_row["upperYRange_start"].Value;
		public float lowerYRange_start => (float)_row["lowerYRange_start"].Value;
		public float diffAngMyToDef_start => (float)_row["diffAngMyToDef_start"].Value;
		public int judgeRangeBasePosDmyId1 => (int)_row["judgeRangeBasePosDmyId1"].Value;
		public int judgeRangeBasePosDmyId2 => (int)_row["judgeRangeBasePosDmyId2"].Value;
		public float adsrobModelPosInterpolationTime => (float)_row["adsrobModelPosInterpolationTime"].Value;
		public float throwFollowingEndEasingTime => (float)_row["throwFollowingEndEasingTime"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | AtkChrId: {AtkChrId} | DefChrId: {DefChrId} | Dist: {Dist} | DiffAngMin: {DiffAngMin} | DiffAngMax: {DiffAngMax} | upperYRange: {upperYRange} | lowerYRange: {lowerYRange} | diffAngMyToDef: {diffAngMyToDef} | throwTypeId: {throwTypeId} | atkAnimId: {atkAnimId} | defAnimId: {defAnimId} | escHp: {escHp} | selfEscCycleTime: {selfEscCycleTime} | sphereCastRadiusRateTop: {sphereCastRadiusRateTop} | sphereCastRadiusRateLow: {sphereCastRadiusRateLow} | PadType: {PadType} | AtkEnableState: {AtkEnableState} | throwFollowingType: {throwFollowingType} | throwType: {throwType} | selfEscCycleCnt: {selfEscCycleCnt} | dmyHasChrDirType: {dmyHasChrDirType} | isTurnAtker: {isTurnAtker} | isSkipWepCate: {isSkipWepCate} | isSkipSphereCast: {isSkipSphereCast} | isEnableCorrectPos_forThrowAdjust: {isEnableCorrectPos_forThrowAdjust} | isEnableThrowFollowingFallAssist: {isEnableThrowFollowingFallAssist} | isEnableThrowFollowingFeedback: {isEnableThrowFollowingFeedback} | atkSorbDmyId: {atkSorbDmyId} | defSorbDmyId: {defSorbDmyId} | Dist_start: {Dist_start} | DiffAngMin_start: {DiffAngMin_start} | DiffAngMax_start: {DiffAngMax_start} | upperYRange_start: {upperYRange_start} | lowerYRange_start: {lowerYRange_start} | diffAngMyToDef_start: {diffAngMyToDef_start} | judgeRangeBasePosDmyId1: {judgeRangeBasePosDmyId1} | judgeRangeBasePosDmyId2: {judgeRangeBasePosDmyId2} | adsrobModelPosInterpolationTime: {adsrobModelPosInterpolationTime} | throwFollowingEndEasingTime: {throwFollowingEndEasingTime}";
	}
}
