using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class GameOverButtonContainer : MonoBehaviour
{
    public void RestartButton()
    {
        Debug.Log("재시작 버튼");
        SceneManager.LoadScene(1);
    }

    public void HomeButton()
    {
        Debug.Log("메인메뉴 버튼");
        SceneManager.LoadScene(0);
    }

    public void ExitButton()
    {
        Debug.Log("종료 버튼");
        Application.Quit();

#if UNITY_EDITOR

        EditorApplication.isPlaying = false;
#endif
    }


    //public void LoadSceneMethod(string name)
    //{
    //    // 씬을 불러올 때 그 씬의 특정 데이터를 클래스로 만들어서 저장하고 불러올 수 있다
    //    SceneManager.LoadScene(name);
    //}


}
