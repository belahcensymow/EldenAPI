using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class LoadBalancerDrawDistScaleParam
	{
		private readonly PARAM _param;
		public LoadBalancerDrawDistScaleParam(PARAM param) => _param = param;
		public IEnumerable<LoadBalancerDrawDistScaleParamRow> Entries => _param.Rows.Select(r => new LoadBalancerDrawDistScaleParamRow(r));
	}
	public class LoadBalancerDrawDistScaleParamRow
	{
		private readonly PARAM.Row _row;
		public LoadBalancerDrawDistScaleParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float Lv00 => (float)_row["Lv00"].Value;
		public float Lv01 => (float)_row["Lv01"].Value;
		public float Lv02 => (float)_row["Lv02"].Value;
		public float Lv03 => (float)_row["Lv03"].Value;
		public float Lv04 => (float)_row["Lv04"].Value;
		public float Lv05 => (float)_row["Lv05"].Value;
		public float Lv06 => (float)_row["Lv06"].Value;
		public float Lv07 => (float)_row["Lv07"].Value;
		public float Lv08 => (float)_row["Lv08"].Value;
		public float Lv09 => (float)_row["Lv09"].Value;
		public float Lv10 => (float)_row["Lv10"].Value;
		public float Lv11 => (float)_row["Lv11"].Value;
		public float Lv12 => (float)_row["Lv12"].Value;
		public float Lv13 => (float)_row["Lv13"].Value;
		public float Lv14 => (float)_row["Lv14"].Value;
		public float Lv15 => (float)_row["Lv15"].Value;
		public float Lv16 => (float)_row["Lv16"].Value;
		public float Lv17 => (float)_row["Lv17"].Value;
		public float Lv18 => (float)_row["Lv18"].Value;
		public float Lv19 => (float)_row["Lv19"].Value;
		public float Lv20 => (float)_row["Lv20"].Value;
		public byte[] reserve => (byte[])_row["reserve"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | Lv00: {Lv00} | Lv01: {Lv01} | Lv02: {Lv02} | Lv03: {Lv03} | Lv04: {Lv04} | Lv05: {Lv05} | Lv06: {Lv06} | Lv07: {Lv07} | Lv08: {Lv08} | Lv09: {Lv09} | Lv10: {Lv10} | Lv11: {Lv11} | Lv12: {Lv12} | Lv13: {Lv13} | Lv14: {Lv14} | Lv15: {Lv15} | Lv16: {Lv16} | Lv17: {Lv17} | Lv18: {Lv18} | Lv19: {Lv19} | Lv20: {Lv20}";
	}
}
