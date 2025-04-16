using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Header : MonoBehaviour
{
    public TextMeshProUGUI text;

    public void SetText(string text)
    {
        this.text.text = text;
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }

    public void Toggle()
    {
        gameObject.SetActive(!gameObject.activeSelf);
    }
}
