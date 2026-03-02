using System.Collections.Generic;
using Azulon.Actors.Player;
using Common.Data;
using Common.Models;

namespace Azulon.Models
{
    public class PlayersModel:IModel
    {
        public ActiveData<PlayerController> CurrentPlayer = new ();
        public List<PlayerController> Players = new();
        
        public void Init() { }
        public void DeInit() { }
    }
}