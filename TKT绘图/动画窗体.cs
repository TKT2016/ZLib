﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZLangRT.Attributes;
using Z桌面控件;

namespace Z绘图
{
    [ZClass(typeof(窗体))]
    public class 动画窗体 : Form
    {
        System.Windows.Forms.Timer timer;
        public Bitmap 背景图像 { get; set; }

        public 动画窗体()
        {
            this.SuspendLayout();
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.Load += new System.EventHandler(this.OnLoad);
            this.MouseMove += new MouseEventHandler(OnMouseMove);
            this.MouseClick += new MouseEventHandler(OnMouseClick);
            this.KeyPress += new KeyPressEventHandler(OnKeyPress);
            this.DoubleBuffered = true;
            //flyer = new Flyer();
            背景图像 = new Bitmap(this.Width, this.Height);
            this.ResumeLayout(false);
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            初始化();
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 38;
            timer.Tick += new EventHandler(OnTick);
            timer.Start();
            
        }

        public void 设置尺寸(int width, int height)
        {
            this.Size = new Size(width, height);
            背景图像.Dispose();
            背景图像 = new Bitmap(width, height);
        }

        public void 启动时窗口居中()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            响应鼠标移动(p);
            doRepaint();
        }

        private void doRepaint()
        {
            this.Invalidate(new Rectangle(0, 0, this.Width, this.Height));
        }

        public virtual void 响应鼠标移动(Point 鼠标位置)
        {

        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            响应键盘(e);
            doRepaint();
        }

        public virtual void 响应键盘(KeyPressEventArgs 鼠标参数)
        {

        }

        private void OnMouseClick(object sender, MouseEventArgs e)
        {
            响应鼠标单击(e);
            doRepaint();
        }

        public virtual void 响应鼠标单击(MouseEventArgs e)
        {

        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            绘图器 x = 创建绘图器();
            绘图(x);
            e.Graphics.DrawImage(背景图像, new Point(0, 0));
            //Console.WriteLine(背景图像.Width);
            //Console.WriteLine(背景图像.Height);
        }

        [ZCode("用(绘图器:HTQ)绘图")]
        public virtual void 绘图(绘图器 HTQ)
        {

        }

        private void OnTick(object sender, EventArgs e)
        {
            更新();
            doRepaint();
        }

        public virtual void 更新()
        {

        }

        public virtual void 初始化()
        {

        }

        public 绘图器 创建绘图器()
        {
            Graphics gs = Graphics.FromImage(背景图像);
            var _绘图器 = new 绘图器(gs);
            return _绘图器;
        }
    }
}
