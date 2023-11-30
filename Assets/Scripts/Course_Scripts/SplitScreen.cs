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

        if(nbPlayer == 2)
        {
            Camera firstCamera = _camera[0];
            Camera secondCamera = _camera[1];
            firstCamera.gameObject.SetActive(true);
            secondCamera.gameObject.SetActive(true);
            firstCamera.rect = new Rect(0, 0, 1f, 1);
            secondCamera.rect = new Rect(0, 0.5f, 1f, 1);
        }
        else
        {
            if(nbPlayer == 3)
            {
                _nullCamera.gameObject.SetActive(true);
            }
            for(int i = 0; i < nbPlayer; i++)
            {
                _camera[i].gameObject.SetActive(true);
            }
        }
    }
}
