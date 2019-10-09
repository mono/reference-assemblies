[assembly:System.Reflection.AssemblyVersionAttribute("1.0.0.0")]
[assembly:System.Diagnostics.DebuggableAttribute(System.Diagnostics.DebuggableAttribute.DebuggingModes.Default | System.Diagnostics.DebuggableAttribute.DebuggingModes.DisableOptimizations | System.Diagnostics.DebuggableAttribute.DebuggingModes.EnableEditAndContinue | System.Diagnostics.DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly:System.Reflection.AssemblyCompanyAttribute("WebAssembly.Bindings")]
[assembly:System.Reflection.AssemblyConfigurationAttribute("Debug")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("1.0.0.0")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("1.0.0")]
[assembly:System.Reflection.AssemblyProductAttribute("WebAssembly.Bindings")]
[assembly:System.Reflection.AssemblyTitleAttribute("WebAssembly.Bindings")]
[assembly:System.Runtime.CompilerServices.CompilationRelaxationsAttribute(8)]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.Versioning.TargetFrameworkAttribute(".NETStandard,Version=v2.0", FrameworkDisplayName="")]
[assembly:System.Security.Permissions.SecurityPermissionAttribute(System.Security.Permissions.SecurityAction.RequestMinimum, SkipVerification=true)]
namespace WebAssembly
{
    public partial class AnyRef
    {
        internal AnyRef() { }
        public int JSHandle { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
    }
    public enum ConvertEnum
    {
        Default = 0,
        Numeric = 3,
        ToLower = 1,
        ToUpper = 2,
    }
    [System.AttributeUsageAttribute(System.AttributeTargets.Class | System.AttributeTargets.Field | System.AttributeTargets.Method | System.AttributeTargets.Property, AllowMultiple=true, Inherited=false)]
    public partial class ExportAttribute : System.Attribute
    {
        public ExportAttribute() { }
        public ExportAttribute(string contractName) { }
        public ExportAttribute(string contractName, System.Type contractType) { }
        public ExportAttribute(System.Type contractType) { }
        public string ContractName { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public System.Type ContractType { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public WebAssembly.ConvertEnum EnumValue { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } [System.Runtime.CompilerServices.CompilerGeneratedAttribute]set { } }
    }
    public partial interface IJSObject
    {
        int JSHandle { get; }
        int Length { get; }
    }
    public partial class JSException : System.Exception
    {
        public JSException(string msg) { }
    }
    public partial class JSObject : WebAssembly.AnyRef, System.IDisposable, WebAssembly.IJSObject
    {
        public JSObject() { }
        public bool IsDisposed { [System.Runtime.CompilerServices.CompilerGeneratedAttribute]get { throw null; } }
        public int Length { get { throw null; } set { } }
        public void Dispose() { }
        protected virtual void Dispose(bool disposing) { }
        public override bool Equals(object obj) { throw null; }
        ~JSObject() { }
        protected void FreeHandle() { }
        public override int GetHashCode() { throw null; }
        public object GetObjectProperty(string name) { throw null; }
        public bool HasOwnProperty(string prop) { throw null; }
        public object Invoke(string method, params object[] args) { throw null; }
        public bool PropertyIsEnumerable(string prop) { throw null; }
        public void SetObjectProperty(string name, object value, bool createIfNotExists = true, bool hasOwnProperty = false) { }
        public override string ToString() { throw null; }
    }
    public sealed partial class Runtime
    {
        public Runtime() { }
        public static System.Enum EnumFromExportContract(System.Type enumType, object value) { throw null; }
        public static object EnumToExportContract(System.Enum value) { throw null; }
        public static void FreeObject(object obj) { }
        public static object GetGlobalObject(string str = null) { throw null; }
        public static string InvokeJS(string str) { throw null; }
        public static int New(string hostClassName, params object[] _params) { throw null; }
        public static WebAssembly.JSObject NewJSObject(WebAssembly.JSObject js_func_ptr = null, params object[] _params) { throw null; }
        public static int New<T>(params object[] _params) { throw null; }
    }
}
namespace WebAssembly.Core
{
    public partial class Array : WebAssembly.Core.CoreObject
    {
        public Array(params object[] _params) : base (default(int)) { }
        public object this[int i] { get { throw null; } set { } }
        public int IndexOf(object searchElement, int fromIndex = 0) { throw null; }
        public int LastIndexOf(object searchElement) { throw null; }
        public int LastIndexOf(object searchElement, int endIndex) { throw null; }
        public int Pop() { throw null; }
        public int Push(params object[] elements) { throw null; }
        public object Shift() { throw null; }
        public int UnShift(params object[] elements) { throw null; }
    }
    public partial class ArrayBuffer : WebAssembly.Core.CoreObject
    {
        public ArrayBuffer() : base (default(int)) { }
        public ArrayBuffer(int length) : base (default(int)) { }
        public int ByteLength { get { throw null; } }
        public bool IsView { get { throw null; } }
        public WebAssembly.Core.ArrayBuffer Slice(int begin) { throw null; }
        public WebAssembly.Core.ArrayBuffer Slice(int begin, int end) { throw null; }
    }
    public abstract partial class CoreObject : WebAssembly.JSObject
    {
        protected CoreObject(int js_handle) { }
    }
    public sealed partial class Float32Array : WebAssembly.Core.TypedArray<WebAssembly.Core.Float32Array, float>
    {
        public Float32Array() { }
        public Float32Array(int length) { }
        public Float32Array(WebAssembly.Core.ArrayBuffer buffer) { }
        public Float32Array(WebAssembly.Core.ArrayBuffer buffer, int byteOffset) { }
        public Float32Array(WebAssembly.Core.ArrayBuffer buffer, int byteOffset, int length) { }
        public Float32Array(WebAssembly.Core.SharedArrayBuffer buffer) { }
        public Float32Array(WebAssembly.Core.SharedArrayBuffer buffer, int byteOffset) { }
        public Float32Array(WebAssembly.Core.SharedArrayBuffer buffer, int byteOffset, int length) { }
        public static implicit operator WebAssembly.Core.Float32Array (System.Span<float> span) { throw null; }
        public static implicit operator System.Span<float> (WebAssembly.Core.Float32Array typedarray) { throw null; }
    }
    public sealed partial class Float64Array : WebAssembly.Core.TypedArray<WebAssembly.Core.Float64Array, double>
    {
        public Float64Array() { }
        public Float64Array(int length) { }
        public Float64Array(WebAssembly.Core.ArrayBuffer buffer) { }
        public Float64Array(WebAssembly.Core.ArrayBuffer buffer, int byteOffset) { }
        public Float64Array(WebAssembly.Core.ArrayBuffer buffer, int byteOffset, int length) { }
        public Float64Array(WebAssembly.Core.SharedArrayBuffer buffer) { }
        public Float64Array(WebAssembly.Core.SharedArrayBuffer buffer, int byteOffset) { }
        public Float64Array(WebAssembly.Core.SharedArrayBuffer buffer, int byteOffset, int length) { }
        public static implicit operator WebAssembly.Core.Float64Array (System.Span<double> span) { throw null; }
        public static implicit operator System.Span<double> (WebAssembly.Core.Float64Array typedarray) { throw null; }
    }
    public partial class Function : WebAssembly.Core.CoreObject
    {
        public Function(params object[] args) : base (default(int)) { }
        public object Apply(object thisArg = null, object[] argsArray = null) { throw null; }
        public WebAssembly.Core.Function Bind(object thisArg = null, object[] argsArray = null) { throw null; }
        public object Call(object thisArg = null, params object[] argsArray) { throw null; }
    }
    public sealed partial class Int16Array : WebAssembly.Core.TypedArray<WebAssembly.Core.Int16Array, short>
    {
        public Int16Array() { }
        public Int16Array(int length) { }
        public Int16Array(WebAssembly.Core.ArrayBuffer buffer) { }
        public Int16Array(WebAssembly.Core.ArrayBuffer buffer, int byteOffset) { }
        public Int16Array(WebAssembly.Core.ArrayBuffer buffer, int byteOffset, int length) { }
        public Int16Array(WebAssembly.Core.SharedArrayBuffer buffer) { }
        public Int16Array(WebAssembly.Core.SharedArrayBuffer buffer, int byteOffset) { }
        public Int16Array(WebAssembly.Core.SharedArrayBuffer buffer, int byteOffset, int length) { }
        public static implicit operator WebAssembly.Core.Int16Array (System.Span<short> span) { throw null; }
        public static implicit operator System.Span<short> (WebAssembly.Core.Int16Array typedarray) { throw null; }
    }
    public sealed partial class Int32Array : WebAssembly.Core.TypedArray<WebAssembly.Core.Int32Array, int>
    {
        public Int32Array() { }
        public Int32Array(int length) { }
        public Int32Array(WebAssembly.Core.ArrayBuffer buffer) { }
        public Int32Array(WebAssembly.Core.ArrayBuffer buffer, int byteOffset) { }
        public Int32Array(WebAssembly.Core.ArrayBuffer buffer, int byteOffset, int length) { }
        public Int32Array(WebAssembly.Core.SharedArrayBuffer buffer) { }
        public Int32Array(WebAssembly.Core.SharedArrayBuffer buffer, int byteOffset) { }
        public Int32Array(WebAssembly.Core.SharedArrayBuffer buffer, int byteOffset, int length) { }
        public static implicit operator WebAssembly.Core.Int32Array (System.Span<int> span) { throw null; }
        public static implicit operator System.Span<int> (WebAssembly.Core.Int32Array typedarray) { throw null; }
    }
    public sealed partial class Int8Array : WebAssembly.Core.TypedArray<WebAssembly.Core.Int8Array, sbyte>
    {
        public Int8Array() { }
        public Int8Array(int length) { }
        public Int8Array(WebAssembly.Core.ArrayBuffer buffer) { }
        public Int8Array(WebAssembly.Core.ArrayBuffer buffer, int byteOffset) { }
        public Int8Array(WebAssembly.Core.ArrayBuffer buffer, int byteOffset, int length) { }
        public Int8Array(WebAssembly.Core.SharedArrayBuffer buffer) { }
        public Int8Array(WebAssembly.Core.SharedArrayBuffer buffer, int byteOffset) { }
        public Int8Array(WebAssembly.Core.SharedArrayBuffer buffer, int byteOffset, int length) { }
        public static implicit operator WebAssembly.Core.Int8Array (System.Span<sbyte> span) { throw null; }
        public static implicit operator System.Span<sbyte> (WebAssembly.Core.Int8Array typedarray) { throw null; }
    }
    public partial interface ITypedArray
    {
        WebAssembly.Core.ArrayBuffer Buffer { get; }
        int ByteLength { get; }
        int BytesPerElement { get; }
        string Name { get; }
        WebAssembly.Core.TypedArrayTypeCode GetTypedArrayType();
        void Set(WebAssembly.Core.Array array);
        void Set(WebAssembly.Core.Array array, int offset);
        void Set(WebAssembly.Core.ITypedArray typedArray);
        void Set(WebAssembly.Core.ITypedArray typedArray, int offset);
    }
    public partial interface ITypedArray<T, U> where U : struct
    {
        T Slice();
        T Slice(int begin);
        T Slice(int begin, int end);
        T SubArray();
        T SubArray(int begin);
        T SubArray(int begin, int end);
    }
    public partial class SharedArrayBuffer : WebAssembly.Core.CoreObject
    {
        public SharedArrayBuffer(int length) : base (default(int)) { }
        public int ByteLength { get { throw null; } }
        public WebAssembly.Core.SharedArrayBuffer Slice(int begin, int end) { throw null; }
    }
    public enum TypedArrayTypeCode
    {
        Float32Array = 13,
        Float64Array = 14,
        Int16Array = 7,
        Int32Array = 9,
        Int8Array = 5,
        Uint16Array = 8,
        Uint32Array = 10,
        Uint8Array = 6,
        Uint8ClampedArray = 15,
    }
    public abstract partial class TypedArray<T, U> : WebAssembly.Core.CoreObject, WebAssembly.Core.ITypedArray, WebAssembly.Core.ITypedArray<T, U> where U : struct
    {
        protected TypedArray() : base (default(int)) { }
        protected TypedArray(int length) : base (default(int)) { }
        protected TypedArray(WebAssembly.Core.ArrayBuffer buffer) : base (default(int)) { }
        protected TypedArray(WebAssembly.Core.ArrayBuffer buffer, int byteOffset) : base (default(int)) { }
        protected TypedArray(WebAssembly.Core.ArrayBuffer buffer, int byteOffset, int length) : base (default(int)) { }
        protected TypedArray(WebAssembly.Core.SharedArrayBuffer buffer) : base (default(int)) { }
        protected TypedArray(WebAssembly.Core.SharedArrayBuffer buffer, int byteOffset) : base (default(int)) { }
        protected TypedArray(WebAssembly.Core.SharedArrayBuffer buffer, int byteOffset, int length) : base (default(int)) { }
        public WebAssembly.Core.ArrayBuffer Buffer { get { throw null; } }
        public int ByteLength { get { throw null; } }
        public int BytesPerElement { get { throw null; } }
        public System.Nullable<U> this[int i] { get { throw null; } set { } }
        public string Name { get { throw null; } }
        public int CopyFrom(System.ReadOnlySpan<U> span) { throw null; }
        public int CopyTo(System.Span<U> span) { throw null; }
        public void Fill(U value) { }
        public void Fill(U value, int start) { }
        public void Fill(U value, int start, int end) { }
        public static T From(System.ReadOnlySpan<U> span) { throw null; }
        public WebAssembly.Core.TypedArrayTypeCode GetTypedArrayType() { throw null; }
        public void Set(WebAssembly.Core.Array array) { }
        public void Set(WebAssembly.Core.Array array, int offset) { }
        public void Set(WebAssembly.Core.ITypedArray typedArray) { }
        public void Set(WebAssembly.Core.ITypedArray typedArray, int offset) { }
        public T Slice() { throw null; }
        public T Slice(int begin) { throw null; }
        public T Slice(int begin, int end) { throw null; }
        public T SubArray() { throw null; }
        public T SubArray(int begin) { throw null; }
        public T SubArray(int begin, int end) { throw null; }
        public U[] ToArray() { throw null; }
        protected static void ValidateFromSource(System.ReadOnlySpan<U> source) { }
        protected static void ValidateFromSource(U[] source, int offset, int count) { }
        protected void ValidateSource(System.ReadOnlySpan<U> source) { }
        protected void ValidateTarget(System.Span<U> target) { }
    }
    public sealed partial class Uint16Array : WebAssembly.Core.TypedArray<WebAssembly.Core.Uint16Array, ushort>
    {
        public Uint16Array() { }
        public Uint16Array(int length) { }
        public Uint16Array(WebAssembly.Core.ArrayBuffer buffer) { }
        public Uint16Array(WebAssembly.Core.ArrayBuffer buffer, int byteOffset) { }
        public Uint16Array(WebAssembly.Core.ArrayBuffer buffer, int byteOffset, int length) { }
        public Uint16Array(WebAssembly.Core.SharedArrayBuffer buffer) { }
        public Uint16Array(WebAssembly.Core.SharedArrayBuffer buffer, int byteOffset) { }
        public Uint16Array(WebAssembly.Core.SharedArrayBuffer buffer, int byteOffset, int length) { }
        public static implicit operator WebAssembly.Core.Uint16Array (System.Span<ushort> span) { throw null; }
        public static implicit operator System.Span<ushort> (WebAssembly.Core.Uint16Array typedarray) { throw null; }
    }
    public sealed partial class Uint32Array : WebAssembly.Core.TypedArray<WebAssembly.Core.Uint32Array, uint>
    {
        public Uint32Array() { }
        public Uint32Array(int length) { }
        public Uint32Array(WebAssembly.Core.ArrayBuffer buffer) { }
        public Uint32Array(WebAssembly.Core.ArrayBuffer buffer, int byteOffset) { }
        public Uint32Array(WebAssembly.Core.ArrayBuffer buffer, int byteOffset, int length) { }
        public Uint32Array(WebAssembly.Core.SharedArrayBuffer buffer) { }
        public Uint32Array(WebAssembly.Core.SharedArrayBuffer buffer, int byteOffset) { }
        public Uint32Array(WebAssembly.Core.SharedArrayBuffer buffer, int byteOffset, int length) { }
        public static implicit operator WebAssembly.Core.Uint32Array (System.Span<uint> span) { throw null; }
        public static implicit operator System.Span<uint> (WebAssembly.Core.Uint32Array typedarray) { throw null; }
    }
    public sealed partial class Uint8Array : WebAssembly.Core.TypedArray<WebAssembly.Core.Uint8Array, byte>
    {
        public Uint8Array() { }
        public Uint8Array(int length) { }
        public Uint8Array(WebAssembly.Core.ArrayBuffer buffer) { }
        public Uint8Array(WebAssembly.Core.ArrayBuffer buffer, int byteOffset) { }
        public Uint8Array(WebAssembly.Core.ArrayBuffer buffer, int byteOffset, int length) { }
        public Uint8Array(WebAssembly.Core.SharedArrayBuffer buffer) { }
        public Uint8Array(WebAssembly.Core.SharedArrayBuffer buffer, int byteOffset) { }
        public Uint8Array(WebAssembly.Core.SharedArrayBuffer buffer, int byteOffset, int length) { }
        public static implicit operator WebAssembly.Core.Uint8Array (System.Span<byte> span) { throw null; }
        public static implicit operator System.Span<byte> (WebAssembly.Core.Uint8Array typedarray) { throw null; }
    }
    public sealed partial class Uint8ClampedArray : WebAssembly.Core.TypedArray<WebAssembly.Core.Uint8ClampedArray, byte>
    {
        public Uint8ClampedArray() { }
        public Uint8ClampedArray(int length) { }
        public Uint8ClampedArray(WebAssembly.Core.ArrayBuffer buffer) { }
        public Uint8ClampedArray(WebAssembly.Core.ArrayBuffer buffer, int byteOffset) { }
        public Uint8ClampedArray(WebAssembly.Core.ArrayBuffer buffer, int byteOffset, int length) { }
        public Uint8ClampedArray(WebAssembly.Core.SharedArrayBuffer buffer) { }
        public Uint8ClampedArray(WebAssembly.Core.SharedArrayBuffer buffer, int byteOffset) { }
        public Uint8ClampedArray(WebAssembly.Core.SharedArrayBuffer buffer, int byteOffset, int length) { }
        public static implicit operator WebAssembly.Core.Uint8ClampedArray (System.Span<byte> span) { throw null; }
        public static implicit operator System.Span<byte> (WebAssembly.Core.Uint8ClampedArray typedarray) { throw null; }
    }
}
namespace WebAssembly.Host
{
    public partial class HostObject : WebAssembly.Host.HostObjectBase
    {
        public HostObject(string hostName, params object[] _params) : base (default(int)) { }
    }
    public abstract partial class HostObjectBase : WebAssembly.JSObject, WebAssembly.Host.IHostObject
    {
        protected HostObjectBase(int js_handle) { }
    }
    public partial interface IHostObject
    {
    }
}
