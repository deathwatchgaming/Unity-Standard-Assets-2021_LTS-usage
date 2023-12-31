using System;
using UnityEngine;

// Added
using UnityEngine.UI;

using UnityEngine.SceneManagement;
using UnityStandardAssets.CrossPlatformInput;

// Removed - Depreciated
//[RequireComponent(typeof (GUITexture))]
// Added
[RequireComponent(typeof(UnityEngine.UI.Image))]
public class ForcedReset : MonoBehaviour
{
    private void Update()
    {
        // if we have forced a reset ...
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
        {
            //... reload the scene
            SceneManager.LoadScene(SceneManager.GetSceneAt(0).name);
        }
    }
}
