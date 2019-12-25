using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformOverCharacter : MonoBehaviour
{
    public GameObject player;
    public Canvas canvas;
    public float displacement = 200f;

    // Update is called once per frame
    void Update()
    {
        Vector3 uiPos = worldToUISpace(canvas, player.transform.position);
        uiPos.y = uiPos.y + displacement;
        transform.position = uiPos;
    }

    public Vector3 worldToUISpace(Canvas parentCanvas, Vector3 worldPos)
    {
        // Convert the world for screen point so that it can be used with ScreenPointToLocalPointInRectangle function
        Vector3 screenPos = Camera.main.WorldToScreenPoint(worldPos);
        Vector2 movePos;

        // Convert the screenpoint to ui rectangle local point
        RectTransformUtility.ScreenPointToLocalPointInRectangle(parentCanvas.transform as RectTransform, screenPos, parentCanvas.worldCamera, out movePos);
        // Convert the local point to world point
        return parentCanvas.transform.TransformPoint(movePos);
    }
}
