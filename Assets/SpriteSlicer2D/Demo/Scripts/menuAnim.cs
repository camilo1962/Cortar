﻿using UnityEngine;
using System.Collections;

public class menuAnim : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Animator anim;
        anim = GetComponent<Animator>();
        anim.SetTrigger("menuanim");
    }
    public void BorrarRecor()
    {
        PlayerPrefs.DeleteAll();
    }

    public void Salir()
    {
        Application.Quit();
    }
}
