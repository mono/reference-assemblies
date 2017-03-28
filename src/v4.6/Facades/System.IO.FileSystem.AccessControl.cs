// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Xamarin, Inc.")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("Copyright (c) 2015 Xamarin Inc. (http://www.xamarin.com)")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.IO.FileSystem.AccessControl.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.IO.FileSystem.AccessControl.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.IO.FileSystem.AccessControl.dll")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.DirectoryObjectSecurity))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.DirectorySecurity))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.FileSecurity))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.FileSystemAccessRule))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.FileSystemAuditRule))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.FileSystemRights))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Security.AccessControl.FileSystemSecurity))]
namespace System
{
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoDocumentationNoteAttribute : System.MonoTODOAttribute
    {
        public MonoDocumentationNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoExtensionAttribute : System.MonoTODOAttribute
    {
        public MonoExtensionAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoInternalNoteAttribute : System.MonoTODOAttribute
    {
        public MonoInternalNoteAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoLimitationAttribute : System.MonoTODOAttribute
    {
        public MonoLimitationAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoNotSupportedAttribute : System.MonoTODOAttribute
    {
        public MonoNotSupportedAttribute(string comment) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true)]
    internal partial class MonoTODOAttribute : System.Attribute
    {
        public MonoTODOAttribute() { }
        public MonoTODOAttribute(string comment) { }
        public string Comment { get { throw null; } }
    }
}
namespace System.IO
{
    public static partial class FileSystemAclExtensions
    {
        public static System.Security.AccessControl.DirectorySecurity GetAccessControl(this System.IO.DirectoryInfo directoryInfo) { throw null; }
        public static System.Security.AccessControl.DirectorySecurity GetAccessControl(this System.IO.DirectoryInfo directoryInfo, System.Security.AccessControl.AccessControlSections includeSections) { throw null; }
        public static System.Security.AccessControl.FileSecurity GetAccessControl(this System.IO.FileInfo fileInfo) { throw null; }
        public static System.Security.AccessControl.FileSecurity GetAccessControl(this System.IO.FileInfo fileInfo, System.Security.AccessControl.AccessControlSections includeSections) { throw null; }
        public static System.Security.AccessControl.FileSecurity GetAccessControl(this System.IO.FileStream fileStream) { throw null; }
        public static void SetAccessControl(this System.IO.DirectoryInfo directoryInfo, System.Security.AccessControl.DirectorySecurity directorySecurity) { }
        public static void SetAccessControl(this System.IO.FileInfo fileInfo, System.Security.AccessControl.FileSecurity fileSecurity) { }
        public static void SetAccessControl(this System.IO.FileStream fileStream, System.Security.AccessControl.FileSecurity fileSecurity) { }
    }
}
