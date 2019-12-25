using UnityEngine;
using System.Collections;

public class CameraTransition : MonoBehaviour
{
    public Camera mainCamera;
    public Camera bookstoreCamera;
    public GameObject gameUI;
    public GameObject prompt;

    private float targetAmountX = -43.5f;
    private float targetAmountY = -10.8f;

    public float allowedTargetAcc = 30f;

    public GameObject player;
    public GameObject signaler;

    private bool bookStoreCameraOn = false;

    private void Update()
    {
        if (Input.GetMouseButtonDown(1) && Vector3.Distance(player.transform.position, signaler.transform.position) < 1)
        {
            prompt.SetActive(false);
            gameUI.SetActive(false);
            ShowBookstoreView();
            bookStoreCameraOn = true;
        }
        
        if (UnityEditor.TransformUtils.GetInspectorRotation(bookstoreCamera.transform).y > targetAmountY - allowedTargetAcc &&
            UnityEditor.TransformUtils.GetInspectorRotation(bookstoreCamera.transform).y < targetAmountY + allowedTargetAcc &&
            UnityEditor.TransformUtils.GetInspectorRotation(bookstoreCamera.transform).x > targetAmountX - allowedTargetAcc &&
            UnityEditor.TransformUtils.GetInspectorRotation(bookstoreCamera.transform).x < targetAmountY + allowedTargetAcc &&
            bookStoreCameraOn)
        {
            gameUI.SetActive(true);
            ShowMainCameraView();
            bookStoreCameraOn = false;
        }
    }

    public void ShowBookstoreView()
    {
        mainCamera.enabled = false;
        bookstoreCamera.enabled = true;
    }

    public void ShowMainCameraView()
    {
        mainCamera.enabled = true;
        bookstoreCamera.enabled = false;
    }
}