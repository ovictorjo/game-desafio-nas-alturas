using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    private Rigidbody2D fisica;
    
    [SerializeField] private float forca;
    private Vector3 posicaoInicial;
    private Diretor diretor;

    //chamado quando o objeto for criado
    private void Awake() 
    {
        this.fisica = GetComponent<Rigidbody2D>();
        this.posicaoInicial = this.transform.position;
    }

    //chamado quando a cena for criada
    private void Start() 
    {
        this.diretor = GameObject.FindObjectOfType<Diretor>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            this.Impulsionar();
        }
    }

    private void Impulsionar()
    {
        this.fisica.velocity = Vector2.zero;
        this.fisica.AddForce(Vector2.up * this.forca, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D colisao)
    {
        this.fisica.simulated = false;
        this.diretor.FinalizarJogo();
    }

    public void Reiniciar()
    {
        this.transform.position = this.posicaoInicial;
        this.fisica.simulated = true;
    }
}
