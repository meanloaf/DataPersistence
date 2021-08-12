using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using System.IO;

public class MenuInfo : MonoBehaviour
{
    public static MenuInfo Instance;
    public string NameInput;
    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    public void LoadMain()
    {
        SceneManager.LoadScene(1);
    }

    public void ResetScore()
    {
        string path = Application.persistentDataPath + "/Save.json";
        if (File.Exists(path))
        {
            File.Delete(path);
        }
    }
}
