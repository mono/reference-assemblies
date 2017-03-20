// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

[assembly:System.Reflection.AssemblyVersionAttribute("4.0.0.0")]
[assembly:System.CLSCompliantAttribute(true)]
[assembly:System.Diagnostics.DebuggableAttribute((System.Diagnostics.DebuggableAttribute.DebuggingModes)(258))]
[assembly:System.Reflection.AssemblyCompanyAttribute("Mono development team")]
[assembly:System.Reflection.AssemblyCopyrightAttribute("(c) Various Mono authors")]
[assembly:System.Reflection.AssemblyDefaultAliasAttribute("System.Configuration.dll")]
[assembly:System.Reflection.AssemblyDescriptionAttribute("System.Configuration.dll")]
[assembly:System.Reflection.AssemblyFileVersionAttribute("4.0.30319.17020")]
[assembly:System.Reflection.AssemblyInformationalVersionAttribute("4.0.30319.17020")]
[assembly:System.Reflection.AssemblyProductAttribute("Mono Common Language Infrastructure")]
[assembly:System.Reflection.AssemblyTitleAttribute("System.Configuration.dll")]
[assembly:System.Resources.NeutralResourcesLanguageAttribute("en-US")]
[assembly:System.Resources.SatelliteContractVersionAttribute("4.0.0.0")]
[assembly:System.Runtime.CompilerServices.InternalsVisibleToAttribute("System.Web, PublicKey=002400000480000094000000060200000024000052534131000400000100010007d1fa57c4aed9f0a32e84aa0faefd0de9e8fd6aec8f87fb03766c834c99921eb23be79ad9d5dcc1dd9ad236132102900b723cf980957fc4e177108fc607774f29e8320e92ea05ece4e821c0a5efe8f1645c4c0c93c1ab99285d622caa652c1dfad63d745d6f2de5f17e5eaf0fc4963d261c8a12436518206dc093344d5ad293")]
[assembly:System.Runtime.CompilerServices.ReferenceAssemblyAttribute]
[assembly:System.Runtime.CompilerServices.RuntimeCompatibilityAttribute(WrapNonExceptionThrows=true)]
[assembly:System.Runtime.InteropServices.ComCompatibleVersionAttribute(1, 0, 3300, 0)]
[assembly:System.Runtime.InteropServices.ComVisibleAttribute(false)]
[assembly:System.Security.AllowPartiallyTrustedCallersAttribute]
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
namespace System.Configuration
{
    public sealed partial class AppSettingsSection : System.Configuration.ConfigurationSection
    {
        public AppSettingsSection() { }
        [System.Configuration.ConfigurationPropertyAttribute("file", DefaultValue="")]
        public string File { get { throw null; } set { } }
        protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("", Options=(System.Configuration.ConfigurationPropertyOptions)(1))]
        public System.Configuration.KeyValueConfigurationCollection Settings { get { throw null; } }
        [System.MonoInternalNoteAttribute("file path?  do we use a System.Configuration api for opening it?  do we keep it open?  do we open it writable?")]
        protected internal override void DeserializeElement(System.Xml.XmlReader reader, bool serializeCollectionKey) { }
        protected internal override object GetRuntimeObject() { throw null; }
        protected internal override bool IsModified() { throw null; }
        protected internal override void Reset(System.Configuration.ConfigurationElement parentSection) { }
        [System.MonoTODOAttribute]
        protected internal override string SerializeSection(System.Configuration.ConfigurationElement parent, string name, System.Configuration.ConfigurationSaveMode mode) { throw null; }
    }
    public sealed partial class CallbackValidator : System.Configuration.ConfigurationValidatorBase
    {
        public CallbackValidator(System.Type type, System.Configuration.ValidatorCallback callback) { }
        public override bool CanValidate(System.Type type) { throw null; }
        public override void Validate(object value) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
    public sealed partial class CallbackValidatorAttribute : System.Configuration.ConfigurationValidatorAttribute
    {
        public CallbackValidatorAttribute() { }
        public string CallbackMethodName { get { throw null; } set { } }
        public System.Type Type { get { throw null; } set { } }
        public override System.Configuration.ConfigurationValidatorBase ValidatorInstance { get { throw null; } }
    }
    public sealed partial class CommaDelimitedStringCollection : System.Collections.Specialized.StringCollection
    {
        public CommaDelimitedStringCollection() { }
        public bool IsModified { get { throw null; } }
        public new bool IsReadOnly { get { throw null; } }
        public new string this[int index] { get { throw null; } set { } }
        public new void Add(string value) { }
        public new void AddRange(string[] range) { }
        public new void Clear() { }
        public System.Configuration.CommaDelimitedStringCollection Clone() { throw null; }
        public new void Insert(int index, string value) { }
        public new void Remove(string value) { }
        public void SetReadOnly() { }
        public override string ToString() { throw null; }
    }
    public sealed partial class CommaDelimitedStringCollectionConverter : System.Configuration.ConfigurationConverterBase
    {
        public CommaDelimitedStringCollectionConverter() { }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type type) { throw null; }
    }
    public sealed partial class Configuration
    {
        internal Configuration() { }
        public System.Configuration.AppSettingsSection AppSettings { get { throw null; } }
        public System.Configuration.ConnectionStringsSection ConnectionStrings { get { throw null; } }
        public System.Configuration.ContextInformation EvaluationContext { get { throw null; } }
        public string FilePath { get { throw null; } }
        public bool HasFile { get { throw null; } }
        public System.Configuration.ConfigurationLocationCollection Locations { get { throw null; } }
        public bool NamespaceDeclared { get { throw null; } set { } }
        public System.Configuration.ConfigurationSectionGroup RootSectionGroup { get { throw null; } }
        public System.Configuration.ConfigurationSectionGroupCollection SectionGroups { get { throw null; } }
        public System.Configuration.ConfigurationSectionCollection Sections { get { throw null; } }
        public System.Configuration.ConfigurationSection GetSection(string path) { throw null; }
        public System.Configuration.ConfigurationSectionGroup GetSectionGroup(string path) { throw null; }
        public void Save() { }
        public void Save(System.Configuration.ConfigurationSaveMode mode) { }
        public void Save(System.Configuration.ConfigurationSaveMode mode, bool forceUpdateAll) { }
        public void SaveAs(string filename) { }
        public void SaveAs(string filename, System.Configuration.ConfigurationSaveMode mode) { }
        [System.MonoInternalNoteAttribute("Detect if file has changed")]
        public void SaveAs(string filename, System.Configuration.ConfigurationSaveMode mode, bool forceUpdateAll) { }
    }
    public enum ConfigurationAllowDefinition
    {
        Everywhere = 300,
        MachineOnly = 0,
        MachineToApplication = 200,
        MachineToWebRoot = 100,
    }
    public enum ConfigurationAllowExeDefinition
    {
        MachineOnly = 0,
        MachineToApplication = 100,
        MachineToLocalUser = 300,
        MachineToRoamingUser = 200,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(132))]
    public sealed partial class ConfigurationCollectionAttribute : System.Attribute
    {
        public ConfigurationCollectionAttribute(System.Type itemType) { }
        public string AddItemName { get { throw null; } set { } }
        public string ClearItemsName { get { throw null; } set { } }
        public System.Configuration.ConfigurationElementCollectionType CollectionType { get { throw null; } set { } }
        [System.MonoInternalNoteAttribute("Do something with this in ConfigurationElementCollection")]
        public System.Type ItemType { get { throw null; } }
        public string RemoveItemName { get { throw null; } set { } }
    }
    public abstract partial class ConfigurationConverterBase : System.ComponentModel.TypeConverter
    {
        protected ConfigurationConverterBase() { }
        public override bool CanConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Type type) { throw null; }
        public override bool CanConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Type type) { throw null; }
    }
    public abstract partial class ConfigurationElement
    {
        protected ConfigurationElement() { }
        public System.Configuration.ElementInformation ElementInformation { get { throw null; } }
        protected internal virtual System.Configuration.ConfigurationElementProperty ElementProperty { get { throw null; } }
        protected System.Configuration.ContextInformation EvaluationContext { get { throw null; } }
        protected internal object this[System.Configuration.ConfigurationProperty property] { get { throw null; } set { } }
        protected internal object this[string property_name] { get { throw null; } set { } }
        public System.Configuration.ConfigurationLockCollection LockAllAttributesExcept { get { throw null; } }
        public System.Configuration.ConfigurationLockCollection LockAllElementsExcept { get { throw null; } }
        public System.Configuration.ConfigurationLockCollection LockAttributes { get { throw null; } }
        public System.Configuration.ConfigurationLockCollection LockElements { get { throw null; } }
        public bool LockItem { get { throw null; } set { } }
        protected internal virtual System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        protected internal virtual void DeserializeElement(System.Xml.XmlReader reader, bool serializeCollectionKey) { }
        public override bool Equals(object compareTo) { throw null; }
        public override int GetHashCode() { throw null; }
        protected internal virtual void Init() { }
        protected internal virtual void InitializeDefault() { }
        protected internal virtual bool IsModified() { throw null; }
        public virtual bool IsReadOnly() { throw null; }
        [System.MonoTODOAttribute]
        protected virtual void ListErrors(System.Collections.IList list) { }
        protected virtual bool OnDeserializeUnrecognizedAttribute(string name, string value) { throw null; }
        protected virtual bool OnDeserializeUnrecognizedElement(string element, System.Xml.XmlReader reader) { throw null; }
        protected virtual object OnRequiredPropertyNotFound(string name) { throw null; }
        protected virtual void PostDeserialize() { }
        protected virtual void PreSerialize(System.Xml.XmlWriter writer) { }
        protected internal virtual void Reset(System.Configuration.ConfigurationElement parentElement) { }
        protected internal virtual void ResetModified() { }
        protected internal virtual bool SerializeElement(System.Xml.XmlWriter writer, bool serializeCollectionKey) { throw null; }
        protected internal virtual bool SerializeToXmlElement(System.Xml.XmlWriter writer, string elementName) { throw null; }
        [System.MonoTODOAttribute]
        protected void SetPropertyValue(System.Configuration.ConfigurationProperty prop, object value, bool ignoreLocks) { }
        protected internal virtual void SetReadOnly() { }
        protected internal virtual void Unmerge(System.Configuration.ConfigurationElement source, System.Configuration.ConfigurationElement parent, System.Configuration.ConfigurationSaveMode updateMode) { }
    }
    [System.Diagnostics.DebuggerDisplayAttribute("Count = {Count}")]
    public abstract partial class ConfigurationElementCollection : System.Configuration.ConfigurationElement, System.Collections.ICollection, System.Collections.IEnumerable
    {
        protected ConfigurationElementCollection() { }
        protected ConfigurationElementCollection(System.Collections.IComparer comparer) { }
        protected internal string AddElementName { get { throw null; } set { } }
        protected internal string ClearElementName { get { throw null; } set { } }
        public virtual System.Configuration.ConfigurationElementCollectionType CollectionType { get { throw null; } }
        public int Count { get { throw null; } }
        protected virtual string ElementName { get { throw null; } }
        public bool EmitClear { get { throw null; } set { } }
        public bool IsSynchronized { get { throw null; } }
        protected internal string RemoveElementName { get { throw null; } set { } }
        public object SyncRoot { get { throw null; } }
        protected virtual bool ThrowOnDuplicate { get { throw null; } }
        protected virtual void BaseAdd(System.Configuration.ConfigurationElement element) { }
        protected void BaseAdd(System.Configuration.ConfigurationElement element, bool throwIfExists) { }
        protected virtual void BaseAdd(int index, System.Configuration.ConfigurationElement element) { }
        protected internal void BaseClear() { }
        protected internal System.Configuration.ConfigurationElement BaseGet(int index) { throw null; }
        protected internal System.Configuration.ConfigurationElement BaseGet(object key) { throw null; }
        protected internal object[] BaseGetAllKeys() { throw null; }
        protected internal object BaseGetKey(int index) { throw null; }
        protected int BaseIndexOf(System.Configuration.ConfigurationElement element) { throw null; }
        protected internal bool BaseIsRemoved(object key) { throw null; }
        protected internal void BaseRemove(object key) { }
        protected internal void BaseRemoveAt(int index) { }
        public void CopyTo(System.Configuration.ConfigurationElement[] array, int index) { }
        protected abstract System.Configuration.ConfigurationElement CreateNewElement();
        protected virtual System.Configuration.ConfigurationElement CreateNewElement(string elementName) { throw null; }
        public override bool Equals(object compareTo) { throw null; }
        protected abstract object GetElementKey(System.Configuration.ConfigurationElement element);
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public override int GetHashCode() { throw null; }
        protected virtual bool IsElementName(string elementName) { throw null; }
        protected virtual bool IsElementRemovable(System.Configuration.ConfigurationElement element) { throw null; }
        protected internal override bool IsModified() { throw null; }
        [System.MonoTODOAttribute]
        public override bool IsReadOnly() { throw null; }
        protected override bool OnDeserializeUnrecognizedElement(string elementName, System.Xml.XmlReader reader) { throw null; }
        protected internal override void Reset(System.Configuration.ConfigurationElement parentElement) { }
        protected internal override void ResetModified() { }
        protected internal override bool SerializeElement(System.Xml.XmlWriter writer, bool serializeCollectionKey) { throw null; }
        [System.MonoTODOAttribute]
        protected internal override void SetReadOnly() { }
        void System.Collections.ICollection.CopyTo(System.Array arr, int index) { }
        protected internal override void Unmerge(System.Configuration.ConfigurationElement sourceElement, System.Configuration.ConfigurationElement parentElement, System.Configuration.ConfigurationSaveMode updateMode) { }
    }
    public enum ConfigurationElementCollectionType
    {
        AddRemoveClearMap = 1,
        AddRemoveClearMapAlternate = 3,
        BasicMap = 0,
        BasicMapAlternate = 2,
    }
    public sealed partial class ConfigurationElementProperty
    {
        public ConfigurationElementProperty(System.Configuration.ConfigurationValidatorBase validator) { }
        public System.Configuration.ConfigurationValidatorBase Validator { get { throw null; } }
    }
    [System.SerializableAttribute]
    public partial class ConfigurationErrorsException : System.Configuration.ConfigurationException
    {
        public ConfigurationErrorsException() { }
        protected ConfigurationErrorsException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ConfigurationErrorsException(string message) { }
        public ConfigurationErrorsException(string message, System.Exception inner) { }
        public ConfigurationErrorsException(string message, System.Exception inner, string filename, int line) { }
        public ConfigurationErrorsException(string message, System.Exception inner, System.Xml.XmlNode node) { }
        public ConfigurationErrorsException(string message, System.Exception inner, System.Xml.XmlReader reader) { }
        public ConfigurationErrorsException(string message, string filename, int line) { }
        public ConfigurationErrorsException(string message, System.Xml.XmlNode node) { }
        public ConfigurationErrorsException(string message, System.Xml.XmlReader reader) { }
        public override string BareMessage { get { throw null; } }
        public System.Collections.ICollection Errors { get { throw null; } }
        public override string Filename { get { throw null; } }
        public override int Line { get { throw null; } }
        public override string Message { get { throw null; } }
        public static string GetFilename(System.Xml.XmlNode node) { throw null; }
        public static string GetFilename(System.Xml.XmlReader reader) { throw null; }
        public static int GetLineNumber(System.Xml.XmlNode node) { throw null; }
        public static int GetLineNumber(System.Xml.XmlReader reader) { throw null; }
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public partial class ConfigurationFileMap : System.ICloneable
    {
        public ConfigurationFileMap() { }
        public ConfigurationFileMap(string machineConfigFilename) { }
        public string MachineConfigFilename { get { throw null; } set { } }
        public virtual object Clone() { throw null; }
    }
    public partial class ConfigurationLocation
    {
        internal ConfigurationLocation() { }
        public string Path { get { throw null; } }
        public System.Configuration.Configuration OpenConfiguration() { throw null; }
    }
    public partial class ConfigurationLocationCollection : System.Collections.ReadOnlyCollectionBase
    {
        internal ConfigurationLocationCollection() { }
        public System.Configuration.ConfigurationLocation this[int index] { get { throw null; } }
    }
    public sealed partial class ConfigurationLockCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        internal ConfigurationLockCollection() { }
        public string AttributeList { get { throw null; } }
        public int Count { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool HasParentElements { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool IsModified { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool IsSynchronized { get { throw null; } }
        [System.MonoTODOAttribute]
        public object SyncRoot { get { throw null; } }
        public void Add(string name) { }
        public void Clear() { }
        public bool Contains(string name) { throw null; }
        public void CopyTo(string[] array, int index) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        [System.MonoInternalNoteAttribute("we can't possibly *always* return false here...")]
        public bool IsReadOnly(string name) { throw null; }
        public void Remove(string name) { }
        public void SetFromList(string attributeList) { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    }
    public static partial class ConfigurationManager
    {
        public static System.Collections.Specialized.NameValueCollection AppSettings { get { throw null; } }
        public static System.Configuration.ConnectionStringSettingsCollection ConnectionStrings { get { throw null; } }
        public static object GetSection(string sectionName) { throw null; }
        public static System.Configuration.Configuration OpenExeConfiguration(System.Configuration.ConfigurationUserLevel userLevel) { throw null; }
        public static System.Configuration.Configuration OpenExeConfiguration(string exePath) { throw null; }
        public static System.Configuration.Configuration OpenMachineConfiguration() { throw null; }
        [System.MonoLimitationAttribute("ConfigurationUserLevel parameter is not supported.")]
        public static System.Configuration.Configuration OpenMappedExeConfiguration(System.Configuration.ExeConfigurationFileMap fileMap, System.Configuration.ConfigurationUserLevel userLevel) { throw null; }
        public static System.Configuration.Configuration OpenMappedMachineConfiguration(System.Configuration.ConfigurationFileMap fileMap) { throw null; }
        public static void RefreshSection(string sectionName) { }
    }
    [System.SerializableAttribute]
    public sealed partial class ConfigurationPermission : System.Security.CodeAccessPermission, System.Security.Permissions.IUnrestrictedPermission
    {
        public ConfigurationPermission(System.Security.Permissions.PermissionState state) { }
        public override System.Security.IPermission Copy() { throw null; }
        public override void FromXml(System.Security.SecurityElement securityElement) { }
        public override System.Security.IPermission Intersect(System.Security.IPermission target) { throw null; }
        public override bool IsSubsetOf(System.Security.IPermission target) { throw null; }
        public bool IsUnrestricted() { throw null; }
        public override System.Security.SecurityElement ToXml() { throw null; }
        public override System.Security.IPermission Union(System.Security.IPermission target) { throw null; }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(32767), AllowMultiple=true, Inherited=false)]
    [System.SerializableAttribute]
    public sealed partial class ConfigurationPermissionAttribute : System.Security.Permissions.CodeAccessSecurityAttribute
    {
        public ConfigurationPermissionAttribute(System.Security.Permissions.SecurityAction action) : base (default(System.Security.Permissions.SecurityAction)) { }
        public override System.Security.IPermission CreatePermission() { throw null; }
    }
    public sealed partial class ConfigurationProperty
    {
        public ConfigurationProperty(string name, System.Type type) { }
        public ConfigurationProperty(string name, System.Type type, object default_value) { }
        public ConfigurationProperty(string name, System.Type type, object default_value, System.ComponentModel.TypeConverter converter, System.Configuration.ConfigurationValidatorBase validation, System.Configuration.ConfigurationPropertyOptions flags) { }
        public ConfigurationProperty(string name, System.Type type, object default_value, System.ComponentModel.TypeConverter converter, System.Configuration.ConfigurationValidatorBase validation, System.Configuration.ConfigurationPropertyOptions flags, string description) { }
        public ConfigurationProperty(string name, System.Type type, object default_value, System.Configuration.ConfigurationPropertyOptions flags) { }
        public System.ComponentModel.TypeConverter Converter { get { throw null; } }
        public object DefaultValue { get { throw null; } }
        public string Description { get { throw null; } }
        public bool IsDefaultCollection { get { throw null; } }
        public bool IsKey { get { throw null; } }
        public bool IsRequired { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Type Type { get { throw null; } }
        public System.Configuration.ConfigurationValidatorBase Validator { get { throw null; } }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
    public sealed partial class ConfigurationPropertyAttribute : System.Attribute
    {
        public ConfigurationPropertyAttribute(string name) { }
        public object DefaultValue { get { throw null; } set { } }
        public bool IsDefaultCollection { get { throw null; } set { } }
        public bool IsKey { get { throw null; } set { } }
        public bool IsRequired { get { throw null; } set { } }
        public string Name { get { throw null; } }
        public System.Configuration.ConfigurationPropertyOptions Options { get { throw null; } set { } }
    }
    public partial class ConfigurationPropertyCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public ConfigurationPropertyCollection() { }
        public int Count { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Configuration.ConfigurationProperty this[string name] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public void Add(System.Configuration.ConfigurationProperty property) { }
        public void Clear() { }
        public bool Contains(string name) { throw null; }
        public void CopyTo(System.Configuration.ConfigurationProperty[] array, int index) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public bool Remove(string name) { throw null; }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    }
    [System.FlagsAttribute]
    public enum ConfigurationPropertyOptions
    {
        IsAssemblyStringTransformationRequired = 16,
        IsDefaultCollection = 1,
        IsKey = 4,
        IsRequired = 2,
        IsTypeStringTransformationRequired = 8,
        IsVersionCheckRequired = 32,
        None = 0,
    }
    public enum ConfigurationSaveMode
    {
        Full = 2,
        Minimal = 1,
        Modified = 0,
    }
    public abstract partial class ConfigurationSection : System.Configuration.ConfigurationElement
    {
        protected ConfigurationSection() { }
        [System.MonoTODOAttribute]
        public System.Configuration.SectionInformation SectionInformation { get { throw null; } }
        [System.MonoInternalNoteAttribute("find the proper location for the decryption stuff")]
        protected internal virtual void DeserializeSection(System.Xml.XmlReader reader) { }
        [System.MonoTODOAttribute("Provide ConfigContext. Likely the culprit of bug #322493")]
        protected internal virtual object GetRuntimeObject() { throw null; }
        [System.MonoTODOAttribute]
        protected internal override bool IsModified() { throw null; }
        [System.MonoTODOAttribute]
        protected internal override void ResetModified() { }
        protected internal virtual string SerializeSection(System.Configuration.ConfigurationElement parentElement, string name, System.Configuration.ConfigurationSaveMode saveMode) { throw null; }
    }
    [System.SerializableAttribute]
    public sealed partial class ConfigurationSectionCollection : System.Collections.Specialized.NameObjectCollectionBase
    {
        internal ConfigurationSectionCollection() { }
        public override int Count { get { throw null; } }
        public System.Configuration.ConfigurationSection this[int index] { get { throw null; } }
        public System.Configuration.ConfigurationSection this[string name] { get { throw null; } }
        public override System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get { throw null; } }
        public void Add(string name, System.Configuration.ConfigurationSection section) { }
        public void Clear() { }
        public void CopyTo(System.Configuration.ConfigurationSection[] array, int index) { }
        public System.Configuration.ConfigurationSection Get(int index) { throw null; }
        public System.Configuration.ConfigurationSection Get(string name) { throw null; }
        [System.Diagnostics.DebuggerHiddenAttribute]
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        public string GetKey(int index) { throw null; }
        [System.MonoTODOAttribute]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public void Remove(string name) { }
        public void RemoveAt(int index) { }
    }
    public partial class ConfigurationSectionGroup
    {
        public ConfigurationSectionGroup() { }
        [System.MonoTODOAttribute]
        public bool IsDeclarationRequired { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool IsDeclared { get { throw null; } }
        public string Name { get { throw null; } }
        [System.MonoInternalNoteAttribute("Check if this is correct")]
        public string SectionGroupName { get { throw null; } }
        public System.Configuration.ConfigurationSectionGroupCollection SectionGroups { get { throw null; } }
        public System.Configuration.ConfigurationSectionCollection Sections { get { throw null; } }
        public string Type { get { throw null; } set { } }
        public void ForceDeclaration() { }
        [System.MonoTODOAttribute]
        public void ForceDeclaration(bool require) { }
    }
    [System.SerializableAttribute]
    public sealed partial class ConfigurationSectionGroupCollection : System.Collections.Specialized.NameObjectCollectionBase
    {
        internal ConfigurationSectionGroupCollection() { }
        public override int Count { get { throw null; } }
        public System.Configuration.ConfigurationSectionGroup this[int index] { get { throw null; } }
        public System.Configuration.ConfigurationSectionGroup this[string name] { get { throw null; } }
        public override System.Collections.Specialized.NameObjectCollectionBase.KeysCollection Keys { get { throw null; } }
        public void Add(string name, System.Configuration.ConfigurationSectionGroup sectionGroup) { }
        public void Clear() { }
        public void CopyTo(System.Configuration.ConfigurationSectionGroup[] array, int index) { }
        public System.Configuration.ConfigurationSectionGroup Get(int index) { throw null; }
        public System.Configuration.ConfigurationSectionGroup Get(string name) { throw null; }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        public string GetKey(int index) { throw null; }
        [System.MonoTODOAttribute]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public void Remove(string name) { }
        public void RemoveAt(int index) { }
    }
    public enum ConfigurationUserLevel
    {
        None = 0,
        PerUserRoaming = 10,
        PerUserRoamingAndLocal = 20,
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
    public partial class ConfigurationValidatorAttribute : System.Attribute
    {
        protected ConfigurationValidatorAttribute() { }
        public ConfigurationValidatorAttribute(System.Type validator) { }
        public virtual System.Configuration.ConfigurationValidatorBase ValidatorInstance { get { throw null; } }
        public System.Type ValidatorType { get { throw null; } }
    }
    public abstract partial class ConfigurationValidatorBase
    {
        protected ConfigurationValidatorBase() { }
        public virtual bool CanValidate(System.Type type) { throw null; }
        public abstract void Validate(object value);
    }
    public sealed partial class ConnectionStringSettings : System.Configuration.ConfigurationElement
    {
        public ConnectionStringSettings() { }
        public ConnectionStringSettings(string name, string connectionString) { }
        public ConnectionStringSettings(string name, string connectionString, string providerName) { }
        [System.Configuration.ConfigurationPropertyAttribute("connectionString", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(2))]
        public string ConnectionString { get { throw null; } set { } }
        [System.Configuration.ConfigurationPropertyAttribute("name", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
        public string Name { get { throw null; } set { } }
        protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("providerName", DefaultValue="System.Data.SqlClient")]
        public string ProviderName { get { throw null; } set { } }
        public override string ToString() { throw null; }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Configuration.ConnectionStringSettings), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
    public sealed partial class ConnectionStringSettingsCollection : System.Configuration.ConfigurationElementCollection
    {
        public ConnectionStringSettingsCollection() { }
        public System.Configuration.ConnectionStringSettings this[int index] { get { throw null; } set { } }
        public new System.Configuration.ConnectionStringSettings this[string Name] { get { throw null; } }
        [System.MonoTODOAttribute]
        protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        public void Add(System.Configuration.ConnectionStringSettings settings) { }
        protected override void BaseAdd(int index, System.Configuration.ConfigurationElement element) { }
        public void Clear() { }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        public int IndexOf(System.Configuration.ConnectionStringSettings settings) { throw null; }
        public void Remove(System.Configuration.ConnectionStringSettings settings) { }
        public void Remove(string name) { }
        public void RemoveAt(int index) { }
    }
    public sealed partial class ConnectionStringsSection : System.Configuration.ConfigurationSection
    {
        public ConnectionStringsSection() { }
        [System.Configuration.ConfigurationPropertyAttribute("", Options=(System.Configuration.ConfigurationPropertyOptions)(1))]
        public System.Configuration.ConnectionStringSettingsCollection ConnectionStrings { get { throw null; } }
        protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        protected internal override object GetRuntimeObject() { throw null; }
    }
    public sealed partial class ContextInformation
    {
        internal ContextInformation() { }
        public object HostingContext { get { throw null; } }
        [System.MonoInternalNoteAttribute("should this use HostingContext instead?")]
        public bool IsMachineLevel { get { throw null; } }
        public object GetSection(string sectionName) { throw null; }
    }
    public sealed partial class DefaultSection : System.Configuration.ConfigurationSection
    {
        public DefaultSection() { }
        protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        protected internal override void DeserializeSection(System.Xml.XmlReader xmlReader) { }
        [System.MonoTODOAttribute]
        protected internal override bool IsModified() { throw null; }
        [System.MonoTODOAttribute]
        protected internal override void Reset(System.Configuration.ConfigurationElement parentSection) { }
        [System.MonoTODOAttribute]
        protected internal override void ResetModified() { }
        [System.MonoTODOAttribute]
        protected internal override string SerializeSection(System.Configuration.ConfigurationElement parentSection, string name, System.Configuration.ConfigurationSaveMode saveMode) { throw null; }
    }
    public sealed partial class DefaultValidator : System.Configuration.ConfigurationValidatorBase
    {
        public DefaultValidator() { }
        public override bool CanValidate(System.Type type) { throw null; }
        public override void Validate(object value) { }
    }
    public sealed partial class DpapiProtectedConfigurationProvider : System.Configuration.ProtectedConfigurationProvider
    {
        public DpapiProtectedConfigurationProvider() { }
        public bool UseMachineProtection { get { throw null; } }
        [System.MonoNotSupportedAttribute("DpapiProtectedConfigurationProvider depends on the Microsoft Data\nProtection API, and is unimplemented in Mono.  For portability's sake,\nit is suggested that you use the RsaProtectedConfigurationProvider.")]
        public override System.Xml.XmlNode Decrypt(System.Xml.XmlNode encrypted_node) { throw null; }
        [System.MonoNotSupportedAttribute("DpapiProtectedConfigurationProvider depends on the Microsoft Data\nProtection API, and is unimplemented in Mono.  For portability's sake,\nit is suggested that you use the RsaProtectedConfigurationProvider.")]
        public override System.Xml.XmlNode Encrypt(System.Xml.XmlNode node) { throw null; }
        [System.MonoTODOAttribute]
        public override void Initialize(string name, System.Collections.Specialized.NameValueCollection configurationValues) { }
    }
    public sealed partial class ElementInformation
    {
        internal ElementInformation() { }
        [System.MonoTODOAttribute]
        public System.Collections.ICollection Errors { get { throw null; } }
        public bool IsCollection { get { throw null; } }
        public bool IsLocked { get { throw null; } }
        [System.MonoTODOAttribute("Support multiple levels of inheritance")]
        public bool IsPresent { get { throw null; } }
        public int LineNumber { get { throw null; } }
        public System.Configuration.PropertyInformationCollection Properties { get { throw null; } }
        public string Source { get { throw null; } }
        public System.Type Type { get { throw null; } }
        public System.Configuration.ConfigurationValidatorBase Validator { get { throw null; } }
    }
    public sealed partial class ExeConfigurationFileMap : System.Configuration.ConfigurationFileMap
    {
        public ExeConfigurationFileMap() { }
        public string ExeConfigFilename { get { throw null; } set { } }
        public string LocalUserConfigFilename { get { throw null; } set { } }
        public string RoamingUserConfigFilename { get { throw null; } set { } }
        public override object Clone() { throw null; }
    }
    public sealed partial class ExeContext
    {
        internal ExeContext() { }
        public string ExePath { get { throw null; } }
        public System.Configuration.ConfigurationUserLevel UserLevel { get { throw null; } }
    }
    public sealed partial class GenericEnumConverter : System.Configuration.ConfigurationConverterBase
    {
        public GenericEnumConverter(System.Type typeEnum) { }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type type) { throw null; }
    }
    public sealed partial class IgnoreSection : System.Configuration.ConfigurationSection
    {
        public IgnoreSection() { }
        protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        protected internal override void DeserializeSection(System.Xml.XmlReader reader) { }
        protected internal override bool IsModified() { throw null; }
        [System.MonoTODOAttribute]
        protected internal override void Reset(System.Configuration.ConfigurationElement parentElement) { }
        [System.MonoTODOAttribute]
        protected internal override void ResetModified() { }
        protected internal override string SerializeSection(System.Configuration.ConfigurationElement parentElement, string name, System.Configuration.ConfigurationSaveMode saveMode) { throw null; }
    }
    public sealed partial class InfiniteIntConverter : System.Configuration.ConfigurationConverterBase
    {
        public InfiniteIntConverter() { }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type type) { throw null; }
    }
    public sealed partial class InfiniteTimeSpanConverter : System.Configuration.ConfigurationConverterBase
    {
        public InfiniteTimeSpanConverter() { }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type type) { throw null; }
    }
    public partial class IntegerValidator : System.Configuration.ConfigurationValidatorBase
    {
        public IntegerValidator(int minValue, int maxValue) { }
        public IntegerValidator(int minValue, int maxValue, bool rangeIsExclusive) { }
        public IntegerValidator(int minValue, int maxValue, bool rangeIsExclusive, int resolution) { }
        public override bool CanValidate(System.Type type) { throw null; }
        public override void Validate(object value) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
    public sealed partial class IntegerValidatorAttribute : System.Configuration.ConfigurationValidatorAttribute
    {
        public IntegerValidatorAttribute() { }
        public bool ExcludeRange { get { throw null; } set { } }
        public int MaxValue { get { throw null; } set { } }
        public int MinValue { get { throw null; } set { } }
        public override System.Configuration.ConfigurationValidatorBase ValidatorInstance { get { throw null; } }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Configuration.KeyValueConfigurationElement), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
    public partial class KeyValueConfigurationCollection : System.Configuration.ConfigurationElementCollection
    {
        public KeyValueConfigurationCollection() { }
        public string[] AllKeys { get { throw null; } }
        public new System.Configuration.KeyValueConfigurationElement this[string key] { get { throw null; } }
        protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        protected override bool ThrowOnDuplicate { get { throw null; } }
        public void Add(System.Configuration.KeyValueConfigurationElement keyValue) { }
        public void Add(string key, string value) { }
        public void Clear() { }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        public void Remove(string key) { }
    }
    public partial class KeyValueConfigurationElement : System.Configuration.ConfigurationElement
    {
        public KeyValueConfigurationElement(string key, string value) { }
        [System.Configuration.ConfigurationPropertyAttribute("key", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(4))]
        public string Key { get { throw null; } }
        protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("value", DefaultValue="")]
        public string Value { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        protected internal override void Init() { }
    }
    public partial class LongValidator : System.Configuration.ConfigurationValidatorBase
    {
        public LongValidator(long minValue, long maxValue) { }
        public LongValidator(long minValue, long maxValue, bool rangeIsExclusive) { }
        public LongValidator(long minValue, long maxValue, bool rangeIsExclusive, long resolution) { }
        public override bool CanValidate(System.Type type) { throw null; }
        public override void Validate(object value) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
    public sealed partial class LongValidatorAttribute : System.Configuration.ConfigurationValidatorAttribute
    {
        public LongValidatorAttribute() { }
        public bool ExcludeRange { get { throw null; } set { } }
        public long MaxValue { get { throw null; } set { } }
        public long MinValue { get { throw null; } set { } }
        public override System.Configuration.ConfigurationValidatorBase ValidatorInstance { get { throw null; } }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Configuration.NameValueConfigurationElement), AddItemName="add", RemoveItemName="remove", ClearItemsName="clear", CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
    public sealed partial class NameValueConfigurationCollection : System.Configuration.ConfigurationElementCollection
    {
        public NameValueConfigurationCollection() { }
        public string[] AllKeys { get { throw null; } }
        public new System.Configuration.NameValueConfigurationElement this[string name] { get { throw null; } set { } }
        protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        public void Add(System.Configuration.NameValueConfigurationElement nameValue) { }
        public void Clear() { }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        public void Remove(System.Configuration.NameValueConfigurationElement nameValue) { }
        public void Remove(string name) { }
    }
    public sealed partial class NameValueConfigurationElement : System.Configuration.ConfigurationElement
    {
        public NameValueConfigurationElement(string name, string value) { }
        [System.Configuration.ConfigurationPropertyAttribute("name", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(4))]
        public string Name { get { throw null; } }
        protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("value", DefaultValue="", Options=(System.Configuration.ConfigurationPropertyOptions)(0))]
        public string Value { get { throw null; } set { } }
    }
    public partial class PositiveTimeSpanValidator : System.Configuration.ConfigurationValidatorBase
    {
        public PositiveTimeSpanValidator() { }
        public override bool CanValidate(System.Type type) { throw null; }
        public override void Validate(object value) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
    public sealed partial class PositiveTimeSpanValidatorAttribute : System.Configuration.ConfigurationValidatorAttribute
    {
        public PositiveTimeSpanValidatorAttribute() { }
        public override System.Configuration.ConfigurationValidatorBase ValidatorInstance { get { throw null; } }
    }
    public sealed partial class PropertyInformation
    {
        internal PropertyInformation() { }
        public System.ComponentModel.TypeConverter Converter { get { throw null; } }
        public object DefaultValue { get { throw null; } }
        public string Description { get { throw null; } }
        public bool IsKey { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool IsLocked { get { throw null; } }
        public bool IsModified { get { throw null; } }
        public bool IsRequired { get { throw null; } }
        public int LineNumber { get { throw null; } }
        public string Name { get { throw null; } }
        public string Source { get { throw null; } }
        public System.Type Type { get { throw null; } }
        public System.Configuration.ConfigurationValidatorBase Validator { get { throw null; } }
        public object Value { get { throw null; } set { } }
        public System.Configuration.PropertyValueOrigin ValueOrigin { get { throw null; } }
    }
    [System.SerializableAttribute]
    public sealed partial class PropertyInformationCollection : System.Collections.Specialized.NameObjectCollectionBase
    {
        internal PropertyInformationCollection() { }
        public System.Configuration.PropertyInformation this[string propertyName] { get { throw null; } }
        public void CopyTo(System.Configuration.PropertyInformation[] array, int index) { }
        public override System.Collections.IEnumerator GetEnumerator() { throw null; }
        [System.MonoTODOAttribute]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
    }
    public enum PropertyValueOrigin
    {
        Default = 0,
        Inherited = 1,
        SetHere = 2,
    }
    public static partial class ProtectedConfiguration
    {
        public const string DataProtectionProviderName = "DataProtectionConfigurationProvider";
        public const string ProtectedDataSectionName = "configProtectedData";
        public const string RsaProviderName = "RsaProtectedConfigurationProvider";
        public static string DefaultProvider { get { throw null; } }
        public static System.Configuration.ProtectedConfigurationProviderCollection Providers { get { throw null; } }
    }
    public abstract partial class ProtectedConfigurationProvider : System.Configuration.Provider.ProviderBase
    {
        protected ProtectedConfigurationProvider() { }
        public abstract System.Xml.XmlNode Decrypt(System.Xml.XmlNode encrypted_node);
        public abstract System.Xml.XmlNode Encrypt(System.Xml.XmlNode node);
    }
    public partial class ProtectedConfigurationProviderCollection : System.Configuration.Provider.ProviderCollection
    {
        public ProtectedConfigurationProviderCollection() { }
        [System.MonoTODOAttribute]
        public new System.Configuration.ProtectedConfigurationProvider this[string name] { get { throw null; } }
        [System.MonoTODOAttribute]
        public override void Add(System.Configuration.Provider.ProviderBase provider) { }
    }
    public sealed partial class ProtectedConfigurationSection : System.Configuration.ConfigurationSection
    {
        public ProtectedConfigurationSection() { }
        [System.Configuration.ConfigurationPropertyAttribute("defaultProvider", DefaultValue="RsaProtectedConfigurationProvider")]
        public string DefaultProvider { get { throw null; } set { } }
        protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("providers")]
        public System.Configuration.ProviderSettingsCollection Providers { get { throw null; } }
    }
    public partial class ProtectedProviderSettings : System.Configuration.ConfigurationElement
    {
        public ProtectedProviderSettings() { }
        protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("", Options=(System.Configuration.ConfigurationPropertyOptions)(1))]
        public System.Configuration.ProviderSettingsCollection Providers { get { throw null; } }
    }
    public sealed partial class ProviderSettings : System.Configuration.ConfigurationElement
    {
        public ProviderSettings() { }
        public ProviderSettings(string name, string type) { }
        [System.Configuration.ConfigurationPropertyAttribute("name", Options=(System.Configuration.ConfigurationPropertyOptions)(6))]
        public string Name { get { throw null; } set { } }
        public System.Collections.Specialized.NameValueCollection Parameters { get { throw null; } }
        protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        [System.Configuration.ConfigurationPropertyAttribute("type", Options=(System.Configuration.ConfigurationPropertyOptions)(2))]
        public string Type { get { throw null; } set { } }
        protected internal override bool IsModified() { throw null; }
        protected override bool OnDeserializeUnrecognizedAttribute(string name, string value) { throw null; }
        protected internal override void Reset(System.Configuration.ConfigurationElement parentElement) { }
        [System.MonoTODOAttribute]
        protected internal override void Unmerge(System.Configuration.ConfigurationElement source, System.Configuration.ConfigurationElement parent, System.Configuration.ConfigurationSaveMode updateMode) { }
    }
    [System.Configuration.ConfigurationCollectionAttribute(typeof(System.Configuration.ProviderSettings), CollectionType=(System.Configuration.ConfigurationElementCollectionType)(1))]
    public sealed partial class ProviderSettingsCollection : System.Configuration.ConfigurationElementCollection
    {
        public ProviderSettingsCollection() { }
        public System.Configuration.ProviderSettings this[int n] { get { throw null; } set { } }
        public new System.Configuration.ProviderSettings this[string key] { get { throw null; } }
        protected internal override System.Configuration.ConfigurationPropertyCollection Properties { get { throw null; } }
        public void Add(System.Configuration.ProviderSettings provider) { }
        public void Clear() { }
        protected override System.Configuration.ConfigurationElement CreateNewElement() { throw null; }
        protected override object GetElementKey(System.Configuration.ConfigurationElement element) { throw null; }
        public void Remove(string key) { }
    }
    public partial class RegexStringValidator : System.Configuration.ConfigurationValidatorBase
    {
        public RegexStringValidator(string regex) { }
        public override bool CanValidate(System.Type type) { throw null; }
        public override void Validate(object value) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
    public sealed partial class RegexStringValidatorAttribute : System.Configuration.ConfigurationValidatorAttribute
    {
        public RegexStringValidatorAttribute(string regex) { }
        public string Regex { get { throw null; } }
        public override System.Configuration.ConfigurationValidatorBase ValidatorInstance { get { throw null; } }
    }
    public sealed partial class RsaProtectedConfigurationProvider : System.Configuration.ProtectedConfigurationProvider
    {
        public RsaProtectedConfigurationProvider() { }
        public string CspProviderName { get { throw null; } }
        public string KeyContainerName { get { throw null; } }
        public System.Security.Cryptography.RSAParameters RsaPublicKey { get { throw null; } }
        public bool UseMachineContainer { get { throw null; } }
        public bool UseOAEP { get { throw null; } }
        [System.MonoTODOAttribute]
        public void AddKey(int keySize, bool exportable) { }
        [System.MonoTODOAttribute]
        public override System.Xml.XmlNode Decrypt(System.Xml.XmlNode encrypted_node) { throw null; }
        [System.MonoTODOAttribute]
        public void DeleteKey() { }
        [System.MonoTODOAttribute]
        public override System.Xml.XmlNode Encrypt(System.Xml.XmlNode node) { throw null; }
        [System.MonoTODOAttribute]
        public void ExportKey(string xmlFileName, bool includePrivateParameters) { }
        [System.MonoTODOAttribute]
        public void ImportKey(string xmlFileName, bool exportable) { }
        [System.MonoTODOAttribute]
        public override void Initialize(string name, System.Collections.Specialized.NameValueCollection configurationValues) { }
    }
    public sealed partial class SectionInformation
    {
        internal SectionInformation() { }
        public System.Configuration.ConfigurationAllowDefinition AllowDefinition { get { throw null; } set { } }
        public System.Configuration.ConfigurationAllowExeDefinition AllowExeDefinition { get { throw null; } set { } }
        public bool AllowLocation { get { throw null; } set { } }
        public bool AllowOverride { get { throw null; } set { } }
        public string ConfigSource { get { throw null; } set { } }
        public bool ForceSave { get { throw null; } set { } }
        public bool InheritInChildApplications { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool IsDeclarationRequired { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool IsDeclared { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool IsLocked { get { throw null; } }
        public bool IsProtected { get { throw null; } }
        public string Name { get { throw null; } }
        public System.Configuration.ProtectedConfigurationProvider ProtectionProvider { get { throw null; } }
        [System.MonoTODOAttribute]
        public bool RequirePermission { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public bool RestartOnExternalChanges { get { throw null; } set { } }
        [System.MonoTODOAttribute]
        public string SectionName { get { throw null; } }
        public string Type { get { throw null; } set { } }
        public void ForceDeclaration() { }
        [System.MonoTODOAttribute]
        public void ForceDeclaration(bool require) { }
        public System.Configuration.ConfigurationSection GetParentSection() { throw null; }
        public string GetRawXml() { throw null; }
        public void ProtectSection(string provider) { }
        [System.MonoTODOAttribute]
        public void RevertToParent() { }
        public void SetRawXml(string xml) { }
        public void UnprotectSection() { }
    }
    public partial class StringValidator : System.Configuration.ConfigurationValidatorBase
    {
        public StringValidator(int minLength) { }
        public StringValidator(int minLength, int maxLength) { }
        public StringValidator(int minLength, int maxLength, string invalidCharacters) { }
        public override bool CanValidate(System.Type type) { throw null; }
        public override void Validate(object value) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
    public sealed partial class StringValidatorAttribute : System.Configuration.ConfigurationValidatorAttribute
    {
        public StringValidatorAttribute() { }
        public string InvalidCharacters { get { throw null; } set { } }
        public int MaxLength { get { throw null; } set { } }
        public int MinLength { get { throw null; } set { } }
        public override System.Configuration.ConfigurationValidatorBase ValidatorInstance { get { throw null; } }
    }
    public sealed partial class SubclassTypeValidator : System.Configuration.ConfigurationValidatorBase
    {
        public SubclassTypeValidator(System.Type baseClass) { }
        public override bool CanValidate(System.Type type) { throw null; }
        public override void Validate(object value) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
    public sealed partial class SubclassTypeValidatorAttribute : System.Configuration.ConfigurationValidatorAttribute
    {
        public SubclassTypeValidatorAttribute(System.Type baseClass) { }
        public System.Type BaseClass { get { throw null; } }
        public override System.Configuration.ConfigurationValidatorBase ValidatorInstance { get { throw null; } }
    }
    public partial class TimeSpanMinutesConverter : System.Configuration.ConfigurationConverterBase
    {
        public TimeSpanMinutesConverter() { }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type type) { throw null; }
    }
    public sealed partial class TimeSpanMinutesOrInfiniteConverter : System.Configuration.TimeSpanMinutesConverter
    {
        public TimeSpanMinutesOrInfiniteConverter() { }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type type) { throw null; }
    }
    public partial class TimeSpanSecondsConverter : System.Configuration.ConfigurationConverterBase
    {
        public TimeSpanSecondsConverter() { }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type type) { throw null; }
    }
    public sealed partial class TimeSpanSecondsOrInfiniteConverter : System.Configuration.TimeSpanSecondsConverter
    {
        public TimeSpanSecondsOrInfiniteConverter() { }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type type) { throw null; }
    }
    public partial class TimeSpanValidator : System.Configuration.ConfigurationValidatorBase
    {
        public TimeSpanValidator(System.TimeSpan minValue, System.TimeSpan maxValue) { }
        public TimeSpanValidator(System.TimeSpan minValue, System.TimeSpan maxValue, bool rangeIsExclusive) { }
        public TimeSpanValidator(System.TimeSpan minValue, System.TimeSpan maxValue, bool rangeIsExclusive, long resolutionInSeconds) { }
        public override bool CanValidate(System.Type type) { throw null; }
        public override void Validate(object value) { }
    }
    [System.AttributeUsageAttribute((System.AttributeTargets)(128))]
    public sealed partial class TimeSpanValidatorAttribute : System.Configuration.ConfigurationValidatorAttribute
    {
        public const string TimeSpanMaxValue = "10675199.02:48:05.4775807";
        public const string TimeSpanMinValue = "-10675199.02:48:05.4775808";
        public TimeSpanValidatorAttribute() { }
        public bool ExcludeRange { get { throw null; } set { } }
        public System.TimeSpan MaxValue { get { throw null; } }
        public string MaxValueString { get { throw null; } set { } }
        public System.TimeSpan MinValue { get { throw null; } }
        public string MinValueString { get { throw null; } set { } }
        public override System.Configuration.ConfigurationValidatorBase ValidatorInstance { get { throw null; } }
    }
    public sealed partial class TypeNameConverter : System.Configuration.ConfigurationConverterBase
    {
        public TypeNameConverter() { }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type type) { throw null; }
    }
    public delegate void ValidatorCallback(object o);
    public sealed partial class WhiteSpaceTrimStringConverter : System.Configuration.ConfigurationConverterBase
    {
        public WhiteSpaceTrimStringConverter() { }
        public override object ConvertFrom(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object data) { throw null; }
        public override object ConvertTo(System.ComponentModel.ITypeDescriptorContext ctx, System.Globalization.CultureInfo ci, object value, System.Type type) { throw null; }
    }
}
namespace System.Configuration.Internal
{
    public partial class DelegatingConfigHost : System.Configuration.Internal.IInternalConfigHost
    {
        protected DelegatingConfigHost() { }
        protected System.Configuration.Internal.IInternalConfigHost Host { get { throw null; } set { } }
        public virtual bool IsRemote { get { throw null; } }
        public virtual bool SupportsChangeNotifications { get { throw null; } }
        public virtual bool SupportsLocation { get { throw null; } }
        public virtual bool SupportsPath { get { throw null; } }
        public virtual bool SupportsRefresh { get { throw null; } }
        public virtual object CreateConfigurationContext(string configPath, string locationSubPath) { throw null; }
        public virtual object CreateDeprecatedConfigContext(string configPath) { throw null; }
        public virtual string DecryptSection(string encryptedXml, System.Configuration.ProtectedConfigurationProvider protectionProvider, System.Configuration.ProtectedConfigurationSection protectedSection) { throw null; }
        public virtual void DeleteStream(string streamName) { }
        public virtual string EncryptSection(string encryptedXml, System.Configuration.ProtectedConfigurationProvider protectionProvider, System.Configuration.ProtectedConfigurationSection protectedSection) { throw null; }
        public virtual string GetConfigPathFromLocationSubPath(string configPath, string locatinSubPath) { throw null; }
        public virtual System.Type GetConfigType(string typeName, bool throwOnError) { throw null; }
        public virtual string GetConfigTypeName(System.Type t) { throw null; }
        public virtual void GetRestrictedPermissions(System.Configuration.Internal.IInternalConfigRecord configRecord, out System.Security.PermissionSet permissionSet, out bool isHostReady) { permissionSet = default(System.Security.PermissionSet); isHostReady = default(bool); }
        public virtual string GetStreamName(string configPath) { throw null; }
        public virtual string GetStreamNameForConfigSource(string streamName, string configSource) { throw null; }
        public virtual object GetStreamVersion(string streamName) { throw null; }
        public virtual System.IDisposable Impersonate() { throw null; }
        public virtual void Init(System.Configuration.Internal.IInternalConfigRoot root, params object[] hostInitParams) { }
        public virtual void InitForConfiguration(ref string locationSubPath, out string configPath, out string locationConfigPath, System.Configuration.Internal.IInternalConfigRoot root, params object[] hostInitConfigurationParams) { configPath = default(string); locationConfigPath = default(string); }
        public virtual bool IsAboveApplication(string configPath) { throw null; }
        public virtual bool IsConfigRecordRequired(string configPath) { throw null; }
        public virtual bool IsDefinitionAllowed(string configPath, System.Configuration.ConfigurationAllowDefinition allowDefinition, System.Configuration.ConfigurationAllowExeDefinition allowExeDefinition) { throw null; }
        public virtual bool IsFile(string streamName) { throw null; }
        public virtual bool IsFullTrustSectionWithoutAptcaAllowed(System.Configuration.Internal.IInternalConfigRecord configRecord) { throw null; }
        public virtual bool IsInitDelayed(System.Configuration.Internal.IInternalConfigRecord configRecord) { throw null; }
        public virtual bool IsLocationApplicable(string configPath) { throw null; }
        public virtual bool IsSecondaryRoot(string configPath) { throw null; }
        public virtual bool IsTrustedConfigPath(string configPath) { throw null; }
        public virtual System.IO.Stream OpenStreamForRead(string streamName) { throw null; }
        public virtual System.IO.Stream OpenStreamForRead(string streamName, bool assertPermissions) { throw null; }
        public virtual System.IO.Stream OpenStreamForWrite(string streamName, string templateStreamName, ref object writeContext) { throw null; }
        public virtual System.IO.Stream OpenStreamForWrite(string streamName, string templateStreamName, ref object writeContext, bool assertPermissions) { throw null; }
        public virtual bool PrefetchAll(string configPath, string streamName) { throw null; }
        public virtual bool PrefetchSection(string sectionGroupName, string sectionName) { throw null; }
        public virtual void RequireCompleteInit(System.Configuration.Internal.IInternalConfigRecord configRecord) { }
        public virtual object StartMonitoringStreamForChanges(string streamName, System.Configuration.Internal.StreamChangeCallback callback) { throw null; }
        public virtual void StopMonitoringStreamForChanges(string streamName, System.Configuration.Internal.StreamChangeCallback callback) { }
        public virtual void VerifyDefinitionAllowed(string configPath, System.Configuration.ConfigurationAllowDefinition allowDefinition, System.Configuration.ConfigurationAllowExeDefinition allowExeDefinition, System.Configuration.Internal.IConfigErrorInfo errorInfo) { }
        public virtual void WriteCompleted(string streamName, bool success, object writeContext) { }
        public virtual void WriteCompleted(string streamName, bool success, object writeContext, bool assertPermissions) { }
    }
    public partial interface IConfigErrorInfo
    {
        string Filename { get; }
        int LineNumber { get; }
    }
    public partial interface IConfigSystem
    {
        System.Configuration.Internal.IInternalConfigHost Host { get; }
        System.Configuration.Internal.IInternalConfigRoot Root { get; }
        void Init(System.Type typeConfigHost, params object[] hostInitParams);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial interface IConfigurationManagerHelper
    {
        void EnsureNetConfigLoaded();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial interface IConfigurationManagerInternal
    {
        string ApplicationConfigUri { get; }
        string ExeLocalConfigDirectory { get; }
        string ExeLocalConfigPath { get; }
        string ExeProductName { get; }
        string ExeProductVersion { get; }
        string ExeRoamingConfigDirectory { get; }
        string ExeRoamingConfigPath { get; }
        string MachineConfigPath { get; }
        bool SetConfigurationSystemInProgress { get; }
        bool SupportsUserConfig { get; }
        string UserConfigFilename { get; }
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial interface IInternalConfigClientHost
    {
        string GetExeConfigPath();
        string GetLocalUserConfigPath();
        string GetRoamingUserConfigPath();
        bool IsExeConfig(string configPath);
        bool IsLocalUserConfig(string configPath);
        bool IsRoamingUserConfig(string configPath);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial interface IInternalConfigConfigurationFactory
    {
        System.Configuration.Configuration Create(System.Type typeConfigHost, params object[] hostInitConfigurationParams);
        string NormalizeLocationSubPath(string subPath, System.Configuration.Internal.IConfigErrorInfo errorInfo);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial interface IInternalConfigHost
    {
        bool IsRemote { get; }
        bool SupportsChangeNotifications { get; }
        bool SupportsLocation { get; }
        bool SupportsPath { get; }
        bool SupportsRefresh { get; }
        object CreateConfigurationContext(string configPath, string locationSubPath);
        object CreateDeprecatedConfigContext(string configPath);
        string DecryptSection(string encryptedXml, System.Configuration.ProtectedConfigurationProvider protectionProvider, System.Configuration.ProtectedConfigurationSection protectedSection);
        void DeleteStream(string streamName);
        string EncryptSection(string encryptedXml, System.Configuration.ProtectedConfigurationProvider protectionProvider, System.Configuration.ProtectedConfigurationSection protectedSection);
        string GetConfigPathFromLocationSubPath(string configPath, string locatinSubPath);
        System.Type GetConfigType(string typeName, bool throwOnError);
        string GetConfigTypeName(System.Type t);
        void GetRestrictedPermissions(System.Configuration.Internal.IInternalConfigRecord configRecord, out System.Security.PermissionSet permissionSet, out bool isHostReady);
        string GetStreamName(string configPath);
        string GetStreamNameForConfigSource(string streamName, string configSource);
        object GetStreamVersion(string streamName);
        System.IDisposable Impersonate();
        void Init(System.Configuration.Internal.IInternalConfigRoot root, params object[] hostInitParams);
        void InitForConfiguration(ref string locationSubPath, out string configPath, out string locationConfigPath, System.Configuration.Internal.IInternalConfigRoot root, params object[] hostInitConfigurationParams);
        bool IsAboveApplication(string configPath);
        bool IsConfigRecordRequired(string configPath);
        bool IsDefinitionAllowed(string configPath, System.Configuration.ConfigurationAllowDefinition allowDefinition, System.Configuration.ConfigurationAllowExeDefinition allowExeDefinition);
        bool IsFile(string streamName);
        bool IsFullTrustSectionWithoutAptcaAllowed(System.Configuration.Internal.IInternalConfigRecord configRecord);
        bool IsInitDelayed(System.Configuration.Internal.IInternalConfigRecord configRecord);
        bool IsLocationApplicable(string configPath);
        bool IsSecondaryRoot(string configPath);
        bool IsTrustedConfigPath(string configPath);
        System.IO.Stream OpenStreamForRead(string streamName);
        System.IO.Stream OpenStreamForRead(string streamName, bool assertPermissions);
        System.IO.Stream OpenStreamForWrite(string streamName, string templateStreamName, ref object writeContext);
        System.IO.Stream OpenStreamForWrite(string streamName, string templateStreamName, ref object writeContext, bool assertPermissions);
        bool PrefetchAll(string configPath, string streamName);
        bool PrefetchSection(string sectionGroupName, string sectionName);
        void RequireCompleteInit(System.Configuration.Internal.IInternalConfigRecord configRecord);
        object StartMonitoringStreamForChanges(string streamName, System.Configuration.Internal.StreamChangeCallback callback);
        void StopMonitoringStreamForChanges(string streamName, System.Configuration.Internal.StreamChangeCallback callback);
        void VerifyDefinitionAllowed(string configPath, System.Configuration.ConfigurationAllowDefinition allowDefinition, System.Configuration.ConfigurationAllowExeDefinition allowExeDefinition, System.Configuration.Internal.IConfigErrorInfo errorInfo);
        void WriteCompleted(string streamName, bool success, object writeContext);
        void WriteCompleted(string streamName, bool success, object writeContext, bool assertPermissions);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial interface IInternalConfigRecord
    {
        string ConfigPath { get; }
        bool HasInitErrors { get; }
        string StreamName { get; }
        object GetLkgSection(string configKey);
        object GetSection(string configKey);
        void RefreshSection(string configKey);
        void Remove();
        void ThrowIfInitErrors();
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial interface IInternalConfigRoot
    {
        bool IsDesignTime { get; }
        event System.Configuration.Internal.InternalConfigEventHandler ConfigChanged;
        event System.Configuration.Internal.InternalConfigEventHandler ConfigRemoved;
        System.Configuration.Internal.IInternalConfigRecord GetConfigRecord(string configPath);
        object GetSection(string section, string configPath);
        string GetUniqueConfigPath(string configPath);
        System.Configuration.Internal.IInternalConfigRecord GetUniqueConfigRecord(string configPath);
        void Init(System.Configuration.Internal.IInternalConfigHost host, bool isDesignTime);
        void RemoveConfig(string configPath);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial interface IInternalConfigSettingsFactory
    {
        void CompleteInit();
        void SetConfigurationSystem(System.Configuration.Internal.IInternalConfigSystem internalConfigSystem, bool initComplete);
    }
    [System.Runtime.InteropServices.ComVisibleAttribute(false)]
    public partial interface IInternalConfigSystem
    {
        bool SupportsUserConfig { get; }
        object GetSection(string configKey);
        void RefreshConfig(string sectionName);
    }
    public sealed partial class InternalConfigEventArgs : System.EventArgs
    {
        public InternalConfigEventArgs(string configPath) { }
        public string ConfigPath { get { throw null; } set { } }
    }
    public delegate void InternalConfigEventHandler(object sender, System.Configuration.Internal.InternalConfigEventArgs e);
    public delegate void StreamChangeCallback(string streamName);
}
namespace System.Configuration.Provider
{
    public abstract partial class ProviderBase
    {
        protected ProviderBase() { }
        public virtual string Description { get { throw null; } }
        public virtual string Name { get { throw null; } }
        public virtual void Initialize(string name, System.Collections.Specialized.NameValueCollection config) { }
    }
    public partial class ProviderCollection : System.Collections.ICollection, System.Collections.IEnumerable
    {
        public ProviderCollection() { }
        public int Count { get { throw null; } }
        public bool IsSynchronized { get { throw null; } }
        public System.Configuration.Provider.ProviderBase this[string name] { get { throw null; } }
        public object SyncRoot { get { throw null; } }
        public virtual void Add(System.Configuration.Provider.ProviderBase provider) { }
        public void Clear() { }
        public void CopyTo(System.Configuration.Provider.ProviderBase[] array, int index) { }
        public System.Collections.IEnumerator GetEnumerator() { throw null; }
        public void Remove(string name) { }
        public void SetReadOnly() { }
        void System.Collections.ICollection.CopyTo(System.Array array, int index) { }
    }
    [System.SerializableAttribute]
    public partial class ProviderException : System.Exception
    {
        public ProviderException() { }
        protected ProviderException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context) { }
        public ProviderException(string message) { }
        public ProviderException(string message, System.Exception innerException) { }
    }
}
