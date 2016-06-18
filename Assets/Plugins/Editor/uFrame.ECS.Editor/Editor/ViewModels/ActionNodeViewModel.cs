using System.Configuration;
using Invert.Core.GraphDesigner;
using Invert.Data;
using uFrame.Attributes;

namespace Invert.uFrame.ECS
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;


    public class ActionNodeViewModel : ActionNodeViewModelBase
    {
        public override NodeColor Color
        {
            get { return NodeColor.Black; }
        }
        public override INodeStyleSchema StyleSchema
        {
            get
            {
                return MinimalisticStyleSchema;
            }
        }
        public ActionNode Action
        {
            get { return GraphItem as ActionNode; }
        }

        public override IEnumerable<string> Tags
        {
            get
            {
                if (!string.IsNullOrEmpty(SecondTitle))
                {
                    if (Action.Meta == null) yield return "Action Not Found";
                    else yield return Action.Title;
                };
                var sequenceContainer = SequenceNode.Graph.CurrentFilter as ISequenceNode;
                if (sequenceContainer != null && sequenceContainer.StartNode == SequenceNode)
                {
                    yield return "Start";
                }
                yield break;
            }
        }

        public override bool IsCollapsed
        {
            get { return false; }
            set { base.IsCollapsed = value; }
        }

        public override bool AllowCollapsing
        {
            get { return false; }
        }

        public override void DataObjectChanged()
        {
            base.DataObjectChanged();

        }

        public override void PropertyChanged(IDataRecord record, string name, object previousValue, object nextValue)
        {
            base.PropertyChanged(record, name, previousValue, nextValue);
            if (name == "StartActionId")
            {
                DataObjectChanged();
            }

        }

        public override bool IsEditable
        {
            get
            {

                return base.IsEditable;
            }
        }



        public override string Name
        {
            get
            {
                if (Action.Meta == null) return Action.MetaType + "Not Found";
                return string.IsNullOrEmpty(SecondTitle) ? Action.Title : SecondTitle;
            }
            set { base.Name = value; }
        }

        public ActionNodeViewModel(ActionNode graphItemObject, Invert.Core.GraphDesigner.DiagramViewModel diagramViewModel) :
                base(graphItemObject, diagramViewModel)
        {
        }

        public virtual bool ShowContextVariables
        {
            get { return true; }
        }
        protected override void CreateContent()
        {
            base.CreateContent();

        }
    }


}
