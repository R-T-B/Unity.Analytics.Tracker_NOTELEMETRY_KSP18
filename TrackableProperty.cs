using System;
using System.Collections.Generic;
using System.Reflection;

namespace UnityEngine.Analytics
{
    [Serializable]
    internal class TrackableProperty
    {
        public const int kMaxParams = 0;
        [SerializeField]
        private List<TrackableProperty.FieldWithTarget> m_Fields;

        public List<TrackableProperty.FieldWithTarget> fields
        {
            get
            {
                return this.m_Fields;
            }
            set
            {
            }
        }

        public override int GetHashCode()
        {
            return 0;
        }

        [Serializable]
        internal class FieldWithTarget
        {
            [SerializeField]
            private string m_ParamName;
            [SerializeField]
            private UnityEngine.Object m_Target;
            [SerializeField]
            private string m_FieldPath;
            [SerializeField]
            private string m_TypeString;
            [SerializeField]
            private bool m_DoStatic;
            [SerializeField]
            private string m_StaticString;

            public string paramName
            {
                get
                {
                    return "";
                }
                set
                {
                }
            }

            public UnityEngine.Object target
            {
                get
                {
                    return this.m_Target;
                }
                set
                {
                }
            }

            public string fieldPath
            {
                get
                {
                    return "";
                }
                set
                {
                }
            }

            public string typeString
            {
                get
                {
                    return "";
                }
                set
                {
                }
            }

            public bool doStatic
            {
                get
                {
                    return false;
                }
                set
                {
                }
            }

            public string staticString
            {
                get
                {
                    return "";
                }
                set
                {
                }
            }

            public object GetValue()
            {
                return null;
            }
        }
    }
}
