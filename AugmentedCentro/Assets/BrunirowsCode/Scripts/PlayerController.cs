using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Player _player;

    public void LeftDown()
    {
        _player.Left(true);
    }
    public void LeftUp()
    {
        _player.Left(false);
    }
    public void RightDown()
    {
        _player.Right(true);
    }
    public void RightUp()
    {
        _player.Right(false);
    }
}
