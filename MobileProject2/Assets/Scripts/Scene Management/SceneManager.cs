﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    // Reference to pages
    public GameObject page1;
    public GameObject page2;
    public GameObject page3;
    public GameObject page4;

    public int pageProgression = 1;

    
    

    // Start is called before the first frame update
    void Awake()
    {
        page1.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        //This is debug, and should be moved into page scripts
        if (Input.GetKeyDown("space"))
        {
            pageProgression = pageProgression + 1;
        }


        if (pageProgression == 2 && !page2.activeSelf)
        {
            ActivatePage2();
            
        }

        if (pageProgression == 3 && !page3.activeSelf)
        {
            ActivatePage3();
        }
        else if (pageProgression == 4 && !page4.activeSelf)
        {
            ActivatePage4();
        }
        
    }

    void ActivatePage2()
    {
        page1.SetActive(false);
        page2.SetActive(true);
        Debug.Log("Page 2 is active");
    }
    void ActivatePage3()
    {
        page2.SetActive(false);
        page3.SetActive(true);
        Debug.Log("Page 3 is active");
    }
    void ActivatePage4()
    {
        page3.SetActive(false);
        page4.SetActive(true);
        Debug.Log("Page 4 is active");
    }
    public void AdvancePage()
    {
        pageProgression = pageProgression + 1;
    }
}