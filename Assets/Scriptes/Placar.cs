public class Placar
{
    public int jogador1;
    public int jogador2;

    // construtor (obrigatório)
    public Placar(int j1, int j2)
    {
        jogador1 = j1;
        jogador2 = j2;
    }

    // sobrecarga
    public Placar()
    {
        jogador1 = 0;
        jogador2 = 0;
    }

    public void Reset()
    {
        jogador1 = 0;
        jogador2 = 0;
    }
}