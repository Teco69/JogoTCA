using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CENASMANAGER : MonoBehaviour
{
    public string enfermariaCena;
    public void enfermaria(){
        SceneManager.LoadScene(enfermariaCena);


    }
}
