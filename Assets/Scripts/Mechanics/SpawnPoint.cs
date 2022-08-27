using UnityEngine;
using static Platformer.Core.Simulation;
using Platformer.Gameplay;
using Platformer.Model;

namespace Platformer.Mechanics
{
    /// <summary>
    /// Marks a gameobject as a spawnpoint in a scene.
    /// </summary>
    public class SpawnPoint : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D other)
        {
            var player = other.gameObject.GetComponent<PlayerController>();
            if(player != null)
            {
                Debug.Log("New Spawnpoint Hit.");
                var ev = Schedule<PlayerSpawnpointCollision>();
                ev.spawnPoint = this;
                gameObject.SetActive(false);
            }
        }

    }
}