﻿// <copyright file="PatternBrush.cs" company="James Jackson-South">
// Copyright (c) James Jackson-South and contributors.
// Licensed under the Apache License, Version 2.0.
// </copyright>

namespace ImageSharp.Drawing.Brushes
{
    using ImageSharp.PixelFormats;

    /// <summary>
    /// Provides an implementation of a pattern brush for painting patterns. The brush use <see cref="Rgba32"/> for painting.
    /// </summary>
    public class PatternBrush : PatternBrush<Rgba32>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PatternBrush"/> class.
        /// </summary>
        /// <param name="foreColor">Color of the fore.</param>
        /// <param name="backColor">Color of the back.</param>
        /// <param name="pattern">The pattern.</param>
        public PatternBrush(Rgba32 foreColor, Rgba32 backColor, bool[,] pattern)
            : base(foreColor, backColor, pattern)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PatternBrush"/> class.
        /// </summary>
        /// <param name="brush">The brush.</param>
        internal PatternBrush(PatternBrush<Rgba32> brush)
            : base(brush)
        {
        }
    }
}