PROFILE := v4.5
SOURCEDIR := ../src/$(PROFILE)/

CSC ?= csc
CSC_COMMON_ARGS := -nologo -noconfig -optimize -nostdlib -unsafe -deterministic -publicsign -target:library -nowarn:612 -nowarn:618
Q_CSC = $(if $(V),,@echo "CSC     [$(PROFILE)] $(1)";)

ASSEMBLIES := Accessibility Commons.Xml.Relaxng CustomMarshalers I18N.CJK I18N.MidEast I18N.Other I18N.Rare I18N.West I18N	\
	IBM.Data.DB2 ICSharpCode.SharpZipLib Microsoft.Build.Engine Microsoft.Build.Framework Microsoft.Build.Tasks.v4.0	\
	Microsoft.Build.Utilities.v4.0 Microsoft.Build Microsoft.CSharp Microsoft.VisualC Microsoft.Web.Infrastructure	\
	Mono.C5 Mono.CSharp Mono.Cairo Mono.Cecil Mono.CodeContracts Mono.CompilerServices.SymbolWriter Mono.Data.Sqlite	\
	Mono.Data.Tds Mono.Debugger.Soft Mono.Http Mono.Management Mono.Messaging.RabbitMQ Mono.Messaging Mono.Options	\
	Mono.Parallel Mono.Posix Mono.Security.Win32 Mono.Security Mono.Simd Mono.Tasklets Mono.WebBrowser Mono.XBuild.Tasks	\
	Novell.Directory.Ldap PEAPI RabbitMQ.Client SMDiagnostics System.ComponentModel.Composition	\
	System.ComponentModel.DataAnnotations System.Configuration.Install System.Configuration System.Core	\
	System.Data.DataSetExtensions System.Data.Entity System.Data.Linq System.Data.OracleClient	\
	System.Data.Services.Client System.Data.Services System.Data System.Design System.DirectoryServices.Protocols	\
	System.DirectoryServices System.Drawing.Design System.Drawing System.Dynamic System.EnterpriseServices	\
	System.IO.Compression.FileSystem System.IO.Compression System.IdentityModel.Selectors System.IdentityModel	\
	System.Json.Microsoft System.Json System.Management System.Messaging System.Net.Http.Formatting	\
	System.Net.Http.WebRequest System.Net.Http System.Net System.Numerics System.Reactive.Core System.Reactive.Debugger	\
	System.Reactive.Experimental System.Reactive.Interfaces System.Reactive.Linq System.Reactive.Observable.Aliases	\
	System.Reactive.PlatformServices System.Reactive.Providers System.Reactive.Runtime.Remoting System.Reactive.Windows.Forms	\
	System.Reactive.Windows.Threading System.Runtime.Caching System.Runtime.DurableInstancing System.Runtime.Remoting	\
	System.Runtime.Serialization.Formatters.Soap System.Runtime.Serialization System.Security System.ServiceModel.Activation	\
	System.ServiceModel.Discovery System.ServiceModel.Internals System.ServiceModel.Routing System.ServiceModel.Web	\
	System.ServiceModel System.ServiceProcess System.Threading.Tasks.Dataflow System.Transactions System.Web.Abstractions	\
	System.Web.ApplicationServices System.Web.DynamicData System.Web.Extensions.Design System.Web.Extensions	\
	System.Web.Http.SelfHost System.Web.Http.WebHost System.Web.Http System.Web.Mvc System.Web.Razor System.Web.Routing	\
	System.Web.Services System.Web.WebPages.Deployment System.Web.WebPages.Razor System.Web.WebPages System.Web	\
	System.Windows.Forms.DataVisualization System.Windows.Forms System.Windows System.Xaml System.Xml.Linq	\
	System.Xml.Serialization System.Xml System WebMatrix.Data WindowsBase cscompmgd monodoc mscorlib

ASSEMBLIES += bare/System bare/System.Xml bare/System.Configuration bare/System.ServiceModel.Activation bare/System.Web

