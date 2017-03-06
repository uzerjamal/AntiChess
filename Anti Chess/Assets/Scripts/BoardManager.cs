using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour {

    private RaycastHit hit;

    private Vector3 scaleUpOnSelect = new Vector3(1.25f, 1.25f, 1);
    private Vector3 scaleBackDownOnDeselect = new Vector3(1, 1, 1);

    private GameObject selectedPiece;

    private bool isWhiteTurn = true;

    private int numberOfPiecesSelected = 0;



    void Update () {

        if (Input.GetMouseButtonDown(0))
        {

            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 20.0f, LayerMask.GetMask("Pieces")))
            {
                if (numberOfPiecesSelected >= 1)
                {
                    selectedPiece.transform.localScale = scaleBackDownOnDeselect;
                    selectedPiece = default(GameObject);
                    numberOfPiecesSelected--;
                }
                    selectedPiece = hit.transform.gameObject;
                    selectedPiece.transform.localScale = scaleUpOnSelect;
                    numberOfPiecesSelected++;
            }


        }
        

    }


}
