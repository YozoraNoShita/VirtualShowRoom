using UnityEngine;
using UnityEngine.XR;

public class HeadsetUIControl : MonoBehaviour
{
    public GameObject uiObject;

    private void Start()
    {
        // UI�� ��Ȱ��ȭ�մϴ�.
        uiObject.SetActive(false);
    }

    private void Update()
    {
        // ���� XR ����̽��� Ȱ��ȭ�Ǿ����� ���θ� Ȯ���մϴ�.
        bool isDeviceActive = XRSettings.isDeviceActive;

        // XR ����̽��� ��Ȱ��ȭ�Ǿ��� �� UI�� Ȱ��ȭ�մϴ�.
        if (!isDeviceActive)
        {
            uiObject.SetActive(true);
        }
        // XR ����̽��� Ȱ��ȭ�Ǿ��� �� UI�� ��Ȱ��ȭ�մϴ�.
        else
        {
            uiObject.SetActive(false);
        }
    }
}
