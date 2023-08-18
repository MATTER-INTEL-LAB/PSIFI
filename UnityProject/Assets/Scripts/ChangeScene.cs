using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

public class ChangeScene : MonoBehaviour
{
    public RenderPipelineAsset HDAsset;

    public void ChangeSceneBtn() 
    {
        switch (this.gameObject.name) 
        {
            case "Home":
                SceneManager.LoadScene(0);
                GraphicsSettings.renderPipelineAsset = default;
                Debug.Log("0번씬으로 전환되었습니다.");
                break;
            case "Scene1":
                SceneManager.LoadScene(1);
                GraphicsSettings.renderPipelineAsset = default;
                Debug.Log("1번씬으로 전환되었습니다.");
                break;
            case "Scene2":
                SceneManager.LoadScene(2);
                GraphicsSettings.renderPipelineAsset = HDAsset;
                Debug.Log("2번씬으로 전환되었습니다.");
                break;
            case "Scene3":
                SceneManager.LoadScene(3);
                GraphicsSettings.renderPipelineAsset = default;
                Debug.Log("3번씬으로 전환되었습니다.");
                break;
        }
    }

}
