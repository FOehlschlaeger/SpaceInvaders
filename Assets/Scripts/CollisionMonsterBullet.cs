using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionMonsterBullet : MonoBehaviour
{
    // Wird ausgelöst, sobald eine Kollision zwischen dem Collider und dem Collider dieses Objekts passiert
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Wir überprüfen, ob das Objekt mit dem wir kollidieren ein Monster oder ein Bullet Tag hat
        if (collision.gameObject.tag == "Monster" || collision.gameObject.tag == "Bullet")
        {
            // Wenn das der Fall ist, ignorieren wir die Kollision. Das Monster kann als z.B. durchfliegen
            // Erster Parameter: Collider des Objekts mit dem die Kollision stattgefunden hat
            // Zweiter Parameter: Collider des Objekts welches dieses Skript besitzt als Component
            Physics2D.IgnoreCollision(collision.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
        else
        {
            // Wenn die Kollision mit einem anderen Objekt war (z.B. dem Spieler) dann soll dieses Objekt (das welches dieses Script hat) zerstört werden
            Destroy(gameObject);
            if (collision.gameObject.tag != "Wall")
            {
                // Zusätzlich soll das Objekt, mit dem kollidiert wird, zerstört werden, wenn es nicht die Wand ist
                Destroy(collision.gameObject);
            }
        }
    }
}
