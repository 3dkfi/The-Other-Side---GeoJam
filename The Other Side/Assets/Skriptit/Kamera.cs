using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour
{
    Camera _camera;
    public bool heavenOn;

    public Material skyHeaven;
    public Material skyHell;

    private void Start()
    {
        _camera = Camera.main;
        RenderSettings.skybox = skyHeaven;
    }

   /* void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {

            heavenOn = !heavenOn;
        }

        if (heavenOn)
        {
            _camera.cullingMask = ~(1 << LayerMask.NameToLayer("heaven"));
            //PelaajaManageri.instance.pelaaja.GetComponent<Renderer>().material.color = Color.white;
            RenderSettings.skybox = skyHeaven;
            DynamicGI.UpdateEnvironment();
        }
        else if (!heavenOn)
            _camera.cullingMask = ~(1 << LayerMask.NameToLayer("hell"));
         RenderSettings.skybox = skyHell;
        DynamicGI.UpdateEnvironment();
        //PelaajaManageri.instance.pelaaja.GetComponent<Renderer>().material.color = Color.red;
    }*/
}
