﻿using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.DataAccess.ObjectBinding;
using ZoruSor.Lib.Havuz;
using ZoruSor.Lib.Soru;
using ZoruSor.Lib.TestSoru;

namespace ZoruSor.Lib.Test.Simetri
{
    [DisplayName("Simetrik Iliskiler 2")]
    [HighlightedClass]
    public class Simetri22Test : BaseTest
    {
        private const int SayfadakiSoruAdet = 1;
        private const int CeldiriciAdet = 3;
        private const int ResimBoyut = 350;

        [HighlightedMember]
        public Simetri22Test(Havuz.Havuz havuz, int zorlukDerece, int sabitParcaAdet, int sayfaAdet)
        {
            for (int i = 0; i < SayfadakiSoruAdet* sayfaAdet; i++)
            {
                var soruCreater = new SoruCreater();
                SoruBuilder builder = new SimetrikIliski2()
                {
                    Havuz = havuz,
                    ZorlukDerece = zorlukDerece,
                    SabitParcaAdet = sabitParcaAdet,
                    CeldiriciAdet = CeldiriciAdet,
                    ResimBoyut = ResimBoyut
                };
                soruCreater.Construct(builder);
                Add(new KurBulUySoru2(builder.Soru));
            }
        }
        public Simetri22Test(IEnumerable<TestDetail> testDetails)
        {
            foreach (var testDetail in testDetails)
            {
                for (int i = 0; i < SayfadakiSoruAdet * testDetail.SayfaAdet; i++)
                {
                    var soruCreater = new SoruCreater();
                    SoruBuilder builder = new SimetrikIliski2
                    {
                        Havuz = testDetail.Havuz,
                        ZorlukDerece = testDetail.Zorluk,
                        SabitParcaAdet = testDetail.SabitParcaAdet,
                        CeldiriciAdet = CeldiriciAdet,
                        ResimBoyut = ResimBoyut
                    };
                    soruCreater.Construct(builder);
                    Add(new KurBulUySoru2(builder.Soru));
                }
                testDetail.Dispose();
            }
        }
    }
}