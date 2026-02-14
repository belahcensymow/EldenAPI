using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class CeremonyParam
	{
		private readonly PARAM _param;
		public CeremonyParam(PARAM param) => _param = param;
		public IEnumerable<CeremonyParamRow> Entries => _param.Rows.Select(r => new CeremonyParamRow(r));
	}
	public class CeremonyParamRow
	{
		private readonly PARAM.Row _row;
		public CeremonyParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int eventLayerId => (int)_row["eventLayerId"].Value;
		public int mapStudioLayerId => (int)_row["mapStudioLayerId"].Value;
		public int multiPlayAreaOffset => (int)_row["multiPlayAreaOffset"].Value;
		public int overrideMapPlaceNameId => (int)_row["overrideMapPlaceNameId"].Value;
		public int overrideSaveMapNameId => (int)_row["overrideSaveMapNameId"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | eventLayerId: {eventLayerId} | mapStudioLayerId: {mapStudioLayerId} | multiPlayAreaOffset: {multiPlayAreaOffset} | overrideMapPlaceNameId: {overrideMapPlaceNameId} | overrideSaveMapNameId: {overrideSaveMapNameId}";
	}
}
