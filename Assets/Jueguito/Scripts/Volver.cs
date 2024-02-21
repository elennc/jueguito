using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MoreMountains.Tools;

public class Volver : MonoBehaviour
{
    public void OnClickVolver()
    {
        MMSceneLoadingManager.LoadScene("Inicio");

    }
}
