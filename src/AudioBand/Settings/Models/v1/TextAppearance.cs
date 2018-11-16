﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AudioBand.Models;

namespace AudioBand.Settings.Models.v1
{
    internal class TextAppearance
    {
        public bool IsVisible { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public int XPosition { get; set; }
        public int YPosition { get; set; }
        public string FontFamily { get; set; }
        public float FontSize { get; set; }
        public Color Color { get; set; }
        public string FormatString { get; set; }
        public CustomLabel.TextAlignment Alignment { get; set; }
        public string Name { get; set; }
        public int ScrollSpeed { get; set; }
    }
}