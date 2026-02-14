using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class BonfireWarpParam
	{
		private readonly PARAM _param;
		public BonfireWarpParam(PARAM param) => _param = param;
		public IEnumerable<BonfireWarpParamRow> Entries => _param.Rows.Select(r => new BonfireWarpParamRow(r));
	}
	public class BonfireWarpParamRow
	{
		private readonly PARAM.Row _row;
		public BonfireWarpParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] disableParam_NT => (byte[])_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public uint eventflagId => (uint)_row["eventflagId"].Value;
		public uint bonfireEntityId => (uint)_row["bonfireEntityId"].Value;
		public byte[] pad4 => (byte[])_row["pad4"].Value;
		public ushort bonfireSubCategorySortId => (ushort)_row["bonfireSubCategorySortId"].Value;
		public ushort forbiddenIconId => (ushort)_row["forbiddenIconId"].Value;
		public byte dispMinZoomStep => (byte)_row["dispMinZoomStep"].Value;
		public byte selectMinZoomStep => (byte)_row["selectMinZoomStep"].Value;
		public int bonfireSubCategoryId => (int)_row["bonfireSubCategoryId"].Value;
		public uint clearedEventFlagId => (uint)_row["clearedEventFlagId"].Value;
		public ushort iconId => (ushort)_row["iconId"].Value;
		public byte[] dispMask00 => (byte[])_row["dispMask00"].Value;
		public byte[] dispMask01 => (byte[])_row["dispMask01"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public byte areaNo => (byte)_row["areaNo"].Value;
		public byte gridXNo => (byte)_row["gridXNo"].Value;
		public byte gridZNo => (byte)_row["gridZNo"].Value;
		public byte[] pad3 => (byte[])_row["pad3"].Value;
		public float posX => (float)_row["posX"].Value;
		public float posY => (float)_row["posY"].Value;
		public float posZ => (float)_row["posZ"].Value;
		public int textId1 => (int)_row["textId1"].Value;
		public uint textEnableFlagId1 => (uint)_row["textEnableFlagId1"].Value;
		public uint textDisableFlagId1 => (uint)_row["textDisableFlagId1"].Value;
		public int textId2 => (int)_row["textId2"].Value;
		public uint textEnableFlagId2 => (uint)_row["textEnableFlagId2"].Value;
		public uint textDisableFlagId2 => (uint)_row["textDisableFlagId2"].Value;
		public int textId3 => (int)_row["textId3"].Value;
		public uint textEnableFlagId3 => (uint)_row["textEnableFlagId3"].Value;
		public uint textDisableFlagId3 => (uint)_row["textDisableFlagId3"].Value;
		public int textId4 => (int)_row["textId4"].Value;
		public uint textEnableFlagId4 => (uint)_row["textEnableFlagId4"].Value;
		public uint textDisableFlagId4 => (uint)_row["textDisableFlagId4"].Value;
		public int textId5 => (int)_row["textId5"].Value;
		public uint textEnableFlagId5 => (uint)_row["textEnableFlagId5"].Value;
		public uint textDisableFlagId5 => (uint)_row["textDisableFlagId5"].Value;
		public int textId6 => (int)_row["textId6"].Value;
		public uint textEnableFlagId6 => (uint)_row["textEnableFlagId6"].Value;
		public uint textDisableFlagId6 => (uint)_row["textDisableFlagId6"].Value;
		public int textId7 => (int)_row["textId7"].Value;
		public uint textEnableFlagId7 => (uint)_row["textEnableFlagId7"].Value;
		public uint textDisableFlagId7 => (uint)_row["textDisableFlagId7"].Value;
		public int textId8 => (int)_row["textId8"].Value;
		public uint textEnableFlagId8 => (uint)_row["textEnableFlagId8"].Value;
		public uint textDisableFlagId8 => (uint)_row["textDisableFlagId8"].Value;
		public byte[] textType1 => (byte[])_row["textType1"].Value;
		public byte[] textType2 => (byte[])_row["textType2"].Value;
		public byte[] textType3 => (byte[])_row["textType3"].Value;
		public byte[] textType4 => (byte[])_row["textType4"].Value;
		public byte[] textType5 => (byte[])_row["textType5"].Value;
		public byte[] textType6 => (byte[])_row["textType6"].Value;
		public byte[] textType7 => (byte[])_row["textType7"].Value;
		public byte[] textType8 => (byte[])_row["textType8"].Value;
		public int noIgnitionSfxDmypolyId_0 => (int)_row["noIgnitionSfxDmypolyId_0"].Value;
		public int noIgnitionSfxId_0 => (int)_row["noIgnitionSfxId_0"].Value;
		public int noIgnitionSfxDmypolyId_1 => (int)_row["noIgnitionSfxDmypolyId_1"].Value;
		public int noIgnitionSfxId_1 => (int)_row["noIgnitionSfxId_1"].Value;
		public int unkA8 => (int)_row["unkA8"].Value;
		public int unkAC => (int)_row["unkAC"].Value;
		public int unkB0 => (int)_row["unkB0"].Value;
		public int unkB4 => (int)_row["unkB4"].Value;
		public int unkB8 => (int)_row["unkB8"].Value;
		public int unkBC => (int)_row["unkBC"].Value;
		public int unkC0 => (int)_row["unkC0"].Value;
		public int unkC4 => (int)_row["unkC4"].Value;
		public int unkC8 => (int)_row["unkC8"].Value;
		public int unkCC => (int)_row["unkCC"].Value;
		public int unkD0 => (int)_row["unkD0"].Value;
		public int unkD4 => (int)_row["unkD4"].Value;
		public int unkD8 => (int)_row["unkD8"].Value;
		public int unkDC => (int)_row["unkDC"].Value;
		public int unkE0 => (int)_row["unkE0"].Value;
		public int unkE4 => (int)_row["unkE4"].Value;
		public int unkE8 => (int)_row["unkE8"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | eventflagId: {eventflagId} | bonfireEntityId: {bonfireEntityId} | bonfireSubCategorySortId: {bonfireSubCategorySortId} | forbiddenIconId: {forbiddenIconId} | dispMinZoomStep: {dispMinZoomStep} | selectMinZoomStep: {selectMinZoomStep} | bonfireSubCategoryId: {bonfireSubCategoryId} | clearedEventFlagId: {clearedEventFlagId} | iconId: {iconId} | areaNo: {areaNo} | gridXNo: {gridXNo} | gridZNo: {gridZNo} | posX: {posX} | posY: {posY} | posZ: {posZ} | textId1: {textId1} | textEnableFlagId1: {textEnableFlagId1} | textDisableFlagId1: {textDisableFlagId1} | textId2: {textId2} | textEnableFlagId2: {textEnableFlagId2} | textDisableFlagId2: {textDisableFlagId2} | textId3: {textId3} | textEnableFlagId3: {textEnableFlagId3} | textDisableFlagId3: {textDisableFlagId3} | textId4: {textId4} | textEnableFlagId4: {textEnableFlagId4} | textDisableFlagId4: {textDisableFlagId4} | textId5: {textId5} | textEnableFlagId5: {textEnableFlagId5} | textDisableFlagId5: {textDisableFlagId5} | textId6: {textId6} | textEnableFlagId6: {textEnableFlagId6} | textDisableFlagId6: {textDisableFlagId6} | textId7: {textId7} | textEnableFlagId7: {textEnableFlagId7} | textDisableFlagId7: {textDisableFlagId7} | textId8: {textId8} | textEnableFlagId8: {textEnableFlagId8} | textDisableFlagId8: {textDisableFlagId8} | noIgnitionSfxDmypolyId_0: {noIgnitionSfxDmypolyId_0} | noIgnitionSfxId_0: {noIgnitionSfxId_0} | noIgnitionSfxDmypolyId_1: {noIgnitionSfxDmypolyId_1} | noIgnitionSfxId_1: {noIgnitionSfxId_1} | unkA8: {unkA8} | unkAC: {unkAC} | unkB0: {unkB0} | unkB4: {unkB4} | unkB8: {unkB8} | unkBC: {unkBC} | unkC0: {unkC0} | unkC4: {unkC4} | unkC8: {unkC8} | unkCC: {unkCC} | unkD0: {unkD0} | unkD4: {unkD4} | unkD8: {unkD8} | unkDC: {unkDC} | unkE0: {unkE0} | unkE4: {unkE4} | unkE8: {unkE8}";
	}
}
