using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    // Darüber regulieren wir, wie schnell sich unser Spieler von uns bewegen lässt
    public float speed = 10f;
    // Das ist unser Rigidbody object, welches wir später nutzen um den Spieler zu bewegen
    Rigidbody2D rigidbody;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        // Damit holen wir uns die Rigidbody2D component des Player GameObject, um es später bewegen zu können
        rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void OnDisable()
    {
        // Parameter 0 entspricht dem Index der Scene
        SceneManager.LoadScene(0);
    }

    // Wird eine feste Anzahl an Malen aufgerufen pro Sekunde, damit das Spiel auf allen Geräten gleich schnell ist
    private void FixedUpdate()
    {
        // Holen der Achsen entlang derer die Bewegung des Spielers ausgeführt wird, liefern jeweils entweder 0 oder 1 zurück
        // Damit holen wir uns ob der Nutzer A oder D drückt bzw. links oder rechts
        float h = Input.GetAxis("Horizontal");
        // Damit holen wir uns ob der Nutzer W oder S drückt bzw. oben oder unten
        float v = Input.GetAxis("Vertical");

        // Damit erzeugen wir einen Vektor mit den beiden Komponenten basierend auf der Nutzereingabe über die Tasten
        Vector2 dir = new Vector2(h, v);
        // Damit setzen wir die Geschwindigkeit des Rigidbody bzw unseres Spieler
        // Die Geschwindigkeit setzt sich zusammen aus der normalisierten Richtung (Einheitskreis) und dem zuvor gesetzten Speed
        rigidbody.velocity = dir.normalized * speed;

        animator.SetBool("isFlyingLeft", (h < 0));
        animator.SetBool("isFlyingRight", (h > 0));
        animator.SetBool("isFlyingUp", (v > 0));
    }

}
