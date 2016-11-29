using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZLangRT.Descs;

namespace Z绘图
{
    public class CiDian : CnEnDict
    {
        public override void AddWords()
        {
            AddSafe("颜色", "Color");
            AddSafe("宽度", "width");
            AddSafe("高度", "Height");
            AddSafe("画笔", "Brush");
           
        }
    }
}