FACADE_ASSEMBLIES := Facades/System.Collections.Concurrent Facades/System.Net.Primitives Facades/System.Runtime	\
	Facades/System.Collections Facades/System.Net.Requests Facades/System.Security.Principal	\
	Facades/System.ComponentModel.Annotations Facades/System.ObjectModel Facades/System.ServiceModel.Duplex	\
	Facades/System.ComponentModel.EventBasedAsync Facades/System.Reflection.Emit.ILGeneration Facades/System.ServiceModel.Http	\
	Facades/System.ComponentModel Facades/System.Reflection.Emit.Lightweight Facades/System.ServiceModel.NetTcp	\
	Facades/System.Diagnostics.Contracts Facades/System.Reflection.Emit Facades/System.ServiceModel.Primitives	\
	Facades/System.Diagnostics.Debug Facades/System.Reflection.Extensions Facades/System.ServiceModel.Security	\
	Facades/System.Diagnostics.Tools Facades/System.Reflection.Primitives Facades/System.Text.Encoding.Extensions	\
	Facades/System.Diagnostics.Tracing Facades/System.Reflection Facades/System.Text.Encoding	\
	Facades/System.Dynamic.Runtime Facades/System.Resources.ResourceManager Facades/System.Text.RegularExpressions	\
	Facades/System.Globalization Facades/System.Runtime.Extensions Facades/System.Threading.Tasks.Parallel	\
	Facades/System.IO Facades/System.Runtime.InteropServices.WindowsRuntime Facades/System.Threading.Tasks	\
	Facades/System.Linq.Expressions Facades/System.Runtime.InteropServices Facades/System.Threading.Timer	\
	Facades/System.Linq.Parallel Facades/System.Runtime.Numerics Facades/System.Threading	\
	Facades/System.Linq.Queryable Facades/System.Runtime.Serialization.Json Facades/System.Xml.ReaderWriter	\
	Facades/System.Linq Facades/System.Runtime.Serialization.Primitives Facades/System.Xml.XDocument	\
	Facades/System.Net.NetworkInformation Facades/System.Runtime.Serialization.Xml Facades/System.Xml.XmlSerializer

ASSEMBLIES += $(FACADE_ASSEMBLIES)

