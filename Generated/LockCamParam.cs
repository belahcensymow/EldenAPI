using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class LockCamParam
	{
		private readonly PARAM _param;
		public LockCamParam(PARAM param) => _param = param;
		public IEnumerable<LockCamParamRow> Entries => _param.Rows.Select(r => new LockCamParamRow(r));
	}
	public class LockCamParamRow
	{
		private readonly PARAM.Row _row;
		public LockCamParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float camDistTarget => (float)_row["camDistTarget"].Value;
		public float rotRangeMinX => (float)_row["rotRangeMinX"].Value;
		public float lockRotXShiftRatio => (float)_row["lockRotXShiftRatio"].Value;
		public float chrOrgOffset_Y => (float)_row["chrOrgOffset_Y"].Value;
		public float chrLockRangeMaxRadius => (float)_row["chrLockRangeMaxRadius"].Value;
		public float camFovY => (float)_row["camFovY"].Value;
		public float chrLockRangeMaxRadius_forD => (float)_row["chrLockRangeMaxRadius_forD"].Value;
		public float chrLockRangeMaxRadius_forPD => (float)_row["chrLockRangeMaxRadius_forPD"].Value;
		public float closeMaxHeight => (float)_row["closeMaxHeight"].Value;
		public float closeMinHeight => (float)_row["closeMinHeight"].Value;
		public float closeAngRange => (float)_row["closeAngRange"].Value;
		public float closeMaxRadius => (float)_row["closeMaxRadius"].Value;
		public float closeMaxRadius_forD => (float)_row["closeMaxRadius_forD"].Value;
		public float closeMaxRadius_forPD => (float)_row["closeMaxRadius_forPD"].Value;
		public float bulletMaxRadius => (float)_row["bulletMaxRadius"].Value;
		public float bulletMaxRadius_forD => (float)_row["bulletMaxRadius_forD"].Value;
		public float bulletMaxRadius_forPD => (float)_row["bulletMaxRadius_forPD"].Value;
		public float bulletAngRange => (float)_row["bulletAngRange"].Value;
		public float lockTgtKeepTime => (float)_row["lockTgtKeepTime"].Value;
		public float chrTransChaseRateForNormal => (float)_row["chrTransChaseRateForNormal"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | camDistTarget: {camDistTarget} | rotRangeMinX: {rotRangeMinX} | lockRotXShiftRatio: {lockRotXShiftRatio} | chrOrgOffset_Y: {chrOrgOffset_Y} | chrLockRangeMaxRadius: {chrLockRangeMaxRadius} | camFovY: {camFovY} | chrLockRangeMaxRadius_forD: {chrLockRangeMaxRadius_forD} | chrLockRangeMaxRadius_forPD: {chrLockRangeMaxRadius_forPD} | closeMaxHeight: {closeMaxHeight} | closeMinHeight: {closeMinHeight} | closeAngRange: {closeAngRange} | closeMaxRadius: {closeMaxRadius} | closeMaxRadius_forD: {closeMaxRadius_forD} | closeMaxRadius_forPD: {closeMaxRadius_forPD} | bulletMaxRadius: {bulletMaxRadius} | bulletMaxRadius_forD: {bulletMaxRadius_forD} | bulletMaxRadius_forPD: {bulletMaxRadius_forPD} | bulletAngRange: {bulletAngRange} | lockTgtKeepTime: {lockTgtKeepTime} | chrTransChaseRateForNormal: {chrTransChaseRateForNormal}";
	}
}
