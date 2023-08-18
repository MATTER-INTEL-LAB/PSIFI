using UnityEngine;
using System.Collections;
//using System.Diagnostics;
using UnityEngine.Video;
using TMPro;

public class DialogTest3 : MonoBehaviour
{
	[SerializeField]
	private	DialogSystem	dialogSystem01;
	[SerializeField]
	private	TextMeshProUGUI	textCountdown;
	[SerializeField]
	private	DialogSystem	dialogSystem02;
    [SerializeField]
    private GameObject      VideoPlayer;
    [SerializeField]
    private GameObject      Screen;
    public  GameObject      WebBrowser;
    private double time;
    private double currentTime;


    private IEnumerator Start()
	{
        VideoPlayer.SetActive(false);
        Screen.SetActive(false);


        // 첫 번째 대사 분기 시작
        Debug.Log("DialogSystem01 Start!");
        yield return new WaitUntil(() => dialogSystem01.UpdateDialog());

        // 대사 분기 사이에 원하는 행동을 추가할 수 있다.
        // 캐릭터를 움직이거나 아이템을 획득하는 등의.. 현재는 5-4-3-2-1 카운트 다운 실행
        //textCountdown.gameObject.SetActive(true);
        //int count = 5;
        //while (count > 0)
        //{
        //    textCountdown.text = count.ToString();
        //    count--;

        //    yield return new WaitForSeconds(1);
        //}
        //textCountdown.gameObject.SetActive(false);


        // 영화 감상 시작
        VideoPlayer.SetActive(true);
        Screen.SetActive(true);

        yield return new WaitUntil(() => VideoPlayer.GetComponent<VideoPlayer>().isPlaying == false);

        Debug.Log("DialogSystem02 Start!");
        yield return new WaitUntil(() => dialogSystem02.UpdateDialog());
        WebBrowser.SetActive(true);

        textCountdown.gameObject.SetActive(true);
        textCountdown.text = "The End";

        new WaitForSeconds(2);

        UnityEditor.EditorApplication.ExitPlaymode();

        

        Debug.Log(VideoPlayer.GetComponent<VideoPlayer>().isPlaying);

    }

}

