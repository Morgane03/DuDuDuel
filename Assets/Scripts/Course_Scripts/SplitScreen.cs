using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitScreen : MonoBehaviour
{
    [SerializeField] List<GameObject> player;

    [SerializeField] List<Camera> _camera;
    [SerializeField] Camera _UICamera;
    [SerializeField] Camera _nullCamera;



    public void DisplayPlayer(int nbPlayer)
    {
        Debug.Log(nbPlayer);
        for(int i = 0; i< nbPlayer; i++)
        {
            player[i].SetActive(true);
        }
    }

    public void DisplayCamera(int nbPlayer)
    {
        _UICamera.gameObject.SetActive(false);

        Camera firstCamera = _camera[0];
        Camera secondCamera = _camera[1];
        Camera thirdCamera = _camera[2];
        Camera fourthCamera = _camera[3];

        if (nbPlayer == 2)
        {
            firstCamera.gameObject.SetActive(true);
            secondCamera.gameObject.SetActive(true);
            firstCamera.rect = new Rect(0, 0, 1f, 0.5F);
            secondCamera.rect = new Rect(0, 0.5f, 1f, 1);
        }
        else if(nbPlayer == 3)
        {
            firstCamera.gameObject.SetActive(true);
            secondCamera.gameObject.SetActive(true);
            thirdCamera.gameObject.SetActive(true);
            _nullCamera.gameObject.SetActive(true);
            firstCamera.rect = new Rect(0, 0, 0.5f, 0.5f);
            secondCamera.rect = new Rect(0.5f, 0, 0.5f, 0.5f);
            thirdCamera.rect = new Rect(0, 0.5f, 1f, 0.5f);
            _nullCamera.rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
        }
        else if(nbPlayer == 4)
        {
            firstCamera.gameObject.SetActive(true);
            secondCamera.gameObject.SetActive(true);
            thirdCamera.gameObject.SetActive(true);
            fourthCamera.gameObject.SetActive(true);
            firstCamera.rect = new Rect(0, 0, 0.5f, 0.5f);
            secondCamera.rect = new Rect(0.5f, 0, 0.5f, 0.5f);
            thirdCamera.rect = new Rect(0, 0.5f, 0.5f, 0.5f);
            fourthCamera.rect = new Rect(0.5f, 0.5f, 0.5f, 0.5f);
        }
    }
}
