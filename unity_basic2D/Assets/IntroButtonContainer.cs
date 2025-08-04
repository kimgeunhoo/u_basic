using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroButtonContainer : MonoBehaviour
{
    // 4���� ��ư�� ���ԵǾ� �ִ� �����̳� ����, Ʃ�丮��, �ɼ�, ����
    public void StartButton()
    {
        Debug.Log("������ �����մϴ�.");

        SceneManager.LoadScene(1);
    }

    public void ButtonTutorial(GameObject tut)
    {
        Debug.Log("Ʃ�丮���� �����մϴ�.");

        tut.SetActive(true);
    }

    public void ButtonOption()
    {
        Debug.Log("�ɼ� â�� �����մϴ�.");
    }

    public void ButtonExit()
    {
        Debug.Log("������ �����մϴ�.");

        Application.Quit();

#if UNITY_EDITOR

        EditorApplication.isPlaying = false;
#endif
    }


}