# generated with (and then slightly tweaked):
# for i in *.dll; do ikdasm --assemblyref $i | grep Name= | sed 's/.*Name=//g' | sed -e $'s/$/\\\n/g' | sed -e ':a' -e 'N' -e '$!ba' -e 's/\n/ /g' -e "s/^/${i%.*}_REFS := /"; done
Accessibility_REFS := mscorlib
Commons.Xml.Relaxng_REFS := System.Xml mscorlib System
CustomMarshalers_REFS := mscorlib
I18N.CJK_REFS := mscorlib I18N
I18N.MidEast_REFS := mscorlib I18N
I18N.Other_REFS := mscorlib I18N
I18N.Rare_REFS := mscorlib I18N
I18N.West_REFS := mscorlib I18N
I18N_REFS := mscorlib
IBM.Data.DB2_REFS := mscorlib System.Data System System.Xml
ICSharpCode.SharpZipLib_REFS := mscorlib
Microsoft.Build.Engine_REFS := mscorlib System System.Xml Microsoft.Build.Framework Microsoft.Build.Utilities.v4.0
Microsoft.Build.Framework_REFS := mscorlib
Microsoft.Build.Tasks.v4.0_REFS := mscorlib Microsoft.Build.Utilities.v4.0 Mono.XBuild.Tasks Microsoft.Build.Framework System System.Xml
Microsoft.Build.Utilities.v4.0_REFS := Microsoft.Build.Framework mscorlib System
Microsoft.Build_REFS := mscorlib Microsoft.Build.Framework System System.Xml
Microsoft.CSharp_REFS := mscorlib Mono.CSharp System.Core
Microsoft.VisualC_REFS := mscorlib
Microsoft.Web.Infrastructure_REFS := System.Web mscorlib System
Mono.C5_REFS := mscorlib
Mono.CSharp_REFS := mscorlib System System.Core System.Xml
Mono.Cairo_REFS := mscorlib
Mono.Cecil_REFS := mscorlib
Mono.CodeContracts_REFS := mscorlib Mono.Cecil System System.Core
Mono.CompilerServices.SymbolWriter_REFS := mscorlib System
Mono.Data.Sqlite_REFS := mscorlib System.Data System System.Xml System.Transactions
Mono.Data.Tds_REFS := mscorlib System
Mono.Debugger.Soft_REFS := mscorlib Mono.Cecil System.Core System
Mono.Http_REFS := System mscorlib ICSharpCode.SharpZipLib Mono.Security System.Web System.Xml
Mono.Management_REFS := mscorlib
Mono.Messaging.RabbitMQ_REFS := RabbitMQ.Client Mono.Messaging mscorlib System
Mono.Messaging_REFS := mscorlib System
Mono.Options_REFS := mscorlib System
Mono.Parallel_REFS := mscorlib
Mono.Posix_REFS := System mscorlib
Mono.Security_REFS := mscorlib bare/System
Mono.Security.Win32_REFS := mscorlib
Mono.Simd_REFS := mscorlib
Mono.Tasklets_REFS := mscorlib
Mono.WebBrowser_REFS := mscorlib System
Mono.XBuild.Tasks_REFS := mscorlib System.Xml
Novell.Directory.Ldap_REFS := mscorlib System
PEAPI_REFS := mscorlib
RabbitMQ.Client_REFS := mscorlib System System.Xml
SMDiagnostics_REFS := mscorlib System.ServiceModel.Internals System System.Configuration System.Xml
System.ComponentModel.Composition_REFS := mscorlib System.Core System
System.ComponentModel.DataAnnotations_REFS := mscorlib System
System.Configuration.Install_REFS := mscorlib System
System.Configuration_REFS := mscorlib System bare/System.Xml
System.Core_REFS := mscorlib System
System.Data.DataSetExtensions_REFS := mscorlib System.Data System.Xml System
System.Data.Entity_REFS := System mscorlib System.Xml System.Core System.Data System.Transactions System.Runtime.Serialization System.ComponentModel.DataAnnotations
System.Data.Linq_REFS := mscorlib System.Data System System.Core System.Xml System.Runtime.Serialization
System.Data.OracleClient_REFS := mscorlib System.Data System.Drawing System.Xml System System.EnterpriseServices
System.Data.Services.Client_REFS := mscorlib System.Core System System.Xml System.Xml.Linq
System.Data.Services_REFS := mscorlib System.Core System System.Data.Services.Client System.ServiceModel System.ServiceModel.Web System.ServiceModel.Activation
System.Data_REFS := mscorlib System System.Numerics System.Xml System.Transactions Mono.Data.Tds System.EnterpriseServices System.Configuration
System.Design_REFS := Accessibility mscorlib System System.Windows.Forms System.Data System.Drawing System.Xml bare/System.Web System.Configuration
System.DirectoryServices.Protocols_REFS := System.DirectoryServices mscorlib System System.Xml
System.DirectoryServices_REFS := Novell.Directory.Ldap mscorlib System
System.Drawing.Design_REFS := System.Windows.Forms System.Drawing mscorlib System
System.Drawing_REFS := mscorlib System
System.Dynamic_REFS := mscorlib System.Core System
System.EnterpriseServices_REFS := mscorlib System.Transactions
System.IO.Compression.FileSystem_REFS := mscorlib System System.IO.Compression
System.IO.Compression_REFS := mscorlib System
System.IdentityModel.Selectors_REFS := System.Xml mscorlib System System.IdentityModel
System.IdentityModel_REFS := mscorlib System System.Configuration System.Xml System.Web.ApplicationServices System.Runtime.Serialization
System.Json.Microsoft_REFS := System.Core mscorlib System System.Runtime.Serialization
System.Json_REFS := mscorlib System
System.Management_REFS := mscorlib System System.Configuration.Install
System.Messaging_REFS := mscorlib Mono.Messaging System System.Configuration.Install System.Windows.Forms System.Drawing
System.Net.Http.Formatting_REFS := mscorlib System.Net.Http System System.Runtime.Serialization System.Core System.Xml System.Xml.Linq System.Data
System.Net.Http.WebRequest_REFS := System mscorlib System.Net.Http
System.Net.Http_REFS := mscorlib System
System.Net_REFS := mscorlib System
System.Numerics_REFS := mscorlib
System.Reactive.Core_REFS := mscorlib System System.Reactive.Interfaces System.Core
System.Reactive.Debugger_REFS := System.Reactive.Linq mscorlib
System.Reactive.Experimental_REFS := mscorlib System.Reactive.Linq System.Reactive.Core System.Core System.Reactive.Interfaces
System.Reactive.Interfaces_REFS := mscorlib System.Core
System.Reactive.Linq_REFS := System.Reactive.Core System mscorlib System.Reactive.Interfaces System.Core
System.Reactive.Observable.Aliases_REFS := mscorlib System.Reactive.Interfaces System.Core
System.Reactive.PlatformServices_REFS := mscorlib System.Reactive.Interfaces System.Reactive.Core System System.Core
System.Reactive.Providers_REFS := System.Core System.Reactive.Interfaces mscorlib System System.Reactive.Core System.Reactive.Linq
System.Reactive.Runtime.Remoting_REFS := mscorlib System.Reactive.Interfaces
System.Reactive.Windows.Forms_REFS := System.Windows.Forms mscorlib System.Reactive.Interfaces System.Reactive.Core System
System.Reactive.Windows.Threading_REFS := WindowsBase mscorlib System System.Reactive.Interfaces System.Reactive.Core
System.Runtime.Caching_REFS := System mscorlib System.Configuration System.Data
System.Runtime.DurableInstancing_REFS := System.Xml.Linq mscorlib System.Transactions System.Core System.ServiceModel.Internals System System.Runtime.Serialization
System.Runtime.Remoting_REFS := mscorlib System.Runtime.Serialization.Formatters.Soap System System.Xml System.Web
System.Runtime.Serialization.Formatters.Soap_REFS := System.Xml mscorlib
System.Runtime.Serialization_REFS := mscorlib System.Xml System System.Configuration System.ServiceModel.Internals
System.Security_REFS := mscorlib System.Xml System Mono.Security
System.ServiceModel.Activation_REFS := mscorlib System.ServiceModel System
System.ServiceModel.Discovery_REFS := System.ServiceModel System mscorlib System.Configuration System.Runtime.Serialization System.Xml System.Xml.Linq
System.ServiceModel.Internals_REFS := mscorlib System System.Xml
System.ServiceModel.Routing_REFS := System.ServiceModel mscorlib System.Configuration System.Xml
System.ServiceModel.Web_REFS := System.ServiceModel mscorlib System.Runtime.Serialization System.Configuration System System.Xml System.ServiceModel.Activation
System.ServiceModel_REFS := mscorlib System System.Runtime.Serialization System.Xml Mono.Security System.Web System.IdentityModel System.Security System.Messaging System.Core System.Transactions System.Configuration System.Web.Services System.Web.ApplicationServices System.IdentityModel.Selectors bare/System.ServiceModel.Activation
System.ServiceProcess_REFS := System mscorlib System.Configuration.Install System.Windows.Forms
System.Threading.Tasks.Dataflow_REFS := mscorlib System
System.Transactions_REFS := mscorlib System.Configuration
System.Web.Abstractions_REFS := mscorlib System System.Web
System.Web.ApplicationServices_REFS := System mscorlib System.Configuration
System.Web.DynamicData_REFS := mscorlib System.Data.Linq System System.Web System.Web.Extensions System.Core System.ComponentModel.DataAnnotations System.Drawing
System.Web.Extensions.Design_REFS := mscorlib System System.Design System.Drawing System.Windows.Forms
System.Web.Extensions_REFS := mscorlib System.Core System System.Web System.Web.ApplicationServices System.Configuration System.Web.Services System.Xml System.ServiceModel System.Drawing
System.Web.Http.SelfHost_REFS := mscorlib System.Net.Http System.ServiceModel System System.Runtime.Serialization System.IdentityModel System.Web.Http
System.Web.Http.WebHost_REFS := mscorlib System.Web.Http System.Web System.Net.Http System
System.Web.Http_REFS := mscorlib System.Net.Http System.Core System.Net.Http.Formatting System System.ComponentModel.DataAnnotations System.Runtime.Serialization System.Xml
System.Web.Mvc_REFS := mscorlib System.Web System.Core System.ComponentModel.DataAnnotations System.Runtime.Caching System.Web.Razor System.Web.WebPages System System.Web.WebPages.Razor
System.Web.Razor_REFS := mscorlib System
System.Web.Routing_REFS := mscorlib System.Web
System.Web.Services_REFS := mscorlib System System.Configuration bare/System.Web System.Xml System.Design System.DirectoryServices System.EnterpriseServices
System.Web.WebPages.Deployment_REFS := mscorlib System System.Web
System.Web.WebPages.Razor_REFS := mscorlib System.Web System.Configuration System System.Web.Razor
System.Web.WebPages_REFS := mscorlib System.Web System System.ComponentModel.DataAnnotations System.Core
System.Web_REFS := mscorlib System.Drawing System System.Xml System.Core System.Configuration System.Data System.Web.Services System.Web.ApplicationServices System.ComponentModel.DataAnnotations Mono.Data.Sqlite System.EnterpriseServices
System.Windows.Forms.DataVisualization_REFS := System.Drawing mscorlib System System.Windows.Forms System.Xml System.Data
System.Windows.Forms_REFS := mscorlib System System.Xml System.Drawing Mono.WebBrowser System.Configuration Mono.Posix Accessibility
System.Windows_REFS := mscorlib System
System.Xaml_REFS := mscorlib System System.Xml
System.Xml.Linq_REFS := System.Xml mscorlib System.Runtime.Serialization System
System.Xml.Serialization_REFS := mscorlib System.Xml System.ServiceModel
System.Xml_REFS := mscorlib System System.Configuration
System_REFS := mscorlib bare/System.Configuration bare/System.Xml Mono.Security
WebMatrix.Data_REFS := System.Data mscorlib System System.Core
WindowsBase_REFS := mscorlib System System.Xml System.Xaml
cscompmgd_REFS := mscorlib
monodoc_REFS := ICSharpCode.SharpZipLib mscorlib System System.Xml System.Xml.Linq System.Core System.Configuration
mscorlib_REFS :=

