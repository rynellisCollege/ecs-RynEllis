using Unity.Entities;
using UnityEngine;

namespace HelloCube.Execute
{
    public class ExecuteAuthoring : MonoBehaviour
    {
        public bool MainThread;
        public bool IJobEntity;
        public bool Aspects;
        public bool Prefabs;
        public bool IJobChunk;
        public bool Reparenting;
        public bool EnableableComponents;
        public bool GameObjectSync;
        public bool Creation;       //added #9 Creation bool **************************************************

        class Baker : Baker<ExecuteAuthoring>
        {
            public override void Bake(ExecuteAuthoring authoring)
            {
                var entity = GetEntity(TransformUsageFlags.None);

                if (authoring.MainThread) AddComponent<MainThread>(entity);
                if (authoring.IJobEntity) AddComponent<IJobEntity>(entity);
                if (authoring.Aspects) AddComponent<Aspects>(entity);
                if (authoring.Prefabs) AddComponent<Prefabs>(entity);
                if (authoring.IJobChunk) AddComponent<IJobChunk>(entity);
                if (authoring.GameObjectSync) AddComponent<GameObjectSync>(entity);
                if (authoring.Reparenting) AddComponent<Reparenting>(entity);
                if (authoring.EnableableComponents) AddComponent<EnableableComponents>(entity);
                if (authoring.Creation) AddComponent<Creation>(entity);     //added this *****************************

            }
        }
    }

    public struct MainThread : IComponentData
    {
    }

    public struct IJobEntity : IComponentData
    {
    }

    public struct Aspects : IComponentData
    {
    }

    public struct Prefabs : IComponentData
    {
    }

    public struct IJobChunk : IComponentData
    {
    }

    public struct GameObjectSync : IComponentData
    {
    }

    public struct Reparenting : IComponentData
    {
    }

    public struct EnableableComponents : IComponentData
    {
    }

    //Added Creation Struct  *****************************************
    public struct Creation : IComponentData
    { 
    }
}
