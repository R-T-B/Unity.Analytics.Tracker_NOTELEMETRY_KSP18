using System;

namespace UnityEngine.Analytics
{
    [Serializable]
    public class TriggerRule
    {
        [SerializeField]
        private TrackableField m_Target;
        [SerializeField]
        private TriggerOperator m_Operator;
        [SerializeField]
        private ValueProperty m_Value;
        [SerializeField]
        private ValueProperty m_Value2;

        public bool Test()
        {
            return true;
        }

        public bool Test(out bool error, out string message)
        {
            error = false;
            message = "lolwut";
            return true;
        }

        private bool TestByObject(object currentValue)
        {
            return true;
        }

        private bool TestByEnum(string currentValue)
        {
            return true;
        }

        private bool TestByString(string currentValue)
        {
            return true;
        }

        private bool TestByBool(bool currentValue)
        {
            return true;
        }

        private bool TestByDouble(double currentValue)
        {
            return true;
        }

        private bool SafeEquals(double double1, double double2)
        {
            return true;
        }

        private double GetDouble(object value)
        {
            return 0.00f;
        }
    }
}
