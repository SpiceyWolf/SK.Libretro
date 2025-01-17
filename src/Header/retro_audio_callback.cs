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
using System.Runtime.InteropServices;

namespace SK.Libretro.Header
{
    // typedef void (RETRO_CALLCONV *retro_audio_callback_t)(void);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void retro_audio_callback_t();
    // typedef void (RETRO_CALLCONV *retro_audio_set_state_callback_t)(bool enabled);
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void retro_audio_set_state_callback_t([MarshalAs(UnmanagedType.I1)] bool enabled);

    public struct retro_audio_callback
    {
        public IntPtr callback;  // retro_audio_callback_t
        public IntPtr set_state; // retro_audio_set_state_callback_t
    }
}
