using System;

namespace UnityEngine.Analytics
{
    [Serializable]
    public abstract class TrackablePropertyBase
    {
        [SerializeField]
        protected UnityEngine.Object m_Target;
        [SerializeField]
        protected string m_Path;
    }
}
