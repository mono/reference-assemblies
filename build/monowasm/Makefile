PROFILE := monowasm
SOURCEDIR := ../../src/$(PROFILE)/

CSC ?= csc
CSC_COMMON_ARGS := -nologo -noconfig -optimize -nostdlib -unsafe -deterministic -debug- -target:library -nowarn:612,618,809
CSC_COMMON_ARGS2 := -nologo -noconfig -optimize -unsafe -deterministic -debug- -target:library -nowarn:612,618,809
Q_CSC = $(if $(V),,@echo "CSC   [$(PROFILE)] $(1)";)

ASSEMBLIES := mscorlib System System.Core System.Net.Http WebAssembly.Bindings WebAssembly.Net.Http WebAssembly.Net.WebSockets

ASSEMBLIES += bare/System

# generated with (and then slightly tweaked):
# for i in *.dll; do ikdasm --assemblyref $i | grep Name= | sed 's/.*Name=//g' | sed -e $'s/$/\\\n/g' | sed -e ':a' -e 'N' -e '$!ba' -e 's/\n/ /g' -e "s/^/${i%.*}_REFS := /"; done
System.Core_REFS := mscorlib System
System.Net.Http_REFS := mscorlib System
System_REFS := mscorlib
WebAssembly.Bindings_REFS := mscorlib System System.Memory 
WebAssembly.Net.Http_REFS := mscorlib System System.Core System.Net.Http WebAssembly.Bindings
WebAssembly.Net.WebSockets_REFS := mscorlib System WebAssembly.Bindings

bare/System_REFS := mscorlib

mscorlib_CSC_ARGS := -runtimemetadataversion:v4.0.30319
System_CSC_ARGS := ../../src/mono/System.extra.cs

all: $(addsuffix .dll, $(ASSEMBLIES))

# System.Memory is from the wasm sdk Facades build.
clean:
	mv System.Memory.dll System.Memory.dll1
	rm -f *.dll
	rm -f bare/*.dll
	mv System.Memory.dll1 System.Memory.dll

define ASSEMBLY_TEMPLATE
$(1).dll: $(addprefix $(SOURCEDIR),$(subst bare/,,$(1)).cs) $(wildcard $(SOURCEDIR)$(1).extra.cs) $(addsuffix .dll, $($(1)_REFS)) $($(1)_KEYFILE)
	@mkdir -p bare/
	$(Q_CSC) $(CSC) -out:$(1).dll $(CSC_COMMON_ARGS) $($(1)_CSC_ARGS) $(addprefix -r:, $(addsuffix .dll, $($(1)_REFS))) $(wildcard $(SOURCEDIR)$(1).extra.cs) $$<
endef

$(foreach asm, $(ASSEMBLIES), $(eval $(call ASSEMBLY_TEMPLATE,$(asm))))
