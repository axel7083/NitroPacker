﻿using System;

namespace HaroohieClub.NitroPacker.IO.Serialization
{
    [AttributeUsage(AttributeTargets.Field, Inherited = true, AllowMultiple = false)]
    public sealed class ChunkSizeAttribute : Attribute
    {
        public int Difference { get; }

        public ChunkSizeAttribute(int difference = 0)
        {
            Difference = difference;
        }
    }
}