using System.Collections.Generic;
using System.Windows.Forms;

namespace TheSurvivor.Source
{
    enum KeyEvent
    { 
        KEY_PRESSED,
        KEY_RELEASED
    }

    class Input
    {
        private Dictionary<Keys, KeyEvent> m_Keys = new Dictionary<Keys, KeyEvent>
        {
            { Keys.A,       KeyEvent.KEY_RELEASED },
            { Keys.D,       KeyEvent.KEY_RELEASED },
        };

        // Set a specific key to the pressed key state
        public void SetKeyPressed(Keys key)
        {
            m_Keys[key] = KeyEvent.KEY_PRESSED;
        }

        // Set a specific key to the released key state
        public void SetKeyReleased(Keys key)
        {
            m_Keys[key] = KeyEvent.KEY_RELEASED;
        }

        // Checks if a specific key is currently being pressed
        public bool IsKeyPressed(Keys key)
        {
            return m_Keys[key] == KeyEvent.KEY_PRESSED;
        }
    }
}
