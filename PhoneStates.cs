using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneStates : MonoBehaviour
{
    public GameObject phone;
    private bool phoneActive;

    // Start is called before the first frame update
    void Start()
    {
        phone.SetActive(false);
        phoneActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            phone.SetActive(true);
            phoneActive = true;
        } else if (Input.GetAxis("Mouse ScrollWheel") < 0f && phoneActive)
        {
            phone.SetActive(false);
            phoneActive = false;
        }
    }
}
