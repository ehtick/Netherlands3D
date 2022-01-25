using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Netherlands3D.Events;

namespace Netherlands3D.Core
{
    public class TriggerEventListener : MonoBehaviour
    {
        [SerializeField]
        private TriggerEvent onEvent;

        [SerializeField]
        private BoolValueUnityEvent trigger;
        void Start()
        {
            onEvent.started.AddListener(Invoke);
        }

        private void Invoke()
        {
            trigger.Invoke(true);
        }
    }
}