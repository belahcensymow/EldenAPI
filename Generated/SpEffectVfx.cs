using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class SpEffectVfx
	{
		private readonly PARAM _param;
		public SpEffectVfx(PARAM param) => _param = param;
		public IEnumerable<SpEffectVfxRow> Entries => _param.Rows.Select(r => new SpEffectVfxRow(r));
	}
	public class SpEffectVfxRow
	{
		private readonly PARAM.Row _row;
		public SpEffectVfxRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public int midstSfxId => (int)_row["midstSfxId"].Value;
		public int midstSeId => (int)_row["midstSeId"].Value;
		public int initSfxId => (int)_row["initSfxId"].Value;
		public int initSeId => (int)_row["initSeId"].Value;
		public int finishSfxId => (int)_row["finishSfxId"].Value;
		public int finishSeId => (int)_row["finishSeId"].Value;
		public float camouflageBeginDist => (float)_row["camouflageBeginDist"].Value;
		public float camouflageEndDist => (float)_row["camouflageEndDist"].Value;
		public int transformProtectorId => (int)_row["transformProtectorId"].Value;
		public short midstDmyId => (short)_row["midstDmyId"].Value;
		public short initDmyId => (short)_row["initDmyId"].Value;
		public short finishDmyId => (short)_row["finishDmyId"].Value;
		public byte[] effectType => (byte[])_row["effectType"].Value;
		public byte[] soulParamIdForWepEnchant => (byte[])_row["soulParamIdForWepEnchant"].Value;
		public byte[] playCategory => (byte[])_row["playCategory"].Value;
		public byte playPriority => (byte)_row["playPriority"].Value;
		public byte[] existEffectForLarge => (byte[])_row["existEffectForLarge"].Value;
		public byte[] existEffectForSoul => (byte[])_row["existEffectForSoul"].Value;
		public byte[] effectInvisibleAtCamouflage => (byte[])_row["effectInvisibleAtCamouflage"].Value;
		public byte[] useCamouflage => (byte[])_row["useCamouflage"].Value;
		public byte[] invisibleAtFriendCamouflage => (byte[])_row["invisibleAtFriendCamouflage"].Value;
		public byte[] isHideFootEffect_forCamouflage => (byte[])_row["isHideFootEffect_forCamouflage"].Value;
		public byte[] halfCamouflage => (byte[])_row["halfCamouflage"].Value;
		public byte[] isFullBodyTransformProtectorId => (byte[])_row["isFullBodyTransformProtectorId"].Value;
		public byte[] isInvisibleWeapon => (byte[])_row["isInvisibleWeapon"].Value;
		public byte[] isSilence => (byte[])_row["isSilence"].Value;
		public byte[] isMidstFullbody => (byte[])_row["isMidstFullbody"].Value;
		public byte[] isInitFullbody => (byte[])_row["isInitFullbody"].Value;
		public byte[] isFinishFullbody => (byte[])_row["isFinishFullbody"].Value;
		public byte[] isVisibleDeadChr => (byte[])_row["isVisibleDeadChr"].Value;
		public byte[] isUseOffsetEnchantSfxSize => (byte[])_row["isUseOffsetEnchantSfxSize"].Value;
		public byte[] pad_1 => (byte[])_row["pad_1"].Value;
		public int decalId1 => (int)_row["decalId1"].Value;
		public int decalId2 => (int)_row["decalId2"].Value;
		public byte footEffectPriority => (byte)_row["footEffectPriority"].Value;
		public byte footEffectOffset => (byte)_row["footEffectOffset"].Value;
		public byte[] traceSfxIdOffsetType => (byte[])_row["traceSfxIdOffsetType"].Value;
		public byte[] forceDeceasedType => (byte[])_row["forceDeceasedType"].Value;
		public int enchantStartDmyId_0 => (int)_row["enchantStartDmyId_0"].Value;
		public int enchantEndDmyId_0 => (int)_row["enchantEndDmyId_0"].Value;
		public int enchantStartDmyId_1 => (int)_row["enchantStartDmyId_1"].Value;
		public int enchantEndDmyId_1 => (int)_row["enchantEndDmyId_1"].Value;
		public int enchantStartDmyId_2 => (int)_row["enchantStartDmyId_2"].Value;
		public int enchantEndDmyId_2 => (int)_row["enchantEndDmyId_2"].Value;
		public int enchantStartDmyId_3 => (int)_row["enchantStartDmyId_3"].Value;
		public int enchantEndDmyId_3 => (int)_row["enchantEndDmyId_3"].Value;
		public int enchantStartDmyId_4 => (int)_row["enchantStartDmyId_4"].Value;
		public int enchantEndDmyId_4 => (int)_row["enchantEndDmyId_4"].Value;
		public int enchantStartDmyId_5 => (int)_row["enchantStartDmyId_5"].Value;
		public int enchantEndDmyId_5 => (int)_row["enchantEndDmyId_5"].Value;
		public int enchantStartDmyId_6 => (int)_row["enchantStartDmyId_6"].Value;
		public int enchantEndDmyId_6 => (int)_row["enchantEndDmyId_6"].Value;
		public int enchantStartDmyId_7 => (int)_row["enchantStartDmyId_7"].Value;
		public int enchantEndDmyId_7 => (int)_row["enchantEndDmyId_7"].Value;
		public byte[] SfxIdOffsetType => (byte[])_row["SfxIdOffsetType"].Value;
		public byte[] phantomParamOverwriteType => (byte[])_row["phantomParamOverwriteType"].Value;
		public byte camouflageMinAlpha => (byte)_row["camouflageMinAlpha"].Value;
		public byte[] wetAspectType => (byte[])_row["wetAspectType"].Value;
		public int phantomParamOverwriteId => (int)_row["phantomParamOverwriteId"].Value;
		public int materialParamId => (int)_row["materialParamId"].Value;
		public float materialParamInitValue => (float)_row["materialParamInitValue"].Value;
		public float materialParamTargetValue => (float)_row["materialParamTargetValue"].Value;
		public float materialParamFadeTime => (float)_row["materialParamFadeTime"].Value;
		public short footDecalMaterialOffsetOverwriteId => (short)_row["footDecalMaterialOffsetOverwriteId"].Value;
		public byte[] pad => (byte[])_row["pad"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | midstSfxId: {midstSfxId} | midstSeId: {midstSeId} | initSfxId: {initSfxId} | initSeId: {initSeId} | finishSfxId: {finishSfxId} | finishSeId: {finishSeId} | camouflageBeginDist: {camouflageBeginDist} | camouflageEndDist: {camouflageEndDist} | transformProtectorId: {transformProtectorId} | midstDmyId: {midstDmyId} | initDmyId: {initDmyId} | finishDmyId: {finishDmyId} | playPriority: {playPriority} | decalId1: {decalId1} | decalId2: {decalId2} | footEffectPriority: {footEffectPriority} | footEffectOffset: {footEffectOffset} | enchantStartDmyId_0: {enchantStartDmyId_0} | enchantEndDmyId_0: {enchantEndDmyId_0} | enchantStartDmyId_1: {enchantStartDmyId_1} | enchantEndDmyId_1: {enchantEndDmyId_1} | enchantStartDmyId_2: {enchantStartDmyId_2} | enchantEndDmyId_2: {enchantEndDmyId_2} | enchantStartDmyId_3: {enchantStartDmyId_3} | enchantEndDmyId_3: {enchantEndDmyId_3} | enchantStartDmyId_4: {enchantStartDmyId_4} | enchantEndDmyId_4: {enchantEndDmyId_4} | enchantStartDmyId_5: {enchantStartDmyId_5} | enchantEndDmyId_5: {enchantEndDmyId_5} | enchantStartDmyId_6: {enchantStartDmyId_6} | enchantEndDmyId_6: {enchantEndDmyId_6} | enchantStartDmyId_7: {enchantStartDmyId_7} | enchantEndDmyId_7: {enchantEndDmyId_7} | camouflageMinAlpha: {camouflageMinAlpha} | phantomParamOverwriteId: {phantomParamOverwriteId} | materialParamId: {materialParamId} | materialParamInitValue: {materialParamInitValue} | materialParamTargetValue: {materialParamTargetValue} | materialParamFadeTime: {materialParamFadeTime} | footDecalMaterialOffsetOverwriteId: {footDecalMaterialOffsetOverwriteId}";
	}
}
