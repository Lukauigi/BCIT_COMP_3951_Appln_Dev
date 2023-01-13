
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.6.1055.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly AccountApp
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 07 01 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 0A 41 63 63 6F 75 6E 74 41 70 70 00 00 )    // ...AccountApp..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 0A 41 63 63 6F 75 6E 74 41 70 70 00 00 )    // ...AccountApp..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 32 30 00 00 )                            //  2020..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 36 39 39 64 65 37 34 36 2D 30 39 61 30   // ..$699de746-09a0
                                                                                                  2D 34 37 62 64 2D 61 66 31 39 2D 63 31 63 32 64   // -47bd-af19-c1c2d
                                                                                                  61 65 30 61 32 31 34 00 00 )                      // ae0a214..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 36 2E 31 01   // ,Version=v4.6.1.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 36 2E 31 )          // amework 4.6.1
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module AccountApp.exe
// MVID: {237CE06D-79D0-47DB-ADC4-DF111891F1B8}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x01770000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit AccountApp.Account
       extends [mscorlib]System.Object
{
  .field private string '<Type>k__BackingField'
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
  .custom instance void [mscorlib]System.Diagnostics.DebuggerBrowsableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggerBrowsableState) = ( 01 00 00 00 00 00 00 00 ) 
  .field private valuetype [mscorlib]System.Decimal balance
  .method public hidebysig specialname instance string 
          get_Type() cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldfld      string AccountApp.Account::'<Type>k__BackingField'
    IL_0006:  ret
  } // end of method Account::get_Type

  .method public hidebysig specialname instance void 
          set_Type(string 'value') cil managed
  {
    .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilerGeneratedAttribute::.ctor() = ( 01 00 00 00 ) 
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  ldarg.1
    IL_0002:  stfld      string AccountApp.Account::'<Type>k__BackingField'
    IL_0007:  ret
  } // end of method Account::set_Type

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor(string accountType,
                               valuetype [mscorlib]System.Decimal initialBalance) cil managed
  {
    // Code size       25 (0x19)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  nop
    IL_0008:  ldarg.0
    IL_0009:  ldarg.1
    IL_000a:  call       instance void AccountApp.Account::set_Type(string)
    IL_000f:  nop
    IL_0010:  ldarg.0
    IL_0011:  ldarg.2
    IL_0012:  call       instance void AccountApp.Account::set_Balance(valuetype [mscorlib]System.Decimal)
    IL_0017:  nop
    IL_0018:  ret
  } // end of method Account::.ctor

  .method public hidebysig specialname instance valuetype [mscorlib]System.Decimal 
          get_Balance() cil managed
  {
    // Code size       12 (0xc)
    .maxstack  1
    .locals init ([0] valuetype [mscorlib]System.Decimal V_0)
    IL_0000:  nop
    IL_0001:  ldarg.0
    IL_0002:  ldfld      valuetype [mscorlib]System.Decimal AccountApp.Account::balance
    IL_0007:  stloc.0
    IL_0008:  br.s       IL_000a

    IL_000a:  ldloc.0
    IL_000b:  ret
  } // end of method Account::get_Balance

  .method private hidebysig specialname instance void 
          set_Balance(valuetype [mscorlib]System.Decimal 'value') cil managed
  {
    // Code size       31 (0x1f)
    .maxstack  6
    .locals init ([0] bool V_0)
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  ldc.i4.0
    IL_0003:  ldc.i4.0
    IL_0004:  ldc.i4.0
    IL_0005:  ldc.i4.0
    IL_0006:  ldc.i4.1
    IL_0007:  newobj     instance void [mscorlib]System.Decimal::.ctor(int32,
                                                                       int32,
                                                                       int32,
                                                                       bool,
                                                                       uint8)
    IL_000c:  call       bool [mscorlib]System.Decimal::op_GreaterThan(valuetype [mscorlib]System.Decimal,
                                                                       valuetype [mscorlib]System.Decimal)
    IL_0011:  stloc.0
    IL_0012:  ldloc.0
    IL_0013:  brfalse.s  IL_001e

    IL_0015:  nop
    IL_0016:  ldarg.0
    IL_0017:  ldarg.1
    IL_0018:  stfld      valuetype [mscorlib]System.Decimal AccountApp.Account::balance
    IL_001d:  nop
    IL_001e:  ret
  } // end of method Account::set_Balance

  .method public hidebysig instance void 
          Deposit(valuetype [mscorlib]System.Decimal depositAmount) cil managed
  {
    // Code size       43 (0x2b)
    .maxstack  6
    .locals init ([0] bool V_0)
    IL_0000:  nop
    IL_0001:  ldarg.1
    IL_0002:  ldc.i4.0
    IL_0003:  ldc.i4.0
    IL_0004:  ldc.i4.0
    IL_0005:  ldc.i4.0
    IL_0006:  ldc.i4.1
    IL_0007:  newobj     instance void [mscorlib]System.Decimal::.ctor(int32,
                                                                       int32,
                                                                       int32,
                                                                       bool,
                                                                       uint8)
    IL_000c:  call       bool [mscorlib]System.Decimal::op_GreaterThan(valuetype [mscorlib]System.Decimal,
                                                                       valuetype [mscorlib]System.Decimal)
    IL_0011:  stloc.0
    IL_0012:  ldloc.0
    IL_0013:  brfalse.s  IL_002a

    IL_0015:  nop
    IL_0016:  ldarg.0
    IL_0017:  ldarg.0
    IL_0018:  call       instance valuetype [mscorlib]System.Decimal AccountApp.Account::get_Balance()
    IL_001d:  ldarg.1
    IL_001e:  call       valuetype [mscorlib]System.Decimal [mscorlib]System.Decimal::op_Addition(valuetype [mscorlib]System.Decimal,
                                                                                                  valuetype [mscorlib]System.Decimal)
    IL_0023:  call       instance void AccountApp.Account::set_Balance(valuetype [mscorlib]System.Decimal)
    IL_0028:  nop
    IL_0029:  nop
    IL_002a:  ret
  } // end of method Account::Deposit

  .property instance string Type()
  {
    .get instance string AccountApp.Account::get_Type()
    .set instance void AccountApp.Account::set_Type(string)
  } // end of property Account::Type
  .property instance valuetype [mscorlib]System.Decimal
          Balance()
  {
    .get instance valuetype [mscorlib]System.Decimal AccountApp.Account::get_Balance()
    .set instance void AccountApp.Account::set_Balance(valuetype [mscorlib]System.Decimal)
  } // end of property Account::Balance
} // end of class AccountApp.Account

