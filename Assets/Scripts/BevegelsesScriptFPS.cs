using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BevegelsesScriptFPS : MonoBehaviour
{
    public GameObject playerFpsGO;
    public Rigidbody fpsPlayerRB;

    // Start is called before the first frame update
    void Start()
    {
        fpsPlayerRB = playerFpsGO.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        BevegelseInputWASD();
    }

    void BevegelseInputWASD()
    {
        if (Input.GetKey(KeyCode.W))
        {
            fpsPlayerRB.AddForce(1,0,0);
            Debug.Log("W er pressa");
        }
    }
}
