using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class MenuOffscrRendParam
	{
		private readonly PARAM _param;
		public MenuOffscrRendParam(PARAM param) => _param = param;
		public IEnumerable<MenuOffscrRendParamRow> Entries => _param.Rows.Select(r => new MenuOffscrRendParamRow(r));
	}
	public class MenuOffscrRendParamRow
	{
		private readonly PARAM.Row _row;
		public MenuOffscrRendParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float camAtPosX => (float)_row["camAtPosX"].Value;
		public float camAtPosY => (float)_row["camAtPosY"].Value;
		public float camAtPosZ => (float)_row["camAtPosZ"].Value;
		public float camDist => (float)_row["camDist"].Value;
		public float camRotX => (float)_row["camRotX"].Value;
		public float camRotY => (float)_row["camRotY"].Value;
		public float camFov => (float)_row["camFov"].Value;
		public float camDistMin => (float)_row["camDistMin"].Value;
		public float camDistMax => (float)_row["camDistMax"].Value;
		public float camRotXMin => (float)_row["camRotXMin"].Value;
		public float camRotXMax => (float)_row["camRotXMax"].Value;
		public uint GparamID => (uint)_row["GparamID"].Value;
		public uint envTexId => (uint)_row["envTexId"].Value;
		public uint Grapm_ID_forPS4 => (uint)_row["Grapm_ID_forPS4"].Value;
		public uint Grapm_ID_forXB1 => (uint)_row["Grapm_ID_forXB1"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | camAtPosX: {camAtPosX} | camAtPosY: {camAtPosY} | camAtPosZ: {camAtPosZ} | camDist: {camDist} | camRotX: {camRotX} | camRotY: {camRotY} | camFov: {camFov} | camDistMin: {camDistMin} | camDistMax: {camDistMax} | camRotXMin: {camRotXMin} | camRotXMax: {camRotXMax} | GparamID: {GparamID} | envTexId: {envTexId} | Grapm_ID_forPS4: {Grapm_ID_forPS4} | Grapm_ID_forXB1: {Grapm_ID_forXB1}";
	}
}
