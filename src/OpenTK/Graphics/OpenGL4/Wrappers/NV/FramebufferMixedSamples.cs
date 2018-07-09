//
// The Open Toolkit Library License
//
// Copyright (c) 2006 - 2015 Stefanos Apostolopoulos for the Open Toolkit Library
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//

using System;
using System.Runtime.InteropServices;
using System.Text;

namespace OpenTK.Graphics.OpenGL4
{
    public sealed partial class GL
    {
        /// <summary>
        /// Contains native bindings to functions in the category "FramebufferMixedSamples" in the extension "NV".
        /// </summary>
        public static partial class NV
        {
            /// <summary>
            /// [requires: NV_framebuffer_mixed_samples]
            /// </summary>
            /// <param name="components">
            /// </param>
            [AutoGenerated(Category = "NV_framebuffer_mixed_samples", Version = "", EntryPoint = "glCoverageModulationNV")]
            public static void CoverageModulation(OpenTK.Graphics.OpenGL4.ColorComponent components)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_framebuffer_mixed_samples]
            /// </summary>
            /// <param name="n">
            /// </param>
            /// <param name="v">
            /// [length: n]
            /// </param>
            [AutoGenerated(Category = "NV_framebuffer_mixed_samples", Version = "", EntryPoint = "glCoverageModulationTableNV")]
            public static void CoverageModulationTable(int n, [CountAttribute(Parameter = "n")] float[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_framebuffer_mixed_samples]
            /// </summary>
            /// <param name="n">
            /// </param>
            /// <param name="v">
            /// [length: n]
            /// </param>
            [AutoGenerated(Category = "NV_framebuffer_mixed_samples", Version = "", EntryPoint = "glCoverageModulationTableNV")]
            public static void CoverageModulationTable(int n, [CountAttribute(Parameter = "n")] ref float v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_framebuffer_mixed_samples]
            /// </summary>
            /// <param name="n">
            /// </param>
            /// <param name="v">
            /// [length: n]
            /// </param>
            [AutoGenerated(Category = "NV_framebuffer_mixed_samples", Version = "", EntryPoint = "glCoverageModulationTableNV")]
            public static unsafe void CoverageModulationTable(int n, [CountAttribute(Parameter = "n")] float* v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_framebuffer_mixed_samples]
            /// </summary>
            /// <returns></returns>
            [AutoGenerated(Category = "NV_framebuffer_mixed_samples", Version = "", EntryPoint = "glGetCoverageModulationTableNV")]
            public static float GetCoverageModulationTable()
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_framebuffer_mixed_samples]
            /// </summary>
            /// <param name="bufsize">
            /// </param>
            /// <param name="v">
            /// </param>
            [AutoGenerated(Category = "NV_framebuffer_mixed_samples", Version = "", EntryPoint = "glGetCoverageModulationTableNV")]
            public static void GetCoverageModulationTable(int bufsize, [OutAttribute] float[] v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_framebuffer_mixed_samples]
            /// </summary>
            /// <param name="bufsize">
            /// </param>
            /// <param name="v">
            /// </param>
            [AutoGenerated(Category = "NV_framebuffer_mixed_samples", Version = "", EntryPoint = "glGetCoverageModulationTableNV")]
            public static void GetCoverageModulationTable(int bufsize, [OutAttribute] out float v)
            {
                throw new BindingsNotRewrittenException();
            }

            /// <summary>
            /// [requires: NV_framebuffer_mixed_samples]
            /// </summary>
            /// <param name="bufsize">
            /// </param>
            /// <param name="v">
            /// </param>
            [AutoGenerated(Category = "NV_framebuffer_mixed_samples", Version = "", EntryPoint = "glGetCoverageModulationTableNV")]
            public static unsafe void GetCoverageModulationTable(int bufsize, [OutAttribute] float* v)
            {
                throw new BindingsNotRewrittenException();
            }

            #pragma warning disable SA1300 // Element should begin with an upper-case letter

            [Slot(159)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern void glCoverageModulationNV(OpenTK.Graphics.OpenGL4.ColorComponent components);

            [Slot(160)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glCoverageModulationTableNV(int n, [CountAttribute(Parameter = "n")] float* v);

            [Slot(350)]
            [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
            private static extern unsafe void glGetCoverageModulationTableNV(int bufsize, [OutAttribute] float* v);
        }
    }
}
