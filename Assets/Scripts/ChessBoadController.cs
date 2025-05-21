using UnityEngine;
using TMPro;

public class ChessBoadController : MonoBehaviour
{
    public GameObject bishopLight;
    public GameObject knightLight;
    public GameObject pawnDark;
    public GameObject rookDark;

    public TextMeshProUGUI nbFoundPiecesText;
    private int speed = 45;

    private int nbFoundPieces;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nbFoundPiecesText.text = "0";
        nbFoundPieces = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void TurnAround()
    {
        transform.Rotate(Vector3.up * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTriggerEnter");
        Debug.Log(other.gameObject.name);
        if (other.gameObject.name == "BishopLight")
        {
            other.gameObject.SetActive(false);
            bishopLight.SetActive(true);
            nbFoundPieces += 1;
        }
        else if (other.gameObject.name == "KnightLight")
        {
            other.gameObject.SetActive(false);
            knightLight.SetActive(true);
            nbFoundPieces += 1;
        }
        else if (other.gameObject.name == "PawnDark")
        {
            other.gameObject.SetActive(false);
            pawnDark.SetActive(true);
            nbFoundPieces += 1;
        }
        else if (other.gameObject.name == "RookDark")
        {
            other.gameObject.SetActive(false);
            rookDark.SetActive(true);
            nbFoundPieces += 1;
        }

        nbFoundPiecesText.text = string.Format("{0}", nbFoundPieces);
        Debug.Log(nbFoundPieces);
    }
}
