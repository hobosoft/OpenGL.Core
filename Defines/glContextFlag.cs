﻿#region Copyright and License
// Copyright (c) 2013-2014 The Khronos Group Inc.
// Copyright (c) of C# port 2014 by Shinta <shintadono@googlemail.com>
//
// Permission is hereby granted, free of charge, to any person obtaining a
// copy of this software and/or associated documentation files (the
// "Materials"), to deal in the Materials without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Materials, and to
// permit persons to whom the Materials are furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be included
// in all copies or substantial portions of the Materials.
//
// THE MATERIALS ARE PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT.
// IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY
// CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT,
// TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE
// MATERIALS OR THE USE OR OTHER DEALINGS IN THE MATERIALS.
#endregion

using System;

namespace OpenGL.Core
{
	/// <summary>
	/// Flags returned by <see cref="O:OpenGL.Core.gl.GetIntegerv">gl.GetIntegerv</see> for <see cref="glGetIntegerParameter.CONTEXT_FLAGS"/>.
	/// </summary>
	[Flags]
	public enum glContextFlag : uint
	{
		/// <summary>
		/// Returned, if context is forward compatible.
		/// </summary>
		CONTEXT_FLAG_FORWARD_COMPATIBLE_BIT = 0x00000001,

		/// <summary>
		/// Returned, if context is a debug context.
		/// </summary>
		CONTEXT_FLAG_DEBUG_BIT = 0x00000002,

		/// <summary>
		/// Returned, if context is a robust context.
		/// </summary>
		CONTEXT_FLAG_ROBUST_ACCESS_BIT = 0x00000004,

		/// <summary>
		/// Returned, if context is a robust context.
		/// </summary>
		[Obsolete("Use glContextFlag.CONTEXT_FLAG_ROBUST_ACCESS_BIT instead.")]
		CONTEXT_FLAG_ROBUST_ACCESS_BIT_ARB = CONTEXT_FLAG_ROBUST_ACCESS_BIT,

		///// <summary>
		///// Returned, if no error behavior is enabled for this context.
		///// </summary>
		//[Obsolete("OpenGL ES extension: GL_KHR_no_error.")]
		//CONTEXT_FLAG_NO_ERROR_BIT_KHR = 0x00000008,

		///// <summary>
		///// Returned, if context is created in protected mode with an extension such as EGL_EXT_protected_context.
		///// </summary>
		//[Obsolete("OpenGL ES extension: GL_EXT_protected_context.")]
		//CONTEXT_FLAG_PROTECTED_CONTENT_BIT_EXT = 0x00000010,
	}
}
