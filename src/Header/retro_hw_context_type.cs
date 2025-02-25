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

namespace SK.Libretro.Header
{
    public enum retro_hw_context_type
    {
        RETRO_HW_CONTEXT_NONE = 0,
        RETRO_HW_CONTEXT_OPENGL = 1,
        RETRO_HW_CONTEXT_OPENGLES2 = 2,
        RETRO_HW_CONTEXT_OPENGL_CORE = 3,
        RETRO_HW_CONTEXT_OPENGLES3 = 4,
        RETRO_HW_CONTEXT_OPENGLES_VERSION = 5,
        RETRO_HW_CONTEXT_VULKAN = 6,
        RETRO_HW_CONTEXT_DIRECT3D = 7
    }
}
