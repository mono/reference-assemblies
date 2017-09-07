Mono binary reference assemblies repository.

Built using csc 2.1.0.

Use the following steps to add a new .NET profile:

```bash
NETFXPROFILE=v4.7.1


cd $NETFXPROFILE-ms
for i in *.dll; do mono ../../api-snapshot/tools/genapi/GenAPI.exe -assembly:$i -out:../src/$NETFXPROFILE -typeforwardedTo -assemblyVersion -assemblyAttributes -headerFile:../../api-snapshot/profiles/license-header.txt -libPath:.; done

cd ../src/$NETFXPROFILE
for i in *.cs; do sed -i "" 's/AssemblyCompanyAttribute("Microsoft Corporation")/AssemblyCompanyAttribute("Mono development team")/g' $i; done
for i in *.cs; do sed -i "" 's/AssemblyCopyrightAttribute("© Microsoft Corporation.  All rights reserved.")/AssemblyCopyrightAttribute("(c) Various Mono authors")/g' $i; done
for i in *.cs; do sed -i "" 's/AssemblyProductAttribute("Microsoft® .NET Framework")/AssemblyProductAttribute("Mono Common Language Infrastructure")/g' $i; done
for i in *.cs; do sed -i "" '/.*AssemblySignatureKeyAttribute(.*]/d' $i; done
for i in *.cs; do sed -i "" '/.*InternalsVisibleToAttribute(.*]/d' $i; done
for i in *.cs; do sed -i "" '/.*DependencyAttribute(.*]/d' $i; done

... Revert changes to Accessibility.cs, Microsoft.VisualC.cs and Microsoft.VisualBasic.cs (bug in GenApi) ...
... Revert changes to System.Workflow.*.cs, System.Web.Mobile.cs and System.Deployment.cs (we only have stub assemblies) ...
... Revert changes to System.Web.WebPages.*.cs, System.Web.Http.*.cs, System.Web.Razor.cs, System.Web.Mvc.cs, System.Net.Http.Formatting.cs and System.Json.Microsoft.cs (wrong AssemblyCompanyAttribute sed replacement) ...
... Revert changes that remove #if / #endif ...
```