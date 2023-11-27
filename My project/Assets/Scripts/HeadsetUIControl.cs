using UnityEngine;
using UnityEngine.XR;

public class HeadsetUIControl : MonoBehaviour
{
    public GameObject uiObject;

    private void Start()
    {
        // UI를 비활성화합니다.
        uiObject.SetActive(false);
    }

    private void Update()
    {
        // 현재 XR 디바이스가 활성화되었는지 여부를 확인합니다.
        bool isDeviceActive = XRSettings.isDeviceActive;

        // XR 디바이스가 비활성화되었을 때 UI를 활성화합니다.
        if (!isDeviceActive)
        {
            uiObject.SetActive(true);
        }
        // XR 디바이스가 활성화되었을 때 UI를 비활성화합니다.
        else
        {
            uiObject.SetActive(false);
        }
    }
}
