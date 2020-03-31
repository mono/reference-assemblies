[assembly:System.Reflection.AssemblyVersionAttribute("1.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.Default | System.Diagnostics.DebuggableAttribute.DebuggingModes.DisableOptimizations | System.Diagnostics.DebuggableAttribute.DebuggingModes.EnableEditAndContinue | System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("System.Net.Http.WebAssemblyHttpHandler")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("1.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("1.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("System.Net.Http.WebAssemblyHttpHandler")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Net.Http.WebAssemblyHttpHandler")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.Net.Http, PublicKey=002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.Versioning.TargetFrameworkAttribute(".NETStandard,Version=v2.0", FrameworkDisplayName="")]
namespace System.Net.Http
{
    public enum RequestCache
    {
        Default = 0,
        NoStore = 1,
        Reload = 2,
        NoCache = 3,
        ForceCache = 4,
        OnlyIfCached = 5,
    }
    public enum RequestCredentials
    {
        Omit = 0,
        SameOrigin = 1,
        Include = 2,
    }
    public enum RequestMode
    {
        SameOrigin = 0,
        NoCors = 1,
        Cors = 2,
        Navigate = 3,
    }
    public partial class WebAssemblyHttpHandler : System.Net.Http.HttpMessageHandler
    {
        public WebAssemblyHttpHandler() { }
        public string Integrity { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public System.Net.Http.RequestCache? RequestCache { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public System.Net.Http.RequestCredentials? RequestCredentials { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public System.Net.Http.RequestMode? RequestMode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        public bool StreamingEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute] get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute] set { } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        protected override System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
}
