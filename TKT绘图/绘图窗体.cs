using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZLangRT;
using ZLangRT.Attributes;
using Z桌面控件;

namespace Z绘图
{
    [ZClass(typeof(窗体))]
    public class 绘图窗体 : Form
    {
        public 绘图窗体()
        {
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.Load += new System.EventHandler(this.OnLoad);
            this.MouseMove += new MouseEventHandler(OnMouseMove);
            this.MouseClick += new MouseEventHandler(OnMouseClick);
            this.KeyPress += new KeyPressEventHandler(OnKeyPress);
        }

        public void 启动时窗口居中()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            响应鼠标移动(new Point(e.X, e.Y));
        }

        public virtual void 响应鼠标移动(Point 鼠标位置)
        {

        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            响应键盘(e);
        }

        public virtual void 响应键盘(KeyPressEventArgs 鼠标参数)
        {

        }

        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            响应鼠标单击(e);
        }

        public virtual void 响应鼠标单击(MouseEventArgs e)
        {

        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            绘图器 x = new 绘图器(e.Graphics);
            绘图(x);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            初始化();
        }
        
        public virtual void 初始化()
        {

        }
      
        [ZCode("用(绘图器:HTQ)绘图")]
        public virtual void 绘图(绘图器 HTQ)
        {

        }

        public 绘图器 创建绘图器()
        {
            //Console.WriteLine(System.AppDomain.CurrentDomain.BaseDirectory);
            var _绘图器 = new 绘图器(this.CreateGraphics());
            return _绘图器;
        }
    }
}
