using UnityEngine;

public class Gol : MonoBehaviour
{
    public bool golJogador1;
    public bool golJogador2;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


 void OnTriggerEnter2D(Collider2D collision) // Método chamado quando um objeto colide com o trigger
        {
        if (collision.gameObject.CompareTag("Disco")) // Verifica se o objeto que colidiu tem a tag "Disco"
        {
            if (golJogador1 == true)
            {
               
             Gamemaneger gm = Object.FindAnyObjectByType<Gamemaneger>();
             

             if (gm == null){
                 Debug.LogError("Gamemaneger não encontrado na cena!");
                 return;}

               gm.MarcarGolJogador1();}
            
           else if (golJogador2 == true)
{
    Gamemaneger gm = Object.FindAnyObjectByType<Gamemaneger>();
    

    if (gm == null)
    {
        Debug.LogError("Gamemaneger não encontrado na cena!");
        return;
    }

    gm.MarcarGolJogador2();
}
        }
        }
}

        






    





    






















