// --------------------------------------------------------------------------------------------
// Version: MPL 1.1/GPL 2.0/LGPL 2.1
// 
// The contents of this file are subject to the Mozilla Public License Version
// 1.1 (the "License"); you may not use this file except in compliance with
// the License. You may obtain a copy of the License at
// http://www.mozilla.org/MPL/
// 
// Software distributed under the License is distributed on an "AS IS" basis,
// WITHOUT WARRANTY OF ANY KIND, either express or implied. See the License
// for the specific language governing rights and limitations under the
// License.
// 
// <remarks>
// Generated by IDLImporter from file nsIGZFileWriter.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
	using System;
	using System.Runtime.InteropServices;
	using System.Runtime.InteropServices.ComTypes;
	using System.Runtime.CompilerServices;
	
	
	/// <summary>
    /// A simple interface for writing to a .gz file.
    ///
    /// Note that the file that this interface produces has a different format than
    /// what you'd get if you compressed your data as a gzip stream and dumped the
    /// result to a file.
    ///
    /// The standard gunzip tool cannot decompress a raw gzip stream, but can handle
    /// the files produced by this interface.
    /// </summary>
	[ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("a256f26a-c603-459e-b5a4-53b4877f2cd8")]
	public interface nsIGZFileWriter
	{
		
		/// <summary>
        /// Initialize this object.  We'll write our gzip'ed data to the given file,
        /// overwriting its contents if the file exists.
        ///
        /// init() will return an error if called twice.  It's an error to call any
        /// other method on this interface without first calling init().
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Init([MarshalAs(UnmanagedType.Interface)] nsIFile file);
		
		/// <summary>
        /// Write the given string to the file.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Write([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase str);
		
		/// <summary>
        /// Close this nsIGZFileWriter.  Classes implementing nsIGZFileWriter will run
        /// this method when the underlying object is destroyed, so it's not strictly
        /// necessary to explicitly call it from your code.
        ///
        /// It's an error to call this method twice, and it's an error to call write()
        /// after finish() has been called.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void Finish();
	}
}
