using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class CutsceneTextureLoadParam
	{
		private readonly PARAM _param;
		public CutsceneTextureLoadParam(PARAM param) => _param = param;
		public IEnumerable<CutsceneTextureLoadParamRow> Entries => _param.Rows.Select(r => new CutsceneTextureLoadParamRow(r));
	}
	public class CutsceneTextureLoadParamRow
	{
		private readonly PARAM.Row _row;
		public CutsceneTextureLoadParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte disableParam_NT => (byte)_row["disableParam_NT"].Value;
		public byte disableParam_Debug => (byte)_row["disableParam_Debug"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public string texName_00 => (string)_row["texName_00"].Value;
		public string texName_01 => (string)_row["texName_01"].Value;
		public string texName_02 => (string)_row["texName_02"].Value;
		public string texName_03 => (string)_row["texName_03"].Value;
		public string texName_04 => (string)_row["texName_04"].Value;
		public string texName_05 => (string)_row["texName_05"].Value;
		public string texName_06 => (string)_row["texName_06"].Value;
		public string texName_07 => (string)_row["texName_07"].Value;
		public string texName_08 => (string)_row["texName_08"].Value;
		public string texName_09 => (string)_row["texName_09"].Value;
		public string texName_10 => (string)_row["texName_10"].Value;
		public string texName_11 => (string)_row["texName_11"].Value;
		public string texName_12 => (string)_row["texName_12"].Value;
		public string texName_13 => (string)_row["texName_13"].Value;
		public string texName_14 => (string)_row["texName_14"].Value;
		public string texName_15 => (string)_row["texName_15"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | disableParam_NT: {disableParam_NT} | disableParam_Debug: {disableParam_Debug} | texName_00: {texName_00} | texName_01: {texName_01} | texName_02: {texName_02} | texName_03: {texName_03} | texName_04: {texName_04} | texName_05: {texName_05} | texName_06: {texName_06} | texName_07: {texName_07} | texName_08: {texName_08} | texName_09: {texName_09} | texName_10: {texName_10} | texName_11: {texName_11} | texName_12: {texName_12} | texName_13: {texName_13} | texName_14: {texName_14} | texName_15: {texName_15}";
	}
}
