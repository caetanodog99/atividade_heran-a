using UnityEngine;

public class testeFlechas : MonoBehaviour
{

    void Start()
    {
        arqueiro caçador = new arqueiro("paladino", 10, 7, 5);
        caçador.AtirarFlecha();

    }


}
