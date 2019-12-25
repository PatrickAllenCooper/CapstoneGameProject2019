using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StreetToBedroom : MonoBehaviour
{
    public GameObject signaler;
    public GameObject player;

    public GameObject stateOne;
    public GameObject stateTwo;

    public GameObject invisibleWallsOne;
    public GameObject invisibleWallsTwo;

    // Update is called once per frame
    private void Start()
    {
        stateOne.SetActive(true);
        invisibleWallsOne.SetActive(true);
        stateTwo.SetActive(false);
        invisibleWallsTwo.SetActive(false);
    }


    void Update()
    {
        if (Vector3.Distance(player.transform.position, signaler.transform.position) < 1 && Input.GetKeyDown("e"))
        {
            stateOne.SetActive(false);
            invisibleWallsOne.SetActive(false);
            stateTwo.SetActive(true);
            invisibleWallsTwo.SetActive(true);


        }
    }
}
