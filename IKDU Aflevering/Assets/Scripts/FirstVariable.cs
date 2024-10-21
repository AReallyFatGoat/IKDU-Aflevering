using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstVariable : MonoBehaviour
{
    int Age = 21;
    void Start()
    {
        Debug.Log("Initial age is " + Age);
        int newAge = NextYear(Age);
        Debug.Log("Age next year is " + newAge);
        newAge = AfterYears(newAge, 7);
        Debug.Log("Age after 7 additional years " + newAge);
        
    }

    int NextYear(int age)
    {
        return age+=1;
    }

    int AfterYears(int age, int years)
    {
        return age+= years;
    }
}
