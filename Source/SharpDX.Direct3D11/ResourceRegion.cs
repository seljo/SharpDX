﻿// Copyright (c) 2010-2012 SharpDX - Alexandre Mutel
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
namespace SharpDX.Direct3D11
{
    public partial struct ResourceRegion
    {
        /// <summary>
        /// Initiailize a new instance of <see cref="ResourceRegion"/> struct.
        /// </summary>
        /// <param name="left">Left coordinates</param>
        /// <param name="top">Top coordinates</param>
        /// <param name="front">Front coordinates</param>
        /// <param name="right">Right coordinates</param>
        /// <param name="bottom">Botoom coordinates</param>
        /// <param name="back">Back coordinates</param>
        public ResourceRegion(int left, int top, int front, int right, int bottom, int back)
        {
            Left = left;
            Top = top;
            Front = front;
            Right = right;
            Bottom = bottom;
            Back = back;
        }
    }
}