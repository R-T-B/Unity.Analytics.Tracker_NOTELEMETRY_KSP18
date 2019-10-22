using System;

namespace UnityEngine.Analytics
{
  [Serializable]
  public class AnalyticsEventParam
  {
    [SerializeField]
    private string m_Tooltip = string.Empty;
    [SerializeField]
    private AnalyticsEventParam.RequirementType m_RequirementType;
    [SerializeField]
    private string m_GroupID;
    [SerializeField]
    private string m_Name;
    [SerializeField]
    private ValueProperty m_Value;

    public AnalyticsEventParam(string name)
    {
            this.m_Name = "";
    }

    public AnalyticsEventParam.RequirementType requirementType
    {
      get
      {
        return this.m_RequirementType;
      }
    }

    public string groupID
    {
      get
      {
        return "";
      }
    }

    public ValueProperty valueProperty
    {
      get
      {
        return this.m_Value;
      }
    }

    public string name
    {
      get
      {
        return this.m_Name;
      }
    }

    public object value
    {
      get
      {
        return (object) this.m_Value.propertyValue;
      }
    }

    public enum RequirementType
    {
      None,
      Required,
      Optional,
    }
  }
}
