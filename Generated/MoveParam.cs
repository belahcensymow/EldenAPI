using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class MoveParam
	{
		private readonly PARAM _param;
		public MoveParam(PARAM param) => _param = param;
		public IEnumerable<MoveParamRow> Entries => _param.Rows.Select(r => new MoveParamRow(r));
	}
	public class MoveParamRow
	{
		private readonly PARAM.Row _row;
		public MoveParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int stayId => (int)_row["stayId"].Value;
		public int walkF => (int)_row["walkF"].Value;
		public int walkB => (int)_row["walkB"].Value;
		public int walkL => (int)_row["walkL"].Value;
		public int walkR => (int)_row["walkR"].Value;
		public int dashF => (int)_row["dashF"].Value;
		public int dashB => (int)_row["dashB"].Value;
		public int dashL => (int)_row["dashL"].Value;
		public int dashR => (int)_row["dashR"].Value;
		public int superDash => (int)_row["superDash"].Value;
		public int escapeF => (int)_row["escapeF"].Value;
		public int escapeB => (int)_row["escapeB"].Value;
		public int escapeL => (int)_row["escapeL"].Value;
		public int escapeR => (int)_row["escapeR"].Value;
		public int turnL => (int)_row["turnL"].Value;
		public int trunR => (int)_row["trunR"].Value;
		public int largeTurnL => (int)_row["largeTurnL"].Value;
		public int largeTurnR => (int)_row["largeTurnR"].Value;
		public int stepMove => (int)_row["stepMove"].Value;
		public int flyStay => (int)_row["flyStay"].Value;
		public int flyWalkF => (int)_row["flyWalkF"].Value;
		public int flyWalkFL => (int)_row["flyWalkFL"].Value;
		public int flyWalkFR => (int)_row["flyWalkFR"].Value;
		public int flyWalkFL2 => (int)_row["flyWalkFL2"].Value;
		public int flyWalkFR2 => (int)_row["flyWalkFR2"].Value;
		public int flyDashF => (int)_row["flyDashF"].Value;
		public int flyDashFL => (int)_row["flyDashFL"].Value;
		public int flyDashFR => (int)_row["flyDashFR"].Value;
		public int flyDashFL2 => (int)_row["flyDashFL2"].Value;
		public int flyDashFR2 => (int)_row["flyDashFR2"].Value;
		public int dashEscapeF => (int)_row["dashEscapeF"].Value;
		public int dashEscapeB => (int)_row["dashEscapeB"].Value;
		public int dashEscapeL => (int)_row["dashEscapeL"].Value;
		public int dashEscapeR => (int)_row["dashEscapeR"].Value;
		public int analogMoveParamId => (int)_row["analogMoveParamId"].Value;
		public byte turnNoAnimAngle => (byte)_row["turnNoAnimAngle"].Value;
		public byte turn45Angle => (byte)_row["turn45Angle"].Value;
		public byte turn90Angle => (byte)_row["turn90Angle"].Value;
		public byte turnWaitNoAnimAngle => (byte)_row["turnWaitNoAnimAngle"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | stayId: {stayId} | walkF: {walkF} | walkB: {walkB} | walkL: {walkL} | walkR: {walkR} | dashF: {dashF} | dashB: {dashB} | dashL: {dashL} | dashR: {dashR} | superDash: {superDash} | escapeF: {escapeF} | escapeB: {escapeB} | escapeL: {escapeL} | escapeR: {escapeR} | turnL: {turnL} | trunR: {trunR} | largeTurnL: {largeTurnL} | largeTurnR: {largeTurnR} | stepMove: {stepMove} | flyStay: {flyStay} | flyWalkF: {flyWalkF} | flyWalkFL: {flyWalkFL} | flyWalkFR: {flyWalkFR} | flyWalkFL2: {flyWalkFL2} | flyWalkFR2: {flyWalkFR2} | flyDashF: {flyDashF} | flyDashFL: {flyDashFL} | flyDashFR: {flyDashFR} | flyDashFL2: {flyDashFL2} | flyDashFR2: {flyDashFR2} | dashEscapeF: {dashEscapeF} | dashEscapeB: {dashEscapeB} | dashEscapeL: {dashEscapeL} | dashEscapeR: {dashEscapeR} | analogMoveParamId: {analogMoveParamId} | turnNoAnimAngle: {turnNoAnimAngle} | turn45Angle: {turn45Angle} | turn90Angle: {turn90Angle} | turnWaitNoAnimAngle: {turnWaitNoAnimAngle}";
	}
}
