using UnityEngine;

public class arqueiro : personagem
{
    private int flechas; 
    public arqueiro(string nome, int vida, int forca, int flechas) :base (nome,vida)
    {
        this.flechas = flechas;
    }

    public void AtirarFlecha()
    {
        flechas--;
        Debug.Log("Flecha Atirada! Total de flechas: " +flechas);
    }


}
