using System;

namespace GUI
{
    internal class openchillForm
    {
        private frmHoaDonBan frmHoaDonBan;

        public openchillForm(frmHoaDonBan frmHoaDonBan)
        {
            this.frmHoaDonBan = frmHoaDonBan;
        }

        public Action<object, object> Closed { get; internal set; }

        internal void setTT(string text1, string text2, string text3, string text4, string text5, string text6, string text7, string text8)
        {
            throw new NotImplementedException();
        }

        internal void Show()
        {
            throw new NotImplementedException();
        }
    }
}