using System;

namespace RectNmsp
{
    class Rectangle
    {
        protected int lenth;
        public int width;
        public void setSize(int l, int w) {
            lenth = (l > 0 ? l : 0);
            width = (w > 0 ? w : 0);
        }
    }
}
