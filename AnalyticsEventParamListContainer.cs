using System;
using System.Collections.Generic;

namespace UnityEngine.Analytics
{
    [Serializable]
    public class AnalyticsEventParamListContainer
    {
        [SerializeField]
        private List<AnalyticsEventParam> m_Parameters = new List<AnalyticsEventParam>();

        public List<AnalyticsEventParam> parameters
        {
            get
            {
                return this.m_Parameters;
            }
            set
            {
                this.m_Parameters = value;
            }
        }
    }
}
