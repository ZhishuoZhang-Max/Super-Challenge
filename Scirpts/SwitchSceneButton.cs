using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor; // ���ڱ༭���е���������ռ�
#endif

public class SwitchSceneButton : MonoBehaviour
{
    private Button button;
    public bool isReplay;
    public int sceneIndex; // ��������
    public bool isExitGameButton; // �Ƿ�Ϊ�˳���Ϸ��ť

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            if (isExitGameButton)
            {
                QuitGame();
            }
            else
            {
                if (isReplay)
                {
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                }
                else
                {
                    SceneManager.LoadScene(sceneIndex);

                }
            }
        });
    }

    // ��Ϸ�˳����ܣ����ݱ༭���ͷ��������ֱ���
    private void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false; // �ڱ༭��ģʽ��ֹͣ����
#else
        Application.Quit(); // �ڷ�������Ϸ�������˳�
#endif
    }
}
