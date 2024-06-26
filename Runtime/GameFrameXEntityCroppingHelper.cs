using UnityEngine;
using UnityEngine.Scripting;

namespace GameFrameX.Entity.Runtime
{
    [Preserve]
    public class GameFrameXEntityCroppingHelper : MonoBehaviour
    {
        [Preserve]
        private void Start()
        {
            _ = typeof(EntityManager);
            _ = typeof(HideEntityCompleteEventArgs);
            _ = typeof(IEntity);
            _ = typeof(IEntityGroup);
            _ = typeof(IEntityGroupHelper);
            _ = typeof(IEntityHelper);
            _ = typeof(IEntityManager);
            _ = typeof(ShowEntityDependencyAssetEventArgs);
            _ = typeof(ShowEntityFailureEventArgs);
            _ = typeof(ShowEntitySuccessEventArgs);
            _ = typeof(ShowEntityUpdateEventArgs);
            _ = typeof(DefaultEntityGroupHelper);
            _ = typeof(DefaultEntityHelper);
            _ = typeof(AttachEntityInfo);
            _ = typeof(Entity);
            _ = typeof(EntityComponent);
            _ = typeof(EntityGroupHelperBase);
            _ = typeof(EntityHelperBase);
            _ = typeof(EntityLogic);
            _ = typeof(ShowEntityInfo);
        }
    }
}