using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public partial class BattleAction
{
    public class AddEuipment : BattleActionBase
    {
        public BattleActionType ActionType { get { return BattleActionType.AddEuipment; } }
        public override void Excute()
        {
            throw new System.NotImplementedException();
        }
    }
}
