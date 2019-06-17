[assembly:System.Reflection.AssemblyVersionAttribute("1.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.Default | System.Diagnostics.DebuggableAttribute.DebuggingModes.DisableOptimizations | System.Diagnostics.DebuggableAttribute.DebuggingModes.EnableEditAndContinue | System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("WebAssembly.Net.Http")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("Debug")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("1.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("1.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("WebAssembly.Net.Http")]
[assembly:System.Reflection.AssemblyTitleAttribute("WebAssembly.Net.Http")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.Net.Http, PublicKey=002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.Versioning.TargetFrameworkAttribute(".NETStandard,Version=v2.0", FrameworkDisplayName="")]
namespace WebAssembly.Net.Http.HttpClient
{
    public enum FetchCredentialsOption
    {
        [WebAssembly.ExportAttribute(EnumValue=WebAssembly.ConvertEnum.ToLower)]
        Include = 2,
        [WebAssembly.ExportAttribute(EnumValue=WebAssembly.ConvertEnum.ToLower)]
        Omit = 0,
        [WebAssembly.ExportAttribute("same-origin")]
        SameOrigin = 1,
    }
    public enum RequestCache
    {
        [WebAssembly.ExportAttribute(EnumValue=WebAssembly.ConvertEnum.ToLower)]
        Default = 0,
        [WebAssembly.ExportAttribute("force-cache")]
        ForceCache = 4,
        [WebAssembly.ExportAttribute("no-cache")]
        NoCache = 3,
        [WebAssembly.ExportAttribute("no-store")]
        NoStore = 1,
        [WebAssembly.ExportAttribute("only-if-cached")]
        OnlyIfCached = 5,
        [WebAssembly.ExportAttribute(EnumValue=WebAssembly.ConvertEnum.ToLower)]
        Reload = 2,
    }
    public enum RequestMode
    {
        [WebAssembly.ExportAttribute(EnumValue=WebAssembly.ConvertEnum.ToLower)]
        Cors = 2,
        [WebAssembly.ExportAttribute(EnumValue=WebAssembly.ConvertEnum.ToLower)]
        Navigate = 3,
        [WebAssembly.ExportAttribute("no-cors")]
        NoCors = 1,
        [WebAssembly.ExportAttribute("same-origin")]
        SameOrigin = 0,
    }
    public partial class WasmHttpMessageHandler : System.Net.Http.HttpMessageHandler
    {
        public WasmHttpMessageHandler() { }
        public static WebAssembly.Net.Http.HttpClient.RequestCache Cache { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public static WebAssembly.Net.Http.HttpClient.FetchCredentialsOption DefaultCredentials { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public static WebAssembly.Net.Http.HttpClient.RequestMode Mode { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public static bool StreamingEnabled { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
        public static bool StreamingSupported { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        [System.Diagnostics.DebuggerStepThroughAttribute]
        protected override System.Threading.Tasks.Task<System.Net.Http.HttpResponseMessage> SendAsync(System.Net.Http.HttpRequestMessage request, System.Threading.CancellationToken cancellationToken) { throw null; }
    }
}
