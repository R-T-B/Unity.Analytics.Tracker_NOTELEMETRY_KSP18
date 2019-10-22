using System.Collections;
using System.Diagnostics;

namespace UnityEngine.Analytics
{
    [AddComponentMenu("Analytics/Analytics Event Tracker")]
    public class AnalyticsEventTracker : MonoBehaviour
    {
        [SerializeField]
        public EventTrigger m_Trigger = new EventTrigger();
        [SerializeField]
        private StandardEventPayload m_EventPayload = new StandardEventPayload();

        public StandardEventPayload payload
        {
            get
            {
                return this.m_EventPayload;
            }
        }

        public void TriggerEvent()
        {
            int num = (int)this.SendEvent();
        }

        private AnalyticsResult SendEvent()
        {
            return AnalyticsResult.Ok;
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

        private void OnApplicationPause(bool paused)
        {
            return;
        }

        private void OnDestroy()
        {
            return;
        }

        [DebuggerHidden]
        private IEnumerator TimedTrigger()
        {
            return null;
        }
    }
}
