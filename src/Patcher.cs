/*
 * MIT License
 * 
 * Copyright (c) 2026 Runic Compiler Toolkit Contributors
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net;
using System.Reflection;
using System.Reflection.Emit;
using static Runic.CIL.Emitter;

namespace Runic.CIL
{
    public abstract partial class Patcher
    {
        public abstract int Position { get; }
        public abstract void Emit(byte b);
        public virtual void Fetch(Runic.CIL.Emitter emitter, int offset) { }
        public virtual void Add(Runic.CIL.Emitter emitter, int offset) { emitter.Add(); }
        public virtual void AddOvf(Runic.CIL.Emitter emitter, int offset) { emitter.AddOvf(); }
        public virtual void AddOvfUn(Runic.CIL.Emitter emitter, int offset) { emitter.AddOvfUn(); }
        public virtual void And(Runic.CIL.Emitter emitter, int offset) { emitter.And(); }
        public virtual void ArgList(Runic.CIL.Emitter emitter, int offset) { emitter.ArgList(); }
        public virtual void Box(Runic.CIL.Emitter emitter, int offset, uint typeToken) { emitter.Box(typeToken); }
        public virtual void Br(Runic.CIL.Emitter emitter, int offset, int address) { Emitter internalEmitter = emitter as Emitter; emitter.Br(internalEmitter.GetLabel(address)); }
        public virtual void Break(Runic.CIL.Emitter emitter, int offset) { emitter.Break(); }
        public virtual void BrEq(Runic.CIL.Emitter emitter, int offset, int address) { Emitter internalEmitter = emitter as Emitter; emitter.BrEq(internalEmitter.GetLabel(address)); }
        public virtual void BrFalse(Runic.CIL.Emitter emitter, int offset, int address) { Emitter internalEmitter = emitter as Emitter; emitter.BrFalse(internalEmitter.GetLabel(address)); }
        public virtual void BrGt(Runic.CIL.Emitter emitter, int offset, int address) { Emitter internalEmitter = emitter as Emitter; emitter.BrGt(internalEmitter.GetLabel(address)); }
        public virtual void BrGtUn(Runic.CIL.Emitter emitter, int offset, int address) { Emitter internalEmitter = emitter as Emitter; emitter.BrGtUn(internalEmitter.GetLabel(address)); }
        public virtual void BrLe(Runic.CIL.Emitter emitter, int offset, int address) { Emitter internalEmitter = emitter as Emitter; emitter.BrLe(internalEmitter.GetLabel(address)); }
        public virtual void BrLeUn(Runic.CIL.Emitter emitter, int offset, int address) { Emitter internalEmitter = emitter as Emitter; emitter.BrLeUn(internalEmitter.GetLabel(address)); }
        public virtual void BrLt(Runic.CIL.Emitter emitter, int offset, int address) { Emitter internalEmitter = emitter as Emitter; emitter.BrLt(internalEmitter.GetLabel(address)); }
        public virtual void BrLtUn(Runic.CIL.Emitter emitter, int offset, int address) { Emitter internalEmitter = emitter as Emitter; emitter.BrLtUn(internalEmitter.GetLabel(address)); }
        public virtual void BrGe(Runic.CIL.Emitter emitter, int offset, int address) { Emitter internalEmitter = emitter as Emitter; emitter.BrGe(internalEmitter.GetLabel(address)); }
        public virtual void BrGeUn(Runic.CIL.Emitter emitter, int offset, int address) { Emitter internalEmitter = emitter as Emitter; emitter.BrGeUn(internalEmitter.GetLabel(address)); }
        public virtual void BrNeqUn(Runic.CIL.Emitter emitter, int offset, int address) { Emitter internalEmitter = emitter as Emitter; emitter.BrNeqUn(internalEmitter.GetLabel(address)); }
        public virtual void BrTrue(Runic.CIL.Emitter emitter, int offset, int address) { Emitter internalEmitter = emitter as Emitter; emitter.BrTrue(internalEmitter.GetLabel(address)); }
        public virtual void Call(Runic.CIL.Emitter emitter, int offset, bool tail, uint methodToken) { emitter.Call(tail, methodToken); }
        public virtual void CallI(Runic.CIL.Emitter emitter, int offset, bool tail, uint descriptorToken) { emitter.CallI(tail, descriptorToken); }
        public virtual void CallVirt(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, uint constrainedType, bool tail, uint methodToken) { emitter.CallVirt(noNullCheck, constrainedType, tail, methodToken); }
        public virtual void CastClass(Runic.CIL.Emitter emitter, int offset, bool noTypeCheck, uint typeToken) { emitter.CastClass(noTypeCheck, typeToken); }
        public virtual void Ceq(Runic.CIL.Emitter emitter, int offset) { emitter.Ceq(); }
        public virtual void Cgt(Runic.CIL.Emitter emitter, int offset) { emitter.Cgt(); }
        public virtual void CgtUn(Runic.CIL.Emitter emitter, int offset) { emitter.CgtUn(); }
        public virtual void Clt(Runic.CIL.Emitter emitter, int offset) { emitter.Clt(); }
        public virtual void CltUn(Runic.CIL.Emitter emitter, int offset) { emitter.CltUn(); }
        public virtual void CkFinite(Runic.CIL.Emitter emitter, int offset) { emitter.CkFinite(); }
        public virtual void ConvI(Runic.CIL.Emitter emitter, int offset) { emitter.ConvI(); }
        public virtual void ConvI1(Runic.CIL.Emitter emitter, int offset) { emitter.ConvI1(); }
        public virtual void ConvI2(Runic.CIL.Emitter emitter, int offset) { emitter.ConvI2(); }
        public virtual void ConvI4(Runic.CIL.Emitter emitter, int offset) { emitter.ConvI4(); }
        public virtual void ConvI8(Runic.CIL.Emitter emitter, int offset) { emitter.ConvI8(); }
        public virtual void ConvOvfI(Runic.CIL.Emitter emitter, int offset) { emitter.ConvOvfI(); }
        public virtual void ConvOvfI1(Runic.CIL.Emitter emitter, int offset) { emitter.ConvOvfI1(); }
        public virtual void ConvOvfI1Un(Runic.CIL.Emitter emitter, int offset) { emitter.ConvOvfI1Un(); }
        public virtual void ConvOvfI2(Runic.CIL.Emitter emitter, int offset) { emitter.ConvOvfI2(); }
        public virtual void ConvOvfI2Un(Runic.CIL.Emitter emitter, int offset) { emitter.ConvOvfI2Un(); }
        public virtual void ConvOvfI4(Runic.CIL.Emitter emitter, int offset) { emitter.ConvOvfI4(); }
        public virtual void ConvOvfI4Un(Runic.CIL.Emitter emitter, int offset) { emitter.ConvOvfI4Un(); }
        public virtual void ConvOvfI8(Runic.CIL.Emitter emitter, int offset) { emitter.ConvOvfI8(); }
        public virtual void ConvOvfI8Un(Runic.CIL.Emitter emitter, int offset) { emitter.ConvOvfI8Un(); }
        public virtual void ConvOvfIUn(Runic.CIL.Emitter emitter, int offset) { emitter.ConvOvfIUn(); }
        public virtual void ConvOvfU(Runic.CIL.Emitter emitter, int offset) { emitter.ConvOvfU(); }
        public virtual void ConvOvfU1(Runic.CIL.Emitter emitter, int offset) { emitter.ConvOvfU1(); }
        public virtual void ConvOvfU1Un(Runic.CIL.Emitter emitter, int offset) { emitter.ConvOvfU1Un(); }
        public virtual void ConvOvfU2(Runic.CIL.Emitter emitter, int offset) { emitter.ConvOvfU2(); }
        public virtual void ConvOvfU2Un(Runic.CIL.Emitter emitter, int offset) { emitter.ConvOvfU2Un(); }
        public virtual void ConvOvfU4(Runic.CIL.Emitter emitter, int offset) { emitter.ConvOvfU4(); }
        public virtual void ConvOvfU4Un(Runic.CIL.Emitter emitter, int offset) { emitter.ConvOvfU4Un(); }
        public virtual void ConvOvfU8(Runic.CIL.Emitter emitter, int offset) { emitter.ConvOvfU8(); }
        public virtual void ConvOvfU8Un(Runic.CIL.Emitter emitter, int offset) { emitter.ConvOvfU8Un(); }
        public virtual void ConvOvfUUn(Runic.CIL.Emitter emitter, int offset) { emitter.ConvOvfUUn(); }
        public virtual void ConvR4(Runic.CIL.Emitter emitter, int offset) { emitter.ConvR4(); }
        public virtual void ConvR8(Runic.CIL.Emitter emitter, int offset) { emitter.ConvR8(); }
        public virtual void ConvRUn(Runic.CIL.Emitter emitter, int offset) { emitter.ConvRUn(); }
        public virtual void ConvU(Runic.CIL.Emitter emitter, int offset) { emitter.ConvU(); }
        public virtual void ConvU1(Runic.CIL.Emitter emitter, int offset) { emitter.ConvU1(); }
        public virtual void ConvU2(Runic.CIL.Emitter emitter, int offset) { emitter.ConvU2(); }
        public virtual void ConvU4(Runic.CIL.Emitter emitter, int offset) { emitter.ConvU4(); }
        public virtual void ConvU8(Runic.CIL.Emitter emitter, int offset) { emitter.ConvU8(); }
        public virtual void CopyObj(Runic.CIL.Emitter emitter, int offset, uint typeToken) { emitter.CopyObj(typeToken); }
        public virtual void CpBlk(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, int alignment) { emitter.CpBlk(volatilePrefix, alignment); }
        public virtual void Div(Runic.CIL.Emitter emitter, int offset) { emitter.Div(); }
        public virtual void DivUn(Runic.CIL.Emitter emitter, int offset) { emitter.DivUn(); }
        public virtual void Dup(Runic.CIL.Emitter emitter, int offset) { emitter.Dup(); }
        public virtual void EndFilter(Runic.CIL.Emitter emitter, int offset) { emitter.EndFilter(); }
        public virtual void EndFinally(Runic.CIL.Emitter emitter, int offset) { emitter.EndFinally(); }
        public virtual void InitBlk(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, int alignment) { emitter.InitBlk(volatilePrefix, alignment); }
        public virtual void InitObj(Runic.CIL.Emitter emitter, int offset, uint typeToken) { emitter.InitObj(typeToken); }
        public virtual void IsInst(Runic.CIL.Emitter emitter, int offset, uint typeToken) { emitter.IsInst(typeToken); }
        public virtual void Jmp(Runic.CIL.Emitter emitter, int offset, uint methodToken) { emitter.Jmp(methodToken); }
        public virtual void LdArg(Runic.CIL.Emitter emitter, int offset, int index) { emitter.LdArg(index); }
        public virtual void LdArgA(Runic.CIL.Emitter emitter, int offset, int index) { emitter.LdArgA(index); }
        public virtual void LdcI4(Runic.CIL.Emitter emitter, int offset, int constant) { emitter.LdcI4(constant); }
        public virtual void LdcI8(Runic.CIL.Emitter emitter, int offset, long constant) { emitter.LdcI8(constant); }
        public virtual void LdcR4(Runic.CIL.Emitter emitter, int offset, float constant) { emitter.LdcR4(constant); }
        public virtual void LdcR8(Runic.CIL.Emitter emitter, int offset, double constant) { emitter.LdcR8(constant); }
        public virtual void LdLoc(Runic.CIL.Emitter emitter, int offset, int index) { emitter.LdLoc(index); }
        public virtual void LdLocA(Runic.CIL.Emitter emitter, int offset, int index) { emitter.LdLocA(index); }
        public virtual void LdElem(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noBoundCheck, uint typeToken) { emitter.LdElem(noNullCheck, noBoundCheck, typeToken); }
        public virtual void LdElemA(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noTypeCheck, bool noBoundCheck, bool readOnly, uint typeToken) { emitter.LdElemA(noNullCheck, noTypeCheck, noBoundCheck, readOnly, typeToken); }
        public virtual void LdElemI(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noBoundCheck) { emitter.LdElemI(noNullCheck, noBoundCheck); }
        public virtual void LdElemI1(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noBoundCheck) { emitter.LdElemI1(noNullCheck, noBoundCheck); }
        public virtual void LdElemI2(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noBoundCheck) { emitter.LdElemI2(noNullCheck, noBoundCheck); }
        public virtual void LdElemI4(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noBoundCheck) { emitter.LdElemI4(noNullCheck, noBoundCheck); }
        public virtual void LdElemI8(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noBoundCheck) { emitter.LdElemI8(noNullCheck, noBoundCheck); }
        public virtual void LdElemR4(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noBoundCheck) { emitter.LdElemR4(noNullCheck, noBoundCheck); }
        public virtual void LdElemR8(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noBoundCheck) { emitter.LdElemR8(noNullCheck, noBoundCheck); }
        public virtual void LdElemRef(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noBoundCheck) { emitter.LdElemRef(noNullCheck, noBoundCheck); }
        public virtual void LdElemU1(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noBoundCheck) { emitter.LdElemU1(noNullCheck, noBoundCheck); }
        public virtual void LdElemU2(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noBoundCheck) { emitter.LdElemU2(noNullCheck, noBoundCheck); }
        public virtual void LdElemU4(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noBoundCheck) { emitter.LdElemU4(noNullCheck, noBoundCheck); }
        public virtual void LdFld(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool volatilePrefix, int alignment, uint fieldToken) { emitter.LdFld(noNullCheck, volatilePrefix, alignment, fieldToken); }
        public virtual void LdFldA(Runic.CIL.Emitter emitter, int offset, uint fieldToken) { emitter.LdFldA(fieldToken); }
        public virtual void LdFtn(Runic.CIL.Emitter emitter, int offset, uint methodToken) { emitter.LdFtn(methodToken); }
        public virtual void LdIndI(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, int alignment) { emitter.LdIndI(volatilePrefix, alignment); }
        public virtual void LdIndI1(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix) { emitter.LdIndI1(volatilePrefix); }
        public virtual void LdIndI2(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, int alignment) { emitter.LdIndI2(volatilePrefix, alignment); }
        public virtual void LdIndI4(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, int alignment) { emitter.LdIndI4(volatilePrefix, alignment); }
        public virtual void LdIndI8(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, int alignment) { emitter.LdIndI8(volatilePrefix, alignment); }
        public virtual void LdIndR4(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, int alignment) { emitter.LdIndR4(volatilePrefix, alignment); }
        public virtual void LdIndR8(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, int alignment) { emitter.LdIndR8(volatilePrefix, alignment); }
        public virtual void LdIndRef(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, int alignment) { emitter.LdIndRef(volatilePrefix, alignment); }
        public virtual void LdIndU1(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix) { emitter.LdIndU1(volatilePrefix); }
        public virtual void LdIndU2(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, int alignment) { emitter.LdIndU2(volatilePrefix, alignment); }
        public virtual void LdIndU4(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, int alignment) { emitter.LdIndU4(volatilePrefix, alignment); }
        public virtual void LdLen(Runic.CIL.Emitter emitter, int offset) { emitter.LdLen(); }
        public virtual void LdNull(Runic.CIL.Emitter emitter, int offset) { emitter.LdNull(); }
        public virtual void LdObj(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, int alignment, uint typeToken) { emitter.LdObj(volatilePrefix, alignment, typeToken); }
        public virtual void LdSFld(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, uint fieldToken) { emitter.LdSFld(volatilePrefix, fieldToken); }
        public virtual void LdSFldA(Runic.CIL.Emitter emitter, int offset, uint fieldToken) { emitter.LdSFldA(fieldToken); }
        public virtual void LdStr(Runic.CIL.Emitter emitter, int offset, uint stringToken) { emitter.LdStr(stringToken); }
        public virtual void LdToken(Runic.CIL.Emitter emitter, int offset, uint token) { emitter.LdToken(token); }
        public virtual void LdVirtFtn(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, uint methodToken) { emitter.LdVirtFtn(noNullCheck, methodToken); }
        public virtual void Leave(Runic.CIL.Emitter emitter, int offset, int address) { Emitter internalEmitter = emitter as Emitter; emitter.Leave(internalEmitter.GetLabel(address)); }
        public virtual void LocAlloc(Runic.CIL.Emitter emitter, int offset) { emitter.LocAlloc(); }
        public virtual void MkRefAny(Runic.CIL.Emitter emitter, int offset, uint typeToken) { emitter.MkRefAny(typeToken); }
        public virtual void Mul(Runic.CIL.Emitter emitter, int offset) { emitter.Mul(); }
        public virtual void MulOvf(Runic.CIL.Emitter emitter, int offset) { emitter.MulOvf(); }
        public virtual void MulOvfUn(Runic.CIL.Emitter emitter, int offset) { emitter.MulOvfUn(); }
        public virtual void Neg(Runic.CIL.Emitter emitter, int offset) { emitter.Neg(); }
        public virtual void NewArr(Runic.CIL.Emitter emitter, int offset, uint typeToken) { emitter.NewArr(typeToken); }
        public virtual void NewObj(Runic.CIL.Emitter emitter, int offset, uint methodToken) { emitter.NewObj(methodToken); }
        public virtual void Nop(Runic.CIL.Emitter emitter, int offset) { emitter.Nop(); }
        public virtual void Not(Runic.CIL.Emitter emitter, int offset) { emitter.Not(); }
        public virtual void Or(Runic.CIL.Emitter emitter, int offset) { emitter.Or(); }
        public virtual void Pop(Runic.CIL.Emitter emitter, int offset) { emitter.Pop(); }
        public virtual void RefAnyType(Runic.CIL.Emitter emitter, int offset) { emitter.RefAnyType(); }
        public virtual void RefAnyVal(Runic.CIL.Emitter emitter, int offset, uint token) { emitter.RefAnyVal(token); }
        public virtual void Rem(Runic.CIL.Emitter emitter, int offset) { emitter.Rem(); }
        public virtual void RemUn(Runic.CIL.Emitter emitter, int offset) { emitter.RemUn(); }
        public virtual void Ret(Runic.CIL.Emitter emitter, int offset) { emitter.Ret(); }
        public virtual void Rethrow(Runic.CIL.Emitter emitter, int offset) { emitter.Rethrow(); }
        public virtual void Shl(Runic.CIL.Emitter emitter, int offset) { emitter.Shl(); }
        public virtual void Shr(Runic.CIL.Emitter emitter, int offset) { emitter.Shr(); }
        public virtual void ShrUn(Runic.CIL.Emitter emitter, int offset) { emitter.ShrUn(); }
        public virtual void SizeOf(Runic.CIL.Emitter emitter, int offset, uint typeToken) { emitter.SizeOf(typeToken); }
        public virtual void StArg(Runic.CIL.Emitter emitter, int offset, int index) { emitter.StArg(index); }
        public virtual void StLoc(Runic.CIL.Emitter emitter, int offset, int index) { emitter.StLoc(index); }
        public virtual void StElem(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noTypeCheck, bool noBoundCheck, uint typeToken) { emitter.StElem(noNullCheck, noTypeCheck, noBoundCheck, typeToken); }
        public virtual void StElemI(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noBoundCheck) { emitter.StElemI(noNullCheck, noBoundCheck); }
        public virtual void StElemI1(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noBoundCheck) { emitter.StElemI1(noNullCheck, noBoundCheck); }
        public virtual void StElemI2(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noBoundCheck) { emitter.StElemI2(noNullCheck, noBoundCheck); }
        public virtual void StElemI4(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noBoundCheck) { emitter.StElemI4(noNullCheck, noBoundCheck); }
        public virtual void StElemI8(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noBoundCheck) { emitter.StElemI8(noNullCheck, noBoundCheck); }
        public virtual void StElemR4(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noBoundCheck) { emitter.StElemR4(noNullCheck, noBoundCheck); }
        public virtual void StElemR8(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noBoundCheck) { emitter.StElemR8(noNullCheck, noBoundCheck); }
        public virtual void StElemRef(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool noBoundCheck) { emitter.StElemRef(noNullCheck, noBoundCheck); }
        public virtual void StFld(Runic.CIL.Emitter emitter, int offset, bool noNullCheck, bool volatilePrefix, int alignment, uint fieldToken) { emitter.StFld(noNullCheck, volatilePrefix, alignment, fieldToken); }
        public virtual void StSFld(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, uint fieldToken) { emitter.StSFld(volatilePrefix, fieldToken); }
        public virtual void StIndI(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, int alignment) { emitter.StIndI(volatilePrefix, alignment); }
        public virtual void StIndI1(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix) { emitter.StIndI1(volatilePrefix); }
        public virtual void StIndI2(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, int alignment) { emitter.StIndI2(volatilePrefix, alignment); }
        public virtual void StIndI4(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, int alignment) { emitter.StIndI4(volatilePrefix, alignment); }
        public virtual void StIndI8(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, int alignment) { emitter.StIndI8(volatilePrefix, alignment); }
        public virtual void StIndR4(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, int alignment) { emitter.StIndR4(volatilePrefix, alignment); }
        public virtual void StIndR8(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, int alignment) { emitter.StIndR8(volatilePrefix, alignment); }
        public virtual void StIndRef(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, int alignment) { emitter.StIndRef(volatilePrefix, alignment); }
        public virtual void StObj(Runic.CIL.Emitter emitter, int offset, bool volatilePrefix, int alignment, uint typeToken) { emitter.StObj(volatilePrefix, alignment, typeToken); }
        public virtual void Sub(Runic.CIL.Emitter emitter, int offset) { emitter.Sub(); }
        public virtual void SubOvf(Runic.CIL.Emitter emitter, int offset) { emitter.SubOvf(); }
        public virtual void SubOvfUn(Runic.CIL.Emitter emitter, int offset) { emitter.SubOvfUn(); }
        public virtual void Throw(Runic.CIL.Emitter emitter, int offset) { emitter.Throw(); }
        public virtual void Unbox(Runic.CIL.Emitter emitter, int offset, bool noTypeCheck, uint typeToken) { emitter.Unbox(noTypeCheck, typeToken); }
        public virtual void UnboxAny(Runic.CIL.Emitter emitter, int offset, uint typeToken) { emitter.UnboxAny(typeToken); }
        public virtual void Xor(Runic.CIL.Emitter emitter, int offset) { emitter.Xor(); }
        public virtual void Switch(Runic.CIL.Emitter emitter, int offset, int[] addresses)
        {
            Emitter internalEmitter = emitter as Emitter;
            Emitter.Label[] labels = new Emitter.Label[addresses.Length];
            for (int n = 0; n < addresses.Length; n++)
            {
                labels[n] = internalEmitter.GetLabel(addresses[n]);
            }
            emitter.Switch(labels);
        }

        class Disassembler : Runic.CIL.Disassembler
        {
            Emitter _emitter;
            Patcher _parent;
            public Disassembler(Patcher patcher, Emitter emitter)
            {
                _parent = patcher;
            }

            public override void Fetch(int offset)
            {
                Emitter.Label label = _emitter.GetLabel(offset);
                _emitter.MarkLabel(label);
                _parent.Fetch(_emitter, offset);
            }
            public override void Add(int offset) { _parent.Add(_emitter, offset); }
            public override void AddOvf(int offset) { _parent.AddOvf(_emitter, offset); }
            public override void AddOvfUn(int offset) { _parent.AddOvfUn(_emitter, offset); }
            public override void And(int offset) { _parent.And(_emitter, offset); }
            public override void ArgList(int offset) { _parent.ArgList(_emitter, offset); }
            public override void Box(int offset, uint typeToken) { _parent.Box(_emitter, offset, typeToken); }
            public override void Br(int offset, int address) { _parent.Br(_emitter, offset, address); }
            public override void Break(int offset) { _parent.Break(_emitter, offset); }
            public override void BrEq(int offset, int address) { _parent.BrEq(_emitter, offset, address); }
            public override void BrFalse(int offset, int address) { _parent.BrFalse(_emitter, offset, address); }
            public override void BrGt(int offset, int address) { _parent.BrGt(_emitter, offset, address); }
            public override void BrGtUn(int offset, int address) { _parent.BrGtUn(_emitter, offset, address); }
            public override void BrLe(int offset, int address) { _parent.BrLe(_emitter, offset, address); }
            public override void BrLeUn(int offset, int address) { _parent.BrLeUn(_emitter, offset, address); }
            public override void BrLt(int offset, int address) { _parent.BrLt(_emitter, offset, address); }
            public override void BrLtUn(int offset, int address) { _parent.BrLtUn(_emitter, offset, address); }
            public override void BrGe(int offset, int address) { _parent.BrGe(_emitter, offset, address); }
            public override void BrGeUn(int offset, int address) { _parent.BrGeUn(_emitter, offset, address); }
            public override void BrNeqUn(int offset, int address) { _parent.BrNeqUn(_emitter, offset, address); }
            public override void BrTrue(int offset, int address) { _parent.BrTrue(_emitter, offset, address); }
            public override void Call(int offset, bool tail, uint methodToken) { _parent.Call(_emitter, offset, tail, methodToken); }
            public override void Calli(int offset, bool tail, uint descriptorToken) { _parent.CallI(_emitter, offset, tail, descriptorToken); }
            public override void CallVirt(int offset, bool noNullCheck, uint constrainedType, bool tail, uint methodToken) { _parent.CallVirt(_emitter, offset, noNullCheck, constrainedType, tail, methodToken); }
            public override void CastClass(int offset, bool noTypeCheck, uint typeToken) { _parent.CastClass(_emitter, offset, noTypeCheck, typeToken); }
            public override void Ceq(int offset) { _parent.Ceq(_emitter, offset); }
            public override void Cgt(int offset) { _parent.Cgt(_emitter, offset); }
            public override void CgtUn(int offset) { _parent.CgtUn(_emitter, offset); }
            public override void Clt(int offset) { _parent.Clt(_emitter, offset); }
            public override void CltUn(int offset) { _parent.CltUn(_emitter, offset); }
            public override void ConvI(int offset) { _parent.ConvI(_emitter, offset); }
            public override void ConvI1(int offset) { _parent.ConvI1(_emitter, offset); }
            public override void ConvI2(int offset) { _parent.ConvI2(_emitter, offset); }
            public override void ConvI4(int offset) { _parent.ConvI4(_emitter, offset); }
            public override void ConvI8(int offset) { _parent.ConvI8(_emitter, offset); }
            public override void ConvOvfI(int offset) { _parent.ConvOvfI(_emitter, offset); }
            public override void ConvOvfI1(int offset) { _parent.ConvOvfI1(_emitter, offset); }
            public override void ConvOvfI1Un(int offset) { _parent.ConvOvfI1Un(_emitter, offset); }
            public override void ConvOvfI2(int offset) { _parent.ConvOvfI2(_emitter, offset); }
            public override void ConvOvfI2Un(int offset) { _parent.ConvOvfI2Un(_emitter, offset); }
            public override void ConvOvfI4(int offset) { _parent.ConvOvfI4(_emitter, offset); }
            public override void ConvOvfI4Un(int offset) { _parent.ConvOvfI4Un(_emitter, offset); }
            public override void ConvOvfI8(int offset) { _parent.ConvOvfI8(_emitter, offset); }
            public override void ConvOvfI8Un(int offset) { _parent.ConvOvfI8Un(_emitter, offset); }
            public override void ConvOvfIUn(int offset) { _parent.ConvOvfIUn(_emitter, offset); }
            public override void ConvOvfU(int offset) { _parent.ConvOvfU(_emitter, offset); }
            public override void ConvOvfU1(int offset) { _parent.ConvOvfU1(_emitter, offset); }
            public override void ConvOvfU1Un(int offset) { _parent.ConvOvfU1Un(_emitter, offset); }
            public override void ConvOvfU2(int offset) { _parent.ConvOvfU2(_emitter, offset); }
            public override void ConvOvfU2Un(int offset) { _parent.ConvOvfU2Un(_emitter, offset); }
            public override void ConvOvfU4(int offset) { _parent.ConvOvfU4(_emitter, offset); }
            public override void ConvOvfU4Un(int offset) { _parent.ConvOvfU4Un(_emitter, offset); }
            public override void ConvOvfU8(int offset) { _parent.ConvOvfU8(_emitter, offset); }
            public override void ConvOvfU8Un(int offset) { _parent.ConvOvfU8Un(_emitter, offset); }
            public override void ConvOvfUUn(int offset) { _parent.ConvOvfUUn(_emitter, offset); }
            public override void ConvR4(int offset) { _parent.ConvR4(_emitter, offset); }
            public override void ConvR8(int offset) { _parent.ConvR8(_emitter, offset); }
            public override void ConvRUn(int offset) { _parent.ConvRUn(_emitter, offset); }
            public override void ConvU(int offset) { _parent.ConvU(_emitter, offset); }
            public override void ConvU1(int offset) { _parent.ConvU1(_emitter, offset); }
            public override void ConvU2(int offset) { _parent.ConvU2(_emitter, offset); }
            public override void ConvU4(int offset) { _parent.ConvU4(_emitter, offset); }
            public override void ConvU8(int offset) { _parent.ConvU8(_emitter, offset); }
            public override void CkFinite(int offset) { _parent.CkFinite(_emitter, offset); }
            public override void CopyObj(int offset, uint typeToken) { _parent.CopyObj(_emitter, offset, typeToken); }
            public override void CpBlk(int offset, bool volatilePrefix, int alignment) { _parent.CpBlk(_emitter, offset, volatilePrefix, alignment); }
            public override void Div(int offset) { _parent.Div(_emitter, offset); }
            public override void DivUn(int offset) { _parent.DivUn(_emitter, offset); }
            public override void Dup(int offset) { _parent.Dup(_emitter, offset); }
            public override void EndFilter(int offset) { _parent.EndFilter(_emitter, offset); }
            public override void EndFinally(int offset) { _parent.EndFinally(_emitter, offset); }
            public override void InitBlk(int offset, bool volatilePrefix, int alignment) { _parent.InitBlk(_emitter, offset, volatilePrefix, alignment); }
            public override void InitObj(int offset, uint typeToken) { _parent.InitObj(_emitter, offset, typeToken); }
            public override void IsInst(int offset, uint typeToken) { _parent.IsInst(_emitter, offset, typeToken); }
            public override void Jmp(int offset, uint methodToken) { _parent.Jmp(_emitter, offset, methodToken); }
            public override void LdArg(int offset, int index) { _parent.LdArg(_emitter, offset, index); }
            public override void LdArgA(int offset, int index) { _parent.LdArgA(_emitter, offset, index); }
            public override void LdcI4(int offset, int constant) { _parent.LdcI4(_emitter, offset, constant); }
            public override void LdcI8(int offset, long constant) { _parent.LdcI8(_emitter, offset, constant); }
            public override void LdcR4(int offset, float constant) { _parent.LdcR4(_emitter, offset, constant); }
            public override void LdcR8(int offset, double constant) { _parent.LdcR8(_emitter, offset, constant); }
            public override void LdLoc(int offset, int index) { _parent.LdLoc(_emitter, offset, index); }
            public override void LdLocA(int offset, int index) { _parent.LdLocA(_emitter, offset, index); }
            public override void LdElem(int offset, bool noNullCheck, bool noBoundCheck, uint typeToken) { _parent.LdElem(_emitter, offset, noNullCheck, noBoundCheck, typeToken); }
            public override void LdElemA(int offset, bool noNullCheck, bool noTypeCheck, bool noBoundCheck, bool readOnly, uint typeToken) { _parent.LdElemA(_emitter, offset, noNullCheck, noTypeCheck, noBoundCheck, readOnly, typeToken); }
            public override void LdElemI(int offset, bool noNullCheck, bool noBoundCheck) { _parent.LdElemI(_emitter, offset, noNullCheck, noBoundCheck); }
            public override void LdElemI1(int offset, bool noNullCheck, bool noBoundCheck) { _parent.LdElemI1(_emitter, offset, noNullCheck, noBoundCheck); }
            public override void LdElemI2(int offset, bool noNullCheck, bool noBoundCheck) { _parent.LdElemI2(_emitter, offset, noNullCheck, noBoundCheck); }
            public override void LdElemI4(int offset, bool noNullCheck, bool noBoundCheck) { _parent.LdElemI4(_emitter, offset, noNullCheck, noBoundCheck); }
            public override void LdElemI8(int offset, bool noNullCheck, bool noBoundCheck) { _parent.LdElemI8(_emitter, offset, noNullCheck, noBoundCheck); }
            public override void LdElemR4(int offset, bool noNullCheck, bool noBoundCheck) { _parent.LdElemR4(_emitter, offset, noNullCheck, noBoundCheck); }
            public override void LdElemR8(int offset, bool noNullCheck, bool noBoundCheck) { _parent.LdElemR8(_emitter, offset, noNullCheck, noBoundCheck); }
            public override void LdElemRef(int offset, bool noNullCheck, bool noBoundCheck) { _parent.LdElemRef(_emitter, offset, noNullCheck, noBoundCheck); }
            public override void LdElemU1(int offset, bool noNullCheck, bool noBoundCheck) { _parent.LdElemU1(_emitter, offset, noNullCheck, noBoundCheck); }
            public override void LdElemU2(int offset, bool noNullCheck, bool noBoundCheck) { _parent.LdElemU2(_emitter, offset, noNullCheck, noBoundCheck); }
            public override void LdElemU4(int offset, bool noNullCheck, bool noBoundCheck) { _parent.LdElemU4(_emitter, offset, noNullCheck, noBoundCheck); }
            public override void LdFld(int offset, bool noNullCheck, bool volatilePrefix, int alignment, uint fieldToken) { _parent.LdFld(_emitter, offset, noNullCheck, volatilePrefix, alignment, fieldToken); }
            public override void LdFldA(int offset, uint fieldToken) { _parent.LdFldA(_emitter, offset, fieldToken); }
            public override void LdFtn(int offset, uint methodToken) { _parent.LdFtn(_emitter, offset, methodToken); }
            public override void LdIndI(int offset, bool volatilePrefix, int alignment) { _parent.LdIndI(_emitter, offset, volatilePrefix, alignment); }
            public override void LdIndI1(int offset, bool volatilePrefix) { _parent.LdIndI1(_emitter, offset, volatilePrefix); }
            public override void LdIndI2(int offset, bool volatilePrefix, int alignment) { _parent.LdIndI2(_emitter, offset, volatilePrefix, alignment); }
            public override void LdIndI4(int offset, bool volatilePrefix, int alignment) { _parent.LdIndI4(_emitter, offset, volatilePrefix, alignment); }
            public override void LdIndI8(int offset, bool volatilePrefix, int alignment) { _parent.LdIndI8(_emitter, offset, volatilePrefix, alignment); }
            public override void LdIndR4(int offset, bool volatilePrefix, int alignment) { _parent.LdIndR4(_emitter, offset, volatilePrefix, alignment); }
            public override void LdIndR8(int offset, bool volatilePrefix, int alignment) { _parent.LdIndR8(_emitter, offset, volatilePrefix, alignment); }
            public override void LdIndRef(int offset, bool volatilePrefix, int alignment) { _parent.LdIndRef(_emitter, offset, volatilePrefix, alignment); }
            public override void LdIndU1(int offset, bool volatilePrefix) { _parent.LdIndU1(_emitter, offset, volatilePrefix); }
            public override void LdIndU2(int offset, bool volatilePrefix, int alignment) { _parent.LdIndU2(_emitter, offset, volatilePrefix, alignment); }
            public override void LdIndU4(int offset, bool volatilePrefix, int alignment) { _parent.LdIndU4(_emitter, offset, volatilePrefix, alignment); }
            public override void LdLen(int offset) { _parent.LdLen(_emitter, offset); }
            public override void LdNull(int offset) { _parent.LdNull(_emitter, offset); }
            public override void LdObj(int offset, bool volatilePrefix, int alignment, uint typeToken) { _parent.LdObj(_emitter, offset, volatilePrefix, alignment, typeToken); }
            public override void LdSFld(int offset, bool volatilePrefix, uint fieldToken) { _parent.LdSFld(_emitter, offset, volatilePrefix, fieldToken); }
            public override void LdSFldA(int offset, uint fieldToken) { _parent.LdSFldA(_emitter, offset, fieldToken); }
            public override void LdStr(int offset, uint stringToken) { _parent.LdStr(_emitter, offset, stringToken); }
            public override void LdToken(int offset, uint token) { _parent.LdToken(_emitter, offset, token); }
            public override void LdVirtFtn(int offset, bool noNullCheck, uint methodToken) { _parent.LdVirtFtn(_emitter, offset, noNullCheck, methodToken); }
            public override void Leave(int offset, int address) { _parent.Leave(_emitter, offset, address); }
            public override void LocAlloc(int offset) { _parent.LocAlloc(_emitter, offset); }
            public override void MkRefAny(int offset, uint token) { _parent.MkRefAny(_emitter, offset, token); }
            public override void Mul(int offset) { _parent.Mul(_emitter, offset); }
            public override void MulOvf(int offset) { _parent.MulOvf(_emitter, offset); }
            public override void MulOvfUn(int offset) { _parent.MulOvfUn(_emitter, offset); }
            public override void Neg(int offset) { _parent.Neg(_emitter, offset); }
            public override void NewArr(int offset, uint typeToken) { _parent.NewArr(_emitter, offset, typeToken); }
            public override void NewObj(int offset, uint constructorToken) { _parent.NewObj(_emitter, offset, constructorToken); }
            public override void Nop(int offset) { _parent.Nop(_emitter, offset); }
            public override void Not(int offset) { _parent.Not(_emitter, offset); }
            public override void Or(int offset) { _parent.Or(_emitter, offset); }
            public override void Pop(int offset) { _parent.Pop(_emitter, offset); }
            public override void RefAnyType(int offset) { _parent.RefAnyType(_emitter, offset); }
            public override void RefAnyVal(int offset, uint token) { _parent.RefAnyVal(_emitter, offset, token); }
            public override void Rem(int offset) { _parent.Rem(_emitter, offset); }
            public override void RemUn(int offset) { _parent.RemUn(_emitter, offset); }
            public override void Ret(int offset) { _parent.Ret(_emitter, offset); }
            public override void Rethrow(int offset) { _parent.Rethrow(_emitter, offset); }
            public override void Shl(int offset) { _parent.Shl(_emitter, offset); }
            public override void Shr(int offset) { _parent.Shr(_emitter, offset); }
            public override void ShrUn(int offset) { _parent.ShrUn(_emitter, offset); }
            public override void SizeOf(int offset, uint typeToken) { _parent.SizeOf(_emitter, offset, typeToken); }
            public override void StArg(int offset, int index) { _parent.StArg(_emitter, offset, index); }
            public override void StLoc(int offset, int index) { _parent.StLoc(_emitter, offset, index); }
            public override void StElem(int offset, bool noNullCheck, bool noTypeCheck, bool noBoundCheck, uint typeToken) { _parent.StElem(_emitter, offset, noNullCheck, noTypeCheck, noBoundCheck, typeToken); }
            public override void StElemI(int offset, bool noNullCheck, bool noBoundCheck) { _parent.StElemI(_emitter, offset, noNullCheck, noBoundCheck); }
            public override void StElemI1(int offset, bool noNullCheck, bool noBoundCheck) { _parent.StElemI1(_emitter, offset, noNullCheck, noBoundCheck); }
            public override void StElemI2(int offset, bool noNullCheck, bool noBoundCheck) { _parent.StElemI2(_emitter, offset, noNullCheck, noBoundCheck); }
            public override void StElemI4(int offset, bool noNullCheck, bool noBoundCheck) { _parent.StElemI4(_emitter, offset, noNullCheck, noBoundCheck); }
            public override void StElemI8(int offset, bool noNullCheck, bool noBoundCheck) { _parent.StElemI8(_emitter, offset, noNullCheck, noBoundCheck); }
            public override void StElemR4(int offset, bool noNullCheck, bool noBoundCheck) { _parent.StElemR4(_emitter, offset, noNullCheck, noBoundCheck); }
            public override void StElemR8(int offset, bool noNullCheck, bool noBoundCheck) { _parent.StElemR8(_emitter, offset, noNullCheck, noBoundCheck); }
            public override void StElemRef(int offset, bool noNullCheck, bool noBoundCheck) { _parent.StElemRef(_emitter, offset, noNullCheck, noBoundCheck); }
            public override void StFld(int offset, bool noNullCheck, bool volatilePrefix, int alignment, uint fieldToken) { _parent.StFld(_emitter, offset, noNullCheck, volatilePrefix, alignment, fieldToken); }
            public override void StIndI(int offset, bool volatilePrefix, int alignment) { _parent.StIndI(_emitter, offset, volatilePrefix, alignment); }
            public override void StIndI1(int offset, bool volatilePrefix) { _parent.StIndI1(_emitter, offset, volatilePrefix); }
            public override void StIndI2(int offset, bool volatilePrefix, int alignment) { _parent.StIndI2(_emitter, offset, volatilePrefix, alignment); }
            public override void StIndI4(int offset, bool volatilePrefix, int alignment) { _parent.StIndI4(_emitter, offset, volatilePrefix, alignment); }
            public override void StIndI8(int offset, bool volatilePrefix, int alignment) { _parent.StIndI8(_emitter, offset, volatilePrefix, alignment); }
            public override void StIndR4(int offset, bool volatilePrefix, int alignment) { _parent.StIndR4(_emitter, offset, volatilePrefix, alignment); }
            public override void StIndR8(int offset, bool volatilePrefix, int alignment) { _parent.StIndR8(_emitter, offset, volatilePrefix, alignment); }
            public override void StIndRef(int offset, bool volatilePrefix, int alignment) { _parent.StIndRef(_emitter, offset, volatilePrefix, alignment); }
            public override void StObj(int offset, bool volatilePrefix, int alignment, uint typeToken) { _parent.StObj(_emitter, offset, volatilePrefix, alignment, typeToken); }
            public override void StSFld(int offset, bool volatilePrefix, uint fieldToken) { _parent.StSFld(_emitter, offset, volatilePrefix, fieldToken); }
            public override void Sub(int offset) { _parent.Sub(_emitter, offset); }
            public override void SubOvf(int offset) { _parent.SubOvf(_emitter, offset); }
            public override void SubOvfUn(int offset) { _parent.SubOvfUn(_emitter, offset); }
            public override void Throw(int offset) { _parent.Throw(_emitter, offset); }
            public override void Unbox(int offset, bool noTypeCheck, uint typeToken) { _parent.Unbox(_emitter, offset, noTypeCheck, typeToken); }
            public override void UnboxAny(int offset, uint typeToken) { _parent.UnboxAny(_emitter, offset, typeToken); }
            public override void Xor(int offset) { _parent.Xor(_emitter, offset); }
            public override void Switch(int offset, int[] address) { _parent.Switch(_emitter, offset, address); }
        }
        class Emitter : Runic.CIL.Emitter
        {
            Patcher _parent;
            System.IO.MemoryStream _memoryStream;
            public Emitter(Patcher patcher, System.IO.MemoryStream memoryStream) { _parent = patcher; _memoryStream = memoryStream; }
            Dictionary<int, Emitter.Label> _labels = new Dictionary<int, Emitter.Label>();
            public Emitter.Label GetLabel(int offset)
            {
                Emitter.Label label;
                if (!_labels.TryGetValue(offset, out label))
                {
                    label = DeclareLabel();
                    _labels.Add(offset, label);
                }
                return label;
            }
            public override int Position { get { return (int)_memoryStream.Position; } }
            public override void Emit(byte b) { _memoryStream.WriteByte(b); }
        }
        public byte[] Patch(byte[] bytecode, int offset, int end)
        {
            using (System.IO.MemoryStream memoryStream = new System.IO.MemoryStream())
            {
                Emitter emitter = new Emitter(this, memoryStream);
                Disassembler disassembler = new Disassembler(this, emitter);
                disassembler.Disassemble(bytecode, offset, end);
                emitter.Flush();
                return memoryStream.ToArray();
            }
        }
    }
}
