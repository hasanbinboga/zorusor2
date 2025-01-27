﻿using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.DataAccess.ObjectBinding;
using ZoruSor.Lib.Havuz;
using ZoruSor.Lib.Soru;
using ZoruSor.Lib.TestSoru;

namespace ZoruSor.Lib.Test.EsEleman
{
    [DisplayName("Eş Eleman Test 1-1")]
    [HighlightedClass]
    public class EsElemanest11 : BaseTest
    {
        private const int SayfadakiSoruAdet = 7;
        private const int CeldiriciAdet = 3;
        private const int ResimBoyut = 135;

        [HighlightedMember]
        public EsElemanest11(Havuz.Havuz havuz, int zorlukDerece, int sabitParcaAdet, int sayfaAdet)
        {
            for (int i = 0; i < SayfadakiSoruAdet * sayfaAdet; i++)
            {
                var soruCreater = new SoruCreater();
                SoruBuilder builder = new EsEleman1
                {
                    Havuz = havuz,
                    ZorlukDerece = zorlukDerece,
                    SabitParcaAdet = sabitParcaAdet,
                    CeldiriciAdet = CeldiriciAdet,
                    ResimBoyut = ResimBoyut

                };
                soruCreater.Construct(builder);
                Add(new EsElemanSoru1(builder.Soru));
            }
        }

        public EsElemanest11(IEnumerable<TestDetail> testDetails)
        {
            foreach (var testDetail in testDetails)
            {

                for (int i = 0; i < SayfadakiSoruAdet * testDetail.SayfaAdet; i++)
                {
                    var soruCreater = new SoruCreater();
                    SoruBuilder builder = new EsEleman1
                    {
                        Havuz = testDetail.Havuz,
                        ZorlukDerece = testDetail.Zorluk,
                        SabitParcaAdet = testDetail.SabitParcaAdet,
                        CeldiriciAdet = CeldiriciAdet,
                        ResimBoyut = ResimBoyut
                    };
                    soruCreater.Construct(builder);
                    Add(new EsElemanSoru1(builder.Soru));
                }
                testDetail.Dispose();
            }
        }
    }
}
