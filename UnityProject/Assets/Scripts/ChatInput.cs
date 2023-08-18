using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChatInput : MonoBehaviour
{
    public TMP_InputField inputField;  // ��ȭ �Է�â

    private void Update()
    {
        // ��ȭ �Է�â�� ��Ŀ�� �Ǿ����� ���� �� EnterŰ�� ������
        if (Input.GetKeyDown(KeyCode.Return) && inputField.isFocused == false)
        {
            // ��ȭ �Է�â�� ��Ŀ���� Ȱ��ȭ
            inputField.ActivateInputField();
            Debug.Log("InputField is active " + inputField.isFocused);
        }
    }

    public void OnEnditEventMethod()
    {
        //EnterŰ�� ������ ��ȭ �Է�â�� �Էµ� ������ ��ȭâ�� ���
        if (Input.GetKeyDown(KeyCode.Return))
        {
            UpdateChat();
            Debug.Log("UpdateChat starts");
        }
    }

    public void UpdateChat()
    {
        // InputField�� ��������� ����
        if (inputField.text.Equals("")) return;
        
        //��ȭ������ PanelMeDialog�� Text�� ����
        GameObject.Find("DialogSystem01").GetComponent<DialogSystem>().speakers[1].textDialogue.text = inputField.text;

        //Text�� ����ǥ���� �ش��ϴ� �κ��� �о� ǥ�� �ִϸ��̼� ����
        GameObject.Find("Avatar_JPLEE").GetComponent<AvatarController>().UpdateAnimation();

        //��ȭ�Է�â�� �ִ� ���� �ʱ�ȭ
        inputField.text = "";
    }
}
