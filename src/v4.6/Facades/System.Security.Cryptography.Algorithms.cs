// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.2.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Xamarin, Inc.")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("Copyright (c) 2016 Xamarin Inc. (http://www.xamarin.com)")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Security.Cryptography.Algorithms.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Security.Cryptography.Algorithms.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Security.Cryptography.Algorithms.dll")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.Aes))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.DeriveBytes))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.ECDsa))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.HMACMD5))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.HMACSHA1))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.HMACSHA256))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.HMACSHA384))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.HMACSHA512))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.MD5))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.RandomNumberGenerator))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.Rfc2898DeriveBytes))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.RSA))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.RSAEncryptionPadding))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.RSAEncryptionPaddingMode))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.RSAParameters))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.RSASignaturePadding))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.RSASignaturePaddingMode))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.SHA1))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.SHA256))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.SHA384))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.SHA512))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.Cryptography.TripleDES))]
namespace System.Security.Cryptography
{
    public sealed partial class IncrementalHash : System.IDisposable
    {
        internal IncrementalHash() { }
        public System.Security.Cryptography.HashAlgorithmName AlgorithmName { get { throw null; } }
        public void AppendData(byte[] data) { }
        public void AppendData(byte[] data, int offset, int count) { }
        public static System.Security.Cryptography.IncrementalHash CreateHash(System.Security.Cryptography.HashAlgorithmName hashAlgorithm) { throw null; }
        public static System.Security.Cryptography.IncrementalHash CreateHMAC(System.Security.Cryptography.HashAlgorithmName hashAlgorithm, byte[] key) { throw null; }
        public void Dispose() { }
        public byte[] GetHashAndReset() { throw null; }
    }
}
