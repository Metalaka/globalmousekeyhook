﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Gma.System.MouseKeyHook
{
    public class KeyPressEventArgs : EventArgs
    {
        public char KeyChar { get; set; }
        public bool Handled { get; set; }

        public KeyPressEventArgs(char keyChar)
        {
            this.KeyChar = keyChar;
        }
    }
}
