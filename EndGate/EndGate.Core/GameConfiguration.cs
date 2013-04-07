﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EndGate.Core.Utilities;

namespace EndGate.Core
{
    public class GameConfiguration
    {
        private const int DefaultUpdateRate = 40;

        private Action<int> _updateRateSetter;
        private int _savedUpdateRate;

        public GameConfiguration(Action<int> updateRateSetter)
        {
            _updateRateSetter = updateRateSetter;

            UpdateRate = DefaultUpdateRate;
        }

        public int UpdateRate
        {
            get
            {
                return _savedUpdateRate;
            }
            set
            {
                _savedUpdateRate = value;
                _updateRateSetter(_savedUpdateRate);
            }
        }
    }
}