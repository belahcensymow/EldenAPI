using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class RideParam
	{
		private readonly PARAM _param;
		public RideParam(PARAM param) => _param = param;
		public IEnumerable<RideParamRow> Entries => _param.Rows.Select(r => new RideParamRow(r));
	}
	public class RideParamRow
	{
		private readonly PARAM.Row _row;
		public RideParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public uint atkChrId => (uint)_row["atkChrId"].Value;
		public uint defChrId => (uint)_row["defChrId"].Value;
		public int rideCamParamId => (int)_row["rideCamParamId"].Value;
		public uint atkChrAnimId => (uint)_row["atkChrAnimId"].Value;
		public uint defChrAnimId => (uint)_row["defChrAnimId"].Value;
		public int defAdjustDmyId => (int)_row["defAdjustDmyId"].Value;
		public int defCheckDmyId => (int)_row["defCheckDmyId"].Value;
		public float diffAngMyToDef => (float)_row["diffAngMyToDef"].Value;
		public float dist => (float)_row["dist"].Value;
		public float upperYRange => (float)_row["upperYRange"].Value;
		public float lowerYRange => (float)_row["lowerYRange"].Value;
		public float diffAngMin => (float)_row["diffAngMin"].Value;
		public float diffAngMax => (float)_row["diffAngMax"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | atkChrId: {atkChrId} | defChrId: {defChrId} | rideCamParamId: {rideCamParamId} | atkChrAnimId: {atkChrAnimId} | defChrAnimId: {defChrAnimId} | defAdjustDmyId: {defAdjustDmyId} | defCheckDmyId: {defCheckDmyId} | diffAngMyToDef: {diffAngMyToDef} | dist: {dist} | upperYRange: {upperYRange} | lowerYRange: {lowerYRange} | diffAngMin: {diffAngMin} | diffAngMax: {diffAngMax}";
	}
}
