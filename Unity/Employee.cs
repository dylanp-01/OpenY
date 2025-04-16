using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Employee
{
    public string name;
    public string type;
}

public class Waiter : Employee
{
    public Waiter(string name)
    {
        this.name = name;
        type = "Waiter";
    }
}
