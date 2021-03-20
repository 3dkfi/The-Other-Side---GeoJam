using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    Camera _camera;
    public bool heavenOn;

    private void Start()
    {
        _camera = Camera.main;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            heavenOn = !heavenOn;
        }

        if (heavenOn)
        {
            _camera.cullingMask = ~(1 << LayerMask.NameToLayer("heaven"));
            PelaajaManageri.instance.pelaaja.GetComponent<Renderer>().material.color = Color.white;
        }
        else if (!heavenOn)
            _camera.cullingMask = ~(1 << LayerMask.NameToLayer("hell"));
        PelaajaManageri.instance.pelaaja.GetComponent<Renderer>().material.color = Color.red;
    }
}
