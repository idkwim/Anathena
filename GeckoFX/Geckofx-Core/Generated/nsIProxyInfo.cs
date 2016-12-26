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
// Generated by IDLImporter from file nsIProxyInfo.idl
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
    /// This interface identifies a proxy server.
    /// </summary>
    [ComImport()]
	[InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
	[Guid("9e557d99-7af0-4895-95b7-e6dba28c9ad9")]
	public interface nsIProxyInfo
	{
		
		/// <summary>
        /// This attribute specifies the hostname of the proxy server.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetHostAttribute([MarshalAs(UnmanagedType.LPStruct)] nsAUTF8StringBase aHost);
		
		/// <summary>
        /// This attribute specifies the port number of the proxy server.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		int GetPortAttribute();
		
		/// <summary>
        /// This attribute specifies the type of the proxy server as an ASCII string.
        ///
        /// Some special values for this attribute include (but are not limited to)
        /// the following:
        /// "http"     HTTP proxy (or SSL CONNECT for HTTPS)
        /// "socks"    SOCKS v5 proxy
        /// "socks4"   SOCKS v4 proxy
        /// "direct"   no proxy
        /// "unknown"  unknown proxy (see nsIProtocolProxyService::resolve)
        ///
        /// A future version of this interface may define additional types.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void GetTypeAttribute([MarshalAs(UnmanagedType.LPStruct)] nsACStringBase aType);
		
		/// <summary>
        /// This attribute specifies flags that modify the proxy type.  The value of
        /// this attribute is the bit-wise combination of the Proxy Flags defined
        /// below.  Any undefined bits are reserved for future use.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetFlagsAttribute();
		
		/// <summary>
        /// This attribute specifies flags that were used by nsIProxyProtocolService when
        /// creating this ProxyInfo element.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetResolveFlagsAttribute();
		
		/// <summary>
        /// This attribute specifies the failover timeout in seconds for this proxy.
        /// If a nsIProxyInfo is reported as failed via nsIProtocolProxyService::
        /// getFailoverForProxy, then the failed proxy will not be used again for this
        /// many seconds.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		uint GetFailoverTimeoutAttribute();
		
		/// <summary>
        /// This attribute specifies the proxy to failover to when this proxy fails.
        /// </summary>
		[return: MarshalAs(UnmanagedType.Interface)]
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		nsIProxyInfo GetFailoverProxyAttribute();
		
		/// <summary>
        /// This attribute specifies the proxy to failover to when this proxy fails.
        /// </summary>
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType=MethodCodeType.Runtime)]
		void SetFailoverProxyAttribute([MarshalAs(UnmanagedType.Interface)] nsIProxyInfo aFailoverProxy);
	}
	
	/// <summary>nsIProxyInfoConsts </summary>
	public class nsIProxyInfoConsts
	{
		
		// <summary>
        // This flag is set if the proxy is to perform name resolution itself.  If
        // this is the case, the hostname is used in some fashion, and we shouldn't
        // do any form of DNS lookup ourselves.
        // </summary>
		public const ushort TRANSPARENT_PROXY_RESOLVES_HOST = 1<<0;
	}
}
