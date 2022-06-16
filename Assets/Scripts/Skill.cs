using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Skill : MonoBehaviour
{
    private static Button skillButton1;
    private static Button skillButton2;
    private static Button skillButton3;
    private static Button skillButton4;

    List<Button>buttonList = new List<Button>{skillButton1, skillButton2, skillButton3, skillButton4};
    public void Awake()
    {
        InitButtonsListener();
    }
    void InitButtonsListener()
    {
        for (int b_index=0; b_index<4; b_index++)
        {
            Button button = buttonList[b_index];
            button = GameObject.Find("Skill"+(b_index+1)).gameObject.GetComponent<Button>();
            button.onClick.AddListener(delegate{ButtonOnclicked(button);});
        }
    }

    private void ButtonOnclicked(Button button)
    {
        Debug.Log(button.gameObject.GetComponentInChildren<TMP_Text>().text);
    }
}
