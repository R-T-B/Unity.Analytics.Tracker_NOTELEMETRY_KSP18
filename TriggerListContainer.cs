using System;
using System.Collections.Generic;

namespace UnityEngine.Analytics
{
    [Serializable]
    public class TriggerListContainer
    {
        [SerializeField]
        private List<TriggerRule> m_Rules = new List<TriggerRule>();

        internal List<TriggerRule> rules
        {
            get
            {
                return this.m_Rules;
            }
            set
            {
                this.m_Rules = value;
            }
        }
    }
}
