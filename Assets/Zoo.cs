using UnityEngine;

public class Zoo : MonoBehaviour{
    void Start(){
        Animal tom = new Animal();
        tom.name = "��";
        tom.sound = "�Ŀ�!";

        tom.PlaySound();
    }
}
