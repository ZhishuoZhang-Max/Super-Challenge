using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

#if UNITY_EDITOR
using UnityEditor; // 仅在编辑器中导入该命名空间
#endif

public class SwitchSceneButton : MonoBehaviour
{
    private Button button;
    public bool isReplay;
    public int sceneIndex; // 场景索引
    public bool isExitGameButton; // 是否为退出游戏按钮

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

    // 游戏退出功能，根据编辑器和发布环境分别处理
    private void QuitGame()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false; // 在编辑器模式下停止运行
#else
        Application.Quit(); // 在发布的游戏中正常退出
#endif
    }
}
