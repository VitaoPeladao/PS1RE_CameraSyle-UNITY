using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraActivator : MonoBehaviour
{
    //no unity, voce seleciona a sua camera e coloque ela nesse slot
    public Camera alphaCam;  

    //Ao iniciar, as cameras devem permanecer desativadas, pois ao entrar no trigger elas ligarao (Desative todas as cameras)
    //em especifico a modificacao do objeto nulo para camera, assim voce pode evitar problemas.
    void Start()
    {
        alphaCam.enabled = false;
    }

    //Aqui voce liga a camera
    private void OnTriggerEnter(Collider other)
    {
        alphaCam.enabled = true;
    }
    private void OnTriggerStay(Collider other) 
    {
        alphaCam.enabled = true;
    }
    private void OnTriggerExit(Collider other)
    {
        alphaCam.enabled = false;
    }
}