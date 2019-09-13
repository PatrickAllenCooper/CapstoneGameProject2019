using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public float speedOfUITransform = 2;
    public Transform cam;
    public float smoothTime = 0.2f;
    private Vector3 _velocity = Vector3.zero;

    private void Awake()
    {
        Vector3 startingPosition = new Vector3(0, (float)-5.8);
        gameObject.transform.position = startingPosition;
    }

    // Updates the position of UI 
    private void Update()
    {
        //gameObject.transform.position = cam.transform.position;
        // Handles Vertical Movement
        Vector3 pos = gameObject.transform.position;
        pos.y += Input.mouseScrollDelta.y * speedOfUITransform;
        if (pos.y <= -0.2 && pos.y >= -5.9)
        {
            ModifyUIPos(pos);
        }
        else if (pos.y > -0.2)
        {
            if (pos.y <= 0)
            {
                ModifyUIPos(pos);
            }
        }
        else if (pos.y < -5.9)
        {
            if (pos.y >= 0)
            {
                ModifyUIPos(pos);
            }
        }
    }
    
    private void ModifyUIPos(Vector3 pos) {

        Vector3.SmoothDamp(gameObject.transform.position, pos, ref _velocity, smoothTime);
        gameObject.transform.position = pos;
    }
}
