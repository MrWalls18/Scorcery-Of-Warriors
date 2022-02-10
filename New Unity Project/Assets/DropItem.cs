using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    [SerializeField] private List<GameObject> ingredients;
    private void OnDestroy()
    {
        if (Random.Range(0, 4) == 3)
        {
            Instantiate(ingredients[Random.Range(0, ingredients.Count)], transform.position, transform.rotation);
        }
    }
}
