using UnityEngine;
using System.Collections;
/*
 *  Check if GameManager is instantiated
 */
public class Loader : MonoBehaviour {

    public GameObject gameManager;

	void Awake()
    {
        if (GameManager.instance == null)
            Instantiate(gameManager);
    }
}
