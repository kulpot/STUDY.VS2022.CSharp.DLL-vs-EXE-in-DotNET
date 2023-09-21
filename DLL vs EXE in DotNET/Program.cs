﻿using System;

//ref link:https://www.youtube.com/watch?v=qwC4KRWHBdk&list=PLRwVmtr-pp06rfSgNYu_oBg40DkwXiRHt&index=8
// EXE -> has .entrypoint in MSIL level code 
// DLL -> no .entrypoint 

/*---------------------------------CMD--------------------------------------
 * 
C:\Users\sunny\source\repos\DLL vs EXE in DotNET>cd DLL vs EXE in DotNet

C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET

22/09/2023  06:12 am    <DIR>          .
22/09/2023  06:12 am    <DIR>          ..
22/09/2023  05:42 am               189 App.config
22/09/2023  05:42 am    <DIR>          bin
22/09/2023  05:43 am             2,390 DLL vs EXE in DotNET.csproj
22/09/2023  05:42 am    <DIR>          obj
22/09/2023  06:12 am               232 Program.cs
22/09/2023  05:42 am    <DIR>          Properties
               3 File(s)          2,811 bytes
               5 Dir(s)  489,869,049,856 bytes free

C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>csc Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET

22/09/2023  06:15 am    <DIR>          .
22/09/2023  06:15 am    <DIR>          ..
22/09/2023  05:42 am               189 App.config
22/09/2023  05:42 am    <DIR>          bin
22/09/2023  05:43 am             2,390 DLL vs EXE in DotNET.csproj
22/09/2023  05:42 am    <DIR>          obj
22/09/2023  06:14 am             1,143 Program.cs
22/09/2023  06:15 am             4,096 Program.exe
22/09/2023  05:42 am    <DIR>          Properties
               4 File(s)          7,818 bytes
               5 Dir(s)  489,872,068,608 bytes free

C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>Program.exe
Hello world

C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>csc /t:library Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET

22/09/2023  06:17 am    <DIR>          .
22/09/2023  06:17 am    <DIR>          ..
22/09/2023  05:42 am               189 App.config
22/09/2023  05:42 am    <DIR>          bin
22/09/2023  05:43 am             2,390 DLL vs EXE in DotNET.csproj
22/09/2023  05:42 am    <DIR>          obj
22/09/2023  06:16 am             2,239 Program.cs
22/09/2023  06:17 am             3,584 Program.dll
22/09/2023  06:15 am             4,096 Program.exe
22/09/2023  05:42 am    <DIR>          Properties
               5 File(s)         12,498 bytes
               5 Dir(s)  489,869,983,744 bytes free

C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>ildasm /out:MeExeCode.txt Program.exe

C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET

22/09/2023  06:18 am    <DIR>          .
22/09/2023  06:18 am    <DIR>          ..
22/09/2023  05:42 am               189 App.config
22/09/2023  05:42 am    <DIR>          bin
22/09/2023  05:43 am             2,390 DLL vs EXE in DotNET.csproj
22/09/2023  06:18 am             1,128 MeExeCode.res
22/09/2023  06:18 am             4,909 MeExeCode.txt
22/09/2023  05:42 am    <DIR>          obj
22/09/2023  06:16 am             2,239 Program.cs
22/09/2023  06:17 am             3,584 Program.dll
22/09/2023  06:15 am             4,096 Program.exe
22/09/2023  05:42 am    <DIR>          Properties
               7 File(s)         18,535 bytes
               5 Dir(s)  489,868,861,440 bytes free

C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>ildasm /out:MeDllCode.txt Program.dll

C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET

22/09/2023  06:20 am    <DIR>          .
22/09/2023  06:20 am    <DIR>          ..
22/09/2023  05:42 am               189 App.config
22/09/2023  05:42 am    <DIR>          bin
22/09/2023  05:43 am             2,390 DLL vs EXE in DotNET.csproj
22/09/2023  06:20 am               644 MeDllCode.res
22/09/2023  06:20 am             4,892 MeDllCode.txt
22/09/2023  06:18 am             1,128 MeExeCode.res
22/09/2023  06:18 am             4,909 MeExeCode.txt
22/09/2023  05:42 am    <DIR>          obj
22/09/2023  06:19 am             4,359 Program.cs
22/09/2023  06:17 am             3,584 Program.dll
22/09/2023  06:15 am             4,096 Program.exe
22/09/2023  05:42 am    <DIR>          Properties
               9 File(s)         26,191 bytes
               5 Dir(s)  489,867,911,168 bytes free

C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>MeDllCode.txt
--------------------------NOTEPAD: MeDllCode.txt--------------------------------


//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly Program
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module Program.dll
// MVID: {308D5F23-83D1-4BCE-9B7E-3FE7B2A6560F}
.custom instance void System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x10000000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x06570000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method EmbeddedAttribute::.ctor

} // end of class Microsoft.CodeAnalysis.EmbeddedAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.RefSafetyRulesAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 02 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ........T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 00 )                               // rited.
  .field public initonly int32 Version
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 A_1) cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ldarg.0
    IL_0008:  ldarg.1
    IL_0009:  stfld      int32 System.Runtime.CompilerServices.RefSafetyRulesAttribute::Version
    IL_000e:  ret
  } // end of method RefSafetyRulesAttribute::.ctor

} // end of class System.Runtime.CompilerServices.RefSafetyRulesAttribute

.class private auto ansi beforefieldinit MainClass
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main() cil managed
  {
    // Code size       13 (0xd)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      "Hello world"
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  ret
  } // end of method MainClass::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method MainClass::.ctor

} // end of class MainClass


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file MeDllCode.res

--------------------------NOTEPAD: MeDllCode.txt--------------------------------END

C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>MeExeCode.txt

--------------------------NOTEPAD: MeExeCode.txt--------------------------------


//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly Program
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .hash algorithm 0x00008004
  .ver 0:0:0:0
}
.module Program.exe
// MVID: {EEE55860-CEE1-4A5E-A9DA-F67C1D4DE567}
.custom instance void System.Runtime.CompilerServices.RefSafetyRulesAttribute::.ctor(int32) = ( 01 00 0B 00 00 00 00 00 ) 
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00000001    //  ILONLY
// Image base: 0x05250000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi sealed beforefieldinit Microsoft.CodeAnalysis.EmbeddedAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method EmbeddedAttribute::.ctor

} // end of class Microsoft.CodeAnalysis.EmbeddedAttribute

.class private auto ansi sealed beforefieldinit System.Runtime.CompilerServices.RefSafetyRulesAttribute
       extends [mscorlib]System.Attribute
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void Microsoft.CodeAnalysis.EmbeddedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.AttributeUsageAttribute::.ctor(valuetype [mscorlib]System.AttributeTargets) = ( 01 00 02 00 00 00 02 00 54 02 0D 41 6C 6C 6F 77   // ........T..Allow
                                                                                                                         4D 75 6C 74 69 70 6C 65 00 54 02 09 49 6E 68 65   // Multiple.T..Inhe
                                                                                                                         72 69 74 65 64 00 )                               // rited.
  .field public initonly int32 Version
  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(int32 A_1) cil managed
  {
    // Code size       15 (0xf)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Attribute::.ctor()
    IL_0006:  nop
    IL_0007:  ldarg.0
    IL_0008:  ldarg.1
    IL_0009:  stfld      int32 System.Runtime.CompilerServices.RefSafetyRulesAttribute::Version
    IL_000e:  ret
  } // end of method RefSafetyRulesAttribute::.ctor

} // end of class System.Runtime.CompilerServices.RefSafetyRulesAttribute

.class private auto ansi beforefieldinit MainClass
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main() cil managed
  {
    .entrypoint   <------------------------ONLY in EXECUTABLES---------|
    // Code size       13 (0xd)
    .maxstack  8
    IL_0000:  nop
    IL_0001:  ldstr      "Hello world"
    IL_0006:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_000b:  nop
    IL_000c:  ret
  } // end of method MainClass::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method MainClass::.ctor

} // end of class MainClass


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file MeExeCode.res

--------------------------NOTEPAD: MeExeCode.txt--------------------------------END

C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>erase *.*
C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET\*.*, Are you sure (Y/N)? y

C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET

22/09/2023  06:33 am    <DIR>          .
22/09/2023  06:33 am    <DIR>          ..
22/09/2023  05:42 am    <DIR>          bin
22/09/2023  05:42 am    <DIR>          obj
22/09/2023  05:42 am    <DIR>          Properties
               0 File(s)              0 bytes
               5 Dir(s)  489,857,789,952 bytes free

-------------------Created----------------------------
Public class MeOtherMainClass
{
    Public static void Main()
    {
        Console.WriteLine("Hello world");
    }
}
------------------------------------------------

C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET

22/09/2023  06:34 am    <DIR>          .
22/09/2023  06:34 am    <DIR>          ..
22/09/2023  05:42 am    <DIR>          bin
22/09/2023  05:42 am    <DIR>          obj
22/09/2023  06:34 am            17,042 Program.cs
22/09/2023  05:42 am    <DIR>          Properties
               1 File(s)         17,042 bytes
               5 Dir(s)  489,860,870,144 bytes free

C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>csc /out:MeMainExe.exe Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>MeMainExe.exe
Hello world

C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET

22/09/2023  06:37 am    <DIR>          .
22/09/2023  06:37 am    <DIR>          ..
22/09/2023  05:42 am    <DIR>          bin
22/09/2023  06:36 am             4,096 MeMainExe.exe
22/09/2023  05:42 am    <DIR>          obj
22/09/2023  06:37 am            18,023 Program.cs
22/09/2023  05:42 am    <DIR>          Properties
               2 File(s)         22,119 bytes
               5 Dir(s)  489,856,614,400 bytes free

--------------Create MeMainExe.exe to Reference EXE Program.exe------------|
C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>csc /r:MeMainExe.exe Program.cs
Microsoft (R) Visual C# Compiler version 4.7.0-3.23416.8 (43b0b05c)
Copyright (C) Microsoft Corporation. All rights reserved.


C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>dir
 Volume in drive C has no label.
 Volume Serial Number is DAE4-938D

 Directory of C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET

22/09/2023  06:41 am    <DIR>          .
22/09/2023  06:41 am    <DIR>          ..
22/09/2023  05:42 am    <DIR>          bin
22/09/2023  06:36 am             4,096 MeMainExe.exe
22/09/2023  05:42 am    <DIR>          obj
22/09/2023  06:41 am            18,847 Program.cs
22/09/2023  06:41 am             4,096 Program.exe
22/09/2023  05:42 am    <DIR>          Properties
               3 File(s)         27,039 bytes
               5 Dir(s)  489,862,508,544 bytes free

C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>Program.exe
Hello world

C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>erase MeMainExe.exe

C:\Users\sunny\source\repos\DLL vs EXE in DotNET\DLL vs EXE in DotNET>Program.exe

Unhandled Exception: System.IO.FileNotFoundException: Could not load file or assembly 'MeMainExe, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null' or one of its dependencies. The system cannot find the file specified.
   at XXXxxxXXXxxXXXXx.Main()


 * 
 */



//class MainClass
//{
//    static void Main()
//    {
//        Console.WriteLine("Hello world");
//    }
//}

//public class MeOtherMainClass
//{
//    public static void Main()
//    {
//        Console.WriteLine("Hello world");
//    }
//}

class XXXxxxXXXxxXXXXx
{
    static void Main()
    {
        MeOtherMainClass.Main();    // reference executable MeMainExe.exe
    }
}