using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class CambiarGano : MonoBehaviour
{
    public void OnCambiarGano()
    {
        MMSceneLoadingManager.LoadScene("Gano");
    }
}
