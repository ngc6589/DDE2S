using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDE2S
{
    internal class ParseString
    {
        public String satellite = "";
        public String azimuth = "";
        public String elevation = "";
        public String dnFreq = "";
        public String upFreq = "";
        public String dnMode = "";
        public String upMode = "";
        public String range = "";
        public String rangeRate = "";
        public String latitude = "";

        public void Setstr(String str)
        {
            int s1;
            int s2;
            // AOS で始まる行は無視
            if (str[0] == 'A') return;
            // 衛星名
            s1 = str.IndexOf("\"");
            s2 = str.IndexOf("\"", s1 + 1);
            satellite = str.Substring((s1 + 1), (s2 - s1 - 1));
            // 方位角
            s1 = str.IndexOf("AZ");
            s2 = str.IndexOf(" ", s1 + 1);
            azimuth = str.Substring(s1 + 2, s2 - s1 - 2);
            // エレベーション
            s1 = str.IndexOf("EL");
            s2 = str.IndexOf(" ", s1 + 1);
            elevation = str.Substring(s1 + 2, s2 - s1 - 2);
            // ダウンリンク周波数
            s1 = str.IndexOf("DN");
            s2 = str.IndexOf(" ", s1 + 1);
            dnFreq = str.Substring(s1 + 2, s2 - s1 - 2);
            // アップリンク周波数
            s1 = str.IndexOf("UP");
            s2 = str.IndexOf(" ", s1 + 1);
            upFreq = str.Substring(s1 + 2, s2 - s1 - 2);
            // ダウンリンクモード
            if ((s1 = str.IndexOf("DM")) == -1)
            {
                dnMode = "None";
            }
            else
            {
                s2 = str.IndexOf(" ", s1 + 1);
                dnMode = str.Substring(s1 + 2, s2 - s1 - 2);
            }
            // アップリンクモード
            if ((s1 = str.IndexOf("UM")) == -1)
            {
                upMode = "None";
            }
            else
            {
                s2 = str.IndexOf(" ", s1 + 1);
                upMode = str.Substring(s1 + 2, s2 - s1 - 2);
            }
            // 距離
            s1 = str.IndexOf("RA");
            s2 = str.IndexOf(" ", s1 + 1);
            range = str.Substring(s1 + 2, s2 - s1 - 2);
            // 速度
            s1 = str.IndexOf("RR");
            s2 = str.IndexOf(" ", s1 + 1);
            rangeRate = str.Substring(s1 + 2, s2 - s1 - 2);
            // 高度
            s1 = str.IndexOf("LA");
            s2 = str.IndexOf(" ", s1 + 1);
            latitude = str.Substring(s1 + 2, s2 - s1 - 2);
        }

    }
}
