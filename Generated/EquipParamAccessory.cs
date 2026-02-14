using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class EquipParamAccessory
	{
		private readonly PARAM _param;
		public EquipParamAccessory(PARAM param) => _param = param;
		public IEnumerable<EquipParamAccessoryRow> Entries => _param.Rows.Select(r => new EquipParamAccessoryRow(r));
	}
	public class EquipParamAccessoryRow
	{
		private readonly PARAM.Row _row;
		public EquipParamAccessoryRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] disableParam_NT => (byte[])_row["disableParam_NT"].Value;
		public byte[] disableParamReserve1 => (byte[])_row["disableParamReserve1"].Value;
		public byte[] disableParamReserve2 => (byte[])_row["disableParamReserve2"].Value;
		public int refId => (int)_row["refId"].Value;
		public int sfxVariationId => (int)_row["sfxVariationId"].Value;
		public float weight => (float)_row["weight"].Value;
		public int behaviorId => (int)_row["behaviorId"].Value;
		public int basicPrice => (int)_row["basicPrice"].Value;
		public int sellValue => (int)_row["sellValue"].Value;
		public int sortId => (int)_row["sortId"].Value;
		public int qwcId => (int)_row["qwcId"].Value;
		public ushort equipModelId => (ushort)_row["equipModelId"].Value;
		public ushort iconId => (ushort)_row["iconId"].Value;
		public short shopLv => (short)_row["shopLv"].Value;
		public short trophySGradeId => (short)_row["trophySGradeId"].Value;
		public short trophySeqId => (short)_row["trophySeqId"].Value;
		public byte[] equipModelCategory => (byte[])_row["equipModelCategory"].Value;
		public byte[] equipModelGender => (byte[])_row["equipModelGender"].Value;
		public byte[] accessoryCategory => (byte[])_row["accessoryCategory"].Value;
		public byte[] refCategory => (byte[])_row["refCategory"].Value;
		public byte[] spEffectCategory => (byte[])_row["spEffectCategory"].Value;
		public byte sortGroupId => (byte)_row["sortGroupId"].Value;
		public int vagrantItemLotId => (int)_row["vagrantItemLotId"].Value;
		public int vagrantBonusEneDropItemLotId => (int)_row["vagrantBonusEneDropItemLotId"].Value;
		public int vagrantItemEneDropItemLotId => (int)_row["vagrantItemEneDropItemLotId"].Value;
		public byte[] isDeposit => (byte[])_row["isDeposit"].Value;
		public byte[] isEquipOutBrake => (byte[])_row["isEquipOutBrake"].Value;
		public byte[] disableMultiDropShare => (byte[])_row["disableMultiDropShare"].Value;
		public byte[] isDiscard => (byte[])_row["isDiscard"].Value;
		public byte[] isDrop => (byte[])_row["isDrop"].Value;
		public byte[] showLogCondType => (byte[])_row["showLogCondType"].Value;
		public byte[] showDialogCondType => (byte[])_row["showDialogCondType"].Value;
		public byte rarity => (byte)_row["rarity"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public int saleValue => (int)_row["saleValue"].Value;
		public short accessoryGroup => (short)_row["accessoryGroup"].Value;
		public byte[] pad3 => (byte[])_row["pad3"].Value;
		public sbyte compTrophySedId => (sbyte)_row["compTrophySedId"].Value;
		public int residentSpEffectId1 => (int)_row["residentSpEffectId1"].Value;
		public int residentSpEffectId2 => (int)_row["residentSpEffectId2"].Value;
		public int residentSpEffectId3 => (int)_row["residentSpEffectId3"].Value;
		public int residentSpEffectId4 => (int)_row["residentSpEffectId4"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | refId: {refId} | sfxVariationId: {sfxVariationId} | weight: {weight} | behaviorId: {behaviorId} | basicPrice: {basicPrice} | sellValue: {sellValue} | sortId: {sortId} | qwcId: {qwcId} | equipModelId: {equipModelId} | iconId: {iconId} | shopLv: {shopLv} | trophySGradeId: {trophySGradeId} | trophySeqId: {trophySeqId} | sortGroupId: {sortGroupId} | vagrantItemLotId: {vagrantItemLotId} | vagrantBonusEneDropItemLotId: {vagrantBonusEneDropItemLotId} | vagrantItemEneDropItemLotId: {vagrantItemEneDropItemLotId} | rarity: {rarity} | saleValue: {saleValue} | accessoryGroup: {accessoryGroup} | compTrophySedId: {compTrophySedId} | residentSpEffectId1: {residentSpEffectId1} | residentSpEffectId2: {residentSpEffectId2} | residentSpEffectId3: {residentSpEffectId3} | residentSpEffectId4: {residentSpEffectId4}";
	}
}
