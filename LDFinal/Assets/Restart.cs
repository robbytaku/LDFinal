using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            SceneManager.LoadScene(0);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
