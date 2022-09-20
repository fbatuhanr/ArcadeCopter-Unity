
using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DilSecenekleri : MonoBehaviour {

    void Update () {

        AyarlarMenu.DilAyari = PlayerPrefs.GetInt("DilAyari");

        if (AyarlarMenu.DilAyari == 0)
            { // Dil Turkce
            Magaza.ParaIcinTikla_Rewarded = "Tıkla 5 Altın Kazan!";

            SnszModOyunMenusu.AnaMenuYazi_SnszMod = "Ana Menu";

            Magaza.Kirmizi_TrailIz = "Alev   İzi";
            Magaza.Yesil_TrailIz = "Yeşilimsi   İz";
            Magaza.Mavi_TrailIz = "Mavimsi   İz";

            GunlukBonusOdul.Kazandin_YouWin = "KAZANDIN";
            GunlukBonusOdul.CarkName = "ÇARKI ÇEVİR!";
            GunlukBonusOdul.CarkSpinCevir = "ÇEVİR";
            GunlukBonusOdul.CarkHakkiSatinAlBuy = "HAK SATIN AL!";
            GunlukBonusOdul.BirGunOneDaySans = "1 Gün 1 Şans!";

            OyunModlari.BolumChapter_Yazisi = "Bölüm";

            Helikopter.SatinAlindi_ItemEsya = "Mevcut Eşya!";
            Helikopter.Yetersiz_ParaMoneySkorScore = "Yetersiz Para veya Skor";

            AnaMenu.CikisYazisi = "Çıkmak İçin Geri Tuşuna Bir Kez Daha Basın.";

            AnaMenu.OynaPlayYazi = "OYNA";
            AnaMenu.MagazaShopYazi = "MAĞAZA";
            AnaMenu.AyarlarSettingsYazi = "AYARLAR";

            OyunModlari.BolumTamamlandi_Completed = "Tamamlandı !";
            OyunModlari.SonsuzMod_SkorScore = "Sonsuz Mod Skor: ";
            OyunModlari.Gelinen_DalgaWave = ".Dalga";
            OyunModlari.DalgaSkor_Score = "Dalga Skor:    ";

            OyunModlari.BolumKac_Yazi1 = "Bölüm 1";
            OyunModlari.BolumKac_Yazi2 = "Bölüm 2";
            OyunModlari.BolumKac_Yazi3 = "Bölüm 3";
            OyunModlari.BolumKac_Yazi4 = "Bölüm 4";
            OyunModlari.BolumKac_Yazi5 = "Bölüm 5";
            OyunModlari.BolumKac_YaziSoruIsareti = "Bölüm ?";

            Magaza.KirmiziRed_Pervane = "Kırmızı Pervane";
            Magaza.YesilGreen_Pervane = "Yeşil Pervane";
            Magaza.MaviBlue_Pervane = "Mavi Pervane";

            Magaza.KirmiziRed_Govde = "Kırmızı Gövde";
            Magaza.YesilGreen_Govde = "Yeşil Gövde";
            Magaza.MaviBlue_Govde = "Mavi Gövde";

            Magaza.KirmiziRed_Altlik = "Kırmızı Altlık";
            Magaza.YesilGreen_Altlik = "Yeşil Altlık";
            Magaza.MaviBlue_Altlik = "Mavi Altlık";

            Magaza.KirmiziRed_Kuyruk = "Kırmızı Kuyruk";
            Magaza.YesilGreen_Kuyruk = "Yeşil Kuyruk";
            Magaza.MaviBlue_Kuyruk = "Mavi Kuyruk";

            Magaza.Pervane_FiyatPrice = "VE";
            MagazaSatinAlim.Yetersiz_ParaMoney = "Yeterli Paran\nveya\nSkor Puanın YOK!";

            OyunModlari.Bolum_Chapter_Play = "1.Bölümü Oynamak İçin Tıklayınız...";
            OyunModlari.Sinirsiz_Limitless_Play = "Sonsuz Mod";
            OyunModlari.Yakinda_ComingSoon = "YAKINDA !!!";

            AyarlarMenu.Ayarlar_Settings = "Ayarlar";
            AyarlarMenu.Sustur_Mute_Music = "Müzik Sesini Kapat";
            AyarlarMenu.Sustur_Mute_HeliPervaneSFX = "Ses Efektlerini Kapat";

            AyarlarMenu.SesAyarlari_Settings = "Ses Ayarı";

            Yukleniyor.Yukleniyor_Loading = "Yükleniyor...";

            OyunMenusu.Devam_Continue = "Devam Et";

            OyunMenusu.DevamEt_Continue = "Devam Et";
            OyunMenusu.Can_Life = "Can";
            OyunMenusu.Ana_MainMenu = "Ana Menü";

            OyunMenusu.Bedel_Price = "Bedel: ";
            

            OyunMenusu.Duraklatildi_Paused = "Oyun Duraklatıldı";
            OyunMenusu.OyunBitti_GameOver = "Oyun Bitti !";

            OyunMenusu.YeterliAltin_EnoughGold = "Yeterli Para Yok";

            OyunMenusu.YeniOyun_NewGame = "Yeni Oyun";
            OyunMenusu.Mevcut_Available = "Mevcut: ";
            OyunMenusu.ikinciDalga_SecondWave = "2.Dalga !!!";
            OyunMenusu.ucuncuDalga_ThirthWave = "3.Dalga !!!";
            OyunMenusu.dorduncuDalga_FourthWave = "4.Dalga !!!";
            OyunMenusu.besinciDalga_FifthWave = "5.Dalga !!!";
            OyunMenusu.birinciBolum_FirstChapter = "1.Bölüm Final !";

             AnaMenu.Para_Money = "Para: ";
             AnaMenu.ToplamSkor_TotalScore = "Toplam Skor: ";

            Magaza.Para_Money = "Para: ";
            Magaza.ToplamSkor_TotalScore = "Toplam Skor: ";
            }
        else if (AyarlarMenu.DilAyari == 1)
          {  // Language is English
            Magaza.ParaIcinTikla_Rewarded = "Click and Earn 5 Money!";

            SnszModOyunMenusu.AnaMenuYazi_SnszMod = "Main Menu";

            Magaza.Kirmizi_TrailIz = "Flame   Trail";
            Magaza.Yesil_TrailIz = "Greenish   Trail";
            Magaza.Mavi_TrailIz = "Bluish   Trail";

            GunlukBonusOdul.Kazandin_YouWin = "YOU WIN";
            GunlukBonusOdul.CarkName = "SPIN THE WHEEL!";
            GunlukBonusOdul.CarkSpinCevir = "SPIN";
            GunlukBonusOdul.CarkHakkiSatinAlBuy = "BUY!";
            GunlukBonusOdul.BirGunOneDaySans = "1 Day 1 Chance!";

            OyunModlari.BolumChapter_Yazisi = "Chapter";

            Helikopter.SatinAlindi_ItemEsya = "Available Item!";
            Helikopter.Yetersiz_ParaMoneySkorScore = "Not Enough Gold or Score";

            AnaMenu.CikisYazisi = "Press Back One More Time To Exit.";

            AnaMenu.OynaPlayYazi = "PLAY";
            AnaMenu.MagazaShopYazi = "SHOP";
            AnaMenu.AyarlarSettingsYazi = "SETTINGS";

            OyunModlari.BolumTamamlandi_Completed = "Completed !";
            OyunModlari.SonsuzMod_SkorScore = "Limitless Mode Score: ";
            OyunModlari.Gelinen_DalgaWave = ".Wave";
            OyunModlari.DalgaSkor_Score = "Wave Score:    ";

            OyunModlari.BolumKac_Yazi1 = "Chapter 1";
            OyunModlari.BolumKac_Yazi2 = "Chapter 2";
            OyunModlari.BolumKac_Yazi3 = "Chapter 3";
            OyunModlari.BolumKac_Yazi4 = "Chapter 4";
            OyunModlari.BolumKac_Yazi5 = "Chapter 5";
            OyunModlari.BolumKac_YaziSoruIsareti = "Chapter ?";

            Magaza.KirmiziRed_Pervane = "Red Propeller";
            Magaza.YesilGreen_Pervane = "Green Propeller";
            Magaza.MaviBlue_Pervane = "Blue Propeller";

            Magaza.KirmiziRed_Govde = "Red Body";
            Magaza.YesilGreen_Govde = "Green Body";
            Magaza.MaviBlue_Govde = "Blue Body";

            Magaza.KirmiziRed_Altlik = "Red Stand";
            Magaza.YesilGreen_Altlik = "Green Stand";
            Magaza.MaviBlue_Altlik = "Blue Stand";

            Magaza.KirmiziRed_Kuyruk = "Red Tail";
            Magaza.YesilGreen_Kuyruk = "Green Tail";
            Magaza.MaviBlue_Kuyruk = "Blue Tail";

            Magaza.Pervane_FiyatPrice = "AND";
            MagazaSatinAlim.Yetersiz_ParaMoney = "Not Enough Money\nor\nScore Point!";

            OyunModlari.Bolum_Chapter_Play = "Touch For Play Chapter 1";
            OyunModlari.Sinirsiz_Limitless_Play = "Limitless Mode";
            OyunModlari.Yakinda_ComingSoon = "COMING SOON !!!";

            AyarlarMenu.Ayarlar_Settings = "Settings";
            AyarlarMenu.Sustur_Mute_Music = "Mute Music";
            AyarlarMenu.Sustur_Mute_HeliPervaneSFX = "Mute SFX";

            AyarlarMenu.SesAyarlari_Settings = "Sound Setting";

            Yukleniyor.Yukleniyor_Loading = "Loading...";

            OyunMenusu.Devam_Continue = "Continue";
            OyunMenusu.DevamEt_Continue = "Continue";
            OyunMenusu.Can_Life = "Life";
            OyunMenusu.Ana_MainMenu = "Main Menu";
            OyunMenusu.Bedel_Price = "Price: ";
            OyunMenusu.Duraklatildi_Paused = "Game Paused";
            OyunMenusu.OyunBitti_GameOver = "Game Over !";
            OyunMenusu.YeterliAltin_EnoughGold = "Not Enough Money !";
            OyunMenusu.YeniOyun_NewGame = "New Game";
            OyunMenusu.Mevcut_Available = "Available: ";
            OyunMenusu.ikinciDalga_SecondWave = "2.Wave !!!";
            OyunMenusu.ucuncuDalga_ThirthWave = "3.Wave !!!";
            OyunMenusu.dorduncuDalga_FourthWave = "4.Wave !!!";
            OyunMenusu.besinciDalga_FifthWave = "5.Wave !!!";
            OyunMenusu.birinciBolum_FirstChapter = "1.Chapter Final !";

            AnaMenu.Para_Money = "Money: ";
            AnaMenu.ToplamSkor_TotalScore = "Total Score: ";

            Magaza.Para_Money = "Money: ";
            Magaza.ToplamSkor_TotalScore = "Total Score: ";
        }

	}
}
