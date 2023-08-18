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
                Debug.Log("0�������� ��ȯ�Ǿ����ϴ�.");
                break;
            case "Scene1":
                SceneManager.LoadScene(1);
                GraphicsSettings.renderPipelineAsset = default;
                Debug.Log("1�������� ��ȯ�Ǿ����ϴ�.");
                break;
            case "Scene2":
                SceneManager.LoadScene(2);
                GraphicsSettings.renderPipelineAsset = HDAsset;
                Debug.Log("2�������� ��ȯ�Ǿ����ϴ�.");
                break;
            case "Scene3":
                SceneManager.LoadScene(3);
                GraphicsSettings.renderPipelineAsset = default;
                Debug.Log("3�������� ��ȯ�Ǿ����ϴ�.");
                break;
        }
    }

}