bare/System_REFS := mscorlib
bare/System.Xml_REFS := mscorlib bare/System
bare/System.Configuration_REFS := mscorlib bare/System bare/System.Xml
bare/System.ServiceModel.Activation_REFS := mscorlib System
bare/System.Web_REFS := mscorlib System.Drawing System System.Xml System.Core System.Configuration System.Data System.Web.ApplicationServices System.ComponentModel.DataAnnotations Mono.Data.Sqlite System.EnterpriseServices

Facades/System.Collections.Concurrent_REFS := mscorlib System
Facades/System.Collections_REFS := mscorlib System.Core System
Facades/System.ComponentModel.Annotations_REFS := mscorlib System.ComponentModel.DataAnnotations
Facades/System.ComponentModel.EventBasedAsync_REFS := mscorlib System
Facades/System.ComponentModel_REFS := mscorlib System
Facades/System.Diagnostics.Contracts_REFS := mscorlib
Facades/System.Diagnostics.Debug_REFS := mscorlib System
Facades/System.Diagnostics.Tools_REFS := mscorlib System
Facades/System.Diagnostics.Tracing_REFS := mscorlib
Facades/System.Dynamic.Runtime_REFS := mscorlib System System.Core
Facades/System.Globalization_REFS := mscorlib
Facades/System.IO_REFS := mscorlib System
Facades/System.Linq.Expressions_REFS := mscorlib System.Core
Facades/System.Linq.Parallel_REFS := mscorlib System.Core
Facades/System.Linq.Queryable_REFS := mscorlib System.Core
Facades/System.Linq_REFS := mscorlib System.Core
Facades/System.Net.NetworkInformation_REFS := mscorlib System
Facades/System.Net.Primitives_REFS := mscorlib System
Facades/System.Net.Requests_REFS := mscorlib System
Facades/System.ObjectModel_REFS := mscorlib System
Facades/System.Reflection.Emit.ILGeneration_REFS := mscorlib
Facades/System.Reflection.Emit.Lightweight_REFS := mscorlib
Facades/System.Reflection.Emit_REFS := mscorlib
Facades/System.Reflection.Extensions_REFS := mscorlib
Facades/System.Reflection.Primitives_REFS := mscorlib
Facades/System.Reflection_REFS := mscorlib
Facades/System.Resources.ResourceManager_REFS := mscorlib
Facades/System.Runtime.Extensions_REFS := mscorlib System
Facades/System.Runtime.InteropServices.WindowsRuntime_REFS := mscorlib
Facades/System.Runtime.InteropServices_REFS := mscorlib System
Facades/System.Runtime.Numerics_REFS := mscorlib System.Numerics
Facades/System.Runtime.Serialization.Json_REFS := mscorlib System.Runtime.Serialization
Facades/System.Runtime.Serialization.Primitives_REFS := mscorlib System.Runtime.Serialization
Facades/System.Runtime.Serialization.Xml_REFS := mscorlib System.Runtime.Serialization System.Xml
Facades/System.Runtime_REFS := mscorlib System.Core System System.ComponentModel.Composition
Facades/System.Security.Principal_REFS := mscorlib
Facades/System.ServiceModel.Duplex_REFS := mscorlib System.ServiceModel
Facades/System.ServiceModel.Http_REFS := mscorlib System.ServiceModel
Facades/System.ServiceModel.NetTcp_REFS := mscorlib System.ServiceModel
Facades/System.ServiceModel.Primitives_REFS := mscorlib System.ServiceModel System.Xml
Facades/System.ServiceModel.Security_REFS := mscorlib System.ServiceModel
Facades/System.Text.Encoding.Extensions_REFS := mscorlib
Facades/System.Text.Encoding_REFS := mscorlib
Facades/System.Text.RegularExpressions_REFS := mscorlib System
Facades/System.Threading.Tasks.Parallel_REFS := mscorlib
Facades/System.Threading.Tasks_REFS := mscorlib System.Core
Facades/System.Threading.Timer_REFS := mscorlib
Facades/System.Threading_REFS := mscorlib System System.Core
Facades/System.Xml.ReaderWriter_REFS := mscorlib System.Xml
Facades/System.Xml.XDocument_REFS := mscorlib System.Xml.Linq System.Xml
Facades/System.Xml.XmlSerializer_REFS := mscorlib System.Xml

