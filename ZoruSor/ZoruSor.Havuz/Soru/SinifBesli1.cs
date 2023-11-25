﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ZoruSor.Lib.Soru
{
    public class SinifBesli1 : SoruBuilder
    {
        private Dictionary<string, int> _ortakParcaList;

        //private CiktiResim KotuParcaDegistir(CiktiResim resim, Dictionary<string, int> ortakParca)
        //{
        //    var kotuParcaList = new Dictionary<string, int>();
        //    foreach (var parca in resim.ParcaList)
        //    {
        //        if (ortakParca.ContainsKey(parca.Key) && ortakParca[parca.Key] == parca.Value)
        //        {
        //            kotuParcaList.Add(parca.Key, parca.Value);
        //        }
        //    }
        //    //ortak parca 1 ve kotu parca yoksa resmi geri gonder/
        //    if (ortakParca.Count == 1 && kotuParcaList.Count == 0)
        //    {
        //        return resim;
        //    }
        //    //Ortak Parca listesinde 1 resim varsa ve kotuparcaList sayisi da 1 ise
        //    if (ortakParca.Count == 1 && kotuParcaList.Count == 1)
        //    {
        //        var parcaAd = kotuParcaList.Keys.First();
        //        kotuParcaList[parcaAd] = RandomHelper.RandomDifferentNumber(0,
        //            Havuz.ParcaList.First(s => s.Ad == parcaAd).Adet - 1,
        //                    new[] { kotuParcaList[parcaAd] });
        //        resim = ResimHelper.ParcaDegistir(Havuz, resim,
        //            kotuParcaList, ResimBoyut);
        //        return resim;
        //    }

        //    //yeni uretilen resimlerdeki otak parcalardan %50 si ayni ise 
        //    if (kotuParcaList.Count > ortakParca.Count / 2)
        //    {
        //        //Ortak parcalarin yarisini sec 
        //        var kotuParcalar = kotuParcaList.Take(kotuParcaList.Count / 2).ToDictionary(k => k.Key, v => v.Value);

        //        //bu parcalar icin rasgele id uret.
        //        foreach (var parca in Havuz.ParcaList)
        //        {
        //            if (kotuParcalar.ContainsKey(parca.Ad))
        //            {
        //                kotuParcalar[parca.Ad] = RandomHelper.RandomDifferentNumber(0, parca.Adet - 1,
        //                    new[] { kotuParcaList[parca.Ad] });
        //            }
        //        }

        //        //resimi degistir.  
        //        resim = ResimHelper.ParcaDegistir(Havuz, resim, kotuParcalar, ResimBoyut);
        //    }
        //    return resim;
        //}


        private CiktiResim KotuParcaDegistir1(CiktiResim resim, Dictionary<string, int> ortakParca)
        {
            var kotuParcaList = new Dictionary<string, int>();
            foreach (var parca in resim.ParcaList)
            {
                if (ortakParca.ContainsKey(parca.Key) && ortakParca[parca.Key] == parca.Value)
                {
                    kotuParcaList.Add(parca.Key, parca.Value);
                }
            }
            //ortak parca 1 ve kotu parca yoksa resmi geri gonder/
            if (ortakParca.Count == 1 && kotuParcaList.Count == 0)
            {
                return resim;
            }
            //Ortak Parca listesinde 1 resim varsa ve kotuparcaList sayisi da 1 ise
            if (ortakParca.Count == 1 && kotuParcaList.Count == 1)
            {
                var parcaAd = kotuParcaList.Keys.First();
                kotuParcaList[parcaAd] = RandomHelper.RandomDifferentNumber(0,
                    Havuz.ParcaList.First(s => s.Ad == parcaAd).Adet - 1,
                            new[] { kotuParcaList[parcaAd] });
                resim = ResimHelper.ParcaDegistir(Havuz, resim,
                    kotuParcaList, ResimBoyut);
                return resim;
            }

            //yeni uretilen resimlerdeki otak parcalardan %50 si ayni ise 
            if (kotuParcaList.Count > 0)
            {
                //Ortak parcalarin yarisini sec 
                var kotuParcalar = kotuParcaList.ToDictionary(k => k.Key, v => v.Value);

                //bu parcalar icin rasgele id uret.
                foreach (var parca in Havuz.ParcaList)
                {
                    if (kotuParcalar.ContainsKey(parca.Ad))
                    {
                        kotuParcalar[parca.Ad] = RandomHelper.RandomDifferentNumber(0, parca.Adet - 1,
                            new[] { kotuParcaList[parca.Ad] });
                    }
                }

                //resimi degistir.  
                resim = ResimHelper.ParcaDegistir(Havuz, resim,
                    kotuParcalar, ResimBoyut);
            }
            return resim;
        }
        public override void ReferansResimUret()
        {
            _ortakParcaList = new Dictionary<string, int>(10);

            //Rastgele bir resim uret
            var resim1 = ResimHelper.RasgeleResimUret(Havuz, ResimBoyut);

            //Zorluk seviyesi -1 kadar degisecek parca sayisini belirle
            var degisecekParcalar = ParcaSecimHelper.KadariniSec(Havuz, ZorlukDerece - 1);

            //Referans resimden, belirlenen parcalari degisik 3 tane daha resim uret.
            var resim2 = ResimHelper.ResimDegistirUret(Havuz, resim1, degisecekParcalar, ResimBoyut);
            var resim3 = ResimHelper.ResimDegistirUret(Havuz, resim1, degisecekParcalar, ResimBoyut);

            Soru.ReferansResimList.Add(resim1);
            Soru.ReferansResimList.Add(resim2);
            Soru.ReferansResimList.Add(resim3);

            //Resimlerden birini dogru cevap yap.
            Soru.DogruCevapList.Add(ResimHelper.ResimDegistirUret(Havuz, resim1, degisecekParcalar, ResimBoyut));

            //Diger 3 referans resimdeki ortak parca adlari ve id' lerini sec
            _ortakParcaList = new Dictionary<string, int>();

            foreach (var referansParca in Soru.ReferansResimList[0].ParcaList)
            {
                if (Soru.ReferansResimList.Count(s => s.ParcaList[referansParca.Key] == referansParca.Value) == 3)
                {
                    _ortakParcaList.Add(referansParca.Key, referansParca.Value);
                }
            }

            //Rasgele 2 tane daha resim uret.

            Soru.ReferansResimList.Add(ResimHelper.RasgeleResimUret(Havuz, ResimBoyut));
            Soru.ReferansResimList.Add(ResimHelper.RasgeleResimUret(Havuz, ResimBoyut));

            //yeni resimlerin her biri icin
            for (int i = 3; i < 5; i++)
            {

                Soru.ReferansResimList[i] = KotuParcaDegistir1(Soru.ReferansResimList[i], _ortakParcaList);

            }
            var kotuOrtakParcalar = new Dictionary<string, int>();

            foreach (var resim in Soru.ReferansResimList)
            {
                foreach (var parcaDeger in resim.ParcaList)
                {
                    if (_ortakParcaList.ContainsKey(parcaDeger.Key) == false)
                    {
                        //Ortak parcalar haricindeki parcalar arasinda deger sayisi 3 ve daha fazla olan varsa 
                        //kotu Ortak parcalara ekle
                        if (Soru.ReferansResimList.Count(s => s.ParcaList[parcaDeger.Key] == parcaDeger.Value) > 2)
                        {
                            if (kotuOrtakParcalar.ContainsKey(parcaDeger.Key) == false)
                            {
                                kotuOrtakParcalar.Add(parcaDeger.Key, parcaDeger.Value);
                            }
                        }
                    }
                }
            }

            if (kotuOrtakParcalar.Count>0)
            {
                //yeni resimlerin her biri icin
                for (int i = 3; i < 5; i++)
                {

                    Soru.ReferansResimList[i] = KotuParcaDegistir1(Soru.ReferansResimList[i], kotuOrtakParcalar);

                }
            }

            

        }

        public override void DogruCevapUret()
        {
            var sonuc = Soru.DogruCevapList[0];
            //ilk kotu resimdeki parca degerlerini al
            var kotuParcaList = new Dictionary<string, int>();
            foreach (var parca in Soru.ReferansResimList[3].ParcaList)
            {

                kotuParcaList.Add(parca.Key, parca.Value);

            }

            //kotu resimdeki parcanin degerlerini dogru cevapta varsa degistir
            sonuc = KotuParcaDegistir1(sonuc, kotuParcaList);

            //Ikinci kotu resimdeki parca degerlerini al
            kotuParcaList = new Dictionary<string, int>();
            foreach (var parca in Soru.ReferansResimList[4].ParcaList)
            {

                kotuParcaList.Add(parca.Key, parca.Value);

            }
            //kotu resimdeki parcanin degerlerini dogru cevapta varsa degistir
            sonuc = KotuParcaDegistir1(sonuc, kotuParcaList);

            Soru.DogruCevapList.Clear();
            Soru.DogruCevapList.Add(sonuc);}

        public override void CeldiriciUret()
        {
            //Aynisini bul' un aynisi
            #region Sifir Validation

            if (ZorlukDerece < 0)
            {
                throw new ApplicationException("Zorluk derecesi 0 dan büyük olmalıdır.");
            }
            if (SabitParcaAdet < 0)
            {
                throw new ApplicationException("Değişim Adedi 0 dan büyük olmalıdır.");
            }
            if (CeldiriciAdet < 0)
            {
                throw new ApplicationException("Çeldirici Adedi 0 dan büyük olmalıdır.");
            }

            #endregion

            if (ZorlukDerece > Havuz.ParcaList.Count)
            {
                throw new ApplicationException("Zorluk derecesi sadece 1 ile " + Havuz.ParcaList.Count + " arasında olabilir.");
            }

            if (ZorlukDerece - SabitParcaAdet <= 0)
            {
                throw new ApplicationException(ZorlukDerece + " Zorluk derecesi için sabit parca adedi en fazla " +
                                               (ZorlukDerece - 1) + " olabilir.");
            }

            //celdirici adedi kadar
            for (var i = 0; i < CeldiriciAdet; i++)
            {
                var degisecekParcalar = ParcaSecimHelper.KalaniSec(Havuz, SabitParcaAdet, ZorlukDerece);
                var sonuc = ResimHelper.ResimDegistirUret(Havuz, Soru.DogruCevapList[0], degisecekParcalar, ResimBoyut);
                sonuc = KotuParcaDegistir1(sonuc, _ortakParcaList);
                //celdiriciyi sorunun listesine ekle
                if (Soru.CeldiriciList.Any(s => s.Equals(sonuc)) || Soru.DogruCevapList[0].Equals(sonuc))
                {
                    i--;
                }
                else
                {
                    Soru.CeldiriciList.Add(sonuc);
                }

            }
        }
    }
}
