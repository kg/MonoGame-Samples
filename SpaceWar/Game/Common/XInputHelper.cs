#region File Description
//-----------------------------------------------------------------------------
// XInputHelper.cs
//
// Microsoft XNA Community Game Platform
// Copyright (C) Microsoft Corporation. All rights reserved.
//-----------------------------------------------------------------------------
#endregion

#region Using Statements
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
#endregion

namespace Spacewar
{
    /// <summary>
    /// Provides a wrapper around the gamepads to allow single button presses to be detected
    /// </summary>
    public static class XInputHelper
    {
        /// <summary>
        /// Current pressed state of the gamepads
        /// </summary>
        private static GamePads gamePads = new GamePads();
        private static KeyboardState keyState;


        #region Properties
        public static GamePads GamePads
        {
            get
            {
                return gamePads;
            }
        }
        public static KeyboardState KeyState
        {
            get
            {
                return keyState;
            }
        }
        #endregion

        /// <summary>
        /// Update the state so presses can be detected - this should be called once per frame
        /// </summary>
        public static void Update(Game game)
        {
            keyState = Keyboard.GetState();
            gamePads.Update(game, keyState);
        }
    }
}