.class private auto ansi beforefieldinit AccountApp.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       360 (0x168)
    .maxstack  6
    .locals init ([0] class AccountApp.Account accountChequing,
             [1] class AccountApp.Account accountSevings,
             [2] valuetype [mscorlib]System.Decimal depositAmount)
    IL_0000:  nop
    IL_0001:  ldstr      "Chequing"
    IL_0006:  ldc.i4     0x1388
    IL_000b:  ldc.i4.0
    IL_000c:  ldc.i4.0
    IL_000d:  ldc.i4.0
    IL_000e:  ldc.i4.2
    IL_000f:  newobj     instance void [mscorlib]System.Decimal::.ctor(int32,
                                                                       int32,
                                                                       int32,
                                                                       bool,
                                                                       uint8)
    IL_0014:  newobj     instance void AccountApp.Account::.ctor(string,
                                                                 valuetype [mscorlib]System.Decimal)
    IL_0019:  stloc.0
    IL_001a:  ldstr      "Savings"
    IL_001f:  ldc.i4     0x2f1
    IL_0024:  ldc.i4.0
    IL_0025:  ldc.i4.0
    IL_0026:  ldc.i4.1
    IL_0027:  ldc.i4.2
    IL_0028:  newobj     instance void [mscorlib]System.Decimal::.ctor(int32,
                                                                       int32,
                                                                       int32,
                                                                       bool,
                                                                       uint8)
    IL_002d:  newobj     instance void AccountApp.Account::.ctor(string,
                                                                 valuetype [mscorlib]System.Decimal)
    IL_0032:  stloc.1
    IL_0033:  ldstr      "{0} balance: {1:C}"
    IL_0038:  ldloc.0
    IL_0039:  callvirt   instance string AccountApp.Account::get_Type()
    IL_003e:  ldloc.0
    IL_003f:  callvirt   instance valuetype [mscorlib]System.Decimal AccountApp.Account::get_Balance()
    IL_0044:  box        [mscorlib]System.Decimal
    IL_0049:  call       string [mscorlib]System.String::Format(string,
                                                                object,
                                                                object)
    IL_004e:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0053:  nop
    IL_0054:  ldstr      "{0} balance: {1:C}"
    IL_0059:  ldloc.1
    IL_005a:  callvirt   instance string AccountApp.Account::get_Type()
    IL_005f:  ldloc.1
    IL_0060:  callvirt   instance valuetype [mscorlib]System.Decimal AccountApp.Account::get_Balance()
    IL_0065:  box        [mscorlib]System.Decimal
    IL_006a:  call       string [mscorlib]System.String::Format(string,
                                                                object,
                                                                object)
    IL_006f:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0074:  nop
    IL_0075:  ldstr      "\nEnter deposit amount for your Chequing account: "
    IL_007a:  call       void [mscorlib]System.Console::Write(string)
    IL_007f:  nop
    IL_0080:  call       string [mscorlib]System.Console::ReadLine()
    IL_0085:  call       valuetype [mscorlib]System.Decimal [mscorlib]System.Decimal::Parse(string)
    IL_008a:  stloc.2
    IL_008b:  ldstr      "adding {0:C} to account Chequing balance\n"
    IL_0090:  ldloc.2
    IL_0091:  box        [mscorlib]System.Decimal
    IL_0096:  call       string [mscorlib]System.String::Format(string,
                                                                object)
    IL_009b:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_00a0:  nop
    IL_00a1:  ldloc.0
    IL_00a2:  ldloc.2
    IL_00a3:  callvirt   instance void AccountApp.Account::Deposit(valuetype [mscorlib]System.Decimal)
    IL_00a8:  nop
    IL_00a9:  ldstr      "{0} balance: {1:C}"
    IL_00ae:  ldloc.0
    IL_00af:  callvirt   instance string AccountApp.Account::get_Type()
    IL_00b4:  ldloc.0
    IL_00b5:  callvirt   instance valuetype [mscorlib]System.Decimal AccountApp.Account::get_Balance()
    IL_00ba:  box        [mscorlib]System.Decimal
    IL_00bf:  call       string [mscorlib]System.String::Format(string,
                                                                object,
                                                                object)
    IL_00c4:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_00c9:  nop
    IL_00ca:  ldstr      "{0} balance: {1:C}"
    IL_00cf:  ldloc.1
    IL_00d0:  callvirt   instance string AccountApp.Account::get_Type()
    IL_00d5:  ldloc.1
    IL_00d6:  callvirt   instance valuetype [mscorlib]System.Decimal AccountApp.Account::get_Balance()
    IL_00db:  box        [mscorlib]System.Decimal
    IL_00e0:  call       string [mscorlib]System.String::Format(string,
                                                                object,
                                                                object)
    IL_00e5:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_00ea:  nop
    IL_00eb:  ldstr      "\nEnter deposit amount for your Savings account: "
    IL_00f0:  call       void [mscorlib]System.Console::Write(string)
    IL_00f5:  nop
    IL_00f6:  call       string [mscorlib]System.Console::ReadLine()
    IL_00fb:  call       valuetype [mscorlib]System.Decimal [mscorlib]System.Decimal::Parse(string)
    IL_0100:  stloc.2
    IL_0101:  ldstr      "adding {0:C} to Savings balance\n"
    IL_0106:  ldloc.2
    IL_0107:  box        [mscorlib]System.Decimal
    IL_010c:  call       string [mscorlib]System.String::Format(string,
                                                                object)
    IL_0111:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0116:  nop
    IL_0117:  ldloc.1
    IL_0118:  ldloc.2
    IL_0119:  callvirt   instance void AccountApp.Account::Deposit(valuetype [mscorlib]System.Decimal)
    IL_011e:  nop
    IL_011f:  ldstr      "{0} balance: {1:C}"
    IL_0124:  ldloc.0
    IL_0125:  callvirt   instance string AccountApp.Account::get_Type()
    IL_012a:  ldloc.0
    IL_012b:  callvirt   instance valuetype [mscorlib]System.Decimal AccountApp.Account::get_Balance()
    IL_0130:  box        [mscorlib]System.Decimal
    IL_0135:  call       string [mscorlib]System.String::Format(string,
                                                                object,
                                                                object)
    IL_013a:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_013f:  nop
    IL_0140:  ldstr      "{0} balance: {1:C}"
    IL_0145:  ldloc.1
    IL_0146:  callvirt   instance string AccountApp.Account::get_Type()
    IL_014b:  ldloc.1
    IL_014c:  callvirt   instance valuetype [mscorlib]System.Decimal AccountApp.Account::get_Balance()
    IL_0151:  box        [mscorlib]System.Decimal
    IL_0156:  call       string [mscorlib]System.String::Format(string,
                                                                object,
                                                                object)
    IL_015b:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0160:  nop
    IL_0161:  call       string [mscorlib]System.Console::ReadLine()
    IL_0166:  pop
    IL_0167:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       8 (0x8)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  nop
    IL_0007:  ret
  } // end of method Program::.ctor

} // end of class AccountApp.Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file C:\Mirela\BCIT\2020 January\COMP 3951\Labs\Lab_1\AccountApp\account.res
