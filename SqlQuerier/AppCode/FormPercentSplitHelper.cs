using System;
using System.Windows.Forms;

namespace SqlQuerier.AppCode
{
    public class FormPercentSplitHelper
    {
        private readonly Form _f;
        private readonly Panel _p;
        //private Splitter _s;
        private Single _layoutPercent;
        private readonly bool _isVertical;

        public FormPercentSplitHelper(Form f, Panel p, Splitter s)
        {
            _f = f;
            _p = p;
            //_s = s;
            _isVertical = (s.Dock == DockStyle.Left || s.Dock == DockStyle.Right);

            CheckLayoutPercent();
            s.SplitterMoved += s_SplitterMoved;
            f.SizeChanged += f_SizeChanged;
        }

        void f_SizeChanged(object sender, EventArgs e)
        {
            ResetLayoutPercent();
        }

        void s_SplitterMoved(object sender, SplitterEventArgs e)
        {
            CheckLayoutPercent();
        }

        private void CheckLayoutPercent()
        {
            if (_isVertical)
            {
                _layoutPercent = (Single)_p.Width / _f.Width;
            }
            else
            {
                _layoutPercent = (Single)_p.Height / _f.Height;
            }
        }

        private void ResetLayoutPercent()
        {
            if (_isVertical)
            {
                _p.Width = (int)(_layoutPercent * _f.Width);
            }
            else
            {
                _p.Height = (int)(_layoutPercent * _f.Height);
            }
        }
    }
}
