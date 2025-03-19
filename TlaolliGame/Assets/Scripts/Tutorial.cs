using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public Animator animator;
    public Image panel;
    // Start is called before the first frame update
    void Start()
    {
        animator.GetComponent<Animator>();
        ChangeColor("#8A8A8A");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    public void ChangeColor(string hexColor)
    {
        Color newColor;
        if (ColorUtility.TryParseHtmlString(hexColor, out newColor))
        {
            panel.color = newColor;
        }
        
    }
}
