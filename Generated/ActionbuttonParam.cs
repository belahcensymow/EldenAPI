using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class ActionbuttonParam
	{
		private readonly PARAM _param;
		public ActionbuttonParam(PARAM param) => _param = param;
		public IEnumerable<ActionbuttonParamRow> Entries => _param.Rows.Select(r => new ActionbuttonParamRow(r));
	}
	public class ActionbuttonParamRow
	{
		private readonly PARAM.Row _row;
		public ActionbuttonParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte regionType => (byte)_row["regionType"].Value;
		public byte category => (byte)_row["category"].Value;
		public byte[] padding1 => (byte[])_row["padding1"].Value;
		public int dummyPoly1 => (int)_row["dummyPoly1"].Value;
		public int dummyPoly2 => (int)_row["dummyPoly2"].Value;
		public float radius => (float)_row["radius"].Value;
		public int angle => (int)_row["angle"].Value;
		public float depth => (float)_row["depth"].Value;
		public float width => (float)_row["width"].Value;
		public float height => (float)_row["height"].Value;
		public float baseHeightOffset => (float)_row["baseHeightOffset"].Value;
		public byte angleCheckType => (byte)_row["angleCheckType"].Value;
		public byte[] padding2 => (byte[])_row["padding2"].Value;
		public int allowAngle => (int)_row["allowAngle"].Value;
		public int spotDummyPoly => (int)_row["spotDummyPoly"].Value;
		public byte textBoxType => (byte)_row["textBoxType"].Value;
		public byte[] padding3 => (byte[])_row["padding3"].Value;
		public byte[] padding5 => (byte[])_row["padding5"].Value;
		public byte isInvalidForRide => (byte)_row["isInvalidForRide"].Value;
		public byte isGrayoutForRide => (byte)_row["isGrayoutForRide"].Value;
		public byte isInvalidForCrouching => (byte)_row["isInvalidForCrouching"].Value;
		public byte isGrayoutForCrouching => (byte)_row["isGrayoutForCrouching"].Value;
		public byte[] padding4 => (byte[])_row["padding4"].Value;
		public int textId => (int)_row["textId"].Value;
		public uint invalidFlag => (uint)_row["invalidFlag"].Value;
		public uint grayoutFlag => (uint)_row["grayoutFlag"].Value;
		public int overrideActionButtonIdForRide => (int)_row["overrideActionButtonIdForRide"].Value;
		public float execInvalidTime => (float)_row["execInvalidTime"].Value;
		public byte[] padding6 => (byte[])_row["padding6"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | regionType: {regionType} | category: {category} | dummyPoly1: {dummyPoly1} | dummyPoly2: {dummyPoly2} | radius: {radius} | angle: {angle} | depth: {depth} | width: {width} | height: {height} | baseHeightOffset: {baseHeightOffset} | angleCheckType: {angleCheckType} | allowAngle: {allowAngle} | spotDummyPoly: {spotDummyPoly} | textBoxType: {textBoxType} | isInvalidForRide: {isInvalidForRide} | isGrayoutForRide: {isGrayoutForRide} | isInvalidForCrouching: {isInvalidForCrouching} | isGrayoutForCrouching: {isGrayoutForCrouching} | textId: {textId} | invalidFlag: {invalidFlag} | grayoutFlag: {grayoutFlag} | overrideActionButtonIdForRide: {overrideActionButtonIdForRide} | execInvalidTime: {execInvalidTime}";
	}
}
