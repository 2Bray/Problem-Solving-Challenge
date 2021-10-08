using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public void openScene(int idx)
    {
        SceneControllerScript.openScene(idx);
    }

    public void Exit() => SceneControllerScript.Exit();
}
