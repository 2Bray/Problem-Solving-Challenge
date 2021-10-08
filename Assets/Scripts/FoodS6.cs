using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodS6 : MonoBehaviour
{
    [SerializeField] private GameObject food;
    [SerializeField] private Transform[] walls;

    private void Start()
    {
        //Mengacak jumlah food, dan memasukan jumlah tersebut kedalam target pada object player
        int rand = Random.Range(2, 10);

        //Membuat satu-persatu object food
        for (int i = 0; i <= rand; i++)
        {
            //Mengacak posisi object food
            float posX = Random.Range(walls[3].position.x + 1, walls[1].position.x - 1);
            float posY = Random.Range(walls[2].position.y + 1, walls[0].position.y - 1);
            Vector3 foodPosition = new Vector3(posX, posY, 0);

            GameObject GO = Instantiate(food, foodPosition, Quaternion.identity);
            GO.GetComponent<BoxCollider2D>().enabled = false;
        }
    }
}
