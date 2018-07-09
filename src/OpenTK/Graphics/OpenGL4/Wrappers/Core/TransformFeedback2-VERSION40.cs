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
        /// [requires: v4.0 or ARB_transform_feedback2|VERSION_4_0]
        /// Bind a transform feedback object.
        /// </summary>
        /// <param name="target">
        /// Specifies the target to which to bind the transform feedback object id. target must be TransformFeedback.
        /// </param>
        /// <param name="id">
        /// Specifies the name of a transform feedback object reserved by glGenTransformFeedbacks.
        /// </param>
        [AutoGenerated(Category = "ARB_transform_feedback2|VERSION_4_0", Version = "4.0", EntryPoint = "glBindTransformFeedback")]
        public static void BindTransformFeedback(OpenTK.Graphics.OpenGL4.TransformFeedbackTarget target, uint id)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_transform_feedback2|VERSION_4_0]
        /// Delete transform feedback objects.
        /// </summary>
        /// <param name="ids">
        /// [length: n]
        /// Specifies an array of names of transform feedback objects to delete.
        /// </param>
        [AutoGenerated(Category = "ARB_transform_feedback2|VERSION_4_0", Version = "4.0", EntryPoint = "glDeleteTransformFeedbacks")]
        public static void DeleteTransformFeedback([CountAttribute(Parameter = "n")] uint ids)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_transform_feedback2|VERSION_4_0]
        /// Delete transform feedback objects.
        /// </summary>
        /// <param name="n">
        /// Specifies the number of transform feedback objects to delete.
        /// </param>
        /// <param name="ids">
        /// [length: n]
        /// Specifies an array of names of transform feedback objects to delete.
        /// </param>
        [AutoGenerated(Category = "ARB_transform_feedback2|VERSION_4_0", Version = "4.0", EntryPoint = "glDeleteTransformFeedbacks")]
        public static void DeleteTransformFeedbacks(int n, [CountAttribute(Parameter = "n")] uint[] ids)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_transform_feedback2|VERSION_4_0]
        /// Delete transform feedback objects.
        /// </summary>
        /// <param name="n">
        /// Specifies the number of transform feedback objects to delete.
        /// </param>
        /// <param name="ids">
        /// [length: n]
        /// Specifies an array of names of transform feedback objects to delete.
        /// </param>
        [AutoGenerated(Category = "ARB_transform_feedback2|VERSION_4_0", Version = "4.0", EntryPoint = "glDeleteTransformFeedbacks")]
        public static void DeleteTransformFeedbacks(int n, [CountAttribute(Parameter = "n")] ref uint ids)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_transform_feedback2|VERSION_4_0]
        /// Delete transform feedback objects.
        /// </summary>
        /// <param name="n">
        /// Specifies the number of transform feedback objects to delete.
        /// </param>
        /// <param name="ids">
        /// [length: n]
        /// Specifies an array of names of transform feedback objects to delete.
        /// </param>
        [AutoGenerated(Category = "ARB_transform_feedback2|VERSION_4_0", Version = "4.0", EntryPoint = "glDeleteTransformFeedbacks")]
        public static unsafe void DeleteTransformFeedbacks(int n, [CountAttribute(Parameter = "n")] uint* ids)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_transform_feedback2|VERSION_4_0]
        /// Render primitives using a count derived from a transform feedback object.
        /// </summary>
        /// <param name="mode">
        /// Specifies what kind of primitives to render. Symbolic constants Points, LineStrip, LineLoop, Lines, LineStripAdjacency, LinesAdjacency, TriangleStrip, TriangleFan, Triangles, TriangleStripAdjacency, TrianglesAdjacency, and Patches are accepted.
        /// </param>
        /// <param name="id">
        /// Specifies the name of a transform feedback object from which to retrieve a primitive count.
        /// </param>
        [AutoGenerated(Category = "ARB_transform_feedback2|VERSION_4_0", Version = "4.0", EntryPoint = "glDrawTransformFeedback")]
        public static void DrawTransformFeedback(OpenTK.Graphics.OpenGL4.PrimitiveType mode, uint id)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_transform_feedback2|VERSION_4_0]
        /// Reserve transform feedback object names.
        /// </summary>
        /// <returns></returns>
        [AutoGenerated(Category = "ARB_transform_feedback2|VERSION_4_0", Version = "4.0", EntryPoint = "glGenTransformFeedbacks")]
        public static uint GenTransformFeedback()
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_transform_feedback2|VERSION_4_0]
        /// Reserve transform feedback object names.
        /// </summary>
        /// <param name="n">
        /// Specifies the number of transform feedback object names to reserve.
        /// </param>
        /// <param name="ids">
        /// [length: n]
        /// Specifies an array of into which the reserved names will be written.
        /// </param>
        [AutoGenerated(Category = "ARB_transform_feedback2|VERSION_4_0", Version = "4.0", EntryPoint = "glGenTransformFeedbacks")]
        public static void GenTransformFeedbacks(int n, [OutAttribute, CountAttribute(Parameter = "n")] uint[] ids)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_transform_feedback2|VERSION_4_0]
        /// Reserve transform feedback object names.
        /// </summary>
        /// <param name="n">
        /// Specifies the number of transform feedback object names to reserve.
        /// </param>
        /// <param name="ids">
        /// [length: n]
        /// Specifies an array of into which the reserved names will be written.
        /// </param>
        [AutoGenerated(Category = "ARB_transform_feedback2|VERSION_4_0", Version = "4.0", EntryPoint = "glGenTransformFeedbacks")]
        public static void GenTransformFeedbacks(int n, [OutAttribute, CountAttribute(Parameter = "n")] out uint ids)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_transform_feedback2|VERSION_4_0]
        /// Reserve transform feedback object names.
        /// </summary>
        /// <param name="n">
        /// Specifies the number of transform feedback object names to reserve.
        /// </param>
        /// <param name="ids">
        /// [length: n]
        /// Specifies an array of into which the reserved names will be written.
        /// </param>
        [AutoGenerated(Category = "ARB_transform_feedback2|VERSION_4_0", Version = "4.0", EntryPoint = "glGenTransformFeedbacks")]
        public static unsafe void GenTransformFeedbacks(int n, [OutAttribute, CountAttribute(Parameter = "n")] uint* ids)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_transform_feedback2|VERSION_4_0]
        /// Determine if a name corresponds to a transform feedback object.
        /// </summary>
        /// <param name="id">
        /// Specifies a value that may be the name of a transform feedback object.
        /// </param>
        /// <returns></returns>
        [AutoGenerated(Category = "ARB_transform_feedback2|VERSION_4_0", Version = "4.0", EntryPoint = "glIsTransformFeedback")]
        public static bool IsTransformFeedback(uint id)
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_transform_feedback2|VERSION_4_0]
        /// Pause transform feedback operations.
        /// </summary>
        [AutoGenerated(Category = "ARB_transform_feedback2|VERSION_4_0", Version = "4.0", EntryPoint = "glPauseTransformFeedback")]
        public static void PauseTransformFeedback()
        {
            throw new BindingsNotRewrittenException();
        }

        /// <summary>
        /// [requires: v4.0 or ARB_transform_feedback2|VERSION_4_0]
        /// Resume transform feedback operations.
        /// </summary>
        [AutoGenerated(Category = "ARB_transform_feedback2|VERSION_4_0", Version = "4.0", EntryPoint = "glResumeTransformFeedback")]
        public static void ResumeTransformFeedback()
        {
            throw new BindingsNotRewrittenException();
        }

        #pragma warning disable SA1300 // Element should begin with an upper-case letter

        [Slot(33)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glBindTransformFeedback(OpenTK.Graphics.OpenGL4.TransformFeedbackTarget target, uint id);

        [Slot(210)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glDeleteTransformFeedbacks(int n, [CountAttribute(Parameter = "n")] uint* ids);

        [Slot(254)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glDrawTransformFeedback(OpenTK.Graphics.OpenGL4.PrimitiveType mode, uint id);

        [Slot(316)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern unsafe void glGenTransformFeedbacks(int n, [OutAttribute, CountAttribute(Parameter = "n")] uint* ids);

        [Slot(639)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern byte glIsTransformFeedback(uint id);

        [Slot(816)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glPauseTransformFeedback();

        [Slot(996)]
        [DllImport(Library, ExactSpelling = true, CallingConvention = CallingConvention.Winapi)]
        private static extern void glResumeTransformFeedback();
    }
}
