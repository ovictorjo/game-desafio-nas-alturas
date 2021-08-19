using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;


public class Obstaculo : MonoBehaviour
{

    [SerializeField] 
    private float velocidade = 0.5f;
    [SerializeField]
    private float variacaoY;

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));
    }

    private void Update()
    {
        this.transform.Translate(Vector3.left * (this.velocidade * Time.deltaTime));
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.Destruir();
    }

    public void Destruir()
    {
        GameObject.Destroy(this.gameObject);
    }
}
