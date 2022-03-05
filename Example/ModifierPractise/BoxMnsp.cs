using System;
using RectNmsp;

namespace BoxNmsp
{
    class Box : Rectangle
    {
        internal int height;
        internal int price;
        private int weight;
        internal void setSize(int l, int w, int h) {
            base.setSize(l, w);
            height = (h > 0 ? h : 0);
        }
        internal int volume() {
            return height * width * lenth;
        }
    }
}
