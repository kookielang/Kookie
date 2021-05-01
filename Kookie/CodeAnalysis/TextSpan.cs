﻿using System;

namespace Kookie.CodeAnalysis
{
    public struct TextSpan
    {
        public int Start { get; }
        public int Length { get; }
        
        public TextSpan(int start, int length)
        {
            Start = start;
            Length = length;
        }

        public int End => Start + Length;
    }

    public sealed class VariableSymbol
    {
        public string Name { get; }
        public Type Type { get; }

        public VariableSymbol(string name, Type type)
        {
            Name = name;
            Type = type;
        }
    }
}