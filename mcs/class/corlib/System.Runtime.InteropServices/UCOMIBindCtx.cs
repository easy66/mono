//
// System.Runtime.InteropServices.UCOMIBindCtx.cs
//
// Author:
//   Andreas Nahr (ClassDevelopment@A-SoftTech.com)
//
// Copyright (C) 2004-2005 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

namespace System.Runtime.InteropServices
{
#if NET_2_0
	[Obsolete]
#endif
	[ComImport]
	[Guid ("0000000e-0000-0000-c000-000000000046")]
	[InterfaceType (ComInterfaceType.InterfaceIsIUnknown)]
	public interface UCOMIBindCtx
	{
		void RegisterObjectBound ([MarshalAs(UnmanagedType.Interface)] object punk);
		void RevokeObjectBound ([MarshalAs(UnmanagedType.Interface)] object punk);
		void ReleaseBoundObjects ();
		void SetBindOptions ([In] ref BIND_OPTS pbindopts);
		void GetBindOptions (ref BIND_OPTS pbindopts);
		void GetRunningObjectTable (out UCOMIRunningObjectTable pprot);
		void RegisterObjectParam ([MarshalAs (UnmanagedType.LPWStr)] string pszKey, [MarshalAs (UnmanagedType.Interface)] object punk);
		void GetObjectParam ([MarshalAs (UnmanagedType.LPWStr)] string pszKey, [MarshalAs (UnmanagedType.Interface)] out object ppunk);
		void EnumObjectParam (out UCOMIEnumString ppenum);
		void RevokeObjectParam ([MarshalAs(UnmanagedType.LPWStr)] string pszKey);
	}
}
