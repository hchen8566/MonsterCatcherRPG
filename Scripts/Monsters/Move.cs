using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move
{
    public MoveBase basic { get; set; }
    public int PP { get; set; }

    public Move(MoveBase mBasic)
    {
        basic = mBasic;
        PP = basic.PP;
    }

}
