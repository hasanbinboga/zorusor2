﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevExpress.DataAccess.ObjectBinding;
using ZoruSor.Lib.Havuz;
using ZoruSor.Lib.Soru;
using ZoruSor.Lib.TestSoru;

namespace ZoruSor.Lib.Test
{
    [DisplayName("Para Oyun Test 2")]
    [HighlightedClass]
    public class ParaOyun1Test2 : BaseTest
    {
        private const int SayfadakiSoruAdet = 1;
        private const int CeldiriciAdet = 3;
        private const int ResimBoyut = 350;

        [HighlightedMember]public ParaOyun1Test2(string satir1Formul, string satir2Formul, string satir3Formul
            , string satir4Formul, int zorlukDerece, int sayfaAdet, bool islemGorunsun)
        {
            for (int i = 0; i < SayfadakiSoruAdet * sayfaAdet; i++)
            {
                var soruCreater = new SoruCreater();
                SoruBuilder builder = new Soru.ParaOyun
                {
                    ZorlukDerece = zorlukDerece,
                    CeldiriciAdet = CeldiriciAdet,
                    ResimBoyut = ResimBoyut,
                    Satir1Formul = satir1Formul,
                    Satir2Formul = satir2Formul,
                    Satir3Formul = satir3Formul,
                    Satir4Formul = satir4Formul,
                    IslemGorunsun = islemGorunsun
                };
                soruCreater.Construct(builder);
                Add(new KurBulUySoru2(builder.Soru));
            }
        }
        public ParaOyun1Test2(IEnumerable<TestDetail> testDetails)
        {
            foreach (var testDetail in testDetails)
            {
                for (int i = 0; i < SayfadakiSoruAdet * testDetail.SayfaAdet; i++)
                {
                    var soruCreater = new SoruCreater();
                    SoruBuilder builder = new Soru.ParaOyun
                    {
                        ZorlukDerece = testDetail.Zorluk,
                        CeldiriciAdet = CeldiriciAdet,
                        ResimBoyut = ResimBoyut,
                        Satir1Formul = testDetail.Resim1Formul,
                        Satir2Formul = testDetail.Resim2Formul,
                        Satir3Formul = testDetail.Resim3Formul,
                        Satir4Formul = testDetail.Resim4Formul,
                        IslemGorunsun = testDetail.IslemGorunsun
                    };
                    soruCreater.Construct(builder);
                    Add(new KurBulUySoru2(builder.Soru));
                }
                testDetail.Dispose();
            }
        }
    }
}