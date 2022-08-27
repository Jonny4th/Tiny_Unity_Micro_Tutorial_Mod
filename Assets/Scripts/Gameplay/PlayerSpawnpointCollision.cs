using Platformer.Core;
using Platformer.Model;
using Platformer.Mechanics;
using UnityEngine;

namespace Platformer.Gameplay
{

    /// <summary>
    /// Fired when a Player collides with a Spawnpoint.
    /// </summary>
    /// <typeparam name="SpawnpointCollision"></typeparam>
    public class PlayerSpawnpointCollision : Simulation.Event<PlayerSpawnpointCollision>
    {
        PlatformerModel model = Simulation.GetModel<PlatformerModel>();
        public SpawnPoint spawnPoint;
        
        public override void Execute()
        {
            model.spawnPoint = spawnPoint.transform;
            Debug.Log("New Spawn point registered." + spawnPoint.transform.position);
        }
    }
}
