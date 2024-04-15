using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private Rigidbody2D _rbPemain;

    private int _kesehatanPemain = 100;
    private float _kecepatanPemain = 4.6f;
    private bool _apakahPemainDiTanah = true;
    private string _namaPemain = "Ucup";
    private Vector3 _posisiPemain = new Vector3(-5f, 0f);


    private void Start()
    {
        _rbPemain = GetComponent<Rigidbody2D>();
        _rbPemain.gravityScale = 0;
    }

}
