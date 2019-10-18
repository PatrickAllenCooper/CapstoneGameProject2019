using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldTransformer : MonoBehaviour
{
    public Vector3 axis = Vector3.up;
    public Vector3 floorTranslationStageOne;
    public float offsetSpencer = 1f;
    public float offsetRiker = 1;

    // operates as a maximum
    public float timeCount = 30.0f;

    /**
     * Rotation points ought to be loaded and disabled based upon the stage currently being used.
    **/
    void Update()
    {
        if (Vector3.Distance(GameObject.Find("Player").transform.position, GameObject.Find("SensorFor1-2").transform.position) < 0.5)
        {
            Quaternion newRotation = Quaternion.AngleAxis(90, GameObject.Find("RotatePoint").transform.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, newRotation, timeCount * Time.deltaTime * 10);
            if (Vector3.Distance(GameObject.Find("Player").transform.position, GameObject.Find("Spencer").transform.position) > 4 ||
                Vector3.Distance(GameObject.Find("Player").transform.position, GameObject.Find("Ryker").transform.position) > 4)
            {
                TransformCompanionsRight();
            }
        }
        else if (Vector3.Distance(GameObject.Find("Player").transform.position, GameObject.Find("SensorFor2-1").transform.position) < 0.5)
        {
            Quaternion newRotation = Quaternion.AngleAxis(0, GameObject.Find("RotatePoint").transform.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, newRotation, timeCount * Time.deltaTime * 10);
            if (Vector3.Distance(GameObject.Find("Player").transform.position, GameObject.Find("Spencer").transform.position) > 4 ||
                Vector3.Distance(GameObject.Find("Player").transform.position, GameObject.Find("Ryker").transform.position) > 4)
            {
                TransformCompanionsLeft();
            }
        }
    }

    private void SlideFloor()
    {
        GameObject.Find("Floor").transform.Translate(floorTranslationStageOne, Space.World);
    }

    public void TransformCompanionsRight()
    {
        Vector3 playerPositionOne = GameObject.Find("Player").transform.position;
        playerPositionOne.x -= offsetSpencer;
        GameObject.Find("Spencer").transform.position = playerPositionOne;

        Vector3 playerPositionTwo = GameObject.Find("Player").transform.position;
        playerPositionTwo.x -= offsetRiker;
        GameObject.Find("Ryker").transform.position = playerPositionTwo;
    }


    public void TransformCompanionsLeft()
    {
        Vector3 playerPositionOne = GameObject.Find("Player").transform.position;
        playerPositionOne.x += offsetSpencer;
        GameObject.Find("Spencer").transform.position = playerPositionOne;

        Vector3 playerPositionTwo = GameObject.Find("Player").transform.position;
        playerPositionTwo.x += offsetRiker;
        GameObject.Find("Ryker").transform.position = playerPositionTwo;
    }


    //TODO Make Backwards Transform
}