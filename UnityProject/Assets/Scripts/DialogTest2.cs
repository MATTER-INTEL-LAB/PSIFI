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
        // 첫 번째 대사 분기 시작
        Debug.Log("DialogSystem01 Start!");
        yield return new WaitUntil(() => dialogSystem01.UpdateDialog());

        // 대사 분기 사이에 원하는 행동을 추가할 수 있다.
        // 캐릭터를 움직이거나 아이템을 획득하는 등의.. 현재는 5-4-3-2-1 카운트 다운 실행
        
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