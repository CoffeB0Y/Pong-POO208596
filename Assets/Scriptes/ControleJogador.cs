using UnityEngine;
using UnityEngine.InputSystem;
public class ControleJogador : EntidadeJogo
{
public float velocidade;

 public bool jogador1;
   public float yMin;
 public float yMax;



    void Start()
    {
       Inicializar();    
    }

    void Update() // roda a qauntidade de frames por segundo
    {
        if (jogador1==true)
        {
            MoverJogador1();

        }
        
    }




    public override void Inicializar()
{
    nome = "Jogador 1";
    Debug.Log(nome + " pronto");
}



      private void MoverJogador1()
    {

        transform.position = new Vector2(transform.position.x, Mathf.Clamp(transform.position.y, yMin, yMax)); // Limita a posição vertical do jogador dentro dos limites definidos

        if (Keyboard.current.wKey.isPressed)
        {
            transform.Translate(Vector2.up * velocidade * Time.deltaTime);
        }

        if (Keyboard.current.sKey.isPressed)
        {
            transform.Translate(Vector2.down * velocidade * Time.deltaTime);
        }
    }



   






















}