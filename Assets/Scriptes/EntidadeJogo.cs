using UnityEngine;

public class EntidadeJogo : MonoBehaviour // Classe base para todas as entidades do jogo 
{
    public string nome;

    public virtual void Inicializar()
    {
        Debug.Log(nome + " inicializado");
    }
}