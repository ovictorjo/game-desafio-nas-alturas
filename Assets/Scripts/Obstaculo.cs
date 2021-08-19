using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Random = UnityEngine.Random;
using Vector3 = UnityEngine.Vector3;


public class Obstaculo : MonoBehaviour
{

    [SerializeField] 
    private float velocidade = 0.5f;
    [SerializeField]
    private float variacaoY;
    private Pontuacao pontuacao;
    private bool pontuei;
    private Vector3 posicaoDoAviao;

    private void Start()
    {
        this.posicaoDoAviao = GameObject.FindObjectOfType<Aviao>().transform.position;
        this.pontuacao = GameObject.FindObjectOfType<Pontuacao>();
    }

    private void Awake()
    {
        this.transform.Translate(Vector3.up * Random.Range(-variacaoY, variacaoY));
    }

    private void Update()
    {
        this.transform.Translate(Vector3.left * (this.velocidade * Time.deltaTime));

        if (!this.pontuei && this.transform.position.x < this.posicaoDoAviao.x)
        {
            this.pontuacao.AdicionarPontos();
            this.pontuei = true;
        }
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
