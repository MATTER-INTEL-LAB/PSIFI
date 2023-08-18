using UnityEngine;
using System.Collections;
//using System.Diagnostics;
using TMPro;

public class DialogTest2 : MonoBehaviour
{
    [SerializeField]
    private DialogSystem dialogSystem01;
    [SerializeField]
    private TextMeshProUGUI textCountdown;
    [SerializeField]
    private DialogSystem dialogSystem02;
    public GameObject WebBrowser;
    private char sp = ')';


    private IEnumerator Start()
    {
        // ù ��° ��� �б� ����
        Debug.Log("DialogSystem01 Start!");
        yield return new WaitUntil(() => dialogSystem01.UpdateDialog());

        // ��� �б� ���̿� ���ϴ� �ൿ�� �߰��� �� �ִ�.
        // ĳ���͸� �����̰ų� �������� ȹ���ϴ� ����.. ����� 5-4-3-2-1 ī��Ʈ �ٿ� ����
        
        WebBrowser.SetActive(true);
        new WaitForSecondsRealtime(3f);

        Debug.Log("DialogSystem02 Start!");
        yield return new WaitUntil(() => dialogSystem02.UpdateDialog());

        textCountdown.gameObject.SetActive(true);
        textCountdown.text = "The End";

        new WaitForSeconds(2);

        UnityEditor.EditorApplication.ExitPlaymode();

    }

}