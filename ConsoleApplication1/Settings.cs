using System;
using System.Drawing;
using UnityEngine;
using Color = System.Drawing.Color;
using Font = System.Drawing.Font;

namespace ConsoleApplication1
{
    public class Settings
    {
        public Pen playerP,
            friendP,
            autoturretP,
            resourceP,
            storageBoxP = new Pen(Color.BurlyWood),
            plantEntityP = new Pen(Color.DarkGreen),
            radarP
            ;

        public Brush playerB,
            friendB,
            autoturretB,
            resourceB,
            storageBoxB = new SolidBrush(Color.BurlyWood),
            plantEntityB = new SolidBrush(Color.DarkGreen),
            radarB
            ;
        
        public ushort sizeRadar, sizeDot, buferSize, center, halfdot;
        public bool showName;
        public String[] friends;
        public Color TransparencyKey;
        public Font font = new Font("Arial", 8);
        public int radPosX, radPosY;
        public Vector2 centerCircle;

        public void SetCircle()
        {
            this.centerCircle = new Vector2(this.center, this.center);
        }
    }
}