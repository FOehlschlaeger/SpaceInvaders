using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //print("Collision vorhanden");
        // Check ob Objekt der Spieler ist
        if (collision.gameObject.tag != "Player")
            // Lösche das Objekt welches die Kollision von außen erzeugt hat, nicht das Objekt welches mit diesem Skript verknüpft ist
            Destroy(collision.gameObject);
    }
}
