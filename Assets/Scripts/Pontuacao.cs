using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.UI;
public class Pontuacao : MonoBehaviour
{

   public Text TextoPontuacao;
   private int pontos;

   public void AdicionarPontos()
   {
      this.pontos++;
      this.TextoPontuacao.text = this.pontos.ToString();
   }

   public void Reiniciar()
   {
      this.pontos = 0;
      this.TextoPontuacao.text = this.pontos.ToString();
   }
}
