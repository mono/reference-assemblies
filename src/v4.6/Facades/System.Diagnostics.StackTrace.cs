// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.1.0")]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(2))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Xamarin, Inc.")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("Copyright (c) 2015 Xamarin Inc. (http://www.xamarin.com)")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Diagnostics.StackTrace.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Diagnostics.StackTrace.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Diagnostics.StackTrace.dll")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.StackFrame))]
[assembly:System.Runtime.CompilerServices.TypeForwardedToAttribute(typeof(System.Diagnostics.StackTrace))]
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
namespace System.Diagnostics
{
    public static partial class StackFrameExtensions
    {
        [System.MonoTODOAttribute]
        public static System.IntPtr GetNativeImageBase(this System.Diagnostics.StackFrame stackFrame) { throw null; }
        [System.MonoTODOAttribute]
        public static System.IntPtr GetNativeIP(this System.Diagnostics.StackFrame stackFrame) { throw null; }
        [System.MonoTODOAttribute]
        public static bool HasILOffset(this System.Diagnostics.StackFrame stackFrame) { throw null; }
        [System.MonoTODOAttribute]
        public static bool HasMethod(this System.Diagnostics.StackFrame stackFrame) { throw null; }
        [System.MonoTODOAttribute]
        public static bool HasNativeImage(this System.Diagnostics.StackFrame stackFrame) { throw null; }
        [System.MonoTODOAttribute]
        public static bool HasSource(this System.Diagnostics.StackFrame stackFrame) { throw null; }
    }
}
