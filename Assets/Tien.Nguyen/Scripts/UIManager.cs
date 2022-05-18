using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] GameObject panelResult;
    [SerializeField] TextMeshProUGUI notiTxt;

    [Space]
    [SerializeField] string winStr;
    [SerializeField] string loseStr;

    [SerializeField] Image[] keyIcons;

    private void Start()
    {
        ActivePanelResult(false);

        for (int i = 0; i < keyIcons.Length; i++)
        {
            keyIcons[i].gameObject.SetActive(false);
        }
    }

    public void ActivePanelResult(bool isActive, bool isWin = false)
    {
        panelResult.SetActive(isActive);

        if (isActive)
            ChangeText(isWin);
    }

    void ChangeText(bool isWin)
    {
        if (isWin)
            notiTxt.text = winStr;
        else
            notiTxt.text = loseStr;
    }

    public void ActiveKeyIcon(int _index)
    {
        keyIcons[_index].gameObject.SetActive(true);
    }
}
