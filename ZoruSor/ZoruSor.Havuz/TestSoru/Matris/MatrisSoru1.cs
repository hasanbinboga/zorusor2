﻿using System.ComponentModel;
using System.Drawing;

namespace ZoruSor.Lib.TestSoru
{
    public class MatrisSoru1 : BaseSoru
    {
        public MatrisSoru1(Soru.Soru soru)
        {
            Soru = soru;
           
            Cevap = RandomHelper.RandomChar('A', 'F').ToString();
            switch (Cevap)
            {
                case "A":
                    SecenekA = soru.DogruCevapList[0].Image;
                    SecenekB = soru.CeldiriciList[0].Image;
                    SecenekC = soru.CeldiriciList[1].Image;
                    SecenekD = soru.CeldiriciList[2].Image;
                    SecenekE = soru.CeldiriciList[3].Image;
                    SecenekF = soru.CeldiriciList[4].Image;
                    break;
                case "B":
                    SecenekA = soru.CeldiriciList[0].Image;
                    SecenekB = soru.DogruCevapList[0].Image;
                    SecenekC = soru.CeldiriciList[1].Image;
                    SecenekD = soru.CeldiriciList[2].Image;
                    SecenekE = soru.CeldiriciList[3].Image;
                    SecenekF = soru.CeldiriciList[4].Image;
                    break;
                case "C":
                    SecenekA = soru.CeldiriciList[0].Image;
                    SecenekB = soru.CeldiriciList[1].Image;
                    SecenekC = soru.DogruCevapList[0].Image;
                    SecenekD = soru.CeldiriciList[2].Image;
                    SecenekE = soru.CeldiriciList[3].Image;
                    SecenekF = soru.CeldiriciList[4].Image;
                    break;
                case "D":
                    SecenekA = soru.CeldiriciList[0].Image;
                    SecenekB = soru.CeldiriciList[1].Image;
                    SecenekC = soru.CeldiriciList[2].Image;
                    SecenekD = soru.DogruCevapList[0].Image;
                    SecenekE = soru.CeldiriciList[3].Image;
                    SecenekF = soru.CeldiriciList[4].Image;
                    break;
                case "E":
                    SecenekA = soru.CeldiriciList[0].Image;
                    SecenekB = soru.CeldiriciList[1].Image;
                    SecenekC = soru.CeldiriciList[2].Image;
                    SecenekD = soru.CeldiriciList[3].Image;
                    SecenekE = soru.DogruCevapList[0].Image;
                    SecenekF = soru.CeldiriciList[4].Image;
                    break;
                case "F":
                    SecenekA = soru.CeldiriciList[0].Image;
                    SecenekB = soru.CeldiriciList[1].Image;
                    SecenekC = soru.CeldiriciList[2].Image;
                    SecenekD = soru.CeldiriciList[3].Image;
                    SecenekE = soru.CeldiriciList[4].Image;
                    SecenekF = soru.DogruCevapList[0].Image;
                    break;
            }

        }
      
        [DisplayName("A)")]
        public Image SecenekA { get; set; }
        [DisplayName("B)")]
        public Image SecenekB { get; set; }
        [DisplayName("C)")]
        public Image SecenekC { get; set; }
        [DisplayName("D)")]
        public Image SecenekD { get; set; }
        [DisplayName("E)")]
        public Image SecenekE { get; set; }
        [DisplayName("F)")]
        public Image SecenekF { get; set; }
    }
}
