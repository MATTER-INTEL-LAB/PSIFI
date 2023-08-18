using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvatarController : MonoBehaviour
{
    private Animator animator;
    private char sp = ')';

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void UpdateAnimation()
    {
        int a = GameObject.Find("Panel").GetComponent<ChatInput>().inputField.text.Split(sp)[1].Length;

        IEnumerator VerbalDelay()
        {
            // for�� ����Ͽ�, text���� ��ŭ Verbal �ִϸ��̼� ����
            for (int i = 0; i < a; i++)
            {
                animator.SetInteger("Verbal", 1);
                yield return new WaitForSeconds(0.3f);
                animator.SetInteger("Verbal", 0);
                yield return new WaitForSeconds(0.3f);
                Debug.Log(i.ToString() + "");
            }
        }

        if (GameObject.Find("Panel").GetComponent<ChatInput>().inputField.text.Split(sp)[0] == "happy") 
        {
            animator.SetBool("Happy", true);
            animator.SetBool("Sadness", false);
            animator.SetBool("Anger", false);
            animator.SetBool("Surprise", false);
            animator.SetBool("Disgust", false);
            StartCoroutine(VerbalDelay());
        }

        if (GameObject.Find("Panel").GetComponent<ChatInput>().inputField.text.Split(sp)[0] == "sad") 
        {
            animator.SetBool("Happy", false);
            animator.SetBool("Sadness", true);
            animator.SetBool("Anger", false);
            animator.SetBool("Surprise", false);
            animator.SetBool("Disgust", false);
            StartCoroutine(VerbalDelay());
        }

        if (GameObject.Find("Panel").GetComponent<ChatInput>().inputField.text.Split(sp)[0] == "angry") 
        {
            animator.SetBool("Happy", false);
            animator.SetBool("Sadness", false);
            animator.SetBool("Anger", true);
            animator.SetBool("Surprise", false);
            animator.SetBool("Disgust", false);
            StartCoroutine(VerbalDelay());
        }

        if (GameObject.Find("Panel").GetComponent<ChatInput>().inputField.text.Split(sp)[0] == "surprised") 
        {
            animator.SetBool("Happy", false);
            animator.SetBool("Sadness", false);
            animator.SetBool("Anger", false);
            animator.SetBool("Surprise", true);
            animator.SetBool("Disgust", false);
            StartCoroutine(VerbalDelay());
        }

        if (GameObject.Find("Panel").GetComponent<ChatInput>().inputField.text.Split(sp)[0] == "disgusted") 
        {
            animator.SetBool("Happy", false);
            animator.SetBool("Sadness", false);
            animator.SetBool("Anger", false);
            animator.SetBool("Surprise", false);
            animator.SetBool("Disgust", true);
            StartCoroutine(VerbalDelay());
        }

        
    }
}
