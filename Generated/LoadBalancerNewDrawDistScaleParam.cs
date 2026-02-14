using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class LoadBalancerNewDrawDistScaleParam
	{
		private readonly PARAM _param;
		public LoadBalancerNewDrawDistScaleParam(PARAM param) => _param = param;
		public IEnumerable<LoadBalancerNewDrawDistScaleParamRow> Entries => _param.Rows.Select(r => new LoadBalancerNewDrawDistScaleParamRow(r));
	}
	public class LoadBalancerNewDrawDistScaleParamRow
	{
		private readonly PARAM.Row _row;
		public LoadBalancerNewDrawDistScaleParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte DrawDist_LvBegin => (byte)_row["DrawDist_LvBegin"].Value;
		public byte DrawDist_LvEnd => (byte)_row["DrawDist_LvEnd"].Value;
		public byte[] reserve0 => (byte[])_row["reserve0"].Value;
		public float DrawDist_ScaleBegin => (float)_row["DrawDist_ScaleBegin"].Value;
		public float DrawDist_ScaleEnd => (float)_row["DrawDist_ScaleEnd"].Value;
		public byte ShadwDrawDist_LvBegin => (byte)_row["ShadwDrawDist_LvBegin"].Value;
		public byte ShadwDrawDist_LvEnd => (byte)_row["ShadwDrawDist_LvEnd"].Value;
		public byte[] reserve1 => (byte[])_row["reserve1"].Value;
		public float ShadwDrawDist_ScaleBegin => (float)_row["ShadwDrawDist_ScaleBegin"].Value;
		public float ShadwDrawDist_ScaleEnd => (float)_row["ShadwDrawDist_ScaleEnd"].Value;
		public byte[] reserve2 => (byte[])_row["reserve2"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | DrawDist_LvBegin: {DrawDist_LvBegin} | DrawDist_LvEnd: {DrawDist_LvEnd} | DrawDist_ScaleBegin: {DrawDist_ScaleBegin} | DrawDist_ScaleEnd: {DrawDist_ScaleEnd} | ShadwDrawDist_LvBegin: {ShadwDrawDist_LvBegin} | ShadwDrawDist_LvEnd: {ShadwDrawDist_LvEnd} | ShadwDrawDist_ScaleBegin: {ShadwDrawDist_ScaleBegin} | ShadwDrawDist_ScaleEnd: {ShadwDrawDist_ScaleEnd}";
	}
}
