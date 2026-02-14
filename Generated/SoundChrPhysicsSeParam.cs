using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class SoundChrPhysicsSeParam
	{
		private readonly PARAM _param;
		public SoundChrPhysicsSeParam(PARAM param) => _param = param;
		public IEnumerable<SoundChrPhysicsSeParamRow> Entries => _param.Rows.Select(r => new SoundChrPhysicsSeParamRow(r));
	}
	public class SoundChrPhysicsSeParamRow
	{
		private readonly PARAM.Row _row;
		public SoundChrPhysicsSeParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] disableParam_NT => (byte[])_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public int ContactLandSeId => (int)_row["ContactLandSeId"].Value;
		public int ContactLandAddSeId => (int)_row["ContactLandAddSeId"].Value;
		public int ContactLandPlayNum => (int)_row["ContactLandPlayNum"].Value;
		public byte[] IsEnablePlayCountPerRigid => (byte[])_row["IsEnablePlayCountPerRigid"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public float ContactLandMinImpuse => (float)_row["ContactLandMinImpuse"].Value;
		public float ContactLandMinSpeed => (float)_row["ContactLandMinSpeed"].Value;
		public int ContactPlayerSeId => (int)_row["ContactPlayerSeId"].Value;
		public float ContactPlayerMinImpuse => (float)_row["ContactPlayerMinImpuse"].Value;
		public float ContactPlayerMinSpeed => (float)_row["ContactPlayerMinSpeed"].Value;
		public sbyte ContactCheckRigidIdx0 => (sbyte)_row["ContactCheckRigidIdx0"].Value;
		public sbyte ContactCheckRigidIdx1 => (sbyte)_row["ContactCheckRigidIdx1"].Value;
		public sbyte ContactCheckRigidIdx2 => (sbyte)_row["ContactCheckRigidIdx2"].Value;
		public sbyte ContactCheckRigidIdx3 => (sbyte)_row["ContactCheckRigidIdx3"].Value;
		public sbyte ContactCheckRigidIdx4 => (sbyte)_row["ContactCheckRigidIdx4"].Value;
		public sbyte ContactCheckRigidIdx5 => (sbyte)_row["ContactCheckRigidIdx5"].Value;
		public sbyte ContactCheckRigidIdx6 => (sbyte)_row["ContactCheckRigidIdx6"].Value;
		public sbyte ContactCheckRigidIdx7 => (sbyte)_row["ContactCheckRigidIdx7"].Value;
		public sbyte ContactCheckRigidIdx8 => (sbyte)_row["ContactCheckRigidIdx8"].Value;
		public sbyte ContactCheckRigidIdx9 => (sbyte)_row["ContactCheckRigidIdx9"].Value;
		public sbyte ContactCheckRigidIdx10 => (sbyte)_row["ContactCheckRigidIdx10"].Value;
		public sbyte ContactCheckRigidIdx11 => (sbyte)_row["ContactCheckRigidIdx11"].Value;
		public sbyte ContactCheckRigidIdx12 => (sbyte)_row["ContactCheckRigidIdx12"].Value;
		public sbyte ContactCheckRigidIdx13 => (sbyte)_row["ContactCheckRigidIdx13"].Value;
		public sbyte ContactCheckRigidIdx14 => (sbyte)_row["ContactCheckRigidIdx14"].Value;
		public sbyte ContactCheckRigidIdx15 => (sbyte)_row["ContactCheckRigidIdx15"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | ContactLandSeId: {ContactLandSeId} | ContactLandAddSeId: {ContactLandAddSeId} | ContactLandPlayNum: {ContactLandPlayNum} | ContactLandMinImpuse: {ContactLandMinImpuse} | ContactLandMinSpeed: {ContactLandMinSpeed} | ContactPlayerSeId: {ContactPlayerSeId} | ContactPlayerMinImpuse: {ContactPlayerMinImpuse} | ContactPlayerMinSpeed: {ContactPlayerMinSpeed} | ContactCheckRigidIdx0: {ContactCheckRigidIdx0} | ContactCheckRigidIdx1: {ContactCheckRigidIdx1} | ContactCheckRigidIdx2: {ContactCheckRigidIdx2} | ContactCheckRigidIdx3: {ContactCheckRigidIdx3} | ContactCheckRigidIdx4: {ContactCheckRigidIdx4} | ContactCheckRigidIdx5: {ContactCheckRigidIdx5} | ContactCheckRigidIdx6: {ContactCheckRigidIdx6} | ContactCheckRigidIdx7: {ContactCheckRigidIdx7} | ContactCheckRigidIdx8: {ContactCheckRigidIdx8} | ContactCheckRigidIdx9: {ContactCheckRigidIdx9} | ContactCheckRigidIdx10: {ContactCheckRigidIdx10} | ContactCheckRigidIdx11: {ContactCheckRigidIdx11} | ContactCheckRigidIdx12: {ContactCheckRigidIdx12} | ContactCheckRigidIdx13: {ContactCheckRigidIdx13} | ContactCheckRigidIdx14: {ContactCheckRigidIdx14} | ContactCheckRigidIdx15: {ContactCheckRigidIdx15}";
	}
}
