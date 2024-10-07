using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
   {
    for ( int month =1; month <=31; month++)
    if (month==11)
    {
    Debug.Log("It's my birthday!");
    }

    else
    {
        Debug.Log(month);
    }

   }

      
   


   
        
    // Update is called once per frame
    void Update()
    {
        
    }
}    