mscorlib_CSC_ARGS := -runtimemetadataversion:v4.0.30319
System_CSC_ARGS := -d:CONFIG_DEP -d:XML_DEP
System.Configuration_CSC_ARGS := -d:CONFIG_DEP
System.Xml_CSC_ARGS := -d:CONFIG_DEP
System.ServiceModel.Activation_CSC_ARGS := -d:SERVICEMODEL_DEP
System.Web_CSC_ARGS := -d:SERVICES_DEP

MONO_KEY := ../../../mcs/class/mono.pub
ECMA_KEY := ../../../mcs/class/ecma.pub
WINFX_KEY := ../../../mcs/class/winfx.pub
MSFINAL_KEY := ../../../mcs/class/msfinal.pub

Mono.C5_KEYFILE := ../../../mcs/class/Mono.C5/c5.pub
IBM.Data.DB2_KEYFILE := ../../../mcs/class/IBM.Data.DB2/ibm.pub
ICSharpCode.SharpZipLib_KEYFILE := ../../../mcs/class/ICSharpCode.SharpZipLib/SharpZipLib.pub

MONO_KEY_ASSEMBLIES := Commons.Xml.Relaxng I18N.CJK I18N.MidEast I18N.Other I18N.Rare I18N.West I18N Mono.CSharp	\
	Mono.Cairo Mono.Cecil Mono.CodeContracts Mono.CompilerServices.SymbolWriter Mono.Data.Sqlite Mono.Data.Tds	\
	Mono.Debugger.Soft Mono.Http Mono.Management Mono.Messaging.RabbitMQ Mono.Messaging Mono.Options Mono.Parallel	\
	Mono.Posix Mono.Security.Win32 Mono.Security Mono.Simd Mono.Tasklets Mono.WebBrowser Mono.XBuild.Tasks	\
	Novell.Directory.Ldap PEAPI monodoc WebMatrix.Data

