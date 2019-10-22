using System;
using System.Collections.Generic;

namespace UnityEngine.Analytics
{
    [Serializable]
    public class StandardEventPayload
    {
        private static Dictionary<string, object> m_EventData = new Dictionary<string, object>();
        [SerializeField]
        private bool m_IsEventExpanded = true;
        [SerializeField]
        private string m_StandardEventType = "CustomEvent";
        [SerializeField]
        private string m_Name = string.Empty;
        public System.Type standardEventType;
        [SerializeField]
        private AnalyticsEventParamListContainer m_Parameters;

        public StandardEventPayload()
        {
            this.m_Parameters = new AnalyticsEventParamListContainer();
        }

        public AnalyticsEventParamListContainer parameters
        {
            get
            {
                return this.m_Parameters;
            }
        }

        public string name
        {
            get
            {
                return this.m_Name;
            }
            set
            {
                this.m_Name = value;
            }
        }

        public virtual AnalyticsResult Send()
        {
            if (string.IsNullOrEmpty(this.name))
                throw new Exception("Analtyics Event Tracker failed to send the CustomEvent. The event Name field cannot be empty.");
            if (!this.IsCustomDataValid())
                throw new Exception("Analytics event tracker failed to send. The event data is not valid. Parameter names cannot be null or empty.");
            if (!this.IsRequiredDataValid())
                throw new Exception("Analytics event tracker failed to send. The event data is not valid. Please check the values of required parameters.");
            return AnalyticsEvent.Custom(this.name.Trim(), this.GetParameters());
        }

        private IDictionary<string, object> GetParameters()
        {
            StandardEventPayload.m_EventData.Clear();
            List<AnalyticsEventParam> parameters = this.parameters.parameters;
            for (int index = 0; index < parameters.Count; ++index)
            {
                if (parameters[index] != null && parameters[index].valueProperty.IsValid())
                    StandardEventPayload.m_EventData.Add(parameters[index].name, parameters[index].value);
            }
            return (IDictionary<string, object>)StandardEventPayload.m_EventData;
        }

        private bool IsCustomDataValid()
        {
            List<AnalyticsEventParam> parameters = this.parameters.parameters;
            for (int index = 0; index < parameters.Count; ++index)
            {
                if (parameters[index] != null && string.IsNullOrEmpty(parameters[index].name) && parameters[index].valueProperty.IsValid())
                    return false;
            }
            return true;
        }

        private bool IsRequiredDataValid()
        {
            List<AnalyticsEventParam> parameters = this.parameters.parameters;
            Dictionary<string, List<bool>> dictionary = new Dictionary<string, List<bool>>();
            for (int index = 0; index < parameters.Count; ++index)
            {
                if (parameters[index] != null && parameters[index].requirementType == AnalyticsEventParam.RequirementType.Required)
                {
                    if (string.IsNullOrEmpty(parameters[index].groupID))
                    {
                        if (!dictionary.ContainsKey("none"))
                            dictionary.Add("none", new List<bool>());
                        dictionary["none"].Add(parameters[index].valueProperty.IsValid());
                    }
                    else
                    {
                        if (!dictionary.ContainsKey(parameters[index].groupID))
                            dictionary.Add(parameters[index].groupID, new List<bool>());
                        dictionary[parameters[index].groupID].Add(parameters[index].valueProperty.IsValid());
                    }
                }
            }
            foreach (string key in dictionary.Keys)
            {
                if (key != null && key == "none")
                {
                    if (dictionary[key].Contains(false))
                        return false;
                }
                else if (!dictionary[key].Contains(true))
                    return false;
            }
            return true;
        }
    }
}
