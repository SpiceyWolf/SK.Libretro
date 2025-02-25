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

using SK.Libretro.Header;

namespace SK.Libretro
{
    public sealed class NullInputProcessor : IInputProcessor
    {
        public LeftStickBehaviour LeftStickBehaviour { get; set; }

        public short JoypadButton(int port, RETRO_DEVICE_ID_JOYPAD button) => 0;
        public short JoypadButtons(int port) => 0;

        public short MouseX(int port) => 0;
        public short MouseY(int port) => 0;
        public short MouseWheel(int port) => 0;
        public short MouseButton(int port, RETRO_DEVICE_ID_MOUSE button) => 0;

        public short KeyboardKey(int port, retro_key key) => 0;

        public short LightgunX(int port) => 0;
        public short LightgunY(int port) => 0;
        public bool LightgunIsOffscreen(int port) => false;
        public short LightgunButton(int port, RETRO_DEVICE_ID_LIGHTGUN button) => 0;

        public short AnalogLeftX(int port) => 0;
        public short AnalogLeftY(int port) => 0;
        public short AnalogRightX(int port) => 0;
        public short AnalogRightY(int port) => 0;

        public short PointerX(int port) => 0;
        public short PointerY(int port) => 0;
        public short PointerPressed(int port) => 0;
        public short PointerCount(int port) => 0;

        public bool SetRumbleState(int port, retro_rumble_effect effect, ushort strength) => true;
    }
}
