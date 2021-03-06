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

namespace OpenGL.Core
{
	/// <summary>
	/// nterpolation filter value for <see cref="glTextureParameter.TEXTURE_MIN_FILTER"/> and
	/// <see cref="glTextureParameter.TEXTURE_MAG_FILTER"/>. Used as value by <see cref="gl.BlitFramebuffer"/>,
	/// <see cref="O:OpenGL.Core.gl.TexParameteri">gl.TexParameteri</see> and
	/// <see cref="O:OpenGL.Core.gl.GetTexParameteriv">gl.GetTexParameter</see>.
	/// </summary>
	public enum glFilter : uint
	{
		/// <summary>
		/// Filter to nearest pixel.
		/// </summary>
		NEAREST = 0x2600,

		/// <summary>
		/// Interpolate pixels linear.
		/// </summary>
		LINEAR = 0x2601,

		/// <summary>
		/// Filter to nearest pixel for main image and mipmaps.
		/// Used only with <see cref="glTextureParameter.TEXTURE_MIN_FILTER"/>.
		/// </summary>
		NEAREST_MIPMAP_NEAREST = 0x2700,

		/// <summary>
		/// Interpolate pixels linear for the main image and filter to nearest pixel for mipmaps.
		/// Used only with <see cref="glTextureParameter.TEXTURE_MIN_FILTER"/>.
		/// </summary>
		LINEAR_MIPMAP_NEAREST = 0x2701,

		/// <summary>
		/// Interpolate pixels linear for mipmaps and filter to nearest pixel for the main image.
		/// Used only with <see cref="glTextureParameter.TEXTURE_MIN_FILTER"/>.
		/// </summary>
		NEAREST_MIPMAP_LINEAR = 0x2702,

		/// <summary>
		/// Interpolate pixels linear for main image and mipmaps.
		/// Used only with <see cref="glTextureParameter.TEXTURE_MIN_FILTER"/>.
		/// </summary>
		LINEAR_MIPMAP_LINEAR = 0x2703,
	}
}
