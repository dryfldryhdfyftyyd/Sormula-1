using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class Button : MonoBehaviour
{
    public string sceneName;
    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("Button Pressed");
        
    }

}
