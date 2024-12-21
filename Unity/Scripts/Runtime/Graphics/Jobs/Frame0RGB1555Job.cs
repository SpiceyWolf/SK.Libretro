﻿/* MIT License

 * Copyright (c) 2021-2022 Skurdt
 *
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:

 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.

 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE. */

using System;
using Unity.Burst;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;

namespace SK.Libretro.Unity
{
    [BurstCompile]
    public struct Frame0RGB1555Job : IJobParallelFor
    {
        [ReadOnly, NativeDisableUnsafePtrRestriction] public IntPtr SourceData;
        public int Width;
        public int Height;
        public int PitchPixels;
        [WriteOnly] public NativeArray<uint> TextureData;

        public unsafe void Execute(int index)
        {
            int x = index % Width;
            int y = (index - x) / Width;
            y = Height - 1 - y;
            int offset = y * PitchPixels;
            TextureData[index] = GraphicsUtilities.ARGB1555toBGRA32(((ushort*)SourceData)[offset + x]);
        }
    }
}
