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
    using uFrame.ECS;
    using uFrame.Kernel;
    using UnityEngine;
    
    
    public class GUISystemGameReadyHandler {
        
        public MenuComponent Group;
        
        private uFrame.Kernel.GameReadyEvent _Event;
        
        private uFrame.ECS.EcsSystem _System;
        
        private UnityEngine.GameObject ActionNode146_obj = default( UnityEngine.GameObject );
        
        private bool ActionNode146_state = default( System.Boolean );
        
        private bool BoolNode147 = false;
        
        public uFrame.Kernel.GameReadyEvent Event {
            get {
                return _Event;
            }
            set {
                _Event = value;
            }
        }
        
        public uFrame.ECS.EcsSystem System {
            get {
                return _System;
            }
            set {
                _System = value;
            }
        }
        
        public virtual System.Collections.IEnumerator Execute() {
            ActionNode146_obj = Group.gameObject;
            ActionNode146_state = BoolNode147;
            // ActionNode
            while (this.DebugInfo("291ffeaa-dbda-403c-b412-a656b50143bf","62210118-65dd-4da2-ab94-1e4f97490b50", this) == 1) yield return null;
            // Visit GameObjectUtils.setActive
            GameObjectUtils.setActive(ActionNode146_obj, ActionNode146_state);
            yield break;
        }
    }
}
