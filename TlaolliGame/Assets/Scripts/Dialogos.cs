using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogos : MonoBehaviour
{
    public Text dialogos;
    public int contador=0;
    public Tutorial tutorial;
    public GameObject boxUI;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        DialogosTuto();
    }

    public void DialogosTuto()
    { if(contador==0)
    {
        dialogos.text= "Bienvenido a tu aventura lejana, hoy aprenderás a identificar aspectos importantes de nuestro mundo.";
    }else if(contador==1)
    {
        dialogos.text="Empecemos por el Maiz, selecciona el maiz y arrastralo hacia el mapa";
        tutorial.ChangeColor("#FFFFFF");
        boxUI.SetActive(true);

    }

    }

    public void next()
    {
        contador++;
    }
}
