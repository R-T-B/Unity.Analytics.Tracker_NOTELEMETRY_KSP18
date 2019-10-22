using System;

namespace UnityEngine.Analytics
{
    [Serializable]
    public class TrackableField : TrackablePropertyBase
    {
        [SerializeField]
        private string[] m_ValidTypeNames;
        [SerializeField]
        private string m_Type;
        [SerializeField]
        private string m_EnumType;

        public TrackableField(params System.Type[] validTypes)
        {
            if (validTypes == null || validTypes.Length == 0)
                return;
            this.m_ValidTypeNames = new string[validTypes.Length];
            for (int index = 0; index < validTypes.Length; ++index)
                this.m_ValidTypeNames[index] = validTypes[index].ToString();
        }

        public object GetValue()
        {
            if (this.m_Target == (UnityEngine.Object)null || string.IsNullOrEmpty(this.m_Path))
                return (object)null;
            object target = (object)this.m_Target;
            string path = this.m_Path;
            char[] chArray = new char[1] { '.' };
            foreach (string name in path.Split(chArray))
            {
                try
                {
                    target = target.GetType().GetProperty(name).GetValue(target, (object[])null);
                }
                catch
                {
                    target = target.GetType().GetField(name).GetValue(target);
                }
            }
            return target;
        }
    }
}
