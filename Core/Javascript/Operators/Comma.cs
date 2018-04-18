﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetJS.Core.Javascript {
    public class Comma : BinaryOperator {
        public Comma() : base(1) { }

        public override Constant Execute(Constant left, Constant right, Scope scope) {
            return left.Comma(right, scope);
        }

        public override void Uneval(StringBuilder builder, int depth) {
            Left.Uneval(builder, depth);
            builder.Append(", ");
            Right.Uneval(builder, depth);
        }

        public override string ToDebugString() {
            return "comma";
        }
    }
}