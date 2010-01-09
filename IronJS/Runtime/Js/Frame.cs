﻿using System.Collections.Generic;
using System.Dynamic;
using System.Reflection;

namespace IronJS.Runtime.Js
{
    using Et = System.Linq.Expressions.Expression;
    using Meta = System.Dynamic.DynamicMetaObject;
    using System;

    public enum VarType { Global, Local }

    public class Frame
    {
        readonly Frame _parent;

        readonly Dictionary<object, object> _values =
             new Dictionary<object, object>();

        public Frame()
            : this(null)
        {

        }

        public Frame(Frame parent)
        {
            _parent = parent;
        }

        public object Arg(object key)
        {
            object value;

            if (_values.TryGetValue(key, out value))
                return value;

            return null;
        }

        public object Push(object key, object value, VarType type)
        {
            if (type == VarType.Local)
            {
                _values[key] = value;
            }
            else
            {
                if (_values.ContainsKey(key))
                {
                    _values[key] = value;
                }
                else
                {
                    if (_parent == null)
                    {
                        _values[key] = value;
                    }
                    else
                    {
                        return _parent.Push(key, value, VarType.Global);
                    }
                }
            }

            return value;
        }

        public object Pull(object key)
        {
            object value; 

            if (_values.TryGetValue(key, out value))
                return value;

            if (_parent != null)
                return _parent.Pull(key);

            return Js.Undefined.Instance;
        }

        public Frame Enter()
        {
            return new Frame(this);
        }

        #region Static

        #endregion
    }
}
