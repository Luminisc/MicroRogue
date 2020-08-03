using System;
using System.Collections.Generic;
using MicroRogue.Core.Input;

namespace MicroRogue.Core
{
    public class Game
    {
        public Scene CurrentScene;
        public List<Unit> Units;
        public Unit PlayerUnit;
        
        public void LoadDemo()
        {
            var random = new Random();
            var mapWidth = 20;
            var mapHeight = 20;

            CurrentScene = new Scene(20, 20);
            Units = new List<Unit>()
            {
                new Unit(random.Next(mapWidth), random.Next(mapHeight), "☻"),
                new Unit(random.Next(mapWidth), random.Next(mapHeight), "☻"),
                new Unit(random.Next(mapWidth), random.Next(mapHeight), "☻"),
                new Unit(random.Next(mapWidth), random.Next(mapHeight), "☻"),
                new Unit(random.Next(mapWidth), random.Next(mapHeight), "☻")
            };
            PlayerUnit = new Unit(random.Next(mapWidth), random.Next(mapHeight), "☺");
        }

        public void ProcessKey(VirtualKey key)
        {
            switch (key)
            {
                case VirtualKey.DPadUp:
                    PlayerUnit.MoveUp(CurrentScene);
                    break;
                case VirtualKey.DPadDown:
                    PlayerUnit.MoveDown(CurrentScene);
                    break;
                case VirtualKey.DPadLeft:
                    PlayerUnit.MoveLeft(CurrentScene);
                    break;
                case VirtualKey.DPadRight:
                    PlayerUnit.MoveRight(CurrentScene);
                    break;
                case VirtualKey.Unknown:
                    LoadDemo();
                    break;
            }
        }
    }
}