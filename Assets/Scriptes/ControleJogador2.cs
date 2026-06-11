using UnityEngine;
using UnityEngine.InputSystem;
public class ControleJogador2 : EntidadeJogo // Herda da classe EntidadeJogo, que é a classe base para os jogadores
{
public float velocidade;

 public bool jogador2;
  
 public float yMin;
 public float yMax;


    void Start()
    {
        
         Inicializar();
    }

    void Update() // roda a qauntidade de frames por segundo
    {
        if (jogador2 == true)
        {
            MoverJogador2();

        }
       
    }

    private void MoverJogador2() // Método para mover o jogador 2 usando as setas do teclado
{
    if (Keyboard.current == null) return;

    if (Keyboard.current.upArrowKey.isPressed)
    {
        transform.Translate(Vector2.up * velocidade * Time.deltaTime);
    }

    if (Keyboard.current.downArrowKey.isPressed)
    {
        transform.Translate(Vector2.down * velocidade * Time.deltaTime);
    }

    transform.position = new Vector2(
        transform.position.x,
        Mathf.Clamp(transform.position.y, yMin, yMax)
    );
}




    public override void Inicializar()
{
     nome = "Jogador 2";
    Debug.Log(nome + " pronto para jogar");
}






















}