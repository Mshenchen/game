using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tools
{
    static Tools ins;
    public  static Tools Ins
    {
        get
        {
            if (ins == null)
            {
                ins = new Tools();
            }
            return ins;
        }
    }
    Tools()
    {

    }
    public void ShowUI(GameObject uiOb)
    {
        uiOb.SetActive(true);
        uiOb.GetComponent<CanvasGroup>().alpha = 0;
        uiOb.GetComponent<UIManager>().ShowUI();
    }
    public void HideUI(GameObject uiOb)
    {
        uiOb.GetComponent<UIManager>().HideUI();
    }
}
