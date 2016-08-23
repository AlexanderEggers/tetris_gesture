// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace TetrisDB {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using TetrisDB;
    using uFrame.ECS;
    using uFrame.Kernel;
    using UniRx;
    using UnityEngine;
    
    
    public partial class SpawnEventBase : uFrame.ECS.EcsSystem {
        
        private IEcsComponentManagerOf<MenuComponent> _MenuComponentManager;
        
        private IEcsComponentManagerOf<GroupComponent> _GroupComponentManager;
        
        private IEcsComponentManagerOf<GreenLightComponent> _GreenLightComponentManager;
        
        private IEcsComponentManagerOf<RedLightComponent> _RedLightComponentManager;
        
        private IEcsComponentManagerOf<SpawnComponent> _SpawnComponentManager;
        
        public IEcsComponentManagerOf<MenuComponent> MenuComponentManager {
            get {
                return _MenuComponentManager;
            }
            set {
                _MenuComponentManager = value;
            }
        }
        
        public IEcsComponentManagerOf<GroupComponent> GroupComponentManager {
            get {
                return _GroupComponentManager;
            }
            set {
                _GroupComponentManager = value;
            }
        }
        
        public IEcsComponentManagerOf<GreenLightComponent> GreenLightComponentManager {
            get {
                return _GreenLightComponentManager;
            }
            set {
                _GreenLightComponentManager = value;
            }
        }
        
        public IEcsComponentManagerOf<RedLightComponent> RedLightComponentManager {
            get {
                return _RedLightComponentManager;
            }
            set {
                _RedLightComponentManager = value;
            }
        }
        
        public IEcsComponentManagerOf<SpawnComponent> SpawnComponentManager {
            get {
                return _SpawnComponentManager;
            }
            set {
                _SpawnComponentManager = value;
            }
        }
        
        public override void Setup() {
            base.Setup();
            MenuComponentManager = ComponentSystem.RegisterComponent<MenuComponent>(4);
            GroupComponentManager = ComponentSystem.RegisterComponent<GroupComponent>(3);
            GreenLightComponentManager = ComponentSystem.RegisterComponent<GreenLightComponent>(7);
            RedLightComponentManager = ComponentSystem.RegisterComponent<RedLightComponent>(8);
            SpawnComponentManager = ComponentSystem.RegisterComponent<SpawnComponent>(1);
            this.OnEvent<TetrisDB.GroupShouldSpawnEvent>().Subscribe(_=>{ SpawnEventGroupShouldSpawnEventFilter(_); }).DisposeWith(this);
            this.OnEvent<uFrame.Kernel.GameReadyEvent>().Subscribe(_=>{ SpawnEventGameReadyFilter(_); }).DisposeWith(this);
        }
        
        protected virtual void SpawnEventGroupShouldSpawnEventHandler(TetrisDB.GroupShouldSpawnEvent data, SpawnComponent group) {
            var handler = new SpawnEventGroupShouldSpawnEventHandler();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void SpawnEventGroupShouldSpawnEventFilter(TetrisDB.GroupShouldSpawnEvent data) {
            var SpawnComponentItems = SpawnComponentManager.Components;
            for (var SpawnComponentIndex = 0
            ; SpawnComponentIndex < SpawnComponentItems.Count; SpawnComponentIndex++
            ) {
                if (!SpawnComponentItems[SpawnComponentIndex].Enabled) {
                    continue;
                }
                this.SpawnEventGroupShouldSpawnEventHandler(data, SpawnComponentItems[SpawnComponentIndex]);
            }
        }
        
        protected virtual void SpawnEventGameReadyHandler(uFrame.Kernel.GameReadyEvent data, SpawnComponent group) {
            var handler = new SpawnEventGameReadyHandler();
            handler.System = this;
            handler.Event = data;
            handler.Group = group;
            StartCoroutine(handler.Execute());
        }
        
        protected void SpawnEventGameReadyFilter(uFrame.Kernel.GameReadyEvent data) {
            var SpawnComponentItems = SpawnComponentManager.Components;
            for (var SpawnComponentIndex = 0
            ; SpawnComponentIndex < SpawnComponentItems.Count; SpawnComponentIndex++
            ) {
                if (!SpawnComponentItems[SpawnComponentIndex].Enabled) {
                    continue;
                }
                this.SpawnEventGameReadyHandler(data, SpawnComponentItems[SpawnComponentIndex]);
            }
        }
    }
    
    [uFrame.Attributes.uFrameIdentifier("5bf54a8f-6f4d-41d2-8581-23ecf72b02b5")]
    public partial class SpawnEvent : SpawnEventBase {
        
        private static SpawnEvent _Instance;
        
        public SpawnEvent() {
            Instance = this;
        }
        
        public static SpawnEvent Instance {
            get {
                return _Instance;
            }
            set {
                _Instance = value;
            }
        }
    }
}
