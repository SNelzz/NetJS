﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetJS.Core {

    // See: https://www.ecma-international.org/ecma-262/8.0/index.html#sec-relational-operators

    public class LessThan : BinaryOperator {
        public LessThan() : base(10) { }

        public override Constant Evaluate(Constant lref, Constant rref, Agent agent) {
            var lval = References.GetValue(lref, agent);
            var rval = References.GetValue(rref, agent);

            var r = Compare.AbstractRelationalComparison(lval, rval, true, agent);
            return Boolean.Create(r == Compare.RelationalComparisonResult.Undefined ? false : r == Compare.RelationalComparisonResult.True);
        }

        public override string ToDebugString() {
            return "less than";
        }
    }

    public class LessThanEquals : BinaryOperator {
        public LessThanEquals() : base(10) { }

        public override Constant Evaluate(Constant lref, Constant rref, Agent agent) {
            var lval = References.GetValue(lref, agent);
            var rval = References.GetValue(rref, agent);

            var r = Compare.AbstractRelationalComparison(rval, lval, true, agent);
            return Boolean.Create(r == Compare.RelationalComparisonResult.Undefined ? false : r != Compare.RelationalComparisonResult.True);
        }

        public override string ToDebugString() {
            return "less than equals";
        }
    }

    public class GreaterThan : BinaryOperator {
        public GreaterThan() : base(10) { }

        public override Constant Evaluate(Constant lref, Constant rref, Agent agent) {
            var lval = References.GetValue(lref, agent);
            var rval = References.GetValue(rref, agent);

            var r = Compare.AbstractRelationalComparison(rval, lval, true, agent);
            return Boolean.Create(r == Compare.RelationalComparisonResult.Undefined ? false : r == Compare.RelationalComparisonResult.True);
        }

        public override string ToDebugString() {
            return "greater than";
        }
    }

    public class GreaterThanEquals : BinaryOperator {
        public GreaterThanEquals() : base(10) { }

        public override Constant Evaluate(Constant lref, Constant rref, Agent agent) {
            var lval = References.GetValue(lref, agent);
            var rval = References.GetValue(rref, agent);

            var r = Compare.AbstractRelationalComparison(lval, rval, true, agent);
            return Boolean.Create(r == Compare.RelationalComparisonResult.Undefined ? false : r != Compare.RelationalComparisonResult.True);
        }

        public override string ToDebugString() {
            return "greater than equals";
        }
    }

    // See: https://www.ecma-international.org/ecma-262/8.0/index.html#sec-equality-operators

    public class Equals : BinaryOperator {
        public Equals() : base(9) { }

        public override Constant Evaluate(Constant lref, Constant rref, Agent agent) {
            var lval = References.GetValue(lref, agent);
            var rval = References.GetValue(rref, agent);

            return Boolean.Create(Compare.AbstractEqualityComparison(rval, lval, agent));
        }

        public override string ToDebugString() {
            return "equals";
        }
    }

    public class NotEquals : BinaryOperator {
        public NotEquals() : base(9) { }

        public override Constant Evaluate(Constant lref, Constant rref, Agent agent) {
            var lval = References.GetValue(lref, agent);
            var rval = References.GetValue(rref, agent);

            return Boolean.Create(!Compare.AbstractEqualityComparison(rval, lval, agent));
        }

        public override string ToDebugString() {
            return "not equals";
        }
    }

    public class StrictEquals : BinaryOperator {
        public StrictEquals() : base(9) { }

        public override Constant Evaluate(Constant lref, Constant rref, Agent agent) {
            var lval = References.GetValue(lref, agent);
            var rval = References.GetValue(rref, agent);

            return Boolean.Create(Compare.StrictEqualityComparison(rval, lval));
        }

        public override string ToDebugString() {
            return "strict equals";
        }
    }

    public class StrictNotEquals : BinaryOperator {
        public StrictNotEquals() : base(9) { }

        public override Constant Evaluate(Constant lref, Constant rref, Agent agent) {
            var lval = References.GetValue(lref, agent);
            var rval = References.GetValue(rref, agent);

            return Boolean.Create(!Compare.StrictEqualityComparison(rval, lval));
        }

        public override string ToDebugString() {
            return "strict not equals";
        }
    }
}