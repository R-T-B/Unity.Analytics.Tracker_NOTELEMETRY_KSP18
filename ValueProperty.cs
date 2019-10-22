using System;

namespace UnityEngine.Analytics
{
    [Serializable]
    public class ValueProperty
    {
        [SerializeField]
        private bool m_EnumTypeIsCustomizable = true;
        [SerializeField]
        private ValueProperty.PropertyType m_PropertyType = ValueProperty.PropertyType.Static;
        [SerializeField]
        private string m_Value = string.Empty;
        [SerializeField]
        private bool m_EditingCustomValue;
        [SerializeField]
        private int m_PopupIndex;
        [SerializeField]
        private string m_CustomValue;
        [SerializeField]
        private bool m_FixedType;
        [SerializeField]
        private string m_EnumType;
        [SerializeField]
        private bool m_CanDisable;
        [SerializeField]
        private string m_ValueType;
        [SerializeField]
        private TrackableField m_Target;

        public string valueType
        {
            get
            {
                return "";
            }
            set
            {
            }
        }

        public string propertyValue
        {
            get
            {
                return "";
            }
        }

        public TrackableField target
        {
            get
            {
                return this.m_Target;
            }
        }

        public bool IsValid()
        {
            return false;
        }

        public enum PropertyType
        {
            Disabled,
            Static,
            Dynamic,
        }
    }
}
