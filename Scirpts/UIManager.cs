using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class UIManager : MonoBehaviour
{
    public static UIManager Instance;

    public GameObject wincontentText;
    public GameObject faildontentText;

    private void Awake()
    {
        Instance = this;
    }


   public void Win()
    {
        wincontentText.SetActive(true);
        faildontentText.SetActive(false);
    }

    public void Faild()
    {
        wincontentText.SetActive(false);
        faildontentText.SetActive(true);
    }
}