ECMA_KEY_ASSEMBLIES := SMDiagnostics System.ComponentModel.Composition System.Core System.Data.DataSetExtensions	\
	System.Data.Entity System.Data.Linq System.Data.OracleClient System.Data.Services.Client System.Data.Services	\
	System.Data System.IO.Compression.FileSystem System.IO.Compression System.IdentityModel.Selectors System.IdentityModel	\
	System.Dynamic System.Numerics System.Runtime.Remoting System.Runtime.Serialization System.ServiceModel.Internals	\
	System.ServiceModel System.Threading.Tasks.Dataflow System.Transactions System.Windows.Forms System.Xaml	\
	System.Xml.Linq System.Xml.Serialization System.Xml System mscorlib bare/System bare/System.Xml

WINFX_KEY_ASSEMBLIES := System.ComponentModel.DataAnnotations Microsoft.Web.Infrastructure System.Json.Microsoft	\
	System.Json System.Net.Http.Formatting System.Reactive.Core System.Reactive.Debugger System.Reactive.Experimental	\
	System.Reactive.Interfaces System.Reactive.Linq System.Reactive.Observable.Aliases System.Reactive.PlatformServices	\
	System.Reactive.Providers System.Reactive.Runtime.Remoting System.Reactive.Windows.Forms System.Reactive.Windows.Threading	\
	System.Runtime.DurableInstancing System.ServiceModel.Activation System.ServiceModel.Discovery System.ServiceModel.Routing	\
	System.ServiceModel.Web System.Web.Abstractions System.Web.ApplicationServices System.Web.DynamicData	\
	System.Web.Extensions.Design System.Web.Extensions System.Web.Http.SelfHost System.Web.Http.WebHost System.Web.Http	\
	System.Web.Mvc System.Web.Razor System.Web.Routing System.Web.WebPages.Deployment System.Web.WebPages.Razor	\
	System.Web.WebPages System.Windows.Forms.DataVisualization WindowsBase bare/System.ServiceModel.Activation

