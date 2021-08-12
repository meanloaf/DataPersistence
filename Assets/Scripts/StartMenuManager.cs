using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StartMenuManager : MonoBehaviour
{
    public TMP_InputField inputField;
    public string nameField;
    private float timer = 0;

    private void Start()
    {
        inputField = gameObject.GetComponent<TMP_InputField>();
    }
    //private void Update()
    //{
        //nameField = inputField.text;
        //MenuInfo.Instance.NameInput = nameField;
        //timer += Time.deltaTime;
        //if (timer > 1)
        //{
        //    timer = 0;
        //    Debug.Log(nameField);
        //}
    //}

    public void NameChanged()
    {
        nameField = inputField.text;
        MenuInfo.Instance.NameInput = nameField;
    }
}
