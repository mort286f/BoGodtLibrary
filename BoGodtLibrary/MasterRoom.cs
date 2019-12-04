﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoGodtLibrary
{
    public abstract class MasterRoom : IMasterRoom
    {
        public abstract ERoomType GetRoomType();
        public abstract bool IsNew();
        public List<IMasterWindow> windows = new List<IMasterWindow>();
        public List<IMasterWindow> GetWindows()
        {
            return windows;
        }
        public List<IMasterDoor> doors = new List<IMasterDoor>();
        public List<IMasterDoor> GetDoors()
        {
            return doors;
        }
    }
}
