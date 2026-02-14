using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class SoundAutoReverbSelectParam
	{
		private readonly PARAM _param;
		public SoundAutoReverbSelectParam(PARAM param) => _param = param;
		public IEnumerable<SoundAutoReverbSelectParamRow> Entries => _param.Rows.Select(r => new SoundAutoReverbSelectParamRow(r));
	}
	public class SoundAutoReverbSelectParamRow
	{
		private readonly PARAM.Row _row;
		public SoundAutoReverbSelectParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public uint reverbType => (uint)_row["reverbType"].Value;
		public int AreaNo => (int)_row["AreaNo"].Value;
		public sbyte IndoorOutdoor => (sbyte)_row["IndoorOutdoor"].Value;
		public sbyte useDistNoA => (sbyte)_row["useDistNoA"].Value;
		public sbyte useDistNoB => (sbyte)_row["useDistNoB"].Value;
		public byte[] pad0 => (byte[])_row["pad0"].Value;
		public float DistMinA => (float)_row["DistMinA"].Value;
		public float DistMaxA => (float)_row["DistMaxA"].Value;
		public float DistMinB => (float)_row["DistMinB"].Value;
		public float DistMaxB => (float)_row["DistMaxB"].Value;
		public int NoHitNumMin => (int)_row["NoHitNumMin"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | reverbType: {reverbType} | AreaNo: {AreaNo} | IndoorOutdoor: {IndoorOutdoor} | useDistNoA: {useDistNoA} | useDistNoB: {useDistNoB} | DistMinA: {DistMinA} | DistMaxA: {DistMaxA} | DistMinB: {DistMinB} | DistMaxB: {DistMaxB} | NoHitNumMin: {NoHitNumMin}";
	}
}
