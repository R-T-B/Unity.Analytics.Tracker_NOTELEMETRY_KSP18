using System;
using System.Collections.Generic;

namespace UnityEngine.Analytics
{
    [AddComponentMenu("")]
    [Obsolete("Analytics Tracker is deprecated. Use Analytics Event Tracker instead!")]
    public class AnalyticsTracker : MonoBehaviour
    {
        private Dictionary<string, object> m_Dict = new Dictionary<string, object>();
        [SerializeField]
        private TrackableProperty m_TrackableProperty = new TrackableProperty();
        [SerializeField]
        private string m_EventName;
        private int m_PrevDictHash;
        [SerializeField]
        internal AnalyticsTracker.Trigger m_Trigger;

        public string eventName
        {
            get
            {
                return "";
            }
            set
            {
            }
        }

        internal TrackableProperty TP
        {
            get
            {
                return this.m_TrackableProperty;
            }
            set
            {
            }
        }

        private void Awake()
        {
            return;
        }

        private void Start()
        {
            return;
        }

        private void OnEnable()
        {
            return;
        }

        private void OnDisable()
        {
            return;
        }

        private void OnApplicationPause()
        {
            return;
        }

        private void OnDestroy()
        {
            return;
        }

        public void TriggerEvent()
        {
            return;
        }

        private void SendEvent()
        {
            return;
        }

        private void BuildParameters()
        {
            return;
        }

        [Serializable]
        internal enum Trigger
        {
            External,
            Awake,
            Start,
            OnEnable,
            OnDisable,
            OnApplicationPause,
            OnDestroy,
        }
    }
}
