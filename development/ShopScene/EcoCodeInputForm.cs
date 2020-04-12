using UnityEngine;

public class EcoCodeInputForm : MonoBehaviour
{
    // public GameObject InputForm;
    void Awake()
    {
        gameObject.SetActive(false);
    }
    public void GetInputForm()
    {
        gameObject.SetActive(true);
    }
    public void QuitInputForm()
    {
        gameObject.SetActive(false);
    }
}
