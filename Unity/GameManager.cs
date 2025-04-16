using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameManager : MonoBehaviour
{
    public Boolean defaultBootBehavior;
    public Header header;
    public LoginMenu loginMenu;
    public HomeMenu homeMenu;

    // Start is called before the first frame update
    void Start()
    {
        if (defaultBootBehavior)
        {
            header.Hide();
            homeMenu.Close();
            loginMenu.Open();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Login(Employee employee)
    {
        loginMenu.Close();
        homeMenu.Open(employee);
    }
}
