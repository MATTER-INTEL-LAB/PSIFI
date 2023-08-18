using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackScene : MonoBehaviour
{
    public void BackSceneBtn() 
    {
        SceneManager.LoadScene(0);
        Debug.Log("0번씬으로 전환되었습니다.");
    }
}
