using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScriptEscape : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Exit the game when escape is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
