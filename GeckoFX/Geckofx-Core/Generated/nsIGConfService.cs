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
// Generated by IDLImporter from file nsIGConfService.idl
// 
// You should use these interfaces when you access the COM objects defined in the mentioned
// IDL/IDH file.
// </remarks>
// --------------------------------------------------------------------------------------------
namespace Gecko
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;


    /// <summary>
    ///This Source Code Form is subject to the terms of the Mozilla Public
    /// License, v. 2.0. If a copy of the MPL was not distributed with this
    /// file, You can obtain one at http://mozilla.org/MPL/2.0/. </summary>
    [ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("5009acae-6973-48c3-b6d6-52c692cc5d9d")]
	public interface nsIGConfService
	{
		
		/// <summary>
        ///Basic registry access </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool GetBool([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetString([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetInt([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		float GetFloat([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key);
		
		/// <summary>
        /// Use this to return any list items in GConf, this will return
        /// an array of UTF16 nsISupportsString's.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIArray GetStringList([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetBool([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key, [MarshalAs(UnmanagedType.U1)] bool value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetString([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetInt([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key, int value);
		
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFloat([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase key, float value);
		
		/// <summary>
        /// Look up the handler for a protocol under the
        /// /desktop/gnome/url-handlers hierarchy.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetAppForProtocol([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase scheme, [MarshalAs(UnmanagedType.U1)] ref bool enabled, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase retval);
		
		/// <summary>
        /// Check whether the handler for a scheme requires a terminal to run.
        /// </summary>
		[return: MarshalAs(UnmanagedType.U1)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		bool HandlerRequiresTerminal([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase scheme);
		
		/// <summary>
        /// Set the handler for a protocol, marking it as enabled.
        /// This removes any GnomeVFSMimeApp association for the protocol.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetAppForProtocol([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase scheme, [MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase command);
	}
}
