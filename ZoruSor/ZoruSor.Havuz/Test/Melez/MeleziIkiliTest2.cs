﻿using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.DataAccess.ObjectBinding;
using ZoruSor.Lib.Havuz;
using ZoruSor.Lib.Soru;
using ZoruSor.Lib.TestSoru;

namespace ZoruSor.Lib.Test.Melez
{
    [DisplayName("Melez Ikili 2")]
    [HighlightedClass]
    public class MelezIkiliTest2 : BaseTest
    {
        private const int SayfadakiSoruAdet = 2;
        private const int CeldiriciAdet = 3;
        private const int ResimBoyut = 350;

        [HighlightedMember]
        public MelezIkiliTest2(Havuz.Havuz havuz, string resim1Formul, string resim2Formul
           , int zorlukDerece, int sabitParcaAdet, int sayfaAdet)
        {

            for (int i = 0; i < SayfadakiSoruAdet * sayfaAdet; i++)
            {
                var soruCreater = new SoruCreater();
                SoruBuilder builder = new MelezIkili
                {
                    Havuz = havuz,
                    ZorlukDerece = zorlukDerece,
                    SabitParcaAdet = sabitParcaAdet,
                    CeldiriciAdet = CeldiriciAdet,
                    ResimBoyut = ResimBoyut,
                    Resim1Formul = resim1Formul,
                    Resim2Formul = resim2Formul
                };
                soruCreater.Construct(builder);
                Add(new MelezIkili2Soru(builder.Soru));
            }
        }

        public MelezIkiliTest2(List<MelezIkili2Soru> soruList)
        {
            soruList.ForEach(Add);
        }

        public MelezIkiliTest2(IEnumerable<TestDetail> testDetails)
        {
            foreach (var testDetail in testDetails)
            {
                for (int i = 0; i < SayfadakiSoruAdet * testDetail.SayfaAdet; i++)
                {
                    var soruCreater = new SoruCreater();
                    SoruBuilder builder = new MelezIkili
                    {
                        Havuz = testDetail.Havuz,
                        ZorlukDerece = testDetail.Zorluk,
                        SabitParcaAdet = testDetail.SabitParcaAdet,
                        CeldiriciAdet = CeldiriciAdet,
                        ResimBoyut = ResimBoyut,
                        Resim1Formul = testDetail.Resim1Formul,
                        Resim2Formul = testDetail.Resim2Formul
                    };
                    soruCreater.Construct(builder);
                    Add(new MelezIkili2Soru(builder.Soru));
                }
                testDetail.Dispose();
            }
        }
    }
}
