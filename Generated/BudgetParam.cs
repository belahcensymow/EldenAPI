using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class BudgetParam
	{
		private readonly PARAM _param;
		public BudgetParam(PARAM param) => _param = param;
		public IEnumerable<BudgetParamRow> Entries => _param.Rows.Select(r => new BudgetParamRow(r));
	}
	public class BudgetParamRow
	{
		private readonly PARAM.Row _row;
		public BudgetParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public float vram_all => (float)_row["vram_all"].Value;
		public float vram_mapobj_tex => (float)_row["vram_mapobj_tex"].Value;
		public float vram_mapobj_mdl => (float)_row["vram_mapobj_mdl"].Value;
		public float vram_map => (float)_row["vram_map"].Value;
		public float vram_chr => (float)_row["vram_chr"].Value;
		public float vram_parts => (float)_row["vram_parts"].Value;
		public float vram_sfx => (float)_row["vram_sfx"].Value;
		public float vram_chr_tex => (float)_row["vram_chr_tex"].Value;
		public float vram_chr_mdl => (float)_row["vram_chr_mdl"].Value;
		public float vram_parts_tex => (float)_row["vram_parts_tex"].Value;
		public float vram_parts_mdl => (float)_row["vram_parts_mdl"].Value;
		public float vram_sfx_tex => (float)_row["vram_sfx_tex"].Value;
		public float vram_sfx_mdl => (float)_row["vram_sfx_mdl"].Value;
		public float vram_gi => (float)_row["vram_gi"].Value;
		public float vram_menu_tex => (float)_row["vram_menu_tex"].Value;
		public float vram_decal_rt => (float)_row["vram_decal_rt"].Value;
		public float vram_decal => (float)_row["vram_decal"].Value;
		public byte[] reserve_0 => (byte[])_row["reserve_0"].Value;
		public float vram_other_tex => (float)_row["vram_other_tex"].Value;
		public float vram_other_mdl => (float)_row["vram_other_mdl"].Value;
		public float havok_anim => (float)_row["havok_anim"].Value;
		public float havok_ins => (float)_row["havok_ins"].Value;
		public float havok_hit => (float)_row["havok_hit"].Value;
		public float vram_other => (float)_row["vram_other"].Value;
		public float vram_detail_all => (float)_row["vram_detail_all"].Value;
		public float vram_chr_and_parts => (float)_row["vram_chr_and_parts"].Value;
		public float havok_navimesh => (float)_row["havok_navimesh"].Value;
		public byte[] reserve_1 => (byte[])_row["reserve_1"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | vram_all: {vram_all} | vram_mapobj_tex: {vram_mapobj_tex} | vram_mapobj_mdl: {vram_mapobj_mdl} | vram_map: {vram_map} | vram_chr: {vram_chr} | vram_parts: {vram_parts} | vram_sfx: {vram_sfx} | vram_chr_tex: {vram_chr_tex} | vram_chr_mdl: {vram_chr_mdl} | vram_parts_tex: {vram_parts_tex} | vram_parts_mdl: {vram_parts_mdl} | vram_sfx_tex: {vram_sfx_tex} | vram_sfx_mdl: {vram_sfx_mdl} | vram_gi: {vram_gi} | vram_menu_tex: {vram_menu_tex} | vram_decal_rt: {vram_decal_rt} | vram_decal: {vram_decal} | vram_other_tex: {vram_other_tex} | vram_other_mdl: {vram_other_mdl} | havok_anim: {havok_anim} | havok_ins: {havok_ins} | havok_hit: {havok_hit} | vram_other: {vram_other} | vram_detail_all: {vram_detail_all} | vram_chr_and_parts: {vram_chr_and_parts} | havok_navimesh: {havok_navimesh}";
	}
}
