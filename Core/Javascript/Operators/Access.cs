﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetJS.Core.Javascript {
    public class Access : BinaryOperator {
        // If the variable is a key like obj.a (true) or a variable like obj[a] (false)
        public bool IsKey;

        public Access(bool isKey) : base(16) {
            IsKey = isKey;
        }

        public override Constant Execute(Constant left, Constant right, Scope scope) {
            return left.Access(right, scope);
        }

        public override Constant Execute(Scope scope, bool getValue = true) {
            var left = Left.Execute(scope, false);
            var right = Right.Execute(scope, !IsKey);

            var result = Execute(left, right, scope);
            return getValue ? result.GetValue(scope) : result;
        }

        public override string ToDebugString() {
            return "access";
        }
    }
}
