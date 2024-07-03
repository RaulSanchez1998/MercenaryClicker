using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenu : MonoBehaviour
{
    public GameObject panelMenu;
    private bool activo=false;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            print("Sup");
            if (activo == false)
            {
                panelMenu.SetActive(true);
                activo = true;
            }
            else
            {
                panelMenu.SetActive(false);
                activo = false;
            }



        }
    }
}
