using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        Player player = other.gameObject.GetComponent<Player>();

        if(player != null)
        {
            player.Die();
            GameManager.instance.RespawnPlayer();
        }
    }

}
