﻿/* ****************************************************************************
 *
 * Copyright (c) Fredrik Holmström
 *
 * This source code is subject to terms and conditions of the Microsoft Public License. A 
 * copy of the license can be found in the License.html file at the root of this distribution. If 
 * you cannot locate the  Microsoft Public License, please send an email to 
 * dlr@microsoft.com. By using this source code in any fashion, you are agreeing to be bound 
 * by the terms of the Microsoft Public License.
 *
 * You must not remove this notice, or any other, from this software.
 *
 * ***************************************************************************/

using System;
using System.Collections.Generic;
using System.Reflection;
using IronJS.Compiler.Ast;
using IronJS.Extensions;

namespace IronJS.Compiler.Optimizer
{
    public class IjsFuncInfo
    {
        public bool IsLambda { get; set; }
        public bool IsCompiled { get { return CompiledMethod != null; } }
        public bool UsesArgumentsObject { get; set; }
        public bool HasBranches { get; set; }
        public bool IsSimple { get { return !HasBranches; } }
        public Type ExprType { get { return IjsTypes.Object; } }
        public Type ClosureType { get; set; }
        public FuncNode AstNode { get; set; }
        public MethodInfo CompiledMethod { get; set; }
        public HashSet<Type> Returns { get; protected set; }
        public HashSet<IjsVarInfo> ClosesOver { get; protected set; }

        public Type ReturnType
        {
            get
            {
                if (IsSimple)
                    return Returns.EvalType();

                return IjsTypes.Dynamic;
            }
        }

        public IjsFuncInfo(FuncNode node)
        {
            AstNode = node;
            IsLambda = false;
            CompiledMethod = null;
            UsesArgumentsObject = false;
            Returns = new HashSet<Type>();
            ClosesOver = new HashSet<IjsVarInfo>();
        }
    }
}