MSFINAL_KEY_ASSEMBLIES := Accessibility CustomMarshalers Microsoft.Build.Engine Microsoft.Build.Framework	\
	Microsoft.Build.Tasks.v4.0 Microsoft.Build.Utilities.v4.0 Microsoft.Build Microsoft.CSharp Microsoft.VisualC	\
	RabbitMQ.Client System.Configuration.Install System.Configuration System.Design System.DirectoryServices.Protocols	\
	System.DirectoryServices System.Drawing.Design System.Drawing System.EnterpriseServices System.Management	\
	System.Messaging System.Net.Http.WebRequest System.Net.Http System.Net System.Runtime.Caching	\
	System.Runtime.Serialization.Formatters.Soap System.Security System.ServiceProcess System.Web.Services	\
	System.Web System.Windows cscompmgd bare/System.Configuration bare/System.Web

all: $(addsuffix .dll, $(ASSEMBLIES))

clean:
	rm -f *.dll
	rm -f bare/*.dll
	rm -f bare/.stamp
	rm -f Facades/*.dll

bare/.stamp:
	@mkdir -p bare/ && touch $@

define KEYFILE_TEMPLATE
$(1)_KEYFILE := $(2)
endef

define ASSEMBLY_TEMPLATE
$(1).dll: $(addprefix $(SOURCEDIR),$(subst bare/,,$(1)).cs) $(wildcard $(SOURCEDIR)$(1).extra.cs) $(addsuffix .dll, $($(1)_REFS)) $($(1)_KEYFILE) Makefile bare/.stamp
	$(Q_CSC) $(CSC) -out:$(1).dll $(CSC_COMMON_ARGS) -keyfile:$($(1)_KEYFILE) $($(1)_CSC_ARGS) $(addprefix -r:, $(addsuffix .dll, $($(1)_REFS))) $(wildcard $(SOURCEDIR)$(1).extra.cs) $$<
endef

$(foreach asm, $(MONO_KEY_ASSEMBLIES),    $(eval $(call KEYFILE_TEMPLATE,$(asm), $(MONO_KEY))))
$(foreach asm, $(ECMA_KEY_ASSEMBLIES),    $(eval $(call KEYFILE_TEMPLATE,$(asm), $(ECMA_KEY))))
$(foreach asm, $(WINFX_KEY_ASSEMBLIES),   $(eval $(call KEYFILE_TEMPLATE,$(asm), $(WINFX_KEY))))
$(foreach asm, $(MSFINAL_KEY_ASSEMBLIES), $(eval $(call KEYFILE_TEMPLATE,$(asm), $(MSFINAL_KEY))))
$(foreach asm, $(FACADE_ASSEMBLIES),      $(eval $(call KEYFILE_TEMPLATE,$(asm), $(MSFINAL_KEY))))

$(foreach asm, $(ASSEMBLIES), $(eval $(call ASSEMBLY_TEMPLATE,$(asm))))
