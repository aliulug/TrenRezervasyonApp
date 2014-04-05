using NUnit.Framework;

namespace HesapMakinasiApplication
{
	[TestFixture]
	public class HesapMakinasiTest
	{
		[Test]
		public void IkiVeUcToplanirsa_BesDoner()
		{
			HesapMakinasi hesapMakinasi = new HesapMakinasi();
			int sonuc = hesapMakinasi.Topla(2, 3);
			Assert.That(sonuc, Is.EqualTo(5));
		}

		[Test]
		public void DortVeYediToplanirsa_OnbirDoner()
		{
			HesapMakinasi hesapMakinasi = new HesapMakinasi();
			int sonuc = hesapMakinasi.Topla(4, 7);
			Assert.That(sonuc, Is.EqualTo(11));
		}
	}

	public class HesapMakinasi
	{
		public int Topla(int sayi1, int sayi2)
		{
			return sayi1 + sayi2;
		}
	}
}
