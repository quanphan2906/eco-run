using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RefreshInputField : MonoBehaviour
{
    public string CodeInputTag = "CodeInput";
    private GameObject CodeInput;
    private Text CodeInputText;
    void Start()
    {
        CodeInput = GameObject.FindWithTag(CodeInputTag);
        CodeInputText = CodeInput.GetComponent<Text>();
        Debug.Log(CodeInputText.text);
    }
    public void Click()
    {
        CodeInputText.text = "";
    }
}
