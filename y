[33mcommit f24b7fdddd4dde06ecae0c775f41f8fb240c0bcc[m
Author: Bilatchuk Ivan <ivanquade07@gmail.com>
Date:   Thu Sep 4 21:43:06 2025 +0300

    test

[1mdiff --git a/Lab01/.idea/.idea.Lab01/.idea/.gitignore b/Lab01/.idea/.idea.Lab01/.idea/.gitignore[m
[1mnew file mode 100644[m
[1mindex 0000000..ea4e687[m
[1m--- /dev/null[m
[1m+++ b/Lab01/.idea/.idea.Lab01/.idea/.gitignore[m
[36m@@ -0,0 +1,13 @@[m
[32m+[m[32m# Default ignored files[m
[32m+[m[32m/shelf/[m
[32m+[m[32m/workspace.xml[m
[32m+[m[32m# Rider ignored files[m
[32m+[m[32m/modules.xml[m
[32m+[m[32m/projectSettingsUpdater.xml[m
[32m+[m[32m/contentModel.xml[m
[32m+[m[32m/.idea.Lab01.iml[m
[32m+[m[32m# Editor-based HTTP Client requests[m
[32m+[m[32m/httpRequests/[m
[32m+[m[32m# Datasource local storage ignored files[m
[32m+[m[32m/dataSources/[m
[32m+[m[32m/dataSources.local.xml[m
[1mdiff --git a/Lab01/.idea/.idea.Lab01/.idea/indexLayout.xml b/Lab01/.idea/.idea.Lab01/.idea/indexLayout.xml[m
[1mnew file mode 100644[m
[1mindex 0000000..7b08163[m
[1m--- /dev/null[m
[1m+++ b/Lab01/.idea/.idea.Lab01/.idea/indexLayout.xml[m
[36m@@ -0,0 +1,8 @@[m
[32m+[m[32m<?xml version="1.0" encoding="UTF-8"?>[m
[32m+[m[32m<project version="4">[m
[32m+[m[32m  <component name="UserContentModel">[m
[32m+[m[32m    <attachedFolders />[m
[32m+[m[32m    <explicitIncludes />[m
[32m+[m[32m    <explicitExcludes />[m
[32m+[m[32m  </component>[m
[32m+[m[32m</project>[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Lab01.sln b/Lab01/Lab01.sln[m
[1mnew file mode 100644[m
[1mindex 0000000..785f998[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Lab01.sln[m
[36m@@ -0,0 +1,28 @@[m
[32m+[m[32m﻿[m
[32m+[m[32mMicrosoft Visual Studio Solution File, Format Version 12.00[m
[32m+[m[32mProject("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "Task1", "Task1\Task1.csproj", "{823E57D7-D7E6-4845-87EC-05DB79E319DA}"[m
[32m+[m[32mEndProject[m
[32m+[m[32mProject("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "Task2", "Task2\Task2.csproj", "{33B0535B-9099-4CA7-BF89-9A480E555850}"[m
[32m+[m[32mEndProject[m
[32m+[m[32mProject("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "Task3", "Task3\Task3.csproj", "{CA2DECC9-BDF0-489F-BB22-9876C7413E86}"[m
[32m+[m[32mEndProject[m
[32m+[m[32mGlobal[m
[32m+[m	[32mGlobalSection(SolutionConfigurationPlatforms) = preSolution[m
[32m+[m		[32mDebug|Any CPU = Debug|Any CPU[m
[32m+[m		[32mRelease|Any CPU = Release|Any CPU[m
[32m+[m	[32mEndGlobalSection[m
[32m+[m	[32mGlobalSection(ProjectConfigurationPlatforms) = postSolution[m
[32m+[m		[32m{823E57D7-D7E6-4845-87EC-05DB79E319DA}.Debug|Any CPU.ActiveCfg = Debug|Any CPU[m
[32m+[m		[32m{823E57D7-D7E6-4845-87EC-05DB79E319DA}.Debug|Any CPU.Build.0 = Debug|Any CPU[m
[32m+[m		[32m{823E57D7-D7E6-4845-87EC-05DB79E319DA}.Release|Any CPU.ActiveCfg = Release|Any CPU[m
[32m+[m		[32m{823E57D7-D7E6-4845-87EC-05DB79E319DA}.Release|Any CPU.Build.0 = Release|Any CPU[m
[32m+[m		[32m{33B0535B-9099-4CA7-BF89-9A480E555850}.Debug|Any CPU.ActiveCfg = Debug|Any CPU[m
[32m+[m		[32m{33B0535B-9099-4CA7-BF89-9A480E555850}.Debug|Any CPU.Build.0 = Debug|Any CPU[m
[32m+[m		[32m{33B0535B-9099-4CA7-BF89-9A480E555850}.Release|Any CPU.ActiveCfg = Release|Any CPU[m
[32m+[m		[32m{33B0535B-9099-4CA7-BF89-9A480E555850}.Release|Any CPU.Build.0 = Release|Any CPU[m
[32m+[m		[32m{CA2DECC9-BDF0-489F-BB22-9876C7413E86}.Debug|Any CPU.ActiveCfg = Debug|Any CPU[m
[32m+[m		[32m{CA2DECC9-BDF0-489F-BB22-9876C7413E86}.Debug|Any CPU.Build.0 = Debug|Any CPU[m
[32m+[m		[32m{CA2DECC9-BDF0-489F-BB22-9876C7413E86}.Release|Any CPU.ActiveCfg = Release|Any CPU[m
[32m+[m		[32m{CA2DECC9-BDF0-489F-BB22-9876C7413E86}.Release|Any CPU.Build.0 = Release|Any CPU[m
[32m+[m	[32mEndGlobalSection[m
[32m+[m[32mEndGlobal[m
[1mdiff --git a/Lab01/Task1/FavoriteColor.cs b/Lab01/Task1/FavoriteColor.cs[m
[1mnew file mode 100644[m
[1mindex 0000000..bbf4c41[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task1/FavoriteColor.cs[m
[36m@@ -0,0 +1,9 @@[m
[32m+[m[32m﻿using System;[m
[32m+[m
[32m+[m[32mclass FavoriteColor[m
[32m+[m[32m{[m
[32m+[m[32m    static void Main()[m
[32m+[m[32m    {[m
[32m+[m[32m        Console.WriteLine("My fav color is red.");[m
[32m+[m[32m    }[m
[32m+[m[32m}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task1/Task1.csproj b/Lab01/Task1/Task1.csproj[m
[1mnew file mode 100644[m
[1mindex 0000000..85b4959[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task1/Task1.csproj[m
[36m@@ -0,0 +1,10 @@[m
[32m+[m[32m﻿<Project Sdk="Microsoft.NET.Sdk">[m
[32m+[m
[32m+[m[32m    <PropertyGroup>[m
[32m+[m[32m        <OutputType>Exe</OutputType>[m
[32m+[m[32m        <TargetFramework>net9.0</TargetFramework>[m
[32m+[m[32m        <ImplicitUsings>enable</ImplicitUsings>[m
[32m+[m[32m        <Nullable>enable</Nullable>[m
[32m+[m[32m    </PropertyGroup>[m
[32m+[m
[32m+[m[32m</Project>[m
[1mdiff --git a/Lab01/Task1/bin/Debug/net9.0/Task1.deps.json b/Lab01/Task1/bin/Debug/net9.0/Task1.deps.json[m
[1mnew file mode 100644[m
[1mindex 0000000..bae2740[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task1/bin/Debug/net9.0/Task1.deps.json[m
[36m@@ -0,0 +1,23 @@[m
[32m+[m[32m{[m
[32m+[m[32m  "runtimeTarget": {[m
[32m+[m[32m    "name": ".NETCoreApp,Version=v9.0",[m
[32m+[m[32m    "signature": ""[m
[32m+[m[32m  },[m
[32m+[m[32m  "compilationOptions": {},[m
[32m+[m[32m  "targets": {[m
[32m+[m[32m    ".NETCoreApp,Version=v9.0": {[m
[32m+[m[32m      "Task1/1.0.0": {[m
[32m+[m[32m        "runtime": {[m
[32m+[m[32m          "Task1.dll": {}[m
[32m+[m[32m        }[m
[32m+[m[32m      }[m
[32m+[m[32m    }[m
[32m+[m[32m  },[m
[32m+[m[32m  "libraries": {[m
[32m+[m[32m    "Task1/1.0.0": {[m
[32m+[m[32m      "type": "project",[m
[32m+[m[32m      "serviceable": false,[m
[32m+[m[32m      "sha512": ""[m
[32m+[m[32m    }[m
[32m+[m[32m  }[m
[32m+[m[32m}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task1/bin/Debug/net9.0/Task1.dll b/Lab01/Task1/bin/Debug/net9.0/Task1.dll[m
[1mnew file mode 100644[m
[1mindex 0000000..31f1d48[m
Binary files /dev/null and b/Lab01/Task1/bin/Debug/net9.0/Task1.dll differ
[1mdiff --git a/Lab01/Task1/bin/Debug/net9.0/Task1.exe b/Lab01/Task1/bin/Debug/net9.0/Task1.exe[m
[1mnew file mode 100644[m
[1mindex 0000000..ab27794[m
Binary files /dev/null and b/Lab01/Task1/bin/Debug/net9.0/Task1.exe differ
[1mdiff --git a/Lab01/Task1/bin/Debug/net9.0/Task1.pdb b/Lab01/Task1/bin/Debug/net9.0/Task1.pdb[m
[1mnew file mode 100644[m
[1mindex 0000000..5a0726d[m
Binary files /dev/null and b/Lab01/Task1/bin/Debug/net9.0/Task1.pdb differ
[1mdiff --git a/Lab01/Task1/bin/Debug/net9.0/Task1.runtimeconfig.json b/Lab01/Task1/bin/Debug/net9.0/Task1.runtimeconfig.json[m
[1mnew file mode 100644[m
[1mindex 0000000..b19c3c8[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task1/bin/Debug/net9.0/Task1.runtimeconfig.json[m
[36m@@ -0,0 +1,12 @@[m
[32m+[m[32m{[m
[32m+[m[32m  "runtimeOptions": {[m
[32m+[m[32m    "tfm": "net9.0",[m
[32m+[m[32m    "framework": {[m
[32m+[m[32m      "name": "Microsoft.NETCore.App",[m
[32m+[m[32m      "version": "9.0.0"[m
[32m+[m[32m    },[m
[32m+[m[32m    "configProperties": {[m
[32m+[m[32m      "System.Runtime.Serialization.EnableUnsafeBinaryFormatterSerialization": false[m
[32m+[m[32m    }[m
[32m+[m[32m  }[m
[32m+[m[32m}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task1/obj/Debug/net9.0/.NETCoreApp,Version=v9.0.AssemblyAttributes.cs b/Lab01/Task1/obj/Debug/net9.0/.NETCoreApp,Version=v9.0.AssemblyAttributes.cs[m
[1mnew file mode 100644[m
[1mindex 0000000..feda5e9[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task1/obj/Debug/net9.0/.NETCoreApp,Version=v9.0.AssemblyAttributes.cs[m
[36m@@ -0,0 +1,4 @@[m
[32m+[m[32m// <autogenerated />[m
[32m+[m[32musing System;[m
[32m+[m[32musing System.Reflection;[m
[32m+[m[32m[assembly: global::System.Runtime.Versioning.TargetFrameworkAttribute(".NETCoreApp,Version=v9.0", FrameworkDisplayName = ".NET 9.0")][m
[1mdiff --git a/Lab01/Task1/obj/Debug/net9.0/Task1.AssemblyInfo.cs b/Lab01/Task1/obj/Debug/net9.0/Task1.AssemblyInfo.cs[m
[1mnew file mode 100644[m
[1mindex 0000000..1ee96c8[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task1/obj/Debug/net9.0/Task1.AssemblyInfo.cs[m
[36m@@ -0,0 +1,22 @@[m
[32m+[m[32m//------------------------------------------------------------------------------[m
[32m+[m[32m// <auto-generated>[m
[32m+[m[32m//     This code was generated by a tool.[m
[32m+[m[32m//[m
[32m+[m[32m//     Changes to this file may cause incorrect behavior and will be lost if[m
[32m+[m[32m//     the code is regenerated.[m
[32m+[m[32m// </auto-generated>[m
[32m+[m[32m//------------------------------------------------------------------------------[m
[32m+[m
[32m+[m[32musing System;[m
[32m+[m[32musing System.Reflection;[m
[32m+[m
[32m+[m[32m[assembly: System.Reflection.AssemblyCompanyAttribute("Task1")][m
[32m+[m[32m[assembly: System.Reflection.AssemblyConfigurationAttribute("Debug")][m
[32m+[m[32m[assembly: System.Reflection.AssemblyFileVersionAttribute("1.0.0.0")][m
[32m+[m[32m[assembly: System.Reflection.AssemblyInformationalVersionAttribute("1.0.0")][m
[32m+[m[32m[assembly: System.Reflection.AssemblyProductAttribute("Task1")][m
[32m+[m[32m[assembly: System.Reflection.AssemblyTitleAttribute("Task1")][m
[32m+[m[32m[assembly: System.Reflection.AssemblyVersionAttribute("1.0.0.0")][m
[32m+[m
[32m+[m[32m// Generated by the MSBuild WriteCodeFragment class.[m
[32m+[m
[1mdiff --git a/Lab01/Task1/obj/Debug/net9.0/Task1.AssemblyInfoInputs.cache b/Lab01/Task1/obj/Debug/net9.0/Task1.AssemblyInfoInputs.cache[m
[1mnew file mode 100644[m
[1mindex 0000000..72f8671[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task1/obj/Debug/net9.0/Task1.AssemblyInfoInputs.cache[m
[36m@@ -0,0 +1 @@[m
[32m+[m[32m6791d1fb8f20d67f8f8b3335d3baac5a88c13fcdbd3d711324fbc94e3fc0c2fc[m
[1mdiff --git a/Lab01/Task1/obj/Debug/net9.0/Task1.GeneratedMSBuildEditorConfig.editorconfig b/Lab01/Task1/obj/Debug/net9.0/Task1.GeneratedMSBuildEditorConfig.editorconfig[m
[1mnew file mode 100644[m
[1mindex 0000000..50c0d46[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task1/obj/Debug/net9.0/Task1.GeneratedMSBuildEditorConfig.editorconfig[m
[36m@@ -0,0 +1,15 @@[m
[32m+[m[32mis_global = true[m
[32m+[m[32mbuild_property.TargetFramework = net9.0[m
[32m+[m[32mbuild_property.TargetPlatformMinVersion =[m[41m [m
[32m+[m[32mbuild_property.UsingMicrosoftNETSdkWeb =[m[41m [m
[32m+[m[32mbuild_property.ProjectTypeGuids =[m[41m [m
[32m+[m[32mbuild_property.InvariantGlobalization =[m[41m [m
[32m+[m[32mbuild_property.PlatformNeutralAssembly =[m[41m [m
[32m+[m[32mbuild_property.EnforceExtendedAnalyzerRules =[m[41m [m
[32m+[m[32mbuild_property._SupportedPlatformList = Linux,macOS,Windows[m
[32m+[m[32mbuild_property.RootNamespace = Task1[m
[32m+[m[32mbuild_property.ProjectDir = C:\Education\CHNU\2\OOP\Lab01\Task1\[m
[32m+[m[32mbuild_property.EnableComHosting =[m[41m [m
[32m+[m[32mbuild_property.EnableGeneratedComInterfaceComImportInterop =[m[41m [m
[32m+[m[32mbuild_property.EffectiveAnalysisLevelStyle = 9.0[m
[32m+[m[32mbuild_property.EnableCodeStyleSeverity =[m[41m [m
[1mdiff --git a/Lab01/Task1/obj/Debug/net9.0/Task1.GlobalUsings.g.cs b/Lab01/Task1/obj/Debug/net9.0/Task1.GlobalUsings.g.cs[m
[1mnew file mode 100644[m
[1mindex 0000000..8578f3d[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task1/obj/Debug/net9.0/Task1.GlobalUsings.g.cs[m
[36m@@ -0,0 +1,8 @@[m
[32m+[m[32m// <auto-generated/>[m
[32m+[m[32mglobal using global::System;[m
[32m+[m[32mglobal using global::System.Collections.Generic;[m
[32m+[m[32mglobal using global::System.IO;[m
[32m+[m[32mglobal using global::System.Linq;[m
[32m+[m[32mglobal using global::System.Net.Http;[m
[32m+[m[32mglobal using global::System.Threading;[m
[32m+[m[32mglobal using global::System.Threading.Tasks;[m
[1mdiff --git a/Lab01/Task1/obj/Debug/net9.0/Task1.assets.cache b/Lab01/Task1/obj/Debug/net9.0/Task1.assets.cache[m
[1mnew file mode 100644[m
[1mindex 0000000..f170a1e[m
Binary files /dev/null and b/Lab01/Task1/obj/Debug/net9.0/Task1.assets.cache differ
[1mdiff --git a/Lab01/Task1/obj/Debug/net9.0/Task1.csproj.CoreCompileInputs.cache b/Lab01/Task1/obj/Debug/net9.0/Task1.csproj.CoreCompileInputs.cache[m
[1mnew file mode 100644[m
[1mindex 0000000..d6b84d4[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task1/obj/Debug/net9.0/Task1.csproj.CoreCompileInputs.cache[m
[36m@@ -0,0 +1 @@[m
[32m+[m[32m464e8be5ad302f17457cca674567397871d3d7f4cea274b16a1678943d165dcd[m
[1mdiff --git a/Lab01/Task1/obj/Debug/net9.0/Task1.csproj.FileListAbsolute.txt b/Lab01/Task1/obj/Debug/net9.0/Task1.csproj.FileListAbsolute.txt[m
[1mnew file mode 100644[m
[1mindex 0000000..5fe072a[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task1/obj/Debug/net9.0/Task1.csproj.FileListAbsolute.txt[m
[36m@@ -0,0 +1,14 @@[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task1\bin\Debug\net9.0\Task1.exe[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task1\bin\Debug\net9.0\Task1.deps.json[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task1\bin\Debug\net9.0\Task1.runtimeconfig.json[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task1\bin\Debug\net9.0\Task1.dll[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task1\bin\Debug\net9.0\Task1.pdb[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task1\obj\Debug\net9.0\Task1.GeneratedMSBuildEditorConfig.editorconfig[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task1\obj\Debug\net9.0\Task1.AssemblyInfoInputs.cache[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task1\obj\Debug\net9.0\Task1.AssemblyInfo.cs[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task1\obj\Debug\net9.0\Task1.csproj.CoreCompileInputs.cache[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task1\obj\Debug\net9.0\Task1.dll[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task1\obj\Debug\net9.0\refint\Task1.dll[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task1\obj\Debug\net9.0\Task1.pdb[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task1\obj\Debug\net9.0\Task1.genruntimeconfig.cache[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task1\obj\Debug\net9.0\ref\Task1.dll[m
[1mdiff --git a/Lab01/Task1/obj/Debug/net9.0/Task1.dll b/Lab01/Task1/obj/Debug/net9.0/Task1.dll[m
[1mnew file mode 100644[m
[1mindex 0000000..31f1d48[m
Binary files /dev/null and b/Lab01/Task1/obj/Debug/net9.0/Task1.dll differ
[1mdiff --git a/Lab01/Task1/obj/Debug/net9.0/Task1.genruntimeconfig.cache b/Lab01/Task1/obj/Debug/net9.0/Task1.genruntimeconfig.cache[m
[1mnew file mode 100644[m
[1mindex 0000000..373d6b5[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task1/obj/Debug/net9.0/Task1.genruntimeconfig.cache[m
[36m@@ -0,0 +1 @@[m
[32m+[m[32m1d7804432825a1d326f5f3aba1b15f8097aed447ca6fa03aa8f1df4df7858ee5[m
[1mdiff --git a/Lab01/Task1/obj/Debug/net9.0/Task1.pdb b/Lab01/Task1/obj/Debug/net9.0/Task1.pdb[m
[1mnew file mode 100644[m
[1mindex 0000000..5a0726d[m
Binary files /dev/null and b/Lab01/Task1/obj/Debug/net9.0/Task1.pdb differ
[1mdiff --git a/Lab01/Task1/obj/Debug/net9.0/apphost.exe b/Lab01/Task1/obj/Debug/net9.0/apphost.exe[m
[1mnew file mode 100644[m
[1mindex 0000000..ab27794[m
Binary files /dev/null and b/Lab01/Task1/obj/Debug/net9.0/apphost.exe differ
[1mdiff --git a/Lab01/Task1/obj/Debug/net9.0/ref/Task1.dll b/Lab01/Task1/obj/Debug/net9.0/ref/Task1.dll[m
[1mnew file mode 100644[m
[1mindex 0000000..956a509[m
Binary files /dev/null and b/Lab01/Task1/obj/Debug/net9.0/ref/Task1.dll differ
[1mdiff --git a/Lab01/Task1/obj/Debug/net9.0/refint/Task1.dll b/Lab01/Task1/obj/Debug/net9.0/refint/Task1.dll[m
[1mnew file mode 100644[m
[1mindex 0000000..956a509[m
Binary files /dev/null and b/Lab01/Task1/obj/Debug/net9.0/refint/Task1.dll differ
[1mdiff --git a/Lab01/Task1/obj/Task1.csproj.nuget.dgspec.json b/Lab01/Task1/obj/Task1.csproj.nuget.dgspec.json[m
[1mnew file mode 100644[m
[1mindex 0000000..2e03550[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task1/obj/Task1.csproj.nuget.dgspec.json[m
[36m@@ -0,0 +1,67 @@[m
[32m+[m[32m{[m
[32m+[m[32m  "format": 1,[m
[32m+[m[32m  "restore": {[m
[32m+[m[32m    "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task1\\Task1.csproj": {}[m
[32m+[m[32m  },[m
[32m+[m[32m  "projects": {[m
[32m+[m[32m    "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task1\\Task1.csproj": {[m
[32m+[m[32m      "version": "1.0.0",[m
[32m+[m[32m      "restore": {[m
[32m+[m[32m        "projectUniqueName": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task1\\Task1.csproj",[m
[32m+[m[32m        "projectName": "Task1",[m
[32m+[m[32m        "projectPath": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task1\\Task1.csproj",[m
[32m+[m[32m        "packagesPath": "C:\\Users\\Incognitus\\.nuget\\packages\\",[m
[32m+[m[32m        "outputPath": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task1\\obj\\",[m
[32m+[m[32m        "projectStyle": "PackageReference",[m
[32m+[m[32m        "configFilePaths": [[m
[32m+[m[32m          "C:\\Users\\Incognitus\\AppData\\Roaming\\NuGet\\NuGet.Config"[m
[32m+[m[32m        ],[m
[32m+[m[32m        "originalTargetFrameworks": [[m
[32m+[m[32m          "net9.0"[m
[32m+[m[32m        ],[m
[32m+[m[32m        "sources": {[m
[32m+[m[32m          "https://api.nuget.org/v3/index.json": {}[m
[32m+[m[32m        },[m
[32m+[m[32m        "frameworks": {[m
[32m+[m[32m          "net9.0": {[m
[32m+[m[32m            "targetAlias": "net9.0",[m
[32m+[m[32m            "projectReferences": {}[m
[32m+[m[32m          }[m
[32m+[m[32m        },[m
[32m+[m[32m        "warningProperties": {[m
[32m+[m[32m          "warnAsError": [[m
[32m+[m[32m            "NU1605"[m
[32m+[m[32m          ][m
[32m+[m[32m        },[m
[32m+[m[32m        "restoreAuditProperties": {[m
[32m+[m[32m          "enableAudit": "true",[m
[32m+[m[32m          "auditLevel": "low",[m
[32m+[m[32m          "auditMode": "direct"[m
[32m+[m[32m        },[m
[32m+[m[32m        "SdkAnalysisLevel": "9.0.300"[m
[32m+[m[32m      },[m
[32m+[m[32m      "frameworks": {[m
[32m+[m[32m        "net9.0": {[m
[32m+[m[32m          "targetAlias": "net9.0",[m
[32m+[m[32m          "imports": [[m
[32m+[m[32m            "net461",[m
[32m+[m[32m            "net462",[m
[32m+[m[32m            "net47",[m
[32m+[m[32m            "net471",[m
[32m+[m[32m            "net472",[m
[32m+[m[32m            "net48",[m
[32m+[m[32m            "net481"[m
[32m+[m[32m          ],[m
[32m+[m[32m          "assetTargetFallback": true,[m
[32m+[m[32m          "warn": true,[m
[32m+[m[32m          "frameworkReferences": {[m
[32m+[m[32m            "Microsoft.NETCore.App": {[m
[32m+[m[32m              "privateAssets": "all"[m
[32m+[m[32m            }[m
[32m+[m[32m          },[m
[32m+[m[32m          "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.304/PortableRuntimeIdentifierGraph.json"[m
[32m+[m[32m        }[m
[32m+[m[32m      }[m
[32m+[m[32m    }[m
[32m+[m[32m  }[m
[32m+[m[32m}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task1/obj/Task1.csproj.nuget.g.props b/Lab01/Task1/obj/Task1.csproj.nuget.g.props[m
[1mnew file mode 100644[m
[1mindex 0000000..0a91026[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task1/obj/Task1.csproj.nuget.g.props[m
[36m@@ -0,0 +1,15 @@[m
[32m+[m[32m﻿<?xml version="1.0" encoding="utf-8" standalone="no"?>[m
[32m+[m[32m<Project ToolsVersion="14.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">[m
[32m+[m[32m  <PropertyGroup Condition=" '$(ExcludeRestorePackageImports)' != 'true' ">[m
[32m+[m[32m    <RestoreSuccess Condition=" '$(RestoreSuccess)' == '' ">True</RestoreSuccess>[m
[32m+[m[32m    <RestoreTool Condition=" '$(RestoreTool)' == '' ">NuGet</RestoreTool>[m
[32m+[m[32m    <ProjectAssetsFile Condition=" '$(ProjectAssetsFile)' == '' ">$(MSBuildThisFileDirectory)project.assets.json</ProjectAssetsFile>[m
[32m+[m[32m    <NuGetPackageRoot Condition=" '$(NuGetPackageRoot)' == '' ">$(UserProfile)\.nuget\packages\</NuGetPackageRoot>[m
[32m+[m[32m    <NuGetPackageFolders Condition=" '$(NuGetPackageFolders)' == '' ">C:\Users\Incognitus\.nuget\packages\</NuGetPackageFolders>[m
[32m+[m[32m    <NuGetProjectStyle Condition=" '$(NuGetProjectStyle)' == '' ">PackageReference</NuGetProjectStyle>[m
[32m+[m[32m    <NuGetToolVersion Condition=" '$(NuGetToolVersion)' == '' ">6.14.0</NuGetToolVersion>[m
[32m+[m[32m  </PropertyGroup>[m
[32m+[m[32m  <ItemGroup Condition=" '$(ExcludeRestorePackageImports)' != 'true' ">[m
[32m+[m[32m    <SourceRoot Include="C:\Users\Incognitus\.nuget\packages\" />[m
[32m+[m[32m  </ItemGroup>[m
[32m+[m[32m</Project>[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task1/obj/Task1.csproj.nuget.g.targets b/Lab01/Task1/obj/Task1.csproj.nuget.g.targets[m
[1mnew file mode 100644[m
[1mindex 0000000..3dc06ef[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task1/obj/Task1.csproj.nuget.g.targets[m
[36m@@ -0,0 +1,2 @@[m
[32m+[m[32m﻿<?xml version="1.0" encoding="utf-8" standalone="no"?>[m
[32m+[m[32m<Project ToolsVersion="14.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" />[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task1/obj/project.assets.json b/Lab01/Task1/obj/project.assets.json[m
[1mnew file mode 100644[m
[1mindex 0000000..42141f2[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task1/obj/project.assets.json[m
[36m@@ -0,0 +1,72 @@[m
[32m+[m[32m{[m
[32m+[m[32m  "version": 3,[m
[32m+[m[32m  "targets": {[m
[32m+[m[32m    "net9.0": {}[m
[32m+[m[32m  },[m
[32m+[m[32m  "libraries": {},[m
[32m+[m[32m  "projectFileDependencyGroups": {[m
[32m+[m[32m    "net9.0": [][m
[32m+[m[32m  },[m
[32m+[m[32m  "packageFolders": {[m
[32m+[m[32m    "C:\\Users\\Incognitus\\.nuget\\packages\\": {}[m
[32m+[m[32m  },[m
[32m+[m[32m  "project": {[m
[32m+[m[32m    "version": "1.0.0",[m
[32m+[m[32m    "restore": {[m
[32m+[m[32m      "projectUniqueName": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task1\\Task1.csproj",[m
[32m+[m[32m      "projectName": "Task1",[m
[32m+[m[32m      "projectPath": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task1\\Task1.csproj",[m
[32m+[m[32m      "packagesPath": "C:\\Users\\Incognitus\\.nuget\\packages\\",[m
[32m+[m[32m      "outputPath": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task1\\obj\\",[m
[32m+[m[32m      "projectStyle": "PackageReference",[m
[32m+[m[32m      "configFilePaths": [[m
[32m+[m[32m        "C:\\Users\\Incognitus\\AppData\\Roaming\\NuGet\\NuGet.Config"[m
[32m+[m[32m      ],[m
[32m+[m[32m      "originalTargetFrameworks": [[m
[32m+[m[32m        "net9.0"[m
[32m+[m[32m      ],[m
[32m+[m[32m      "sources": {[m
[32m+[m[32m        "https://api.nuget.org/v3/index.json": {}[m
[32m+[m[32m      },[m
[32m+[m[32m      "frameworks": {[m
[32m+[m[32m        "net9.0": {[m
[32m+[m[32m          "targetAlias": "net9.0",[m
[32m+[m[32m          "projectReferences": {}[m
[32m+[m[32m        }[m
[32m+[m[32m      },[m
[32m+[m[32m      "warningProperties": {[m
[32m+[m[32m        "warnAsError": [[m
[32m+[m[32m          "NU1605"[m
[32m+[m[32m        ][m
[32m+[m[32m      },[m
[32m+[m[32m      "restoreAuditProperties": {[m
[32m+[m[32m        "enableAudit": "true",[m
[32m+[m[32m        "auditLevel": "low",[m
[32m+[m[32m        "auditMode": "direct"[m
[32m+[m[32m      },[m
[32m+[m[32m      "SdkAnalysisLevel": "9.0.300"[m
[32m+[m[32m    },[m
[32m+[m[32m    "frameworks": {[m
[32m+[m[32m      "net9.0": {[m
[32m+[m[32m        "targetAlias": "net9.0",[m
[32m+[m[32m        "imports": [[m
[32m+[m[32m          "net461",[m
[32m+[m[32m          "net462",[m
[32m+[m[32m          "net47",[m
[32m+[m[32m          "net471",[m
[32m+[m[32m          "net472",[m
[32m+[m[32m          "net48",[m
[32m+[m[32m          "net481"[m
[32m+[m[32m        ],[m
[32m+[m[32m        "assetTargetFallback": true,[m
[32m+[m[32m        "warn": true,[m
[32m+[m[32m        "frameworkReferences": {[m
[32m+[m[32m          "Microsoft.NETCore.App": {[m
[32m+[m[32m            "privateAssets": "all"[m
[32m+[m[32m          }[m
[32m+[m[32m        },[m
[32m+[m[32m        "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.304/PortableRuntimeIdentifierGraph.json"[m
[32m+[m[32m      }[m
[32m+[m[32m    }[m
[32m+[m[32m  }[m
[32m+[m[32m}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task1/obj/project.nuget.cache b/Lab01/Task1/obj/project.nuget.cache[m
[1mnew file mode 100644[m
[1mindex 0000000..e428e99[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task1/obj/project.nuget.cache[m
[36m@@ -0,0 +1,8 @@[m
[32m+[m[32m{[m
[32m+[m[32m  "version": 2,[m
[32m+[m[32m  "dgSpecHash": "Zvd/nXeAVf8=",[m
[32m+[m[32m  "success": true,[m
[32m+[m[32m  "projectFilePath": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task1\\Task1.csproj",[m
[32m+[m[32m  "expectedPackageFiles": [],[m
[32m+[m[32m  "logs": [][m
[32m+[m[32m}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task1/obj/project.packagespec.json b/Lab01/Task1/obj/project.packagespec.json[m
[1mnew file mode 100644[m
[1mindex 0000000..1136704[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task1/obj/project.packagespec.json[m
[36m@@ -0,0 +1 @@[m
[32m+[m[32m﻿"restore":{"projectUniqueName":"C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task1\\Task1.csproj","projectName":"Task1","projectPath":"C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task1\\Task1.csproj","outputPath":"C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task1\\obj\\","projectStyle":"PackageReference","originalTargetFrameworks":["net9.0"],"sources":{"https://api.nuget.org/v3/index.json":{}},"frameworks":{"net9.0":{"targetAlias":"net9.0","projectReferences":{}}},"warningProperties":{"warnAsError":["NU1605"]},"restoreAuditProperties":{"enableAudit":"true","auditLevel":"low","auditMode":"direct"},"SdkAnalysisLevel":"9.0.300"}"frameworks":{"net9.0":{"targetAlias":"net9.0","imports":["net461","net462","net47","net471","net472","net48","net481"],"assetTargetFallback":true,"warn":true,"frameworkReferences":{"Microsoft.NETCore.App":{"privateAssets":"all"}},"runtimeIdentifierGraphPath":"C:\\Program Files\\dotnet\\sdk\\9.0.304/PortableRuntimeIdentifierGraph.json"}}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task1/obj/rider.project.model.nuget.info b/Lab01/Task1/obj/rider.project.model.nuget.info[m
[1mnew file mode 100644[m
[1mindex 0000000..11b752d[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task1/obj/rider.project.model.nuget.info[m
[36m@@ -0,0 +1 @@[m
[32m+[m[32m﻿17569821790634881[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task1/obj/rider.project.restore.info b/Lab01/Task1/obj/rider.project.restore.info[m
[1mnew file mode 100644[m
[1mindex 0000000..11b752d[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task1/obj/rider.project.restore.info[m
[36m@@ -0,0 +1 @@[m
[32m+[m[32m﻿17569821790634881[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task2/Task2.csproj b/Lab01/Task2/Task2.csproj[m
[1mnew file mode 100644[m
[1mindex 0000000..85b4959[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task2/Task2.csproj[m
[36m@@ -0,0 +1,10 @@[m
[32m+[m[32m﻿<Project Sdk="Microsoft.NET.Sdk">[m
[32m+[m
[32m+[m[32m    <PropertyGroup>[m
[32m+[m[32m        <OutputType>Exe</OutputType>[m
[32m+[m[32m        <TargetFramework>net9.0</TargetFramework>[m
[32m+[m[32m        <ImplicitUsings>enable</ImplicitUsings>[m
[32m+[m[32m        <Nullable>enable</Nullable>[m
[32m+[m[32m    </PropertyGroup>[m
[32m+[m
[32m+[m[32m</Project>[m
[1mdiff --git a/Lab01/Task2/Types.cs b/Lab01/Task2/Types.cs[m
[1mnew file mode 100644[m
[1mindex 0000000..9562e1e[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task2/Types.cs[m
[36m@@ -0,0 +1,55 @@[m
[32m+[m[32m﻿using System;[m
[32m+[m
[32m+[m[32mclass Types[m
[32m+[m[32m{[m
[32m+[m[32m    static void Main()[m
[32m+[m[32m    {[m
[32m+[m[32m        Console.WriteLine("1. Integer.");[m
[32m+[m[32m        Console.WriteLine("2. Double and float.");[m
[32m+[m[32m        Console.WriteLine("3. String and char.");[m
[32m+[m[32m        int choice = int.Parse(Console.ReadLine());[m
[32m+[m[32m        switch (choice)[m
[32m+[m[32m        {[m
[32m+[m[32m            case 1:[m
[32m+[m[32m            {[m
[32m+[m[32m                sbyte num1 = -100;[m
[32m+[m[32m                byte num2 = 128;[m
[32m+[m[32m                short num3 = -3540;[m
[32m+[m[32m                ushort num4 = 64876;[m
[32m+[m[32m                uint num5 = 2147483648;[m
[32m+[m[32m                int num6 = -1141583228;[m
[32m+[m[32m                Console.WriteLine(num1);[m
[32m+[m[32m                Console.WriteLine(num2);[m
[32m+[m[32m                Console.WriteLine(num3);[m
[32m+[m[32m                Console.WriteLine(num4);[m
[32m+[m[32m                Console.WriteLine(num5);[m
[32m+[m[32m                Console.WriteLine(num6);[m
[32m+[m[32m                break;[m
[32m+[m[32m            }[m
[32m+[m[32m            case 2:[m
[32m+[m[32m            {[m
[32m+[m[32m                decimal num1 = 3.141592653589793238m;[m
[32m+[m[32m                double num2 = 1.60217657;[m
[32m+[m[32m                decimal num3 = 7.8184261974584555216535342341m;[m
[32m+[m[32m                Console.WriteLine(num1);[m
[32m+[m[32m                Console.WriteLine(num2);[m
[32m+[m[32m                Console.WriteLine(num3);[m
[32m+[m[32m                break;[m
[32m+[m[32m            }[m
[32m+[m[32m            case 3:[m
[32m+[m[32m            {[m
[32m+[m[32m                string str = "Chernivtsi National University";[m
[32m+[m[32m                char b = 'B';[m
[32m+[m[32m                char y = 'y';[m
[32m+[m[32m                char e = 'e';[m
[32m+[m[32m                string str2 = "I love programming";[m
[32m+[m[32m                Console.WriteLine(str);[m
[32m+[m[32m                Console.WriteLine(b);[m
[32m+[m[32m                Console.WriteLine(y);[m
[32m+[m[32m                Console.WriteLine(e);[m
[32m+[m[32m                Console.WriteLine(str2);[m
[32m+[m[32m                break;[m
[32m+[m[32m            }[m[41m    [m
[32m+[m[32m        }[m
[32m+[m[32m    }[m
[32m+[m[32m}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task2/bin/Debug/net9.0/Task2.deps.json b/Lab01/Task2/bin/Debug/net9.0/Task2.deps.json[m
[1mnew file mode 100644[m
[1mindex 0000000..ac2f665[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task2/bin/Debug/net9.0/Task2.deps.json[m
[36m@@ -0,0 +1,23 @@[m
[32m+[m[32m{[m
[32m+[m[32m  "runtimeTarget": {[m
[32m+[m[32m    "name": ".NETCoreApp,Version=v9.0",[m
[32m+[m[32m    "signature": ""[m
[32m+[m[32m  },[m
[32m+[m[32m  "compilationOptions": {},[m
[32m+[m[32m  "targets": {[m
[32m+[m[32m    ".NETCoreApp,Version=v9.0": {[m
[32m+[m[32m      "Task2/1.0.0": {[m
[32m+[m[32m        "runtime": {[m
[32m+[m[32m          "Task2.dll": {}[m
[32m+[m[32m        }[m
[32m+[m[32m      }[m
[32m+[m[32m    }[m
[32m+[m[32m  },[m
[32m+[m[32m  "libraries": {[m
[32m+[m[32m    "Task2/1.0.0": {[m
[32m+[m[32m      "type": "project",[m
[32m+[m[32m      "serviceable": false,[m
[32m+[m[32m      "sha512": ""[m
[32m+[m[32m    }[m
[32m+[m[32m  }[m
[32m+[m[32m}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task2/bin/Debug/net9.0/Task2.dll b/Lab01/Task2/bin/Debug/net9.0/Task2.dll[m
[1mnew file mode 100644[m
[1mindex 0000000..3302c82[m
Binary files /dev/null and b/Lab01/Task2/bin/Debug/net9.0/Task2.dll differ
[1mdiff --git a/Lab01/Task2/bin/Debug/net9.0/Task2.exe b/Lab01/Task2/bin/Debug/net9.0/Task2.exe[m
[1mnew file mode 100644[m
[1mindex 0000000..b9384d8[m
Binary files /dev/null and b/Lab01/Task2/bin/Debug/net9.0/Task2.exe differ
[1mdiff --git a/Lab01/Task2/bin/Debug/net9.0/Task2.pdb b/Lab01/Task2/bin/Debug/net9.0/Task2.pdb[m
[1mnew file mode 100644[m
[1mindex 0000000..b15284d[m
Binary files /dev/null and b/Lab01/Task2/bin/Debug/net9.0/Task2.pdb differ
[1mdiff --git a/Lab01/Task2/bin/Debug/net9.0/Task2.runtimeconfig.json b/Lab01/Task2/bin/Debug/net9.0/Task2.runtimeconfig.json[m
[1mnew file mode 100644[m
[1mindex 0000000..b19c3c8[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task2/bin/Debug/net9.0/Task2.runtimeconfig.json[m
[36m@@ -0,0 +1,12 @@[m
[32m+[m[32m{[m
[32m+[m[32m  "runtimeOptions": {[m
[32m+[m[32m    "tfm": "net9.0",[m
[32m+[m[32m    "framework": {[m
[32m+[m[32m      "name": "Microsoft.NETCore.App",[m
[32m+[m[32m      "version": "9.0.0"[m
[32m+[m[32m    },[m
[32m+[m[32m    "configProperties": {[m
[32m+[m[32m      "System.Runtime.Serialization.EnableUnsafeBinaryFormatterSerialization": false[m
[32m+[m[32m    }[m
[32m+[m[32m  }[m
[32m+[m[32m}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task2/obj/Debug/net9.0/.NETCoreApp,Version=v9.0.AssemblyAttributes.cs b/Lab01/Task2/obj/Debug/net9.0/.NETCoreApp,Version=v9.0.AssemblyAttributes.cs[m
[1mnew file mode 100644[m
[1mindex 0000000..feda5e9[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task2/obj/Debug/net9.0/.NETCoreApp,Version=v9.0.AssemblyAttributes.cs[m
[36m@@ -0,0 +1,4 @@[m
[32m+[m[32m// <autogenerated />[m
[32m+[m[32musing System;[m
[32m+[m[32musing System.Reflection;[m
[32m+[m[32m[assembly: global::System.Runtime.Versioning.TargetFrameworkAttribute(".NETCoreApp,Version=v9.0", FrameworkDisplayName = ".NET 9.0")][m
[1mdiff --git a/Lab01/Task2/obj/Debug/net9.0/Task2.AssemblyInfo.cs b/Lab01/Task2/obj/Debug/net9.0/Task2.AssemblyInfo.cs[m
[1mnew file mode 100644[m
[1mindex 0000000..fcaae91[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task2/obj/Debug/net9.0/Task2.AssemblyInfo.cs[m
[36m@@ -0,0 +1,22 @@[m
[32m+[m[32m//------------------------------------------------------------------------------[m
[32m+[m[32m// <auto-generated>[m
[32m+[m[32m//     This code was generated by a tool.[m
[32m+[m[32m//[m
[32m+[m[32m//     Changes to this file may cause incorrect behavior and will be lost if[m
[32m+[m[32m//     the code is regenerated.[m
[32m+[m[32m// </auto-generated>[m
[32m+[m[32m//------------------------------------------------------------------------------[m
[32m+[m
[32m+[m[32musing System;[m
[32m+[m[32musing System.Reflection;[m
[32m+[m
[32m+[m[32m[assembly: System.Reflection.AssemblyCompanyAttribute("Task2")][m
[32m+[m[32m[assembly: System.Reflection.AssemblyConfigurationAttribute("Debug")][m
[32m+[m[32m[assembly: System.Reflection.AssemblyFileVersionAttribute("1.0.0.0")][m
[32m+[m[32m[assembly: System.Reflection.AssemblyInformationalVersionAttribute("1.0.0")][m
[32m+[m[32m[assembly: System.Reflection.AssemblyProductAttribute("Task2")][m
[32m+[m[32m[assembly: System.Reflection.AssemblyTitleAttribute("Task2")][m
[32m+[m[32m[assembly: System.Reflection.AssemblyVersionAttribute("1.0.0.0")][m
[32m+[m
[32m+[m[32m// Generated by the MSBuild WriteCodeFragment class.[m
[32m+[m
[1mdiff --git a/Lab01/Task2/obj/Debug/net9.0/Task2.AssemblyInfoInputs.cache b/Lab01/Task2/obj/Debug/net9.0/Task2.AssemblyInfoInputs.cache[m
[1mnew file mode 100644[m
[1mindex 0000000..8969c90[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task2/obj/Debug/net9.0/Task2.AssemblyInfoInputs.cache[m
[36m@@ -0,0 +1 @@[m
[32m+[m[32m88f505f2c9af269e3f04b4b53bbe3b4f6de1603b619a742710144002f3c5338a[m
[1mdiff --git a/Lab01/Task2/obj/Debug/net9.0/Task2.GeneratedMSBuildEditorConfig.editorconfig b/Lab01/Task2/obj/Debug/net9.0/Task2.GeneratedMSBuildEditorConfig.editorconfig[m
[1mnew file mode 100644[m
[1mindex 0000000..75f7e70[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task2/obj/Debug/net9.0/Task2.GeneratedMSBuildEditorConfig.editorconfig[m
[36m@@ -0,0 +1,15 @@[m
[32m+[m[32mis_global = true[m
[32m+[m[32mbuild_property.TargetFramework = net9.0[m
[32m+[m[32mbuild_property.TargetPlatformMinVersion =[m[41m [m
[32m+[m[32mbuild_property.UsingMicrosoftNETSdkWeb =[m[41m [m
[32m+[m[32mbuild_property.ProjectTypeGuids =[m[41m [m
[32m+[m[32mbuild_property.InvariantGlobalization =[m[41m [m
[32m+[m[32mbuild_property.PlatformNeutralAssembly =[m[41m [m
[32m+[m[32mbuild_property.EnforceExtendedAnalyzerRules =[m[41m [m
[32m+[m[32mbuild_property._SupportedPlatformList = Linux,macOS,Windows[m
[32m+[m[32mbuild_property.RootNamespace = Task2[m
[32m+[m[32mbuild_property.ProjectDir = C:\Education\CHNU\2\OOP\Lab01\Task2\[m
[32m+[m[32mbuild_property.EnableComHosting =[m[41m [m
[32m+[m[32mbuild_property.EnableGeneratedComInterfaceComImportInterop =[m[41m [m
[32m+[m[32mbuild_property.EffectiveAnalysisLevelStyle = 9.0[m
[32m+[m[32mbuild_property.EnableCodeStyleSeverity =[m[41m [m
[1mdiff --git a/Lab01/Task2/obj/Debug/net9.0/Task2.GlobalUsings.g.cs b/Lab01/Task2/obj/Debug/net9.0/Task2.GlobalUsings.g.cs[m
[1mnew file mode 100644[m
[1mindex 0000000..8578f3d[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task2/obj/Debug/net9.0/Task2.GlobalUsings.g.cs[m
[36m@@ -0,0 +1,8 @@[m
[32m+[m[32m// <auto-generated/>[m
[32m+[m[32mglobal using global::System;[m
[32m+[m[32mglobal using global::System.Collections.Generic;[m
[32m+[m[32mglobal using global::System.IO;[m
[32m+[m[32mglobal using global::System.Linq;[m
[32m+[m[32mglobal using global::System.Net.Http;[m
[32m+[m[32mglobal using global::System.Threading;[m
[32m+[m[32mglobal using global::System.Threading.Tasks;[m
[1mdiff --git a/Lab01/Task2/obj/Debug/net9.0/Task2.assets.cache b/Lab01/Task2/obj/Debug/net9.0/Task2.assets.cache[m
[1mnew file mode 100644[m
[1mindex 0000000..6ff44f5[m
Binary files /dev/null and b/Lab01/Task2/obj/Debug/net9.0/Task2.assets.cache differ
[1mdiff --git a/Lab01/Task2/obj/Debug/net9.0/Task2.csproj.CoreCompileInputs.cache b/Lab01/Task2/obj/Debug/net9.0/Task2.csproj.CoreCompileInputs.cache[m
[1mnew file mode 100644[m
[1mindex 0000000..1ef692c[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task2/obj/Debug/net9.0/Task2.csproj.CoreCompileInputs.cache[m
[36m@@ -0,0 +1 @@[m
[32m+[m[32me555f69512da0a5cb7eeabb25ad1d3b71ef834db8bff5c4eba23d649d3ce5edf[m
[1mdiff --git a/Lab01/Task2/obj/Debug/net9.0/Task2.csproj.FileListAbsolute.txt b/Lab01/Task2/obj/Debug/net9.0/Task2.csproj.FileListAbsolute.txt[m
[1mnew file mode 100644[m
[1mindex 0000000..f90816a[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task2/obj/Debug/net9.0/Task2.csproj.FileListAbsolute.txt[m
[36m@@ -0,0 +1,14 @@[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task2\bin\Debug\net9.0\Task2.exe[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task2\bin\Debug\net9.0\Task2.deps.json[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task2\bin\Debug\net9.0\Task2.runtimeconfig.json[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task2\bin\Debug\net9.0\Task2.dll[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task2\bin\Debug\net9.0\Task2.pdb[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task2\obj\Debug\net9.0\Task2.GeneratedMSBuildEditorConfig.editorconfig[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task2\obj\Debug\net9.0\Task2.AssemblyInfoInputs.cache[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task2\obj\Debug\net9.0\Task2.AssemblyInfo.cs[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task2\obj\Debug\net9.0\Task2.csproj.CoreCompileInputs.cache[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task2\obj\Debug\net9.0\Task2.dll[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task2\obj\Debug\net9.0\refint\Task2.dll[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task2\obj\Debug\net9.0\Task2.pdb[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task2\obj\Debug\net9.0\Task2.genruntimeconfig.cache[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task2\obj\Debug\net9.0\ref\Task2.dll[m
[1mdiff --git a/Lab01/Task2/obj/Debug/net9.0/Task2.dll b/Lab01/Task2/obj/Debug/net9.0/Task2.dll[m
[1mnew file mode 100644[m
[1mindex 0000000..3302c82[m
Binary files /dev/null and b/Lab01/Task2/obj/Debug/net9.0/Task2.dll differ
[1mdiff --git a/Lab01/Task2/obj/Debug/net9.0/Task2.genruntimeconfig.cache b/Lab01/Task2/obj/Debug/net9.0/Task2.genruntimeconfig.cache[m
[1mnew file mode 100644[m
[1mindex 0000000..5a17f87[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task2/obj/Debug/net9.0/Task2.genruntimeconfig.cache[m
[36m@@ -0,0 +1 @@[m
[32m+[m[32me7f65849a7e888a01180f9c7999667af127585d46c651a3dd756f13c5c78549e[m
[1mdiff --git a/Lab01/Task2/obj/Debug/net9.0/Task2.pdb b/Lab01/Task2/obj/Debug/net9.0/Task2.pdb[m
[1mnew file mode 100644[m
[1mindex 0000000..b15284d[m
Binary files /dev/null and b/Lab01/Task2/obj/Debug/net9.0/Task2.pdb differ
[1mdiff --git a/Lab01/Task2/obj/Debug/net9.0/apphost.exe b/Lab01/Task2/obj/Debug/net9.0/apphost.exe[m
[1mnew file mode 100644[m
[1mindex 0000000..b9384d8[m
Binary files /dev/null and b/Lab01/Task2/obj/Debug/net9.0/apphost.exe differ
[1mdiff --git a/Lab01/Task2/obj/Debug/net9.0/ref/Task2.dll b/Lab01/Task2/obj/Debug/net9.0/ref/Task2.dll[m
[1mnew file mode 100644[m
[1mindex 0000000..1bd8ddd[m
Binary files /dev/null and b/Lab01/Task2/obj/Debug/net9.0/ref/Task2.dll differ
[1mdiff --git a/Lab01/Task2/obj/Debug/net9.0/refint/Task2.dll b/Lab01/Task2/obj/Debug/net9.0/refint/Task2.dll[m
[1mnew file mode 100644[m
[1mindex 0000000..1bd8ddd[m
Binary files /dev/null and b/Lab01/Task2/obj/Debug/net9.0/refint/Task2.dll differ
[1mdiff --git a/Lab01/Task2/obj/Task2.csproj.nuget.dgspec.json b/Lab01/Task2/obj/Task2.csproj.nuget.dgspec.json[m
[1mnew file mode 100644[m
[1mindex 0000000..cba9978[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task2/obj/Task2.csproj.nuget.dgspec.json[m
[36m@@ -0,0 +1,67 @@[m
[32m+[m[32m{[m
[32m+[m[32m  "format": 1,[m
[32m+[m[32m  "restore": {[m
[32m+[m[32m    "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task2\\Task2.csproj": {}[m
[32m+[m[32m  },[m
[32m+[m[32m  "projects": {[m
[32m+[m[32m    "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task2\\Task2.csproj": {[m
[32m+[m[32m      "version": "1.0.0",[m
[32m+[m[32m      "restore": {[m
[32m+[m[32m        "projectUniqueName": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task2\\Task2.csproj",[m
[32m+[m[32m        "projectName": "Task2",[m
[32m+[m[32m        "projectPath": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task2\\Task2.csproj",[m
[32m+[m[32m        "packagesPath": "C:\\Users\\Incognitus\\.nuget\\packages\\",[m
[32m+[m[32m        "outputPath": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task2\\obj\\",[m
[32m+[m[32m        "projectStyle": "PackageReference",[m
[32m+[m[32m        "configFilePaths": [[m
[32m+[m[32m          "C:\\Users\\Incognitus\\AppData\\Roaming\\NuGet\\NuGet.Config"[m
[32m+[m[32m        ],[m
[32m+[m[32m        "originalTargetFrameworks": [[m
[32m+[m[32m          "net9.0"[m
[32m+[m[32m        ],[m
[32m+[m[32m        "sources": {[m
[32m+[m[32m          "https://api.nuget.org/v3/index.json": {}[m
[32m+[m[32m        },[m
[32m+[m[32m        "frameworks": {[m
[32m+[m[32m          "net9.0": {[m
[32m+[m[32m            "targetAlias": "net9.0",[m
[32m+[m[32m            "projectReferences": {}[m
[32m+[m[32m          }[m
[32m+[m[32m        },[m
[32m+[m[32m        "warningProperties": {[m
[32m+[m[32m          "warnAsError": [[m
[32m+[m[32m            "NU1605"[m
[32m+[m[32m          ][m
[32m+[m[32m        },[m
[32m+[m[32m        "restoreAuditProperties": {[m
[32m+[m[32m          "enableAudit": "true",[m
[32m+[m[32m          "auditLevel": "low",[m
[32m+[m[32m          "auditMode": "direct"[m
[32m+[m[32m        },[m
[32m+[m[32m        "SdkAnalysisLevel": "9.0.300"[m
[32m+[m[32m      },[m
[32m+[m[32m      "frameworks": {[m
[32m+[m[32m        "net9.0": {[m
[32m+[m[32m          "targetAlias": "net9.0",[m
[32m+[m[32m          "imports": [[m
[32m+[m[32m            "net461",[m
[32m+[m[32m            "net462",[m
[32m+[m[32m            "net47",[m
[32m+[m[32m            "net471",[m
[32m+[m[32m            "net472",[m
[32m+[m[32m            "net48",[m
[32m+[m[32m            "net481"[m
[32m+[m[32m          ],[m
[32m+[m[32m          "assetTargetFallback": true,[m
[32m+[m[32m          "warn": true,[m
[32m+[m[32m          "frameworkReferences": {[m
[32m+[m[32m            "Microsoft.NETCore.App": {[m
[32m+[m[32m              "privateAssets": "all"[m
[32m+[m[32m            }[m
[32m+[m[32m          },[m
[32m+[m[32m          "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.304/PortableRuntimeIdentifierGraph.json"[m
[32m+[m[32m        }[m
[32m+[m[32m      }[m
[32m+[m[32m    }[m
[32m+[m[32m  }[m
[32m+[m[32m}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task2/obj/Task2.csproj.nuget.g.props b/Lab01/Task2/obj/Task2.csproj.nuget.g.props[m
[1mnew file mode 100644[m
[1mindex 0000000..0a91026[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task2/obj/Task2.csproj.nuget.g.props[m
[36m@@ -0,0 +1,15 @@[m
[32m+[m[32m﻿<?xml version="1.0" encoding="utf-8" standalone="no"?>[m
[32m+[m[32m<Project ToolsVersion="14.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">[m
[32m+[m[32m  <PropertyGroup Condition=" '$(ExcludeRestorePackageImports)' != 'true' ">[m
[32m+[m[32m    <RestoreSuccess Condition=" '$(RestoreSuccess)' == '' ">True</RestoreSuccess>[m
[32m+[m[32m    <RestoreTool Condition=" '$(RestoreTool)' == '' ">NuGet</RestoreTool>[m
[32m+[m[32m    <ProjectAssetsFile Condition=" '$(ProjectAssetsFile)' == '' ">$(MSBuildThisFileDirectory)project.assets.json</ProjectAssetsFile>[m
[32m+[m[32m    <NuGetPackageRoot Condition=" '$(NuGetPackageRoot)' == '' ">$(UserProfile)\.nuget\packages\</NuGetPackageRoot>[m
[32m+[m[32m    <NuGetPackageFolders Condition=" '$(NuGetPackageFolders)' == '' ">C:\Users\Incognitus\.nuget\packages\</NuGetPackageFolders>[m
[32m+[m[32m    <NuGetProjectStyle Condition=" '$(NuGetProjectStyle)' == '' ">PackageReference</NuGetProjectStyle>[m
[32m+[m[32m    <NuGetToolVersion Condition=" '$(NuGetToolVersion)' == '' ">6.14.0</NuGetToolVersion>[m
[32m+[m[32m  </PropertyGroup>[m
[32m+[m[32m  <ItemGroup Condition=" '$(ExcludeRestorePackageImports)' != 'true' ">[m
[32m+[m[32m    <SourceRoot Include="C:\Users\Incognitus\.nuget\packages\" />[m
[32m+[m[32m  </ItemGroup>[m
[32m+[m[32m</Project>[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task2/obj/Task2.csproj.nuget.g.targets b/Lab01/Task2/obj/Task2.csproj.nuget.g.targets[m
[1mnew file mode 100644[m
[1mindex 0000000..3dc06ef[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task2/obj/Task2.csproj.nuget.g.targets[m
[36m@@ -0,0 +1,2 @@[m
[32m+[m[32m﻿<?xml version="1.0" encoding="utf-8" standalone="no"?>[m
[32m+[m[32m<Project ToolsVersion="14.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" />[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task2/obj/project.assets.json b/Lab01/Task2/obj/project.assets.json[m
[1mnew file mode 100644[m
[1mindex 0000000..fb4beb7[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task2/obj/project.assets.json[m
[36m@@ -0,0 +1,72 @@[m
[32m+[m[32m{[m
[32m+[m[32m  "version": 3,[m
[32m+[m[32m  "targets": {[m
[32m+[m[32m    "net9.0": {}[m
[32m+[m[32m  },[m
[32m+[m[32m  "libraries": {},[m
[32m+[m[32m  "projectFileDependencyGroups": {[m
[32m+[m[32m    "net9.0": [][m
[32m+[m[32m  },[m
[32m+[m[32m  "packageFolders": {[m
[32m+[m[32m    "C:\\Users\\Incognitus\\.nuget\\packages\\": {}[m
[32m+[m[32m  },[m
[32m+[m[32m  "project": {[m
[32m+[m[32m    "version": "1.0.0",[m
[32m+[m[32m    "restore": {[m
[32m+[m[32m      "projectUniqueName": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task2\\Task2.csproj",[m
[32m+[m[32m      "projectName": "Task2",[m
[32m+[m[32m      "projectPath": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task2\\Task2.csproj",[m
[32m+[m[32m      "packagesPath": "C:\\Users\\Incognitus\\.nuget\\packages\\",[m
[32m+[m[32m      "outputPath": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task2\\obj\\",[m
[32m+[m[32m      "projectStyle": "PackageReference",[m
[32m+[m[32m      "configFilePaths": [[m
[32m+[m[32m        "C:\\Users\\Incognitus\\AppData\\Roaming\\NuGet\\NuGet.Config"[m
[32m+[m[32m      ],[m
[32m+[m[32m      "originalTargetFrameworks": [[m
[32m+[m[32m        "net9.0"[m
[32m+[m[32m      ],[m
[32m+[m[32m      "sources": {[m
[32m+[m[32m        "https://api.nuget.org/v3/index.json": {}[m
[32m+[m[32m      },[m
[32m+[m[32m      "frameworks": {[m
[32m+[m[32m        "net9.0": {[m
[32m+[m[32m          "targetAlias": "net9.0",[m
[32m+[m[32m          "projectReferences": {}[m
[32m+[m[32m        }[m
[32m+[m[32m      },[m
[32m+[m[32m      "warningProperties": {[m
[32m+[m[32m        "warnAsError": [[m
[32m+[m[32m          "NU1605"[m
[32m+[m[32m        ][m
[32m+[m[32m      },[m
[32m+[m[32m      "restoreAuditProperties": {[m
[32m+[m[32m        "enableAudit": "true",[m
[32m+[m[32m        "auditLevel": "low",[m
[32m+[m[32m        "auditMode": "direct"[m
[32m+[m[32m      },[m
[32m+[m[32m      "SdkAnalysisLevel": "9.0.300"[m
[32m+[m[32m    },[m
[32m+[m[32m    "frameworks": {[m
[32m+[m[32m      "net9.0": {[m
[32m+[m[32m        "targetAlias": "net9.0",[m
[32m+[m[32m        "imports": [[m
[32m+[m[32m          "net461",[m
[32m+[m[32m          "net462",[m
[32m+[m[32m          "net47",[m
[32m+[m[32m          "net471",[m
[32m+[m[32m          "net472",[m
[32m+[m[32m          "net48",[m
[32m+[m[32m          "net481"[m
[32m+[m[32m        ],[m
[32m+[m[32m        "assetTargetFallback": true,[m
[32m+[m[32m        "warn": true,[m
[32m+[m[32m        "frameworkReferences": {[m
[32m+[m[32m          "Microsoft.NETCore.App": {[m
[32m+[m[32m            "privateAssets": "all"[m
[32m+[m[32m          }[m
[32m+[m[32m        },[m
[32m+[m[32m        "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.304/PortableRuntimeIdentifierGraph.json"[m
[32m+[m[32m      }[m
[32m+[m[32m    }[m
[32m+[m[32m  }[m
[32m+[m[32m}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task2/obj/project.nuget.cache b/Lab01/Task2/obj/project.nuget.cache[m
[1mnew file mode 100644[m
[1mindex 0000000..51a9fc8[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task2/obj/project.nuget.cache[m
[36m@@ -0,0 +1,8 @@[m
[32m+[m[32m{[m
[32m+[m[32m  "version": 2,[m
[32m+[m[32m  "dgSpecHash": "ynoEpplN3S8=",[m
[32m+[m[32m  "success": true,[m
[32m+[m[32m  "projectFilePath": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task2\\Task2.csproj",[m
[32m+[m[32m  "expectedPackageFiles": [],[m
[32m+[m[32m  "logs": [][m
[32m+[m[32m}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task2/obj/project.packagespec.json b/Lab01/Task2/obj/project.packagespec.json[m
[1mnew file mode 100644[m
[1mindex 0000000..9bfe8be[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task2/obj/project.packagespec.json[m
[36m@@ -0,0 +1 @@[m
[32m+[m[32m﻿"restore":{"projectUniqueName":"C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task2\\Task2.csproj","projectName":"Task2","projectPath":"C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task2\\Task2.csproj","outputPath":"C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task2\\obj\\","projectStyle":"PackageReference","originalTargetFrameworks":["net9.0"],"sources":{"https://api.nuget.org/v3/index.json":{}},"frameworks":{"net9.0":{"targetAlias":"net9.0","projectReferences":{}}},"warningProperties":{"warnAsError":["NU1605"]},"restoreAuditProperties":{"enableAudit":"true","auditLevel":"low","auditMode":"direct"},"SdkAnalysisLevel":"9.0.300"}"frameworks":{"net9.0":{"targetAlias":"net9.0","imports":["net461","net462","net47","net471","net472","net48","net481"],"assetTargetFallback":true,"warn":true,"frameworkReferences":{"Microsoft.NETCore.App":{"privateAssets":"all"}},"runtimeIdentifierGraphPath":"C:\\Program Files\\dotnet\\sdk\\9.0.304/PortableRuntimeIdentifierGraph.json"}}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task2/obj/rider.project.restore.info b/Lab01/Task2/obj/rider.project.restore.info[m
[1mnew file mode 100644[m
[1mindex 0000000..9b9e201[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task2/obj/rider.project.restore.info[m
[36m@@ -0,0 +1 @@[m
[32m+[m[32m﻿17569825073315623[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task3/Program.cs b/Lab01/Task3/Program.cs[m
[1mnew file mode 100644[m
[1mindex 0000000..5cf7e89[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task3/Program.cs[m
[36m@@ -0,0 +1,52 @@[m
[32m+[m[32m﻿using System;[m
[32m+[m
[32m+[m[32mclass NumManipulations[m
[32m+[m[32m{[m
[32m+[m[32m    static void Main()[m
[32m+[m[32m    {[m
[32m+[m[32m        int choice = int.Parse(Console.ReadLine());[m
[32m+[m[32m        switch (choice)[m
[32m+[m[32m        {[m
[32m+[m[32m            case 1:[m
[32m+[m[32m            {[m
[32m+[m[32m                float a = int.Parse(Console.ReadLine());[m
[32m+[m[32m                float b = int.Parse(Console.ReadLine());[m
[32m+[m[32m                float c = int.Parse(Console.ReadLine());[m
[32m+[m[32m                float average = (a + b + c) / 3;[m
[32m+[m[32m                Console.WriteLine("Average is " + average);[m
[32m+[m[32m                break;[m
[32m+[m[32m            }[m
[32m+[m[32m            case 2:[m
[32m+[m[32m            {[m
[32m+[m[32m                double a = double.Parse(Console.ReadLine());[m
[32m+[m[32m                double b = double.Parse(Console.ReadLine());[m
[32m+[m[32m                double h = double.Parse(Console.ReadLine());[m
[32m+[m[32m                double area = (a + b) * h / 2;[m
[32m+[m[32m                Console.WriteLine("Area is " + area);[m
[32m+[m[32m                break;[m
[32m+[m[32m            }[m
[32m+[m[32m            case 3:[m
[32m+[m[32m            {[m
[32m+[m[32m                int n = int.Parse(Console.ReadLine());[m
[32m+[m[32m                int lastDigit = n % 10;[m
[32m+[m[32m                Console.WriteLine("Last digit is " + lastDigit);[m
[32m+[m[32m                break;[m
[32m+[m[32m            }[m
[32m+[m[32m            case 4:[m
[32m+[m[32m            {[m
[32m+[m[32m                int n = int.Parse(Console.ReadLine());[m
[32m+[m[32m                int number = int.Parse(Console.ReadLine());[m
[32m+[m[32m                if (number < Math.Pow(10, n - 1))[m
[32m+[m[32m                {[m
[32m+[m[32m                    Console.WriteLine("-");[m
[32m+[m[32m                }[m
[32m+[m[32m                else[m
[32m+[m[32m                {[m
[32m+[m[32m                    int nDigit = number / (int)(Math.Pow(10, n - 1)) % 10;[m
[32m+[m[32m                    Console.WriteLine(nDigit);[m
[32m+[m[32m                }[m
[32m+[m[32m                break;[m
[32m+[m[32m            }[m[41m    [m
[32m+[m[32m        }[m
[32m+[m[32m    }[m
[32m+[m[32m}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task3/Task3.csproj b/Lab01/Task3/Task3.csproj[m
[1mnew file mode 100644[m
[1mindex 0000000..85b4959[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task3/Task3.csproj[m
[36m@@ -0,0 +1,10 @@[m
[32m+[m[32m﻿<Project Sdk="Microsoft.NET.Sdk">[m
[32m+[m
[32m+[m[32m    <PropertyGroup>[m
[32m+[m[32m        <OutputType>Exe</OutputType>[m
[32m+[m[32m        <TargetFramework>net9.0</TargetFramework>[m
[32m+[m[32m        <ImplicitUsings>enable</ImplicitUsings>[m
[32m+[m[32m        <Nullable>enable</Nullable>[m
[32m+[m[32m    </PropertyGroup>[m
[32m+[m
[32m+[m[32m</Project>[m
[1mdiff --git a/Lab01/Task3/bin/Debug/net9.0/Task3.deps.json b/Lab01/Task3/bin/Debug/net9.0/Task3.deps.json[m
[1mnew file mode 100644[m
[1mindex 0000000..2ec5eba[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task3/bin/Debug/net9.0/Task3.deps.json[m
[36m@@ -0,0 +1,23 @@[m
[32m+[m[32m{[m
[32m+[m[32m  "runtimeTarget": {[m
[32m+[m[32m    "name": ".NETCoreApp,Version=v9.0",[m
[32m+[m[32m    "signature": ""[m
[32m+[m[32m  },[m
[32m+[m[32m  "compilationOptions": {},[m
[32m+[m[32m  "targets": {[m
[32m+[m[32m    ".NETCoreApp,Version=v9.0": {[m
[32m+[m[32m      "Task3/1.0.0": {[m
[32m+[m[32m        "runtime": {[m
[32m+[m[32m          "Task3.dll": {}[m
[32m+[m[32m        }[m
[32m+[m[32m      }[m
[32m+[m[32m    }[m
[32m+[m[32m  },[m
[32m+[m[32m  "libraries": {[m
[32m+[m[32m    "Task3/1.0.0": {[m
[32m+[m[32m      "type": "project",[m
[32m+[m[32m      "serviceable": false,[m
[32m+[m[32m      "sha512": ""[m
[32m+[m[32m    }[m
[32m+[m[32m  }[m
[32m+[m[32m}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task3/bin/Debug/net9.0/Task3.dll b/Lab01/Task3/bin/Debug/net9.0/Task3.dll[m
[1mnew file mode 100644[m
[1mindex 0000000..9237017[m
Binary files /dev/null and b/Lab01/Task3/bin/Debug/net9.0/Task3.dll differ
[1mdiff --git a/Lab01/Task3/bin/Debug/net9.0/Task3.exe b/Lab01/Task3/bin/Debug/net9.0/Task3.exe[m
[1mnew file mode 100644[m
[1mindex 0000000..8ad2ef3[m
Binary files /dev/null and b/Lab01/Task3/bin/Debug/net9.0/Task3.exe differ
[1mdiff --git a/Lab01/Task3/bin/Debug/net9.0/Task3.pdb b/Lab01/Task3/bin/Debug/net9.0/Task3.pdb[m
[1mnew file mode 100644[m
[1mindex 0000000..78891e0[m
Binary files /dev/null and b/Lab01/Task3/bin/Debug/net9.0/Task3.pdb differ
[1mdiff --git a/Lab01/Task3/bin/Debug/net9.0/Task3.runtimeconfig.json b/Lab01/Task3/bin/Debug/net9.0/Task3.runtimeconfig.json[m
[1mnew file mode 100644[m
[1mindex 0000000..b19c3c8[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task3/bin/Debug/net9.0/Task3.runtimeconfig.json[m
[36m@@ -0,0 +1,12 @@[m
[32m+[m[32m{[m
[32m+[m[32m  "runtimeOptions": {[m
[32m+[m[32m    "tfm": "net9.0",[m
[32m+[m[32m    "framework": {[m
[32m+[m[32m      "name": "Microsoft.NETCore.App",[m
[32m+[m[32m      "version": "9.0.0"[m
[32m+[m[32m    },[m
[32m+[m[32m    "configProperties": {[m
[32m+[m[32m      "System.Runtime.Serialization.EnableUnsafeBinaryFormatterSerialization": false[m
[32m+[m[32m    }[m
[32m+[m[32m  }[m
[32m+[m[32m}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task3/obj/Debug/net9.0/.NETCoreApp,Version=v9.0.AssemblyAttributes.cs b/Lab01/Task3/obj/Debug/net9.0/.NETCoreApp,Version=v9.0.AssemblyAttributes.cs[m
[1mnew file mode 100644[m
[1mindex 0000000..feda5e9[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task3/obj/Debug/net9.0/.NETCoreApp,Version=v9.0.AssemblyAttributes.cs[m
[36m@@ -0,0 +1,4 @@[m
[32m+[m[32m// <autogenerated />[m
[32m+[m[32musing System;[m
[32m+[m[32musing System.Reflection;[m
[32m+[m[32m[assembly: global::System.Runtime.Versioning.TargetFrameworkAttribute(".NETCoreApp,Version=v9.0", FrameworkDisplayName = ".NET 9.0")][m
[1mdiff --git a/Lab01/Task3/obj/Debug/net9.0/Task3.AssemblyInfo.cs b/Lab01/Task3/obj/Debug/net9.0/Task3.AssemblyInfo.cs[m
[1mnew file mode 100644[m
[1mindex 0000000..7758bba[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task3/obj/Debug/net9.0/Task3.AssemblyInfo.cs[m
[36m@@ -0,0 +1,22 @@[m
[32m+[m[32m//------------------------------------------------------------------------------[m
[32m+[m[32m// <auto-generated>[m
[32m+[m[32m//     This code was generated by a tool.[m
[32m+[m[32m//[m
[32m+[m[32m//     Changes to this file may cause incorrect behavior and will be lost if[m
[32m+[m[32m//     the code is regenerated.[m
[32m+[m[32m// </auto-generated>[m
[32m+[m[32m//------------------------------------------------------------------------------[m
[32m+[m
[32m+[m[32musing System;[m
[32m+[m[32musing System.Reflection;[m
[32m+[m
[32m+[m[32m[assembly: System.Reflection.AssemblyCompanyAttribute("Task3")][m
[32m+[m[32m[assembly: System.Reflection.AssemblyConfigurationAttribute("Debug")][m
[32m+[m[32m[assembly: System.Reflection.AssemblyFileVersionAttribute("1.0.0.0")][m
[32m+[m[32m[assembly: System.Reflection.AssemblyInformationalVersionAttribute("1.0.0")][m
[32m+[m[32m[assembly: System.Reflection.AssemblyProductAttribute("Task3")][m
[32m+[m[32m[assembly: System.Reflection.AssemblyTitleAttribute("Task3")][m
[32m+[m[32m[assembly: System.Reflection.AssemblyVersionAttribute("1.0.0.0")][m
[32m+[m
[32m+[m[32m// Generated by the MSBuild WriteCodeFragment class.[m
[32m+[m
[1mdiff --git a/Lab01/Task3/obj/Debug/net9.0/Task3.AssemblyInfoInputs.cache b/Lab01/Task3/obj/Debug/net9.0/Task3.AssemblyInfoInputs.cache[m
[1mnew file mode 100644[m
[1mindex 0000000..1d083e4[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task3/obj/Debug/net9.0/Task3.AssemblyInfoInputs.cache[m
[36m@@ -0,0 +1 @@[m
[32m+[m[32m563406dd12da2649174a228aaf334ab0e1f0efe9e6f10bf270ea3650bc0542d1[m
[1mdiff --git a/Lab01/Task3/obj/Debug/net9.0/Task3.GeneratedMSBuildEditorConfig.editorconfig b/Lab01/Task3/obj/Debug/net9.0/Task3.GeneratedMSBuildEditorConfig.editorconfig[m
[1mnew file mode 100644[m
[1mindex 0000000..7c655cd[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task3/obj/Debug/net9.0/Task3.GeneratedMSBuildEditorConfig.editorconfig[m
[36m@@ -0,0 +1,15 @@[m
[32m+[m[32mis_global = true[m
[32m+[m[32mbuild_property.TargetFramework = net9.0[m
[32m+[m[32mbuild_property.TargetPlatformMinVersion =[m[41m [m
[32m+[m[32mbuild_property.UsingMicrosoftNETSdkWeb =[m[41m [m
[32m+[m[32mbuild_property.ProjectTypeGuids =[m[41m [m
[32m+[m[32mbuild_property.InvariantGlobalization =[m[41m [m
[32m+[m[32mbuild_property.PlatformNeutralAssembly =[m[41m [m
[32m+[m[32mbuild_property.EnforceExtendedAnalyzerRules =[m[41m [m
[32m+[m[32mbuild_property._SupportedPlatformList = Linux,macOS,Windows[m
[32m+[m[32mbuild_property.RootNamespace = Task3[m
[32m+[m[32mbuild_property.ProjectDir = C:\Education\CHNU\2\OOP\Lab01\Task3\[m
[32m+[m[32mbuild_property.EnableComHosting =[m[41m [m
[32m+[m[32mbuild_property.EnableGeneratedComInterfaceComImportInterop =[m[41m [m
[32m+[m[32mbuild_property.EffectiveAnalysisLevelStyle = 9.0[m
[32m+[m[32mbuild_property.EnableCodeStyleSeverity =[m[41m [m
[1mdiff --git a/Lab01/Task3/obj/Debug/net9.0/Task3.GlobalUsings.g.cs b/Lab01/Task3/obj/Debug/net9.0/Task3.GlobalUsings.g.cs[m
[1mnew file mode 100644[m
[1mindex 0000000..8578f3d[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task3/obj/Debug/net9.0/Task3.GlobalUsings.g.cs[m
[36m@@ -0,0 +1,8 @@[m
[32m+[m[32m// <auto-generated/>[m
[32m+[m[32mglobal using global::System;[m
[32m+[m[32mglobal using global::System.Collections.Generic;[m
[32m+[m[32mglobal using global::System.IO;[m
[32m+[m[32mglobal using global::System.Linq;[m
[32m+[m[32mglobal using global::System.Net.Http;[m
[32m+[m[32mglobal using global::System.Threading;[m
[32m+[m[32mglobal using global::System.Threading.Tasks;[m
[1mdiff --git a/Lab01/Task3/obj/Debug/net9.0/Task3.assets.cache b/Lab01/Task3/obj/Debug/net9.0/Task3.assets.cache[m
[1mnew file mode 100644[m
[1mindex 0000000..e5f5fde[m
Binary files /dev/null and b/Lab01/Task3/obj/Debug/net9.0/Task3.assets.cache differ
[1mdiff --git a/Lab01/Task3/obj/Debug/net9.0/Task3.csproj.CoreCompileInputs.cache b/Lab01/Task3/obj/Debug/net9.0/Task3.csproj.CoreCompileInputs.cache[m
[1mnew file mode 100644[m
[1mindex 0000000..1882781[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task3/obj/Debug/net9.0/Task3.csproj.CoreCompileInputs.cache[m
[36m@@ -0,0 +1 @@[m
[32m+[m[32m5269dbe284730a878025113afdd9c148abcd7d500aed83c4f338c13055043b70[m
[1mdiff --git a/Lab01/Task3/obj/Debug/net9.0/Task3.csproj.FileListAbsolute.txt b/Lab01/Task3/obj/Debug/net9.0/Task3.csproj.FileListAbsolute.txt[m
[1mnew file mode 100644[m
[1mindex 0000000..56422b5[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task3/obj/Debug/net9.0/Task3.csproj.FileListAbsolute.txt[m
[36m@@ -0,0 +1,14 @@[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task3\bin\Debug\net9.0\Task3.exe[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task3\bin\Debug\net9.0\Task3.deps.json[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task3\bin\Debug\net9.0\Task3.runtimeconfig.json[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task3\bin\Debug\net9.0\Task3.dll[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task3\bin\Debug\net9.0\Task3.pdb[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task3\obj\Debug\net9.0\Task3.GeneratedMSBuildEditorConfig.editorconfig[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task3\obj\Debug\net9.0\Task3.AssemblyInfoInputs.cache[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task3\obj\Debug\net9.0\Task3.AssemblyInfo.cs[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task3\obj\Debug\net9.0\Task3.csproj.CoreCompileInputs.cache[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task3\obj\Debug\net9.0\Task3.dll[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task3\obj\Debug\net9.0\refint\Task3.dll[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task3\obj\Debug\net9.0\Task3.pdb[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task3\obj\Debug\net9.0\Task3.genruntimeconfig.cache[m
[32m+[m[32mC:\Education\CHNU\2\OOP\Lab01\Task3\obj\Debug\net9.0\ref\Task3.dll[m
[1mdiff --git a/Lab01/Task3/obj/Debug/net9.0/Task3.dll b/Lab01/Task3/obj/Debug/net9.0/Task3.dll[m
[1mnew file mode 100644[m
[1mindex 0000000..9237017[m
Binary files /dev/null and b/Lab01/Task3/obj/Debug/net9.0/Task3.dll differ
[1mdiff --git a/Lab01/Task3/obj/Debug/net9.0/Task3.genruntimeconfig.cache b/Lab01/Task3/obj/Debug/net9.0/Task3.genruntimeconfig.cache[m
[1mnew file mode 100644[m
[1mindex 0000000..ae0d72a[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task3/obj/Debug/net9.0/Task3.genruntimeconfig.cache[m
[36m@@ -0,0 +1 @@[m
[32m+[m[32m6db9c330140c0ce87231032c294889cc34fa22307d2c3b9079b14fc955822ac0[m
[1mdiff --git a/Lab01/Task3/obj/Debug/net9.0/Task3.pdb b/Lab01/Task3/obj/Debug/net9.0/Task3.pdb[m
[1mnew file mode 100644[m
[1mindex 0000000..78891e0[m
Binary files /dev/null and b/Lab01/Task3/obj/Debug/net9.0/Task3.pdb differ
[1mdiff --git a/Lab01/Task3/obj/Debug/net9.0/apphost.exe b/Lab01/Task3/obj/Debug/net9.0/apphost.exe[m
[1mnew file mode 100644[m
[1mindex 0000000..8ad2ef3[m
Binary files /dev/null and b/Lab01/Task3/obj/Debug/net9.0/apphost.exe differ
[1mdiff --git a/Lab01/Task3/obj/Debug/net9.0/ref/Task3.dll b/Lab01/Task3/obj/Debug/net9.0/ref/Task3.dll[m
[1mnew file mode 100644[m
[1mindex 0000000..7c28b2e[m
Binary files /dev/null and b/Lab01/Task3/obj/Debug/net9.0/ref/Task3.dll differ
[1mdiff --git a/Lab01/Task3/obj/Debug/net9.0/refint/Task3.dll b/Lab01/Task3/obj/Debug/net9.0/refint/Task3.dll[m
[1mnew file mode 100644[m
[1mindex 0000000..7c28b2e[m
Binary files /dev/null and b/Lab01/Task3/obj/Debug/net9.0/refint/Task3.dll differ
[1mdiff --git a/Lab01/Task3/obj/Task3.csproj.nuget.dgspec.json b/Lab01/Task3/obj/Task3.csproj.nuget.dgspec.json[m
[1mnew file mode 100644[m
[1mindex 0000000..5c86918[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task3/obj/Task3.csproj.nuget.dgspec.json[m
[36m@@ -0,0 +1,67 @@[m
[32m+[m[32m{[m
[32m+[m[32m  "format": 1,[m
[32m+[m[32m  "restore": {[m
[32m+[m[32m    "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task3\\Task3.csproj": {}[m
[32m+[m[32m  },[m
[32m+[m[32m  "projects": {[m
[32m+[m[32m    "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task3\\Task3.csproj": {[m
[32m+[m[32m      "version": "1.0.0",[m
[32m+[m[32m      "restore": {[m
[32m+[m[32m        "projectUniqueName": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task3\\Task3.csproj",[m
[32m+[m[32m        "projectName": "Task3",[m
[32m+[m[32m        "projectPath": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task3\\Task3.csproj",[m
[32m+[m[32m        "packagesPath": "C:\\Users\\Incognitus\\.nuget\\packages\\",[m
[32m+[m[32m        "outputPath": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task3\\obj\\",[m
[32m+[m[32m        "projectStyle": "PackageReference",[m
[32m+[m[32m        "configFilePaths": [[m
[32m+[m[32m          "C:\\Users\\Incognitus\\AppData\\Roaming\\NuGet\\NuGet.Config"[m
[32m+[m[32m        ],[m
[32m+[m[32m        "originalTargetFrameworks": [[m
[32m+[m[32m          "net9.0"[m
[32m+[m[32m        ],[m
[32m+[m[32m        "sources": {[m
[32m+[m[32m          "https://api.nuget.org/v3/index.json": {}[m
[32m+[m[32m        },[m
[32m+[m[32m        "frameworks": {[m
[32m+[m[32m          "net9.0": {[m
[32m+[m[32m            "targetAlias": "net9.0",[m
[32m+[m[32m            "projectReferences": {}[m
[32m+[m[32m          }[m
[32m+[m[32m        },[m
[32m+[m[32m        "warningProperties": {[m
[32m+[m[32m          "warnAsError": [[m
[32m+[m[32m            "NU1605"[m
[32m+[m[32m          ][m
[32m+[m[32m        },[m
[32m+[m[32m        "restoreAuditProperties": {[m
[32m+[m[32m          "enableAudit": "true",[m
[32m+[m[32m          "auditLevel": "low",[m
[32m+[m[32m          "auditMode": "direct"[m
[32m+[m[32m        },[m
[32m+[m[32m        "SdkAnalysisLevel": "9.0.300"[m
[32m+[m[32m      },[m
[32m+[m[32m      "frameworks": {[m
[32m+[m[32m        "net9.0": {[m
[32m+[m[32m          "targetAlias": "net9.0",[m
[32m+[m[32m          "imports": [[m
[32m+[m[32m            "net461",[m
[32m+[m[32m            "net462",[m
[32m+[m[32m            "net47",[m
[32m+[m[32m            "net471",[m
[32m+[m[32m            "net472",[m
[32m+[m[32m            "net48",[m
[32m+[m[32m            "net481"[m
[32m+[m[32m          ],[m
[32m+[m[32m          "assetTargetFallback": true,[m
[32m+[m[32m          "warn": true,[m
[32m+[m[32m          "frameworkReferences": {[m
[32m+[m[32m            "Microsoft.NETCore.App": {[m
[32m+[m[32m              "privateAssets": "all"[m
[32m+[m[32m            }[m
[32m+[m[32m          },[m
[32m+[m[32m          "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.304/PortableRuntimeIdentifierGraph.json"[m
[32m+[m[32m        }[m
[32m+[m[32m      }[m
[32m+[m[32m    }[m
[32m+[m[32m  }[m
[32m+[m[32m}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task3/obj/Task3.csproj.nuget.g.props b/Lab01/Task3/obj/Task3.csproj.nuget.g.props[m
[1mnew file mode 100644[m
[1mindex 0000000..0a91026[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task3/obj/Task3.csproj.nuget.g.props[m
[36m@@ -0,0 +1,15 @@[m
[32m+[m[32m﻿<?xml version="1.0" encoding="utf-8" standalone="no"?>[m
[32m+[m[32m<Project ToolsVersion="14.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">[m
[32m+[m[32m  <PropertyGroup Condition=" '$(ExcludeRestorePackageImports)' != 'true' ">[m
[32m+[m[32m    <RestoreSuccess Condition=" '$(RestoreSuccess)' == '' ">True</RestoreSuccess>[m
[32m+[m[32m    <RestoreTool Condition=" '$(RestoreTool)' == '' ">NuGet</RestoreTool>[m
[32m+[m[32m    <ProjectAssetsFile Condition=" '$(ProjectAssetsFile)' == '' ">$(MSBuildThisFileDirectory)project.assets.json</ProjectAssetsFile>[m
[32m+[m[32m    <NuGetPackageRoot Condition=" '$(NuGetPackageRoot)' == '' ">$(UserProfile)\.nuget\packages\</NuGetPackageRoot>[m
[32m+[m[32m    <NuGetPackageFolders Condition=" '$(NuGetPackageFolders)' == '' ">C:\Users\Incognitus\.nuget\packages\</NuGetPackageFolders>[m
[32m+[m[32m    <NuGetProjectStyle Condition=" '$(NuGetProjectStyle)' == '' ">PackageReference</NuGetProjectStyle>[m
[32m+[m[32m    <NuGetToolVersion Condition=" '$(NuGetToolVersion)' == '' ">6.14.0</NuGetToolVersion>[m
[32m+[m[32m  </PropertyGroup>[m
[32m+[m[32m  <ItemGroup Condition=" '$(ExcludeRestorePackageImports)' != 'true' ">[m
[32m+[m[32m    <SourceRoot Include="C:\Users\Incognitus\.nuget\packages\" />[m
[32m+[m[32m  </ItemGroup>[m
[32m+[m[32m</Project>[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task3/obj/Task3.csproj.nuget.g.targets b/Lab01/Task3/obj/Task3.csproj.nuget.g.targets[m
[1mnew file mode 100644[m
[1mindex 0000000..3dc06ef[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task3/obj/Task3.csproj.nuget.g.targets[m
[36m@@ -0,0 +1,2 @@[m
[32m+[m[32m﻿<?xml version="1.0" encoding="utf-8" standalone="no"?>[m
[32m+[m[32m<Project ToolsVersion="14.0" xmlns="http://schemas.microsoft.com/developer/msbuild/2003" />[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task3/obj/project.assets.json b/Lab01/Task3/obj/project.assets.json[m
[1mnew file mode 100644[m
[1mindex 0000000..927d050[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task3/obj/project.assets.json[m
[36m@@ -0,0 +1,72 @@[m
[32m+[m[32m{[m
[32m+[m[32m  "version": 3,[m
[32m+[m[32m  "targets": {[m
[32m+[m[32m    "net9.0": {}[m
[32m+[m[32m  },[m
[32m+[m[32m  "libraries": {},[m
[32m+[m[32m  "projectFileDependencyGroups": {[m
[32m+[m[32m    "net9.0": [][m
[32m+[m[32m  },[m
[32m+[m[32m  "packageFolders": {[m
[32m+[m[32m    "C:\\Users\\Incognitus\\.nuget\\packages\\": {}[m
[32m+[m[32m  },[m
[32m+[m[32m  "project": {[m
[32m+[m[32m    "version": "1.0.0",[m
[32m+[m[32m    "restore": {[m
[32m+[m[32m      "projectUniqueName": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task3\\Task3.csproj",[m
[32m+[m[32m      "projectName": "Task3",[m
[32m+[m[32m      "projectPath": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task3\\Task3.csproj",[m
[32m+[m[32m      "packagesPath": "C:\\Users\\Incognitus\\.nuget\\packages\\",[m
[32m+[m[32m      "outputPath": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task3\\obj\\",[m
[32m+[m[32m      "projectStyle": "PackageReference",[m
[32m+[m[32m      "configFilePaths": [[m
[32m+[m[32m        "C:\\Users\\Incognitus\\AppData\\Roaming\\NuGet\\NuGet.Config"[m
[32m+[m[32m      ],[m
[32m+[m[32m      "originalTargetFrameworks": [[m
[32m+[m[32m        "net9.0"[m
[32m+[m[32m      ],[m
[32m+[m[32m      "sources": {[m
[32m+[m[32m        "https://api.nuget.org/v3/index.json": {}[m
[32m+[m[32m      },[m
[32m+[m[32m      "frameworks": {[m
[32m+[m[32m        "net9.0": {[m
[32m+[m[32m          "targetAlias": "net9.0",[m
[32m+[m[32m          "projectReferences": {}[m
[32m+[m[32m        }[m
[32m+[m[32m      },[m
[32m+[m[32m      "warningProperties": {[m
[32m+[m[32m        "warnAsError": [[m
[32m+[m[32m          "NU1605"[m
[32m+[m[32m        ][m
[32m+[m[32m      },[m
[32m+[m[32m      "restoreAuditProperties": {[m
[32m+[m[32m        "enableAudit": "true",[m
[32m+[m[32m        "auditLevel": "low",[m
[32m+[m[32m        "auditMode": "direct"[m
[32m+[m[32m      },[m
[32m+[m[32m      "SdkAnalysisLevel": "9.0.300"[m
[32m+[m[32m    },[m
[32m+[m[32m    "frameworks": {[m
[32m+[m[32m      "net9.0": {[m
[32m+[m[32m        "targetAlias": "net9.0",[m
[32m+[m[32m        "imports": [[m
[32m+[m[32m          "net461",[m
[32m+[m[32m          "net462",[m
[32m+[m[32m          "net47",[m
[32m+[m[32m          "net471",[m
[32m+[m[32m          "net472",[m
[32m+[m[32m          "net48",[m
[32m+[m[32m          "net481"[m
[32m+[m[32m        ],[m
[32m+[m[32m        "assetTargetFallback": true,[m
[32m+[m[32m        "warn": true,[m
[32m+[m[32m        "frameworkReferences": {[m
[32m+[m[32m          "Microsoft.NETCore.App": {[m
[32m+[m[32m            "privateAssets": "all"[m
[32m+[m[32m          }[m
[32m+[m[32m        },[m
[32m+[m[32m        "runtimeIdentifierGraphPath": "C:\\Program Files\\dotnet\\sdk\\9.0.304/PortableRuntimeIdentifierGraph.json"[m
[32m+[m[32m      }[m
[32m+[m[32m    }[m
[32m+[m[32m  }[m
[32m+[m[32m}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task3/obj/project.nuget.cache b/Lab01/Task3/obj/project.nuget.cache[m
[1mnew file mode 100644[m
[1mindex 0000000..a56c0ab[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task3/obj/project.nuget.cache[m
[36m@@ -0,0 +1,8 @@[m
[32m+[m[32m{[m
[32m+[m[32m  "version": 2,[m
[32m+[m[32m  "dgSpecHash": "coGutWIeoOI=",[m
[32m+[m[32m  "success": true,[m
[32m+[m[32m  "projectFilePath": "C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task3\\Task3.csproj",[m
[32m+[m[32m  "expectedPackageFiles": [],[m
[32m+[m[32m  "logs": [][m
[32m+[m[32m}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task3/obj/project.packagespec.json b/Lab01/Task3/obj/project.packagespec.json[m
[1mnew file mode 100644[m
[1mindex 0000000..e101097[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task3/obj/project.packagespec.json[m
[36m@@ -0,0 +1 @@[m
[32m+[m[32m﻿"restore":{"projectUniqueName":"C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task3\\Task3.csproj","projectName":"Task3","projectPath":"C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task3\\Task3.csproj","outputPath":"C:\\Education\\CHNU\\2\\OOP\\Lab01\\Task3\\obj\\","projectStyle":"PackageReference","originalTargetFrameworks":["net9.0"],"sources":{"https://api.nuget.org/v3/index.json":{}},"frameworks":{"net9.0":{"targetAlias":"net9.0","projectReferences":{}}},"warningProperties":{"warnAsError":["NU1605"]},"restoreAuditProperties":{"enableAudit":"true","auditLevel":"low","auditMode":"direct"},"SdkAnalysisLevel":"9.0.300"}"frameworks":{"net9.0":{"targetAlias":"net9.0","imports":["net461","net462","net47","net471","net472","net48","net481"],"assetTargetFallback":true,"warn":true,"frameworkReferences":{"Microsoft.NETCore.App":{"privateAssets":"all"}},"runtimeIdentifierGraphPath":"C:\\Program Files\\dotnet\\sdk\\9.0.304/PortableRuntimeIdentifierGraph.json"}}[m
\ No newline at end of file[m
[1mdiff --git a/Lab01/Task3/obj/rider.project.restore.info b/Lab01/Task3/obj/rider.project.restore.info[m
[1mnew file mode 100644[m
[1mindex 0000000..261ab6c[m
[1m--- /dev/null[m
[1m+++ b/Lab01/Task3/obj/rider.project.restore.info[m
[36m@@ -0,0 +1 @@[m
[32m+[m[32m﻿17569840903153370[m
\ No newline at end of file[m
