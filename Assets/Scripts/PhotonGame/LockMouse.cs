using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockMouse : MonoBehaviour
{
    bool isLocked;
    // Use this for initialization
    void Start()
    {
        SetCursorLock(isLocked);
        Cursor.visible = false;
    }

    void SetCursorLock(bool isLocked)
    {

        this.isLocked = isLocked;
        Screen.lockCursor = isLocked;
        Cursor.visible = !isLocked;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            SetCursorLock(!isLocked);
        }
    }
}