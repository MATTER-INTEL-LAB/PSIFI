using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarChatbox : MonoBehaviour
{
    public string[] sentences;
    public Transform chatTr;
    public GameObject chatBoxPreFab;

    private void Start()
    { 
    
    }
    public void TalkAvatar()
    {
        GameObject go = Instantiate(chatBoxPreFab);
        go.GetComponent<ChatSystem>().Ondialogue(sentences, chatTr);
    }
    private void OnMouseDown()
    {
        TalkAvatar();
    }
}
