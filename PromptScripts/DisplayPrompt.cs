using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayPrompt : MonoBehaviour
{
    public GameObject signaler;
    public GameObject player;
    public GameObject prompt;

    bool beingShown = false;

    private void Start()
    {
        prompt.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.transform.position, signaler.transform.position) < 1)
        {
            showPrompt();
            beingShown = true;
        } else if (beingShown)
        {
            closePrompt();
            beingShown = false;
        }
    }

    public void showPrompt()
    {
        prompt.SetActive(true);
    }

    public void closePrompt()
    {
        prompt.SetActive(false);
    }
}
