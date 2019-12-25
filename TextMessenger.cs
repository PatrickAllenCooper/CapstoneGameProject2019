using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMessenger : MonoBehaviour
{

    private List<string> textMessages = new List<string>();
    public List<string> npcMessages = new List<string>();
    public List<Text> textDisplays = new List<Text>();
    public InputField textField;

    private int messageIndexUsed = 0;

    void Update()
    {
            if (Input.GetKeyDown("return"))
            {
                textDisplays[messageIndexUsed].text = textField.text.ToString();
                textField.text = "";
                messageIndexUsed++;
                if (npcMessages[messageIndexUsed] != "no message")
                {
                    textDisplays[messageIndexUsed].text = npcMessages[messageIndexUsed];
                    messageIndexUsed++;
                }
                else
                {
                    messageIndexUsed++;
                }
            }
        }
}
