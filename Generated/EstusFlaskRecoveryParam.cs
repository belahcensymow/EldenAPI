using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class EstusFlaskRecoveryParam
	{
		private readonly PARAM _param;
		public EstusFlaskRecoveryParam(PARAM param) => _param = param;
		public IEnumerable<EstusFlaskRecoveryParamRow> Entries => _param.Rows.Select(r => new EstusFlaskRecoveryParamRow(r));
	}
	public class EstusFlaskRecoveryParamRow
	{
		private readonly PARAM.Row _row;
		public EstusFlaskRecoveryParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte host => (byte)_row["host"].Value;
		public byte invadeOrb_None => (byte)_row["invadeOrb_None"].Value;
		public byte invadeOrb_Umbasa => (byte)_row["invadeOrb_Umbasa"].Value;
		public byte invadeOrb_Berserker => (byte)_row["invadeOrb_Berserker"].Value;
		public byte invadeOrb_Sinners => (byte)_row["invadeOrb_Sinners"].Value;
		public byte invadeSign_None => (byte)_row["invadeSign_None"].Value;
		public byte invadeSign_Umbasa => (byte)_row["invadeSign_Umbasa"].Value;
		public byte invadeSign_Berserker => (byte)_row["invadeSign_Berserker"].Value;
		public byte invadeSign_Sinners => (byte)_row["invadeSign_Sinners"].Value;
		public byte invadeRing_Sinners => (byte)_row["invadeRing_Sinners"].Value;
		public byte invadeRing_Rosalia => (byte)_row["invadeRing_Rosalia"].Value;
		public byte invadeRing_Forest => (byte)_row["invadeRing_Forest"].Value;
		public byte coopSign_None => (byte)_row["coopSign_None"].Value;
		public byte coopSign_Umbasa => (byte)_row["coopSign_Umbasa"].Value;
		public byte coopSign_Berserker => (byte)_row["coopSign_Berserker"].Value;
		public byte coopSign_Sinners => (byte)_row["coopSign_Sinners"].Value;
		public byte coopRing_RedHunter => (byte)_row["coopRing_RedHunter"].Value;
		public byte invadeRing_Anor => (byte)_row["invadeRing_Anor"].Value;
		public ushort paramReplaceRate => (ushort)_row["paramReplaceRate"].Value;
		public int paramReplaceId => (int)_row["paramReplaceId"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | host: {host} | invadeOrb_None: {invadeOrb_None} | invadeOrb_Umbasa: {invadeOrb_Umbasa} | invadeOrb_Berserker: {invadeOrb_Berserker} | invadeOrb_Sinners: {invadeOrb_Sinners} | invadeSign_None: {invadeSign_None} | invadeSign_Umbasa: {invadeSign_Umbasa} | invadeSign_Berserker: {invadeSign_Berserker} | invadeSign_Sinners: {invadeSign_Sinners} | invadeRing_Sinners: {invadeRing_Sinners} | invadeRing_Rosalia: {invadeRing_Rosalia} | invadeRing_Forest: {invadeRing_Forest} | coopSign_None: {coopSign_None} | coopSign_Umbasa: {coopSign_Umbasa} | coopSign_Berserker: {coopSign_Berserker} | coopSign_Sinners: {coopSign_Sinners} | coopRing_RedHunter: {coopRing_RedHunter} | invadeRing_Anor: {invadeRing_Anor} | paramReplaceRate: {paramReplaceRate} | paramReplaceId: {paramReplaceId}";
	}
}
