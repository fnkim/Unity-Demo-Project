using System.Collections;
using System.Collections.Generic;
using UnityEngine;



// This is a comment. It is used to be able to communicate with other programmers or leave notes without affecting the code.
// You use two forward slashes to make a one line comment

/* You can make multi-line comments using a forward slash and asterisk to start it
And then an asterisk followed by a forward slash to end it.
*/




public class Demo2Script : MonoBehaviour
{
    int _dog = 1;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(_dog);
    }

    // Update is called once per frame
    void Update()
    {
        _dog += 3;
        Debug.Log(_dog);
    }
}
