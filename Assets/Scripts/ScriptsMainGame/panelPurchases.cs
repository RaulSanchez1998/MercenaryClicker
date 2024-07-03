using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEditor;
using UnityEngine;


public class panelPurchases : MonoBehaviour
{
    public RectTransform subMenu;
    public GameObject panel;
    float posFinal;
    bool abrirMenu = true;
    public float tiempo = 0.5f;

    private void Start()
    {
        posFinal = Screen.width / 2;
        subMenu.position = new UnityEngine.Vector3(-posFinal, subMenu.position.y, 0);
        
    }

    IEnumerator Mover(float time, UnityEngine.Vector3 postInit, UnityEngine.Vector3 posFin)
    {
        float elapseTime = 0;
        while(elapseTime < time)
        {
            subMenu.position = UnityEngine.Vector3.Lerp(postInit, posFin, (elapseTime / time));
            elapseTime += Time.deltaTime;
            yield return null;
        }
    }

    void MoverMenu(float time, UnityEngine.Vector3 posInit, UnityEngine.Vector3 posFin)
    {
        StartCoroutine(Mover(time, posInit, posFin));
    }

    public void Button_sub_menu()
    {
        /* print(abrirMenu);
        panel.SetActive(true);*/

        
         int signo = 1;
         if (!abrirMenu)
            signo = -1;
        //panel.SetActive(false);

       // print(abrirMenu);
             MoverMenu(tiempo, subMenu.position, new UnityEngine.Vector3(signo * 509.4f, subMenu.position.y, 0));
             abrirMenu = !abrirMenu;
        
      
        
    }
}
