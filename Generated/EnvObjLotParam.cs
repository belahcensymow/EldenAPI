using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class EnvObjLotParam
	{
		private readonly PARAM _param;
		public EnvObjLotParam(PARAM param) => _param = param;
		public IEnumerable<EnvObjLotParamRow> Entries => _param.Rows.Select(r => new EnvObjLotParamRow(r));
	}
	public class EnvObjLotParamRow
	{
		private readonly PARAM.Row _row;
		public EnvObjLotParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int AssetId_0 => (int)_row["AssetId_0"].Value;
		public int AssetId_1 => (int)_row["AssetId_1"].Value;
		public int AssetId_2 => (int)_row["AssetId_2"].Value;
		public int AssetId_3 => (int)_row["AssetId_3"].Value;
		public int AssetId_4 => (int)_row["AssetId_4"].Value;
		public int AssetId_5 => (int)_row["AssetId_5"].Value;
		public int AssetId_6 => (int)_row["AssetId_6"].Value;
		public int AssetId_7 => (int)_row["AssetId_7"].Value;
		public byte CreateWeight_0 => (byte)_row["CreateWeight_0"].Value;
		public byte CreateWeight_1 => (byte)_row["CreateWeight_1"].Value;
		public byte CreateWeight_2 => (byte)_row["CreateWeight_2"].Value;
		public byte CreateWeight_3 => (byte)_row["CreateWeight_3"].Value;
		public byte CreateWeight_4 => (byte)_row["CreateWeight_4"].Value;
		public byte CreateWeight_5 => (byte)_row["CreateWeight_5"].Value;
		public byte CreateWeight_6 => (byte)_row["CreateWeight_6"].Value;
		public byte CreateWeight_7 => (byte)_row["CreateWeight_7"].Value;
		public byte[] Reserve_0 => (byte[])_row["Reserve_0"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | AssetId_0: {AssetId_0} | AssetId_1: {AssetId_1} | AssetId_2: {AssetId_2} | AssetId_3: {AssetId_3} | AssetId_4: {AssetId_4} | AssetId_5: {AssetId_5} | AssetId_6: {AssetId_6} | AssetId_7: {AssetId_7} | CreateWeight_0: {CreateWeight_0} | CreateWeight_1: {CreateWeight_1} | CreateWeight_2: {CreateWeight_2} | CreateWeight_3: {CreateWeight_3} | CreateWeight_4: {CreateWeight_4} | CreateWeight_5: {CreateWeight_5} | CreateWeight_6: {CreateWeight_6} | CreateWeight_7: {CreateWeight_7}";
	}
}
