using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class RuntimeBoneControlParam
	{
		private readonly PARAM _param;
		public RuntimeBoneControlParam(PARAM param) => _param = param;
		public IEnumerable<RuntimeBoneControlParamRow> Entries => _param.Rows.Select(r => new RuntimeBoneControlParamRow(r));
	}
	public class RuntimeBoneControlParamRow
	{
		private readonly PARAM.Row _row;
		public RuntimeBoneControlParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public uint chrId => (uint)_row["chrId"].Value;
		public byte[] ctrlType => (byte[])_row["ctrlType"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public string applyBone => (string)_row["applyBone"].Value;
		public string targetBone1 => (string)_row["targetBone1"].Value;
		public string targetBone2 => (string)_row["targetBone2"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | chrId: {chrId} | applyBone: {applyBone} | targetBone1: {targetBone1} | targetBone2: {targetBone2}";
	}
}
