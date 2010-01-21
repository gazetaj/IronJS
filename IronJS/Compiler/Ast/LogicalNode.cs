﻿using System.Linq.Expressions;
using Et = System.Linq.Expressions.Expression;

namespace IronJS.Compiler.Ast
{
    class LogicalNode : Node
    {
        public readonly Node Left;
        public readonly Node Right;
        public readonly ExpressionType Op;

        public LogicalNode(Node left, Node right, ExpressionType op)
            : base(NodeType.Logical)
        {
            Left = left;
            Right = right;
            Op = op;
        }

        public override Expression Walk(EtGenerator etgen)
        {
            var tmp = Et.Parameter(typeof(object), "#tmp");

            return Et.Block(
                new[] { tmp },

                Et.Assign(
                    tmp, 
                    Left.Walk(etgen)
                ),

                Et.Condition(
                    Et.Dynamic(
                        etgen.Context.CreateConvertBinder(typeof(bool)),
                        typeof(bool),
                        tmp
                    ),

                    Op == ExpressionType.AndAlso
                           ? Right.Walk(etgen) // &&
                           : tmp,              // ||

                    Op == ExpressionType.AndAlso
                           ? tmp               // &&
                           : Right.Walk(etgen) // ||
                )
            );
        }
    }
}
