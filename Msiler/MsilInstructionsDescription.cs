﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quart.Msiler
{
    internal class MsilInstructionsDescription
    {
        public static Dictionary<string, string> InstructionDescriptions =
            new Dictionary<string, string> {
                { "add", "Add two values, returning a new value." },
                { "add.ovf", "Add signed integer values with overflow check." },
                { "add.ovf.un", "Add unsigned integer values with overflow check." },
                { "and", "Bitwise AND of two integral values, returns an integral value." },
                { "arglist", "Return argument list handle for the current method." },
                { "beq", "Branch to target if equal." },
                { "beq.s", "Branch to target if equal, short form." },
                { "bge", "Branch to target if greater than or equal to." },
                { "bge.s", "Branch to target if greater than or equal to, short form." }, {
                    "bge.un",
                    "Branch to target if greater than or equal to (unsigned or unordered)."
                }, {
                    "bge.un.s",
                    "Branch to target if greater than or equal to (unsigned or unordered), short form"
                },
                { "bgt", "Branch to target if greater than." },
                { "bgt.s", "Branch to target if greater than, short form." },
                { "bgt.un", "Branch to target if greater than (unsigned or unordered)." }, {
                    "bgt.un.s",
                    "Branch to target if greater than (unsigned or unordered), short form."
                },
                { "ble", "Branch to target if less than or equal to." },
                { "ble.s", "Branch to target if less than or equal to, short form." },
                { "ble.un", "Branch to target if less than or equal to (unsigned or unordered)." }, {
                    "ble.un.s",
                    "Branch to target if less than or equal to (unsigned or unordered), short form"
                },
                { "blt", "Branch to target if less than." },
                { "blt.s", "Branch to target if less than, short form." },
                { "blt.un", "Branch to target if less than (unsigned or unordered)." },
                { "blt.un.s", "Branch to target if less than (unsigned or unordered), short form." },
                { "bne.un", "Branch to target if unequal or unordered." },
                { "bne.un.s", "Branch to target if unequal or unordered, short form." },
                { "box", "Convert a boxable value to its boxed form   Object model instruction" },
                { "br", "Branch to target." },
                { "br.s", "Branch to target, short form." },
                { "break", "Inform a debugger that a breakpoint has been reached." },
                { "brfalse", "Branch to target if value is zero (false)." },
                { "brfalse.s", "Branch to target if value is zero (false), short form." }, {
                    "brinst",
                    "Branch to target if value is a non-null object reference (alias for brtrue)."
                }, {
                    "brinst.s",
                    "Branch to target if value is a non-null object reference, short form (alias for brtrue.s)."
                },
                { "brnull", "Branch to target if value is null (alias for brfalse)." }, {
                    "brnull.s",
                    "Branch to target if value is null (alias for brfalse.s), short form."
                },
                { "brtrue", "Branch to target if value is non-zero (true)." },
                { "brtrue.s", "Branch to target if value is non-zero (true), short form." },
                { "brzero", "Branch to target if value is zero (alias for brfalse)." }, {
                    "brzero.s",
                    "Branch to target if value is zero (alias for brfalse.s), short form."
                },
                { "call", "Call method described by method." }, {
                    "calli",
                    "Call method indicated on the stack with arguments described by callsitedescr."
                }, {
                    "callvirt",
                    "Call a method associated with an object.    Object model instruction"
                },
                { "castclass", "Cast obj to class.  Object model instruction" },
                { "ceq", "Push 1 (of type int32) if value1 equals value2, else push 0." },
                { "cgt", "Push 1 (of type int32) if value1 > value2, else push 0." }, {
                    "cgt.un",
                    "Push 1 (of type int32) if value1 > value2, unsigned or unordered, else push 0."
                },
                { "ckfinite", "Throw ArithmeticException if value is not a finite number." },
                { "clt", "Push 1 (of type int32) if value1 < value2, else push 0." }, {
                    "clt.un",
                    "Push 1 (of type int32) if value1 < value2, unsigned or unordered, else push 0."
                },
                { "constrained.", "Call a virtual method on a type constrained to be type T" },
                { "conv.i", "Convert to native int, pushing native int on stack." },
                { "conv.i1", "Convert to int8, pushing int32 on stack." },
                { "conv.i2", "Convert to int16, pushing int32 on stack." },
                { "conv.i4", "Convert to int32, pushing int32 on stack." },
                { "conv.i8", "Convert to int64, pushing int64 on stack." }, {
                    "conv.ovf.i",
                    "Convert to a native int (on the stack as native int) and throw an exception on overflow."
                }, {
                    "conv.ovf.i.un",
                    "Convert unsigned to a native int (on the stack as native int) and throw an exception on overflow."
                }, {
                    "conv.ovf.i1",
                    "Convert to an int8 (on the stack as int32) and throw an exception on overflow."
                }, {
                    "conv.ovf.i1.un",
                    "Convert unsigned to an int8 (on the stack as int32) and throw an exception on overflow."
                }, {
                    "conv.ovf.i2",
                    "Convert to an int16 (on the stack as int32) and throw an exception on overflow."
                }, {
                    "conv.ovf.i2.un",
                    "Convert unsigned to an int16 (on the stack as int32) and throw an exception on overflow."
                }, {
                    "conv.ovf.i4",
                    "Convert to an int32 (on the stack as int32) and throw an exception on overflow."
                }, {
                    "conv.ovf.i4.un",
                    "Convert unsigned to an int32 (on the stack as int32) and throw an exception on overflow."
                }, {
                    "conv.ovf.i8",
                    "Convert to an int64 (on the stack as int64) and throw an exception on overflow."
                }, {
                    "conv.ovf.i8.un",
                    "Convert unsigned to an int64 (on the stack as int64) and throw an exception on overflow."
                }, {
                    "conv.ovf.u",
                    "Convert to a native unsigned int (on the stack as native int) and throw an exception on overflow."
                }, {
                    "conv.ovf.u.un",
                    "Convert unsigned to a native unsigned int (on the stack as native int) and throw an exception on overflow."
                }, {
                    "conv.ovf.u1",
                    "Convert to an unsigned int8 (on the stack as int32) and throw an exception on overflow."
                }, {
                    "conv.ovf.u1.un",
                    "Convert unsigned to an unsigned int8 (on the stack as int32) and throw an exception on overflow."
                }, {
                    "conv.ovf.u2",
                    "Convert to an unsigned int16 (on the stack as int32) and throw an exception on overflow."
                }, {
                    "conv.ovf.u2.un",
                    "Convert unsigned to an unsigned int16 (on the stack as int32) and throw an exception on overflow."
                }, {
                    "conv.ovf.u4",
                    "Convert to an unsigned int32 (on the stack as int32) and throw an exception on overflow."
                }, {
                    "conv.ovf.u4.un",
                    "Convert unsigned to an unsigned int32 (on the stack as int32) and throw an exception on overflow."
                }, {
                    "conv.ovf.u8",
                    "Convert to an unsigned int64 (on the stack as int64) and throw an exception on overflow."
                }, {
                    "conv.ovf.u8.un",
                    "Convert unsigned to an unsigned int64 (on the stack as int64) and throw an exception on overflow."
                },
                { "conv.r.un", "Convert unsigned integer to floating-point, pushing F on stack." },
                { "conv.r4", "Convert to float32, pushing F on stack." },
                { "conv.r8", "Convert to float64, pushing F on stack." },
                { "conv.u", "Convert to native unsigned int, pushing native int on stack." },
                { "conv.u1", "Convert to unsigned int8, pushing int32 on stack." },
                { "conv.u2", "Convert to unsigned int16, pushing int32 on stack." },
                { "conv.u4", "Convert to unsigned int32, pushing int32 on stack." },
                { "conv.u8", "Convert to unsigned int64, pushing int64 on stack." },
                { "cpblk", "Copy data from memory to memory." },
                { "cpobj", "Copy a value type from src to dest. Object model instruction" },
                { "div", "Divide two values to return a quotient or floating-point result." },
                { "div.un", "Divide two values, unsigned, returning a quotient." },
                { "dup", "Duplicate the value on the top of the stack." },
                { "endfault", "End fault clause of an exception block." },
                { "endfilter", "End an exception handling filter clause." },
                { "endfinally", "End finally clause of an exception block." },
                { "initblk", "Set all bytes in a block of memory to a given byte value." },
                { "initobj", "Initialize the value at address dest.   Object model instruction" }, {
                    "isinst",
                    "Test if obj is an instance of class, returning null or an instance of that class or interface.  Object model instruction"
                },
                { "jmp", "Exit current method and jump to the specified method." },
                { "ldarg", "Load argument numbered num onto the stack." },
                { "ldarg.0", "Load argument 0 onto the stack." },
                { "ldarg.1", "Load argument 1 onto the stack." },
                { "ldarg.2", "Load argument 2 onto the stack." },
                { "ldarg.3", "Load argument 3 onto the stack." },
                { "ldarg.s", "Load argument numbered num onto the stack, short form." },
                { "ldarga", "Fetch the address of argument argNum." },
                { "ldarga.s", "Fetch the address of argument argNum, short form." },
                { "ldc.i4", "Push num of type int32 onto the stack as int32." },
                { "ldc.i4.0", "Push 0 onto the stack as int32." },
                { "ldc.i4.1", "Push 1 onto the stack as int32." },
                { "ldc.i4.2", "Push 2 onto the stack as int32." },
                { "ldc.i4.3", "Push 3 onto the stack as int32." },
                { "ldc.i4.4", "Push 4 onto the stack as int32." },
                { "ldc.i4.5", "Push 5 onto the stack as int32." },
                { "ldc.i4.6", "Push 6 onto the stack as int32." },
                { "ldc.i4.7", "Push 7 onto the stack as int32." },
                { "ldc.i4.8", "Push 8 onto the stack as int32." },
                { "ldc.i4.m1", "Push -1 onto the stack as int32." }, {
                    "ldc.i4.M1",
                    "Push -1 of type int32 onto the stack as int32 (alias for ldc.i4.m1)."
                },
                { "ldc.i4.s", "Push num onto the stack as int32, short form." },
                { "ldc.i8", "Push num of type int64 onto the stack as int64." },
                { "ldc.r4", "Push num of type float32 onto the stack as F." },
                { "ldc.r8", "Push num of type float64 onto the stack as F." }, {
                    "ldelem",
                    "Load the element at index onto the top of the stack.    Object model instruction"
                }, {
                    "ldelem.i",
                    "Load the element with type native int at index onto the top of the stack as a native int.   Object model instruction"
                }, {
                    "ldelem.i1",
                    "Load the element with type int8 at index onto the top of the stack as an int32. Object model instruction"
                }, {
                    "ldelem.i2",
                    "Load the element with type int16 at index onto the top of the stack as an int32.    Object model instruction"
                }, {
                    "ldelem.i4",
                    "Load the element with type int32 at index onto the top of the stack as an int32.    Object model instruction"
                }, {
                    "ldelem.i8",
                    "Load the element with type int64 at index onto the top of the stack as an int64.    Object model instruction"
                }, {
                    "ldelem.r4",
                    "Load the element with type float32 at index onto the top of the stack as an F   Object model instruction"
                }, {
                    "ldelem.r8",
                    "Load the element with type float64 at index onto the top of the stack as an F.  Object model instruction"
                }, {
                    "ldelem.ref",
                    "Load the element at index onto the top of the stack as an O. The type of the O is the same as the element type of the array pushed on the CIL stack.    Object model instruction"
                }, {
                    "ldelem.u1",
                    "Load the element with type unsigned int8 at index onto the top of the stack as an int32.    Object model instruction"
                }, {
                    "ldelem.u2",
                    "Load the element with type unsigned int16 at index onto the top of the stack as an int32.   Object model instruction"
                }, {
                    "ldelem.u4",
                    "Load the element with type unsigned int32 at index onto the top of the stack as an int32.   Object model instruction"
                }, {
                    "ldelem.u8",
                    "Load the element with type unsigned int64 at index onto the top of the stack as an int64 (alias for ldelem.i8). Object model instruction"
                }, {
                    "ldelema",
                    "Load the address of element at index onto the top of the stack. Object model instruction"
                }, {
                    "ldfld",
                    "Push the value of field of object (or value type) obj, onto the stack.  Object model instruction"
                }, {
                    "ldflda",
                    "Push the address of field of object obj on the stack.   Object model instruction"
                },
                { "ldftn", "Push a pointer to a method referenced by method, on the stack." },
                { "ldind.i", "Indirect load value of type native int as native int on the stack" },
                { "ldind.i1", "Indirect load value of type int8 as int32 on the stack." },
                { "ldind.i2", "Indirect load value of type int16 as int32 on the stack." },
                { "ldind.i4", "Indirect load value of type int32 as int32 on the stack." },
                { "ldind.i8", "Indirect load value of type int64 as int64 on the stack." },
                { "ldind.r4", "Indirect load value of type float32 as F on the stack." },
                { "ldind.r8", "Indirect load value of type float64 as F on the stack." },
                { "ldind.ref", "Indirect load value of type object ref as O on the stack." },
                { "ldind.u1", "Indirect load value of type unsigned int8 as int32 on the stack" },
                { "ldind.u2", "Indirect load value of type unsigned int16 as int32 on the stack" },
                { "ldind.u4", "Indirect load value of type unsigned int32 as int32 on the stack" }, {
                    "ldind.u8",
                    "Indirect load value of type unsigned int64 as int64 on the stack (alias for ldind.i8)."
                }, {
                    "ldlen",
                    "Push the length (of type native unsigned int) of array on the stack.    Object model instruction"
                },
                { "ldloc", "Load local variable of index indx onto stack." },
                { "ldloc.0", "Load local variable 0 onto stack." },
                { "ldloc.1", "Load local variable 1 onto stack." },
                { "ldloc.2", "Load local variable 2 onto stack." },
                { "ldloc.3", "Load local variable 3 onto stack." },
                { "ldloc.s", "Load local variable of index indx onto stack, short form." },
                { "ldloca", "Load address of local variable with index indx." },
                { "ldloca.s", "Load address of local variable with index indx, short form." },
                { "ldnull", "Push a null reference on the stack." }, {
                    "ldobj",
                    "Copy the value stored at address src to the stack.  Object model instruction"
                },
                { "ldsfld", "Push the value of field on the stack.   Object model instruction" }, {
                    "ldsflda",
                    "Push the address of the static field, field, on the stack.  Object model instruction"
                }, {
                    "ldstr",
                    "Push a string object for the literal string.    Object model instruction"
                }, {
                    "ldtoken",
                    "Convert metadata token to its runtime representation.   Object model instruction"
                }, {
                    "ldvirtftn",
                    "Push address of virtual method on the stack.    Object model instruction"
                },
                { "leave", "Exit a protected region of code." },
                { "leave.s", "Exit a protected region of code, short form." },
                { "localloc", "Allocate space from the local memory pool." }, {
                    "mkrefany",
                    "Push a typed reference to ptr of type class onto the stack. Object model instruction"
                },
                { "mul", "Multiply values." }, {
                    "mul.ovf",
                    "Multiply signed integer values. Signed result shall fit in same size"
                }, {
                    "mul.ovf.un",
                    "Multiply unsigned integer values. Unsigned result shall fit in same size"
                },
                { "neg", "Negate value." }, {
                    "newarr",
                    "Create a new array with elements of type etype. Object model instruction"
                }, {
                    "newobj",
                    "Allocate an uninitialized object or value type and call ctor.   Object model instruction"
                }, {
                    "no.typecheck",
                    "The specified fault check(s) normally performed as part of the execution of the subsequent instruction can/shall be skipped."
                }, {
                    "no.rangecheck",
                    "The specified fault check(s) normally performed as part of the execution of the subsequent instruction can/shall be skipped."
                }, {
                    "no.nullcheck",
                    "The specified fault check(s) normally performed as part of the execution of the subsequent instruction can/shall be skipped."
                },
                { "nop", "Do nothing (No operation)." },
                { "not", "Bitwise complement (logical not)." },
                { "or", "Bitwise OR of two integer values, returns an integer." },
                { "pop", "Pop value from the stack." }, {
                    "readonly.",
                    "Specify that the subsequent array address operation performs no type check at runtime, and that it returns a controlled-mutability managed pointer"
                }, {
                    "refanytype",
                    "Push the type token stored in a typed reference.    Object model instruction"
                }, {
                    "refanyval",
                    "Push the address stored in a typed reference.   Object model instruction"
                },
                { "rem", "Remainder when dividing one value by another." },
                { "rem.un", "Remainder when dividing one unsigned value by another." },
                { "ret", "Return from method, possibly with a value." },
                { "rethrow", "Rethrow the current exception.  Object model instruction" },
                { "shl", "Shift an integer left (shifting in zeros), return an integer." },
                { "shr", "Shift an integer right (shift in sign), return an integer." },
                { "shr.un", "Shift an integer right (shift in zero), return an integer." }, {
                    "sizeof",
                    "Push the size, in bytes, of a type as an unsigned int32.    Object model instruction"
                },
                { "starg", "Store value to the argument numbered num." },
                { "starg.s", "Store value to the argument numbered num, short form." }, {
                    "stelem",
                    "Replace array element at index with the value on the stack  Object model instruction"
                }, {
                    "stelem.i",
                    "Replace array element at index with the i value on the stack.   Object model instruction"
                }, {
                    "stelem.i1",
                    "Replace array element at index with the int8 value on the stack.    Object model instruction"
                }, {
                    "stelem.i2",
                    "Replace array element at index with the int16 value on the stack.   Object model instruction"
                }, {
                    "stelem.i4",
                    "Replace array element at index with the int32 value on the stack.   Object model instruction"
                }, {
                    "stelem.i8",
                    "Replace array element at index with the int64 value on the stack.   Object model instruction"
                }, {
                    "stelem.r4",
                    "Replace array element at index with the float32 value on the stack. Object model instruction"
                }, {
                    "stelem.r8",
                    "Replace array element at index with the float64 value on the stack. Object model instruction"
                }, {
                    "stelem.ref",
                    "Replace array element at index with the ref value on the stack. Object model instruction"
                }, {
                    "stfld",
                    "Replace the value of field of the object obj with value.    Object model instruction"
                },
                { "stind.i", "Store value of type native int into memory at address" },
                { "stind.i1", "Store value of type int8 into memory at address" },
                { "stind.i2", "Store value of type int16 into memory at address" },
                { "stind.i4", "Store value of type int32 into memory at address" },
                { "stind.i8", "Store value of type int64 into memory at address" },
                { "stind.r4", "Store value of type float32 into memory at address" },
                { "stind.r8", "Store value of type float64 into memory at address" },
                { "stind.ref", "Store value of type object ref (type O) into memory at address" },
                { "stloc", "Pop a value from stack into local variable indx." },
                { "stloc.0", "Pop a value from stack into local variable 0." },
                { "stloc.1", "Pop a value from stack into local variable 1." },
                { "stloc.2", "Pop a value from stack into local variable 2." },
                { "stloc.3", "Pop a value from stack into local variable 3." },
                { "stloc.s", "Pop a value from stack into local variable indx, short form." }, {
                    "stobj",
                    "Store a value of type typeTok at an address.    Object model instruction"
                },
                { "stsfld", "Replace the value of field with val.    Object model instruction" },
                { "sub", "Subtract value2 from value1, returning a new value." }, {
                    "sub.ovf",
                    "Subtract native int from a native int. Signed result shall fit in same size"
                }, {
                    "sub.ovf.un",
                    "Subtract native unsigned int from a native unsigned int. Unsigned result shall fit in same size."
                },
                { "switch", "Jump to one of n values." },
                { "tail.", "Subsequent call terminates current method" },
                { "throw", "Throw an exception. Object model instruction" },
                { "unaligned. (alignment)", "Subsequent pointer instruction might be unaligned." }, {
                    "unbox",
                    "Extract a value-type from obj, its boxed representation.    Object model instruction"
                }, {
                    "unbox.any",
                    "Extract a value-type from obj, its boxed representation Object model instruction"
                },
                { "volatile.", "Subsequent pointer reference is volatile." },
                { "xor", "Bitwise XOR of integer values, returns an integer." }
            };
    }
}
