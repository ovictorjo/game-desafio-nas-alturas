using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeradorObstaculos : MonoBehaviour
{
    [SerializeField] 
    private float tempoPararGerar;
    private float _cronometro;
    [SerializeField]
    private GameObject manuelDeInstrucoes;

    private void Awake()
    {
        this._cronometro = this.tempoPararGerar;
    }
    void Update()
    {
        this._cronometro -= Time.deltaTime;

        if (this._cronometro < 0)
        {
            GameObject.Instantiate(this.manuelDeInstrucoes, this.transform.position, Quaternion.identity);
            this._cronometro = this.tempoPararGerar;
        }
    }
}
