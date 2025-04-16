using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoginMenu : MonoBehaviour
{
    public GameManager gameManager;
    public TMP_InputField username;
    public TMP_InputField password;
    public GameObject errorText;
    public GameObject regularButton;
    public GameObject erroredButton;

    public void Open()
    {
        SetErrorState(false);
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
        ResetFields();
    }

    public void PressLogin()
    {
        Debug.Log($"Logging in with Username: '{username.text}'; Password: '{password.text}'");
        if (username.text == "myusername" && password.text == "mypassword")
        {
            Success();
        }
        else
        {
            SetErrorState(true);
            ResetPasswordField();
        }
    }

    void Success()
    {
        Waiter waiter = new Waiter("John Do");
        Debug.Log($"Login Successful with '{waiter.name}'");
        gameManager.Login(waiter);
    }

    void ResetFields()
    {
        username.text = string.Empty;
        ResetPasswordField();
    }

    void ResetPasswordField()
    {
        password.text = string.Empty;
    }

    void SetErrorState(bool error)
    {
        if (error)
        {
            errorText.SetActive(true);
            regularButton.SetActive(false);
            erroredButton.SetActive(true);
        }
        else
        {
            errorText.SetActive(false);
            erroredButton.SetActive(false);
            regularButton.SetActive(true);
        }
    }
}
