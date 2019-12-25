using UnityEngine;
using System.Collections;

public class CameraRotation : MonoBehaviour
{

    public float speedH = 2.0f;
    public float speedV = 2.0f;

    public float viewRange = 30f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;

    void Update()
    {
        yaw += speedH * Input.GetAxis("Mouse X");
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);

        //gameObject.transform.localEulerAngles = new Vector3(ClampAngle(gameObject.transform.localEulerAngles.x, -viewRange, viewRange), 0, 0);
        gameObject.transform.localEulerAngles = new Vector3(gameObject.transform.localEulerAngles.x, ClampAngle(gameObject.transform.localEulerAngles.y, -viewRange, viewRange), 0);

        /** Normalize angles to a range from -180 to 180 an then clamp the angle
          * with min and max.
          */
        float ClampAngle(float angle, float min, float max)
        {

            angle = NormalizeAngle(angle);
            if (angle > 180)
            {
                angle -= 360;
            }
            else if (angle < -180)
            {
                angle += 360;
            }

            min = NormalizeAngle(min);
            if (min > 180)
            {
                min -= 360;
            }
            else if (min < -180)
            {
                min += 360;
            }

            max = NormalizeAngle(max);
            if (max > 180)
            {
                max -= 360;
            }
            else if (max < -180)
            {
                max += 360;
            }

            // Aim is, convert angles to -180 until 180.
            return Mathf.Clamp(angle, min, max);
        }

        /** If angles over 360 or under 360 degree, then normalize them.
         */
        float NormalizeAngle(float angle)
        {
            while (angle > 360)
                angle -= 360;
            while (angle < 0)
                angle += 360;
            return angle;
        }
    }
}
