using UnityEngine;
using TMPro;
public class Gamemaneger : MonoBehaviour
{
    public static Gamemaneger Instance; // Instância única do Gamemaneger
    
    public Placar placar;
    public Disco disco;
    public int placarMaximo = 4; // Placar necessário para vencer o jogo
    public bool jogoAtivo = true; // Variável para controlar se o jogo está ativo ou não
    public TMP_Text placarTexto;
    
   



    void Start()
    {
       placar = new Placar();  
       disco = Object.FindAnyObjectByType<Disco>();
       if (disco == null)
    {
        Debug.LogError("Disco não encontrado na cena!");
    }
       AtualizarPlacar();
    }

    
    void Update()
    {
        if (jogoAtivo)
        {
            VerificarVencedor();
        }
    }

    




    public void MarcarGolJogador1()
{
    placar.jogador1++;
    AtualizarPlacar();

    VerificarVencedor();
    disco.ReiniciarDisco();

    Debug.Log("Gol do Jogador 1!");
}

public void MarcarGolJogador2()
{
     placar.jogador2++;
    AtualizarPlacar();

    VerificarVencedor();
    disco.ReiniciarDisco();

    Debug.Log("Gol do Jogador 2!");
}




 private void Awake() // Método chamado quando o script é carregado
    {
        Instance = this; // Atribui a instância atual do Gamemaneger à variável estática Instance
    }








    public void AtualizarPlacar()
    {
      placarTexto.text = placar.jogador1 + " - " + placar.jogador2;
}
    






    public void ReiniciarJogo()
    {
        placar.Reset();
        jogoAtivo = true; // Reinicia o jogo
    }



    public void VerificarVencedor()
{
    if (placar.jogador1 >= placarMaximo)
    {
        Debug.Log("Jogador 1 venceu!");
        EncerrarJogo();
        ZerarPlacar();
    }
    else if (placar.jogador2 >= placarMaximo)
    {
        Debug.Log("Jogador 2 venceu!");
        EncerrarJogo();
        ZerarPlacar();
    }
}


public void ZerarPlacar()
{
   placar.Reset();
    AtualizarPlacar();
}







    public void EncerrarJogo()
    {
        jogoAtivo = false; // Encerra o jogo
    }























}
