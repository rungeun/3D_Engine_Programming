using UnityEngine;

public class Zoo : MonoBehaviour{
    void Start(){
        Animal tom = new Animal();
        tom.name = "Åè";
        tom.sound = "³Ä¿Ë!";

        tom.PlaySound();
    }
}
