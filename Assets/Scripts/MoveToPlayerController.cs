using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayerController : MonoBehaviour
{
    // Die Geschwindigkeit mit der die Kugel sich in Richtung Spieler bewegen soll
    public float speed = 1;
    
    // Start is called before the first frame update
    void Start()
    {
        // Darüber holen wir uns das Spieler GameObject via des Tags. Das natürlich im Prefab "Player" auch gesetzt sein
        GameObject gameObject = GameObject.FindWithTag("Player");

        if (gameObject != null)
        {
            // Das ist ein Vector, der von der Kugel zum Spieler zeigt. Hierbei im 3D Raum.
            // Normalized brauchen wir hierbei wieder um die Länge des Vektors zu normalisieren, um die Geschwindigkeit richtungsunabhängig immer konstant zu halten
            Vector3 v3 = (gameObject.transform.position - transform.position).normalized;
            // Nun brechen wir das auf 2D herunter
            Vector2 v2 = new Vector2(v3.x, v3.y);
            // Nun setzen wir die velocity des Objekts, welches dieses Skript besitzt (z.B. unsere Kugeln)
            GetComponent<Rigidbody2D>().velocity = v2 * speed;
        }
    }
    
}
