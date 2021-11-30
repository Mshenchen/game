using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public void ShowUI()
    {
        canvasGroup.DOFade(1, 0.7f);
    }
    public void HideUI()
    {
        canvasGroup.DOFade(0, 0.7f).onComplete = () =>
        {
            gameObject.SetActive(false);
        };
    }
}
