﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetJS.Core.Javascript {
    public class Void : UnaryRightOperator {
        public Void() : base(14) { }

        public override Constant Execute(Constant right, Scope scope) {
            return right.Void(scope);
        }

        public override string ToDebugString() {
            return "void";
        }
    }
}
