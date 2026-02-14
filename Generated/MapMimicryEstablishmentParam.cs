using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class MapMimicryEstablishmentParam
	{
		private readonly PARAM _param;
		public MapMimicryEstablishmentParam(PARAM param) => _param = param;
		public IEnumerable<MapMimicryEstablishmentParamRow> Entries => _param.Rows.Select(r => new MapMimicryEstablishmentParamRow(r));
	}
	public class MapMimicryEstablishmentParamRow
	{
		private readonly PARAM.Row _row;
		public MapMimicryEstablishmentParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float mimicryEstablishment0 => (float)_row["mimicryEstablishment0"].Value;
		public float mimicryEstablishment1 => (float)_row["mimicryEstablishment1"].Value;
		public float mimicryEstablishment2 => (float)_row["mimicryEstablishment2"].Value;
		public int mimicryBeginSfxId0 => (int)_row["mimicryBeginSfxId0"].Value;
		public int mimicrySfxId0 => (int)_row["mimicrySfxId0"].Value;
		public int mimicryEndSfxId0 => (int)_row["mimicryEndSfxId0"].Value;
		public int mimicryBeginSfxId1 => (int)_row["mimicryBeginSfxId1"].Value;
		public int mimicrySfxId1 => (int)_row["mimicrySfxId1"].Value;
		public int mimicryEndSfxId1 => (int)_row["mimicryEndSfxId1"].Value;
		public int mimicryBeginSfxId2 => (int)_row["mimicryBeginSfxId2"].Value;
		public int mimicrySfxId2 => (int)_row["mimicrySfxId2"].Value;
		public int mimicryEndSfxId2 => (int)_row["mimicryEndSfxId2"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | mimicryEstablishment0: {mimicryEstablishment0} | mimicryEstablishment1: {mimicryEstablishment1} | mimicryEstablishment2: {mimicryEstablishment2} | mimicryBeginSfxId0: {mimicryBeginSfxId0} | mimicrySfxId0: {mimicrySfxId0} | mimicryEndSfxId0: {mimicryEndSfxId0} | mimicryBeginSfxId1: {mimicryBeginSfxId1} | mimicrySfxId1: {mimicrySfxId1} | mimicryEndSfxId1: {mimicryEndSfxId1} | mimicryBeginSfxId2: {mimicryBeginSfxId2} | mimicrySfxId2: {mimicrySfxId2} | mimicryEndSfxId2: {mimicryEndSfxId2}";
	}
}
