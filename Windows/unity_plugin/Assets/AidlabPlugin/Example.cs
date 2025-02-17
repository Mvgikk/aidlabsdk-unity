using UnityEngine;
using UnityEngine.UI;

namespace Test.Example
{
    public class Example : MonoBehaviour
    {

        private void Start()
        {
            Aidlab.AidlabSDK.init();
            // Aidlab.AidlabSDK.aidlabDelegate.temperature.Subscribe(ReceiveTemperature);
            // Aidlab.AidlabSDK.aidlabDelegate.wearState.Subscribe(ReceiveWearState);
            Aidlab.AidlabSDK.aidlabDelegate.respiration.Subscribe(() => { Debug.Log(Aidlab.AidlabSDK.aidlabDelegate.respiration.value); });
        }

        private void ReceiveTemperature()
        {
            Debug.Log("Temperature " + Aidlab.AidlabSDK.aidlabDelegate.temperature.value + " [*C]");
        }

        private void ReceiveWearState()
        {
            Debug.Log("WearState " + Aidlab.AidlabSDK.aidlabDelegate.wearState.value);
        }
    }
}
