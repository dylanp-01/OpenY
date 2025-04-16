using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class HomeMenu : MonoBehaviour
{
    public Employee employee;
    public TextMeshProUGUI welcomeDisplay;
    public TextMeshProUGUI timeDisplay;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeDisplay.text = FormatTime(DateTime.Now.TimeOfDay);
    }

    public void Open(Employee employee)
    {
        this.employee = employee;
        welcomeDisplay.text = $"Welcome {employee.name},\nHome Screen\n{employee.type}";
        gameObject.SetActive(true);
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    string FormatTime(TimeSpan time)
    {
        int hours = time.Hours;
        string suffix = hours < 12 ? "am" : "pm";
        hours = (hours %= 12) == 0 ? 12 : hours;
        return $"{hours}:{place2(time.Minutes)}:{place2(time.Seconds)}{suffix}";
    }

    string place2(int num)
    {
        string str = num.ToString();
        if (str.Length < 2)
        {
            str = "0" + str;
        }
        if (str.Length < 1)
        {
            str = "0" + str;
        }
        return str;
    }
}
