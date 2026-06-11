using UnityEngine;

public class Disco : EntidadeJogo   
{
    public float velocidadeDisco;
   public Rigidbody2D origidbody;
    private Vector3 posicaoInicial;





   void Start()
{
    nome = "Disco";
    Inicializar();

    posicaoInicial = transform.position;
    origidbody = GetComponent<Rigidbody2D>();

    Lancar();
}

    
    void Update()
    {
        
    }

   private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Jogador1") ||
        collision.gameObject.CompareTag("Jogador2"))
    {
        Vector2 direcaoRebote =
            (transform.position - collision.transform.position).normalized;

        origidbody.linearVelocity = direcaoRebote * velocidadeDisco;
    }
}

void Lancar()
{
    float x = Random.value < 0.5f ? -1f : 1f;           
    float y = Random.Range(-1f, 1f);

    Vector2 dir = new Vector2(x, y).normalized;
    origidbody.linearVelocity = dir * velocidadeDisco;
}
public void ReiniciarDisco()
{
   transform.position = posicaoInicial;
    origidbody.linearVelocity = Vector2.zero;

    Lancar();
}







































}
