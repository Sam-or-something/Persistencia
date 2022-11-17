using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersistenciaPlayerPrefs : MonoBehaviour
{
    public string nombre;

    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetString("nombreAlmacenado", nombre);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
