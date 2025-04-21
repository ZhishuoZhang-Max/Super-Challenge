using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonOpenOrClose : MonoBehaviour
{
    Button button;

    public GameObject closeUI;
    public GameObject openUI;
    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(() =>
        {
            if (openUI)
                openUI.SetActive(true);
            if (closeUI)
                closeUI.SetActive(false);
        });

    }

}
