using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    public void Cambiar_Escena(string scene){
        SceneManager.LoadScene(scene);
    }
}