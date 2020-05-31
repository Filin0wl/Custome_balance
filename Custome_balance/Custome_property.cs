using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Custome_balance
{
    public class Custome_property
    {
        public bool VisibleLabel { get; set; }
        public Color ColorItem { get; set; }
        public int PositionRowText{ get; set; }
        public int PositionRowMoney{ get; set; }
        public int Positioncolomn{ get; set; }

        public Custome_property(bool vis, Color col)
        {
            VisibleLabel = vis;
            ColorItem = col;
            if(vis)
            {
                PositionRowText = 3;
                PositionRowMoney = 4;
                Positioncolomn = 0;
                
            }
            else
            {
                PositionRowText = 1;
                PositionRowMoney = 2;
                Positioncolomn = 1;
            }
        }
    }
}
