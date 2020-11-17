using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Drawing;
using System.Windows.Forms;

namespace Race
{
    public class hound
    {
        public int FromPosition;
        public int Location = 0;

        public Random RandomPicker;
        public int TrackSize;
        public PictureBox MyPictureBox = null; 
        

        public bool Running()
        {
        int GoForward = RandomPicker.Next(1, 4);
        Point p = MyPictureBox.Location;
        p.X += GoForward;
        MyPictureBox.Location = p;
        if (p.X >= TrackSize)
        return true;
        else
        return false;
        }

        public void TFPosition()
        {
            FromPosition = 0;
        }
    }
}