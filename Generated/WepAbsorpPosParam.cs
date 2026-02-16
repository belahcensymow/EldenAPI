using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class WepAbsorpPosParam
	{
		private readonly PARAM _param;
		public WepAbsorpPosParam(PARAM param) => _param = param;
		public IEnumerable<WepAbsorpPosParamRow> Entries => _param.Rows.Select(r => new WepAbsorpPosParamRow(r));
	}
	public class WepAbsorpPosParamRow
	{
		private readonly PARAM.Row _row;
		public WepAbsorpPosParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte disableParam_NT => (byte)_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public byte hangPosType => (byte)_row["hangPosType"].Value;
		public byte isSkeletonBind => (byte)_row["isSkeletonBind"].Value;
		public byte[] pad0 => (byte[])_row["pad0"].Value;
		public short right_0 => (short)_row["right_0"].Value;
		public short left_0 => (short)_row["left_0"].Value;
		public short both_0 => (short)_row["both_0"].Value;
		public short leftHang_0 => (short)_row["leftHang_0"].Value;
		public short rightHang_0 => (short)_row["rightHang_0"].Value;
		public short right_1 => (short)_row["right_1"].Value;
		public short left_1 => (short)_row["left_1"].Value;
		public short both_1 => (short)_row["both_1"].Value;
		public short leftHang_1 => (short)_row["leftHang_1"].Value;
		public short rightHang_1 => (short)_row["rightHang_1"].Value;
		public short right_2 => (short)_row["right_2"].Value;
		public short left_2 => (short)_row["left_2"].Value;
		public short both_2 => (short)_row["both_2"].Value;
		public short leftHang_2 => (short)_row["leftHang_2"].Value;
		public short rightHang_2 => (short)_row["rightHang_2"].Value;
		public short right_3 => (short)_row["right_3"].Value;
		public short left_3 => (short)_row["left_3"].Value;
		public short both_3 => (short)_row["both_3"].Value;
		public short leftHang_3 => (short)_row["leftHang_3"].Value;
		public short rightHang_3 => (short)_row["rightHang_3"].Value;
		public byte wepInvisibleType_0 => (byte)_row["wepInvisibleType_0"].Value;
		public byte wepInvisibleType_1 => (byte)_row["wepInvisibleType_1"].Value;
		public byte wepInvisibleType_2 => (byte)_row["wepInvisibleType_2"].Value;
		public byte wepInvisibleType_3 => (byte)_row["wepInvisibleType_3"].Value;
		public short leftBoth_0 => (short)_row["leftBoth_0"].Value;
		public short leftBoth_1 => (short)_row["leftBoth_1"].Value;
		public short leftBoth_2 => (short)_row["leftBoth_2"].Value;
		public short leftBoth_3 => (short)_row["leftBoth_3"].Value;
		public byte dispPosType_right_0 => (byte)_row["dispPosType_right_0"].Value;
		public byte dispPosType_left_0 => (byte)_row["dispPosType_left_0"].Value;
		public byte dispPosType_rightBoth_0 => (byte)_row["dispPosType_rightBoth_0"].Value;
		public byte dispPosType_leftBoth_0 => (byte)_row["dispPosType_leftBoth_0"].Value;
		public byte dispPosType_rightHang_0 => (byte)_row["dispPosType_rightHang_0"].Value;
		public byte dispPosType_leftHang_0 => (byte)_row["dispPosType_leftHang_0"].Value;
		public byte dispPosType_right_1 => (byte)_row["dispPosType_right_1"].Value;
		public byte dispPosType_left_1 => (byte)_row["dispPosType_left_1"].Value;
		public byte dispPosType_rightBoth_1 => (byte)_row["dispPosType_rightBoth_1"].Value;
		public byte dispPosType_leftBoth_1 => (byte)_row["dispPosType_leftBoth_1"].Value;
		public byte dispPosType_rightHang_1 => (byte)_row["dispPosType_rightHang_1"].Value;
		public byte dispPosType_leftHang_1 => (byte)_row["dispPosType_leftHang_1"].Value;
		public byte dispPosType_right_2 => (byte)_row["dispPosType_right_2"].Value;
		public byte dispPosType_left_2 => (byte)_row["dispPosType_left_2"].Value;
		public byte dispPosType_rightBoth_2 => (byte)_row["dispPosType_rightBoth_2"].Value;
		public byte dispPosType_leftBoth_2 => (byte)_row["dispPosType_leftBoth_2"].Value;
		public byte dispPosType_rightHang_2 => (byte)_row["dispPosType_rightHang_2"].Value;
		public byte dispPosType_leftHang_2 => (byte)_row["dispPosType_leftHang_2"].Value;
		public byte dispPosType_right_3 => (byte)_row["dispPosType_right_3"].Value;
		public byte dispPosType_left_3 => (byte)_row["dispPosType_left_3"].Value;
		public byte dispPosType_rightBoth_3 => (byte)_row["dispPosType_rightBoth_3"].Value;
		public byte dispPosType_leftBoth_3 => (byte)_row["dispPosType_leftBoth_3"].Value;
		public byte dispPosType_rightHang_3 => (byte)_row["dispPosType_rightHang_3"].Value;
		public byte dispPosType_leftHang_3 => (byte)_row["dispPosType_leftHang_3"].Value;
		public byte[] reserve => (byte[])_row["reserve"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | disableParam_NT: {disableParam_NT} | hangPosType: {hangPosType} | isSkeletonBind: {isSkeletonBind} | right_0: {right_0} | left_0: {left_0} | both_0: {both_0} | leftHang_0: {leftHang_0} | rightHang_0: {rightHang_0} | right_1: {right_1} | left_1: {left_1} | both_1: {both_1} | leftHang_1: {leftHang_1} | rightHang_1: {rightHang_1} | right_2: {right_2} | left_2: {left_2} | both_2: {both_2} | leftHang_2: {leftHang_2} | rightHang_2: {rightHang_2} | right_3: {right_3} | left_3: {left_3} | both_3: {both_3} | leftHang_3: {leftHang_3} | rightHang_3: {rightHang_3} | wepInvisibleType_0: {wepInvisibleType_0} | wepInvisibleType_1: {wepInvisibleType_1} | wepInvisibleType_2: {wepInvisibleType_2} | wepInvisibleType_3: {wepInvisibleType_3} | leftBoth_0: {leftBoth_0} | leftBoth_1: {leftBoth_1} | leftBoth_2: {leftBoth_2} | leftBoth_3: {leftBoth_3} | dispPosType_right_0: {dispPosType_right_0} | dispPosType_left_0: {dispPosType_left_0} | dispPosType_rightBoth_0: {dispPosType_rightBoth_0} | dispPosType_leftBoth_0: {dispPosType_leftBoth_0} | dispPosType_rightHang_0: {dispPosType_rightHang_0} | dispPosType_leftHang_0: {dispPosType_leftHang_0} | dispPosType_right_1: {dispPosType_right_1} | dispPosType_left_1: {dispPosType_left_1} | dispPosType_rightBoth_1: {dispPosType_rightBoth_1} | dispPosType_leftBoth_1: {dispPosType_leftBoth_1} | dispPosType_rightHang_1: {dispPosType_rightHang_1} | dispPosType_leftHang_1: {dispPosType_leftHang_1} | dispPosType_right_2: {dispPosType_right_2} | dispPosType_left_2: {dispPosType_left_2} | dispPosType_rightBoth_2: {dispPosType_rightBoth_2} | dispPosType_leftBoth_2: {dispPosType_leftBoth_2} | dispPosType_rightHang_2: {dispPosType_rightHang_2} | dispPosType_leftHang_2: {dispPosType_leftHang_2} | dispPosType_right_3: {dispPosType_right_3} | dispPosType_left_3: {dispPosType_left_3} | dispPosType_rightBoth_3: {dispPosType_rightBoth_3} | dispPosType_leftBoth_3: {dispPosType_leftBoth_3} | dispPosType_rightHang_3: {dispPosType_rightHang_3} | dispPosType_leftHang_3: {dispPosType_leftHang_3}";
	}
}
