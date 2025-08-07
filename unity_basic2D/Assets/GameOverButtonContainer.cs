using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.Rendering;

public class GameOverButtonContainer : MonoBehaviour
{
    private int SceneIndex;

    public void RestartButton()
    {
        Debug.Log("����� ��ư");
        SceneManager.LoadScene(1);
    }

    public void HomeButton()
    {
        Debug.Log("���θ޴� ��ư");
        SceneManager.LoadScene(0);
    }

    public void ExitButton()
    {
        Debug.Log("���� ��ư");
        Application.Quit();

#if UNITY_EDITOR

        EditorApplication.isPlaying = false;
#endif
    }

    public void ButtonNext(int sceneIndex)
    {
        SceneManager.LoadScene(sceneIndex);

    }


    //public void LoadSceneMethod(string name)
    //{
    //    // ���� �ҷ��� �� �� ���� Ư�� �����͸� Ŭ������ ���� �����ϰ� �ҷ��� �� �ִ�
    //    SceneManager.LoadScene(name);
    //}


}
