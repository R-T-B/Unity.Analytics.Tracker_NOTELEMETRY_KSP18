using System;

namespace UnityEngine.Analytics
{
    [Serializable]
    public class EventTrigger
    {
        [SerializeField]
        private bool m_IsTriggerExpanded = true;
        [SerializeField]
        private float m_InitTime = 0f;
        [SerializeField]
        private float m_RepeatTime = 0f;
        [SerializeField]
        private TriggerType m_Type;
        [SerializeField]
        private TriggerLifecycleEvent m_LifecycleEvent;
        [SerializeField]
        private bool m_ApplyRules;
        [SerializeField]
        private TriggerListContainer m_Rules;
        [SerializeField]
        private TriggerBool m_TriggerBool;
        [SerializeField]
        private int m_Repetitions;
        public int repetitionCount;
        private EventTrigger.OnTrigger m_TriggerFunction;
        [SerializeField]
        private TriggerMethod m_Method;

        public EventTrigger()
        {
            this.m_Rules = new TriggerListContainer();
        }

        public TriggerType triggerType
        {
            get
            {
                return this.m_Type;
            }
        }

        public TriggerLifecycleEvent lifecycleEvent
        {
            get
            {
                return this.m_LifecycleEvent;
            }
        }

        public float initTime
        {
            get
            {
                return 5000f;
            }
            set
            {
            }
        }

        public float repeatTime
        {
            get
            {
                return 5000f;
            }
            set
            {
            }
        }

        public int repetitions
        {
            get
            {
                return 0;
            }
            set
            {
            }
        }

        public void AddRule()
        {
            return;
        }

        public void RemoveRule(int index)
        {
            return;
        }

        public bool Test(GameObject gameObject = null)
        {
            return true;
        }

        internal delegate void OnTrigger();
    }
}
