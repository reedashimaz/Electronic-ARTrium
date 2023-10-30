using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeUnityBG : MonoBehaviour
{
    private Camera mainCamera;
    private Color originalBackgroundColor;
    private bool colorChanged = false;

    // Start is called before the first frame update
    void Start()
    {
        // Find the main camera in the scene by its tag
        mainCamera = Camera.main;

        if (mainCamera != null)
        {
            // Store the original background color
            originalBackgroundColor = mainCamera.backgroundColor;
        }
        else
        {
            Debug.LogError("MainCamera not found. Make sure you have a camera tagged as 'MainCamera' in your scene.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !colorChanged)
        {
            if (mainCamera != null)
            {
                // Change the background color to blue
                mainCamera.backgroundColor = Color.blue;
                colorChanged = true;
            }
        }
        else if (Input.GetKeyDown(KeyCode.Space) && colorChanged)
        {
            if (mainCamera != null)
            {
                // Restore the original background color
                mainCamera.backgroundColor = originalBackgroundColor;
                colorChanged = false;
            }
        }
    }
}

