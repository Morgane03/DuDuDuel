using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxGenerator : MonoBehaviour
{
    public GameObject boxPrefab;    //a mettre dans le gameManager

    public Vector3 boxLenght;

    public Vector3 lenghtA;
    public Vector3 lenghtB;

    public GameObject positionLeft;
    public GameObject positionRight;

    public void RandomSize() //random taille de la caisse
    {
        Vector3 randomLenght = lenghtA - lenghtB;
        boxLenght = lenghtA + Random.value * randomLenght;
        boxPrefab.gameObject.transform.localScale = boxLenght;
    }
    public void RandomPosition()  //random position entre 2 points
    {
        Vector3 randomPos = positionLeft.transform.position - positionRight.transform.position;
        Vector3 targetPos = positionRight.transform.position + Random.value * randomPos;
        boxPrefab.transform.position = targetPos;
    }

    public void CreateBox()
    {
        if (ChanceGameManager.Instance.gameLauch)
        {
            RandomSize();
            GameObject newBox = Instantiate(boxPrefab);
            newBox.GetComponent<FallObject>();
            newBox.GetComponent<PlayerLoseCondition>();
            RandomPosition();

            StartCoroutine(WaitForNewBox());
        }
    }

    IEnumerator WaitForNewBox()
    {
        yield return new WaitForSeconds(1);
        CreateBox();
    }
}
