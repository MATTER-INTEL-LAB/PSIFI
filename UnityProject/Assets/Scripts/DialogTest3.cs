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


        // ù ��° ��� �б� ����
        Debug.Log("DialogSystem01 Start!");
        yield return new WaitUntil(() => dialogSystem01.UpdateDialog());

        // ��� �б� ���̿� ���ϴ� �ൿ�� �߰��� �� �ִ�.
        // ĳ���͸� �����̰ų� �������� ȹ���ϴ� ����.. ����� 5-4-3-2-1 ī��Ʈ �ٿ� ����
        //textCountdown.gameObject.SetActive(true);
        //int count = 5;
        //while (count > 0)
        //{
        //    textCountdown.text = count.ToString();
        //    count--;

        //    yield return new WaitForSeconds(1);
        //}
        //textCountdown.gameObject.SetActive(false);


        // ��ȭ ���� ����
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

