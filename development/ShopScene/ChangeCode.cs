using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCode : MonoBehaviour
{
    public string CodeInputTag = "CodeInput";
    private GameObject CodeInput;
    private Text CodeInputText;
    private Text text;

    // Start is called before the first frame update
    void Start()
    {
        CodeInput = GameObject.FindWithTag(CodeInputTag);
        CodeInputText = CodeInput.GetComponent<Text>();
        text = gameObject.GetComponentInChildren<Text>();
    }

    public void Click()
    {
        string temp = CodeInputText.text;
        temp += text.text;
        if (temp.Length >= 5) return;
        CodeInputText.text = temp;
    }
}
