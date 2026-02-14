using System.Collections.Generic;
using System.Linq;
using SoulsFormats;

namespace EldenRingDataExtractor
{
	public class AttackElementCorrectParam
	{
		private readonly PARAM _param;
		public AttackElementCorrectParam(PARAM param) => _param = param;
		public IEnumerable<AttackElementCorrectParamRow> Entries => _param.Rows.Select(r => new AttackElementCorrectParamRow(r));
	}
	public class AttackElementCorrectParamRow
	{
		private readonly PARAM.Row _row;
		public AttackElementCorrectParamRow(PARAM.Row row) => _row = row;
		public int ID => _row.ID;
		public string Name => _row.Name;
		public byte[] isStrengthCorrect_byPhysics => (byte[])_row["isStrengthCorrect_byPhysics"].Value;
		public byte[] isDexterityCorrect_byPhysics => (byte[])_row["isDexterityCorrect_byPhysics"].Value;
		public byte[] isMagicCorrect_byPhysics => (byte[])_row["isMagicCorrect_byPhysics"].Value;
		public byte[] isFaithCorrect_byPhysics => (byte[])_row["isFaithCorrect_byPhysics"].Value;
		public byte[] isLuckCorrect_byPhysics => (byte[])_row["isLuckCorrect_byPhysics"].Value;
		public byte[] isStrengthCorrect_byMagic => (byte[])_row["isStrengthCorrect_byMagic"].Value;
		public byte[] isDexterityCorrect_byMagic => (byte[])_row["isDexterityCorrect_byMagic"].Value;
		public byte[] isMagicCorrect_byMagic => (byte[])_row["isMagicCorrect_byMagic"].Value;
		public byte[] isFaithCorrect_byMagic => (byte[])_row["isFaithCorrect_byMagic"].Value;
		public byte[] isLuckCorrect_byMagic => (byte[])_row["isLuckCorrect_byMagic"].Value;
		public byte[] isStrengthCorrect_byFire => (byte[])_row["isStrengthCorrect_byFire"].Value;
		public byte[] isDexterityCorrect_byFire => (byte[])_row["isDexterityCorrect_byFire"].Value;
		public byte[] isMagicCorrect_byFire => (byte[])_row["isMagicCorrect_byFire"].Value;
		public byte[] isFaithCorrect_byFire => (byte[])_row["isFaithCorrect_byFire"].Value;
		public byte[] isLuckCorrect_byFire => (byte[])_row["isLuckCorrect_byFire"].Value;
		public byte[] isStrengthCorrect_byThunder => (byte[])_row["isStrengthCorrect_byThunder"].Value;
		public byte[] isDexterityCorrect_byThunder => (byte[])_row["isDexterityCorrect_byThunder"].Value;
		public byte[] isMagicCorrect_byThunder => (byte[])_row["isMagicCorrect_byThunder"].Value;
		public byte[] isFaithCorrect_byThunder => (byte[])_row["isFaithCorrect_byThunder"].Value;
		public byte[] isLuckCorrect_byThunder => (byte[])_row["isLuckCorrect_byThunder"].Value;
		public byte[] isStrengthCorrect_byDark => (byte[])_row["isStrengthCorrect_byDark"].Value;
		public byte[] isDexterityCorrect_byDark => (byte[])_row["isDexterityCorrect_byDark"].Value;
		public byte[] isMagicCorrect_byDark => (byte[])_row["isMagicCorrect_byDark"].Value;
		public byte[] isFaithCorrect_byDark => (byte[])_row["isFaithCorrect_byDark"].Value;
		public byte[] isLuckCorrect_byDark => (byte[])_row["isLuckCorrect_byDark"].Value;
		public byte[] pad1 => (byte[])_row["pad1"].Value;
		public short overwriteStrengthCorrectRate_byPhysics => (short)_row["overwriteStrengthCorrectRate_byPhysics"].Value;
		public short overwriteDexterityCorrectRate_byPhysics => (short)_row["overwriteDexterityCorrectRate_byPhysics"].Value;
		public short overwriteMagicCorrectRate_byPhysics => (short)_row["overwriteMagicCorrectRate_byPhysics"].Value;
		public short overwriteFaithCorrectRate_byPhysics => (short)_row["overwriteFaithCorrectRate_byPhysics"].Value;
		public short overwriteLuckCorrectRate_byPhysics => (short)_row["overwriteLuckCorrectRate_byPhysics"].Value;
		public short overwriteStrengthCorrectRate_byMagic => (short)_row["overwriteStrengthCorrectRate_byMagic"].Value;
		public short overwriteDexterityCorrectRate_byMagic => (short)_row["overwriteDexterityCorrectRate_byMagic"].Value;
		public short overwriteMagicCorrectRate_byMagic => (short)_row["overwriteMagicCorrectRate_byMagic"].Value;
		public short overwriteFaithCorrectRate_byMagic => (short)_row["overwriteFaithCorrectRate_byMagic"].Value;
		public short overwriteLuckCorrectRate_byMagic => (short)_row["overwriteLuckCorrectRate_byMagic"].Value;
		public short overwriteStrengthCorrectRate_byFire => (short)_row["overwriteStrengthCorrectRate_byFire"].Value;
		public short overwriteDexterityCorrectRate_byFire => (short)_row["overwriteDexterityCorrectRate_byFire"].Value;
		public short overwriteMagicCorrectRate_byFire => (short)_row["overwriteMagicCorrectRate_byFire"].Value;
		public short overwriteFaithCorrectRate_byFire => (short)_row["overwriteFaithCorrectRate_byFire"].Value;
		public short overwriteLuckCorrectRate_byFire => (short)_row["overwriteLuckCorrectRate_byFire"].Value;
		public short overwriteStrengthCorrectRate_byThunder => (short)_row["overwriteStrengthCorrectRate_byThunder"].Value;
		public short overwriteDexterityCorrectRate_byThunder => (short)_row["overwriteDexterityCorrectRate_byThunder"].Value;
		public short overwriteMagicCorrectRate_byThunder => (short)_row["overwriteMagicCorrectRate_byThunder"].Value;
		public short overwriteFaithCorrectRate_byThunder => (short)_row["overwriteFaithCorrectRate_byThunder"].Value;
		public short overwriteLuckCorrectRate_byThunder => (short)_row["overwriteLuckCorrectRate_byThunder"].Value;
		public short overwriteStrengthCorrectRate_byDark => (short)_row["overwriteStrengthCorrectRate_byDark"].Value;
		public short overwriteDexterityCorrectRate_byDark => (short)_row["overwriteDexterityCorrectRate_byDark"].Value;
		public short overwriteMagicCorrectRate_byDark => (short)_row["overwriteMagicCorrectRate_byDark"].Value;
		public short overwriteFaithCorrectRate_byDark => (short)_row["overwriteFaithCorrectRate_byDark"].Value;
		public short overwriteLuckCorrectRate_byDark => (short)_row["overwriteLuckCorrectRate_byDark"].Value;
		public short InfluenceStrengthCorrectRate_byPhysics => (short)_row["InfluenceStrengthCorrectRate_byPhysics"].Value;
		public short InfluenceDexterityCorrectRate_byPhysics => (short)_row["InfluenceDexterityCorrectRate_byPhysics"].Value;
		public short InfluenceMagicCorrectRate_byPhysics => (short)_row["InfluenceMagicCorrectRate_byPhysics"].Value;
		public short InfluenceFaithCorrectRate_byPhysics => (short)_row["InfluenceFaithCorrectRate_byPhysics"].Value;
		public short InfluenceLuckCorrectRate_byPhysics => (short)_row["InfluenceLuckCorrectRate_byPhysics"].Value;
		public short InfluenceStrengthCorrectRate_byMagic => (short)_row["InfluenceStrengthCorrectRate_byMagic"].Value;
		public short InfluenceDexterityCorrectRate_byMagic => (short)_row["InfluenceDexterityCorrectRate_byMagic"].Value;
		public short InfluenceMagicCorrectRate_byMagic => (short)_row["InfluenceMagicCorrectRate_byMagic"].Value;
		public short InfluenceFaithCorrectRate_byMagic => (short)_row["InfluenceFaithCorrectRate_byMagic"].Value;
		public short InfluenceLuckCorrectRate_byMagic => (short)_row["InfluenceLuckCorrectRate_byMagic"].Value;
		public short InfluenceStrengthCorrectRate_byFire => (short)_row["InfluenceStrengthCorrectRate_byFire"].Value;
		public short InfluenceDexterityCorrectRate_byFire => (short)_row["InfluenceDexterityCorrectRate_byFire"].Value;
		public short InfluenceMagicCorrectRate_byFire => (short)_row["InfluenceMagicCorrectRate_byFire"].Value;
		public short InfluenceFaithCorrectRate_byFire => (short)_row["InfluenceFaithCorrectRate_byFire"].Value;
		public short InfluenceLuckCorrectRate_byFire => (short)_row["InfluenceLuckCorrectRate_byFire"].Value;
		public short InfluenceStrengthCorrectRate_byThunder => (short)_row["InfluenceStrengthCorrectRate_byThunder"].Value;
		public short InfluenceDexterityCorrectRate_byThunder => (short)_row["InfluenceDexterityCorrectRate_byThunder"].Value;
		public short InfluenceMagicCorrectRate_byThunder => (short)_row["InfluenceMagicCorrectRate_byThunder"].Value;
		public short InfluenceFaithCorrectRate_byThunder => (short)_row["InfluenceFaithCorrectRate_byThunder"].Value;
		public short InfluenceLuckCorrectRate_byThunder => (short)_row["InfluenceLuckCorrectRate_byThunder"].Value;
		public short InfluenceStrengthCorrectRate_byDark => (short)_row["InfluenceStrengthCorrectRate_byDark"].Value;
		public short InfluenceDexterityCorrectRate_byDark => (short)_row["InfluenceDexterityCorrectRate_byDark"].Value;
		public short InfluenceMagicCorrectRate_byDark => (short)_row["InfluenceMagicCorrectRate_byDark"].Value;
		public short InfluenceFaithCorrectRate_byDark => (short)_row["InfluenceFaithCorrectRate_byDark"].Value;
		public short InfluenceLuckCorrectRate_byDark => (short)_row["InfluenceLuckCorrectRate_byDark"].Value;
		public byte[] pad2 => (byte[])_row["pad2"].Value;
		public override string ToString() => $"ID: {ID} | Name: {Name} | overwriteStrengthCorrectRate_byPhysics: {overwriteStrengthCorrectRate_byPhysics} | overwriteDexterityCorrectRate_byPhysics: {overwriteDexterityCorrectRate_byPhysics} | overwriteMagicCorrectRate_byPhysics: {overwriteMagicCorrectRate_byPhysics} | overwriteFaithCorrectRate_byPhysics: {overwriteFaithCorrectRate_byPhysics} | overwriteLuckCorrectRate_byPhysics: {overwriteLuckCorrectRate_byPhysics} | overwriteStrengthCorrectRate_byMagic: {overwriteStrengthCorrectRate_byMagic} | overwriteDexterityCorrectRate_byMagic: {overwriteDexterityCorrectRate_byMagic} | overwriteMagicCorrectRate_byMagic: {overwriteMagicCorrectRate_byMagic} | overwriteFaithCorrectRate_byMagic: {overwriteFaithCorrectRate_byMagic} | overwriteLuckCorrectRate_byMagic: {overwriteLuckCorrectRate_byMagic} | overwriteStrengthCorrectRate_byFire: {overwriteStrengthCorrectRate_byFire} | overwriteDexterityCorrectRate_byFire: {overwriteDexterityCorrectRate_byFire} | overwriteMagicCorrectRate_byFire: {overwriteMagicCorrectRate_byFire} | overwriteFaithCorrectRate_byFire: {overwriteFaithCorrectRate_byFire} | overwriteLuckCorrectRate_byFire: {overwriteLuckCorrectRate_byFire} | overwriteStrengthCorrectRate_byThunder: {overwriteStrengthCorrectRate_byThunder} | overwriteDexterityCorrectRate_byThunder: {overwriteDexterityCorrectRate_byThunder} | overwriteMagicCorrectRate_byThunder: {overwriteMagicCorrectRate_byThunder} | overwriteFaithCorrectRate_byThunder: {overwriteFaithCorrectRate_byThunder} | overwriteLuckCorrectRate_byThunder: {overwriteLuckCorrectRate_byThunder} | overwriteStrengthCorrectRate_byDark: {overwriteStrengthCorrectRate_byDark} | overwriteDexterityCorrectRate_byDark: {overwriteDexterityCorrectRate_byDark} | overwriteMagicCorrectRate_byDark: {overwriteMagicCorrectRate_byDark} | overwriteFaithCorrectRate_byDark: {overwriteFaithCorrectRate_byDark} | overwriteLuckCorrectRate_byDark: {overwriteLuckCorrectRate_byDark} | InfluenceStrengthCorrectRate_byPhysics: {InfluenceStrengthCorrectRate_byPhysics} | InfluenceDexterityCorrectRate_byPhysics: {InfluenceDexterityCorrectRate_byPhysics} | InfluenceMagicCorrectRate_byPhysics: {InfluenceMagicCorrectRate_byPhysics} | InfluenceFaithCorrectRate_byPhysics: {InfluenceFaithCorrectRate_byPhysics} | InfluenceLuckCorrectRate_byPhysics: {InfluenceLuckCorrectRate_byPhysics} | InfluenceStrengthCorrectRate_byMagic: {InfluenceStrengthCorrectRate_byMagic} | InfluenceDexterityCorrectRate_byMagic: {InfluenceDexterityCorrectRate_byMagic} | InfluenceMagicCorrectRate_byMagic: {InfluenceMagicCorrectRate_byMagic} | InfluenceFaithCorrectRate_byMagic: {InfluenceFaithCorrectRate_byMagic} | InfluenceLuckCorrectRate_byMagic: {InfluenceLuckCorrectRate_byMagic} | InfluenceStrengthCorrectRate_byFire: {InfluenceStrengthCorrectRate_byFire} | InfluenceDexterityCorrectRate_byFire: {InfluenceDexterityCorrectRate_byFire} | InfluenceMagicCorrectRate_byFire: {InfluenceMagicCorrectRate_byFire} | InfluenceFaithCorrectRate_byFire: {InfluenceFaithCorrectRate_byFire} | InfluenceLuckCorrectRate_byFire: {InfluenceLuckCorrectRate_byFire} | InfluenceStrengthCorrectRate_byThunder: {InfluenceStrengthCorrectRate_byThunder} | InfluenceDexterityCorrectRate_byThunder: {InfluenceDexterityCorrectRate_byThunder} | InfluenceMagicCorrectRate_byThunder: {InfluenceMagicCorrectRate_byThunder} | InfluenceFaithCorrectRate_byThunder: {InfluenceFaithCorrectRate_byThunder} | InfluenceLuckCorrectRate_byThunder: {InfluenceLuckCorrectRate_byThunder} | InfluenceStrengthCorrectRate_byDark: {InfluenceStrengthCorrectRate_byDark} | InfluenceDexterityCorrectRate_byDark: {InfluenceDexterityCorrectRate_byDark} | InfluenceMagicCorrectRate_byDark: {InfluenceMagicCorrectRate_byDark} | InfluenceFaithCorrectRate_byDark: {InfluenceFaithCorrectRate_byDark} | InfluenceLuckCorrectRate_byDark: {InfluenceLuckCorrectRate_byDark}";
	}
}
