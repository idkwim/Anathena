﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anathema
{
    public enum ValueConstraintsEnum
    {
        Invalid,
        Equal,
        NotEqual,
        Changed,
        Unchanged,
        Increased,
        Decreased,
        IncreasedByX,
        DecreasedByX,
        GreaterThan,
        LessThan,
    }

    public class ScanConstraintItem
    {
        public ValueConstraintsEnum ValueConstraints { get; set; }
        public Type ElementType { get; set; }
        public dynamic Value { get; set; }

        public ScanConstraintItem()
        {
            ValueConstraints = ValueConstraintsEnum.Changed;
            ElementType = typeof(Int32);
            Value = null;
        }

        public ScanConstraintItem(ValueConstraintsEnum ValueConstraint, Type ValueType, dynamic Value = null)
        {
            this.ValueConstraints = ValueConstraint;
            this.ElementType = ValueType;
            this.Value = Value;
        }
    }
}
