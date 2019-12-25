using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PhoneUIController : MonoBehaviour
{
    public GameObject homeScreen;
    public Button homeButton;

    public GameObject messenger;
    public Button messengerButton;

    public GameObject gallery;
    public Button galleryButton;

    private void Start()
    {
        homeScreen.SetActive(homeScreen);

        homeButton.onClick.AddListener(OpenHomeScreen);
        messengerButton.onClick.AddListener(OpenMessengerScreen);
        galleryButton.onClick.AddListener(OpenGalleryScreen);
    }

    void OpenHomeScreen()
    {
        messenger.SetActive(false);
        gallery.SetActive(false);
        homeScreen.SetActive(true);
    }

    void OpenMessengerScreen()
    {
        messenger.SetActive(true);
        gallery.SetActive(false);
        homeScreen.SetActive(false);
    }

    void OpenGalleryScreen()
    {
        messenger.SetActive(false);
        gallery.SetActive(true);
        homeScreen.SetActive(false);
    }
}
