using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class FinalDamageRateParam
	{
		private readonly PARAM _param;
		public FinalDamageRateParam(PARAM param) => _param = param;
		public IEnumerable<FinalDamageRateParamRow> Entries => _param.Rows.Select(r => new FinalDamageRateParamRow(r));
	}
	public class FinalDamageRateParamRow
	{
		private readonly PARAM.Row _row;
		public FinalDamageRateParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float physRate => (float)_row["physRate"].Value;
		public float magRate => (float)_row["magRate"].Value;
		public float fireRate => (float)_row["fireRate"].Value;
		public float thunRate => (float)_row["thunRate"].Value;
		public float darkRate => (float)_row["darkRate"].Value;
		public float staminaRate => (float)_row["staminaRate"].Value;
		public float saRate => (float)_row["saRate"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | physRate: {physRate} | magRate: {magRate} | fireRate: {fireRate} | thunRate: {thunRate} | darkRate: {darkRate} | staminaRate: {staminaRate} | saRate: {saRate}";
	}
}
