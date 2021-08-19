using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diretor : MonoBehaviour
{
   [SerializeField] private GameObject imagemGameOver;
   public void FinalizarJogo()
   {
      Time.timeScale = 0;
      this.imagemGameOver.SetActive(true);
   }
}
