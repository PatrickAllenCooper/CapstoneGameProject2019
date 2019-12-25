using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneFollower : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject phone;

    public bool phoneState = false;

    private void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        phone.transform.position = mainCamera.transform.position;
        phone.transform.position = phone.transform.position + new Vector3(0, -0.5f, 5.0f);

        if (Input.GetKeyDown("p"))
        {
            phoneState = !phoneState;
            phone.SetActive(phoneState);
        }
    }

}
