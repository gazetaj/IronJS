﻿using IronJS.Runtime;
using Et = System.Linq.Expressions.Expression;

namespace IronJS.Compiler.Ast
{
    class TypeOfNode : Node
    {
        public readonly Node Target;

        public TypeOfNode(Node target)
            : base(NodeType.TypeOf)
        {
            Target = target;
        }
        
        public override System.Linq.Expressions.Expression Walk(EtGenerator etgen)
        {
            return Et.Call(
                typeof(BuiltIns).GetMethod("TypeOf"),
                Target.Walk(etgen)
            );
        }
    }
}
