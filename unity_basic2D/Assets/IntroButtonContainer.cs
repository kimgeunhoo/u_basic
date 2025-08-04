using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class IntroButtonContainer : MonoBehaviour
{
    // 4개의 버튼이 포함되어 있는 컨테이너 시작, 튜토리얼, 옵션, 종료
    public void StartButton()
    {
        Debug.Log("게임을 시작합니다.");

        SceneManager.LoadScene(1);
    }

    public void ButtonTutorial(GameObject tut)
    {
        Debug.Log("튜토리얼을 실행합니다.");

        tut.SetActive(true);
    }

    public void ButtonOption()
    {
        Debug.Log("옵션 창을 열람합니다.");
    }

    public void ButtonExit()
    {
        Debug.Log("게임을 종료합니다.");

        Application.Quit();

#if UNITY_EDITOR

        EditorApplication.isPlaying = false;
#endif
    }


}
